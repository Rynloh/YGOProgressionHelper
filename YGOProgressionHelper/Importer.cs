using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YGOProgressionHelper
{
    class Importer
    {
        private string ydkPath;
        private string csvPath;

        public Importer(string ydkPath, string csvPath)
        {
            this.ydkPath = ydkPath;
            this.csvPath = csvPath;

            // Create CSV File if it doesn't exist.
            if (!System.IO.File.Exists(csvPath))
            {
                System.IO.StreamWriter file = System.IO.File.CreateText(csvPath);
                file.Close();
            }
        }

        public bool verifyYDKPath()
        {
            return System.IO.File.Exists(this.ydkPath);
        }

        private Dictionary<int, YGOCard> readCSV()
        {
            return CSVReader.readCSVFile(csvPath);
        }

        private List<YDKEntry> readYDK()
        {
            return YDKReader.readYDKFile(ydkPath);
        }

        public string import()
        {
            Dictionary<int, YGOCard> cardDict;
            try
            {
                cardDict = readCSV();
            }
            catch
            {
                return "Failed to read CSV File!";
            }

            List<YDKEntry> ydkList;
            try
            {
                ydkList = readYDK();
            }
            catch
            {
                return "Failed to Read YDK File!";
            }

            // For each entry in ydklist, if in dictionary add to count, else add to list to look up with api.
            Dictionary<int, int> lookupDict = new Dictionary<int, int>();
            foreach (YDKEntry entry in ydkList)
            {
                if (cardDict.ContainsKey(entry.ID))
                {
                    cardDict[entry.ID].count++;
                }
                else if (lookupDict.ContainsKey(entry.ID))
                {
                    lookupDict[entry.ID]++;
                }
                else
                {
                    lookupDict.Add(entry.ID, 1);
                }
            }

            // If there are cards to lookup from the API
            if (lookupDict.Count > 0)
            {
                CardList lookupList = YGOAPI.lookupCards(lookupDict.Keys.ToList());
                // Set the count of each of the cards that was just looked up.
                // And add to the card dictionary
                foreach (YGOCard card in lookupList.data)
                {
                    card.count = lookupDict[card.id];
                    cardDict.Add(card.id, card);
                }
            }

            try
            {
                CSVWriter.writeCSV(cardDict.Values.ToList(), csvPath);
            }
            catch
            {
                return "Failed to Write CSV File!";
            }
            return "Import Successful!";
        }
    }
}

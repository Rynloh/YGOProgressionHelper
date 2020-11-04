using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YGOProgressionHelper
{
    class CSVWriter
    {
        public static void writeCSV(List<YGOCard> cards, string csvPath)
        {
            // Create backup of csv file
            string backupPath = csvPath + ".backup";
            System.IO.File.Copy(csvPath, backupPath);

            // Write each card to the csv file line by line.
            System.IO.StreamWriter file = System.IO.File.CreateText(csvPath);
            foreach (YGOCard card in cards)
            {
                file.WriteLine(card.toCSVLine());
            }
            file.Close();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YGOProgressionHelper
{
    class CSVReader
    {
        public static Dictionary<int, YGOCard> readCSVFile(string csvPath)
        {
            Dictionary<int, YGOCard> output = new Dictionary<int, YGOCard>();

            System.IO.StreamReader file =
                new System.IO.StreamReader(csvPath);

            string line = "";
            while ((line = file.ReadLine()) != null)
            {
                string[] tokens = line.Split('|');
                int ID = int.Parse(tokens[0]);
                if (output.ContainsKey(ID)) {
                    output[ID].count++;
                } 
                else
                {
                    output.Add(ID, YGOCard.fromTokens(tokens));
                }
            }

            return output;
        }
    }
}

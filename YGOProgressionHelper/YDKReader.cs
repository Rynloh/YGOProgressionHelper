using System;
using System.Collections.Generic;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YGOProgressionHelper
{
    public static class YDKReader
    {
        public static List<YDKEntry> readYDKFile(string ydkPath)
        {
            List<YDKEntry> output = new List<YDKEntry>();

            System.IO.StreamReader file =
                new System.IO.StreamReader(ydkPath);

            string line = "";
            while((line = file.ReadLine()) != null)
            {
                string trimmed = line.Trim();
                if (!trimmed.StartsWith("#") && !trimmed.StartsWith("!"))
                {
                    output.Add(new YDKEntry(int.Parse(trimmed)));
                }
            }

            file.Close();

            return output;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YGOProgressionHelper
{
    public class YDKEntry
    {
        public YDKEntry(int id)
        {
            this.ID = id;
        }

        public override string ToString()
        {
            return ID.ToString();
        }

        public int ID { get; set; }
    }
}

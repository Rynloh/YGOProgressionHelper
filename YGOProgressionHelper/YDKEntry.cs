using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YGOProgressionHelper
{
    public class YDKEntry
    {
        public YDKEntry(string id)
        {
            this.ID = id;
        }

        public override string ToString()
        {
            return ID;
        }

        public string ID
        {
            get => id;
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                    throw new ArgumentException("ID must not be blank");
                id = value.Trim();
            }
        }
        private string id;
    }
}

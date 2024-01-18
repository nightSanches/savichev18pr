using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace savichev18pr.Classes
{
    public class Format
    {
        public int id { get; set; }
        public string format { get; set; }
        public string description { get; set; }

        public Format(int id, string format, string description)
        {
            this.id = id;
            this.format = format;
            this.description = description;
        }

        public static List<Format> AllFormats()
        {
            List<Format> allFormat = new List<Format>();

            allFormat.Add(new Format(1, "A4", ""));
            allFormat.Add(new Format(2, "A3", ""));
            allFormat.Add(new Format(3, "A2", ""));
            allFormat.Add(new Format(4, "A1", ""));

            return allFormat;
        }
    }
}

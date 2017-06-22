using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitTest_Examples_1
{
    public class Ortschaft
    {
        public Ortschaft(int postleitzahl, string ortsname, string ortsteil)
        {
            Postleitzahl = postleitzahl;
            Ortsname = ortsname;

            if (!string.IsNullOrEmpty(ortsteil))
                Ortsteil = ortsteil;

        }
        public int Postleitzahl { get; private set; }
        public string Ortsname { get; private set; }
        public string Ortsteil { get; private set; }
    }
}

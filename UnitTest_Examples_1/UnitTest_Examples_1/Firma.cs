using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitTest_Examples_1
{
    public class Firma
    {
        string m_straße;
        int m_hausnummer;
        Ortschaft m_ort;

        public Firma(string name, string straße, int hausnummer, Ortschaft sitz)
        {
            this.FirmenName = name;
            this.m_straße = straße;
            this.m_hausnummer = hausnummer;
            this.m_ort = sitz;
        }
        public string FirmenName { get; private set; }



        public override string ToString()
        {
            string ortsteilTemp = "";

            if (!string.IsNullOrEmpty(m_ort.Ortsteil))
                ortsteilTemp = string.Format("({0})", m_ort.Ortsteil);

            string result = string.Format("{0}, \r\n{1} {2}, \r\n{3} {4}{5}",
                FirmenName, m_straße, m_hausnummer, m_ort.Postleitzahl, m_ort.Ortsname, ortsteilTemp);

            return result;
        }
    }
}

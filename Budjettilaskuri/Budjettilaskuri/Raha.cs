using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Budjettilaskuri
{
    public class Raha
    {
        public string Nimi { get; set; } = "";
        public double Määrä { get; set; }
        public bool Toistuva { get; set; } = false;
        public bool Poistettava { get; set; } = true;

        public Raha() { }

        public Raha(string nimi, double määrä)
        {
            Nimi = nimi;

            if (määrä > 0)
            {
                Määrä = määrä;
            }
            else
            {
                Määrä = 0;
            }
        }

        public override string? ToString()
        {
            return Nimi;
        }
    }
}

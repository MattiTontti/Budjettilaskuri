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
        public Raha()
        {

        }
        public Raha(string nimi, double määrä)
        {
            Nimi = nimi;
            Määrä = määrä;
        }

        public override string? ToString()
        {
            return Nimi;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Budjettilaskuri
{
    internal class Raha
    {
        public string Nimi { get; set; } = "";
        public double Määrä { get; set; }

        public Raha(string nimi, double määrä)
        {
            Nimi = nimi;
            Määrä = määrä;
        }

        public override string? ToString()
        {
            return $"{Nimi}: {Määrä:f2} €";
        }
    }
}

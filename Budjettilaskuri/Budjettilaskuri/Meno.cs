using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Budjettilaskuri
{
    internal class Meno
    {
        public string Nimi { get; set; }
        public double Määrä { get; set; }
        public override string? ToString()
        {
            return $"{Nimi}: {Määrä:f2} €";
        }
    }
}

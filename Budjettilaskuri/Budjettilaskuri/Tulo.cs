using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Budjettilaskuri
{
    internal class Tulo : Raha
    {
        public Tulo(string nimi, double määrä)
        {
            Nimi = nimi;
            Määrä = määrä;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Budjettilaskuri
{
    public class Meno : Raha
    {
        public Meno(string nimi, double määrä) : base(nimi, määrä) { }

        public Meno() { }
    }
}

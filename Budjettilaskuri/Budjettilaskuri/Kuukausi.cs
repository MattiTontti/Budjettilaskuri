using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Budjettilaskuri
{
    internal class Kuukausi
    {
        public List<Meno> menot;
        public List<Tulo> tulot;
        internal double KokoMenot()
        {
            double d = 0;
            foreach (Meno m in menot)
            {
                d += m.Määrä;
            }
            return d;
        }
        internal double KokoTulot()
        {
            double d = 0;
            foreach (Tulo t in tulot)
            {
                d += t.Määrä;
            }
            return d;
        }
    }
}

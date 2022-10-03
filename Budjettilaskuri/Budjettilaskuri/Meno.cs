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
        public Meno()
        {

        }
        public void OlemassaCheck(Vuosi vuosi)
        {
            foreach (Kuukausi kk in vuosi.Kuukaudet)
            {
                if (kk.OnkoMeno(this.Nimi))
                {
                    Olemassa.Add(true);
                }
                else
                {
                    Olemassa.Add(false);
                }
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Budjettilaskuri
{
    public class Tulo : Raha
    {
        public Tulo(string nimi, double määrä) : base(nimi, määrä) { }
        public Tulo()
        {

        }
        public void OlemassaCheck(Vuosi vuosi)
        {
            foreach (Kuukausi kk in vuosi.Kuukaudet)
            {
                if (kk.OnkoTulo(this.Nimi))
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

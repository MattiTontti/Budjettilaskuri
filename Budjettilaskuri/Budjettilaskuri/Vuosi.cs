using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace Budjettilaskuri
{
    public class Vuosi
    {
        public int Numero { get; set; }
        public List<Kuukausi> Kuukaudet { get; set; }
        public DateTime dt = DateTime.Now;
        public Vuosi()
        {
            Numero = 2022;
            Kuukaudet = new List<Kuukausi>();
            for (int i = 0; i < 12; i++)
            {
                Kuukaudet.Add(new Kuukausi(i + 1));
            }
        }

        public Vuosi(int numero)
        {
            Numero = numero;
            Kuukaudet = new List<Kuukausi>();
            for (int i = 0; i < 12; i++)
            {
                Kuukaudet.Add(new Kuukausi(i + 1));
            }
        }
        /// <summary>
        /// Hakee nykykuukauden
        /// </summary>
        /// <returns>Nykykuukausi</returns>
        internal Kuukausi NykyKuukausi()
        {
            return Kuukaudet[dt.Month - 1];
        }
        /// <summary>
        /// Hakee edellisen kuukauden
        /// </summary>
        /// <returns>Edellinen kuukausi</returns>
        internal Kuukausi EdellinenKuukausi()
        {
            return Kuukaudet[dt.Month - 2];
        }
        /// <summary>
        /// Laskee vuoden koko menot
        /// </summary>
        /// <returns>Vuoden menot</returns>
        internal double KokoMenot()
        {
            double menot = 0;
            foreach (Kuukausi kk in Kuukaudet)
            {
                menot += kk.KokoMenot();
            }
            return menot;
        }
        /// <summary>
        /// Laskee vuoden koko tulot
        /// </summary>
        /// <returns>Vuoden tulot</returns>
        internal double KokoTulot()
        {
            double tulot = 0;
            foreach (Kuukausi kk in Kuukaudet)
            {
                tulot += kk.KokoTulot();
            }
            return tulot;
        }
        /// <summary>
        /// Laskee vuoden tulojen ja menojen erotuksen
        /// </summary>
        /// <returns>Tulojen ja menojen erotus</returns>
        internal double Erotus()
        {
            return KokoTulot() - KokoMenot();
        }

        /// <summary>
        /// Lisää toistuva meno
        /// </summary>
        /// <param name="meno"></param>
        internal void ToistuvaMeno(Meno meno)
        {
            meno.OlemassaCheck(this);
            foreach (Kuukausi kk in Kuukaudet)
            {
                if (!kk.OnkoMeno(meno.Nimi))
                {
                    kk.LisääMeno(meno);
                }
                else
                {
                    kk.MuokkaaMeno(meno.Nimi, meno.Määrä);
                }
                kk.Menot[kk.Menot.IndexOf(kk.HaeMeno(meno.Nimi))].Toistuva = true;
            }
        }

        /// <summary>
        /// Lisää toistuva tulo
        /// </summary>
        /// <param name="tulo"></param>
        internal void ToistuvaTulo(Tulo tulo)
        {
            tulo.OlemassaCheck(this);
            foreach (Kuukausi kk in Kuukaudet)
            {
                if (!kk.OnkoTulo(tulo.Nimi))
                {
                    kk.LisääTulo(tulo);
                }
                else
                {
                    kk.MuokkaaTulo(tulo.Nimi, tulo.Määrä);
                }
                kk.Tulot[kk.Tulot.IndexOf(kk.HaeTulo(tulo.Nimi))].Toistuva = true;
            }
        }

        /// <summary>
        /// Poistaa menon muista kuukauksista
        /// </summary>
        /// <param name="meno"></param>
        /// <param name="kuukausi"></param>
        internal void EiToistuvaMeno(Meno meno, Kuukausi kuukausi)
        {
            if (meno.Olemassa.Count > 0)
            {
                for (int i = 0; i < 12; i++)
                {
                    if (Kuukaudet[i].Nimi != kuukausi.Nimi && (meno.Olemassa[i] == false || Kuukaudet[i].Menot[Kuukaudet[i].Menot.IndexOf(Kuukaudet[i].HaeMeno(meno.Nimi))].Määrä == 0) && Kuukaudet[i].Menot[Kuukaudet[i].Menot.IndexOf(Kuukaudet[i].HaeMeno(meno.Nimi))].Poistettava == true)
                    {
                        Kuukaudet[i].Menot.RemoveAt(Kuukaudet[i].Menot.IndexOf(Kuukaudet[i].HaeMeno(meno.Nimi)));
                    }
                    else
                    {
                        Kuukaudet[i].Menot[Kuukaudet[i].Menot.IndexOf(Kuukaudet[i].HaeMeno(meno.Nimi))].Toistuva = false;
                    }
                }
            }
            else
            {
                foreach (Kuukausi kk in Kuukaudet)
                {
                    if (kk.Nimi != kuukausi.Nimi)
                    {
                        kk.Menot.RemoveAt(kk.Menot.IndexOf(kk.HaeMeno(meno.Nimi)));
                    }
                    else
                    {
                        kk.Menot[kk.Menot.IndexOf(kk.HaeMeno(meno.Nimi))].Toistuva = false;
                    }
                }
            }
        }

        /// <summary>
        /// Poistaa tulon muista kuukauksista
        /// </summary>
        /// <param name="tulo"></param>
        /// <param name="kuukausi"></param>
        internal void EiToistuvaTulo(Tulo tulo, Kuukausi kuukausi)
        {
            {
                if (tulo.Olemassa.Count > 0)
                {
                    for (int i = 0; i < 12; i++)
                    {
                        if (Kuukaudet[i].Nimi != kuukausi.Nimi && (tulo.Olemassa[i] == false || Kuukaudet[i].Tulot[Kuukaudet[i].Tulot.IndexOf(Kuukaudet[i].HaeTulo(tulo.Nimi))].Määrä == 0) && Kuukaudet[i].Tulot[Kuukaudet[i].Tulot.IndexOf(Kuukaudet[i].HaeTulo(tulo.Nimi))].Poistettava == true)
                        {
                            Kuukaudet[i].Tulot.RemoveAt(Kuukaudet[i].Tulot.IndexOf(Kuukaudet[i].HaeTulo(tulo.Nimi)));
                        }
                        else
                        {
                            Kuukaudet[i].Tulot[Kuukaudet[i].Tulot.IndexOf(Kuukaudet[i].HaeTulo(tulo.Nimi))].Toistuva = false;
                        }
                    }
                }
                else
                {
                    foreach (Kuukausi kk in Kuukaudet)
                    {
                        if (kk.Nimi != kuukausi.Nimi)
                        {
                            kk.Tulot.RemoveAt(kk.Tulot.IndexOf(kk.HaeTulo(tulo.Nimi)));
                        }
                        else
                        {
                            kk.Tulot[kk.Tulot.IndexOf(kk.HaeTulo(tulo.Nimi))].Toistuva = false;
                        }
                    }
                }
            }
        }

        internal Kuukausi HaeKuukausi(string kuukausi)
        {
            Kuukausi returnKK = new Kuukausi();
            foreach (Kuukausi kk in Kuukaudet)
            {
                if (kk.Nimi == kuukausi)
                {
                    returnKK = kk;
                }
            }
            return returnKK;
        }
    }
}

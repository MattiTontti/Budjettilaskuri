using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Budjettilaskuri
{
    internal class Vuosi
    {
        public int Numero { get; set; }
        public List<Kuukausi> Kuukaudet { get; set; }
        DateTime dt = DateTime.Now;
        public Vuosi(int num)
        {
            Numero = num;
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

    }
}

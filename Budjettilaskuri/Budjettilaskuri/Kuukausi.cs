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
        public List<Meno> Menot { get; set; } = new List<Meno>();
        public List<Tulo> Tulot { get; set; } = new List<Tulo>();
        internal string Nimi { get; set; }
        public Kuukausi(int numero)
        {
            switch (numero)
            {
                case 1: Nimi = "tammikuu"; break;
                case 2: Nimi = "helmikuu"; break;
                case 3: Nimi = "maaliskuu"; break;
                case 4: Nimi = "huhtikuu"; break;
                case 5: Nimi = "toukokuu"; break;
                case 6: Nimi = "kesäkuu"; break;
                case 7: Nimi = "heinäkuu"; break;
                case 8: Nimi = "elokuu"; break;
                case 9: Nimi = "syyskuu"; break;
                case 10: Nimi = "lokakuu"; break;
                case 11: Nimi = "marraskuu"; break;
                case 12: Nimi = "joulukuu"; break;
                default: Nimi = ""; break;
            }

        }
        /// <summary>
        /// Laskee kuukauden menot
        /// </summary>
        /// <returns>Menot</returns>
        internal double KokoMenot()
        {
            double d = 0;
            foreach (Meno m in Menot)
            {
                d += m.Määrä;
            }
            return d;
        }
        /// <summary>
        /// Laskee kuukauden tulot
        /// </summary>
        /// <returns>Tulot</returns>
        internal double KokoTulot()
        {
            double d = 0;
            foreach (Tulo t in Tulot)
            {
                d += t.Määrä;
            }
            return d;
        }
        /// <summary>
        /// Lisää uuden tulon
        /// </summary>
        /// <param name="t"></param>
        internal void LisääTulo(Tulo t)
        {
            Tulot.Add(t);
        }
        /// <summary>
        /// Lisää uuden menon
        /// </summary>
        /// <param name="m"></param>
        internal void LisääMeno(Meno m)
        {
            Menot.Add(m);
        }
        /// <summary>
        /// Laskee tulojen ja menojen erotuksen
        /// </summary>
        /// <returns>Tulojen ja menojen erotus</returns>
        internal double Erotus()
        {
            return KokoTulot() - KokoMenot();
        }
    }
}

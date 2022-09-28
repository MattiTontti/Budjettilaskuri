using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Budjettilaskuri
{

    public class Kuukausi
    {
        public List<Meno> Menot { get; set; } = new List<Meno>();
        public List<Tulo> Tulot { get; set; } = new List<Tulo>();
        public string Nimi { get; set; }
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
            Meno vuokralaina = new Meno("Vuokra / laina", 0);
            LisääMeno(vuokralaina);
            Meno sähkö = new Meno("Sähkö", 0);
            LisääMeno(sähkö);
            Meno vesi = new Meno("Vesi", 0);
            LisääMeno(vesi);
            Meno ruoka = new Meno("Ruoka", 0);
            LisääMeno(ruoka);
            Meno matkakulut = new Meno("Matkakulut", 0);
            LisääMeno(matkakulut);
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
        /// <param name="tulo"></param>
        internal void LisääTulo(Tulo tulo)
        {
            Tulot.Add(tulo);
        }
        /// <summary>
        /// Lisää uuden tulon
        /// </summary>
        /// <param name="nimi"></param>
        /// <param name="määrä"></param>
        internal void LisääTulo(string nimi, double määrä)
        {
            Tulot.Add(new Tulo(nimi, määrä));
        }

        /// <summary>
        /// Lisää uuden menon
        /// </summary>
        /// <param name="meno"></param>
        internal void LisääMeno(Meno meno)
        {
            Menot.Add(meno);
        }

        /// <summary>
        /// Lisää uuden menon
        /// </summary>
        /// <param name="nimi"></param>
        /// <param name="määrä"></param>
        internal void LisääMeno(string nimi, double määrä)
        {
            Menot.Add(new Meno(nimi, määrä));
        }
        /// <summary>
        /// Laskee tulojen ja menojen erotuksen
        /// </summary>
        /// <returns>Tulojen ja menojen erotus</returns>
        internal double Erotus()
        {
            return KokoTulot() - KokoMenot();
        }
        /// <summary>
        /// Muokkaa meno
        /// </summary>
        /// <param name="meno"></param>
        /// <param name="määrä"></param>
        internal void MuokkaaMeno(string meno, double määrä)
        {
            foreach (Meno m in Menot)
            {
                if (m.Nimi == meno)
                {
                    m.Määrä = määrä;
                    break;
                }
            }
        }

        /// <summary>
        /// Muokkaa tulo
        /// </summary>
        /// <param name="tulo"></param>
        /// <param name="määrä"></param>
        internal void MuokkaaTulo(string tulo, double määrä)
        {
            foreach (Tulo t in Tulot)
            {
                if (t.Nimi == tulo)
                {
                    t.Määrä = määrä;
                    break;
                }
            }
        }
    }
}

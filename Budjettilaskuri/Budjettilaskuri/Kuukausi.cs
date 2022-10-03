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
        public Kuukausi()
        {

        }
        public Kuukausi(int numero)
        {
            switch (numero)
            {
                case 1: Nimi = "Tammikuu"; break;
                case 2: Nimi = "Helmikuu"; break;
                case 3: Nimi = "Maaliskuu"; break;
                case 4: Nimi = "Huhtikuu"; break;
                case 5: Nimi = "Toukokuu"; break;
                case 6: Nimi = "Kesäkuu"; break;
                case 7: Nimi = "Heinäkuu"; break;
                case 8: Nimi = "Elokuu"; break;
                case 9: Nimi = "Syyskuu"; break;
                case 10: Nimi = "Lokakuu"; break;
                case 11: Nimi = "Marraskuu"; break;
                case 12: Nimi = "Joulukuu"; break;
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

        /// <summary>
        /// Onko tämän niminen meno olemassa
        /// </summary>
        /// <param name="meno"></param>
        /// <returns>true/false</returns>
        internal bool OnkoMeno(string meno)
        {
            bool returnBool = false;
            foreach (Meno m in Menot)
            {
                if (m.Nimi == meno)
                {
                    returnBool = true;
                    break;
                }
            }
            return returnBool;
        }

        /// <summary>
        /// Onko tämän niminen tulo olemassa
        /// </summary>
        /// <param name="tulo"></param>
        /// <returns>true/false</returns>
        internal bool OnkoTulo(string tulo)
        {
            bool returnBool = false;
            foreach (Tulo t in Tulot)
            {
                if (t.Nimi == tulo)
                {
                    returnBool = true;
                    break;
                }
            }
            return returnBool;
        }

        /// <summary>
        /// Hakee menon
        /// </summary>
        /// <param name="meno"></param>
        /// <returns>Haettu meno</returns>
        internal Meno HaeMeno(string meno)
        {
            Meno returnMeno = new Meno();
            foreach (Meno m in Menot)
            {
                if (m.Nimi == meno)
                {
                    returnMeno = m;
                    break;
                }
            }
            return returnMeno;
        }

        /// <summary>
        /// Hakee tulon
        /// </summary>
        /// <param name="tulo"></param>
        /// <returns>Haettu tulo</returns>
        internal Tulo HaeTulo(string tulo)
        {
            Tulo returnTulo = new Tulo();
            foreach (Tulo t in Tulot)
            {
                if (t.Nimi == tulo)
                {
                    returnTulo = t;
                    break;
                }
            }
            return returnTulo;
        }
    }
}

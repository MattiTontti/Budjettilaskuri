using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace Budjettilaskuri
{
    /// <summary>
    /// Interaction logic for Vedenkulutus.xaml
    /// </summary>
    public partial class Vedenkulutus : Window
    {
        public double VesiKKKMäärä;
        public double EdellKKKMäärä;
        Kuukausi kk;
        public Vedenkulutus(Kuukausi kuukausi, Kuukausi edelkuukausi)
        {
            InitializeComponent();

            VesiKKKMäärä = kuukausi.Vedenkulutus;
            VesiKKK.Text = VesiKKKMäärä.ToString();
            EdellKKKMäärä = edelkuukausi.Vedenkulutus;
            EdellKKK.Text = EdellKKKMäärä.ToString();
        }
        public Vedenkulutus(Kuukausi kuukausi)
        {
            InitializeComponent();

            VesiKKKMäärä = kuukausi.Vedenkulutus;
            VesiKKK.Text = VesiKKKMäärä.ToString();
        }

        private void VesiKKK_TextChanged(object sender, TextChangedEventArgs e)
        {
            double määrä;
            if (double.TryParse(VesiKKK.Text, out määrä))
            {
                VesiKKKMäärä = määrä;
                KuukaudenKulutus.Text = (VesiKKKMäärä - EdellKKKMäärä).ToString();
            }

        }

        private void EdellKKK_TextChanged(object sender, TextChangedEventArgs e)
        {
            double määrä;
            if (double.TryParse(EdellKKK.Text, out määrä))
            {
                EdellKKKMäärä = määrä;
                KuukaudenKulutus.Text = (VesiKKKMäärä - EdellKKKMäärä).ToString();
            }
        }
    }
}

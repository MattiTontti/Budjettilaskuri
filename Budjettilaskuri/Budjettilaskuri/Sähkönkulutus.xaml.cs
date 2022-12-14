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
    /// Interaction logic for Sähkönkulutus.xaml
    /// </summary>
    public partial class Sähkönkulutus : Window
    {
        double KulutusMäärä = 0;
        double SiirtoMäärä = 0;
        double KäyttöMäärä = 0;

        public Sähkönkulutus()
        {
            InitializeComponent();
        }

        private void Skulutus_TextChanged(object sender, TextChangedEventArgs e)
        {
            double määrä;

            if (double.TryParse(kWh.Text, out määrä))
            {
                if (määrä > 0)
                {
                    KulutusMäärä = määrä;
                }
                MaksutYht.Text = Math.Round((SiirtoMäärä + KäyttöMäärä) / KulutusMäärä, 2).ToString();
            }
        }

        private void SyötäKäyttöM_TextChanged(object sender, TextChangedEventArgs e)
        {
            double määrä;

            if (double.TryParse(SyötäKäyttöM.Text, out määrä))
            {
                if (määrä > 0)
                {
                    KäyttöMäärä = määrä;
                }
                else
                {
                    KäyttöMäärä = 0;
                }

                MaksutYht.Text = Math.Round((SiirtoMäärä + KäyttöMäärä) / KulutusMäärä, 2).ToString();            
            }
        }

        private void SyötäSiirtoM_TextChanged(object sender, TextChangedEventArgs e)
        {
            double määrä;

            if (double.TryParse(SyötäSiirtoM.Text, out määrä))
            {
                if (määrä > 0)
                {
                    SiirtoMäärä = määrä;
                }
                else
                {
                    SiirtoMäärä = 0;
                }

                MaksutYht.Text = Math.Round((SiirtoMäärä + KäyttöMäärä) / KulutusMäärä, 2).ToString();            
            }
        }

        private void hyvaksyButton_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }
    }
}

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
    /// Interaction logic for LisääIkkuna.xaml
    /// </summary>
    public partial class LisääWindow : Window
    {
        public Kuukausi kk;
        public Meno meno;
        public Tulo tulo;
        int i;
        public LisääWindow(Kuukausi kuukausi, int numero)
        {
            InitializeComponent();
            kk = kuukausi;
            i = numero;
        }
        public bool bcheck = false;
        private void Window_Closing(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if (bcheck)
            {
                double määrä = 0;
                if (i == 0)
                {
                    double.TryParse(määräText.Text, out määrä);
                    meno = new Meno(nimiText.Text, määrä);
                }
                else
                {
                    double.TryParse(määräText.Text, out määrä);
                    tulo = new Tulo(nimiText.Text, määrä);
                }
            }
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            bcheck = true;
            Close();
        }
    }
}

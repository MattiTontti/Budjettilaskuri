using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.IO;
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
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Text.Json;
using System.Reflection;

namespace Budjettilaskuri
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public static Vuosi vuosi = new Vuosi();

        public MainWindow()
        {
            InitializeComponent();

            if (File.Exists("vuosi.json"))
            {
                vuosi = JsonSerializer.Deserialize<Vuosi>(File.ReadAllText("vuosi.json"));
            }

            Kuukausi_Check();
            KuukausiMäärä_Kaikki();
        }


        private void Kuukausi_Check()
        {
            menotKK.Text = vuosi.NykyKuukausi().KokoMenot() + " €";
            tulotKK.Text = vuosi.NykyKuukausi().KokoTulot() + " €";
            menotEK.Text = vuosi.EdellinenKuukausi().KokoMenot() + " €";
            tulotEK.Text = vuosi.EdellinenKuukausi().KokoTulot() + " €";
            menotV.Text = vuosi.KokoMenot() + " €";
            tulotV.Text = vuosi.KokoTulot() + " €";
        }

        private void KuukausiMäärä_Check(TextBlock Kuukausi)
        {
            string s = vuosi.Kuukaudet[vuosi.Kuukaudet.IndexOf(vuosi.HaeKuukausi(Kuukausi.Name))].Erotus();
            Kuukausi.Text = s;

            if (s[0] == '-')
            {
                Kuukausi.Foreground = Brushes.Red;
            }
            else
            {
                Kuukausi.Foreground = Brushes.Green;
            }
        }

        private void KuukausiMäärä_Kaikki()
        {
            KuukausiMäärä_Check(Tammikuu);
            KuukausiMäärä_Check(Helmikuu);
            KuukausiMäärä_Check(Maaliskuu);
            KuukausiMäärä_Check(Huhtikuu);
            KuukausiMäärä_Check(Toukokuu);
            KuukausiMäärä_Check(Kesäkuu);
            KuukausiMäärä_Check(Heinäkuu);
            KuukausiMäärä_Check(Elokuu);
            KuukausiMäärä_Check(Syyskuu);
            KuukausiMäärä_Check(Lokakuu);
            KuukausiMäärä_Check(Marraskuu);
            KuukausiMäärä_Check(Joulukuu);
        }


        private void Window_Closing(object sender, System.ComponentModel.CancelEventArgs e)
        {
            string jsonString = JsonSerializer.Serialize(vuosi);
            File.WriteAllText("vuosi.json", jsonString);
        }

        private void KK_Click(object sender, RoutedEventArgs e)
        {
            int num = -1;

            switch((sender as Button).Content)
            {
                case "Tammikuu":
                    num = 0; break;
                case "Helmikuu":
                    num = 1; break;
                case "Maaliskuu":
                    num = 2; break;
                case "Huhtikuu":
                    num = 3; break;
                case "Toukokuu":
                    num = 4; break;
                case "Kesäkuu":
                    num = 5; break;
                case "Heinäkuu":
                    num = 6; break;
                case "Elokuu":
                    num = 7; break;
                case "Syyskuu":
                    num = 8; break;
                case "Lokakuu":
                    num = 9; break;
                case "Marraskuu":
                    num = 10; break;
                case "Joulukuu":
                    num = 11; break;

            }

            KuukausiWindow kkwindow = new KuukausiWindow(vuosi.Kuukaudet[num]);
            kkwindow.ShowDialog();
            Kuukausi_Check();
            KuukausiMäärä_Kaikki();
        }

        private void nollaaButton_Click(object sender, RoutedEventArgs e)
        {
            var m = MessageBox.Show("Haluatko varmasti nollata budjetin?", "Nollaa budjetti", MessageBoxButton.YesNo, MessageBoxImage.Question);

            if (m == MessageBoxResult.Yes)
            {
                vuosi = new Vuosi();
                Kuukausi_Check();
                KuukausiMäärä_Kaikki();
            }
        }
    }
}

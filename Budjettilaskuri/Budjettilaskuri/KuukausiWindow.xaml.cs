using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.Xml;
using System.Text;
using System.Text.Json;
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
    /// Interaction logic for KuukausiWindow.xaml
    /// </summary>
    public partial class KuukausiWindow : Window
    {
        public Kuukausi kuukausi;
        public KuukausiWindow(Kuukausi kk)
        {
            kuukausi = kk;
            InitializeComponent();
            Title = kk.Nimi;
            kuukausiNimi.Text = kk.Nimi;
            comboBox.ItemsSource = kuukausi.Menot;
            comboBox2.ItemsSource = kuukausi.Tulot;
            kokoMenot.Text = kuukausi.KokoMenot().ToString() + " €";
            kokoTulot.Text = kuukausi.KokoTulot().ToString() + " €";

            if (!(comboBox.SelectedItem as Meno).Poistettava)
            {
                poistaMenoButton.Visibility = Visibility.Hidden;
            }

            if (comboBox2.SelectedItem is Tulo && (comboBox2.SelectedItem as Tulo).Poistettava)
            {
                poistaTuloButton.Visibility = Visibility.Visible;
            }
            else
            {
                poistaTuloButton.Visibility = Visibility.Hidden;
            }

        }

        private void comboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (comboBox.SelectedItem is Meno)
            {
                menotBox.Text = (comboBox.SelectedItem as Meno).Määrä.ToString();
                if ((comboBox.SelectedItem as Meno).Toistuva)
                {
                    toistuvaCheck.IsChecked = true;
                }
                else
                {
                    toistuvaCheck.IsChecked = false;
                }

                if ((comboBox.SelectedItem as Meno).Poistettava)
                {
                    poistaMenoButton.Visibility = Visibility.Visible;
                }
                else
                {
                    poistaMenoButton.Visibility = Visibility.Hidden;
                }
            }
        }

        private void comboBox2_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (comboBox2.SelectedItem is Tulo)
            {
                tulotBox.Text = (comboBox2.SelectedItem as Tulo).Määrä.ToString();
                if ((comboBox2.SelectedItem as Tulo).Toistuva)
                {
                    toistuvaCheck2.IsChecked = true;
                }
                else
                {
                    toistuvaCheck.IsChecked = false;
                }

                if ((comboBox2.SelectedItem as Tulo).Poistettava)
                {
                    poistaTuloButton.Visibility = Visibility.Visible;
                }
                else
                {
                    poistaTuloButton.Visibility = Visibility.Hidden;
                }
            }
            if (comboBox2.SelectedItem == null)
            {
                poistaTuloButton.Visibility = Visibility.Hidden;
            }
        }

        private void menotBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            double määrä;
            if (double.TryParse(menotBox.Text, out määrä))
            {
                kuukausi.MuokkaaMeno(comboBox.SelectedItem.ToString(), määrä);
            }
            if (toistuvaCheck.IsChecked == true)
            {
                MainWindow.vuosi.ToistuvaMeno((Meno)comboBox.SelectedItem);
            }
            kokoMenot.Text = kuukausi.KokoMenot().ToString() + " €";
        }
        public bool addcheck = false;
        private void lisääMeno_Click(object sender, RoutedEventArgs e)
        {
            LisääWindow window = new LisääWindow(kuukausi, 0);
            window.ShowDialog();
            if (window.bcheck)
            {
                kuukausi.LisääMeno(window.meno);
                comboBox.ItemsSource = new List<string>();
                comboBox.ItemsSource = kuukausi.Menot;
                comboBox.SelectedIndex = kuukausi.Menot.Count - 1;
            }
        }

        private void lisääTulo_Click(object sender, RoutedEventArgs e)
        {
            LisääWindow window = new LisääWindow(kuukausi, 1);
            window.ShowDialog();
            if (window.bcheck)
            {
                kuukausi.LisääTulo(window.tulo);
                comboBox2.ItemsSource = new List<string>();
                comboBox2.ItemsSource = kuukausi.Tulot;
                comboBox2.SelectedIndex = kuukausi.Tulot.Count - 1;
            }
        }

        private void tulotBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            double määrä;
            if (double.TryParse(tulotBox.Text, out määrä))
            {
                kuukausi.MuokkaaTulo(comboBox2.SelectedItem.ToString(), määrä);
            }
            if (toistuvaCheck2.IsChecked == true)
            {
                MainWindow.vuosi.ToistuvaTulo((Tulo)comboBox.SelectedItem);
            }
            kokoTulot.Text = kuukausi.KokoTulot().ToString() + " €";
        }

        private void toistuvaCheck_Checked(object sender, RoutedEventArgs e)
        {
            MainWindow.vuosi.ToistuvaMeno((Meno)comboBox.SelectedItem);
        }

        private void toistuvaCheck2_Checked(object sender, RoutedEventArgs e)
        {
            MainWindow.vuosi.ToistuvaTulo((Tulo)comboBox2.SelectedItem);
        }

        private void toistuvaCheck_Unchecked(object sender, RoutedEventArgs e)
        {
            MainWindow.vuosi.EiToistuvaMeno((Meno)comboBox.SelectedItem, MainWindow.vuosi.Kuukaudet[MainWindow.vuosi.Kuukaudet.IndexOf(MainWindow.vuosi.HaeKuukausi(kuukausi.Nimi))]);
        }

        private void toistuvaCheck2_Unchecked(object sender, RoutedEventArgs e)
        {
            MainWindow.vuosi.EiToistuvaTulo((Tulo)comboBox2.SelectedItem, MainWindow.vuosi.Kuukaudet[MainWindow.vuosi.Kuukaudet.IndexOf(MainWindow.vuosi.HaeKuukausi(kuukausi.Nimi))]);
        }

        private void poistaMeno(object sender, RoutedEventArgs e)
        {
            var m = MessageBox.Show("Poista meno?", "Poista meno", MessageBoxButton.YesNo, MessageBoxImage.Question);
            if (m == MessageBoxResult.Yes)
            {
                int index = comboBox.SelectedIndex;
                kuukausi.Menot.Remove((Meno)comboBox.SelectedItem);
                comboBox.ItemsSource = new List<string>();
                comboBox.ItemsSource = kuukausi.Menot;
                comboBox.SelectedIndex = index;
            }
        }

        private void poistaTulo(object sender, RoutedEventArgs e)
        {
            var m = MessageBox.Show("Poista tulo?", "Poista tulo", MessageBoxButton.YesNo, MessageBoxImage.Question);
            if (m == MessageBoxResult.Yes)
            {
                int index = comboBox2.SelectedIndex;
                kuukausi.Tulot.Remove((Tulo)comboBox2.SelectedItem);
                comboBox2.ItemsSource = new List<string>();
                comboBox2.ItemsSource = kuukausi.Tulot;
                comboBox2.SelectedIndex = index;
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
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
        public KuukausiWindow(Kuukausi kk)
        {
            InitializeComponent();
            Title = kk.Nimi;
            comboBox.ItemsSource = kk.Menot;
            comboBox2.ItemsSource = kk.Tulot;
        }

        private void comboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            menotBox.Text = (comboBox.SelectedItem as Meno).Määrä.ToString();
        }

        private void comboBox2_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            menotBox.Text = (comboBox.SelectedItem as Tulo).Määrä.ToString();
        }
    }
}

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

namespace Budjettilaskuri
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        Vuosi vuosi = new Vuosi();
        public MainWindow()
        {
            InitializeComponent();
            if (File.Exists("vuosi.json"))
            {
                vuosi = JsonSerializer.Deserialize<Vuosi>(File.ReadAllText("vuosi.json"));
            }

            vuosi.NykyKuukausi().MuokkaaMeno("Vuokra / laina", 500);
            vuosi.NykyKuukausi().LisääMeno("Muut menot", 900);

            MessageBox.Show(vuosi.KokoMenot().ToString());  
            /*
            menotKk.Text = vuosi.NykyKuukausi().KokoMenot() + " €";
            tulotKk.Text = vuosi.NykyKuukausi().KokoTulot() + " €";
            menotEdellinen.Text = vuosi.EdellinenKuukausi().KokoMenot() + " €";
            tulotEdellinen.Text = vuosi.EdellinenKuukausi().KokoTulot() + " €";
            menotVuosi.Text = vuosi.KokoMenot() + " €";
            tulotVuosi.Text = vuosi.KokoTulot() + " €";
            */
        }

        private void Window_Closing(object sender, System.ComponentModel.CancelEventArgs e)
        {
            string jsonString = JsonSerializer.Serialize(vuosi);
            File.WriteAllText("vuosi.json", jsonString);
        }
    }
}

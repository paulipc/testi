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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace textbox
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        Lights Olohuone = new Lights();
        Lights Keittiö = new Lights();
        Sauna SaunanOhjaus = new Sauna();
        Thermostat TalonLämpö = new Thermostat();

        public MainWindow()
        {
            InitializeComponent();
            Olohuone.DimmerString = "";
            Olohuone.Switched = false;
            Keittiö.DimmerString = "";
            Keittiö.Switched = false;
            TalonLämpö.Temperature = 20;
        }

         private void radioButton_Checked(object sender, RoutedEventArgs e)
        {
            textBox.Text = "POIS";
            Olohuone.DimmerString = "0";
            Olohuone.Switched = false;
        }

        private void radioButton_HÄMÄRÄ_Checked(object sender, RoutedEventArgs e)
        {
            textBox.Text = "HÄMÄRÄ";
            Olohuone.DimmerString = "33";
            Olohuone.Switched = true;


        }

        private void radioButton_PUOLIVALOT_Checked(object sender, RoutedEventArgs e)
        {
            textBox.Text = "PUOLIVALOT";
            Olohuone.DimmerString = "66";
            Olohuone.Switched = true;


        }

        private void radioButton_KIRKAS_Checked(object sender, RoutedEventArgs e)
        {
            textBox.Text = "KIRKAS ";
            Olohuone.DimmerString = "100";
            Olohuone.Switched = true;

        }

        private void buttonSauna_Click(object sender, RoutedEventArgs e)
        {
            SaunanOhjaus.SaunaOn();

            if (SaunanOhjaus.Switched == true)
            {
                textBoxSauna.Text = "Sauna päällä";
            }
            else
            {
                textBoxSauna.Text = " ";
            }
        }

        private void buttonAsetaLämpötila_Click(object sender, RoutedEventArgs e)
        {
            int IntLämpötila = int.Parse(textBoxTavoiteLämpötila.Text);
          
            TalonLämpö.SetTemperature(IntLämpötila);
            textBoxLämpötila.Text = textBoxTavoiteLämpötila.Text;
            textBoxTavoiteLämpötila.Text = "";
        }

        private void radioButtonKeittiöPOIS_Checked(object sender, RoutedEventArgs e)
        {
            //textBoxKeittiö.Text = "POIS";
            Keittiö.DimmerString = "0";
            Keittiö.Switched = false;

        }

        private void radioButtonKeittiöPUOLIVALOT_Checked(object sender, RoutedEventArgs e)
        {
            textBoxKeittiö.Text = "PUOLIVALOT";
            Keittiö.DimmerString = "66";
            Keittiö.Switched = true;

        }

        private void radioButtonKeittiöKIRKAS_Checked(object sender, RoutedEventArgs e)
        {
            textBoxKeittiö.Text = "KIRKAS ";
            Keittiö.DimmerString = "100";
            Keittiö.Switched = true;

        }

        private void radioButton_Checked_1(object sender, RoutedEventArgs e)
        {

        }
    }
}

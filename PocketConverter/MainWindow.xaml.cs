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

namespace PocketConverter
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }


        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            cmb_Origine.SelectedIndex = 1; //metro
            cmb_Destinazione.SelectedIndex = 3; //centimetro
            cmbDestinazioneM.IsEnabled = false;

            txt_Origine.Text = "0";
            txt_Destinazione.Text = "0";
        }

        private void btn_Converti_Click(object sender, RoutedEventArgs e)
        {
            /*
                Chilometro = 0
                Metro = 1
                Decimetro = 2
                Centimetro = 3
                Millimetro = 4
             */
            if (cmb_Origine.SelectedIndex == 0) // Chilometro
            {
                switch (cmb_Destinazione.SelectedIndex)
                {
                    case 1:
                        txt_Destinazione.Text = Convert.ToString(Convert.ToDecimal(txt_Origine.Text) * 1000);
                        break;
                    case 2:
                        txt_Destinazione.Text = Convert.ToString(Convert.ToDecimal(txt_Origine.Text) * 10000);
                        break;
                    case 3:
                        txt_Destinazione.Text = Convert.ToString(Convert.ToDecimal(txt_Origine.Text) * 100000);
                        break;
                    case 4:
                        txt_Destinazione.Text = Convert.ToString(Convert.ToDecimal(txt_Origine.Text) * 1000000);
                        break;
                    default:
                        txt_Destinazione.Text = txt_Origine.Text;
                        break;
                }
            }
            else if (cmb_Origine.SelectedIndex == 1) // Metro
            {
                switch (cmb_Destinazione.SelectedIndex)
                {
                    case 0:
                        txt_Destinazione.Text = Convert.ToString(Convert.ToDecimal(txt_Origine.Text) / 1000);
                        break;
                    case 2:
                        txt_Destinazione.Text = Convert.ToString(Convert.ToDecimal(txt_Origine.Text) * 10);
                        break;
                    case 3:
                        txt_Destinazione.Text = Convert.ToString(Convert.ToDecimal(txt_Origine.Text) * 100);
                        break;
                    case 4:
                        txt_Destinazione.Text = Convert.ToString(Convert.ToDecimal(txt_Origine.Text) * 1000);
                        break;
                    default:
                        txt_Destinazione.Text = txt_Origine.Text;
                        break;
                }
            }
            else if (cmb_Origine.SelectedIndex == 2) // Decimetro
            {
                switch (cmb_Destinazione.SelectedIndex)
                {
                    case 0:
                        txt_Destinazione.Text = Convert.ToString(Convert.ToDecimal(txt_Origine.Text) / 10000);
                        break;
                    case 1:
                        txt_Destinazione.Text = Convert.ToString(Convert.ToDecimal(txt_Origine.Text) / 10);
                        break;
                    case 3:
                        txt_Destinazione.Text = Convert.ToString(Convert.ToDecimal(txt_Origine.Text) * 10);
                        break;
                    case 4:
                        txt_Destinazione.Text = Convert.ToString(Convert.ToDecimal(txt_Origine.Text) * 100);
                        break;
                    default:
                        txt_Destinazione.Text = txt_Origine.Text;
                        break;
                }
            }
            else if (cmb_Origine.SelectedIndex == 3) // Centimetro
            {
                switch (cmb_Destinazione.SelectedIndex)
                {
                    case 0:
                        txt_Destinazione.Text = Convert.ToString(Convert.ToDecimal(txt_Origine.Text) / 100000);
                        break;
                    case 1:
                        txt_Destinazione.Text = Convert.ToString(Convert.ToDecimal(txt_Origine.Text) / 100);
                        break;
                    case 2:
                        txt_Destinazione.Text = Convert.ToString(Convert.ToDecimal(txt_Origine.Text) / 10);
                        break;
                    case 4:
                        txt_Destinazione.Text = Convert.ToString(Convert.ToDecimal(txt_Origine.Text) * 10);
                        break;
                    default:
                        txt_Destinazione.Text = txt_Origine.Text;
                        break;
                }
            }
            else if (cmb_Origine.SelectedIndex == 4) // Millimetro
            {
                switch (cmb_Destinazione.SelectedIndex)
                {
                    case 0:
                        txt_Destinazione.Text = Convert.ToString(Convert.ToDecimal(txt_Origine.Text) / 1000000);
                        break;
                    case 1:
                        txt_Destinazione.Text = Convert.ToString(Convert.ToDecimal(txt_Origine.Text) / 1000);
                        break;
                    case 2:
                        txt_Destinazione.Text = Convert.ToString(Convert.ToDecimal(txt_Origine.Text) / 100);
                        break;
                    case 3:
                        txt_Destinazione.Text = Convert.ToString(Convert.ToDecimal(txt_Origine.Text) / 10);
                        break;
                    default:
                        txt_Destinazione.Text = txt_Origine.Text;
                        break;
                }
            }
            else
            {
                txt_Destinazione.Text = txt_Origine.Text;
            }
        }

        private void cmb_Origine_DropDownClosed(object sender, EventArgs e)
        {
            // serve per ingrigire un valore di origine o destinazione se uno è selezionato e NON cliccabile
            
            cmbDestinazioneKm.IsEnabled = true;
            cmbDestinazioneM.IsEnabled = true;
            cmbDestinazioneDm.IsEnabled = true;
            cmbDestinazioneCm.IsEnabled = true;
            cmbDestinazioneMm.IsEnabled = true;

            if (cmb_Origine.SelectedIndex == 0)
            {
                cmbDestinazioneKm.IsEnabled = false;
            }
            else if(cmb_Origine.SelectedIndex == 1)
            {
                cmbDestinazioneM.IsEnabled = false;
            }
            else if (cmb_Origine.SelectedIndex == 2)
            {
                cmbDestinazioneDm.IsEnabled = false;
            }
            else if (cmb_Origine.SelectedIndex == 3)
            {
                cmbDestinazioneCm.IsEnabled = false;
            }
            else if (cmb_Origine.SelectedIndex == 4)
            {
                cmbDestinazioneMm.IsEnabled = false;
            }

            if (cmb_Origine.SelectedIndex == cmb_Destinazione.SelectedIndex)
            {
                if (cmb_Destinazione.SelectedIndex == 0)
                {
                    cmb_Destinazione.SelectedIndex = 1;
                }
                else
                {
                    cmb_Destinazione.SelectedIndex = cmb_Destinazione.SelectedIndex - 1;
                }
            }
        }
    }
}

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

        private void Button_Click(object sender, RoutedEventArgs e)
        {

        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            cmb_Origine.SelectedIndex = 1;
            cmb_Destinazione.SelectedIndex = 3;
            //cmbDestinazioneM.IsEnabled = false;

            txt_Origine.Text = "0";
            txt_Destinazione.Text = "0";
        }

        private void btn_Converti_Click(object sender, RoutedEventArgs e)
        {

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
        }
    }
}

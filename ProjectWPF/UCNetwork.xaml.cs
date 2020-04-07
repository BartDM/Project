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

namespace ProjectWPF
{
    /// <summary>
    /// Interaction logic for UCNetwork.xaml
    /// </summary>
    public partial class UCNetwork : UserControl
    {
        public UCNetwork()
        {
            InitializeComponent();
        }
        private void UserControl_Loaded(object sender, RoutedEventArgs e)
        {
        }

            private void radVLAN_Checked(object sender, RoutedEventArgs e)
        {
            txtIp.Visibility = Visibility.Hidden;
            txtComputer.Visibility = Visibility.Hidden;
            txtMask.Visibility = Visibility.Hidden;
            txtVlan.Visibility = Visibility.Hidden;

            //txtVlan.Visibility= Visibility.Visible;
            txtVlanNr.Visibility = Visibility.Visible;
            txtVlanDescr.Visibility = Visibility.Visible;

        }

        private void radIP_Checked(object sender, RoutedEventArgs e)
        {
            txtVlanNr.Visibility = Visibility.Hidden;
            txtVlanDescr.Visibility = Visibility.Hidden;

            txtIp.Visibility = Visibility.Visible;
            txtMask.Visibility = Visibility.Visible;

            txtComputer.Visibility = Visibility.Visible;
            txtVlan.Visibility = Visibility.Visible;
        }
    }
}

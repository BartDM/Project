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
    /// Interaction logic for UCProducts.xaml
    /// </summary>
    public partial class UCProducts : UserControl
    {
        public UCProducts()
        {
            InitializeComponent();
        }
        private void UserControl_Loaded(object sender, RoutedEventArgs e)
        {
            cmbVendor.Items.Add("Microsoft");
            cmbVendor.Items.Add("Debian");
            cmbVendor.Items.Add("Apache");
            cmbVendor.Items.Add("RedHat");
        }
        private void radOS_Checked(object sender, RoutedEventArgs e)
        {
            //btnSearchProducts.Content = "Search OS";
        }

        private void radSoftware_Checked(object sender, RoutedEventArgs e)
        {
            //btnSearchProducts = "Search Software";
        }

        
    }
}

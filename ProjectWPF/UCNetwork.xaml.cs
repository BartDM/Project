using ProjectDAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
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

        Vlan vlan = null;
        Vlan vlan2 = null;
        NetworkInterface nwi = null;

            List<Vlan> vlanlijst = new List<Vlan>();
            List<NetworkInterface> nwilijst = new List<NetworkInterface>();

        private void UserControl_Loaded(object sender, RoutedEventArgs e)
        {
            //Test opvullen classeobject
            OpvullenVlanGrid();


            //ips
            nwi = new NetworkInterface
            {
                Vlan = vlan as Vlan,
                Name = NwiNames.PI1,
                Ip = IPAddress.Parse("192.168.1.3")
            };
            nwilijst.Add(nwi);

            nwi = new NetworkInterface
            {
                Vlan = vlan,
                Name = NwiNames.PI2,
                Ip = IPAddress.Parse("192.168.1.5")
            };
            nwilijst.Add(nwi);

            nwi = new NetworkInterface
            {
                Vlan = vlan2 as Vlan,
                Name = NwiNames.PI2,
                Ip = IPAddress.Parse("192.168.2.3")
            };
            nwilijst.Add(nwi);

            //nwi = new NetworkInterface();
            //nwi.Vlan = gridVlan.SelectedItem as Vlan;
            //nwi.Name = NwiNames.PI1;
            //nwi.Ip = IPAddress.Parse("192.168.2.2");
            //nwilijst.Add(nwi);



            
        }

        private void OpvullenVlanGrid()
        {
            vlan = new Vlan
            {
                IpBegin = IPAddress.Parse("192.168.1.1"),
                Nr = 1,
                MaskLength = 24,
                Description = "DMZ"
            };
            vlanlijst.Add(vlan);

            vlan2 = new Vlan
            {
                IpBegin = IPAddress.Parse("192.168.2.1"),
                Nr = 2,
                MaskLength = 24,
                Description = "Servers"
            };
            vlanlijst.Add(vlan2);

            //Ophalen DB info -> all
            //In grid plaatsen
            gridVlan.ItemsSource = vlanlijst;
        }

        private void radVLAN_Checked(object sender, RoutedEventArgs e)
        {
            //window layout
                txtIp.Visibility = Visibility.Hidden;
                txtComputer.Visibility = Visibility.Hidden;
                txtMask.Visibility = Visibility.Hidden;
                txtVlan.Visibility = Visibility.Hidden;
            
                txtVlanNr.Visibility = Visibility.Visible;
                txtVlanDescr.Visibility = Visibility.Visible;
                txtIpBegin.Visibility = Visibility.Visible;
                txtNetmask.Visibility = Visibility.Visible;
                //txtRange.Visibility = Visibility.Visible;

                //txtVlanNr.Text = vlan.Nr.ToString();
                //txtVlanDescr.Text = vlan.Description.ToString();
                //txtIpBegin.Text = vlan.IpBegin.ToString();
                //txtNetmask.Text = vlan.MaskLength.ToString();
                //txtRange.Text = "";
                //    MessageBox.Show(vlan.Range().ToString()); 

        }

        private void radIP_Checked(object sender, RoutedEventArgs e)
        {
            //window layout
                txtVlanNr.Visibility = Visibility.Hidden;
                txtVlanDescr.Visibility = Visibility.Hidden;
                txtIpBegin.Visibility = Visibility.Hidden;
                txtNetmask.Visibility = Visibility.Hidden;
                //txtRange.Visibility = Visibility.Hidden;

                txtIp.Visibility = Visibility.Visible;
                txtMask.Visibility = Visibility.Visible;

                txtComputer.Visibility = Visibility.Visible;
                txtVlan.Visibility = Visibility.Visible;

            
           
        }

        private void gridVlan_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            List<NetworkInterface> nwilijst2 = new List<NetworkInterface>();

            if (gridVlan.SelectedItem is Vlan vl)  //VLAN1
            {
                foreach (var item in nwilijst)
                {
                    if (item.Vlan == vl)
                    {
                        nwilijst2.Add(item);
                    }
                }
                gridNetwork.ItemsSource = null;
                gridNetwork.ItemsSource = nwilijst2;
                
            }
            //gridNetwork.ItemsSource = nwilijst;
        }
    }
}

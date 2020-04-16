using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;

namespace ProjectWPF
{
    /// <summary>
    /// Interaction logic for VendorWindow.xaml
    /// </summary>
    public partial class VendorWindow : Window
    {
        public VendorWindow()
        {
            InitializeComponent();
            
        }

        private void Window_MouseDown(object sender, MouseButtonEventArgs e)
        {
            if (e.ChangedButton == MouseButton.Left)
                this.DragMove();
        }
        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            //lblUser.Content = this.Username;
        //    lblUser.Content = this.User.FirstName + " " + this.User.LastName;
        }

        // overbrengen van string in login page
        private string _username;
        public string Username {
            get { return _username; }
            set { _username = value; }
        }
        //public ProgramUser User
        //{
        //    get;
        //    set;
        //}


        private void ListViewItem_Selected_Dashboard(object sender, RoutedEventArgs e)
        {

        }
        private void ListViewItem_Selected_Network(object sender, RoutedEventArgs e)
        {
            stkMain.Children.Clear();
            UCNetwork ucObj = new UCNetwork();
            stkMain.Children.Add(ucObj);
           
        }
        private void ListViewItem_Selected_RouterFW(object sender, RoutedEventArgs e)
        {
           // MessageBox.Show(this.Username);
        }
        private void ListViewItem_Selected_Windows(object sender, RoutedEventArgs e)
        {

        }
        private void ListViewItem_Selected_Linux(object sender, RoutedEventArgs e)
        {

        }
        private void ListViewItem_Selected_Products(object sender, RoutedEventArgs e)
        {
            stkMain.Children.Clear();
            UCProducts ucObj = new UCProducts();

            stkMain.Children.Add(ucObj);
        }
        private void ListViewItem_Selected_Statistics(object sender, RoutedEventArgs e)
        {

        }

        private void btnExit_Click(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown();
        }

        private void btnPrinter_Click(object sender, RoutedEventArgs e)
        {
            PrintDialog printDlg = new PrintDialog();
            //printDlg.PrintVisual(stkMain, "Grid Printing.");
            printDlg.PrintVisual(this, "Window Printing.");
            
        }

        
    }
}

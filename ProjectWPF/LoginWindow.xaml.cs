using ProjectDAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace ProjectWPF
{
    /// <summary>
    /// Interaction logic for LoginWindow.xaml
    /// </summary>
    public partial class LoginWindow : Window
    {
        public LoginWindow()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, RoutedEventArgs e)
        {
            if (txtUsername.Text.Length == 0)
            {
                lblLoginError.Content = "Enter an email.";
                txtUsername.Focus();
            }
            else if (!Regex.IsMatch(txtUsername.Text, @"^[a-zA-Z][\w\.-]*[a-zA-Z0-9]@[a-zA-Z0-9][\w\.-]*[a-zA-Z0-9]\.[a-zA-Z][a-zA-Z\.]*[a-zA-Z]$"))
            {
                lblLoginError.Content = "Enter a valid email.";
                txtUsername.Select(0, txtUsername.Text.Length);
                txtUsername.Focus();
            }
            else
            {
                string email = txtUsername.Text;
                //string password = pwdLogin.Password;
                
                // Passing the Password to Encrypt method and the method will return encrypted string and stored in password variable.
                string password = Cryptography.Encrypt(pwdLogin.Password);
                ProgramUser user = new ProgramUser(email,password,true,"Eve","Ravignot","");
                // decrypt test: MessageBox.Show(Cryptography.Decrypt(password));

                //Controle DB no implementeren met DAL
                //-------------------------------------
                //SqlConnection con = new SqlConnection("Data Source=TESTPURU;Initial Catalog=Data;User ID=sa;Password=wintellect");
                //con.Open();
                //SqlCommand cmd = new SqlCommand("Select * from Registration where Email='" + email + "'  and password='" + password + "'", con);
                //cmd.CommandType = CommandType.Text;
                //SqlDataAdapter adapter = new SqlDataAdapter();
                //adapter.SelectCommand = cmd;
                //DataSet dataSet = new DataSet();
                //adapter.Fill(dataSet);
                //if (dataSet.Tables[0].Rows.Count > 0)
                //{
                //    string username = dataSet.Tables[0].Rows[0]["FirstName"].ToString() + " " + dataSet.Tables[0].Rows[0]["LastName"].ToString();
                //    welcome.TextBlockName.Text = username;//Sending value from one form to another form.  
                //    welcome.Show();
                //    Close();
                //}
                //else
                //{
                //    errormessage.Text = "Sorry! Please enter existing emailid/password.";
                //}
                //con.Close();

                //Alternatief
                //---------------
                VendorWindow win = new VendorWindow();
                win.Username = email;
                win.User = user;
                win.Show();
                
                //win.ShowDialog();
                this.Close();
            }
        }

        private void btnLoginExit_Click(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown();
        }
        private void Window_MouseDown(object sender, MouseButtonEventArgs e)
        {
            if (e.ChangedButton == MouseButton.Left)
                this.DragMove();
        }
    }
}

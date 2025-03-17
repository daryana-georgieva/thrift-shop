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
using System.Windows.Shapes;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Navigation;

namespace finalproject
{
    /// <summary>
    /// Interaction logic for Login.xaml
    /// </summary>
    public partial class Login : Window
    {
        public Login()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            SqlConnection sqlCon = new SqlConnection(@"Data Source=DESKTOP-N8FGE93\MSSQLSERVER01;Initial Catalog=vtorataupotreba;Integrated Security=True");

            try
            {
                if (sqlCon.State == ConnectionState.Closed)
                    sqlCon.Open();
                string query = "SELECT COUNT(1) FROM Users Where username=@Username and pass=@Password";
                SqlCommand sqlCmd = new SqlCommand(query, sqlCon);
                sqlCmd.CommandType = CommandType.Text;
                sqlCmd.Parameters.AddWithValue("@Username", usernametxt.Text);
                sqlCmd.Parameters.AddWithValue("@Password", passwordtxt.Password);

                int count = Convert.ToInt32(sqlCmd.ExecuteScalar());
                if (count == 1)
                {
                    MessageBox.Show($"Welcome, {usernametxt.Text}");

                    (App.Current as App).username = usernametxt.Text;
                    (App.Current as App).pass = passwordtxt.Password;


                    WelcomePage wp = new WelcomePage();
                    wp.Show();
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Username or password are not correct!");
                }


            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
            finally
            {
                sqlCon.Close();
            }
        }
    }
}

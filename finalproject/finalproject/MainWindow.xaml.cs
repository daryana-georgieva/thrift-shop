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
using System.Globalization;

namespace finalproject
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            SqlConnection sqlCon = new SqlConnection(@"Data Source=DESKTOP-N8FGE93\MSSQLSERVER01;Initial Catalog=vtorataupotreba;Integrated Security=True");

            try
            {
                sqlCon.Open();

                string query = "INSERT INTO Users(username, email, pass, address_, cardnumber)values ('" + this.usernametxt.Text + "','" + this.emailtxt.Text + "','" + this.passwordtxt.Password + "','" + this.addresstxt.Text + "','" + this.cardnumtxt.Text + "') ";
                SqlCommand cmd = new SqlCommand(query, sqlCon);
                

                cmd.ExecuteNonQuery();

                MessageBox.Show("Successfully saved");

                Login lg = new Login();
                lg.Show();
                this.Close();

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
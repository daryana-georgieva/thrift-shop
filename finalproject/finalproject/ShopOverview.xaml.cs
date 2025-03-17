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
    /// <summary>
    /// Interaction logic for ShopOverview.xaml
    /// </summary>
    public partial class ShopOverview : Window
    {
        public ShopOverview()
        {
            InitializeComponent();
        }

        private void brownsweaterAddToCart(object sender, RoutedEventArgs e)
        {
            SqlConnection sqlCon = new SqlConnection(@"Data Source=DESKTOP-N8FGE93\MSSQLSERVER01;Initial Catalog=vtorataupotreba;Integrated Security=True");

            try
            {
                sqlCon.Open();

                string usernameresult = (App.Current as App).username;
                string passresult = (App.Current as App).pass;

                string query = $"select userid from Users where username = @Username and pass = @Password";
                SqlCommand cmd = new SqlCommand(query, sqlCon);
                cmd.CommandType = CommandType.Text;
                cmd.Parameters.AddWithValue("@Username", usernameresult);
                cmd.Parameters.AddWithValue("@Password", passresult);
                int useridresult = (int)cmd.ExecuteScalar();

                Console.WriteLine(useridresult);

                string query3 = $"insert into Cart (u.userid, s.itemid, s.itemname, s.price, s.condition, s.originalvalue, s.size) select u.userid, s.itemid, s.itemname, s.price, s.condition, s.originalvalue, s.size from Users u, Stock s where u.userid = {useridresult} and s.itemid = 3";
                SqlCommand cmd3 = new SqlCommand(query3, sqlCon);
                cmd.CommandType = CommandType.Text;
                cmd.Parameters.AddWithValue("@Useridresult", useridresult);
                cmd3.ExecuteNonQuery();

                MessageBox.Show("Successfully added to cart");

                Cart ct = new Cart();
                ct.Show();
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

        private void jacketAddToCart(object sender, RoutedEventArgs e)  //done
        {
            SqlConnection sqlCon = new SqlConnection(@"Data Source=DESKTOP-N8FGE93\MSSQLSERVER01;Initial Catalog=vtorataupotreba;Integrated Security=True");

            try
            {
                sqlCon.Open();

                string usernameresult = (App.Current as App).username;
                string passresult = (App.Current as App).pass;

                string query = $"select userid from Users where username = @Username and pass = @Password";
                SqlCommand cmd = new SqlCommand(query, sqlCon);
                cmd.CommandType = CommandType.Text;
                cmd.Parameters.AddWithValue("@Username", usernameresult);
                cmd.Parameters.AddWithValue("@Password", passresult);
                int useridresult = (int)cmd.ExecuteScalar();

                Console.WriteLine(useridresult);

                string query3 = $"insert into Cart (u.userid, s.itemid, s.itemname, s.price, s.condition, s.originalvalue, s.size) select u.userid, s.itemid, s.itemname, s.price, s.condition, s.originalvalue, s.size from Users u, Stock s where u.userid = {useridresult} and s.itemid = 1";
                SqlCommand cmd3 = new SqlCommand(query3, sqlCon);
                cmd.CommandType = CommandType.Text;
                cmd.Parameters.AddWithValue("@Useridresult", useridresult);
                cmd3.ExecuteNonQuery();

                MessageBox.Show("Successfully added to cart");

                Cart ct = new Cart();
                ct.Show();
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

        private void tshirtAddToCart(object sender, RoutedEventArgs e)
        {
            SqlConnection sqlCon = new SqlConnection(@"Data Source=DESKTOP-N8FGE93\MSSQLSERVER01;Initial Catalog=vtorataupotreba;Integrated Security=True");

            try
            {
                sqlCon.Open();

                string usernameresult = (App.Current as App).username;
                string passresult = (App.Current as App).pass;

                string query = $"select userid from Users where username = @Username and pass = @Password";
                SqlCommand cmd = new SqlCommand(query, sqlCon);
                cmd.CommandType = CommandType.Text;
                cmd.Parameters.AddWithValue("@Username", usernameresult);
                cmd.Parameters.AddWithValue("@Password", passresult);
                int useridresult = (int)cmd.ExecuteScalar();

                Console.WriteLine(useridresult);

                string query3 = $"insert into Cart (u.userid, s.itemid, s.itemname, s.price, s.condition, s.originalvalue, s.size) select u.userid, s.itemid, s.itemname, s.price, s.condition, s.originalvalue, s.size from Users u, Stock s where u.userid = {useridresult} and s.itemid = 7";
                SqlCommand cmd3 = new SqlCommand(query3, sqlCon);
                cmd.CommandType = CommandType.Text;
                cmd.Parameters.AddWithValue("@Useridresult", useridresult);
                cmd3.ExecuteNonQuery();

                MessageBox.Show("Successfully added to cart");

                Cart ct = new Cart();
                ct.Show();
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

        private void bluesweaterAddToCart(object sender, RoutedEventArgs e)  //done
        {
            SqlConnection sqlCon = new SqlConnection(@"Data Source=DESKTOP-N8FGE93\MSSQLSERVER01;Initial Catalog=vtorataupotreba;Integrated Security=True");

            try
            {
                sqlCon.Open();

                string usernameresult = (App.Current as App).username;
                string passresult = (App.Current as App).pass;

                string query = $"select userid from Users where username = @Username and pass = @Password";
                SqlCommand cmd = new SqlCommand(query, sqlCon);
                cmd.CommandType = CommandType.Text;
                cmd.Parameters.AddWithValue("@Username", usernameresult);
                cmd.Parameters.AddWithValue("@Password", passresult);
                int useridresult = (int)cmd.ExecuteScalar();

                Console.WriteLine(useridresult);

                string query3 = $"insert into Cart (u.userid, s.itemid, s.itemname, s.price, s.condition, s.originalvalue, s.size) select u.userid, s.itemid, s.itemname, s.price, s.condition, s.originalvalue, s.size from Users u, Stock s where u.userid = {useridresult} and s.itemid = 1";
                SqlCommand cmd3 = new SqlCommand(query3, sqlCon);
                cmd.CommandType = CommandType.Text;
                cmd.Parameters.AddWithValue("@Useridresult", useridresult);
                cmd3.ExecuteNonQuery();

                MessageBox.Show("Successfully added to cart");

                Cart ct = new Cart();
                ct.Show();
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

        private void cargojeansAddToCart(object sender, RoutedEventArgs e)
        {
            SqlConnection sqlCon = new SqlConnection(@"Data Source=DESKTOP-N8FGE93\MSSQLSERVER01;Initial Catalog=vtorataupotreba;Integrated Security=True");

            try
            {
                sqlCon.Open();

                string usernameresult = (App.Current as App).username;
                string passresult = (App.Current as App).pass;

                string query = $"select userid from Users where username = @Username and pass = @Password";
                SqlCommand cmd = new SqlCommand(query, sqlCon);
                cmd.CommandType = CommandType.Text;
                cmd.Parameters.AddWithValue("@Username", usernameresult);
                cmd.Parameters.AddWithValue("@Password", passresult);
                int useridresult = (int)cmd.ExecuteScalar();

                Console.WriteLine(useridresult);

                string query3 = $"insert into Cart (u.userid, s.itemid, s.itemname, s.price, s.condition, s.originalvalue, s.size) select u.userid, s.itemid, s.itemname, s.price, s.condition, s.originalvalue, s.size from Users u, Stock s where u.userid = {useridresult} and s.itemid = 5";
                SqlCommand cmd3 = new SqlCommand(query3, sqlCon);
                cmd.CommandType = CommandType.Text;
                cmd.Parameters.AddWithValue("@Useridresult", useridresult);
                cmd3.ExecuteNonQuery();

                MessageBox.Show("Successfully added to cart");

                Cart ct = new Cart();
                ct.Show();
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

        private void blackjacketAddToCart(object sender, RoutedEventArgs e)
        {
            SqlConnection sqlCon = new SqlConnection(@"Data Source=DESKTOP-N8FGE93\MSSQLSERVER01;Initial Catalog=vtorataupotreba;Integrated Security=True");

            try
            {
                sqlCon.Open();

                string usernameresult = (App.Current as App).username;
                string passresult = (App.Current as App).pass;
                
                string query = $"select userid from Users where username = @Username and pass = @Password";
                SqlCommand cmd = new SqlCommand(query, sqlCon);
                cmd.CommandType = CommandType.Text;
                cmd.Parameters.AddWithValue("@Username", usernameresult);
                cmd.Parameters.AddWithValue("@Password", passresult);
                int useridresult = (int)cmd.ExecuteScalar();

                Console.WriteLine(useridresult);

                string query3 = $"insert into Cart (u.userid, s.itemid, s.itemname, s.price, s.condition, s.originalvalue, s.size) select u.userid, s.itemid, s.itemname, s.price, s.condition, s.originalvalue, s.size from Users u, Stock s where u.userid = {useridresult} and s.itemid = 6";
                SqlCommand cmd3 = new SqlCommand(query3, sqlCon);
                cmd.CommandType = CommandType.Text;
                cmd.Parameters.AddWithValue("@Useridresult", useridresult);
                cmd3.ExecuteNonQuery();

                MessageBox.Show("Successfully added to cart");

                Cart ct = new Cart();
                ct.Show();
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

        private void shopbtn_Click(object sender, RoutedEventArgs e)
        {
            ShopOverview sh = new ShopOverview();
            sh.Show();
            this.Close();
        }

        private void homebtn_Click(object sender, RoutedEventArgs e)
        {
            WelcomePage wp = new WelcomePage();
            wp.Show();
            this.Close();
        }

        private void cartbtn_Click(object sender, RoutedEventArgs e)
        {
            Cart cr = new Cart();
            cr.Show();
            this.Close();
        }
    }
}

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
    /// Interaction logic for Cart.xaml
    /// </summary>
    public partial class Cart : Window
    {
        public Cart()
        {
            InitializeComponent();
            ChangeLabel();
        }

        private void ChangeLabel()
        {
            SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-N8FGE93\MSSQLSERVER01;Initial Catalog=vtorataupotreba;Integrated Security=True");
            con.Open();
            string usernameresult = (App.Current as App).username;
            string passresult = (App.Current as App).pass;

            string query = $"select userid from Users where username = @Username and pass = @Password";
            SqlCommand cmd = new SqlCommand(query, con);
            cmd.CommandType = CommandType.Text;
            cmd.Parameters.AddWithValue("@Username", usernameresult);
            cmd.Parameters.AddWithValue("@Password", passresult);
            int useridresult = (int)cmd.ExecuteScalar();


            string displayinfo = $"select itemname, price, condition, originalvalue, size from cart where userid = {useridresult}";
            SqlCommand display = new SqlCommand(displayinfo, con);
            SqlDataReader reader;
            reader = display.ExecuteReader();
            while (reader.Read())
            {
                //usernamelbl.content = $"thank you, {usernameresult}";
                itemnamelabel.Content = reader["itemname"].ToString();
                pricelabel.Content = reader["price"].ToString();
                conditionlabel.Content = reader["condition"].ToString();
                ogvaluelabel.Content = reader["originalvalue"].ToString();
                sizelabel.Content = reader["size"].ToString();
            }
            reader.Close();
            con.Close();

        }

        private void cancelbtn_Click(object sender, RoutedEventArgs e)
        {
            SqlConnection sqlCon = new SqlConnection(@"Data Source=DESKTOP-N8FGE93\MSSQLSERVER01;Initial Catalog=vtorataupotreba;Integrated Security=True");

            //delete from cart
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

                string deletefromcart = $"delete from Cart where userid = {useridresult}";
                SqlCommand cmd3 = new SqlCommand(deletefromcart, sqlCon);
                cmd.CommandType = CommandType.Text;
                cmd.Parameters.AddWithValue("@Useridresult", useridresult);
                cmd3.ExecuteNonQuery();

                MessageBox.Show("Successfully deleted from cart");

                ShopOverview sh = new ShopOverview();
                sh.Show();
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

        private void buynow_Click(object sender, RoutedEventArgs e)
        {
            //add to orders
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

                string query3 = $"insert into Orders (u.userid, c.itemid, c.itemname, c.price, c.condition, c.originalvalue, c.size) select u.userid, c.itemid, c.itemname, c.price, c.condition, c.originalvalue, c.size from Users u, Cart c where u.userid = {useridresult}";
                SqlCommand cmd3 = new SqlCommand(query3, sqlCon);
                cmd.CommandType = CommandType.Text;
                cmd.Parameters.AddWithValue("@Useridresult", useridresult);
                cmd3.ExecuteNonQuery();

                MessageBox.Show("Order placed");

                //string itemidquery = $"select itemid from Cart where userid = {useridresult}";
                //SqlCommand itemidsearch = new SqlCommand(itemidquery, sqlCon);
                //cmd.CommandType = CommandType.Text;
                //int itemidresult = (int)cmd.ExecuteScalar();

                //string deletefromcart = $"delete from Stock where itemid = {itemidresult}";
                //SqlCommand deletefromstock = new SqlCommand(deletefromcart, sqlCon);
                //deletefromstock.CommandType = CommandType.Text;
                //deletefromstock.ExecuteNonQuery();


                AfterShopping aftershopping = new AfterShopping();
                aftershopping.Show();
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

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {

            finalproject.vtorataupotrebaDataSet3 vtorataupotrebaDataSet3 = ((finalproject.vtorataupotrebaDataSet3)(this.FindResource("vtorataupotrebaDataSet3")));
            // Load data into the table Cart. You can modify this code as needed.
            finalproject.vtorataupotrebaDataSet3TableAdapters.CartTableAdapter vtorataupotrebaDataSet3CartTableAdapter = new finalproject.vtorataupotrebaDataSet3TableAdapters.CartTableAdapter();
            vtorataupotrebaDataSet3CartTableAdapter.Fill(vtorataupotrebaDataSet3.Cart);
            System.Windows.Data.CollectionViewSource cartViewSource = ((System.Windows.Data.CollectionViewSource)(this.FindResource("cartViewSource")));
            cartViewSource.View.MoveCurrentToFirst();
        }
    }
}

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
    /// Interaction logic for AfterShopping.xaml
    /// </summary>
    public partial class AfterShopping : Window
    {
        public AfterShopping()
        {
            InitializeComponent();
            ChangeLabel();
        }

        public void ChangeLabel()
        {
            string usernameresult = (App.Current as App).username;

            Console.WriteLine(usernameresult);

            usernamelbl.Content = $"Thank you, {usernameresult}";
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {

            finalproject.vtorataupotrebaDataSet3 vtorataupotrebaDataSet3 = ((finalproject.vtorataupotrebaDataSet3)(this.FindResource("vtorataupotrebaDataSet3")));
            // Load data into the table Orders. You can modify this code as needed.
            finalproject.vtorataupotrebaDataSet3TableAdapters.OrdersTableAdapter vtorataupotrebaDataSet3OrdersTableAdapter = new finalproject.vtorataupotrebaDataSet3TableAdapters.OrdersTableAdapter();
            vtorataupotrebaDataSet3OrdersTableAdapter.Fill(vtorataupotrebaDataSet3.Orders);
            System.Windows.Data.CollectionViewSource ordersViewSource = ((System.Windows.Data.CollectionViewSource)(this.FindResource("ordersViewSource")));
            ordersViewSource.View.MoveCurrentToFirst();
        }
    }
}

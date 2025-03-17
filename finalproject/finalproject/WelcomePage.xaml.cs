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

namespace finalproject
{
    /// <summary>
    /// Interaction logic for WelcomePage.xaml
    /// </summary>
    public partial class WelcomePage : Window
    {
        public WelcomePage()
        {
            InitializeComponent();
        }

        private void shopnowbtn_Click(object sender, RoutedEventArgs e)
        {
            ShopOverview sh = new ShopOverview();
            sh.Show();
            this.Close();
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
    }
}

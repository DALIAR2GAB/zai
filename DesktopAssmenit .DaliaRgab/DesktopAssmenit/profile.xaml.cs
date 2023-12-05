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

namespace DesktopAssmenit
{
    /// <summary>
    /// Interaction logic for profile.xaml
    /// </summary>
    public partial class profile : Page
    {
        public profile(string name)
        {
            InitializeComponent();
            u1.Content= name;

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            login l= new login();
            this.NavigationService.Navigate(l);
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            login l = new login();
            this.NavigationService.Navigate(l);
        }

        private void Button_Click_1(object sender, object e)
        {

        }
    }
}

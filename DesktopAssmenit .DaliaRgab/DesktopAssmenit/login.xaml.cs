using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
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
    /// Interaction logic for login.xaml
    /// </summary>
    public partial class login : Page
    {
        profileEntities db=new profileEntities();
        public login()
        {
            InitializeComponent();
           
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            forget ff = new forget();
            this.NavigationService.Navigate(ff);
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            User_ u=new User_();
            u = db.User_.FirstOrDefault(x => x.Username == user.Text && x.password_ == pass.Password);
            if (u != null)
            { 
                
                MessageBox.Show("secsufuuly sign in");
                 
                string name1 = user.Text;
                profilepage p = new profilepage(name1);
                this.NavigationService.Navigate(p);
            }
            else
            {
                MessageBox.Show("the wroung is username or password ");
            }
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            signup ss=new signup();
            this.NavigationService.Navigate(ss);
        }
    }
}

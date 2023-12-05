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
    /// Interaction logic for signup.xaml
    /// </summary>
    public partial class signup : Page
    {
        profileEntities db=new profileEntities();
        public signup()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            login l=new login();    
            this.NavigationService.Navigate(l);
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            if(phone(phn.Text))
            {
                if (Age(age.Text))
                {
                    if (isvalid(pas.Text))
                    {
                        User_ ff = new User_();
                        if (username1 != null && pas != null && age != null && phn != null && com != null)
                        {
                            ff.Username = username1.Text;
                            ff.password_ = pas.Text;
                            ff.Age = int.Parse(age.Text);
                            ff.Gender = combox.Text;
                            ff.phonenum = phn.Text;
                            ff.city = com.Text;
                            db.User_.Add(ff);
                            db.SaveChanges();
                            MessageBox.Show("secufully sin up");
                        }
                        else
                        {
                            MessageBox.Show("Error sign up");
                        }
                    }
                    else
                    {
                        MessageBox.Show("please enter the password have char and symbol ");
                    }
                }
                else
                {
                    MessageBox.Show("ypu shouhd enter age between 16 and 60 ");
                }

            }
            else
            {
                MessageBox.Show(" the length of num 11");
            }




            bool isvalid(string pass)
            {
                bool upper, lower, num, symbol;
                upper = lower = num = symbol = false;
                string speacail = "!@#$%^&*()_+";
                foreach(char c in pass)
                {
                    if(c>='A'&& c<='Z')
                    {
                        upper= true;
                    }
                    else if(c>='a'&&c<='z')
                    {
                        lower= true;
                    }
                    else if(c>='0' &&c<='9')
                    {
                        num= true;
                    }
                    else if(speacail.Contains(c))
                    {
                        symbol= true;
                    }
                }
                return upper&& lower && num&& symbol;
            }
            bool Age(string age)
            {
                bool length=false;
                foreach (char c in age)
                {
                    if (c >= 18 && c <= 60)
                    {
                        length = true;
                    }
                    
                }
                if(age.Length>= 18 && age.Length<=60)
                {
                    length = true;  
                }
                return length;
            }
            bool phone(string pho)
            {
                bool length=false;
               
                if(pho.Length==11)
                {
                    length= true;
                }
                return length;

            }
        }
    }
}

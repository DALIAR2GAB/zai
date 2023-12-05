using System;
using System.Collections.Generic;
using System.Data.Entity.Migrations;
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
    /// Interaction logic for forget.xaml
    /// </summary>
    public partial class forget : Page
    {
        profileEntities db=new profileEntities();
        public forget()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if(phone(use1.Text))
            {
                if (isvalid(pass1.Text))
                {
                    User_ gg = new User_();
                    gg = db.User_.FirstOrDefault(x => x.phonenum == use.Text);
                    if (gg != null)
                    {
                        gg.password_ = pass1.Text;
                        gg.password_ = use1.Text;
                        db.User_.AddOrUpdate();
                        db.SaveChanges();
                        MessageBox.Show("seccfully update the  password");
                    }

                }
                else
                {
                    MessageBox.Show("wrong password");
                }

            }
            else
            {
                MessageBox.Show("error phone");
            }

            bool isvalid(string pass)
            {
                bool upper, lower, num, symbol;
                upper = lower = num = symbol = false;
                string speacail = "!@#$%^&*()_+";
                foreach (char c in pass)
                {
                    if (c >= 'A' && c <= 'Z')
                    {
                        upper = true;
                    }
                    else if (c >= 'a' && c <= 'z')
                    {
                        lower = true;
                    }
                    else if (c >= '0' && c <= '9')
                    {
                        num = true;
                    }
                    else if (speacail.Contains(c))
                    {
                        symbol = true;
                    }
                }
                return upper && lower && num && symbol;
            }
            bool phone(string pho)
            {
                bool length = false;

                if (pho.Length == 11)
                {
                    length = true;
                }
                return length;

            }
        }
    }
}

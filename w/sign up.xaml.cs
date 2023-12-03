using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
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

namespace w
{
    /// <summary>
    /// Interaction logic for sign_up.xaml
    /// </summary>
    public partial class sign_up : Page
    {
        cEntities entities=new cEntities();
        public sign_up()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            var ss = IsValid(pass.Text);
            if(ss!=true)
            {
                MessageBox.Show("invalid");
            }
            else if(ss==true)
            {
  
            }
            bool IsValid(string pass)
            {
                
                bool l, s, n, w,m;
                l = s = n = w=m = false;
                if(pass.Length < 15 && pass.Length > 10)
                {
                    m = true;
                }
                
                string x = "@#$%^&*()";
                foreach (char c in pass)
                {
                    if (c >= 'a' && c <= 'z')
                    {
                        l = true;
                    }
                    else if (c >= 'A' && c <= 'Z')
                    {
                        s = true;
                    }
                    else if (c >= '0' && c <= '9')
                    {
                        n = true;
                    }
                    else if (x.Contains(c))
                    {
                        w = true;
                    }
                }
                return l && s && n && w&&m;

            }


        }
    }
}

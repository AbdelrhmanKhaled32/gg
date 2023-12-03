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

namespace w
{
    /// <summary>
    /// Interaction logic for log_in.xaml
    /// </summary>
    public partial class log_in : Page
    {
        cEntities entities = new cEntities();
        public log_in()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            ADMINLOGIN dMINLOGIN = entities.ADMINLOGINs.FirstOrDefault(x => x.USERNAME_ == user.Text&&x.PASSWORD_==pass.Text);
            if(dMINLOGIN == null)
            {
                MessageBox.Show("invalid");
            }
            else if(dMINLOGIN!=null)
            {
                MessageBox.Show("valid");
                admin admin = new admin();
                this.NavigationService.Navigate(admin); 
            }

        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            sign_up sign_Up = new sign_up();
            this.NavigationService.Navigate(sign_Up);
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            forgetpass forgetpass = new forgetpass();
            this.NavigationService.Navigate(forgetpass);
        }
    }
}

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
    /// Interaction logic for r.xaml
    /// </summary>
    public partial class r : Page
    {
        public r()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if (combo.Text=="Admin")
            {
                log_in admin = new log_in();
                this.NavigationService.Navigate(admin);
            }
            else if (combo.Text == "User")
            {
                userpage userpage = new userpage();
                this.NavigationService.Navigate(userpage);
            }
        }
      
    }
}

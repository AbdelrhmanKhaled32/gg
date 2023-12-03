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

namespace w
{
    /// <summary>
    /// Interaction logic for forgetpass.xaml
    /// </summary>
    public partial class forgetpass : Page
    {
        cEntities entities=new cEntities();
        public forgetpass()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            ADMINLOGIN aDMINLOGIN=entities.ADMINLOGINs.FirstOrDefault(x=>x.USERNAME_==user.Text);
            if (aDMINLOGIN==null)
            {
                MessageBox.Show("invalid");
            }
            else if(aDMINLOGIN!=null)
            {
                aDMINLOGIN.PASSWORD_ = pass.Text;
                entities.ADMINLOGINs.AddOrUpdate(aDMINLOGIN);
                entities.SaveChanges();
                MessageBox.Show("Successfully");
            }
        }
    }
}

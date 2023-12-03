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
    /// Interaction logic for admin.xaml
    /// </summary>
    public partial class admin : Page
    {
        cEntities entities=new cEntities();
        public admin()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            dg.ItemsSource=entities.USER_.ToList();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            USER_ uSER_=entities.USER_.FirstOrDefault(x=>x.USERNAME_==name.Text);
            if (uSER_==null)
            {
                MessageBox.Show("invalid");
            }
            else if(uSER_!=null)
            {
                uSER_.AGE = age.Text;
                uSER_.DEPARTMENT=department.Text;
                entities.USER_.AddOrUpdate(uSER_);
                entities.SaveChanges();
                MessageBox.Show("Update");
            }
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            entities.USER_.Remove(entities.USER_.FirstOrDefault(x=>x.USERNAME_== name.Text));
            entities.SaveChanges();
            MessageBox.Show("delete");
        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            dg.ItemsSource = entities.USER_.Where(x=>x.USERNAME_==name.Text).ToList();
        }
    }
}

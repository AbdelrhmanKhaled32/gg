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
    /// Interaction logic for userpage.xaml
    /// </summary>
    public partial class userpage : Page
    {
        cEntities entities=new cEntities();
        public userpage()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if(male.IsEnabled)
            {
                USER_ sER_ = new USER_();
                sER_.USERNAME_ = name.Text;
                sER_.GENDER = "Male";
                sER_.DEPARTMENT=department.Text;
                sER_.AGE = age.Text;
                sER_.ADDRESS_=Address.Text;
                entities.USER_.Add(sER_);
                entities.SaveChanges();
                MessageBox.Show("Successfully");

            }
            else if(female.IsEnabled)
            {
                USER_ sER_ = new USER_();
                sER_.USERNAME_ = name.Text;
                sER_.GENDER = "Female";
                sER_.DEPARTMENT = department.Text;
                sER_.AGE = age.Text;
                sER_.ADDRESS_ = Address.Text;
                entities.USER_.Add(sER_);
                entities.SaveChanges();
                MessageBox.Show("Successfully");
            }
        }
    }
}

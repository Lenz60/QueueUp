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
using System.Windows.Shapes;

namespace Antrian.View
{

    public partial class AdminHomeWindow : Window
    {
        //Deklarasi Controller
        Controller.LoginController ControllerLogin;
        public AdminHomeWindow()
        {
            InitializeComponent();
            //Instance
            ControllerLogin = new Controller.LoginController(this);
            //Set Label User menjadi nama admin
            lblDataUser.Content = Controller.LoginController.GetNamaA();
        }

        private void LblHome_MouseDown(object sender, MouseButtonEventArgs e)
        {
            frame.Navigate(new View.AdminHomePage());
        }

        private void LblStaff_MouseDown(object sender, MouseButtonEventArgs e)
        {
            frame.Navigate(new View.AdminStaffRegPage());
        }

        private void LbLogout_MouseDown(object sender, MouseButtonEventArgs e)
        {
            Logout(); //Memanggil Fungsi Logout
        }

        //Kembali ke Window Login Admin
        public void Logout()
        {
            AdminWindow LoginAdmin = new AdminWindow();
            LoginAdmin.Show();
            this.Close();
        }

        private void LblRecord_MouseDown(object sender, MouseButtonEventArgs e)
        {
            frame.Navigate(new View.AdminRecordPage());
        }
    }
}

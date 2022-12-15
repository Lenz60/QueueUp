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
    /// <summary>
    /// Interaction logic for InputanWindow.xaml
    /// </summary>
    public partial class InputanWindow : Window
    {
        //Constructor
        private Controller.LoginController LoginController;
        public InputanWindow()
        {
            InitializeComponent();
            //Instance
            LoginController = new Controller.LoginController(this);
            //Set Nama Staff ke Label
            LbNamaStaff.Content = Controller.LoginController.GetNama();
        }

        private void ImgAntri_MouseDown(object sender, MouseButtonEventArgs e)
        {
            InputAntri();
        }

        private void ImgAdmin_MouseDown(object sender, MouseButtonEventArgs e)
        {
            AdminAkses();
        }

        public void InputAntri()
        {
            IDWindow ID = new IDWindow();
            ID.Show();
            this.Close();
        }

        public void AdminAkses()
        {
            AdminWindow Admin = new AdminWindow();
            Admin.Show();
            this.Close();
        }

        public void Logout()
        {
            LoginWindow Login = new LoginWindow();
            Login.Show();
            this.Close();
        }

        private void ImgLogout_MouseDown(object sender, MouseButtonEventArgs e)
        {
            Logout();
        }
    }
}

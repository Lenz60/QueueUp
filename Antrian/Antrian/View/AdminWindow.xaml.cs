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
    /// Interaction logic for AdminWindow.xaml
    /// </summary>
    public partial class AdminWindow : Window
    {
        private Controller.LoginController LoginController;
        public AdminWindow()
        {
            InitializeComponent();
            LoginController = new Controller.LoginController(this);
            TxtUsername.Focus();
            //Maxs Characters 
            TxtUsername.MaxLength = 5;
        }

        private void BtnLogin_MouseDown(object sender, MouseButtonEventArgs e)
        {
            Login();
        }

        public void Login()
        {
            if (LoginController.LoginAdmin() == true)
            {
                AdminHomeWindow AdminWindow = new AdminHomeWindow();
                AdminWindow.Show();
                this.Close();
            }
            else
            {
                MessageBox.Show("Maaf Username/Password Salah\n Silahkan Masukkan Kembali");
                TxtUsername.Text = "";
                PBPassword.Password = "";
                TxtUsername.Focus();
            }
        }

        //Shortcut Key
        private void PBPassword_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Enter)
            {
                Login();
            }
        }

        private void BtnBack_MouseDown(object sender, MouseButtonEventArgs e)
        {
            Back();
        }

        public void Back()
        {
            InputanWindow Input = new InputanWindow();
            Input.Show();
            this.Close();
        }
        //Shortcut Key
        private void TxtUsername_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Escape)
            {
                Back();
            }
        }
    }
}

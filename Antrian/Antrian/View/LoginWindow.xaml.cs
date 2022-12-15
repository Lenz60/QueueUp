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
using System.Drawing;
using System.Drawing.Drawing2D;


namespace Antrian.View
{
    /// <summary>
    /// Interaction logic for LoginWindow.xaml
    /// </summary>
    public partial class LoginWindow : Window
    {

        private Controller.LoginController LoginController;
        public LoginWindow()
        {
            InitializeComponent();
            LoginController = new Controller.LoginController(this);
            TxtUsername.Focus();
        }

        private void TxtPassword_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        //Shortcut Key
        private void TxtPassword_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Enter)
            {
                BtnLoginClick();
            }
        }

        private void BtnLogin_KeyDown(object sender, KeyEventArgs e)
        {
            
        }

        public void BtnLoginClick()
        {
            if (LoginController.LoginStaff() == true)
            {
                InputanWindow inputwindow = new InputanWindow();
                inputwindow.Show();
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

        private void BtnImgLogin_MouseDown(object sender, MouseButtonEventArgs e)
        {
            BtnLoginClick();
        }

        private void PBPassword_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Enter)
            {
                BtnLoginClick();
            }
        }
    }
}

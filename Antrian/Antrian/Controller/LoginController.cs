using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Antrian.View;
using System.Data;


namespace Antrian.Controller
{
    class LoginController
    {
        //Deklarasi Constructor
        private View.LoginWindow viewLogin;
        private Model.LoginModel modelLogin;
        private InputanWindow inputanWindow;
        private View.IDWindow viewID;
        private View.AdminWindow viewLoginAdmin;
        private View.AdminHomeWindow viewHomeAdmin;
        private static String Nama;
        private static String NamaA;
        //
        public LoginController(View.LoginWindow viewLogin)
        {
            //Instansi Constructor
            this.viewLogin = viewLogin;
            modelLogin = new Model.LoginModel();
        }

        public LoginController(InputanWindow inputanWindow)
        {
            this.inputanWindow = inputanWindow;
        }
        public LoginController(View.IDWindow viewID)
        {
            this.viewID = viewID;
            modelLogin = new Model.LoginModel();
        }

        public LoginController(View.AdminWindow viewLoginAdmin)
        {
            this.viewLoginAdmin = viewLoginAdmin;
            modelLogin = new Model.LoginModel();
        }

        public LoginController(AdminHomeWindow viewHomeAdmin)
        {
            this.viewHomeAdmin = viewHomeAdmin;
        }


        public static string GetNama()
        {
            return Nama;
        }

        public static void SetNama(String Nama)
        {
            LoginController.Nama = Nama;
        }

        public static string GetNamaA()
        {
            return NamaA;
        }

        public static void SetNamaA(String NamaA)
        {
            LoginController.NamaA = NamaA;
        }

        public bool LoginStaff()
        {
            //Fungsi LoginStaff
            bool hasil = modelLogin.Login(viewLogin.TxtUsername.Text,
                                          viewLogin.PBPassword.Password);
            //Mengambil Value Username dan Password pada LoginView lalu di parameter ke
            //fungsi Login pada LoginModel
            return hasil;
            //Mengembalikan Value Hasil
        }

        public bool LoginAdmin()
        {
            bool hasil = modelLogin.LoginAdmin(viewLoginAdmin.TxtUsername.Text,
                                          viewLoginAdmin.PBPassword.Password);
            return hasil;
        }

    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using Antrian.KoneksiDB;
using System.Data;


namespace Antrian.Model
{

    class LoginModel
    {
        //[*] SQL Connection [*]
        private SqlConnection con;
        //[] Constructor []
        public LoginModel()
        { 
            con = KoneksiDB.Koneksi.GetKoneksi();
        }
        //
        private string query;
        private bool hasil;
        //Deklarasi Hasil untuk inputan
        ////////////////////////////////
        //1. Information Hiding
        private string Username;
        private string Password;
        private string UsernameA;
        private string PasswordA;
        ///////////////////////////////
        //2.Enkapsulasi
        ////////LOGIN STAFF ////////////////
        public string GetUsername()
        {
            return Username;
        }
        public void SetUsername(string Username)
        {
            this.Username = Username;
        }
        public string GetPassword()
        {
            return Password;
        }
        public void SetPassword(string Password)
        {
            this.Password = Password;
        }
        ///// LOGIN ADMIN /////
        public string GetUsernameA()
        {
            return UsernameA;
        }
        public void SetUsernameA(string UsernameA)
        {
            this.UsernameA = UsernameA;
        }
        public string GetPasswordA()
        {
            return PasswordA;
        }
        public void SetPasswordA(string PasswordA)
        {
            this.PasswordA = PasswordA;
        }
        //LOGIN STAFF//
        public bool Login(string Username, string Password)
        {
            query = "SELECT * FROM LoginStaff WHERE Username = '" + Username + "'" +
                    "AND Password = '" + Password + "'";
            con.Open();
            SqlCommand command = con.CreateCommand();
            command.CommandText = query;
            SqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                if((reader.GetString(0).ToString() == Username) && 
                    (reader.GetString(1).ToString() == Password))
                {
                    hasil = true;
                    Controller.LoginController.SetNama(reader.GetString(2).ToString()); //SetVariable User
                }
                else
                {
                    hasil = false;
                }
            }
            con.Close();
            return hasil;
        }
        //LOGIN ADMIN//
        public bool LoginAdmin(string UsernameA, string PasswordA)
        {
            query = "SELECT * FROM LoginAdmin WHERE Username = '" + UsernameA + "'" +
                    "AND Password = '" + PasswordA + "'";
            con.Open();
            SqlCommand command = con.CreateCommand();
            command.CommandText = query;
            SqlDataReader reader = command.ExecuteReader();

            while (reader.Read())
            {
                if ((reader.GetString(0).ToString() == UsernameA) &&
                    (reader.GetString(1).ToString() == PasswordA))
                {
                    hasil = true;
                    Controller.LoginController.SetNamaA(reader.GetString(2).ToString());
                }
                else
                {
                    hasil = false;
                }
            }
            con.Close();
            return hasil;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace Antrian.Model
{
 
    class StaffModel
    {
        //[*] SQL Connection & Ccommand [*]
        private SqlConnection con;
        private SqlCommand command;
        public StaffModel()
        {
            con = KoneksiDB.Koneksi.GetKoneksi();
        }
        //
        private string query;
        private bool hasil;
        //1. Information Hiding
        private string Username;
        private string Password;
        private string Nama;
        //2.Encapsulation
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
            this.Password = Password ;
        }

        public string GetNama()
        {
            return Nama;
        }
        public void SetNama(string Nama)
        {
            this.Nama = Nama;
        }
        //3.Functions
        public DataSet SelectStaff()
        {//Fungsi Tampil data
            DataSet ds = new DataSet();
            try
            {
                con.Open();
                command = new SqlCommand();
                command.Connection = con;
                command.CommandType = CommandType.Text;
                command.CommandText = "SELECT Username, Password, Nama as [Nama Staff] FROM LoginStaff";
                SqlDataAdapter sda = new SqlDataAdapter(command);
                sda.Fill(ds, "Data");
                con.Close();
            }
            catch (SqlException)
            {

            }
            return ds;
        }

        public bool Tambah()
        {//fungsi Tambah
            try
            {
               
                query = "INSERT INTO LoginStaff values ('" + Username + "','" + Password + "','" + Nama + "')";
                con.Open();
                //Membuka Koneksi Database
                command = new SqlCommand();
                command.Connection = con;
                command.CommandText = query;
                command.ExecuteNonQuery();
                hasil = true;
            }
            catch (SqlException)
            {
                hasil = false;
            }
            con.Close();
            return hasil;
        }

        public bool Delete()
        {//fungsi Tambah
            try
            {

                query = "DELETE FROM LoginStaff WHERE Username = '"+ Username +"'";
                con.Open();
                //Membuka Koneksi Database
                command = new SqlCommand();
                command.Connection = con;
                command.CommandText = query;
                command.ExecuteNonQuery();
                hasil = true;
            }
            catch (SqlException)
            {
                hasil = false;
            }
            con.Close();
            return hasil;
        }

        public bool Edit()
        {//fungsi Tambah
            try
            {
                query = "UPDATE LoginStaff SET Password = '"+ Password +"'" +
                            ",Nama = '"+ Nama +"' WHERE Username = '" + Username + "'";
                con.Open();
                //Membuka Koneksi Database
                command = new SqlCommand();
                command.Connection = con;
                command.CommandText = query;
                command.ExecuteNonQuery();
                hasil = true;
            }
            catch (SqlException)
            {
                hasil = false;
            }
            con.Close();
            return hasil;
        }


    }
}

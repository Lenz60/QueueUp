using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace MesinAntri.Model
{
    class InputModel
    {
        private SqlConnection con;
        //deklarasi sql koneksi
        //constructor
        public InputModel()
        {
            //Constructor 
            con = Koneksi.KoneksiDB.GetKoneksi();
        }
        private string Kode;
        private SqlCommand command;
        private bool hasil;
        private string query;

        public string GetKode()
        {
            return Kode;
        }
        public void GetKode(string Kode)
        {
            this.Kode = Kode;
        }

        public bool InputKode(string Kode)
        {
            query = "SELECT * FROM Kdaid WHERE Kd_AntriID = '"+ Kode +"'";
            con.Open();
            SqlCommand command = con.CreateCommand();
            command.CommandText = query;
            SqlDataReader reader = command.ExecuteReader();

            while (reader.Read())
            {
                if ((reader.GetString(0).ToString() == Kode))
                {
                    hasil = true;
                   Controller.Antri2Controller.SetKode(reader.GetString(0).ToString());
                }
                else
                {
                    hasil = false;
                }
            }
            con.Close();
            return hasil;
        }

        

        public DataSet SelectAntrian(string Kode)
        {//Fungsi Tampil data
            //InputKode(Kode);
            DataSet ds = new DataSet();
            try
            {
                con.Open();
                command = new SqlCommand();
                command.Connection = con;
                command.CommandType = CommandType.Text;
                command.CommandText = "SELECT DataID.ID_Pasien as [ID Pasien] , DataID.Nama_Pasien as [Nama], Poli.Nama_Poli as [Poli] ,Dokter.Nama_Dokter as [Dokter], Asuransi.Nama_A as [Asuransi], " +
                                        "Kdaid.Kd_AntriID as [Kode Antrian] FROM DataID JOIN Kdaid ON DataID.ID_Pasien = Kdaid.ID_Pasien JOIN Poli ON Poli.Kd_Poli = Kdaid.Kd_Poli " +
                                        "JOIN Dokter ON Dokter.Kd_Dokter = Kdaid.Kd_Dokter JOIN Asuransi ON Asuransi.Kd_A = Kdaid.kd_A WHERE Kdaid.Kd_AntriID='"+Kode+"'";

                SqlDataAdapter sda = new SqlDataAdapter(command);
                sda.Fill(ds, "Data");
                con.Close();
            }
            catch (SqlException)
            {

            }
            return ds;
        }

    }
}

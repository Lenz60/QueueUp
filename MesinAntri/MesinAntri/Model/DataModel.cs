using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace MesinAntri.Model
{
    class DataModel
    {
        private SqlConnection con;
        //deklarasi sql koneksi
        //constructor
        public DataModel()
        {
            //Constructor 
            con = Koneksi.KoneksiDB.GetKoneksi();
        }
        private string Kode;
        private SqlCommand command;
        private bool hasil;
        private string query;


        public bool SelectNamaP(string Kode)
        {
            query = "SELECT DISTINCT DataID.ID_Pasien, DataID.Nama_Pasien,DataID.JK_ID,DataID.Tgl_Lahir_ID, Kdaid.Kd_Poli,Kdaid.Kd_Dokter, Kdaid.kd_A, Kdaid.Kd_AntriID" +
                "FROM DataID JOIN Kdaid ON DataID.ID_Pasien = Kdaid.ID_Pasien WHERE Kd_AntriID = '"+Kode+"'";
            con.Open();
            SqlCommand command = con.CreateCommand();
            command.CommandText = query;
            SqlDataReader reader = command.ExecuteReader();

            while (reader.Read())
            {
                if ((reader.GetString(0).ToString() == Kode))
                {
                    hasil = true;
                    Controller.Antri2Controller.SetNamaP(reader.GetString(1).ToString());
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

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
    class KodeIDModel
    {
        //[*] SQL Connection & Ccommand [*]
        private SqlConnection con;
        private SqlCommand command;
        //[] Constructor []
        public KodeIDModel()
        {
            con = KoneksiDB.Koneksi.GetKoneksi();
        }
        //
        private string query;
        private bool hasil;
        // 1. Information Hiding
        private string ID;
        private string Poli;
        private string Dokter;
        private string Asuransi;
        private string KodeAID;
        //Encapsulation
        public string GetID()
        {
            return ID;
        }
        public void SetID(string ID)
        {
            this.ID = ID;
        }

        public string GetPoli()
        {
            return Poli;
        }
        public void SetPoli(string Poli)
        {
            this.Poli = Poli;
        }
        //
        public string GetDokter()
        {
            return Dokter;
        }
        public void SetDokter(string Dokter)
        {
            this.Dokter = Dokter;
        }
        //
        public string GetAsuransi()
        {
            return Asuransi;
        }
        public void SetAsuransi(string Asuransi)
        {
            this.Asuransi = Asuransi;
        }
        //
        public string GetKodeAID()
        {
            return KodeAID;
        }
        public void SetKodeAID(string KodeAID)
        {
            this.KodeAID = KodeAID;
        }
        //
        public DataSet SelectAntri()
        {//Fungsi Tampil data
            DataSet ds = new DataSet();
            try
            {
                con.Open();
                command = new SqlCommand();
                command.Connection = con;
                command.CommandType = CommandType.Text;
                command.CommandText = "SELECT DataID.ID_Pasien as [ID Pasien], DataID.Nama_Pasien as [Nama Pasien], Poli.Nama_Poli as [Poli],Dokter.Nama_Dokter as [Dokter], Asuransi.Nama_A as [Asuransi], " +
                                        "Kdaid.Kd_AntriID as [Kode Antri] FROM DataID JOIN Kdaid ON DataID.ID_Pasien = Kdaid.ID_Pasien JOIN Poli ON Poli.Kd_Poli = Kdaid.Kd_Poli " +
                                        "JOIN Dokter ON Dokter.Kd_Dokter = Kdaid.Kd_Dokter JOIN Asuransi ON Asuransi.Kd_A = Kdaid.kd_A";
                SqlDataAdapter sda = new SqlDataAdapter(command);
                sda.Fill(ds, "Data");
                con.Close();
            }
            catch (SqlException)
            {

            }
            return ds;
        }

        public DataSet SelectPoli()
        {
            DataSet ds = new DataSet();
            try
            {
                con.Open();
                command = new SqlCommand();
                command.Connection = con;
                command.CommandType = CommandType.Text;
                command.CommandText = "SELECT * FROM Poli";
                SqlDataAdapter sda = new SqlDataAdapter(command);
                sda.Fill(ds, "Poli");
                con.Close();
            }
            catch (SqlException)
            {

            }
            return ds;
        }

        public DataSet SelectDokter()
        {
            DataSet ds = new DataSet();
            try
            {
                con.Open();
                command = new SqlCommand();
                command.Connection = con;
                command.CommandType = CommandType.Text;
                command.CommandText = "SELECT * FROM Dokter";
                SqlDataAdapter sda = new SqlDataAdapter(command);
                sda.Fill(ds, "Dokter");
                con.Close();
            }
            catch (SqlException)
            {

            }
            return ds;
        }
        public DataSet SelectAsuransi()
        {
            DataSet ds = new DataSet();
            try
            {
                con.Open();
                command = new SqlCommand();
                command.Connection = con;
                command.CommandType = CommandType.Text;
                command.CommandText = "SELECT * FROM Asuransi";
                SqlDataAdapter sda = new SqlDataAdapter(command);
                sda.Fill(ds, "Asuransi");
                con.Close();
            }
            catch (SqlException)
            {

            }
            return ds;
        }

         public void polii(string pol)
         {//Untuk menconvert text pada Combo box ke Kode Tertentu yang sudah tercatat
             //di database
             if(pol == "Umum[A]")
             {
                 Poli = "A01";
             }
             else if(pol == "Saraf[B]")
             {
                 Poli = "B01";
             }
             else if(pol == "Orthopedi[C]")
             {
                 Poli = "C01";
             }
             else if (pol == "THT[D]")
             {
                 Poli = "D01";
             }
            else if (pol == "Gigi[E]")
            {
                Poli = "E01";
            }
            else if (pol == "Anak[F]")
            {
                Poli = "F01";
            }
            else if (pol == "Kulit dan Kelamin[G]")
            {
                Poli = "G01";
            }
            else if (pol == "Penyakit Dalam[H]")
            {
                Poli = "H01";
            }
            else if (pol == "Mata[I]")
            {
                Poli = "I01";
            }
            else if (pol == "Kandungan[J]")
            {
                Poli = "J01";
            }

        }
        

         public void docc(string doc)
         {//Untuk menconvert text pada Combo box ke Kode Tertentu yang sudah tercatat
             //di database
             if (doc == "Jakurai")
             {
                 Dokter = "D01";
             }
             else if (doc == "Shiki")
             {
                 Dokter = "D02";
             }
             else if (doc == "Kaoru")
             {
                 Dokter = "D03";
             }
               else if (doc == "Muzaki")
             {
                 Dokter = "D04";
             }
            else if (doc == "Demian")
            {
                Dokter = "D05";
            }
            else if (doc == "Rafael")
            {
                Dokter = "D06";
            }
            else if (doc == "Anto")
            {
                Dokter = "D07";
            }
            else if (doc == "Tri")
            {
                Dokter = "D08";
            }
            else if (doc == "Agung")
            {
                Dokter = "D09";
            }
            else if (doc == "Linda")
            {
                Dokter = "D10";
            }
            else if (doc == "Rumi")
            {
                Dokter = "D11";
            }

        }

         public void insur(string ansur)
         {//Untuk menconvert text pada Combo box ke Kode Tertentu yang sudah tercatat
             //di database
             if (ansur == "BPJS")
             {
                 Asuransi = "AS01";
             }
            else if (ansur == "Prudential")
            {
                Asuransi = "AS02";
            }
            else if (ansur == "AXAMandiri")
            {
                Asuransi = "AS03";
            }
            else if (ansur == "BMPutera19")
            {
                Asuransi = "AS04";
            }
            else if (ansur == "IFinancial")
            {
                Asuransi = "AS05";
            }
            else if (ansur == "Jiwasraya")
            {
                Asuransi = "AS06";
            }
            else if (ansur == "Avrist")
             {
                 Asuransi = "AS07";
             }
            else if (ansur == "Sinarmas")
            {
                Asuransi = "AS08";
            }
            else if (ansur == "Lain-Lain")
            {
                Asuransi = "AS09";
            }


        }
         
        public bool cek(string ID)
        {//fungsi cek
            query = "SELECT ID_Pasien FROM DataID WHERE ID_Pasien='" + ID + "'";
            con.Open();
            SqlCommand command = con.CreateCommand();
            command.CommandText = query;
            SqlDataReader reader = command.ExecuteReader();
            while (reader.Read()==true)
            {
                
                if ((reader.GetString(0).ToString() == ID))
                {
                    hasil = true;
                    
                }
                else
                {
                    hasil = false;
                }
            }
            con.Close();
            return hasil;
        }
        public bool Tambah(string pol, string doc, string ansur)
        {//fungsi Tambah
            try
            {
                ////////// Pemanggilan Fungsi Set Combobox dengan parameter value combobox ///////
                polii(pol);
                docc(doc);
                insur(ansur);
                //////////////////////////////////////////////////////////////////////////////////
                query = "INSERT INTO Kdaid values ('" + KodeAID + "','" + ID + "','" + Poli + "','" + Dokter + "','" + Asuransi + "')";
                con.Open();
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

        public DataSet SelectID()
        {
            DataSet ds = new DataSet();
            try
            {
                con.Open();
                command = new SqlCommand();
                command.Connection = con;
                command.CommandType = CommandType.Text;
                command.CommandText = "SELECT ID_Pasien as [ID Pasien], Nama_Pasien as [Nama Pasien], JK_ID as [Jenis Kelamin],"
                                         +"Tgl_Lahir_ID [Tanggal Lahir] FROM DataID";
                SqlDataAdapter sda = new SqlDataAdapter(command);
                sda.Fill(ds, "IDPasien");
                con.Close();
            }
            catch (SqlException)
            {

            }
            return ds;

        }
        /*
         ********************* FUNGSI EDIT DI HILANGKAN(Revisi) ********
        public bool Edit(string pol, string doc, string ansur)
        {//fungsi edit
            try
            {
                polii(pol);
                docc(doc);
                insur(ansur);
                query = "UPDATE Kdaid SET ID_Pasien = '"+ID+"',Kd_Poli = '"+Poli+
                        "',Kd_Dokter = '"+Dokter+"',Kd_A = '"+Asuransi+ "' WHERE Kd_AntriID = '" + KodeAID + "'";
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
        ************************ FUNGSI DELETE  DIHILANGKAN(Revisi) *******
        public bool Delete(string pol, string doc, string ansur)
        {//fungsi delete
            try
            {
                polii(pol);
                docc(doc);
                insur(ansur);
                query = "DELETE FROM DataID WHERE ID_Pasien = '"+ID+"'"+ 
                    "DELETE FROM Poli WHERE Kd_Poli = '"+Poli+"' DELETE FROM Dokter WHERE Kd_Dokter = '"+Dokter+ " '"+
                    "DELETE FROM Kdaid WHERE Kd_AntriID = '" + KodeAID + "'";
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
        */
    }
}
    


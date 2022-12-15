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
    class RecordModel
    {
        //1.Information Hiding
        private string Poli;
        private string Dokter;
        private SqlConnection con;
        private string query;
        private SqlCommand command;
        //[] Constructor []
        public RecordModel()
        {
            con = KoneksiDB.Koneksi.GetKoneksi();
        }
        //2. Encapsulation
        public string GetPoli()
        {
            return Poli;
        }
        public void SetPoli(string Poli)
        {
            this.Poli = Poli;
        }
        public string GetDokter()
        {
            return Dokter;
        }
        public void SetDokter(string Dokter)
        {
            this.Dokter = Dokter;
        }
        //3.Functions
        public void polii(string pol)
        {//Untuk menconvert text pada Combo box ke Kode Tertentu yang sudah tercatat
         //di database
            if (pol == "Umum")
            {
                Poli = "A01";
            }
            else if (pol == "Saraf")
            {
                Poli = "B01";
            }
            else if (pol == "Orthopedi")
            {
                Poli = "C01";
            }
            else if (pol == "THT")
            {
                Poli = "D01";
            }
            else if (pol == "Gigi")
            {
                Poli = "E01";
            }
            else if (pol == "Anak")
            {
                Poli = "F01";
            }
            else if (pol == "Kulit dan Kelamin")
            {
                Poli = "G01";
            }
            else if (pol == "Penyakit Dalam")
            {
                Poli = "H01";
            }
            else if (pol == "Mata")
            {
                Poli = "I01";
            }
            else if (pol == "Kandungan")
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
        public void RecordData(string rec, string pol, string doc )
        {
            //variable query memiliki banyak query berdasarkan pilihan pada combo box
            polii(pol);
            docc(doc);       
            if(rec == "Data Antrian")
            {
                query = "SELECT DataID.ID_Pasien as [ID Pasien], DataID.Nama_Pasien as [Nama Pasien], Poli.Nama_Poli as [Poli],Dokter.Nama_Dokter as [Dokter], Asuransi.Nama_A as [Asuransi], " +
                                        "Kdaid.Kd_AntriID FROM DataID JOIN Kdaid ON DataID.ID_Pasien = Kdaid.ID_Pasien JOIN Poli ON Poli.Kd_Poli = Kdaid.Kd_Poli " +
                                        "JOIN Dokter ON Dokter.Kd_Dokter = Kdaid.Kd_Dokter JOIN Asuransi ON Asuransi.Kd_A = Kdaid.kd_A";
            }     
            else if(rec == "Jumlah Antrian Pasien")
            {
                query = "SELECT COUNT(Kd_AntriID) as [Jumlah Seluruh Antrian]  FROM Kdaid";
            }

            else if(rec == "Jumlah Pengantri dari Poli")
            {
                query = "SELECT COUNT(Kd_AntriID) as 'Jumlah Antrian di Poli "+pol+"'  FROM Kdaid WHERE Kd_Poli='" + Poli + "'";
            }
            else if (rec == "Jumlah Pengantri dari Dokter")
            {
                query = "SELECT COUNT(Kd_AntriID) as 'Jumlah Antrian di Dokter "+doc+"'  FROM Kdaid WHERE Kd_Dokter='" + Dokter + "'";
            }
            else if (rec == "Data Pengantri yang dilayani Dokter")
            {
                query = "SELECT DataID.ID_Pasien as [ID Pasien], DataID.Nama_Pasien as [Nama Pasien], Poli.Nama_Poli as [Poli],Dokter.Nama_Dokter as [Dokter], Asuransi.Nama_A as [Asuransi], " +
                                        "Kdaid.Kd_AntriID FROM DataID JOIN Kdaid ON DataID.ID_Pasien = Kdaid.ID_Pasien JOIN Poli ON Poli.Kd_Poli = Kdaid.Kd_Poli " +
                                        "JOIN Dokter ON Dokter.Kd_Dokter = Kdaid.Kd_Dokter JOIN Asuransi ON Asuransi.Kd_A = Kdaid.kd_A WHERE Kdaid.Kd_Dokter = '"+ Dokter +"'";
            }
            else if (rec == "Data Pengantri yang dilayani Poli")
            {
                query = "SELECT DataID.ID_Pasien as [ID Pasien], DataID.Nama_Pasien as [Nama Pasien], Poli.Nama_Poli as [Poli],Dokter.Nama_Dokter as [Dokter], Asuransi.Nama_A as [Asuransi], " +
                                        "Kdaid.Kd_AntriID FROM DataID JOIN Kdaid ON DataID.ID_Pasien = Kdaid.ID_Pasien JOIN Poli ON Poli.Kd_Poli = Kdaid.Kd_Poli " +
                                        "JOIN Dokter ON Dokter.Kd_Dokter = Kdaid.Kd_Dokter JOIN Asuransi ON Asuransi.Kd_A = Kdaid.kd_A WHERE Kdaid.Kd_Poli = '" + Poli + "'";
            }
        }
        public DataSet SelectNormal()
        {
            DataSet ds = new DataSet();
            try
            {
                con.Open();
                command = new SqlCommand();
                command.Connection = con;
                command.CommandType = CommandType.Text;
                command.CommandText = "SELECT DataID.ID_Pasien as [ID Pasien], DataID.Nama_Pasien as [Nama Pasien], Poli.Nama_Poli as [Poli],Dokter.Nama_Dokter as [Dokter], Asuransi.Nama_A as [Asuransi], " +
                                        "Kdaid.Kd_AntriID FROM DataID JOIN Kdaid ON DataID.ID_Pasien = Kdaid.ID_Pasien JOIN Poli ON Poli.Kd_Poli = Kdaid.Kd_Poli " +
                                        "JOIN Dokter ON Dokter.Kd_Dokter = Kdaid.Kd_Dokter JOIN Asuransi ON Asuransi.Kd_A = Kdaid.kd_A";
                SqlDataAdapter sda = new SqlDataAdapter(command);
                sda.Fill(ds, "SelectNormal");
                con.Close();
            }
            catch (SqlException)
            {

            }
            return ds;

        }

        public DataSet SelectRecord(string rec, string pol, string doc)
        {
                RecordData(rec, pol, doc);
                polii(pol);
                docc(doc);
                SqlDataAdapter da = new SqlDataAdapter();
                SqlCommand cmd = con.CreateCommand();
                cmd.CommandText = query;
                da.SelectCommand = cmd;
                DataSet ds = new DataSet();

                con.Open();
                da.Fill(ds);
                con.Close();

                return ds;
            }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Antrian.KoneksiDB
{
    
    class Koneksi
    {
        private static SqlConnection koneksi;
        //Deklarasi SqlKoneksi
        public static SqlConnection GetKoneksi()
        {
            //Menyambungkan App ke Database
            koneksi = new SqlConnection();
            koneksi.ConnectionString = "Data Source=T:\\Antrian\\Kumpul\\Antrian_dat.mdf;" +
                                        "Initial Catalog=AntrianRS;" +
                                        "Integrated Security=True;";
            //dengan server DESKTOP-L8FCLTB pada bagian katalog atau database AntrianRS
            return koneksi;
            //mengembalikan value koneksi
        }
    }
}

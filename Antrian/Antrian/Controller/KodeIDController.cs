using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Antrian.View;
using System.Data;

namespace Antrian.Controller
{
    class KodeIDController
    {
        //Declaration
        private View.LoginWindow viewLogin;
        private Model.KodeIDModel modelKodeID;
        private InputanWindow inputanWindow;
        private View.IDWindow viewID;

        public KodeIDController(View.LoginWindow viewLogin)
        {
            //Instansi Constructor
            this.viewLogin = viewLogin;
            modelKodeID = new Model.KodeIDModel();
        }

        public KodeIDController(InputanWindow inputanWindow)
        {//Instansi Constructor
            this.inputanWindow = inputanWindow;
        }
        public KodeIDController(View.IDWindow viewID)
        {//Instansi Constructor
            this.viewID = viewID;
            modelKodeID = new Model.KodeIDModel();
        }

        public void Select()
        {//menyambungkan fungsi dataset pada model ke view
            DataSet data = modelKodeID.SelectAntri();
            viewID.DGID.ItemsSource = data.Tables[0].DefaultView;

        }
        
        public bool Tambah()
        {//penghubungan fungsi tambah pada model ke view
            modelKodeID.SetPoli(viewID.CmbPoli.Text);
            modelKodeID.SetDokter(viewID.CmbDokter.Text);
            modelKodeID.SetAsuransi(viewID.CmbAs.Text);
            modelKodeID.SetKodeAID(viewID.TxtKA2.Text);
            modelKodeID.SetID(viewID.TxtID.Text);
            bool hasil = modelKodeID.Tambah(viewID.CmbPoli.Text,viewID.CmbDokter.Text,
                viewID.CmbAs.Text);
            return hasil;
        }
        /*
        public bool Edit()
        {//penghubungan fungsi Edit pada model ke view
            modelKodeID.SetKodeAID(viewID.TxtKA2.Text);
            modelKodeID.SetID(viewID.TxtID.Text);
            modelKodeID.SetPoli(viewID.CmbPoli.Text);
            modelKodeID.SetDokter(viewID.CmbDokter.Text);
            modelKodeID.SetAsuransi(viewID.CmbAs.Text);
            bool hasil = modelKodeID.Edit(viewID.CmbPoli.Text, viewID.CmbDokter.Text, viewID.CmbAs.Text);
            return hasil;
        }


        public bool Delete()
        {//penghubungan fungsi Delete pada model ke view
            modelKodeID.SetKodeAID(viewID.TxtKA2.Text);
            modelKodeID.SetID(viewID.TxtID.Text);
            modelKodeID.SetPoli(viewID.CmbPoli.Text);
            modelKodeID.SetDokter(viewID.CmbDokter.Text);
            modelKodeID.SetAsuransi(viewID.CmbAs.Text);
            bool hasil = modelKodeID.Delete(viewID.CmbPoli.Text, viewID.CmbDokter.Text, viewID.CmbAs.Text);
            return hasil;
        }
        */
        public bool cek()
        {//penghubungan fungsi Cek pada model ke view
            bool hasil = modelKodeID.cek(viewID.TxtID.Text);
            return hasil;
        }

    }
}

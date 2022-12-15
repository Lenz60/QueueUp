using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace MesinAntri.Controller
{
    class Antri2Controller
    {
        private View.MesinAntri1Window viewAntri1;
        private Model.InputModel ModelInput;
        private Model.DataModel ModelData;
        private View.MesinAntri2Window viewAntri2;
        private static String Kode;
        private static String NamaP;

        public Antri2Controller(View.MesinAntri1Window viewAntri1)
        {
            //Instansi Constructor
            this.viewAntri1 = viewAntri1;
            ModelInput = new Model.InputModel();
        }

        public Antri2Controller(View.MesinAntri2Window viewAntri2)
        {
            
            this.viewAntri2 = viewAntri2;
            ModelInput = new Model.InputModel();
            
        }


        public static string GetKode()
        {
            return Kode;
        }

        public static void SetKode(String Kode)
        {
            Antri2Controller.Kode = Kode;
        }

        public static string GetNamaP()
        {
            return NamaP;
        }
        //Antri2B/////////////////////////////////////////
        public static void SetNamaP(String NamaP)
        {
            Antri2Controller.NamaP = NamaP;
        }
        //Antri2B
        public bool SelectPasien()
        {
            bool hasil = ModelData.SelectNamaP(GetKode());
            return hasil;
            
        }
      
        ///////////////////////////////////////////////



        public void Select()
        {//menyambungkan fungsi dataset pada model ke view
           
            DataSet data = ModelInput.SelectAntrian(GetKode());
            viewAntri2.DGAntrian.ItemsSource = data.Tables[0].DefaultView;

        }

       
    }
}

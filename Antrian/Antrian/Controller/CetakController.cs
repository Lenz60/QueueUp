using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Antrian.View;
using System.IO;


namespace Antrian.Controller
{
    class CetakController
    {
        private Model.CetakModel modelCetak;
        private View.IDWindow viewID;
        private View.Form1 viewCetak;

        public CetakController(View.IDWindow viewID)
        {//Instansi Constructor
            this.viewID = viewID;
            modelCetak = new Model.CetakModel();
        }

        public CetakController(View.Form1 ViewCetak)
        {//Instansi Constructor
            this.viewCetak = ViewCetak;
            modelCetak = new Model.CetakModel();
            
        }

        public void Cetak()
        {
            modelCetak.Cetak(viewID.TxtKA2.Text.ToString());
        }


    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MesinAntri.Controller
{
    class CetakController
    {
        private View.MesinAntri1Window viewAntri1;
        private Model.InputModel ModelInput;
        private Model.CetakModel ModelCetak;
        private View.MesinAntri2Window viewAntri2;
        private View.CetakForm viewCetak;

        public CetakController(View.MesinAntri1Window viewAntri1)
        {
            //Instansi Constructor
            this.viewAntri1 = viewAntri1;
            ModelInput = new Model.InputModel();
        }

        public CetakController(View.MesinAntri2Window viewAntri2)
        {

            this.viewAntri2 = viewAntri2;
            ModelCetak = new Model.CetakModel();

        }

        public void Cetak()
        {
            ModelCetak.Cetak(viewAntri2.LblNoAntri.Content.ToString());
        }

    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;


namespace MesinAntri.Controller
{
    class Antri1Controller
    {
        private View.MesinAntri1Window viewAntri1;
        private Model.InputModel ModelInput;
        private View.MesinAntri2Window viewAntri2;

        public Antri1Controller(View.MesinAntri1Window viewAntri1)
        {
            //Instansi Constructor
            this.viewAntri1 = viewAntri1;
            ModelInput = new Model.InputModel();
        }

        public Antri1Controller(View.MesinAntri2Window viewAntri2)
        {
            this.viewAntri2 = viewAntri2;
        }

        public bool Input()
        {
            bool hasil = ModelInput.InputKode(viewAntri1.TxtInput.Text);
            return hasil;
        }
       



    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Antrian.View;
using System.Data;

namespace Antrian.Controller
{
    class MemberIDController
    {
        //Deklarasi Constructor
        private View.LoginWindow viewLogin;
        private Model.KodeIDModel modelKodeID;
        private InputanWindow inputanWindow;
        private View.IDMemberWindow viewMemberID;

        public MemberIDController(View.LoginWindow viewLogin)
        {
            //Instansi Constructor
            this.viewLogin = viewLogin;
            modelKodeID = new Model.KodeIDModel();
        }

        public MemberIDController(InputanWindow inputanWindow)
        {//Instansi Constructor
            this.inputanWindow = inputanWindow;
        }
        public MemberIDController(View.IDMemberWindow viewMemberID)
        {//Instansi Constructor
            this.viewMemberID = viewMemberID;
            modelKodeID = new Model.KodeIDModel();
        }

        public void SelectMember()
        {//menyambungkan fungsi dataset pada model ke view
            DataSet data = modelKodeID.SelectID();
            viewMemberID.DGMember.ItemsSource = data.Tables[0].DefaultView;

        }

    }
}

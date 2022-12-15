using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Antrian.View;
using System.Data;

namespace Antrian.Controller
{
    class StaffController
    {
        //Deklarasi Konstruktor
        private View.AdminWindow viewLogin;
        private Model.StaffModel modelStaff;
        private View.AdminHomeWindow viewAdmin;
        private View.AdminStaffRegPage viewStaffReg;

        public StaffController(View.AdminWindow viewLogin)
        {
            //Instansi Constructor
            this.viewLogin = viewLogin;
            modelStaff = new Model.StaffModel();
        }

        public StaffController(View.AdminStaffRegPage viewStaffReg)
        {
            //Instansi Constructor
            this.viewStaffReg = viewStaffReg;
            modelStaff = new Model.StaffModel();
        }

        public StaffController(View.AdminHomeWindow viewAdmin)
        {//Instansi Constructor
            this.viewAdmin = viewAdmin;
        }

        public void Select()
        {//menyambungkan fungsi dataset pada model ke view
            DataSet data = modelStaff.SelectStaff();
            viewStaffReg.DGStaff.ItemsSource = data.Tables[0].DefaultView;
        }

        public bool InsertStaff()
        {
            modelStaff.SetUsername(viewStaffReg.TxtUsername.Text.ToString());
            modelStaff.SetPassword(viewStaffReg.PBPassword.Password.ToString());
            modelStaff.SetNama(viewStaffReg.TxtNama.Text.ToString());
            bool hasil = modelStaff.Tambah();
            return hasil;
        }

        public bool EditStaff()
        {
            modelStaff.SetUsername(viewStaffReg.TxtUsername.Text.ToString());
            modelStaff.SetPassword(viewStaffReg.PBPassword.Password.ToString());
            modelStaff.SetNama(viewStaffReg.TxtNama.Text.ToString());
            bool hasil = modelStaff.Edit();
            return hasil;
        }

        public bool Delete()
        {
            modelStaff.SetUsername(viewStaffReg.TxtUsername.Text.ToString());
            modelStaff.SetPassword(viewStaffReg.PBPassword.Password.ToString());
            modelStaff.SetNama(viewStaffReg.TxtNama.Text.ToString());
            bool hasil = modelStaff.Delete();
            return hasil;
        }
    }
}

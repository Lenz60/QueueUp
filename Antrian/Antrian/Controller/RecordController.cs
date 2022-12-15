using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Antrian.View;
using System.Data;

namespace Antrian.Controller
{
    class RecordController
    {
        //Deklarasi Constructor
        private View.AdminWindow viewLogin;
        private Model.RecordModel modelRecord;
        private View.AdminHomeWindow viewAdmin;
        private View.AdminStaffRegPage viewStaffReg;
        private View.AdminRecordPage viewRecord;

        public RecordController(View.AdminWindow viewLogin)
        {
            //Instansi Constructor
            this.viewLogin = viewLogin;
            modelRecord = new Model.RecordModel();
        }

        public RecordController(View.AdminStaffRegPage viewStaffReg)
        {
            //Instansi Constructor
            this.viewStaffReg = viewStaffReg;
            modelRecord = new Model.RecordModel();
        }

        public RecordController(View.AdminRecordPage viewRecord)
        {
            //Instansi Constructor
            this.viewRecord = viewRecord;
            modelRecord = new Model.RecordModel();
        }

        public RecordController(View.AdminHomeWindow viewAdmin)
        {//Instansi Constructor
            this.viewAdmin = viewAdmin;
        }

        public void Select()
        {//penghubungan fungsi tambah pada model ke view
            DataSet data = modelRecord.SelectNormal();
            viewRecord.DGRecord.ItemsSource = data.Tables[0].DefaultView;
        }

        public void SelectRecordData()
        {//penghubungan fungsi tambah pada model ke view
            modelRecord.SetPoli(viewRecord.CmbRecordPoli.Text);
            modelRecord.SetDokter(viewRecord.CmbRecordDokter.Text);
            DataSet data = modelRecord.SelectRecord(viewRecord.CmbRecord.Text, viewRecord.CmbRecordPoli.Text,
                 viewRecord.CmbRecordDokter.Text);
            viewRecord.DGRecord.ItemsSource = data.Tables[0].DefaultView;
        }
    }
}

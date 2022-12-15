using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Antrian.View
{
    /// <summary>
    /// Interaction logic for AdminRecordPage.xaml
    /// </summary>
    public partial class AdminRecordPage : Page
    {
        //Deklarasi Constructor
        Controller.RecordController ControllerRecord;
        public AdminRecordPage()
        {
            InitializeComponent();
            //Instance
            ControllerRecord = new Controller.RecordController(this);
            Tampil();
        }
        //Select Data Antrian
        public void Tampil()
        {
            ControllerRecord.Select();           
        }
        //Select Record berdasarkan inputan
        private void BtnTambah_Click(object sender, RoutedEventArgs e)
        {
            ControllerRecord.SelectRecordData();            
        }
    }
}

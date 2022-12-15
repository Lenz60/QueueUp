using System;
using System.Collections.Generic;
using System.Data;
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
    /// Interaction logic for AdminStaffRegPage.xaml
    /// </summary>
    public partial class AdminStaffRegPage : Page
    {
        //Deklarasi Constructor
        private Controller.StaffController ControllerStaff;
        //
        private bool hasil;
        public AdminStaffRegPage()
        {
            InitializeComponent();
            //Instance
            ControllerStaff = new Controller.StaffController(this);
            Tampil();
            //Maks Character Textboxt Username
            TxtUsername.MaxLength = 4;
           
        }
        //Select * Data antrian
        public void Tampil()
        {
            ControllerStaff.Select();
        }

        private void BtnTambah_Click(object sender, RoutedEventArgs e)
        {
            Insert();
            Tampil();
        }
        //Shortcut key Input data
        private void PBPassword_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Enter)
            {
                BtnTambah_Click(sender, e);
            }
        }

        public void Insert()
        {
            hasil = ControllerStaff.InsertStaff();
            if (hasil == true)
            {
                MessageBox.Show("Data Berhasil Disimpan");
            }
            else
            {
                MessageBox.Show("Penyimpanan Data Gagal\n Silahkan Cek Inputan Anda");
            }
        }

        public void Edit()
        {
            hasil = ControllerStaff.EditStaff();
            if (hasil == true)
            {
                MessageBox.Show("Data Berhasil Diubah");
            }
            else
            {
                MessageBox.Show("Data Gagal Diubah\n Silahkan Cek Inputan Anda");
            }
        }

        public void Delete()
        {
            hasil = ControllerStaff.Delete();
            if (hasil == true)
            {
                MessageBox.Show("Data Berhasil Dihapus");
            }
            else
            {
                MessageBox.Show("Penghapusan Data Gagal\n Silahkan Cek Inputan Anda");
            }
            
        }

        private void BtnEdit_Click(object sender, RoutedEventArgs e)
        {
            Edit();
            Tampil();
        }

        private void BtnDelete_Click(object sender, RoutedEventArgs e)
        {
            Delete();
            Tampil();
        }

        private void TxtUsername_KeyDown(object sender, KeyEventArgs e)
        {
            //Shortcut Key clear password text
            if (e.Key == Key.Tab)
            {
                PBPassword.Password="";
            }
        }

        //Bind Datagrid Value ke Textbox
        private void DGStaff_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            DataGrid gd = (DataGrid)sender;
            DataRowView row_selected = gd.SelectedItem as DataRowView;
                if (row_selected != null)
            {
                TxtNama.Text = row_selected["Nama Staff"].ToString();
                TxtUsername.Text = row_selected["Username"].ToString();
                PBPassword.Password = row_selected["Password"].ToString();
            }
        }
    }
}

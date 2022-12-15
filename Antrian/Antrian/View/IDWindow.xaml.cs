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
using System.Windows.Shapes;
using System.Windows.Threading;
using System.IO;
using iTextSharp.text;
using iTextSharp.text.pdf;
using System.Data;

namespace Antrian.View
{
    /// <summary>
    /// Interaction logic for IDWindow.xaml
    /// </summary>
    public partial class IDWindow : Window
    {
        private Controller.KodeIDController KodeIDController;
        private Controller.CetakController CetakController;
        private bool hasil;

        public IDWindow()
        {
            
            InitializeComponent();
            KodeIDController = new Controller.KodeIDController(this);
            CetakController = new Controller.CetakController(this);    
            DispatcherTimer timer = new DispatcherTimer(new TimeSpan(0, 0, 1), DispatcherPriority.Normal, delegate
            {
                this.dateText.Text = DateTime.Now.ToString("dd-MMMM-yyyy HH:mmmm:ss");
            }, this.Dispatcher);
            Tampil();
            TxtKA2.MaxLength = 4;
            TxtID.MaxLength = 4;
        }

        private void BtnCek_Click(object sender, RoutedEventArgs e)
        {
            
            if(KodeIDController.cek() == true)
            {
                MessageBox.Show("Member ID Sudah tersedia");
                MessageBox.Show("Silahkan Isi Daftar");
            }
            else
            {
                MessageBox.Show("Member ID Tidak Tersedia");
                TxtID.Text = "";
            }
            Tampil();            
        }

        private void BtnSimpan_Click(object sender, RoutedEventArgs e)
        {
            
            hasil = KodeIDController.Tambah();
            if (hasil == true)
            {
                MessageBox.Show("Data berhasil disimpan");
            }
            else
            {
                MessageBox.Show("Penyimpanan data gagal");
                MessageBox.Show("Silahkan Dicek Kembali Inputannya");
            }
            Tampil();
        }

        private void LblPatientID_Click(object sender, RoutedEventArgs e)
        {
           
        }

        private void CmbPoli_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            
        }

        private void CmbDokter_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
           
        }

        private void CmbAs_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
           
        }
        private void BtnCetak_MouseDown(object sender, MouseButtonEventArgs e)
        {
            
        }        
        private void BtnCetak_Click(object sender, RoutedEventArgs e)
        {
            CetakController.Cetak();
            CetakForm();
        }

        private void TxtKA2_TextChanged(object sender, TextChangedEventArgs e)
        {
            
        }

        private void label_MouseDown(object sender, MouseButtonEventArgs e)
        {

        }

        private void TxtKA2_KeyDown(object sender, KeyEventArgs e)
        {
            ShorcutSave(sender, e);
            Back2(e);
            ShorcutPrint(sender, e);
        }

        private void ImgDataID_MouseDown(object sender, MouseButtonEventArgs e)
        {
            ViewIDMember();
        }

        private void ImgDataID_KeyDown(object sender, KeyEventArgs e)
        {
            
        }

        private void ImgDataID_MouseMove(object sender, MouseEventArgs e)
        {
            
        }

        private void BtnBack_MouseDown(object sender, MouseButtonEventArgs e)
        {
            Back();
        }

        private void TxtID_KeyDown(object sender, KeyEventArgs e)
        {
            ShorcutID();
            Back2(e);
        }


        //////////////////////////////// Functions /////////////////////////////////
        public void Tampil()
        {
            KodeIDController.Select();
            TxtID.Focus();
        }

        public void Back()
        {
            InputanWindow Input = new InputanWindow();
            Input.Show();
            this.Close();
        }

        public void Back2(KeyEventArgs e)
        {
            if (e.Key == Key.Escape)
            {
                Back();
            }
        }

        public void ViewIDMember()
        {
            IDMemberWindow IDMember = new IDMemberWindow();
            IDMember.Show();
        }

        public void ShorcutID()
        {
            if (Keyboard.IsKeyDown(Key.LeftCtrl) && Keyboard.IsKeyDown(Key.E))
            {
                ViewIDMember();
            }
        }

        public void ShorcutPrint(object sender, RoutedEventArgs e)
        {
            if (Keyboard.IsKeyDown(Key.LeftCtrl) && Keyboard.IsKeyDown(Key.P))
            {
                BtnCetak_Click(sender, e);
            }
        }

        public void ShorcutSave(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Enter)
            {
                BtnSimpan_Click(sender, e);
            }
        }

        public void CetakForm()
        {
            Form1 form = new Form1();
            form.Show();
        }

        private void DGID_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            DataGrid gd = (DataGrid)sender;
            DataRowView row_selected = gd.SelectedItem as DataRowView;
            if (row_selected != null)
            {
                TxtID.Text = row_selected["ID Pasien"].ToString();
                TxtKA2.Text = row_selected["Kode Antri"].ToString();
            }
        }


        //////////////////////////////////////////////////////////////////


    }
}

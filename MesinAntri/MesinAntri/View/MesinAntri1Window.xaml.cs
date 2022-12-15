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

namespace MesinAntri.View
{
    /// <summary>
    /// Interaction logic for MesinAntri1Window.xaml
    /// </summary>
    public partial class MesinAntri1Window : Window
    {
        Controller.Antri1Controller AntriController;
        public MesinAntri1Window()
        {
            InitializeComponent();
            AntriController = new Controller.Antri1Controller(this);
            Date();

        }

        public void Date()
        {
            DispatcherTimer timer = new DispatcherTimer(new TimeSpan(0, 0, 1), DispatcherPriority.Normal, delegate
            {
                this.dateText.Text = DateTime.Now.ToString("dd-MMMM-yyyy HH:mmmm:ss");
            }, this.Dispatcher);
        }

        private void BtnEnter_Click(object sender, RoutedEventArgs e)
        {
            if(AntriController.Input() == true)
            {

                MesinAntri2Window antri2 = new MesinAntri2Window();
                antri2.Show();
               this.Close();
               
            }
            else
            {
                MessageBox.Show("Inputan atau Kode Antri Tidak Tersedia");
            }
        }

        
        private void BtnA_Click(object sender, RoutedEventArgs e)
        {
            TxtInput.Text = TxtInput.Text + "A";
        }

        private void Btn1_Click(object sender, RoutedEventArgs e)
        {
            TxtInput.Text = TxtInput.Text + "1";
        }

        private void Btn2_Click(object sender, RoutedEventArgs e)
        {
            TxtInput.Text = TxtInput.Text + "2";
        }

        private void Btn3_Click(object sender, RoutedEventArgs e)
        {
            TxtInput.Text = TxtInput.Text + "3";
        }

        private void BtnB_Click(object sender, RoutedEventArgs e)
        {
            TxtInput.Text = TxtInput.Text + "B";
        }

        private void Btn4_Click(object sender, RoutedEventArgs e)
        {
            TxtInput.Text = TxtInput.Text + "4";
        }

        private void Btn5_Click(object sender, RoutedEventArgs e)
        {
            TxtInput.Text = TxtInput.Text + "5";
        }

        private void Btn6_Click(object sender, RoutedEventArgs e)
        {
            TxtInput.Text = TxtInput.Text + "6";
        }

        private void BtnC_Click(object sender, RoutedEventArgs e)
        {
            TxtInput.Text = TxtInput.Text + "C";
        }

        private void Btn7_Click(object sender, RoutedEventArgs e)
        {
            TxtInput.Text = TxtInput.Text + "7";
        }

        private void Btn8_Click(object sender, RoutedEventArgs e)
        {
            TxtInput.Text = TxtInput.Text + "8";
        }

        private void Btn9_Click(object sender, RoutedEventArgs e)
        {
            TxtInput.Text = TxtInput.Text + "9";
        }

        private void BtnD_Click(object sender, RoutedEventArgs e)
        {
            TxtInput.Text = TxtInput.Text + "D";
        }

        private void Btn0_Click(object sender, RoutedEventArgs e)
        {
            TxtInput.Text = TxtInput.Text + "0";
        }

        private void BtnHapus_Click(object sender, RoutedEventArgs e)
        {
            TxtInput.Text = "";
        }
        private void BtnE_Click(object sender, RoutedEventArgs e)
        {
            TxtInput.Text = TxtInput.Text + "E";
        }

        private void BtnF_Click(object sender, RoutedEventArgs e)
        {
            TxtInput.Text = TxtInput.Text + "F";
        }

        private void BtnG_Click(object sender, RoutedEventArgs e)
        {
            TxtInput.Text = TxtInput.Text + "G";
        }

        private void BtnH_Click(object sender, RoutedEventArgs e)
        {
            TxtInput.Text = TxtInput.Text + "H";
        }

        private void BtnI_Click(object sender, RoutedEventArgs e)
        {
            TxtInput.Text = TxtInput.Text + "I";
        }

        private void BtnJ_Click(object sender, RoutedEventArgs e)
        {
            TxtInput.Text = TxtInput.Text + "J";
        }
    }
}

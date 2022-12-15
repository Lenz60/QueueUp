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
    /// Interaction logic for MesinAntri2Window.xaml
    /// </summary>
    public partial class MesinAntri2Window : Window
    {
        Controller.Antri2Controller Antri2Controller;
        Controller.CetakController CetakController;
        public MesinAntri2Window()
        {
            InitializeComponent();
            Antri2Controller = new Controller.Antri2Controller(this);
            CetakController = new Controller.CetakController(this);
            LblKode.Content = Controller.Antri2Controller.GetKode();
            Date();
            LblNoAntri.Content = "Q" + LblKode.Content;
            Tampil();
        }
        
        public void Date()
        {
            DispatcherTimer timer = new DispatcherTimer(new TimeSpan(0, 0, 1), DispatcherPriority.Normal, delegate
            {
                this.dateText.Text = DateTime.Now.ToString("dd-MMMM-yyyy HH:mmmm:ss");
            }, this.Dispatcher);
        }


        public void Tampil()
        {
            Antri2Controller.Select();
        }

        private void BtnKembali_Click(object sender, RoutedEventArgs e)
        {
            MesinAntri1Window Antri1 = new MesinAntri1Window();
            Antri1.Show();
            this.Close();
        }

        private void BtnCetak_Click(object sender, RoutedEventArgs e)
        {
            CetakController.Cetak();
            CetakForm cetak = new CetakForm();
            cetak.Show();
        }
    }
}

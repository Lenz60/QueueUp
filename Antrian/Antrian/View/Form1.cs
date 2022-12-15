using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Antrian.View
{
    public partial class Form1 : Form
    {
        Controller.CetakController CetakController;
        public Form1()
        {
            InitializeComponent();
            CetakController = new Controller.CetakController(this);
           axAcroPDF1.src = @"D:\Antrian.pdf"; //Open file secara Statis dan otomatis
        }

      

        private void axAcroPDF1_OnError(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {

            /*      //OpenFile(); //Open file File Secara Dinamis   */
            this.axAcroPDF1.Print(); //Print 
            timerReset();
            ResetBar();
            timerStart();    
      
        }

        public void OpenFile()
        {
            // ================= Penyimpanan File Secara Dinamis (kurang efektif) ================== 
            OpenFileDialog open = new OpenFileDialog();
            open.InitialDirectory = "D:\\";
            open.Filter = "pdf files (*.pdf)|*.pdf|All files (*.*)|*.*";
            if (open.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                axAcroPDF1.src = open.FileName;
                MessageBox.Show("Tekan Ctrl+P Untuk Print");
            }
        }

        private void LoadingBar_Click(object sender, EventArgs e)
        {

        }
        //Start Timer untuk Loading Bar
        public void timerStart()
        {
            this.loadingTimer.Start();
        }
        //Reset Timer untuk Loading Bar
        public void timerReset()
        {
            this.loadingTimer.Stop();
        }
        //Reset Loading Bar
        public void ResetBar()
        {
            if (LoadingBar.Value == 100)
            {
                LoadingBar.Value = 0;
            }
        }
        //Penghubung Timer dg Loading Bar
        private void loadingTimer_Tick(object sender, EventArgs e)
        {
            this.LoadingBar.Increment(1);
        }
    }
}

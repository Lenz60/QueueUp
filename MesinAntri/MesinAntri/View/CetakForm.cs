using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MesinAntri.View
{
    public partial class CetakForm : Form
    {
        public CetakForm()
        {
            InitializeComponent();
            axAcroPDF1.src = @"D:\NoAntrian.pdf";// Open File secara Statis
        }

        private void axAcroPDF1_OnError(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            /*      //OpenFile(); //Open file File Secara Dinamis    */
            axAcroPDF1.Print();
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

        private void progressBar1_Click(object sender, EventArgs e)
        {
            
        }

        public void timerStart()
        {
            this.loadingTimer.Start();
        }
        public void timerReset()
        {
            this.loadingTimer.Stop();
        }

        public void ResetBar()
        {
            if (LoadingBar.Value == 100)
            {
                LoadingBar.Value = 0;
            }
        }

        private void loadingTimer_Tick(object sender, EventArgs e)
        {
            
            this.LoadingBar.Increment(1);
            
        }
    }
}

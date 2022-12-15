using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using iTextSharp.text;
using iTextSharp.text.pdf;
using System.Windows.Forms;

namespace Antrian.Model
{
    class CetakModel
    {
        //1.Information Hiding
        private string KodeID;
        //2.Encapsulation
        public string GetKodeID()
        {
            return KodeID;
        }
        public void SetKodeID(string KodeID)
        {
            this.KodeID = KodeID;
        }
        //3.Function
        public void Cetak(string KodeID)
        {
            Document doc = new Document(iTextSharp.text.PageSize.A9, 10, 10, 42, 35);
            PdfWriter wri = PdfWriter.GetInstance(doc, new FileStream("Antrian.pdf", FileMode.Create));
            //Lokasi penyimpanan Kode Antrian sebagai format pdf secara statis tersimpan pada  D:\\
            doc.Open();
            iTextSharp.text.Paragraph paragraph = new iTextSharp.text.Paragraph();
            paragraph.Font = new Font(FontFactory.GetFont("Arial", 10, Font.BOLD));
            paragraph.Alignment = Element.ALIGN_CENTER;
            paragraph.Add("Kode Antrian Anda adalah : \n" + KodeID.ToString());
            doc.Add(paragraph);
            doc.Close();
        }


    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using iTextSharp.text;
using iTextSharp.text.pdf;

namespace MesinAntri.Model
{
    class CetakModel
    {
        private string NoAntri;
        public string GetNoAntri()
        {
            return NoAntri;
        }
        public void SetNoAntri(string NoAntri)
        {
            this.NoAntri = NoAntri;
        }


        public void Cetak(string NoAntri)
        {
            Document doc = new Document(iTextSharp.text.PageSize.A9, 10, 10, 42, 35);
            PdfWriter wri = PdfWriter.GetInstance(doc, new FileStream("D:\\NoAntrian.pdf", FileMode.Create));
            doc.Open();
            iTextSharp.text.Paragraph paragraph = new iTextSharp.text.Paragraph();
            paragraph.Font = new Font(FontFactory.GetFont("Arial", 10, Font.BOLD));
            paragraph.Alignment = Element.ALIGN_CENTER;
            paragraph.Add("Nomor Antrian Anda adalah : \n" + NoAntri.ToString());
            doc.Add(paragraph);
            doc.Close();
        }


    }
}

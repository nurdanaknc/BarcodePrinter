using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Printing;
using System.Drawing.Imaging;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.IO;
using Zen.Barcode;
using Image = System.Drawing.Image;
using static System.Net.Mime.MediaTypeNames;
using System.Reflection;

namespace WebApplication1
{
    public partial class WebForm1 : System.Web.UI.Page
    {
       

        protected void Page_Load(object sender, EventArgs e)
        {

            

        }

      

        protected void Print_Page(object sender, PrintPageEventArgs e)
        {
            Font printfont4 = new Font("Times New Roman", 8, FontStyle.Bold);
            Font printfont3 = new Font("Times New Roman", 7, FontStyle.Bold);
            Font printfont2 = new Font("Times New Roman", 10, FontStyle.Bold);
            SolidBrush br = new SolidBrush(Color.Black);


            e.Graphics.DrawString("HAMMADDE BARKODU", printfont4, br, 9, 10);
            var img3 = Image.FromFile(@"C:\Users\Jarvi\OneDrive\Masaüstü\barkod\WebApplication1\img\image.png"); 
            e.Graphics.DrawImage(img3, new System.Drawing.Rectangle(150, 10, 70, 50));


            e.Graphics.DrawString("Stok kodu:", printfont3, br, 10, 60);
            e.Graphics.DrawString(stokkodu.Text.Trim(), printfont3, br, 55, 60);


            e.Graphics.DrawString("Stok Adı:", printfont3, br, 10, 85);
            Rectangle rect = new Rectangle(52, 80, 150, 100);
            e.Graphics.FillRectangle(Brushes.White, rect);
            rect.Inflate(-5, -5);
            string text = stokadı.Text.Trim();
            e.Graphics.DrawString(text, printfont3, Brushes.Black, rect);


            e.Graphics.DrawString("Miktar:", printfont3, br, 10, 125);


            e.Graphics.DrawString(miktar.Text.ToString().Replace(',', '.'), printfont3, br, 55, 125);
            e.Graphics.DrawString(birim.Text.Trim(), printfont3, br, 95, 125);

            e.Graphics.DrawString("Lot No:", printfont3, br, 10, 145);
            e.Graphics.DrawString(lotno.Text.ToString().Trim(), printfont3, br, 55, 145);


            //barkod oluştur
            string yeni_barkod_text = kod.Text;
            Zen.Barcode.Code128BarcodeDraw barcode_text = Zen.Barcode.BarcodeDrawFactory.Code128WithChecksum;
            var myimg = barcode_text.Draw(yeni_barkod_text.Trim(), 3);
            e.Graphics.DrawImage(myimg, new System.Drawing.Rectangle(60, 180, 100, 40));
            e.Graphics.DrawString(yeni_barkod_text, printfont2, br, 75, 225);

           

        }


        public System.Drawing.Printing.PrinterSettings.PaperSizeCollection PaperSizes { get; }
        public System.Drawing.Printing.PaperSize PaperSize { get; set; }
      
        protected void Button1_Click(object sender, EventArgs e)
        {
            /*
            
            Font printfont2 = new Font("Times New Roman", 10, FontStyle.Bold);
            SolidBrush br = new SolidBrush(Color.Black);

            string barcode = kod.Text;
            // A new bitmap with the same size as the barcode text
            var bitmap = new Bitmap(barcode.Length * 40, 80);
            //Get the graphics objectm which we can use to draw
            var graphics = Graphics.FromImage(bitmap);

            //Draw stuff
            graphics.DrawString(barcode, printfont2, br, new Point(16, 18));

            //Show the bitmap with graphics image in the PictureBox */


            //PrinterSettings ps = new PrinterSettings();

            //pd.PrinterSettings = ps;

            //  pd.DefaultPageSettings.PaperSize = new PaperSize("Custom", 315, 300);

            
            PrintDocument pd = new PrintDocument();
            pd.PrintPage += new PrintPageEventHandler (this.Print_Page);
            // pd.DefaultPageSettings.PaperSize = new PaperSize("custom", 500, 500);
            pd.PrinterSettings.PrinterName = "Microsoft Print To PDF";
            // pd.PrinterSettings.PrinterName = "Microsoft XPS Document Writer";
            PaperSize pkCustomSize1 = new PaperSize("papersize", 70, 100);
            pd.DefaultPageSettings.PaperSize = pkCustomSize1;
            pd.Print();
            





        }

    }
}
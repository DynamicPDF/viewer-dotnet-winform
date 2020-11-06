using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace viewer_dotnet_winforms_cs
{
    public partial class ParallelView : Form
    {
        ceTe.DynamicPDF.Viewer.PdfDocument pdfDocument2 = null;

        public ParallelView()
        {
            InitializeComponent();
            // In the form constructor do not use any Viewer methods (Open, Print etc.) that perform UI activities.
        }

        private void pdfViewerLeft_ViewChanged(object sender, ceTe.DynamicPDF.Viewer.ViewChangedEventArgs e)
        {
            if (pdfDocument2 != null && e.CurrentView.StartPageNumber <= pdfDocument2.PageCount)
            {
                pdfViewerRight.Navigate(e.CurrentView);

                pdfViewerLeft.Focus();
                System.Threading.Thread.Sleep(100);
            }
        }

        private void pdfViewerRight_FileOpened(object sender, ceTe.DynamicPDF.Viewer.FileOpenedEventArgs e)
        {
            pdfDocument2 = e.PdfDocument;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            pdfViewerLeft.Focus();
        }
    }
}

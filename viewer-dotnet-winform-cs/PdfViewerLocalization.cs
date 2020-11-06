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
    public partial class PdfViewerLocalization : Form
    {
        string[] cultureNames = { "en-US", "ar-SA" };
        public PdfViewerLocalization()
        {
            // It is nessasory to initialize it right here, even if you are going to change it later.
            System.Threading.Thread.CurrentThread.CurrentUICulture = new System.Globalization.CultureInfo("en-US");
            InitializeComponent();
            // In the form constructor do not use any Viewer methods (Open, Print etc.) that perform UI activities.
            comboBox1.SelectedIndex = 0;
        }

        private void comboBox1_SelectedValueChanged(object sender, EventArgs e)
        {
            // Preserve current state and remove PdfViewer control
            string origPath = pdfViewer1.FilePath;
            System.Drawing.Rectangle origRect = pdfViewer1.Bounds;
            ceTe.DynamicPDF.Viewer.View origView = pdfViewer1.GetCurrentView();

            this.Controls.Remove(pdfViewer1);

            // Change the culture
            System.Threading.Thread.CurrentThread.CurrentUICulture = new System.Globalization.CultureInfo(cultureNames[comboBox1.SelectedIndex]);

            // Create new instance of PdfViewer and restore old state
            pdfViewer1 = new ceTe.DynamicPDF.Viewer.PdfViewer();
            pdfViewer1.Location = origRect.Location;
            pdfViewer1.Size = origRect.Size;
            pdfViewer1.Anchor = AnchorStyles.Bottom | AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            if (string.IsNullOrEmpty(origPath) == false)
            {
                pdfViewer1.Open(origPath);
                pdfViewer1.Navigate(origView);
            }
            this.Controls.Add(pdfViewer1);
        }
    }
}

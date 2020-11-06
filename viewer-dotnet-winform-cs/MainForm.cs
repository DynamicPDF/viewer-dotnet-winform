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
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void btn_CustomSearchDialog_Click(object sender, EventArgs e)
        {
            CustomSearchInterface customSearchDialog = new CustomSearchInterface();
            customSearchDialog.ShowDialog();
        }

        private void btn_CustomToolStrip_Click(object sender, EventArgs e)
        {
            CustomToolStrip customToolStrip = new CustomToolStrip();
            customToolStrip.ShowDialog();
        }

        private void btn_HiddenToolbars_Click(object sender, EventArgs e)
        {
            HiddenToolbars hiddenToolbars = new HiddenToolbars();
            hiddenToolbars.ShowDialog();
        }

        private void btn_ParallelView_Click(object sender, EventArgs e)
        {
            ParallelView parallelView = new ParallelView();
            parallelView.ShowDialog();
        }

        private void btn_PDFViewerCustomizations_Click(object sender, EventArgs e)
        {
            PdfViewerCustomizations pDFViewerCustomizations = new PdfViewerCustomizations();
            pDFViewerCustomizations.ShowDialog();
        }

        private void btn_PDFViewerLocalization_Click(object sender, EventArgs e)
        {
            PdfViewerLocalization pDFViewerLocalization = new PdfViewerLocalization();
            pDFViewerLocalization.ShowDialog();
        }

        private void btn_SimplePDFViewer_Click(object sender, EventArgs e)
        {
            SimplePdfViewer simplePDFViewer = new SimplePdfViewer();
            simplePDFViewer.ShowDialog();
        }

        private void btn_SplitControls_Click(object sender, EventArgs e)
        {
            SplitControls splitControls = new SplitControls();
            splitControls.ShowDialog();
        }
    }
}

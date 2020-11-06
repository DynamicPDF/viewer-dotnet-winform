using ceTe.DynamicPDF.Viewer;
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
    public partial class PdfViewerCustomizations : Form
    {
        bool newToolStripAdded = false;
        private PdfToolStrip toolbar;
        private TableLayoutPanel tableLayoutPanel1;
        private Label label1;
        private Button button2;
        private Button button3;
        private Button button4;
        private Button button5;
        private Button button6;
        private SplitContainer splitContainer2;
        private PdfNavigationPanel pdfNavigationPanel1;
        private PdfViewer pdfViewer1;
        private PdfToolStrip pdfToolStrip1;
        private Button button1;
        public PdfViewerCustomizations()
        {

            InitializeComponent();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PdfViewerCustomizations));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            // In the form constructor do not use any Viewer methods (Open, Print etc.) that perform UI activities.
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            pdfToolStrip1.AssociateToPdfViewer(pdfViewer1);
            pdfNavigationPanel1.AssociateToPdfViewer(pdfViewer1);
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            this.splitContainer2.Panel1.Controls.Add(this.pdfViewer1);
            this.splitContainer2.Panel2.Controls.Add(this.pdfNavigationPanel1);
            this.splitContainer2.SplitterDistance = this.ClientSize.Width - 250;
            this.pdfViewer1.Dock = DockStyle.Fill;
            this.pdfToolStrip1.Dock = DockStyle.Fill;
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            this.splitContainer2.Panel1.Controls.Add(this.pdfNavigationPanel1);
            this.splitContainer2.Panel2.Controls.Add(this.pdfViewer1);
            this.splitContainer2.SplitterDistance = 300;
            this.pdfViewer1.Dock = DockStyle.Fill;
            this.pdfToolStrip1.Dock = DockStyle.Fill;
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            this.tableLayoutPanel1.Controls.Add(this.pdfToolStrip1, 0, 2);
            this.pdfToolStrip1.Dock = DockStyle.Fill;
        }

        private void button4_Click_1(object sender, EventArgs e)
        {
            this.tableLayoutPanel1.Controls.Add(this.pdfToolStrip1, 0, 4);
            this.pdfToolStrip1.Dock = DockStyle.Fill;
        }

        private void button5_Click_1(object sender, EventArgs e)
        {
            if (newToolStripAdded == false)
            {
                toolbar = new ceTe.DynamicPDF.Viewer.PdfToolStrip();

                ToolStripItem firstButton = toolbar.ToolStrip.Items[ceTe.DynamicPDF.Viewer.PdfToolStripItems.FirstPage];
                ToolStripItem previousButton = toolbar.ToolStrip.Items[ceTe.DynamicPDF.Viewer.PdfToolStripItems.PreviousPage];
                ToolStripItem nextButton = toolbar.ToolStrip.Items[ceTe.DynamicPDF.Viewer.PdfToolStripItems.NextPage];
                ToolStripItem lastButton = toolbar.ToolStrip.Items[ceTe.DynamicPDF.Viewer.PdfToolStripItems.LastPage];

                toolbar.ToolStrip.Items.Clear();
                toolbar.ToolStrip.Items.Add(firstButton);
                toolbar.ToolStrip.Items.Add(previousButton);
                toolbar.ToolStrip.Items.Add(nextButton);
                toolbar.ToolStrip.Items.Add(lastButton);

                toolbar.AssociateToPdfViewer(pdfViewer1);

                this.Controls.Add(toolbar);
                toolbar.Dock = DockStyle.Bottom;
                toolbar.Size = new Size(this.ClientRectangle.Width, 50);
                newToolStripAdded = true;
            }

        }

        private void button6_Click_1(object sender, EventArgs e)
        {
            if (toolbar != null)
            {
                toolbar.AssociateToPdfViewer(null);
                toolbar.Controls.Clear();
                this.Controls.Remove(toolbar);
                newToolStripAdded = false;
                toolbar = null;
            }
        }
    }
}

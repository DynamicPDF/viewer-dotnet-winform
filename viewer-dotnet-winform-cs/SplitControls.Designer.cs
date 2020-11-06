namespace viewer_dotnet_winforms_cs
{
    partial class SplitControls
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SplitControls));
            this.title = new System.Windows.Forms.Label();
            this.toolbar1 = new ceTe.DynamicPDF.Viewer.PdfToolStrip();
            this.navigationPanel1 = new ceTe.DynamicPDF.Viewer.PdfNavigationPanel();
            this.navigationPanel2 = new ceTe.DynamicPDF.Viewer.PdfNavigationPanel();
            this.splitter1 = new System.Windows.Forms.Splitter();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.pdfViewer1 = new ceTe.DynamicPDF.Viewer.PdfViewer();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.pdfViewer2 = new ceTe.DynamicPDF.Viewer.PdfViewer();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // title
            // 
            this.title.AutoEllipsis = true;
            this.title.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.title.Dock = System.Windows.Forms.DockStyle.Top;
            this.title.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.title.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.title.ForeColor = System.Drawing.SystemColors.Control;
            this.title.Location = new System.Drawing.Point(0, 0);
            this.title.Name = "title";
            this.title.Size = new System.Drawing.Size(962, 56);
            this.title.TabIndex = 1;
            this.title.Text = "This example demonstrates implementing a tab interface using a tab control along " +
    "with controls included with viewer.";
            // 
            // toolbar1
            // 
            this.toolbar1.BackColor = System.Drawing.SystemColors.Control;
            this.toolbar1.Dock = System.Windows.Forms.DockStyle.Top;
            this.toolbar1.Location = new System.Drawing.Point(0, 56);
            this.toolbar1.MinimumSize = new System.Drawing.Size(40, 35);
            this.toolbar1.Name = "toolbar1";
            this.toolbar1.Size = new System.Drawing.Size(962, 35);
            this.toolbar1.TabIndex = 2;
            this.toolbar1.TabStop = false;
            this.toolbar1.Text = "toolbar1";
            // 
            // navigationPanel1
            // 
            this.navigationPanel1.BackColor = System.Drawing.Color.Gray;
            this.navigationPanel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.navigationPanel1.Location = new System.Drawing.Point(55, 91);
            this.navigationPanel1.MinimumSize = new System.Drawing.Size(55, 200);
            this.navigationPanel1.Name = "navigationPanel1";
            this.navigationPanel1.ShowShrinkIcon = false;
            this.navigationPanel1.Size = new System.Drawing.Size(55, 522);
            this.navigationPanel1.TabIndex = 3;
            this.navigationPanel1.TabStop = false;
            this.navigationPanel1.VisibleNavigationPane = ceTe.DynamicPDF.Viewer.NavigationPane.None;
            // 
            // navigationPanel2
            // 
            this.navigationPanel2.BackColor = System.Drawing.Color.Gray;
            this.navigationPanel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.navigationPanel2.Location = new System.Drawing.Point(0, 91);
            this.navigationPanel2.MinimumSize = new System.Drawing.Size(55, 200);
            this.navigationPanel2.Name = "navigationPanel2";
            this.navigationPanel2.ShowShrinkIcon = false;
            this.navigationPanel2.Size = new System.Drawing.Size(55, 522);
            this.navigationPanel2.TabIndex = 3;
            this.navigationPanel2.TabStop = false;
            this.navigationPanel2.VisibleNavigationPane = ceTe.DynamicPDF.Viewer.NavigationPane.None;
            // 
            // splitter1
            // 
            this.splitter1.Location = new System.Drawing.Point(110, 91);
            this.splitter1.Name = "splitter1";
            this.splitter1.Size = new System.Drawing.Size(3, 522);
            this.splitter1.TabIndex = 4;
            this.splitter1.TabStop = false;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(113, 91);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(849, 522);
            this.tabControl1.TabIndex = 5;
            this.tabControl1.Selected += new System.Windows.Forms.TabControlEventHandler(this.tabControl1_Selected);
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.pdfViewer1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(841, 496);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "tabPage1";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // pdfViewer1
            // 
            this.pdfViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pdfViewer1.FocusBorderColor = System.Drawing.SystemColors.Highlight;
            this.pdfViewer1.FocusBorderWidth = 3;
            this.pdfViewer1.InitialOrientation = null;
            this.pdfViewer1.InitialPage = null;
            this.pdfViewer1.InitialPageMode = null;
            this.pdfViewer1.InitialVisibleNavigationPane = null;
            this.pdfViewer1.InitialZoomMode = null;
            this.pdfViewer1.InitialZoomPercent = null;
            this.pdfViewer1.Location = new System.Drawing.Point(3, 3);
            this.pdfViewer1.MinimumSize = new System.Drawing.Size(200, 150);
            this.pdfViewer1.Name = "pdfViewer1";
            this.pdfViewer1.NavigationPanelWidth = 345;
            this.pdfViewer1.PageColor = System.Drawing.Color.White;
            this.pdfViewer1.RightToLeftText = null;
            this.pdfViewer1.ShowBookmarkIcon = false;
            this.pdfViewer1.ShowHorizontalScrollbar = true;
            this.pdfViewer1.ShowNavigationPanel = false;
            this.pdfViewer1.ShowThumbnailIcon = false;
            this.pdfViewer1.ShowToolbar = false;
            this.pdfViewer1.ShowToolStrip = false;
            this.pdfViewer1.ShowVerticalScrollbar = true;
            this.pdfViewer1.Size = new System.Drawing.Size(835, 490);
            this.pdfViewer1.TabIndex = 0;
            this.pdfViewer1.TabStop = false;
            this.pdfViewer1.TextSelectionColor = System.Drawing.Color.Empty;
            this.pdfViewer1.VisibleNavigationPane = ceTe.DynamicPDF.Viewer.NavigationPane.None;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.pdfViewer2);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(896, 496);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "tabPage2";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // pdfViewer2
            // 
            this.pdfViewer2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pdfViewer2.FocusBorderColor = System.Drawing.SystemColors.Highlight;
            this.pdfViewer2.FocusBorderWidth = 3;
            this.pdfViewer2.InitialOrientation = null;
            this.pdfViewer2.InitialPage = null;
            this.pdfViewer2.InitialPageMode = null;
            this.pdfViewer2.InitialVisibleNavigationPane = null;
            this.pdfViewer2.InitialZoomMode = null;
            this.pdfViewer2.InitialZoomPercent = null;
            this.pdfViewer2.Location = new System.Drawing.Point(3, 3);
            this.pdfViewer2.MinimumSize = new System.Drawing.Size(200, 150);
            this.pdfViewer2.Name = "pdfViewer2";
            this.pdfViewer2.NavigationPanelWidth = 345;
            this.pdfViewer2.PageColor = System.Drawing.Color.White;
            this.pdfViewer2.RightToLeftText = null;
            this.pdfViewer2.ShowBookmarkIcon = false;
            this.pdfViewer2.ShowHorizontalScrollbar = true;
            this.pdfViewer2.ShowNavigationPanel = false;
            this.pdfViewer2.ShowThumbnailIcon = false;
            this.pdfViewer2.ShowToolbar = false;
            this.pdfViewer2.ShowToolStrip = false;
            this.pdfViewer2.ShowVerticalScrollbar = true;
            this.pdfViewer2.Size = new System.Drawing.Size(890, 490);
            this.pdfViewer2.TabIndex = 0;
            this.pdfViewer2.TabStop = false;
            this.pdfViewer2.TextSelectionColor = System.Drawing.Color.Empty;
            this.pdfViewer2.VisibleNavigationPane = ceTe.DynamicPDF.Viewer.NavigationPane.None;
            // 
            // SplitControls
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(962, 613);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.splitter1);
            this.Controls.Add(this.navigationPanel1);
            this.Controls.Add(this.navigationPanel2);
            this.Controls.Add(this.toolbar1);
            this.Controls.Add(this.title);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "SplitControls";
            this.Text = "SplitControls";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label title;
        private ceTe.DynamicPDF.Viewer.PdfToolStrip toolbar1;
        private ceTe.DynamicPDF.Viewer.PdfNavigationPanel navigationPanel1;
        private ceTe.DynamicPDF.Viewer.PdfNavigationPanel navigationPanel2;
        private System.Windows.Forms.Splitter splitter1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private ceTe.DynamicPDF.Viewer.PdfViewer pdfViewer1;
        private System.Windows.Forms.TabPage tabPage2;
        private ceTe.DynamicPDF.Viewer.PdfViewer pdfViewer2;
    }
}
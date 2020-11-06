namespace viewer_dotnet_winforms_cs
{
    partial class ParallelView
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ParallelView));
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.title = new System.Windows.Forms.Label();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.pdfViewerLeft = new ceTe.DynamicPDF.Viewer.PdfViewer();
            this.pdfViewerRight = new ceTe.DynamicPDF.Viewer.PdfViewer();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.splitContainer1.IsSplitterFixed = true;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.title);
            this.splitContainer1.Panel1MinSize = 20;
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.splitContainer2);
            this.splitContainer1.Size = new System.Drawing.Size(834, 587);
            this.splitContainer1.SplitterDistance = 40;
            this.splitContainer1.TabIndex = 0;
            // 
            // title
            // 
            this.title.AutoEllipsis = true;
            this.title.Dock = System.Windows.Forms.DockStyle.Fill;
            this.title.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.title.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.title.ForeColor = System.Drawing.SystemColors.Control;
            this.title.Location = new System.Drawing.Point(0, 0);
            this.title.Name = "title";
            this.title.Size = new System.Drawing.Size(834, 40);
            this.title.TabIndex = 0;
            this.title.Text = "This example shows two PDFs side by side.\r\nChanges made to the page view in the c" +
    "ontrol on the left, will be reflected on the right.";
            // 
            // splitContainer2
            // 
            this.splitContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer2.Location = new System.Drawing.Point(0, 0);
            this.splitContainer2.Name = "splitContainer2";
            // 
            // splitContainer2.Panel1
            // 
            this.splitContainer2.Panel1.Controls.Add(this.pdfViewerLeft);
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.Controls.Add(this.pdfViewerRight);
            this.splitContainer2.Size = new System.Drawing.Size(834, 543);
            this.splitContainer2.SplitterDistance = 414;
            this.splitContainer2.TabIndex = 4;
            // 
            // pdfViewerLeft
            // 
            this.pdfViewerLeft.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pdfViewerLeft.FocusBorderColor = System.Drawing.SystemColors.Highlight;
            this.pdfViewerLeft.FocusBorderWidth = 3;
            this.pdfViewerLeft.InitialOrientation = null;
            this.pdfViewerLeft.InitialPage = 1;
            this.pdfViewerLeft.InitialPageMode = null;
            this.pdfViewerLeft.InitialVisibleNavigationPane = null;
            this.pdfViewerLeft.InitialZoomMode = null;
            this.pdfViewerLeft.InitialZoomPercent = null;
            this.pdfViewerLeft.Location = new System.Drawing.Point(0, 0);
            this.pdfViewerLeft.Margin = new System.Windows.Forms.Padding(0);
            this.pdfViewerLeft.MinimumSize = new System.Drawing.Size(200, 150);
            this.pdfViewerLeft.Name = "pdfViewerLeft";
            this.pdfViewerLeft.NavigationPanelWidth = 345;
            this.pdfViewerLeft.PageColor = System.Drawing.Color.White;
            this.pdfViewerLeft.RightToLeftText = null;
            this.pdfViewerLeft.ShowBookmarkIcon = true;
            this.pdfViewerLeft.ShowHorizontalScrollbar = true;
            this.pdfViewerLeft.ShowNavigationPanel = true;
            this.pdfViewerLeft.ShowThumbnailIcon = true;
            this.pdfViewerLeft.ShowToolbar = true;
            this.pdfViewerLeft.ShowToolStrip = true;
            this.pdfViewerLeft.ShowVerticalScrollbar = true;
            this.pdfViewerLeft.Size = new System.Drawing.Size(414, 543);
            this.pdfViewerLeft.TabIndex = 1;
            this.pdfViewerLeft.TabStop = false;
            this.pdfViewerLeft.TextSelectionColor = System.Drawing.Color.Empty;
            this.pdfViewerLeft.VisibleNavigationPane = ceTe.DynamicPDF.Viewer.NavigationPane.None;
            this.pdfViewerLeft.ViewChanged += new ceTe.DynamicPDF.Viewer.ViewChangedEventHandler(this.pdfViewerLeft_ViewChanged);
            // 
            // pdfViewerRight
            // 
            this.pdfViewerRight.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pdfViewerRight.FocusBorderColor = System.Drawing.SystemColors.Highlight;
            this.pdfViewerRight.FocusBorderWidth = 3;
            this.pdfViewerRight.InitialOrientation = null;
            this.pdfViewerRight.InitialPage = 1;
            this.pdfViewerRight.InitialPageMode = null;
            this.pdfViewerRight.InitialVisibleNavigationPane = null;
            this.pdfViewerRight.InitialZoomMode = null;
            this.pdfViewerRight.InitialZoomPercent = null;
            this.pdfViewerRight.Location = new System.Drawing.Point(0, 0);
            this.pdfViewerRight.Margin = new System.Windows.Forms.Padding(0);
            this.pdfViewerRight.MinimumSize = new System.Drawing.Size(200, 150);
            this.pdfViewerRight.Name = "pdfViewerRight";
            this.pdfViewerRight.NavigationPanelWidth = 345;
            this.pdfViewerRight.PageColor = System.Drawing.Color.White;
            this.pdfViewerRight.RightToLeftText = null;
            this.pdfViewerRight.ShowBookmarkIcon = true;
            this.pdfViewerRight.ShowHorizontalScrollbar = true;
            this.pdfViewerRight.ShowNavigationPanel = true;
            this.pdfViewerRight.ShowThumbnailIcon = true;
            this.pdfViewerRight.ShowToolbar = true;
            this.pdfViewerRight.ShowToolStrip = true;
            this.pdfViewerRight.ShowVerticalScrollbar = true;
            this.pdfViewerRight.Size = new System.Drawing.Size(416, 543);
            this.pdfViewerRight.TabIndex = 2;
            this.pdfViewerRight.TabStop = false;
            this.pdfViewerRight.TextSelectionColor = System.Drawing.Color.Empty;
            this.pdfViewerRight.VisibleNavigationPane = ceTe.DynamicPDF.Viewer.NavigationPane.None;
            this.pdfViewerRight.FileOpened += new ceTe.DynamicPDF.Viewer.FileOpenedEventHandler(this.pdfViewerRight_FileOpened);
            // 
            // ParallelView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(834, 587);
            this.Controls.Add(this.splitContainer1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ParallelView";
            this.Text = "ParallelView";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.splitContainer2.Panel1.ResumeLayout(false);
            this.splitContainer2.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
            this.splitContainer2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.SplitContainer splitContainer2;
        private ceTe.DynamicPDF.Viewer.PdfViewer pdfViewerLeft;
        private ceTe.DynamicPDF.Viewer.PdfViewer pdfViewerRight;
        private System.Windows.Forms.Label title;
    }
}
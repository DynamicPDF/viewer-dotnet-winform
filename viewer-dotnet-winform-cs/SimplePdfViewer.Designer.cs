namespace viewer_dotnet_winforms_cs
{
    partial class SimplePdfViewer
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SimplePdfViewer));
            this.pdfViewer1 = new ceTe.DynamicPDF.Viewer.PdfViewer();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // pdfViewer1
            // 
            this.pdfViewer1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pdfViewer1.FocusBorderColor = System.Drawing.SystemColors.Highlight;
            this.pdfViewer1.FocusBorderWidth = 3;
            this.pdfViewer1.InitialOrientation = null;
            this.pdfViewer1.InitialPage = null;
            this.pdfViewer1.InitialPageMode = null;
            this.pdfViewer1.InitialVisibleNavigationPane = null;
            this.pdfViewer1.InitialZoomMode = null;
            this.pdfViewer1.InitialZoomPercent = null;
            this.pdfViewer1.Location = new System.Drawing.Point(2, 26);
            this.pdfViewer1.MinimumSize = new System.Drawing.Size(200, 150);
            this.pdfViewer1.Name = "pdfViewer1";
            this.pdfViewer1.NavigationPanelWidth = 345;
            this.pdfViewer1.PageColor = System.Drawing.Color.White;
            this.pdfViewer1.RightToLeftText = null;
            this.pdfViewer1.ShowBookmarkIcon = true;
            this.pdfViewer1.ShowHorizontalScrollbar = true;
            this.pdfViewer1.ShowNavigationPanel = true;
            this.pdfViewer1.ShowThumbnailIcon = true;
            this.pdfViewer1.ShowToolbar = true;
            this.pdfViewer1.ShowToolStrip = true;
            this.pdfViewer1.ShowVerticalScrollbar = true;
            this.pdfViewer1.Size = new System.Drawing.Size(764, 488);
            this.pdfViewer1.TabIndex = 0;
            this.pdfViewer1.TabStop = false;
            this.pdfViewer1.TextSelectionColor = System.Drawing.Color.Empty;
            this.pdfViewer1.VisibleNavigationPane = ceTe.DynamicPDF.Viewer.NavigationPane.None;
            // 
            // label1
            // 
            this.label1.AutoEllipsis = true;
            this.label1.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(764, 23);
            this.label1.TabIndex = 5;
            this.label1.Text = "This example demonstrates the default behavior of a viewer control.";
            // 
            // SimplePdfViewer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(764, 514);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pdfViewer1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "SimplePdfViewer";
            this.Text = "SimplePDFViewer";
            this.ResumeLayout(false);

        }

        #endregion

        private ceTe.DynamicPDF.Viewer.PdfViewer pdfViewer1;
        private System.Windows.Forms.Label label1;
    }
}
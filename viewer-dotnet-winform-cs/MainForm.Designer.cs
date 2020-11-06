namespace viewer_dotnet_winforms_cs
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.btn_CustomSearchDialog = new System.Windows.Forms.Button();
            this.btn_CustomToolStrip = new System.Windows.Forms.Button();
            this.btn_HiddenToolbars = new System.Windows.Forms.Button();
            this.btn_ParallelView = new System.Windows.Forms.Button();
            this.btn_PDFViewerCustomizations = new System.Windows.Forms.Button();
            this.btn_PDFViewerLocalization = new System.Windows.Forms.Button();
            this.btn_SimplePDFViewer = new System.Windows.Forms.Button();
            this.btn_SplitControls = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_CustomSearchDialog
            // 
            this.btn_CustomSearchDialog.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_CustomSearchDialog.Location = new System.Drawing.Point(424, 12);
            this.btn_CustomSearchDialog.Name = "btn_CustomSearchDialog";
            this.btn_CustomSearchDialog.Size = new System.Drawing.Size(200, 125);
            this.btn_CustomSearchDialog.TabIndex = 0;
            this.btn_CustomSearchDialog.Text = "Custom Search Interface";
            this.btn_CustomSearchDialog.UseVisualStyleBackColor = true;
            this.btn_CustomSearchDialog.Click += new System.EventHandler(this.btn_CustomSearchDialog_Click);
            // 
            // btn_CustomToolStrip
            // 
            this.btn_CustomToolStrip.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_CustomToolStrip.Location = new System.Drawing.Point(630, 12);
            this.btn_CustomToolStrip.Name = "btn_CustomToolStrip";
            this.btn_CustomToolStrip.Size = new System.Drawing.Size(200, 125);
            this.btn_CustomToolStrip.TabIndex = 1;
            this.btn_CustomToolStrip.Text = "Custom ToolStrip";
            this.btn_CustomToolStrip.UseVisualStyleBackColor = true;
            this.btn_CustomToolStrip.Click += new System.EventHandler(this.btn_CustomToolStrip_Click);
            // 
            // btn_HiddenToolbars
            // 
            this.btn_HiddenToolbars.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_HiddenToolbars.Location = new System.Drawing.Point(12, 143);
            this.btn_HiddenToolbars.Name = "btn_HiddenToolbars";
            this.btn_HiddenToolbars.Size = new System.Drawing.Size(200, 125);
            this.btn_HiddenToolbars.TabIndex = 2;
            this.btn_HiddenToolbars.Text = "Hidden Toolbars";
            this.btn_HiddenToolbars.UseVisualStyleBackColor = true;
            this.btn_HiddenToolbars.Click += new System.EventHandler(this.btn_HiddenToolbars_Click);
            // 
            // btn_ParallelView
            // 
            this.btn_ParallelView.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_ParallelView.Location = new System.Drawing.Point(630, 143);
            this.btn_ParallelView.Name = "btn_ParallelView";
            this.btn_ParallelView.Size = new System.Drawing.Size(200, 125);
            this.btn_ParallelView.TabIndex = 3;
            this.btn_ParallelView.Text = "Parallel View";
            this.btn_ParallelView.UseVisualStyleBackColor = true;
            this.btn_ParallelView.Click += new System.EventHandler(this.btn_ParallelView_Click);
            // 
            // btn_PDFViewerCustomizations
            // 
            this.btn_PDFViewerCustomizations.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_PDFViewerCustomizations.Location = new System.Drawing.Point(218, 12);
            this.btn_PDFViewerCustomizations.Name = "btn_PDFViewerCustomizations";
            this.btn_PDFViewerCustomizations.Size = new System.Drawing.Size(200, 125);
            this.btn_PDFViewerCustomizations.TabIndex = 4;
            this.btn_PDFViewerCustomizations.Text = "PDF Viewer Customizations";
            this.btn_PDFViewerCustomizations.UseVisualStyleBackColor = true;
            this.btn_PDFViewerCustomizations.Click += new System.EventHandler(this.btn_PDFViewerCustomizations_Click);
            // 
            // btn_PDFViewerLocalization
            // 
            this.btn_PDFViewerLocalization.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_PDFViewerLocalization.Location = new System.Drawing.Point(218, 143);
            this.btn_PDFViewerLocalization.Name = "btn_PDFViewerLocalization";
            this.btn_PDFViewerLocalization.Size = new System.Drawing.Size(200, 125);
            this.btn_PDFViewerLocalization.TabIndex = 5;
            this.btn_PDFViewerLocalization.Text = "PDF Viewer Localization";
            this.btn_PDFViewerLocalization.UseVisualStyleBackColor = true;
            this.btn_PDFViewerLocalization.Click += new System.EventHandler(this.btn_PDFViewerLocalization_Click);
            // 
            // btn_SimplePDFViewer
            // 
            this.btn_SimplePDFViewer.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_SimplePDFViewer.Location = new System.Drawing.Point(12, 12);
            this.btn_SimplePDFViewer.Name = "btn_SimplePDFViewer";
            this.btn_SimplePDFViewer.Size = new System.Drawing.Size(200, 125);
            this.btn_SimplePDFViewer.TabIndex = 6;
            this.btn_SimplePDFViewer.Text = "Simple PDF Viewer";
            this.btn_SimplePDFViewer.UseVisualStyleBackColor = true;
            this.btn_SimplePDFViewer.Click += new System.EventHandler(this.btn_SimplePDFViewer_Click);
            // 
            // btn_SplitControls
            // 
            this.btn_SplitControls.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_SplitControls.Location = new System.Drawing.Point(424, 143);
            this.btn_SplitControls.Name = "btn_SplitControls";
            this.btn_SplitControls.Size = new System.Drawing.Size(200, 125);
            this.btn_SplitControls.TabIndex = 7;
            this.btn_SplitControls.Text = "Split Controls";
            this.btn_SplitControls.UseVisualStyleBackColor = true;
            this.btn_SplitControls.Click += new System.EventHandler(this.btn_SplitControls_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(846, 282);
            this.Controls.Add(this.btn_SplitControls);
            this.Controls.Add(this.btn_SimplePDFViewer);
            this.Controls.Add(this.btn_PDFViewerLocalization);
            this.Controls.Add(this.btn_PDFViewerCustomizations);
            this.Controls.Add(this.btn_ParallelView);
            this.Controls.Add(this.btn_HiddenToolbars);
            this.Controls.Add(this.btn_CustomToolStrip);
            this.Controls.Add(this.btn_CustomSearchDialog);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainForm";
            this.Text = "DynamicPDF Viewer Examples";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_CustomSearchDialog;
        private System.Windows.Forms.Button btn_CustomToolStrip;
        private System.Windows.Forms.Button btn_HiddenToolbars;
        private System.Windows.Forms.Button btn_ParallelView;
        private System.Windows.Forms.Button btn_PDFViewerCustomizations;
        private System.Windows.Forms.Button btn_PDFViewerLocalization;
        private System.Windows.Forms.Button btn_SimplePDFViewer;
        private System.Windows.Forms.Button btn_SplitControls;
    }
}


<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class PdfViewerLocalization
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(PdfViewerLocalization))
        Me.label2 = New System.Windows.Forms.Label()
        Me.comboBox1 = New System.Windows.Forms.ComboBox()
        Me.label1 = New System.Windows.Forms.Label()
        Me.pdfViewer1 = New ceTe.DynamicPDF.Viewer.PdfViewer()
        Me.SuspendLayout()
        '
        'label2
        '
        Me.label2.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.label2.AutoSize = True
        Me.label2.Location = New System.Drawing.Point(12, 484)
        Me.label2.Name = "label2"
        Me.label2.Size = New System.Drawing.Size(92, 13)
        Me.label2.TabIndex = 11
        Me.label2.Text = "Display Language"
        '
        'comboBox1
        '
        Me.comboBox1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.comboBox1.FormattingEnabled = True
        Me.comboBox1.Items.AddRange(New Object() {"English (US)", "Arabic (Saudi Arabia)"})
        Me.comboBox1.Location = New System.Drawing.Point(110, 481)
        Me.comboBox1.Name = "comboBox1"
        Me.comboBox1.Size = New System.Drawing.Size(642, 21)
        Me.comboBox1.TabIndex = 10
        '
        'label1
        '
        Me.label1.AutoEllipsis = True
        Me.label1.BackColor = System.Drawing.SystemColors.ControlDarkDark
        Me.label1.Dock = System.Windows.Forms.DockStyle.Top
        Me.label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label1.ForeColor = System.Drawing.Color.White
        Me.label1.Location = New System.Drawing.Point(0, 0)
        Me.label1.Name = "label1"
        Me.label1.Size = New System.Drawing.Size(764, 23)
        Me.label1.TabIndex = 9
        Me.label1.Text = "This example demonstrates the default behavior of a viewer control."
        '
        'pdfViewer1
        '
        Me.pdfViewer1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.pdfViewer1.FocusBorderColor = System.Drawing.SystemColors.Highlight
        Me.pdfViewer1.FocusBorderWidth = 3
        Me.pdfViewer1.InitialOrientation = Nothing
        Me.pdfViewer1.InitialPage = Nothing
        Me.pdfViewer1.InitialPageMode = Nothing
        Me.pdfViewer1.InitialVisibleNavigationPane = Nothing
        Me.pdfViewer1.InitialZoomMode = Nothing
        Me.pdfViewer1.InitialZoomPercent = Nothing
        Me.pdfViewer1.Location = New System.Drawing.Point(2, 26)
        Me.pdfViewer1.MinimumSize = New System.Drawing.Size(200, 150)
        Me.pdfViewer1.Name = "pdfViewer1"
        Me.pdfViewer1.NavigationPanelWidth = 345
        Me.pdfViewer1.PageColor = System.Drawing.Color.White
        Me.pdfViewer1.RightToLeftText = Nothing
        Me.pdfViewer1.ShowBookmarkIcon = True
        Me.pdfViewer1.ShowHorizontalScrollbar = True
        Me.pdfViewer1.ShowNavigationPanel = True
        Me.pdfViewer1.ShowThumbnailIcon = True
        Me.pdfViewer1.ShowToolbar = True
        Me.pdfViewer1.ShowToolStrip = True
        Me.pdfViewer1.ShowVerticalScrollbar = True
        Me.pdfViewer1.Size = New System.Drawing.Size(764, 449)
        Me.pdfViewer1.TabIndex = 8
        Me.pdfViewer1.TabStop = False
        Me.pdfViewer1.TextSelectionColor = System.Drawing.Color.Empty
        Me.pdfViewer1.VisibleNavigationPane = ceTe.DynamicPDF.Viewer.NavigationPane.None
        '
        'PDFViewerLocalization
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(764, 514)
        Me.Controls.Add(Me.label2)
        Me.Controls.Add(Me.comboBox1)
        Me.Controls.Add(Me.label1)
        Me.Controls.Add(Me.pdfViewer1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "PDFViewerLocalization"
        Me.Text = "PDFViewerLocalization"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Private WithEvents label2 As System.Windows.Forms.Label
    Private WithEvents comboBox1 As System.Windows.Forms.ComboBox
    Private WithEvents label1 As System.Windows.Forms.Label
    Private WithEvents pdfViewer1 As ceTe.DynamicPDF.Viewer.PdfViewer
End Class

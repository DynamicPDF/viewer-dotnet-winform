<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class ParallelView
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
        Me.pdfViewerLeft = New ceTe.DynamicPDF.Viewer.PdfViewer()
        Me.splitContainer1 = New System.Windows.Forms.SplitContainer()
        Me.title = New System.Windows.Forms.Label()
        Me.splitContainer2 = New System.Windows.Forms.SplitContainer()
        Me.pdfViewerRight = New ceTe.DynamicPDF.Viewer.PdfViewer()
        CType(Me.splitContainer1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.splitContainer1.Panel1.SuspendLayout()
        Me.splitContainer1.Panel2.SuspendLayout()
        Me.splitContainer1.SuspendLayout()
        CType(Me.splitContainer2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.splitContainer2.Panel1.SuspendLayout()
        Me.splitContainer2.Panel2.SuspendLayout()
        Me.splitContainer2.SuspendLayout()
        Me.SuspendLayout()
        '
        'pdfViewerLeft
        '
        Me.pdfViewerLeft.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pdfViewerLeft.FocusBorderColor = System.Drawing.SystemColors.Highlight
        Me.pdfViewerLeft.FocusBorderWidth = 3
        Me.pdfViewerLeft.InitialOrientation = Nothing
        Me.pdfViewerLeft.InitialPage = 1
        Me.pdfViewerLeft.InitialPageMode = Nothing
        Me.pdfViewerLeft.InitialVisibleNavigationPane = Nothing
        Me.pdfViewerLeft.InitialZoomMode = Nothing
        Me.pdfViewerLeft.InitialZoomPercent = Nothing
        Me.pdfViewerLeft.Location = New System.Drawing.Point(0, 0)
        Me.pdfViewerLeft.Margin = New System.Windows.Forms.Padding(0)
        Me.pdfViewerLeft.MinimumSize = New System.Drawing.Size(200, 150)
        Me.pdfViewerLeft.Name = "pdfViewerLeft"
        Me.pdfViewerLeft.NavigationPanelWidth = 345
        Me.pdfViewerLeft.PageColor = System.Drawing.Color.White
        Me.pdfViewerLeft.RightToLeftText = Nothing
        Me.pdfViewerLeft.ShowBookmarkIcon = True
        Me.pdfViewerLeft.ShowHorizontalScrollbar = True
        Me.pdfViewerLeft.ShowNavigationPanel = True
        Me.pdfViewerLeft.ShowThumbnailIcon = True
        Me.pdfViewerLeft.ShowToolbar = True
        Me.pdfViewerLeft.ShowToolStrip = True
        Me.pdfViewerLeft.ShowVerticalScrollbar = True
        Me.pdfViewerLeft.Size = New System.Drawing.Size(447, 629)
        Me.pdfViewerLeft.TabIndex = 1
        Me.pdfViewerLeft.TabStop = False
        Me.pdfViewerLeft.TextSelectionColor = System.Drawing.Color.Empty
        Me.pdfViewerLeft.VisibleNavigationPane = ceTe.DynamicPDF.Viewer.NavigationPane.None
        '
        'splitContainer1
        '
        Me.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.splitContainer1.FixedPanel = System.Windows.Forms.FixedPanel.Panel1
        Me.splitContainer1.IsSplitterFixed = True
        Me.splitContainer1.Location = New System.Drawing.Point(0, 0)
        Me.splitContainer1.Name = "splitContainer1"
        Me.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal
        '
        'splitContainer1.Panel1
        '
        Me.splitContainer1.Panel1.Controls.Add(Me.title)
        Me.splitContainer1.Panel1MinSize = 20
        '
        'splitContainer1.Panel2
        '
        Me.splitContainer1.Panel2.Controls.Add(Me.splitContainer2)
        Me.splitContainer1.Size = New System.Drawing.Size(902, 673)
        Me.splitContainer1.SplitterDistance = 40
        Me.splitContainer1.TabIndex = 1
        '
        'title
        '
        Me.title.AutoEllipsis = True
        Me.title.Dock = System.Windows.Forms.DockStyle.Fill
        Me.title.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.title.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.title.ForeColor = System.Drawing.SystemColors.Control
        Me.title.Location = New System.Drawing.Point(0, 0)
        Me.title.Name = "title"
        Me.title.Size = New System.Drawing.Size(902, 40)
        Me.title.TabIndex = 0
        Me.title.Text = "This example shows two PDFs side by side." & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Changes made to the page view in the c" &
    "ontrol on the left, will be reflected on the right."
        '
        'splitContainer2
        '
        Me.splitContainer2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.splitContainer2.Location = New System.Drawing.Point(0, 0)
        Me.splitContainer2.Name = "splitContainer2"
        '
        'splitContainer2.Panel1
        '
        Me.splitContainer2.Panel1.Controls.Add(Me.pdfViewerLeft)
        '
        'splitContainer2.Panel2
        '
        Me.splitContainer2.Panel2.Controls.Add(Me.pdfViewerRight)
        Me.splitContainer2.Size = New System.Drawing.Size(902, 629)
        Me.splitContainer2.SplitterDistance = 447
        Me.splitContainer2.TabIndex = 4
        '
        'pdfViewerRight
        '
        Me.pdfViewerRight.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pdfViewerRight.FocusBorderColor = System.Drawing.SystemColors.Highlight
        Me.pdfViewerRight.FocusBorderWidth = 3
        Me.pdfViewerRight.InitialOrientation = Nothing
        Me.pdfViewerRight.InitialPage = 1
        Me.pdfViewerRight.InitialPageMode = Nothing
        Me.pdfViewerRight.InitialVisibleNavigationPane = Nothing
        Me.pdfViewerRight.InitialZoomMode = Nothing
        Me.pdfViewerRight.InitialZoomPercent = Nothing
        Me.pdfViewerRight.Location = New System.Drawing.Point(0, 0)
        Me.pdfViewerRight.Margin = New System.Windows.Forms.Padding(0)
        Me.pdfViewerRight.MinimumSize = New System.Drawing.Size(200, 150)
        Me.pdfViewerRight.Name = "pdfViewerRight"
        Me.pdfViewerRight.NavigationPanelWidth = 345
        Me.pdfViewerRight.PageColor = System.Drawing.Color.White
        Me.pdfViewerRight.RightToLeftText = Nothing
        Me.pdfViewerRight.ShowBookmarkIcon = True
        Me.pdfViewerRight.ShowHorizontalScrollbar = True
        Me.pdfViewerRight.ShowNavigationPanel = True
        Me.pdfViewerRight.ShowThumbnailIcon = True
        Me.pdfViewerRight.ShowToolbar = True
        Me.pdfViewerRight.ShowToolStrip = True
        Me.pdfViewerRight.ShowVerticalScrollbar = True
        Me.pdfViewerRight.Size = New System.Drawing.Size(451, 629)
        Me.pdfViewerRight.TabIndex = 2
        Me.pdfViewerRight.TabStop = False
        Me.pdfViewerRight.TextSelectionColor = System.Drawing.Color.Empty
        Me.pdfViewerRight.VisibleNavigationPane = ceTe.DynamicPDF.Viewer.NavigationPane.None
        '
        'ParallelView
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ControlDarkDark
        Me.ClientSize = New System.Drawing.Size(902, 673)
        Me.Controls.Add(Me.splitContainer1)
        Me.Name = "ParallelView"
        Me.Text = "ParallelView"
        Me.splitContainer1.Panel1.ResumeLayout(False)
        Me.splitContainer1.Panel2.ResumeLayout(False)
        CType(Me.splitContainer1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.splitContainer1.ResumeLayout(False)
        Me.splitContainer2.Panel1.ResumeLayout(False)
        Me.splitContainer2.Panel2.ResumeLayout(False)
        CType(Me.splitContainer2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.splitContainer2.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Private WithEvents pdfViewerLeft As ceTe.DynamicPDF.Viewer.PdfViewer
    Private WithEvents splitContainer1 As System.Windows.Forms.SplitContainer
    Private WithEvents title As System.Windows.Forms.Label
    Private WithEvents splitContainer2 As System.Windows.Forms.SplitContainer
    Private WithEvents pdfViewerRight As ceTe.DynamicPDF.Viewer.PdfViewer
End Class

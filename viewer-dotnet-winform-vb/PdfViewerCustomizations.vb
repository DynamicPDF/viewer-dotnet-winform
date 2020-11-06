
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Data
Imports System.Drawing
Imports System.Linq
Imports System.Text
Imports System.Windows.Forms


Partial Public Class PDFViewerCustomizations
    Inherits Form

    Private newToolStripAdded As Boolean = False
    Private WithEvents tableLayoutPanel1 As TableLayoutPanel
    Private WithEvents pdfToolStrip1 As ceTe.DynamicPDF.Viewer.PdfToolStrip
    Private WithEvents label1 As Label
    Private WithEvents button2 As Button
    Private WithEvents button3 As Button
    Private WithEvents button4 As Button
    Private WithEvents button5 As Button
    Private WithEvents button6 As Button
    Private WithEvents button1 As Button
    Private WithEvents splitContainer2 As SplitContainer
    Private WithEvents pdfViewer1 As ceTe.DynamicPDF.Viewer.PdfViewer
    Private WithEvents pdfNavigationPanel1 As ceTe.DynamicPDF.Viewer.PdfNavigationPanel
    Private toolbar As ceTe.DynamicPDF.Viewer.PdfToolStrip
    Public Sub New()
        InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(PDFViewerCustomizations))
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        ' In the form constructor do not use any Viewer methods (Open, Print etc.) that perform UI activities.
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        pdfToolStrip1.AssociateToPdfViewer(pdfViewer1)
        pdfNavigationPanel1.AssociateToPdfViewer(pdfViewer1)
    End Sub



    Private Sub InitializeComponent()
        Me.tableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.pdfToolStrip1 = New ceTe.DynamicPDF.Viewer.PdfToolStrip()
        Me.label1 = New System.Windows.Forms.Label()
        Me.button2 = New System.Windows.Forms.Button()
        Me.button3 = New System.Windows.Forms.Button()
        Me.button4 = New System.Windows.Forms.Button()
        Me.button5 = New System.Windows.Forms.Button()
        Me.button6 = New System.Windows.Forms.Button()
        Me.button1 = New System.Windows.Forms.Button()
        Me.splitContainer2 = New System.Windows.Forms.SplitContainer()
        Me.pdfNavigationPanel1 = New ceTe.DynamicPDF.Viewer.PdfNavigationPanel()
        Me.pdfViewer1 = New ceTe.DynamicPDF.Viewer.PdfViewer()
        Me.tableLayoutPanel1.SuspendLayout()
        CType(Me.splitContainer2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.splitContainer2.Panel1.SuspendLayout()
        Me.splitContainer2.Panel2.SuspendLayout()
        Me.splitContainer2.SuspendLayout()
        Me.SuspendLayout()
        '
        'tableLayoutPanel1
        '
        Me.tableLayoutPanel1.ColumnCount = 7
        Me.tableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 186.0!))
        Me.tableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 212.0!))
        Me.tableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 136.0!))
        Me.tableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 156.0!))
        Me.tableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 150.0!))
        Me.tableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 150.0!))
        Me.tableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.tableLayoutPanel1.Controls.Add(Me.pdfToolStrip1, 0, 2)
        Me.tableLayoutPanel1.Controls.Add(Me.label1, 0, 0)
        Me.tableLayoutPanel1.Controls.Add(Me.button2, 1, 1)
        Me.tableLayoutPanel1.Controls.Add(Me.button3, 2, 1)
        Me.tableLayoutPanel1.Controls.Add(Me.button4, 3, 1)
        Me.tableLayoutPanel1.Controls.Add(Me.button5, 4, 1)
        Me.tableLayoutPanel1.Controls.Add(Me.button6, 5, 1)
        Me.tableLayoutPanel1.Controls.Add(Me.button1, 0, 1)
        Me.tableLayoutPanel1.Controls.Add(Me.splitContainer2, 0, 3)
        Me.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tableLayoutPanel1.Location = New System.Drawing.Point(0, 0)
        Me.tableLayoutPanel1.Name = "tableLayoutPanel1"
        Me.tableLayoutPanel1.RowCount = 5
        Me.tableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.tableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 34.0!))
        Me.tableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 41.0!))
        Me.tableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 640.0!))
        Me.tableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 9.0!))
        Me.tableLayoutPanel1.Size = New System.Drawing.Size(971, 849)
        Me.tableLayoutPanel1.TabIndex = 11
        '
        'pdfToolStrip1
        '
        Me.pdfToolStrip1.BackColor = System.Drawing.SystemColors.Control
        Me.tableLayoutPanel1.SetColumnSpan(Me.pdfToolStrip1, 7)
        Me.pdfToolStrip1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.pdfToolStrip1.Location = New System.Drawing.Point(3, 57)
        Me.pdfToolStrip1.MinimumSize = New System.Drawing.Size(40, 35)
        Me.pdfToolStrip1.Name = "pdfToolStrip1"
        Me.pdfToolStrip1.Size = New System.Drawing.Size(965, 35)
        Me.pdfToolStrip1.TabIndex = 15
        Me.pdfToolStrip1.TabStop = False
        '
        'label1
        '
        Me.label1.AutoEllipsis = True
        Me.label1.AutoSize = True
        Me.label1.BackColor = System.Drawing.SystemColors.ControlDarkDark
        Me.tableLayoutPanel1.SetColumnSpan(Me.label1, 7)
        Me.label1.Dock = System.Windows.Forms.DockStyle.Top
        Me.label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label1.ForeColor = System.Drawing.Color.White
        Me.label1.Location = New System.Drawing.Point(3, 0)
        Me.label1.Name = "label1"
        Me.label1.Size = New System.Drawing.Size(965, 16)
        Me.label1.TabIndex = 9
        Me.label1.Text = "This example demonstrates using a Navigation Panel and Toolbar control."
        '
        'button2
        '
        Me.button2.Location = New System.Drawing.Point(189, 23)
        Me.button2.Name = "button2"
        Me.button2.Size = New System.Drawing.Size(201, 28)
        Me.button2.TabIndex = 2
        Me.button2.Text = "Move Navigation Panel Left"
        Me.button2.UseVisualStyleBackColor = True
        '
        'button3
        '
        Me.button3.Location = New System.Drawing.Point(401, 23)
        Me.button3.Name = "button3"
        Me.button3.Size = New System.Drawing.Size(130, 28)
        Me.button3.TabIndex = 3
        Me.button3.Text = "MoveTool Bar Top"
        Me.button3.UseVisualStyleBackColor = True
        '
        'button4
        '
        Me.button4.Location = New System.Drawing.Point(537, 23)
        Me.button4.Name = "button4"
        Me.button4.Size = New System.Drawing.Size(150, 28)
        Me.button4.TabIndex = 4
        Me.button4.Text = "Move Tool Bar Down"
        Me.button4.UseVisualStyleBackColor = True
        '
        'button5
        '
        Me.button5.Location = New System.Drawing.Point(693, 23)
        Me.button5.Name = "button5"
        Me.button5.Size = New System.Drawing.Size(144, 28)
        Me.button5.TabIndex = 5
        Me.button5.Text = "Add New Tool Bar"
        Me.button5.UseVisualStyleBackColor = True
        '
        'button6
        '
        Me.button6.Location = New System.Drawing.Point(843, 23)
        Me.button6.Name = "button6"
        Me.button6.Size = New System.Drawing.Size(144, 28)
        Me.button6.TabIndex = 6
        Me.button6.Text = "Remove Tool Bar"
        Me.button6.UseVisualStyleBackColor = True
        '
        'button1
        '
        Me.button1.Location = New System.Drawing.Point(3, 23)
        Me.button1.Name = "button1"
        Me.button1.Size = New System.Drawing.Size(180, 28)
        Me.button1.TabIndex = 1
        Me.button1.Text = "Move Navigation Panel Right"
        Me.button1.UseVisualStyleBackColor = True
        '
        'splitContainer2
        '
        Me.tableLayoutPanel1.SetColumnSpan(Me.splitContainer2, 7)
        Me.splitContainer2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.splitContainer2.Location = New System.Drawing.Point(3, 98)
        Me.splitContainer2.Name = "splitContainer2"
        '
        'splitContainer2.Panel1
        '
        Me.splitContainer2.Panel1.Controls.Add(Me.pdfNavigationPanel1)
        '
        'splitContainer2.Panel2
        '
        Me.splitContainer2.Panel2.Controls.Add(Me.pdfViewer1)
        Me.splitContainer2.Size = New System.Drawing.Size(965, 634)
        Me.splitContainer2.SplitterDistance = 179
        Me.splitContainer2.TabIndex = 10
        '
        'pdfNavigationPanel1
        '
        Me.pdfNavigationPanel1.BackColor = System.Drawing.Color.Gray
        Me.pdfNavigationPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pdfNavigationPanel1.Location = New System.Drawing.Point(0, 0)
        Me.pdfNavigationPanel1.MinimumSize = New System.Drawing.Size(155, 200)
        Me.pdfNavigationPanel1.Name = "pdfNavigationPanel1"
        Me.pdfNavigationPanel1.ShowShrinkIcon = False
        Me.pdfNavigationPanel1.Size = New System.Drawing.Size(179, 634)
        Me.pdfNavigationPanel1.TabIndex = 1
        Me.pdfNavigationPanel1.TabStop = False
        Me.pdfNavigationPanel1.VisibleNavigationPane = ceTe.DynamicPDF.Viewer.NavigationPane.Bookmark
        '
        'pdfViewer1
        '
        Me.pdfViewer1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.pdfViewer1.FocusBorderColor = System.Drawing.SystemColors.Highlight
        Me.pdfViewer1.FocusBorderWidth = 3
        Me.pdfViewer1.InitialOrientation = Nothing
        Me.pdfViewer1.InitialPage = Nothing
        Me.pdfViewer1.InitialPageMode = Nothing
        Me.pdfViewer1.InitialVisibleNavigationPane = Nothing
        Me.pdfViewer1.InitialZoomMode = Nothing
        Me.pdfViewer1.InitialZoomPercent = Nothing
        Me.pdfViewer1.Location = New System.Drawing.Point(3, 0)
        Me.pdfViewer1.MinimumSize = New System.Drawing.Size(200, 150)
        Me.pdfViewer1.Name = "pdfViewer1"
        Me.pdfViewer1.NavigationPanelWidth = 300
        Me.pdfViewer1.PageColor = System.Drawing.Color.White
        Me.pdfViewer1.RightToLeftText = Nothing
        Me.pdfViewer1.ShowBookmarkIcon = False
        Me.pdfViewer1.ShowHorizontalScrollbar = True
        Me.pdfViewer1.ShowNavigationPanel = False
        Me.pdfViewer1.ShowThumbnailIcon = False
        Me.pdfViewer1.ShowToolbar = False
        Me.pdfViewer1.ShowToolStrip = False
        Me.pdfViewer1.ShowVerticalScrollbar = True
        Me.pdfViewer1.Size = New System.Drawing.Size(776, 631)
        Me.pdfViewer1.TabIndex = 0
        Me.pdfViewer1.TabStop = False
        Me.pdfViewer1.TextSelectionColor = System.Drawing.Color.Empty
        Me.pdfViewer1.VisibleNavigationPane = ceTe.DynamicPDF.Viewer.NavigationPane.None
        '
        'PDFViewerCustomizations
        '
        Me.ClientSize = New System.Drawing.Size(971, 849)
        Me.Controls.Add(Me.tableLayoutPanel1)
        Me.Name = "PDFViewerCustomizations"
        Me.Text = "PDFViewerCustomizations"
        Me.tableLayoutPanel1.ResumeLayout(False)
        Me.tableLayoutPanel1.PerformLayout()
        Me.splitContainer2.Panel1.ResumeLayout(False)
        Me.splitContainer2.Panel2.ResumeLayout(False)
        CType(Me.splitContainer2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.splitContainer2.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Private Sub button1_Click(sender As Object, e As EventArgs) Handles button1.Click
        Me.splitContainer2.Panel1.Controls.Add(Me.pdfViewer1)
        Me.splitContainer2.Panel2.Controls.Add(Me.pdfNavigationPanel1)
        Me.splitContainer2.SplitterDistance = Me.ClientSize.Width - 250
        Me.pdfViewer1.Dock = DockStyle.Fill
        Me.pdfToolStrip1.Dock = DockStyle.Fill


    End Sub

    Private Sub button2_Click(sender As Object, e As EventArgs) Handles button2.Click

        Me.splitContainer2.Panel1.Controls.Add(Me.pdfNavigationPanel1)
        Me.splitContainer2.Panel2.Controls.Add(Me.pdfViewer1)
        Me.pdfViewer1.Dock = DockStyle.Fill
        Me.pdfToolStrip1.Dock = DockStyle.Fill
        Me.splitContainer2.SplitterDistance = 250
    End Sub

    Private Sub button3_Click(sender As Object, e As EventArgs) Handles button3.Click
        Me.tableLayoutPanel1.Controls.Add(Me.pdfToolStrip1, 0, 2)
        Me.pdfToolStrip1.Dock = DockStyle.Fill
    End Sub

    Private Sub button4_Click(sender As Object, e As EventArgs) Handles button4.Click
        Me.tableLayoutPanel1.Controls.Add(Me.pdfToolStrip1, 0, 4)
        Me.pdfToolStrip1.Dock = DockStyle.Fill
    End Sub

    Private Sub button5_Click(sender As Object, e As EventArgs) Handles button5.Click
        If newToolStripAdded = False Then
            toolbar = New ceTe.DynamicPDF.Viewer.PdfToolStrip()

            Dim firstButton As ToolStripItem = toolbar.ToolStrip.Items(ceTe.DynamicPDF.Viewer.PdfToolStripItems.FirstPage)
            Dim previousButton As ToolStripItem = toolbar.ToolStrip.Items(ceTe.DynamicPDF.Viewer.PdfToolStripItems.PreviousPage)
            Dim nextButton As ToolStripItem = toolbar.ToolStrip.Items(ceTe.DynamicPDF.Viewer.PdfToolStripItems.NextPage)
            Dim lastButton As ToolStripItem = toolbar.ToolStrip.Items(ceTe.DynamicPDF.Viewer.PdfToolStripItems.LastPage)

            toolbar.ToolStrip.Items.Clear()
            toolbar.ToolStrip.Items.Add(firstButton)
            toolbar.ToolStrip.Items.Add(previousButton)
            toolbar.ToolStrip.Items.Add(nextButton)
            toolbar.ToolStrip.Items.Add(lastButton)

            toolbar.AssociateToPdfViewer(pdfViewer1)

            Me.Controls.Add(toolbar)
            toolbar.Dock = DockStyle.Bottom
            toolbar.Size = New Size(Me.ClientRectangle.Width, 50)
            newToolStripAdded = True
        End If
    End Sub

    Private Sub button6_Click(sender As Object, e As EventArgs) Handles button6.Click
        If Not toolbar Is Nothing Then
            toolbar.AssociateToPdfViewer(Nothing)
            toolbar.Controls.Clear()
            Me.Controls.Remove(toolbar)
            newToolStripAdded = False
            toolbar = Nothing
        End If
    End Sub
End Class

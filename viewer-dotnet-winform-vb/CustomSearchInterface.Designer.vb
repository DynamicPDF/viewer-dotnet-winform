<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class CustomSearchInterface
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(CustomSearchInterface))
        Me.pdfViewer1 = New ceTe.DynamicPDF.Viewer.PdfViewer()
        Me.splitContainer1 = New System.Windows.Forms.SplitContainer()
        Me.title = New System.Windows.Forms.Label()
        Me.groupBox1 = New System.Windows.Forms.GroupBox()
        Me.find = New System.Windows.Forms.Button()
        Me.searchText = New System.Windows.Forms.TextBox()
        Me.matchCase = New System.Windows.Forms.CheckBox()
        Me.matchWholeWord = New System.Windows.Forms.CheckBox()
        CType(Me.splitContainer1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.splitContainer1.Panel1.SuspendLayout()
        Me.splitContainer1.Panel2.SuspendLayout()
        Me.splitContainer1.SuspendLayout()
        Me.groupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'pdfViewer1
        '
        Me.pdfViewer1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pdfViewer1.FocusBorderColor = System.Drawing.SystemColors.Highlight
        Me.pdfViewer1.FocusBorderWidth = 3
        Me.pdfViewer1.InitialOrientation = Nothing
        Me.pdfViewer1.InitialPage = 1
        Me.pdfViewer1.InitialPageMode = Nothing
        Me.pdfViewer1.InitialVisibleNavigationPane = Nothing
        Me.pdfViewer1.InitialZoomMode = Nothing
        Me.pdfViewer1.InitialZoomPercent = Nothing
        Me.pdfViewer1.Location = New System.Drawing.Point(0, 0)
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
        Me.pdfViewer1.Size = New System.Drawing.Size(911, 619)
        Me.pdfViewer1.TabIndex = 3
        Me.pdfViewer1.TabStop = False
        Me.pdfViewer1.TextSelectionColor = System.Drawing.Color.Empty
        Me.pdfViewer1.VisibleNavigationPane = ceTe.DynamicPDF.Viewer.NavigationPane.None
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
        Me.splitContainer1.Panel1.BackColor = System.Drawing.SystemColors.InactiveCaption
        Me.splitContainer1.Panel1.Controls.Add(Me.title)
        Me.splitContainer1.Panel1.Controls.Add(Me.groupBox1)
        Me.splitContainer1.Panel1MinSize = 75
        '
        'splitContainer1.Panel2
        '
        Me.splitContainer1.Panel2.Controls.Add(Me.pdfViewer1)
        Me.splitContainer1.Size = New System.Drawing.Size(911, 713)
        Me.splitContainer1.SplitterDistance = 90
        Me.splitContainer1.TabIndex = 11
        '
        'title
        '
        Me.title.BackColor = System.Drawing.Color.Transparent
        Me.title.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.title.ForeColor = System.Drawing.Color.Black
        Me.title.Location = New System.Drawing.Point(3, 5)
        Me.title.Name = "title"
        Me.title.Size = New System.Drawing.Size(701, 26)
        Me.title.TabIndex = 11
        Me.title.Text = "This example demonstrates implementing a custom search interface which overrides " &
    "the default search dialog."
        '
        'groupBox1
        '
        Me.groupBox1.BackColor = System.Drawing.Color.Transparent
        Me.groupBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.groupBox1.Controls.Add(Me.find)
        Me.groupBox1.Controls.Add(Me.searchText)
        Me.groupBox1.Controls.Add(Me.matchCase)
        Me.groupBox1.Controls.Add(Me.matchWholeWord)
        Me.groupBox1.Enabled = False
        Me.groupBox1.ForeColor = System.Drawing.Color.Black
        Me.groupBox1.Location = New System.Drawing.Point(4, 31)
        Me.groupBox1.Margin = New System.Windows.Forms.Padding(0)
        Me.groupBox1.Name = "groupBox1"
        Me.groupBox1.Padding = New System.Windows.Forms.Padding(0)
        Me.groupBox1.Size = New System.Drawing.Size(582, 50)
        Me.groupBox1.TabIndex = 10
        Me.groupBox1.TabStop = False
        Me.groupBox1.Tag = "200"
        Me.groupBox1.Text = "  Find "
        '
        'find
        '
        Me.find.ForeColor = System.Drawing.Color.Black
        Me.find.Location = New System.Drawing.Point(295, 16)
        Me.find.Name = "find"
        Me.find.Size = New System.Drawing.Size(76, 23)
        Me.find.TabIndex = 15
        Me.find.Text = "Find Next"
        Me.find.UseVisualStyleBackColor = True
        '
        'searchText
        '
        Me.searchText.Location = New System.Drawing.Point(22, 19)
        Me.searchText.Name = "searchText"
        Me.searchText.Size = New System.Drawing.Size(267, 20)
        Me.searchText.TabIndex = 13
        '
        'matchCase
        '
        Me.matchCase.AutoSize = True
        Me.matchCase.ForeColor = System.Drawing.Color.Black
        Me.matchCase.Location = New System.Drawing.Point(376, 22)
        Me.matchCase.Name = "matchCase"
        Me.matchCase.Size = New System.Drawing.Size(82, 17)
        Me.matchCase.TabIndex = 1
        Me.matchCase.Text = "Match case"
        Me.matchCase.UseVisualStyleBackColor = True
        '
        'matchWholeWord
        '
        Me.matchWholeWord.AutoSize = True
        Me.matchWholeWord.ForeColor = System.Drawing.Color.Black
        Me.matchWholeWord.Location = New System.Drawing.Point(464, 22)
        Me.matchWholeWord.Name = "matchWholeWord"
        Me.matchWholeWord.Size = New System.Drawing.Size(113, 17)
        Me.matchWholeWord.TabIndex = 0
        Me.matchWholeWord.Text = "Match whole word"
        Me.matchWholeWord.UseVisualStyleBackColor = True
        '
        'CustomSearchInterface
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(911, 713)
        Me.Controls.Add(Me.splitContainer1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "CustomSearchInterface"
        Me.Text = "CustomSearchInterface"
        Me.splitContainer1.Panel1.ResumeLayout(False)
        Me.splitContainer1.Panel2.ResumeLayout(False)
        CType(Me.splitContainer1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.splitContainer1.ResumeLayout(False)
        Me.groupBox1.ResumeLayout(False)
        Me.groupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Private WithEvents pdfViewer1 As ceTe.DynamicPDF.Viewer.PdfViewer
    Private WithEvents splitContainer1 As System.Windows.Forms.SplitContainer
    Private WithEvents title As System.Windows.Forms.Label
    Private WithEvents groupBox1 As System.Windows.Forms.GroupBox
    Private WithEvents find As System.Windows.Forms.Button
    Private WithEvents searchText As System.Windows.Forms.TextBox
    Private WithEvents matchCase As System.Windows.Forms.CheckBox
    Private WithEvents matchWholeWord As System.Windows.Forms.CheckBox
End Class

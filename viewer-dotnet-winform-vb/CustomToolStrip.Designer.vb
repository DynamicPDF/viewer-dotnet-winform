<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class CustomToolStrip
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
        Me.ChangeToolbarToCustom = New System.Windows.Forms.Button()
        Me.openFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.label1 = New System.Windows.Forms.Label()
        Me.RestoreViewerToolbar = New System.Windows.Forms.Button()
        Me.pdfViewer1 = New ceTe.DynamicPDF.Viewer.PdfViewer()
        Me.SuspendLayout()
        '
        'ChangeToolbarToCustom
        '
        Me.ChangeToolbarToCustom.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ChangeToolbarToCustom.Location = New System.Drawing.Point(888, 47)
        Me.ChangeToolbarToCustom.Name = "ChangeToolbarToCustom"
        Me.ChangeToolbarToCustom.Size = New System.Drawing.Size(105, 45)
        Me.ChangeToolbarToCustom.TabIndex = 5
        Me.ChangeToolbarToCustom.Text = "Custom toolbar"
        Me.ChangeToolbarToCustom.UseVisualStyleBackColor = True
        '
        'openFileDialog1
        '
        Me.openFileDialog1.Filter = "PDF|*.pdf"
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
        Me.label1.Size = New System.Drawing.Size(995, 23)
        Me.label1.TabIndex = 8
        Me.label1.Text = "This example demonstrates replacing the default toolbar items of a viewer control" &
    " with custom toolbar items."
        '
        'RestoreViewerToolbar
        '
        Me.RestoreViewerToolbar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.RestoreViewerToolbar.Enabled = False
        Me.RestoreViewerToolbar.Location = New System.Drawing.Point(888, 98)
        Me.RestoreViewerToolbar.Name = "RestoreViewerToolbar"
        Me.RestoreViewerToolbar.Size = New System.Drawing.Size(105, 45)
        Me.RestoreViewerToolbar.TabIndex = 7
        Me.RestoreViewerToolbar.Text = "Restore Viewer Toolbar"
        Me.RestoreViewerToolbar.UseVisualStyleBackColor = True
        '
        'pdfViewer1
        '
        Me.pdfViewer1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.pdfViewer1.FocusBorderColor = System.Drawing.SystemColors.Highlight
        Me.pdfViewer1.FocusBorderWidth = 3
        Me.pdfViewer1.InitialOrientation = Nothing
        Me.pdfViewer1.InitialPage = 1
        Me.pdfViewer1.InitialPageMode = Nothing
        Me.pdfViewer1.InitialVisibleNavigationPane = Nothing
        Me.pdfViewer1.InitialZoomMode = Nothing
        Me.pdfViewer1.InitialZoomPercent = Nothing
        Me.pdfViewer1.Location = New System.Drawing.Point(0, 26)
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
        Me.pdfViewer1.Size = New System.Drawing.Size(882, 530)
        Me.pdfViewer1.TabIndex = 6
        Me.pdfViewer1.TabStop = False
        Me.pdfViewer1.TextSelectionColor = System.Drawing.Color.Empty
        Me.pdfViewer1.VisibleNavigationPane = ceTe.DynamicPDF.Viewer.NavigationPane.None
        '
        'CustomToolStrip
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(995, 578)
        Me.Controls.Add(Me.ChangeToolbarToCustom)
        Me.Controls.Add(Me.label1)
        Me.Controls.Add(Me.RestoreViewerToolbar)
        Me.Controls.Add(Me.pdfViewer1)
        Me.Name = "CustomToolStrip"
        Me.Text = "CustomToolStrip"
        Me.ResumeLayout(False)

    End Sub
    Private WithEvents ChangeToolbarToCustom As System.Windows.Forms.Button
    Private WithEvents openFileDialog1 As System.Windows.Forms.OpenFileDialog
    Private WithEvents label1 As System.Windows.Forms.Label
    Private WithEvents RestoreViewerToolbar As System.Windows.Forms.Button
    Private WithEvents pdfViewer1 As ceTe.DynamicPDF.Viewer.PdfViewer
End Class

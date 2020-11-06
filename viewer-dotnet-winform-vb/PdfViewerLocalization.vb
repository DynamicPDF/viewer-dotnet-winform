Public Class PdfViewerLocalization
    Inherits System.Windows.Forms.Form

    Dim cultureNames() As String = New String() {"en-US", "ar-SA"}

    Public Sub New()
        ' It is nessasory to initialize it right here, even if you are going to change it later.
        System.Threading.Thread.CurrentThread.CurrentUICulture = New System.Globalization.CultureInfo("en-US")
        InitializeComponent()
        ' In the form constructor do not use any Viewer methods (Open, Print etc.) that perform UI activities.
        comboBox1.SelectedIndex = 0
    End Sub

    Private Sub comboBox1_SelectedValueChanged(sender As System.Object, e As System.EventArgs) Handles comboBox1.SelectedValueChanged
        ' Preserve current state and remove PdfViewer control
        Dim origPath As String = pdfViewer1.FilePath
        Dim origRect As System.Drawing.Rectangle = pdfViewer1.Bounds
        Dim origView As ceTe.DynamicPDF.Viewer.View = pdfViewer1.GetCurrentView()

        Me.Controls.Remove(pdfViewer1)

        ' Change the culture
        System.Threading.Thread.CurrentThread.CurrentUICulture = New System.Globalization.CultureInfo(cultureNames(comboBox1.SelectedIndex))

        ' Create new instance of PdfViewer and restore old state
        pdfViewer1 = New ceTe.DynamicPDF.Viewer.PdfViewer()
        pdfViewer1.Location = origRect.Location
        pdfViewer1.Size = origRect.Size
        pdfViewer1.Anchor = AnchorStyles.Bottom Or AnchorStyles.Top Or AnchorStyles.Left Or AnchorStyles.Right
        If String.IsNullOrEmpty(origPath) = False Then
            pdfViewer1.Open(origPath)
            pdfViewer1.Navigate(origView)
        End If

        Me.Controls.Add(pdfViewer1)
    End Sub
End Class
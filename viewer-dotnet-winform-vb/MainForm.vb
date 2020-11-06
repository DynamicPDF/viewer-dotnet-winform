Public Class MainForm
    Private Sub btn_CustomSearchDialog_Click(sender As Object, e As EventArgs) Handles btn_CustomSearchDialog.Click
        Dim customSearchDialog As CustomSearchInterface = New CustomSearchInterface()
        customSearchDialog.ShowDialog()
    End Sub

    Private Sub btn_CustomToolStrip_Click(sender As Object, e As EventArgs) Handles btn_CustomToolStrip.Click
        Dim customToolStrip As CustomToolStrip = New CustomToolStrip()
        customToolStrip.ShowDialog()
    End Sub

    Private Sub btn_HiddenToolbars_Click(sender As Object, e As EventArgs) Handles btn_HiddenToolbars.Click
        Dim hiddenToolbars As HiddenToolbars = New HiddenToolbars()
        hiddenToolbars.ShowDialog()
    End Sub

    Private Sub btn_ParallelView_Click(sender As Object, e As EventArgs) Handles btn_ParallelView.Click
        Dim parallelView As ParallelView = New ParallelView()
        parallelView.ShowDialog()
    End Sub

    Private Sub btn_PDFViewerCustomizations_Click(sender As Object, e As EventArgs) Handles btn_PDFViewerCustomizations.Click
        Dim pDFViewerCustomizations As PDFViewerCustomizations = New PDFViewerCustomizations()
        pDFViewerCustomizations.ShowDialog()
    End Sub

    Private Sub btn_PDFViewerLocalization_Click(sender As Object, e As EventArgs) Handles btn_PDFViewerLocalization.Click
        Dim pDFViewerLocalization As PdfViewerLocalization = New PdfViewerLocalization()
        pDFViewerLocalization.ShowDialog()
    End Sub

    Private Sub btn_SimplePDFViewer_Click(sender As Object, e As EventArgs) Handles btn_SimplePDFViewer.Click
        Dim simplePDFViewer As SimplePdfViewer = New SimplePdfViewer()
        simplePDFViewer.ShowDialog()
    End Sub

    Private Sub btn_SplitControls_Click(sender As Object, e As EventArgs) Handles btn_SplitControls.Click
        Dim splitControls As SplitControls = New SplitControls()
        splitControls.ShowDialog()
    End Sub
End Class

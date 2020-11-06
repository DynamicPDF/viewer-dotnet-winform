Public Class CustomSearchInterface

    Public Sub New()
        MyBase.New()
        InitializeComponent()
        ' In the form constructor do not use any Viewer methods (Open, Print etc.) that perform UI activities.
    End Sub
    Private Sub pdfViewer1_SearchDialogShowing(sender As Object, e As ceTe.DynamicPDF.Viewer.SearchDialogShowingEventArgs) Handles pdfViewer1.SearchDialogShowing
        e.Cancel = True
        searchText.Focus()
    End Sub
    Private Sub find_Click(sender As Object, e As EventArgs) Handles find.Click
        Dim matchOptions As ceTe.DynamicPDF.Viewer.MatchOptions
        If (Not String.IsNullOrEmpty(searchText.Text)) Then
            matchOptions = ceTe.DynamicPDF.Viewer.MatchOptions.All
            If ((matchWholeWord.Checked = True) And (matchCase.Checked = True)) Then
                matchOptions = ceTe.DynamicPDF.Viewer.MatchOptions.All
            ElseIf ((matchWholeWord.Checked = True) And (matchCase.Checked = False)) Then
                matchOptions = ceTe.DynamicPDF.Viewer.MatchOptions.WholeWordOnly
            ElseIf ((matchWholeWord.Checked = False) And (matchCase.Checked = True)) Then
                matchOptions = ceTe.DynamicPDF.Viewer.MatchOptions.CaseSensitive
            Else
                matchOptions = ceTe.DynamicPDF.Viewer.MatchOptions.None
            End If
            pdfViewer1.SearchForward(searchText.Text, matchOptions)
        End If
    End Sub

    Private Sub pdfViewer1_DocumentDisplayed(sender As Object, e As ceTe.DynamicPDF.Viewer.DocumentDisplayedEventArgs) Handles pdfViewer1.DocumentDisplayed
        groupBox1.Enabled = True
        title.Text = "Type a search term in the 'Find' text box and click on 'Find Next'."
    End Sub
End Class

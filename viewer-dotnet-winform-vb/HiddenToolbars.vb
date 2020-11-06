Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Data
Imports System.Drawing
Imports System.Text
Imports System.Windows.Forms

Public Class HiddenToolbars
    Public Sub HiddenToolbars()
        InitializeComponent()
        ' In the form constructor do not use any Viewer methods (Open, Print etc.) that perform UI activities.
    End Sub
    Private Sub Open_Click(sender As Object, e As EventArgs) Handles Open.Click
        If (Me.openFileDialog1.ShowDialog(Me.pdfViewer1) = DialogResult.OK) Then
            'Calling  method to open the selected document from file dialog.
            Me.pdfViewer1.Open(Me.openFileDialog1.FileName)
        End If
    End Sub

    Private Sub Print_Click(sender As Object, e As EventArgs) Handles Print.Click
        'Calling method for print.
        Me.pdfViewer1.Print()
    End Sub

    Private Sub CloseDoc_Click(sender As Object, e As EventArgs) Handles CloseDoc.Click
        ' Calling mehtod to close the current document.
        Me.pdfViewer1.Close()
    End Sub
End Class

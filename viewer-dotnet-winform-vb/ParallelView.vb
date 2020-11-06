﻿Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Drawing
Imports System.Text
Imports System.Windows.Forms

Public Class ParallelView
    Inherits System.Windows.Forms.Form

    Private pdfDocument2 As ceTe.DynamicPDF.Viewer.PdfDocument

    Public Sub ParallelView()
        InitializeComponent()
        ' In the form constructor do not use any Viewer methods (Open, Print etc.) that perform UI activities.
    End Sub

    Private Sub pdfViewerLeft_ViewChanged(ByVal sender As System.Object, ByVal e As ceTe.DynamicPDF.Viewer.ViewChangedEventArgs) Handles pdfViewerLeft.ViewChanged
        If (pdfDocument2 IsNot Nothing) And (e.CurrentView.StartPageNumber <= pdfDocument2.PageCount) Then
            pdfViewerRight.Navigate(e.CurrentView)
            pdfViewerLeft.Focus()
            System.Threading.Thread.Sleep(100)
        End If
    End Sub
    Private Sub pdfViewerRight_FileOpened(ByVal sender As System.Object, ByVal e As ceTe.DynamicPDF.Viewer.FileOpenedEventArgs) Handles pdfViewerRight.FileOpened
        pdfDocument2 = e.PdfDocument
    End Sub

    Private Sub Form1_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        pdfViewerLeft.Focus()
    End Sub
End Class

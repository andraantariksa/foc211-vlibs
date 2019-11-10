Imports System.IO
Imports System.Net

Public Class ImageHelper
    Public Shared Function GetImageBitmapFromURL(url As String) As Bitmap
        Dim webClientObj As WebClient = New WebClient
        Return Bitmap.FromStream(New MemoryStream(webClientObj.DownloadData(url)))
    End Function
End Class

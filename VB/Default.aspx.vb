Partial Public Class _Default
    Inherits System.Web.UI.Page

    Protected Sub UploadControl_FileUploadComplete(ByVal sender As Object, ByVal e As DevExpress.Web.FileUploadCompleteEventArgs)
        If e.UploadedFile.IsValid Then
            Dim fileName As String = e.UploadedFile.FileName
            e.UploadedFile.SaveAs(MapPath(RichEdit.WorkDirectory) & "\" & fileName, True)
            e.CallbackData = fileName
        End If
    End Sub
End Class
public partial class _Default : System.Web.UI.Page {
    protected void UploadControl_FileUploadComplete(object sender, DevExpress.Web.FileUploadCompleteEventArgs e) {
        if (e.UploadedFile.IsValid) {
            string fileName = e.UploadedFile.FileName;
            e.UploadedFile.SaveAs(MapPath(RichEdit.WorkDirectory) + "\\" + fileName, true);
            e.CallbackData = fileName;
        }
    }
}
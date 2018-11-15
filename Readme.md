<!-- default file list -->
*Files to look at*:

* [Default.aspx](./CS/Default.aspx) (VB: [Default.aspx.vb](./VB/Default.aspx.vb))
* [Default.aspx.cs](./CS/Default.aspx.cs) (VB: [Default.aspx.vb](./VB/Default.aspx.vb))
<!-- default file list end -->
# ASPxRichEdit - How to upload a document in the working directory using drag-and-drop


In some scenarios, it is necessary to load a document stored on a user's hard disk to the <a href="https://documentation.devexpress.com/AspNet/DevExpress.Web.ASPxRichEdit.ASPxRichEdit.class">ASPxRichEdit</a> control. The <a href="https://documentation.devexpress.com/AspNet/DevExpress.Web.ASPxRichEdit.ASPxRichEdit.class">ASPxRichEdit</a> does not support this feature, but you can use a workaround described in this example. Note, that in this example the open document is saved to the <strong>Working Directory</strong>. If you need to open the document without saving to the <strong>Working Directory</strong> see <a href="https://www.devexpress.com/Support/Center/Example/Details/T438419/aspxrichedit-how-to-open-a-document-using-drag-and-drop">this</a> example.<br><br>The <a href="https://documentation.devexpress.com/AspNet/DevExpress.Web.ASPxUploadControl.class">ASPxUploadControl</a> is developed to save client files to the server via a browser. This control includes the <a href="https://documentation.devexpress.com/AspNet/9886/ASP-NET-WebForms-Controls/File-Management/File-Upload/Concepts/Upload-Modes">Advanced mode</a> that allows users to load documents using drag-and-drop. The <a href="https://documentation.devexpress.com/AspNet/DevExpress.Web.ASPxUploadControl.class">ASPxUploadControl's</a> <a href="https://documentation.devexpress.com/AspNet/DevExpress.Web.UploadAdvancedModeSettings.ExternalDropZoneID.property">ExternalDropZoneID</a> property defines which HTML element is used to release files dragged from the client's hardware. Using this property, you can invoke document loading by dragging it to the <a href="https://documentation.devexpress.com/AspNet/DevExpress.Web.ASPxRichEdit.ASPxRichEdit.members">ASPxRichEdit</a> control. When the <a href="https://documentation.devexpress.com/AspNet/DevExpress.Web.ASPxUploadControl.class">ASPxUploadControl</a> finishes loading the document, it is saved to the <a href="https://documentation.devexpress.com/AspNet/DevExpress.Web.ASPxRichEdit.ASPxRichEdit.members">ASPxRichEdit's</a> <strong>WorkingDirectory</strong> and opened using the <a href="https://documentation.devexpress.com/AspNet/117668/ASP-NET-WebForms-Controls/Rich-Text-Editor/Concepts/Client-API/Client-Commands">client-side command</a>.

<br/>



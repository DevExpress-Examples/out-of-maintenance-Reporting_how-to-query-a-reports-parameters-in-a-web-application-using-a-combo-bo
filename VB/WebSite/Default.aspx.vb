Imports Microsoft.VisualBasic
Imports System
Imports System.Data
Imports System.Configuration
Imports System.Web
Imports System.Web.Security
Imports System.Web.UI
Imports System.Web.UI.WebControls
Imports System.Web.UI.WebControls.WebParts
Imports System.Web.UI.HtmlControls

Partial Public Class _Default
	Inherits System.Web.UI.Page

	Protected Sub Page_Load(ByVal sender As Object, ByVal e As EventArgs)
		Dim report As New XtraReport1()
		If Me.ASPxComboBox1.Value IsNot Nothing Then
			report.Parameters("CustomerID").Value = Me.ASPxComboBox1.Value
			Me.ReportViewer1.Report = report
		End If

	End Sub

End Class

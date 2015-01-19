Imports Microsoft.Reporting.WinForms
Public Class receipt_ferpay
    Dim class_conn As New class_conn
    Public con_id As String = ""

    Sub select_data()
        Dim sql As String = ""
        Dim dta As DataTable
        sql += " select top 1 * from vw_re_fer where contract_fer_no = '" + con_id + "' order by create_date desc"
        dta = class_conn.selectbase(Sql)

        ReportViewer1.LocalReport.DataSources.Clear()
        ReportViewer1.LocalReport.ReportPath = "..\..\Report\receipt_fer.rdlc"
        ReportViewer1.LocalReport.DataSources.Add(New ReportDataSource("DataSet1", dta))
        Me.ReportViewer1.RefreshReport()
    End Sub

    Private Sub receipt_ferpay_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        select_data()
        Me.ReportViewer1.RefreshReport()
    End Sub

    Private Sub tst_back_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tst_back.Click
        Close()

    End Sub
End Class
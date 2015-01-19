Imports Microsoft.Reporting.WinForms
Public Class Re_oilcon
    Dim class_conn As New class_conn
    Sub select_data()
        Dim date_from As String = dtp_date1.Value.Year.ToString & "-" & dtp_date1.Value.Month.ToString & "-" & dtp_date1.Value.Day.ToString
        Dim date_to As String = dtp_date2.Value.Year.ToString & "-" & dtp_date2.Value.Month.ToString & "-" & dtp_date2.Value.Day.ToString
        Dim sql As String = ""
        Dim dta As DataTable

        Dim date_day As String
        Dim date_month As String
        Dim name_month As String
        Dim date_year As String
        Dim date_year2 As String
        Dim sum_date As String
        date_day = Me.dtp_date1.Value.Day
        date_month = Me.dtp_date1.Value.Month
        date_year = Me.dtp_date1.Value.Year
        date_year2 = date_year + 543
        If date_month = "1" Then
            name_month = "มกราคม"
        ElseIf date_month = "2" Then
            name_month = "กุมภาพันธ์"
        ElseIf date_month = "3" Then
            name_month = "มีนาคม"
        ElseIf date_month = "4" Then
            name_month = "เมษายน"
        ElseIf date_month = "5" Then
            name_month = "พฤษภาคม"
        ElseIf date_month = "6" Then
            name_month = "มิถุนายน"
        ElseIf date_month = "7" Then
            name_month = "กรกฎาคม"
        ElseIf date_month = "8" Then
            name_month = "สิงหาคม"
        ElseIf date_month = "9" Then
            name_month = "กันยายน"
        ElseIf date_month = "10" Then
            name_month = "ตุลาคม"
        ElseIf date_month = "11" Then
            name_month = "พฤศจิกายน"
        ElseIf date_month = "12" Then
            name_month = "ธันวาคม"
        Else
            name_month = "ธันวาคม"
        End If

        Dim date_day2 As String
        Dim date_month2 As String
        Dim name_month2 As String
        Dim date_year21 As String
        Dim date_year22 As String
        date_day2 = Me.dtp_date2.Value.Day
        date_month2 = Me.dtp_date2.Value.Month
        date_year21 = Me.dtp_date2.Value.Year
        date_year22 = date_year21 + 543
        If date_month2 = "1" Then
            name_month2 = "มกราคม"
        ElseIf date_month2 = "2" Then
            name_month2 = "กุมภาพันธ์"
        ElseIf date_month2 = "3" Then
            name_month2 = "มีนาคม"
        ElseIf date_month2 = "4" Then
            name_month2 = "เมษายน"
        ElseIf date_month2 = "5" Then
            name_month2 = "พฤษภาคม"
        ElseIf date_month2 = "6" Then
            name_month2 = "มิถุนายน"
        ElseIf date_month2 = "7" Then
            name_month2 = "กรกฎาคม"
        ElseIf date_month2 = "8" Then
            name_month2 = "สิงหาคม"
        ElseIf date_month2 = "9" Then
            name_month2 = "กันยายน"
        ElseIf date_month2 = "10" Then
            name_month2 = "ตุลาคม"
        ElseIf date_month2 = "11" Then
            name_month2 = "พฤศจิกายน"
        ElseIf date_month2 = "12" Then
            name_month2 = "ธันวาคม"
        Else
            name_month2 = "ธันวาคม"
        End If

        sum_date = date_day + " " + name_month + " พ.ศ." + date_year2 + " - " + date_day2 + " " + name_month2 + " พ.ศ." + date_year22

        sql += " select * from vw_re_oilcon where create_date >= '" + date_from + " 00:00:00' and  create_date <= '" + date_to + " 23:59:59'"
        dta = class_conn.selectbase(sql)

        ReportViewer1.LocalReport.DataSources.Clear()
        ReportViewer1.LocalReport.ReportPath = "..\..\Report\re_oilcon.rdlc"
        ReportViewer1.LocalReport.DataSources.Add(New ReportDataSource("DataSet1", dta))
        Dim myParam2 As New ReportParameter("date_today", sum_date)
        ReportViewer1.LocalReport.SetParameters(myParam2)
        Me.ReportViewer1.RefreshReport()
    End Sub


    Private Sub tst_back_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tst_back.Click
        Close()

    End Sub

    Private Sub Re_oilcon_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        Me.ReportViewer1.RefreshReport()
    End Sub

    Private Sub btn_search_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_search.Click
        select_data()

    End Sub
End Class
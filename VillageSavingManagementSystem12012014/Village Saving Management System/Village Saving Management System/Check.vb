Imports Microsoft.VisualBasic
Imports System.Data
Imports System.Data.SqlClient
Public Class Check
    Dim class_conn As New class_conn

    Sub select_data()
        Dim date_from As String = dtp_time1.Value.Year.ToString & "-" & dtp_time1.Value.Month.ToString & "-" & dtp_time1.Value.Day.ToString
        Dim date_to As String = dtp_time2.Value.Year.ToString & "-" & dtp_time2.Value.Month.ToString & "-" & dtp_time2.Value.Day.ToString

        Dim sql As String = ""
        Dim dta As DataTable
        sql += " select username,position,use_date,out_date from vw_login where use_date >='" + date_from + " 00:00:00' and use_date <= '" + date_to + " 23:59:59' ORDER BY use_date DESC"

        dta = class_conn.selectbase(sql)
        Dim count As Integer = 0
        count = dta.Rows.Count
      If count = 0 Then
            MessageBox.Show("ไม่พบข้อมูล", "มีปัญหา", MessageBoxButtons.OK, MessageBoxIcon.Warning)


        Else
            Me.DataGridView1.DataSource = dta
        End If

    End Sub

    Private Sub tst_print_ButtonClick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tst_print.ButtonClick

    End Sub

    Private Sub tst_back_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tst_back.Click
        Close()

    End Sub

  
    Private Sub btn_search_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_search.Click
        select_data()
    End Sub


End Class
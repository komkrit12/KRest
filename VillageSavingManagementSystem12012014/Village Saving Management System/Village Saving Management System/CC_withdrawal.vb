﻿Imports Microsoft.VisualBasic
Imports System.Data
Imports System.Data.SqlClient
Public Class CC_withdrawal
    Dim class_conn As New class_conn

    Sub load_data()
        Dim sql As String = ""
        Dim dta As DataTable

        If Me.cbo_search2.Text = "ชื่อ" Then
            sql += " select *, cust_fname + ' ' + cust_lname AS FullName from vw_no_trans where cust_fname like '%" + Me.txt_search.Text + "%' and status is null and status_tarns = 'แจ้งยกเลิก' and trans_type = 'Withdrawal' Order by cust_id ASC"
        ElseIf Me.cbo_search2.Text = "รหัสสมาชิก" Then
            sql += " select *, cust_fname + ' ' + cust_lname AS FullName from vw_no_trans where cust_id like '%" + Me.txt_search.Text + "%' and status is null and status_tarns = 'แจ้งยกเลิก'  and trans_type = 'Withdrawal' Order by cust_id ASC"
        ElseIf Me.cbo_search2.Text = "เลขบัตรประชาชน" Then
            sql += " select *, cust_fname + ' ' + cust_lname AS FullName from vw_no_trans where personal_id like '%" + Me.txt_search.Text + "%' and status is null and status_tarns = 'แจ้งยกเลิก'  and trans_type = 'Withdrawal' Order by cust_id ASC"
        Else
            sql += " select * from vw_no_trans"
        End If
        dta = class_conn.selectbase(sql)
        Me.DataGridView1.DataSource = dta

    End Sub

    Sub select_data()
        Dim sql As String = ""
        Dim dta As DataTable
        sql += " select * from vw_no_trans where status_tarns = 'แจ้งยกเลิก' and trans_type = 'Withdrawal' Order by cust_id ASC"
        dta = class_conn.selectbase(sql)
        Me.DataGridView1.DataSource = dta
    End Sub

    Sub cencel_data()
        Dim sql As String = ""
        sql += " UPDATE transection SET"
        sql += " status_tarns = 'ยกเลิก'"
        sql += " WHERE trans_id=" + Me.lb.Text + ""

        If class_conn.writebase(sql) = True Then
            select_data()

            MessageBox.Show("ยกเลิกรายการสำเร็จ", "Village Saving Management System", MessageBoxButtons.OK, MessageBoxIcon.Information)

        Else
            MessageBox.Show("ยกเลิกรายการล้มเหลว", "Village Saving Management System", MessageBoxButtons.OK, MessageBoxIcon.Warning)

        End If

    End Sub

    Sub cencel_dataall()
        Dim sql As String = ""
        sql += " UPDATE transection SET"
        sql += " status_tarns = 'ยกเลิก'"
        sql += " WHERE status_tarns= 'แจ้งยกเลิก'"
        If class_conn.writebase(sql) = True Then
            select_data()

            MessageBox.Show("บันทึกการยกเลิกสำเร็จ", "Village Saving Management System", MessageBoxButtons.OK, MessageBoxIcon.Information)

        Else
            MessageBox.Show("บันทึกการยกเลิกล้มเหลว", "Village Saving Management System", MessageBoxButtons.OK, MessageBoxIcon.Warning)

        End If
    End Sub

    Private Sub tst_cancel_ButtonClick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tst_cancel.ButtonClick
        If MsgBox("คุณต้องการยกเลิกรายการนี้ใช่หรือไม่" & "", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
            cencel_data()
        End If
    End Sub


    Private Sub tst_allcancel_ButtonClick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tst_allcancel.ButtonClick
        If MsgBox("คุณต้องการยกเลิกรายการทั้งหมดใช่หรือไม่" & "", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
            cencel_dataall()
        End If
    End Sub


    Private Sub btn_search_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_search.Click
        load_data()

    End Sub


    Private Sub tst_back_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tst_back.Click
        Close()

    End Sub

    Private Sub DataGridView1_CellContentClick_1(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick
        Dim UserSelectRow As Integer = 0
        UserSelectRow = CInt(Me.DataGridView1.CurrentRow.Index.ToString)
        Me.lb.Text = DataGridView1.Rows.Item(UserSelectRow).Cells("trans_id").Value.ToString
        Me.txt_id.Text = DataGridView1.Rows.Item(UserSelectRow).Cells("cust_id").Value.ToString
        Me.txt_fullname.Text = DataGridView1.Rows.Item(UserSelectRow).Cells("FullName").Value.ToString
        Me.txt_personalid.Text = DataGridView1.Rows.Item(UserSelectRow).Cells("personal_id").Value.ToString
        Me.txt_withdrawal.Text = DataGridView1.Rows.Item(UserSelectRow).Cells("trans_value").Value.ToString
        Me.dtp_1.Text = DataGridView1.Rows.Item(UserSelectRow).Cells("time_create").Value.ToString
        Me.txt_create.Text = DataGridView1.Rows.Item(UserSelectRow).Cells("createby").Value.ToString
    End Sub
End Class
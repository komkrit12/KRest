﻿Imports Microsoft.VisualBasic
Imports System.Data
Imports System.Data.SqlClient
Public Class CC_ferstock
    Dim class_conn As New class_conn



    Sub cencel_data()
        Dim sql As String = ""
        sql += " UPDATE fer_receive SET"
        sql += " status_ferreceive = 'ยกเลิก'"
        sql += " WHERE re_id=" + Me.lb.Text + ""

        If class_conn.writebase(sql) = True Then
            select_data()

            MessageBox.Show("ยกเลิกรายการสำเร็จ", "Village Saving Management System", MessageBoxButtons.OK, MessageBoxIcon.Information)

        Else
            MessageBox.Show("ยกเลิกรายการล้มเหลว", "Village Saving Management System", MessageBoxButtons.OK, MessageBoxIcon.Warning)

        End If

    End Sub

    Sub cencel_dataall()
        Dim sql As String = ""
        sql += " UPDATE fer_receive SET"
        sql += " status_ferreceive = 'ยกเลิก'"
        sql += " WHERE status_ferreceive= 'แจ้งยกเลิก'"
        If class_conn.writebase(sql) = True Then
            select_data()

            MessageBox.Show("บันทึกการยกเลิกสำเร็จ", "Village Saving Management System", MessageBoxButtons.OK, MessageBoxIcon.Information)

        Else
            MessageBox.Show("การยกเลิกล้มเหลวค่ะ", "Village Saving Management System", MessageBoxButtons.OK, MessageBoxIcon.Warning)

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

    Private Sub tst_back_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tst_back.Click
        Close()

    End Sub

    Private Sub DataGridView1_CellContentClick_1(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick
        Dim UserSelectRow As Integer = 0
        UserSelectRow = CInt(Me.DataGridView1.CurrentRow.Index.ToString)
        Me.lb.Text = DataGridView1.Rows.Item(UserSelectRow).Cells("re_id").Value.ToString
        Me.txt_fertype.Text = DataGridView1.Rows.Item(UserSelectRow).Cells("fer_type").Value.ToString
        Me.txt_receive.Text = DataGridView1.Rows.Item(UserSelectRow).Cells("receive").Value.ToString
        Me.txt_sumprice.Text = DataGridView1.Rows.Item(UserSelectRow).Cells("sum_price").Value.ToString
        Me.txt_number.Text = DataGridView1.Rows.Item(UserSelectRow).Cells("number").Value.ToString
        Me.dtp_time.Text = DataGridView1.Rows.Item(UserSelectRow).Cells("receive_date").Value.ToString
        Me.txt_create.Text = DataGridView1.Rows.Item(UserSelectRow).Cells("createby").Value.ToString

    End Sub

    Sub select_data()
        Dim sql As String = ""
        Dim dta As DataTable
        sql += " select re_id,fer_type,receive,sum_price,number,receive_date,createby from vw_no_ferreceive where status_ferreceive = 'แจ้งยกเลิก' and status_fer is null ORDER BY receive_date DESC "
        dta = class_conn.selectbase(sql)
        Me.DataGridView1.DataSource = dta

    End Sub

    Private Sub CC_ferstock_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        select_data()

    End Sub
End Class
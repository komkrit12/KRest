Imports Microsoft.VisualBasic
Imports System.Data
Imports System.Data.SqlClient
Public Class Fer_Add
    Dim class_conn As New class_conn

    Sub insert_data()
        Dim sql As String = ""
        sql += " Insert into fertilizer (fer_type,price,point,time_create,createby)"
        sql += " Values ('" + Me.txt_type.Text + "'," + Me.txt_price.Text + "," + Me.txt_point.Text + ",getdate(),'" + Me.txt_create.Text + "')"

        If class_conn.writebase(sql) = True Then
            MessageBox.Show("ทำการบันทึกสำเร็จ", "Village Saving Management System", MessageBoxButtons.OK, MessageBoxIcon.Information)
            select_data()

        Else
            MessageBox.Show("ทำการบันทึกล้มเหลว", "Village Saving Management System", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End If
    End Sub

    Sub clear_text()
        Me.txt_type.Text = ""
        Me.txt_price.Text = ""
        Me.txt_point.Text = ""

    End Sub

    Sub select_data()
        Dim sql As String = ""
        Dim dta As DataTable
        sql += " select * from fertilizer where status_fer is null"
        dta = class_conn.selectbase(sql)
        Me.DataGridView1.DataSource = dta
    End Sub

    Sub cencel_data()
        Dim sql As String = ""
        If lb_status.Text = "-" Or lb_status.Text = "" Then
            sql += " UPDATE fertilizer"
            sql += " SET status_fer = 'ยกเลิก'"
            sql += " WHERE fer_id=" + Me.lb_ferid.Text + ""
        End If
        If class_conn.writebase(sql) = True Then
            select_data()

            MessageBox.Show("บันทึกการยกเลิกสำเร็จ", "Village Saving Management System", MessageBoxButtons.OK, MessageBoxIcon.Information)

        Else
            MessageBox.Show("บันทึกการยกเลิกล้มเหลว", "Village Saving Management System", MessageBoxButtons.OK, MessageBoxIcon.Warning)

        End If
    End Sub

    Sub check_data()
        If Me.txt_type.Text = "" Or Me.txt_price.Text = "" Or Me.txt_point.Text = "" Then
            MessageBox.Show("กรุณากรอกข้อมูลให้สมบูรณ์", "Village Saving Management System", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        Else
            insert_data()

        End If
    End Sub

    Sub username_log()
        Dim dta As DataTable
        Dim sql As String = ""
        sql += " select * from register"
        sql += " where register_id=" + Me.lb_reid.Text + ""
        dta = class_conn.selectbase(sql)

        Dim fullname As String = ""
        fullname += dta.Rows(0).Item("username")
        Me.txt_create.Text = fullname

    End Sub
    

    Private Sub tst_save_ButtonClick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tst_save.ButtonClick
        check_data()


    End Sub

    Private Sub tst_clear_ButtonClick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tst_clear.ButtonClick
        clear_text()

    End Sub

    Private Sub tst_back_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tst_back.Click
        Close()
    End Sub

    Private Sub tst_cancel_ButtonClick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tst_cancel.ButtonClick
        If MsgBox("คุณต้องการยกเลิกรายการนี้ใช่หรือไม่" & "", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
            cencel_data()
        End If
    End Sub

    Private Sub Fer_Add_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        select_data()
        username_log()

    End Sub

    Private Sub DataGridView1_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick
        Dim UserSelectRow As Integer = 0
        UserSelectRow = CInt(Me.DataGridView1.CurrentRow.Index.ToString)
        Me.lb_ferid.Text = DataGridView1.Rows.Item(UserSelectRow).Cells("fer_id").Value.ToString
        Me.lb_status.Text = DataGridView1.Rows.Item(UserSelectRow).Cells("status_fer").Value.ToString
        Me.txt_type.Text = DataGridView1.Rows.Item(UserSelectRow).Cells("fer_type").Value.ToString
        Me.txt_price.Text = DataGridView1.Rows.Item(UserSelectRow).Cells("price").Value.ToString
        Me.txt_point.Text = DataGridView1.Rows.Item(UserSelectRow).Cells("point").Value.ToString
        Me.dtp_date.Text = DataGridView1.Rows.Item(UserSelectRow).Cells("time_create").Value.ToString
    End Sub

    Private Sub txt_price_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txt_price.TextChanged
        If Me.txt_price.Text = "" Then
            Exit Sub
        End If

        If Not IsNumeric(Me.txt_price.Text) Then
            MessageBox.Show("กรุณากรอกข้อมูลที่เป็นตัวเลขเท่านั้น", "Village Saving Management System", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Me.txt_price.Text = ""
        End If
    End Sub

    Private Sub txt_stock_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txt_point.TextChanged
        If Me.txt_point.Text = "" Then
            Exit Sub
        End If

        If Not IsNumeric(Me.txt_point.Text) Then
            MessageBox.Show("กรุณากรอกข้อมูลที่เป็นตัวเลขเท่านั้น", "Village Saving Management System", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Me.txt_point.Text = ""
        End If
    End Sub

  
End Class
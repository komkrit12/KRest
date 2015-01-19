Imports Microsoft.VisualBasic
Imports System.Data
Imports System.Data.SqlClient
Public Class Deposit
    Dim class_conn As New class_conn

    Sub load_data()
        Dim sql As String = ""
        Dim dta As DataTable

        If Me.cbo_search.Text = "ชื่อ" Then
            sql += " select * from customers where cust_fname like '%" + Me.txt_search.Text + "%' and status is null"
        ElseIf Me.cbo_search.Text = "รหัสสมาชิก" Then
            sql += " select * from customers where cust_id like '%" + Me.txt_search.Text + "%' and status is null"
        ElseIf Me.cbo_search.Text = "เลขบัตรประชาชน" Then
            sql += " select * from customers where personal_id like '%" + Me.txt_search.Text + "%' and status is null"

        Else

            MessageBox.Show("กรุณาเลือกคำค้นหาก่อนค่ะ", "Village Saving Management System", MessageBoxButtons.OK, MessageBoxIcon.Warning)

        End If

        dta = class_conn.selectbase(sql)
        Dim count As Integer = 0
        count = dta.Rows.Count

        If Me.txt_search.Text = "" Then
            MessageBox.Show("กรุณากรอกข้อมูลให้สมบูรณ์", "Village Saving Management System", MessageBoxButtons.OK, MessageBoxIcon.Warning)

        ElseIf count = 0 Then
            MessageBox.Show("ไม่พบข้อมูล", "Village Saving Management System", MessageBoxButtons.OK, MessageBoxIcon.Warning)

        Else
            Me.DataGridView1.DataSource = dta
        End If

    End Sub

    Sub insert_data()
        Dim balance As Integer
        Dim deposit As Integer
        Dim sum_balance As Integer
        balance = Me.txt_balance.Text
        deposit = Me.txt_deposit.Text
        sum_balance = deposit + balance
        Dim sql As String = ""
        sql += " Insert into transection (cust_id,trans_type,trans_value,balance,time_create,createby)"
        sql += " Values ('" + Me.txt_id.Text + "','DEPOSIT'," + Me.txt_deposit.Text + "," + CStr(sum_balance) + ",getdate(),'" + Me.txt_create.Text + "' )"

        If class_conn.writebase(sql) = True Then

            MessageBox.Show("ทำรายการสำเร็จ", "Village Saving Management System", MessageBoxButtons.OK, MessageBoxIcon.Information)
            cal_cost()
            Me.txt_deposit.Text = ""

        Else
            MessageBox.Show("ทำรายการล้มเหลว", "Village Saving Management System", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End If

    End Sub

    Sub cal_cost()
        Dim deposit As Decimal
        Dim Withdrawal As Decimal
        Dim cost As Decimal
        Dim count_de As Integer
        Dim count_w As Integer
        Dim sql_de As String = ""
        Dim dta_de As DataTable
        Dim sql_w As String = ""
        Dim dta_w As DataTable
        sql_de += " select * from trans_vw1 where cust_id ='" + Me.txt_id.Text + "'"
        dta_de = class_conn.selectbase(sql_de)
        count_de = dta_de.Rows.Count
        If (count_de <> 0) Then
            deposit = dta_de.Rows(0).Item("cost_de").ToString
        Else
            deposit = 0
        End If

        sql_w += " select * from trans_vw2 where cust_id ='" + Me.txt_id.Text + "'"
        dta_w = class_conn.selectbase(sql_w)
        count_w = dta_w.Rows.Count
        If (count_w <> 0) Then
            Withdrawal = dta_w.Rows(0).Item("cost_tran").ToString
        Else
            Withdrawal = 0
        End If

        cost = deposit - Withdrawal
        Me.txt_balance.Text = cost

    End Sub


    Sub check_data()
        If Me.txt_id.Text = "" Or Me.txt_deposit.Text = "" Then
            MessageBox.Show("กรุณากรอกข้อมูลให้สมบูรณ์", "Village Saving Management System", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        Else
            insert_data()

        End If

    End Sub

    Sub clear_text()
        Me.txt_id.Text = ""
        Me.txt_fname.Text = ""
        Me.txt_lname.Text = ""
        Me.txt_address.Text = ""
        Me.txt_personalid.Text = ""
        Me.txt_balance.Text = ""
        Me.txt_deposit.Text = ""

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
        If MsgBox("คุณต้องการบันทึกการฝากใช่หรือไม่" & "", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
            check_data()
        End If

    End Sub

    Private Sub btn_search_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_search.Click
        load_data()

    End Sub

    Private Sub DataGridView1_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick
        Dim UserSelectRow As Integer = 0
        UserSelectRow = CInt(Me.DataGridView1.CurrentRow.Index.ToString)
        Me.txt_id.Text = DataGridView1.Rows.Item(UserSelectRow).Cells("cust_id").Value.ToString
        Me.txt_fname.Text = DataGridView1.Rows.Item(UserSelectRow).Cells("cust_fname").Value.ToString
        Me.txt_lname.Text = DataGridView1.Rows.Item(UserSelectRow).Cells("cust_lname").Value.ToString
        Me.txt_address.Text = DataGridView1.Rows.Item(UserSelectRow).Cells("cust_address").Value.ToString
        Me.txt_personalid.Text = DataGridView1.Rows.Item(UserSelectRow).Cells("personal_id").Value.ToString
        Me.txt_deposit.Text = DataGridView1.Rows.Item(UserSelectRow).Cells("balance").Value.ToString
        cal_cost()

    End Sub

    Private Sub tst_close_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tst_close.Click
        Close()

    End Sub

  
    Private Sub txt_deposit_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txt_deposit.TextChanged
        If Me.txt_deposit.Text = "" Then
            Exit Sub
        End If

        If Not IsNumeric(Me.txt_deposit.Text) Then
            MessageBox.Show("กรุณากรอกข้อมูลที่เป็นตัวเลขเท่านั้น", "Village Saving Management System", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Me.txt_deposit.Text = ""
        End If

    End Sub

    Private Sub Deposit_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        username_log()

    End Sub

    Private Sub tst_clear_ButtonClick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tst_clear.ButtonClick
        clear_text()

    End Sub
End Class

Imports Microsoft.VisualBasic
Imports System.Data
Imports System.Data.SqlClient

Public Class Edit
    Dim class_conn As New class_conn

    Sub load_data()
        Dim sql As String = ""
        Dim dta As DataTable

        If Me.cbo_search.Text = "ชื่อ" Then
            sql += " select cust_id,cust_fname,cust_lname,cust_address,tel,occupation,personal_id,age,earnings_month from customers where cust_fname like '%" + Me.txt_search.Text + "%' and status is null"
        ElseIf Me.cbo_search.Text = "รหัสสมาชิก" Then
            sql += " select cust_id,cust_fname,cust_lname,cust_address,tel,occupation,personal_id,age,earnings_month from customers where cust_id like '%" + Me.txt_search.Text + "%' and status is null"
        ElseIf Me.cbo_search.Text = "เลขบัตรประชาชน" Then
            sql += " select cust_id,cust_fname,cust_lname,cust_address,tel,occupation,personal_id,age,earnings_month from customers where personal_id like '%" + Me.txt_search.Text + "%' and status is null"

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


    Sub edit_data()
        Dim sql As String = ""
        sql += " update customers set"
        sql += " cust_fname='" + Me.txt_fname.Text + "',"
        sql += " cust_lname='" + Me.txt_lname.Text + "',"
        sql += " cust_address='" + Me.txt_address.Text + "',"
        sql += " tel='" + Me.txt_tel.Text + "',"
        sql += " occupation='" + Me.cbo_vocation.Text + "',"
        sql += " personal_id='" + Me.txt_personalid.Text + "',"
        sql += " age=" + Me.txt_age.Text + ","
        sql += " earnings_month=" + Me.txt_month.Text + ","
        sql += " updateby='" + Me.txt_create.Text + "',"
        sql += " time_update=getdate()"
        sql += " where cust_id='" + Me.txt_id.Text + "'"
        If class_conn.writebase(sql) = True Then
            MessageBox.Show("ทำการแก้ไขสำเร็จ", "Village Saving Management System", MessageBoxButtons.OK, MessageBoxIcon.Information)
            select_data()

        Else
            MessageBox.Show("ทำการแก้ไขล้มเหลว", "Village Saving Management System", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End If

    End Sub

    Sub clear_text()
        Me.txt_id.Text = ""
        Me.txt_fname.Text = ""
        Me.txt_lname.Text = ""
        Me.txt_address.Text = ""
        Me.txt_tel.Text = ""
        Me.cbo_vocation.Text = "--เลือก--"
        Me.txt_personalid.Text = ""
        Me.txt_age.Text = ""
        Me.txt_month.Text = ""


    End Sub

    Sub select_data()
        Dim sql As String = ""
        Dim dta As DataTable
        sql += " select cust_id,cust_fname,cust_lname,cust_address,tel,occupation,personal_id,age,earnings_month,updateby from customers where cust_id='" + Me.txt_id.Text + "'"
        dta = class_conn.selectbase(sql)
        Me.DataGridView1.DataSource = dta
    End Sub

    Sub check_data()
        If Me.txt_fname.Text = "" Or Me.txt_lname.Text = "" Or Me.txt_address.Text = "" Or Me.txt_tel.Text = "" _
            Or Me.txt_personalid.Text = "" Or Me.txt_month.Text = "" Or Me.txt_age.Text = "" Then
            MessageBox.Show("กรุณากรอกข้อมูลให้สมบูรณ์", "Village Saving Management System", MessageBoxButtons.OK, MessageBoxIcon.Warning)

        Else
            edit_data()
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
        If MsgBox("คุณต้องการทำการแก้ไขใช่หรือไม่" & "", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
            check_data()
        End If
    End Sub

    Private Sub Edit_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        username_log()

    End Sub

    Private Sub btn_search_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_search.Click
        load_data()
    End Sub

    Private Sub tst_back_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tst_back.Click
        Close()
    End Sub

    Private Sub DataGridView1_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick
        Dim UserSelectRow As Integer = 0
        UserSelectRow = CInt(Me.DataGridView1.CurrentRow.Index.ToString)
        Me.txt_id.Text = DataGridView1.Rows.Item(UserSelectRow).Cells("cust_id").Value.ToString
        Me.txt_fname.Text = DataGridView1.Rows.Item(UserSelectRow).Cells("cust_fname").Value.ToString
        Me.txt_lname.Text = DataGridView1.Rows.Item(UserSelectRow).Cells("cust_lname").Value.ToString
        Me.txt_address.Text = DataGridView1.Rows.Item(UserSelectRow).Cells("cust_address").Value.ToString
        Me.txt_tel.Text = DataGridView1.Rows.Item(UserSelectRow).Cells("tel").Value.ToString
        Me.cbo_vocation.Text = DataGridView1.Rows.Item(UserSelectRow).Cells("occupation").Value.ToString
        Me.txt_personalid.Text = DataGridView1.Rows.Item(UserSelectRow).Cells("personal_id").Value.ToString
        Me.txt_age.Text = DataGridView1.Rows.Item(UserSelectRow).Cells("age").Value.ToString
        Me.txt_month.Text = DataGridView1.Rows.Item(UserSelectRow).Cells("earnings_month").Value.ToString

    End Sub

    Private Sub txt_tel_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txt_tel.TextChanged
        If txt_tel.Text = "" Then
            Exit Sub
        End If

        If Not IsNumeric(txt_tel.Text) Then
            MessageBox.Show("กรุณากรอกข้อมูลที่เป็นตัวเลขเท่านั้น", "Village Saving Management System", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            txt_tel.Text = ""
        End If
    End Sub

    Private Sub txt_personalid_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txt_personalid.TextChanged
        If txt_personalid.Text = "" Then
            Exit Sub
        End If

        If Not IsNumeric(txt_personalid.Text) Then
            MessageBox.Show("กรุณากรอกข้อมูลที่เป็นตัวเลขเท่านั้น", "Village Saving Management System", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            txt_personalid.Text = ""
        End If
    End Sub

    Private Sub txt_age_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txt_month.TextChanged
        If txt_month.Text = "" Then
            Exit Sub
        End If

        If Not IsNumeric(txt_month.Text) Then
            MessageBox.Show("กรุณากรอกข้อมูลที่เป็นตัวเลขเท่านั้น", "Village Saving Management System", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            txt_month.Text = ""
        End If
    End Sub

    Private Sub txt_month_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txt_age.TextChanged
        If txt_age.Text = "" Then
            Exit Sub
        End If

        If Not IsNumeric(txt_age.Text) Then
            MessageBox.Show("กรุณากรอกข้อมูลที่เป็นตัวเลขเท่านั้น", "Village Saving Management System", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            txt_age.Text = ""
        End If
    End Sub

    Private Sub tst_clear_ButtonClick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tst_clear.ButtonClick
        clear_text()

    End Sub

End Class
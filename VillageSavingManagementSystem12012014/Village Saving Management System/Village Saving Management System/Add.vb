Imports Microsoft.VisualBasic
Imports System.Data
Imports System.Data.SqlClient

Public Class Add
    Dim class_conn As New class_conn

    Sub cus_id()
        Dim sql As String = ""
        Dim dta As DataTable

        sql += "select cust_id from customers order by cust_id desc"

        dta = class_conn.selectbase(sql)
        Dim a As String = ""
        Dim b As Integer
        a = dta.Rows(0).Item("cust_id").ToString
        b = CInt(a) + 1
        If b >= 0 And b < 10 Then
            Me.txt_id.Text = "000" + CStr(b)

        ElseIf b >= 0 And b < 100 Then
            Me.txt_id.Text = "00" + CStr(b)

        ElseIf b >= 0 And b < 1000 Then
            Me.txt_id.Text = "0" + CStr(b)

        ElseIf b >= 0 And b < 10000 Then
            Me.txt_id.Text = CStr(b)
        Else
            Me.txt_id.Text = CStr(b)

        End If

    End Sub


    Sub insert_data()
        Dim sql As String = ""
        sql += " Insert into customers (cust_id,cust_fname,cust_lname,cust_address,tel,occupation,personal_id,age,earnings_month,time_create,createby)"
        sql += " Values ('" + Me.txt_id.Text + "','" + Me.txt_fname.Text + "','" + Me.txt_lname.Text + "','" + Me.txt_address.Text + "'"
        sql += " ,'" + Me.txt_tel.Text + "','" + Me.cbo_vocation.Text + "'," + Me.txt_personalid.Text + "," + Me.txt_age.Text + "," + Me.txt_month.Text + ",getdate(),'" + Me.txt_create.Text + "' )"

        If class_conn.writebase(sql) = True Then
            MessageBox.Show("ทำรายการสำเร็จ", "Village Saving Management System", MessageBoxButtons.OK, MessageBoxIcon.Information)
            select_data()

        Else
            MessageBox.Show("ทำรายล้มเหลว", "Village Saving Management System", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End If
    End Sub

    Sub clear_text()
        Me.txt_fname.Text = ""
        Me.txt_lname.Text = ""
        Me.txt_address.Text = ""
        Me.txt_tel.Text = ""
        Me.cbo_vocation.Text = "--เลือก--"
        Me.txt_personalid.Text = ""
        Me.txt_age.Text = ""
        Me.txt_month.Text = ""
        Me.DataGridView1.DataSource = ""

    End Sub

    Sub select_data()
        Dim sql As String = ""
        Dim dta As DataTable
        sql += " select cust_id,cust_fname,cust_lname,cust_address,tel,occupation,personal_id,age,earnings_month,time_create,createby from customers where cust_id='" + Me.txt_id.Text + "'"
        dta = class_conn.selectbase(sql)
        Me.DataGridView1.DataSource = dta
    End Sub

    Sub check_data()
        If Me.txt_fname.Text = "" Or Me.txt_lname.Text = "" Or Me.txt_address.Text = "" Or Me.txt_tel.Text = "" _
            Or Me.txt_personalid.Text = "" Or Me.txt_age.Text = "" Or Me.txt_month.Text = "" Then
            MessageBox.Show("กรุณากรอกข้อมูลให้สมบูรณ์", "Village Saving Management System", MessageBoxButtons.OK, MessageBoxIcon.Warning)

        ElseIf Me.cbo_vocation.Text = "เกษตรกร" Then
            insert_data()

        ElseIf Me.cbo_vocation.Text = "ข้าราชการ" Then
            insert_data()

        Else
            MessageBox.Show("กรุณากรอกข้อมูลให้สมบูรณ์", "Village Saving Management System", MessageBoxButtons.OK, MessageBoxIcon.Warning)
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

        If MsgBox("คุณต้องการทำการบันทึกใช่หรือไม่" & "", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
            check_data()
        End If

    End Sub

   
    Private Sub Add_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        cus_id()
        select_data()
        username_log()

    End Sub

    Private Sub tst_clear_ButtonClick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tst_clear.ButtonClick
        clear_text()
        cus_id()

    End Sub

    Private Sub tst_back_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tst_back.Click
        Close()

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

    Private Sub txt_age_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txt_age.TextChanged
        If txt_age.Text = "" Then
            Exit Sub
        End If

        If Not IsNumeric(txt_age.Text) Then
            MessageBox.Show("กรุณากรอกข้อมูลที่เป็นตัวเลขเท่านั้น", "Village Saving Management System", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            txt_age.Text = ""
        End If
    End Sub

    Private Sub txt_month_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txt_month.TextChanged
        If txt_month.Text = "" Then
            Exit Sub
        End If

        If Not IsNumeric(txt_month.Text) Then
            MessageBox.Show("กรุณากรอกข้อมูลที่เป็นตัวเลขเท่านั้น", "Village Saving Management System", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            txt_month.Text = ""
        End If
    End Sub

End Class
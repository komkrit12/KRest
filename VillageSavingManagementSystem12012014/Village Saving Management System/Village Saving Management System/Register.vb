Imports Microsoft.VisualBasic
Imports System.Data
Imports System.Data.SqlClient
Public Class Register
    Dim class_conn As New class_conn

    Sub insert_data()
        Dim sql As String = ""
        sql += " Insert into register (username,password,address,personal_id,position,name)"
        sql += " Values ('" + Me.txt_username.Text + "','" + Me.txt_password.Text + "','" + Me.txt_address.Text + "','" + Me.txt_personalid.Text + "','" + Me.cbo_position.Text + "','" + Me.txt_name.Text + "')"

        If class_conn.writebase(sql) = True Then
            MessageBox.Show("ทำการบันทึกสำเร็จ", "Village Saving Management System", MessageBoxButtons.OK, MessageBoxIcon.Information)
            clear_text()
        Else
            MessageBox.Show("ทำการบันทึกล้มเหลว", "Village Saving Management System", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End If
    End Sub


    Sub edit_data()
        Dim sql As String = ""
        sql += " update register set"
        sql += " username='" + Me.txt_username.Text + "',"
        sql += " password='" + Me.txt_password.Text + "',"
        sql += " address='" + Me.txt_address.Text + "',"
        sql += " personal_id='" + Me.txt_personalid.Text + "',"
        sql += " position='" + Me.cbo_position.Text + "',"
        sql += " name='" + Me.txt_name.Text + "',"
        sql += " update_date=getdate()"
        sql += " where register_id=" + Me.lb_id.Text + ""

        If class_conn.writebase(sql) = True Then
            MessageBox.Show("ทำการแก้ไขสำเร็จ", "Village Saving Management System", MessageBoxButtons.OK, MessageBoxIcon.Information)

        Else
            MessageBox.Show("ทำการแก้ไขล้มเหลว", "Village Saving Management System", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End If

    End Sub


    Sub check_data()
        If Me.txt_name.Text = "" Or Me.txt_password.Text = "" Or Me.txt_address.Text = "" Then

            MessageBox.Show("กรุณากรอกข้อมูลให้สมบูรณ์", "Village Saving Management System", MessageBoxButtons.OK, MessageBoxIcon.Warning)


        ElseIf Me.cbo_position.Text = "ประธาน" Then
            insert_data()

        ElseIf Me.cbo_position.Text = "เจ้าหน้าที่" Then
            insert_data()

        Else
            MessageBox.Show("กรุณากรอกข้อมูลให้สมบูรณ์", "Village Saving Management System", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End If
    End Sub

    Sub clear_text()
        Me.lb_id.Text = ""
        Me.txt_name.Text = ""
        Me.txt_address.Text = ""
        Me.txt_personalid.Text = ""
        Me.cbo_position.Text = "--เลือก--"
        Me.txt_password.Text = ""
    End Sub

    Sub cencel_data()
        Dim sql As String = ""
        sql += " UPDATE register"
        sql += " SET status_user = 'ยกเลิก'"
        sql += " WHERE register_id=" + Me.lb_id.Text + ""

        If class_conn.writebase(sql) = True Then
            MessageBox.Show("บันทึกการยกเลิกสำเร็จ", "Village Saving Management System", MessageBoxButtons.OK, MessageBoxIcon.Information)

        Else
            MessageBox.Show("บันทึกการยกเลิกล้มเหลว", "Village Saving Management System", MessageBoxButtons.OK, MessageBoxIcon.Warning)

        End If
    End Sub

    Sub username_log()
        Dim dta As DataTable
        Dim sql As String = ""
        sql += " select * from register"
        sql += " where register_id=" + Me.lb_reid.Text + ""
        dta = class_conn.selectbase(sql)

        'Dim fullname As String = ""
        Dim type As String = ""
        'fullname = dta.Rows(0).Item("username")
        'Me.lb_type.Text = dta.Rows(0).Item("position")

        type = dta.Rows(0).Item("position")
        If type = "เจ้าหน้าที่" Then
            Me.lb_id.Text = Me.lb_reid.Text
            Me.txt_name.Text = dta.Rows(0).Item("name")
            Me.txt_address.Text = dta.Rows(0).Item("address")
            Me.txt_personalid.Text = dta.Rows(0).Item("personal_id")
            Me.cbo_position.Text = dta.Rows(0).Item("position")
            Me.txt_password.Text = dta.Rows(0).Item("password")
            Me.txt_username.Text = dta.Rows(0).Item("username")
            'Me.txt_create.Text = dta.Rows(0).Item("createby")
            Me.txt_name.Enabled = False
            Me.txt_address.Enabled = False
            Me.txt_personalid.Enabled = False
            Me.cbo_position.Enabled = False
            Me.txt_username.Enabled = False

            Me.lb_Search.Visible = False
            Me.btn_Search.Visible = False
            Me.tst_add.Visible = False
            Me.tst_cancel.Visible = False
            Me.tst_clear.Visible = False
            'Me.txt_create.Text = fullname
            'Else

            '    Me.txt_create.Text = fullname
        End If


    End Sub


    Private Sub tst_add_ButtonClick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tst_add.ButtonClick
        If MsgBox("คุณต้องการเพิ่มผู้เข้าใช้งานใช่หรือไม่" & "", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
            check_data()
            clear_text()
        End If

    End Sub

    Sub check_editdata()
        If Me.txt_name.Text = "" Or Me.txt_password.Text = "" Or Me.txt_address.Text = "" Then

            MessageBox.Show("กรุณากรอกข้อมูลให้สมบูรณ์", "Village Saving Management System", MessageBoxButtons.OK, MessageBoxIcon.Warning)

        ElseIf Me.cbo_position.Text = "ประธาน" Then
            edit_data()
            clear_text()

        ElseIf Me.cbo_position.Text = "เจ้าหน้าที่" Then
            edit_data()
            clear_text()

        Else
            MessageBox.Show("กรุณากรอกข้อมูลให้สมบูรณ์", "Village Saving Management System", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End If
    End Sub

    Private Sub tst_edit_ButtonClick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tst_edit.ButtonClick
        If MsgBox("คุณต้องการทำการแก้ไขใช่หรือไม่" & "", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
            check_editdata()

        End If

    End Sub

    Private Sub tst_clear_ButtonClick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tst_clear.ButtonClick
        clear_text()

    End Sub

    Private Sub tst_back_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tst_back.Click
        Close()

    End Sub

    Private Sub txt_personalid_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txt_personalid.TextChanged
        If Me.txt_personalid.Text = "" Then
            Exit Sub
        End If

        If Not IsNumeric(Me.txt_personalid.Text) Then
            MessageBox.Show("กรุณากรอกข้อมูลที่เป็นตัวเลขเท่านั้น", "Village Saving Management System",
                            MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Me.txt_personalid.Text = ""
        End If

    End Sub

    Private Sub tst_cancel_ButtonClick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tst_cancel.ButtonClick
        If MsgBox("คุณต้องการยกเลิกผู้เข้าใช้งานใช่หรือไม่" & "", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
            cencel_data()
            clear_text()
        End If

    End Sub


    Private Sub btn_Search_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Search.Click

        all_register.ShowDialog()
        If all_register.DialogResult = Windows.Forms.DialogResult.OK Then

            Me.lb_id.Text() = id
            Me.txt_name.Text() = strname
            Me.txt_address.Text() = straddres
            Me.txt_personalid.Text() = strpersonal
            Me.cbo_position.Text() = strposition
            Me.txt_username.Text() = strusername
            Me.txt_password.Text() = strpassword

        End If
    End Sub

    Private Sub Register_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        username_log()
    End Sub


End Class


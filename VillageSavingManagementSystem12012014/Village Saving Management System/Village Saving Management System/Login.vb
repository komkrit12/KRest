Imports Microsoft.VisualBasic
Imports System.Data
Imports System.Data.SqlClient
Public Class Login
    Dim class_conn As New class_conn

    Sub check_data()
        If Me.cbo_username.Text = "--เลือก--" Then
            MessageBox.Show("กรุณาเลือกชื่อในการเข้าสู่ระบบ", "Village Saving Management System", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        ElseIf Me.txt_password.Text = "" Then
            MessageBox.Show("กรุณาใส่รหัสผ่านในการเข้าสู่ระบบ", "Village Saving Management System", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        ElseIf Me.cbo_username.Text = "--เลือก--" And Me.txt_password.Text = "" Then
            MessageBox.Show("กรุณาเลือกชื่อและใส่รหัสผ่านในการเข้าสู่ระบบ", "Village Saving Management System", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        Else
            check_login()

        End If
    End Sub

    Sub check_login()
        Dim dta As DataTable
        Dim sql As String = ""
        sql += " select * from register"
        sql += " where username = '" + Me.cbo_username.Text + "'"
        sql += " and password = '" + Me.txt_password.Text + "'"
        dta = class_conn.selectbase(sql)
        If dta.Rows.Count = 0 Then
            MessageBox.Show("ไม่พบผู้ใช้งาน", "Village Saving Management System", MessageBoxButtons.OK, MessageBoxIcon.Warning)

        ElseIf dta.Rows.Count <> 0 Then
            Dim id As Integer = dta.Rows(0).Item("register_id")
            'Dim position As String = dta.Rows(0).Item("position")

            'If position = "ประธาน" Then
            Dim sql2 As String = ""
            sql2 += " Insert into login (register_id,use_date)"
            sql2 += " Values ( " + CStr(id) + ",getdate())"
            class_conn.writebase(sql2)

            Me.Hide()
            Dim a As New Home
            a.lb_reid.Text = id
            a.Show()
            '    ElseIf position = "เจ้าหน้าที่" Then
            '        Dim sql2 As String = ""
            '        sql2 += " Insert into login (register_id,use_date)"
            '        sql2 += " Values ( " + CStr(id) + ",getdate())"
            '        class_conn.writebase(sql2)

            '        Me.Hide()
            '        Dim a As New home2
            '        a.lb_reid.Text = id
            '        a.Show()
            '    End If
        End If


    End Sub

    Sub data_combobox()
        Dim sql As String
        Dim dta As DataTable
        sql = " select * from Register where status is null"
        dta = class_conn.selectbase(sql)
        Dim dr As DataRow = dta.NewRow()
        dr("register_id") = 0
        dr("username") = "--เลือก--"
        dta.Rows.InsertAt(dr, 0)
        Me.cbo_username.DisplayMember = "username"
        Me.cbo_username.ValueMember = "register_id"
        Me.cbo_username.DataSource = dta

    End Sub

    Private Sub btn_login_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_login.Click
        check_data()

    End Sub

    Private Sub btn_cancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_cancel.Click
        If MsgBox("ท่านต้องการออกจากระบบใช่หรือไม่" & "", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
            Me.Close()

        End If

    End Sub

    Private Sub Login_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        data_combobox()
        Me.txt_password.Text = "12345"

    End Sub

   
End Class
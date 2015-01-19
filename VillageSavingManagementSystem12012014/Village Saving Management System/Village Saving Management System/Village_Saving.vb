Imports Microsoft.VisualBasic
Imports System.Data
Imports System.Data.SqlClient
Public Class Village_Saving
    Dim class_conn As New class_conn

    Sub insert_data()
        Dim sql As String = ""
        sql += " Insert into village (name,address,boss,secretary,dividend,interest_loan,interest_fer,interest_oil,loan_limit,fer_limit,oil_limit,mulct,createby,create_date)"
        sql += " Values ('" + Me.txt_name.Text + "','" + Me.txt_address.Text + "','" + Me.txt_boss.Text + "','" + Me.txt_secretary.Text + "'"
        sql += "," + Me.txt_dividend.Text + "," + Me.txt_int_loan.Text + "," + Me.txt_int_fer.Text + "," + Me.txt_int_oil.Text + ""
        sql += "," + Me.txt_limit.Text + "," + Me.txt_ferlimit.Text + "," + Me.txt_oillimit.Text + "," + Me.txt_mulct.Text + ",'" + Me.txt_create.Text + "',getdate() )"

        If class_conn.writebase(sql) = True Then
            MessageBox.Show("ทำการบันทึกสำเร็จ", "Village Saving Management System", MessageBoxButtons.OK, MessageBoxIcon.Information)

        Else
            MessageBox.Show("ทำการบันทึกล้มเหลว", "Village Saving Management System", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End If
    End Sub

    Sub edit_data()

        Dim sql As String = ""
        If lb_status.Text = "-" Or lb_status.Text = "" Then
            sql += " Update village Set"
            sql += " name='" + Me.txt_name.Text + "',"
            sql += " address='" + Me.txt_address.Text + "',"
            sql += " boss='" + Me.txt_boss.Text + "',"
            sql += " secretary='" + Me.txt_secretary.Text + "',"
            sql += " dividend=" + Me.txt_dividend.Text + ","
            sql += " interest_loan=" + Me.txt_int_loan.Text + ","
            sql += " interest_fer=" + Me.txt_int_fer.Text + ","
            sql += " interest_oil=" + Me.txt_int_oil.Text + ","
            sql += " loan_limit=" + Me.txt_limit.Text + ","
            sql += " fer_limit=" + Me.txt_ferlimit.Text + ","
            sql += " oil_limit=" + Me.txt_oillimit.Text + ","
            sql += " mulct=" + Me.txt_mulct.Text + ","
            sql += " updateby='" + Me.txt_create.Text + "',"
            sql += " update_date=getdate()"
            sql += " WHERE id=" + Me.lb_vid.Text + ""
        End If

        If class_conn.writebase(sql) = True Then
            MessageBox.Show("ทำการแก้ไขสำเร็จ", "Village Saving Management System", MessageBoxButtons.OK, MessageBoxIcon.Information)

        Else
            MessageBox.Show("ทำการแก้ไขล้มเหลว", "Village Saving Management System", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End If

    End Sub

    Sub check_insertdata()
        If Me.txt_name.Text = "" Or Me.txt_address.Text = "" Or Me.txt_boss.Text = "" Or Me.txt_secretary.Text = "" _
           Or Me.txt_dividend.Text = "" Or Me.txt_int_loan.Text = "" Or Me.txt_int_fer.Text = "" Or Me.txt_int_oil.Text = "" _
           Or Me.txt_ferlimit.Text = "" Or Me.txt_oillimit.Text = "" Or Me.txt_limit.Text = "" Or Me.txt_mulct.Text = "" Then

            MessageBox.Show("กรุณากรอกข้อมูลให้สมบูรณ์", "Village Saving Management System", MessageBoxButtons.OK, MessageBoxIcon.Warning)

        Else
            insert_data()
            clear_text()

        End If

    End Sub


    Sub clear_text()
        Me.txt_name.Text = ""
        Me.txt_address.Text = ""
        Me.txt_boss.Text = ""
        Me.txt_secretary.Text = ""
        Me.txt_dividend.Text = ""
        Me.txt_int_loan.Text = ""
        Me.txt_int_fer.Text = ""
        Me.txt_int_oil.Text = ""
        Me.txt_limit.Text = ""
        Me.txt_ferlimit.Text = ""
        Me.txt_oillimit.Text = ""
        Me.txt_mulct.Text = ""

    End Sub

    Sub username_log()
        Dim dta As DataTable
        Dim sql As String = ""
        sql += " select * from register"
        sql += " where register_id=" + Me.lb_reid.Text + ""
        dta = class_conn.selectbase(sql)

        Dim fullname As String = ""
        fullname = dta.Rows(0).Item("username")
        Me.lb_type.Text = dta.Rows(0).Item("position")

        If Me.lb_type.Text = "เจ้าหน้าที่" Then
            
            Me.txt_name.Enabled = False
            Me.txt_address.Enabled = False
            Me.txt_boss.Enabled = False
            Me.txt_secretary.Enabled = False
            Me.txt_dividend.Enabled = False
            Me.txt_int_loan.Enabled = False
            Me.txt_int_fer.Enabled = False
            Me.txt_int_oil.Enabled = False
            Me.txt_limit.Enabled = False
            Me.txt_ferlimit.Enabled = False
            Me.txt_oillimit.Enabled = False
            Me.txt_mulct.Enabled = False
            Me.tst_save.Visible = False
            Me.tst_edit.Visible = False
            Me.tst_clear.Visible = False
            Me.txt_create.Visible = False
            Me.lb_create.Visible = False
            Me.txt_create.Text = fullname
            select_data()
        Else
            Me.txt_name.Enabled = True
            Me.txt_address.Enabled = True
            Me.txt_boss.Enabled = True
            Me.txt_secretary.Enabled = True
            Me.txt_dividend.Enabled = True
            Me.txt_int_loan.Enabled = True
            Me.txt_int_fer.Enabled = True
            Me.txt_int_oil.Enabled = True
            Me.txt_limit.Enabled = True
            Me.txt_ferlimit.Enabled = True
            Me.txt_oillimit.Enabled = True
            Me.txt_mulct.Enabled = True
            Me.tst_save.Visible = True
            Me.tst_edit.Visible = True
            Me.tst_clear.Visible = True
            Me.txt_create.Visible = True
            Me.lb_create.Visible = True
            Me.txt_create.Text = fullname
            select_data()
        End If
    End Sub

    Sub select_data()
        Dim dta As DataTable
        Dim sql As String = ""
        sql += " select TOP 1 * from village"
        sql += " order by id desc"
        dta = class_conn.selectbase(sql)
        Me.txt_name.Text = dta.Rows(0).Item("name")
        Me.txt_address.Text = dta.Rows(0).Item("address")
        Me.txt_boss.Text = dta.Rows(0).Item("boss")
        Me.txt_secretary.Text = dta.Rows(0).Item("secretary")
        Me.txt_dividend.Text = dta.Rows(0).Item("dividend")
        Me.txt_int_loan.Text = dta.Rows(0).Item("interest_loan")
        Me.txt_int_fer.Text = dta.Rows(0).Item("interest_fer")
        Me.txt_int_oil.Text = dta.Rows(0).Item("interest_oil")
        Me.txt_limit.Text = dta.Rows(0).Item("loan_limit")
        Me.txt_ferlimit.Text = dta.Rows(0).Item("fer_limit")
        Me.txt_oillimit.Text = dta.Rows(0).Item("oil_limit")
        Me.txt_mulct.Text = dta.Rows(0).Item("mulct")
        Me.lb_vid.Text = dta.Rows(0).Item("id")
    End Sub

    Private Sub tst_save_ButtonClick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tst_save.ButtonClick
        If MsgBox("คุณต้องการทำการบันทึกใช่หรือไม่" & "", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
            check_insertdata()

        End If
    End Sub

    Sub check_editdata()
        If Me.txt_name.Text = "" Or Me.txt_address.Text = "" Or Me.txt_boss.Text = "" Or Me.txt_secretary.Text = "" _
           Or Me.txt_dividend.Text = "" Or Me.txt_int_loan.Text = "" Or Me.txt_int_fer.Text = "" Or Me.txt_int_oil.Text = "" _
           Or Me.txt_ferlimit.Text = "" Or Me.txt_oillimit.Text = "" Or Me.txt_limit.Text = "" Or Me.txt_mulct.Text = "" Then

            MessageBox.Show("กรุณากรอกข้อมูลให้สมบูรณ์", "Village Saving Management System", MessageBoxButtons.OK, MessageBoxIcon.Warning)

        Else
            edit_data()

        End If
    End Sub

    Private Sub tst_edit_ButtonClick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tst_edit.ButtonClick
        If MsgBox("คุณต้องการทำการแก้ไขใช่หรือไม่" & "", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
            check_editdata()

        End If
    End Sub

    Private Sub Village_Saving_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        username_log()

    End Sub


    Private Sub txt_dividend_TextChanged_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txt_dividend.TextChanged
        If Me.txt_dividend.Text = "" Then
            Exit Sub
        End If

        If Not IsNumeric(Me.txt_dividend.Text) Then
            MessageBox.Show("กรุณากรอกข้อมูลที่เป็นตัวเลขเท่านั้น", "Village Saving Management System", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Me.txt_dividend.Text = ""
        End If

    End Sub

    Private Sub txt_int_loan_TextChanged_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txt_int_loan.TextChanged
        If Me.txt_int_loan.Text = "" Then
            Exit Sub
        End If

        If Not IsNumeric(Me.txt_int_loan.Text) Then
            MessageBox.Show("กรุณากรอกข้อมูลที่เป็นตัวเลขเท่านั้น", "Village Saving Management System", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Me.txt_int_loan.Text = ""
        End If

    End Sub

    Private Sub txt_int_fer_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txt_int_fer.TextChanged
        If Me.txt_int_fer.Text = "" Then
            Exit Sub
        End If

        If Not IsNumeric(Me.txt_int_fer.Text) Then
            MessageBox.Show("กรุณากรอกข้อมูลที่เป็นตัวเลขเท่านั้น", "Village Saving Management System", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Me.txt_int_fer.Text = ""
        End If

    End Sub

    Private Sub txt_int_oil_TextChanged_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txt_int_oil.TextChanged
        If Me.txt_int_oil.Text = "" Then
            Exit Sub
        End If

        If Not IsNumeric(Me.txt_int_oil.Text) Then
            MessageBox.Show("กรุณากรอกข้อมูลที่เป็นตัวเลขเท่านั้น", "Village Saving Management System", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Me.txt_int_oil.Text = ""
        End If

    End Sub

    Private Sub txt_limit_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txt_limit.TextChanged
        If Me.txt_limit.Text = "" Then
            Exit Sub
        End If

        If Not IsNumeric(Me.txt_limit.Text) Then
            MessageBox.Show("กรุณากรอกข้อมูลที่เป็นตัวเลขเท่านั้น", "Village Saving Management System", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Me.txt_limit.Text = ""
        End If
    End Sub

    Private Sub txt_ferlimit_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txt_ferlimit.TextChanged
        If Me.txt_ferlimit.Text = "" Then
            Exit Sub
        End If

        If Not IsNumeric(Me.txt_ferlimit.Text) Then
            MessageBox.Show("กรุณากรอกข้อมูลที่เป็นตัวเลขเท่านั้น", "Village Saving Management System", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Me.txt_ferlimit.Text = ""
        End If
    End Sub

    Private Sub txt_oillimit_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txt_oillimit.TextChanged
        If Me.txt_oillimit.Text = "" Then
            Exit Sub
        End If

        If Not IsNumeric(Me.txt_oillimit.Text) Then
            MessageBox.Show("กรุณากรอกข้อมูลที่เป็นตัวเลขเท่านั้น", "Village Saving Management System", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Me.txt_oillimit.Text = ""
        End If
    End Sub

   
    Private Sub txt_mulct_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txt_mulct.TextChanged
        If Me.txt_mulct.Text = "" Then
            Exit Sub
        End If

        If Not IsNumeric(Me.txt_mulct.Text) Then
            MessageBox.Show("กรุณากรอกข้อมูลที่เป็นตัวเลขเท่านั้น", "Village Saving Management System", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Me.txt_mulct.Text = ""
        End If
    End Sub

    Private Sub tst_back_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tst_back.Click
        Me.Close()

    End Sub

    Private Sub tst_clear_ButtonClick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tst_clear.ButtonClick
        clear_text()

    End Sub
End Class
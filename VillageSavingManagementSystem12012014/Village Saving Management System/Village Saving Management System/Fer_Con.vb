Imports Microsoft.VisualBasic
Imports System.Data
Imports System.Data.SqlClient
Public Class Fer_Con
    Dim class_conn As New class_conn

    Sub cus_id()
        Dim sql As String = ""
        Dim dta As DataTable

        sql += "select contract_fer_no from fer_contracts order by contract_fer_no desc"

        dta = class_conn.selectbase(sql)
        If dta.Rows.Count = "0" Then
            Me.txt_conid.Text = "0001"
        Else
            Dim a As String = ""
            Dim b As Integer
            a = dta.Rows(0).Item("contract_fer_no").ToString
            b = CInt(a) + 1

            If b >= 0 And b < 10 Then
                Me.txt_conid.Text = "000" + CStr(b)

            ElseIf b >= 0 And b < 100 Then
                Me.txt_conid.Text = "00" + CStr(b)

            ElseIf b >= 0 And b < 1000 Then
                Me.txt_conid.Text = "0" + CStr(b)

            ElseIf b >= 0 And b < 10000 Then
                Me.txt_conid.Text = CStr(b)
            Else
                Me.txt_conid.Text = CStr(b)

            End If
        End If

    End Sub

    Sub insert_data()

        Dim sql As String = ""
        sql += " Insert into fer_contracts (contract_fer_no,cust_id,create_date,guarantee_no1,createby)"
        sql += " Values ('" + Me.txt_conid.Text + "','" + Me.txt_id.Text + "'"
        sql += " , getdate(),'" + Me.txt_gid1.Text + "','" + Me.txt_create.Text + "')"

        If class_conn.writebase(sql) = True Then
            MessageBox.Show("ทำการบันทึกสำเร็จ", "Village Saving Management System", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Dim a As New fer_buy
            a.lb_cus.Text = txt_id.Text
            a.lb_id.Text = txt_conid.Text
            a.ShowDialog()
            If a.DialogResult = Windows.Forms.DialogResult.OK Then
                clear_text()
                cus_id()
            End If
        Else
            MessageBox.Show("ทำการบันทึกล้มเหลว", "Village Saving Management System", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End If
    End Sub

    Sub update_statuscon()
        Dim sql As String = ""
        sql += " update customers set"
        sql += " fercon_status='กู้แล้ว'"
        sql += " where cust_id='" + Me.txt_id.Text + "'"
        class_conn.writebase(sql)
    End Sub

    Sub check_data()
        If Me.txt_id.Text = "" Or Me.txt_gid1.Text = "" Then
            MessageBox.Show("กรุณากรอกข้อมูลให้สมบูรณ์", "Village Saving Management System", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        Else
            insert_data()
            update_statuscon()

        End If
    End Sub

    Sub clear_text()
        Me.txt_conid.Text = ""
        Me.txt_id.Text = ""
        Me.txt_fullname.Text = ""
        Me.txt_address.Text = ""
        Me.txt_tel.Text = ""
        Me.txt_personalid.Text = ""
        Me.txt_age.Text = ""
        Me.txt_vocation.Text = ""
        Me.txt_month.Text = ""

        Me.txt_gid1.Text = ""
        Me.txt_gfullname1.Text = ""
        Me.txt_gaddess1.Text = ""
        Me.txt_gvocation1.Text = ""
        Me.txt_gmonth1.Text = ""

        
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
        If MsgBox("คุณต้องการบันทึกสัญญาใช่หรือไม่ ? " & "", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
            check_data()
        End If

    End Sub


    Private Sub btn_Search1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Search1.Click
        all_customer_con.ShowDialog()
        If all_customer_con.DialogResult = Windows.Forms.DialogResult.OK Then

            Me.txt_id.Text() = strid
            Me.txt_fullname.Text() = strname + " " + strsurname
            Me.txt_address.Text() = straddress
            Me.txt_tel.Text() = strtel
            Me.txt_personalid.Text() = strid_card
            Me.txt_age.Text() = strage
            Me.txt_vocation.Text() = strjob
            Me.txt_month.Text() = strsalary
        End If

    End Sub

    Private Sub btn_Search2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Search2.Click
        all_customer_con.ShowDialog()
        If all_customer_con.DialogResult = Windows.Forms.DialogResult.OK Then

            Me.txt_gid1.Text() = strid
            Me.txt_gfullname1.Text() = strname + " " + strsurname
            Me.txt_gaddess1.Text() = straddress
            Me.txt_gvocation1.Text() = strjob
            Me.txt_gmonth1.Text() = strsalary
        End If

    End Sub

    Private Sub tst_back_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tst_back.Click
        Close()

    End Sub

    Private Sub GroupBox3_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GroupBox3.Enter
        cus_id()


    End Sub

    Private Sub Fer_Con_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        username_log()
    End Sub

    Private Sub tst_clear_ButtonClick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tst_clear.ButtonClick
        clear_text()

    End Sub

End Class
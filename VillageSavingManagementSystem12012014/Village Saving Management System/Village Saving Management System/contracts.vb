Imports Microsoft.VisualBasic
Imports System.Data
Imports System.Data.SqlClient
Public Class contracts
    Dim class_conn As New class_conn

    Sub cus_id()
        Dim sql As String = ""
        Dim dta As DataTable

        sql += "select contract_no from contracts order by contract_no desc"

        dta = class_conn.selectbase(sql)
        If dta.Rows.Count = "0" Then
            Me.txt_conid.Text = "0001"
        Else
            Dim a As String = ""
            Dim b As Integer
            a = dta.Rows(0).Item("contract_no").ToString
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

        Dim date_from As String = dtp_time1.Value.Year.ToString & "-" & dtp_time1.Value.Month.ToString & "-" & dtp_time1.Value.Day.ToString

        Dim sql As String = ""
        sql += " Insert into contracts (contract_no,cust_id,loan_amount,sum_interest,sum,firstyear,time_create,createby,guarantee_no1,guarantee_no2)"
        sql += " Values ('" + Me.txt_conid.Text + "','" + Me.txt_id.Text + "'," + Me.txt_loan.Text + "," + Me.txt_interest.Text + "," + Me.txt_sum.Text + ""
        sql += " ,'" + date_from + "', getdate(),'" + Me.txt_create.Text + "','" + Me.txt_gid1.Text + "','" + Me.txt_gid2.Text + "')"

        If class_conn.writebase(sql) = True Then
            MessageBox.Show("ทำรายการสำเร็จ", "Village Saving Management System", MessageBoxButtons.OK, MessageBoxIcon.Information)
            update_statuscon()
            update_statusg1()
            update_statusg2()
            cus_id()
        Else
            MessageBox.Show("ทำรายการล้มเหลว", "Village Saving Management System", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End If
    End Sub

    Sub update_statuscon()
        Dim sql As String = ""
        sql += " update customers set"
        sql += " con_status='กู้แล้ว'"
        sql += " where cust_id='" + Me.txt_id.Text + "'"
        class_conn.writebase(sql)
    End Sub

    Sub update_statusg1()
        Dim sql As String = ""
        sql += " update customers set"
        sql += " guarantee_status='ผู้ค้ำ1'"
        sql += " where cust_id='" + Me.txt_gid1.Text + "'"
        class_conn.writebase(sql)
    End Sub

    Sub update_statusg2()
        Dim sql As String = ""
        sql += " update customers set"
        sql += " guarantee_status='ผู้ค้ำ2'"
        sql += " where cust_id='" + Me.txt_gid2.Text + "'"
        class_conn.writebase(sql)
    End Sub

    Sub interest()
        Dim sql As String = ""
        Dim dta As DataTable
        sql += " Select * From village order by id desc"

        dta = class_conn.selectbase(sql)
        Dim interest1 As Double
        Dim loanlimit As Double
        interest1 = dta.Rows(0).Item("interest_loan").ToString
        loanlimit = dta.Rows(0).Item("loan_limit").ToString

        If Me.txt_loan.Text > loanlimit Then
            MessageBox.Show("จำนวนเงินที่ต้องการกู้เกินวงเงินที่กำหนด", "Village Saving Management System", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Me.txt_loan.Text = ""
            Me.txt_interest.Text = ""
            Me.txt_sum.Text = ""

        Else
            Me.txt_interest.Text = (Me.txt_loan.Text * interest1) / 100
            Me.txt_sum.Text = CInt(Me.txt_interest.Text) + CInt(Me.txt_loan.Text)

        End If

    End Sub

    Sub check_data()
        If Me.txt_id.Text = "" Or Me.txt_gid1.Text = "" Or Me.txt_gid2.Text = "" Or Me.txt_loan.Text = "" Then
            MessageBox.Show("กรุณากรอกข้อมูลให้สมบูรณ์", "Village Saving Management System", MessageBoxButtons.OK, MessageBoxIcon.Warning)

        Else
            insert_data()
            clear_text()

        End If
    End Sub

    Sub clear_text()

        Me.txt_id.Text = ""
        Me.txt_fullname.Text = ""
        Me.txt_address.Text = ""
        Me.txt_tel.Text = ""
        Me.txt_personalid.Text = ""
        Me.txt_month.Text = ""
        Me.txt_age.Text = ""
        Me.txt_vocation.Text = ""
        Me.txt_loan.Text = ""
        Me.txt_interest.Text = ""
        Me.txt_sum.Text = ""

        Me.txt_gid1.Text = ""
        Me.txt_gfullname1.Text = ""
        Me.txt_gaddess1.Text = ""
        Me.txt_gvocation1.Text = ""
        Me.txt_gmonth1.Text = ""

        Me.txt_gid2.Text = ""
        Me.txt_gfullname2.Text = ""
        Me.txt_gaddress2.Text = ""
        Me.txt_gvocation2.Text = ""
        Me.txt_gmonth2.Text = ""

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
        If MsgBox("คุณต้องการบันทึกสัญญาใช่หรือไม่" & "", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
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
        all_customer_g1.ShowDialog()
        If all_customer_g1.DialogResult = Windows.Forms.DialogResult.OK Then

            Me.txt_gid1.Text() = strid
            Me.txt_gfullname1.Text() = strname + " " + strsurname
            Me.txt_gaddess1.Text() = straddress
            Me.txt_gvocation1.Text() = strjob
            Me.txt_gmonth1.Text() = strsalary
        End If
    End Sub

    Private Sub btn_Search3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Search3.Click
        all_customer_g2.ShowDialog()
        If all_customer_g2.DialogResult = Windows.Forms.DialogResult.OK Then

            Me.txt_gid2.Text() = strid
            Me.txt_gfullname2.Text() = strname + " " + strsurname
            Me.txt_gaddress2.Text() = straddress
            Me.txt_gvocation2.Text() = strjob
            Me.txt_gmonth2.Text() = strsalary
        End If
    End Sub

    Private Sub GroupBox1_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GroupBox1.Enter
        cus_id()
        dtp_time1.Value = Now.AddYears(+1)

    End Sub

    Private Sub tst_back_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tst_back.Click
        Close()

    End Sub

    Private Sub tst_clear_ButtonClick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tst_clear.ButtonClick
        clear_text()

    End Sub

    Private Sub txt_loan_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txt_loan.TextChanged

        If Me.txt_loan.Text = "" Then
            Me.txt_interest.Text = ""
            Me.txt_sum.Text = ""
            Exit Sub
        ElseIf Not IsNumeric(Me.txt_loan.Text) Then
            MessageBox.Show("กรุณากรอกข้อมูลที่เป็นตัวเลขเท่านั้น", "Village Saving Management System", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Me.txt_loan.Text = ""

        Else
            interest()

        End If
    End Sub

    Private Sub txt_month_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txt_month.TextChanged

    End Sub

    Private Sub contracts_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        username_log()

    End Sub

    Private Sub dtp_time1_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles dtp_time1.ValueChanged

    End Sub
End Class
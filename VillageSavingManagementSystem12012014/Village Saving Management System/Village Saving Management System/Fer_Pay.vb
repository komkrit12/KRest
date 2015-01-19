Imports Microsoft.VisualBasic
Imports System.Data
Imports System.Data.SqlClient

Public Class Fer_Pay
    Dim class_conn As New class_conn


    Sub insert_data()

        Dim sql As String = ""
        sql += " Insert into fer_payment (contract_fer_no,pay_value,balance,create_date)"
        sql += " Values ('" + Me.txt_conid.Text + "'," + Me.txt_pay.Text + "," + Me.txt_balance.Text + " "
        sql += " ,getdate() )"

        If class_conn.writebase(sql) = True Then
            MessageBox.Show("ทำรายการสำเร็จค่ะ", "Village Saving Management System", MessageBoxButtons.OK, MessageBoxIcon.Information)

        Else
            MessageBox.Show("ทำรายการล้มเหลวค่ะ", "Village Saving Management System", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End If

    End Sub

    Sub check_data()
        If Me.txt_sum.Text = 0 Then
            MessageBox.Show("สมาชิกได้ทำการชำระเงินเสร็จสิ้นแล้ว", "Village Saving Management System", MessageBoxButtons.OK, MessageBoxIcon.Warning)

        Else

            If Me.txt_conid.Text = "" Or Me.txt_pay.Text = "" Then
                MessageBox.Show("กรุณากรอกข้อมูลให้สมบูรณ์", "Village Saving Management System", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Else
                insert_data()
                Me.txt_pay.Text = ""
                

            End If
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

        Me.txt_sumprice.Text = ""
        Me.txt_interest.Text = ""
        Me.txt_sum.Text = ""
        Me.txt_pay.Text = ""
        Me.txt_balance.Text = ""

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
        If MsgBox("คุณต้องการบันทึกการชำระเงินใช่หรือไม่ ? " & "", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
            check_data()
        End If

    End Sub

  
    Sub check_balance()
        Dim sql_pay As String
        Dim dta_pay As DataTable
        Dim count As Integer
        Dim count2 As Integer
        Dim balance As Decimal
        Dim pay_value As Decimal
        Dim sum_price As Decimal
        Dim sum As Decimal
        Dim interest As Decimal
        Dim con_id As String
        Dim sql_con As String
        Dim dta_con As DataTable

        Dim date_from As Date
        Dim date_jay As Date
        date_from = Me.dtp_date1.Value.Day & "-" & Me.dtp_date1.Value.Month & "-" & Me.dtp_date1.Value.Year
        date_jay = Me.dtp_date2.Value.Day & "-" & Me.dtp_date2.Value.Month & "-" & Me.dtp_date2.Value.Year

        sql_con += " select top 1 * from vw_ferfer where cust_id ='" + Me.txt_id.Text + "' order by f_id desc"
        dta_con = class_conn.selectbase(sql_con)
        count = dta_con.Rows.Count
        If (count <> 0) Then
            sum = dta_con.Rows(0).Item("sum").ToString
            interest = dta_con.Rows(0).Item("sum_interest").ToString
            sum_price = dta_con.Rows(0).Item("sum_price").ToString
            con_id = dta_con.Rows(0).Item("contract_fer_no").ToString
        Else
            sum = 0
            interest = 0
            sum_price = 0
        End If
        sql_pay += " select top 1 * from fer_payment where contract_fer_no ='" + con_id + "' order by pay_id desc"
        dta_pay = class_conn.selectbase(sql_pay)
        count2 = dta_pay.Rows.Count
        If (count2 <> 0) Then
            balance = dta_pay.Rows(0).Item("balance").ToString
            pay_value = dta_pay.Rows(0).Item("pay_value").ToString
        Else
            balance = 0
            pay_value = 0
        End If

        Dim sql_vi As String = ""
        Dim dta_vi As DataTable
        sql_vi += " Select * From village order by id desc"

        dta_vi = class_conn.selectbase(sql_vi)
        Dim mulct As Double
        mulct = dta_vi.Rows(0).Item("mulct").ToString

        Dim dlong As Long
        dlong = DateDiff(DateInterval.Day, date_from, date_jay)

        If balance = 0 And pay_value <> 0 Then
            Me.txt_sum.Text = 0
            Me.txt_sumprice.Text = 0
            Me.txt_interest.Text = 0
            Me.txt_pay.Text = 0
            Me.txt_balance.Text = 0
            Me.txt_pay.Enabled = False
            If dlong > 0 Then
                Me.txt_mulct.Text = (CInt(Me.txt_sumprice.Text) * mulct) / 100
                Me.txt_sum.Text = 0 + CInt(Me.txt_mulct.Text)
                Me.txt_balance.Text = 0 + CInt(Me.txt_mulct.Text)
            Else
                Me.txt_mulct.Text = 0
            End If
        ElseIf balance = 0 And pay_value = 0 Then
            Me.txt_sum.Text = sum
            Me.txt_sumprice.Text = sum_price
            Me.txt_balance.Text = sum
            Me.txt_interest.Text = interest
            Me.txt_pay.Text = ""
            Me.txt_pay.Enabled = True
            If dlong > 0 Then
                Me.txt_mulct.Text = (CInt(Me.txt_sumprice.Text) * mulct) / 100
                Me.txt_sum.Text = sum + CInt(Me.txt_mulct.Text)
                Me.txt_balance.Text = sum + CInt(Me.txt_mulct.Text)
            Else
                Me.txt_mulct.Text = 0
            End If
        Else
            Me.txt_sum.Text = balance
            Me.txt_sumprice.Text = sum_price
            Me.txt_balance.Text = balance
            Me.txt_interest.Text = interest
            Me.txt_pay.Text = ""
            Me.txt_pay.Enabled = True
            If dlong > 0 Then
                Me.txt_mulct.Text = (CInt(Me.txt_sumprice.Text) * mulct) / 100
                Me.txt_sum.Text = balance + CInt(Me.txt_mulct.Text)
                Me.txt_balance.Text = balance + CInt(Me.txt_mulct.Text)
            Else
                Me.txt_mulct.Text = 0
            End If
        End If

    End Sub


    Private Sub tst_back_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tst_back.Click
        Close()

    End Sub

    Private Sub txt_pay_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txt_pay.TextChanged
        

        If Me.txt_sum.Text = "" Or Me.txt_pay.Text = "" Then
            Exit Sub
        ElseIf Not IsNumeric(Me.txt_pay.Text) Then
            MessageBox.Show("กรุณากรอกข้อมูลที่เป็นตัวเลขเท่านั้น", "Village Saving Management System", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Me.txt_pay.Text = ""

        Else

            Me.txt_balance.Text = Me.txt_sum.Text - Me.txt_pay.Text

        End If

    End Sub

    Private Sub Fer_Pay_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        username_log()

    End Sub

    Private Sub tst_clear_ButtonClick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tst_clear.ButtonClick
        clear_text()

    End Sub

    Private Sub Lab_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Lab.Click

    End Sub

    Private Sub btn_Search1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Search1.Click
        all_customer_ferpay.ShowDialog()
        If all_customer_ferpay.DialogResult = Windows.Forms.DialogResult.OK Then

            Me.txt_conid.Text() = strconid
            Me.txt_id.Text() = strid
            Me.txt_fullname.Text() = strname + " " + strsurname
            Me.txt_address.Text() = straddress
            Me.txt_tel.Text() = strtel
            Me.txt_personalid.Text() = strid_card
            Me.txt_age.Text() = strage
            Me.txt_vocation.Text() = strjob
            Me.txt_month.Text() = strsalary
            Me.dtp_date1.Value() = strtime1
            check_balance()

        End If
    End Sub

    Private Sub dtp_date1_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles dtp_date1.ValueChanged

    End Sub

    Private Sub tst_print_ButtonClick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tst_print.ButtonClick
        Dim a As New receipt_ferpay
        a.con_id = Me.txt_conid.Text
        a.ShowDialog()
    End Sub
End Class
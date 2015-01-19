Public Class Home
    Dim class_conn As New class_conn
    Sub out()
        Dim sql2 As String = ""
        sql2 += " Update login Set"
        sql2 += " out_date = getdate()"
        sql2 += " Where login_id = " + Me.lb_loginid.Text + ""
        class_conn.writebase(sql2)
        Login.Show()
        Me.Hide()
    End Sub

    Private Sub st_Close_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles st_Close.Click
        If MsgBox("ต้องการออกจากระบบใช่หรือไม่" & "", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
            out()
        End If

    End Sub

    Private Sub Home_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim sql As String = ""
        Dim dta As DataTable
        sql += " Select login_id from login where register_id =" + Me.lb_reid.Text + " order by use_date desc "
        dta = class_conn.selectbase(sql)
        If dta.Rows.Count = 0 Then
            MessageBox.Show("ไม่พบผู้ใช้งาน")
        ElseIf dta.Rows.Count <> 0 Then
            Dim login As Integer = dta.Rows(0).Item("login_id")
            Me.lb_loginid.Text = login
        End If
    End Sub

    Private Sub st_Village_Saving_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles st_Village_Saving.Click

        Dim frm As New Village_Saving
        frm.lb_reid.Text = Me.lb_reid.Text
        frm.ShowDialog()
    End Sub


    Private Sub st_Register_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles st_Register.Click

        Dim frm As New Register
        frm.lb_reid.Text = Me.lb_reid.Text
        frm.ShowDialog()

    End Sub

    Private Sub st_check_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles st_check.Click
        Check.ShowDialog()

    End Sub

    Private Sub st_search_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles st_search.Click

        Search.ShowDialog()
    End Sub

    Private Sub st_Add_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles st_Add.Click

        Dim frm As New Add
        frm.lb_reid.Text = Me.lb_reid.Text
        frm.ShowDialog()

    End Sub

    Private Sub st_Edit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles st_Edit.Click

        Dim frm As New Edit
        frm.lb_reid.Text = Me.lb_reid.Text
        frm.ShowDialog()

    End Sub

    Private Sub st_Deposit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles st_Deposit.Click

        Dim frm As New Deposit
        frm.lb_reid.Text = Me.lb_reid.Text
        frm.ShowDialog()

    End Sub

    Private Sub st_Withdrawal_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles st_Withdrawal.Click

        Dim frm As New Withdrawal
        frm.lb_reid.Text = Me.lb_reid.Text
        frm.ShowDialog()
    End Sub

    Private Sub st_Contract_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles st_Contract.Click

        Dim frm As New contracts
        frm.lb_reid.Text = Me.lb_reid.Text
        frm.ShowDialog()
    End Sub

    Private Sub st_Payment_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles st_Payment.Click

        Dim frm As New Payment
        frm.lb_reid.Text = Me.lb_reid.Text
        frm.ShowDialog()
    End Sub

    Private Sub st_dividend_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles st_dividend.Click

        Dim frm As New Dividend
        frm.lb_reid.Text = Me.lb_reid.Text
        frm.ShowDialog()
    End Sub

    Private Sub st_Fer_Stock_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles st_Fer_Stock.Click

        Dim frm As New Fer_Stock
        frm.lb_reid.Text = Me.lb_reid.Text
        frm.ShowDialog()
    End Sub

    Private Sub st_Fer_Con_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles st_Fer_Con.Click

        Dim frm As New Fer_Con
        frm.lb_reid.Text = Me.lb_reid.Text
        frm.ShowDialog()
    End Sub

    Private Sub st_Fer_Pay_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles st_Fer_Pay.Click

        Dim frm As New Fer_Pay
        frm.lb_reid.Text = Me.lb_reid.Text
        frm.ShowDialog()
    End Sub

    Private Sub st_Oil_Stock_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles st_Oil_Stock.Click

        Dim frm As New Oil_Stock
        frm.lb_reid.Text = Me.lb_reid.Text
        frm.ShowDialog()
    End Sub

    Private Sub st_Oil_Con_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles st_Oil_Con.Click

        Dim frm As New Oil_Con
        frm.lb_reid.Text = Me.lb_reid.Text
        frm.ShowDialog()
    End Sub

    Private Sub st_Oil_Pay_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles st_Oil_Pay.Click

        Dim frm As New Oil_Pay
        frm.lb_reid.Text = Me.lb_reid.Text
        frm.ShowDialog()
    End Sub

    Private Sub st_Re_deposit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles st_Re_deposit.Click
        Re_deposit.ShowDialog()

    End Sub

    Private Sub st_Re_cust_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles st_Re_cust.Click
        Re_customers.Show()

    End Sub

    Private Sub st_Re_loan_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles st_Re_loan.Click
        Re_con.ShowDialog()

    End Sub

    Private Sub st_Re_payment_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles st_Re_payment.Click
        Re_payment.ShowDialog()

    End Sub

    Private Sub st_Re_dividend_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles st_Re_dividend.Click
        Re_dividend.ShowDialog()

    End Sub

    Private Sub st_Re_fercon_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles st_Re_fercon.Click
        Re_fercon.ShowDialog()

    End Sub

    Private Sub st_Re_ferpay_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles st_Re_ferpay.Click
        Re_ferpay.ShowDialog()

    End Sub

    Private Sub st_Re_oilcon_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles st_Re_oilcon.Click
        Re_oilcon.ShowDialog()

    End Sub

    Private Sub st_Re_oilpay_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles st_Re_oilpay.Click
        Re_oilpay.ShowDialog()

    End Sub

    Private Sub st_Help_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles st_Help.Click

    End Sub

    Private Sub st_cancle_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim frm As New Edit
        frm.lb_reid.Text = Me.lb_reid.Text
        frm.ShowDialog()
    End Sub

    
    Private Sub st_Fer_Add_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles st_Fer_Add.Click
        Dim frm As New Fer_Add
        frm.lb_reid.Text = Me.lb_reid.Text
        frm.ShowDialog()
    End Sub

    Private Sub st_Oil_Add_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles st_Oil_Add.Click
        Dim frm As New Oil_Add
        frm.lb_reid.Text = Me.lb_reid.Text
        frm.ShowDialog()
    End Sub

    Private Sub st_cc_customers_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles st_cc_customers.Click
        CC_customers.ShowDialog()

    End Sub

    Private Sub st_cc_deposit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles st_cc_deposit.Click
        CC_deposit.ShowDialog()

    End Sub

    Private Sub st_cc_withdrawal_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles st_cc_withdrawal.Click
        CC_withdrawal.ShowDialog()

    End Sub

    Private Sub st_cc_contracts_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles st_cc_contracts.Click
        CC_contracts.ShowDialog()

    End Sub

    Private Sub st_cc_payment_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles st_cc_payment.Click
        CC_payment.ShowDialog()

    End Sub

    Private Sub st_cc_ferstock_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles st_cc_ferstock.Click
        CC_ferstock.ShowDialog()

    End Sub

    Private Sub st_cc_fercon_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles st_cc_fercon.Click
        CC_fercon.ShowDialog()

    End Sub

    Private Sub st_cc_ferpay_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles st_cc_ferpay.Click
        CC_ferpay.ShowDialog()

    End Sub

    Private Sub st_cc_oilstock_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles st_cc_oilstock.Click
        CC_oilstock.ShowDialog()

    End Sub

    Private Sub st_cc_oilcon_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles st_cc_oilcon.Click
        CC_oilcon.ShowDialog()

    End Sub

    Private Sub st_cc_oilpay_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles st_cc_oilpay.Click
        CC_oilpay.ShowDialog()

    End Sub

    Private Sub tst_withdrawal_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tst_withdrawal.Click
        Re_withdrawal.ShowDialog()

    End Sub

    Private Sub st_home_ButtonClick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles st_home.ButtonClick

    End Sub
End Class
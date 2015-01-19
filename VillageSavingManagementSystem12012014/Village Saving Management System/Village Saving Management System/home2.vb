Public Class home2
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
        If MsgBox("ต้องการออกจากระบบใช่หรือไม่ ?" & "แจ้งเตือน", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
            out()

        End If
    End Sub

    Private Sub home1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
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

    Private Sub st_ConFer_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles st_Fer_Con.Click
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

    Private Sub st_Re_deposit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Re_deposit.ShowDialog()

    End Sub

    Private Sub st_Re_withdrawal_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Re_customers.ShowDialog()

    End Sub

    Private Sub st_Re_loan_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Re_con.ShowDialog()

    End Sub

    Private Sub st_Re_payment_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Re_payment.ShowDialog()

    End Sub

    Private Sub st_Re_fercon_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Re_fercon.ShowDialog()

    End Sub

    Private Sub st_Re_ferpay_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Re_ferpay.ShowDialog()

    End Sub

    Private Sub st_Re_oilcon_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Re_oilcon.ShowDialog()

    End Sub

    Private Sub st_Re_oilpay_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Re_oilpay.ShowDialog()

    End Sub

    Private Sub st_Re_dividend_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Re_dividend.ShowDialog()

    End Sub

    Private Sub st_Help_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles st_Help.Click

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

    Private Sub st_nc_customers_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles st_nc_customers.Click
        NC_customers.ShowDialog()

    End Sub

    Private Sub st_nc_deposit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles st_nc_deposit.Click
        NC_deposit.ShowDialog()

    End Sub

    Private Sub st_nc_withdrawal_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles st_nc_withdrawal.Click
        NC_withdrawal.ShowDialog()

    End Sub

    Private Sub st_nc_contracts_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles st_nc_contracts.Click
        NC_contracts.ShowDialog()

    End Sub

    Private Sub st_nc_payment_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles st_nc_payment.Click
        NC_payment.ShowDialog()

    End Sub

    Private Sub st_nc_ferstock_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles st_nc_ferstock.Click
        NC_ferstock.ShowDialog()

    End Sub

    Private Sub st_nc_fercon_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles st_nc_fercon.Click
        NC_fercon.ShowDialog()

    End Sub

    Private Sub st_nc_ferpay_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles st_nc_ferpay.Click
        NC_ferpay.ShowDialog()

    End Sub

    Private Sub st_nc_oilstock_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles st_nc_oilstock.Click
        NC_oilstock.ShowDialog()

    End Sub

    Private Sub st_nc_oilcon_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles st_nc_oilcon.Click
        NC_oilcon.ShowDialog()

    End Sub

    Private Sub st_nc_oilpay_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles st_nc_oilpay.Click
        NC_oilpay.ShowDialog()

    End Sub
End Class
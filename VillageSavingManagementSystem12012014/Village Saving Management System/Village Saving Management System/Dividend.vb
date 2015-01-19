Imports Microsoft.VisualBasic
Imports System.Data
Imports System.Data.SqlClient
Public Class Dividend
    Dim class_conn As New class_conn

    Sub load_data()
        Dim sql As String = ""
        Dim dta As DataTable

        If Me.cbo_search.Text = "ชื่อ" Then
            sql += " select * from customers where cust_fname like '%" + Me.txt_search.Text + "%' and status is null"
        ElseIf Me.cbo_search.Text = "รหัสสมาชิก" Then
            sql += " select * from customers where cust_id like '%" + Me.txt_search.Text + "%' and status is null"
        ElseIf Me.cbo_search.Text = "เลขบัตรประชาชน" Then
            sql += " select * from customers where personal_id like '%" + Me.txt_search.Text + "%' and status is null"

        Else

            MessageBox.Show("กรุณาเลือกคำค้นหาก่อนค่ะ", "Village Saving Management System", MessageBoxButtons.OK, MessageBoxIcon.Warning)

        End If

        dta = class_conn.selectbase(sql)
        Dim count As Integer = 0
        count = dta.Rows.Count

        If Me.txt_search.Text = "" Then
            MessageBox.Show("กรุณาใส่คำที่ต้องการค้นหาก่อนค่ะ", "Village Saving Management System", MessageBoxButtons.OK, MessageBoxIcon.Warning)

        ElseIf count = 0 Then
            MessageBox.Show("ไม่พบข้อมูล", "Village Saving Management System", MessageBoxButtons.OK, MessageBoxIcon.Warning)

        Else
            Me.DataGridView1.DataSource = dta
        End If

    End Sub

    Sub insert_data()
        Dim sql As String = ""
        sql += " Insert into dividend (cust_id,dividend_value,createby,create_date)"
        sql += " Values ('" + Me.txt_id.Text + "'," + Me.txt_dividend.Text + ",'" + Me.txt_create.Text + "',getdate() )"

        If class_conn.writebase(sql) = True Then

            MessageBox.Show("ทำการบันทึกสำเร็จ", "Village Saving Management System", MessageBoxButtons.OK, MessageBoxIcon.Information)

        Else
            MessageBox.Show("ทำการบันทึกล้มเหลว", "Village Saving Management System", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End If

    End Sub

    Sub interest()
        Dim sql As String = ""
        Dim dta As DataTable
        sql += " Select * From village order by id desc"

        dta = class_conn.selectbase(sql)
        Dim interest1 As Double

        interest1 = dta.Rows(0).Item("dividend").ToString
        Me.txt_interest.Text = interest1
        Me.txt_dividend.Text = (Me.txt_balance.Text * interest1) / 100

    End Sub

    Sub clear_text()
        Me.txt_id.Text = ""
        Me.txt_fname.Text = ""
        Me.txt_lname.Text = ""
        Me.txt_address.Text = ""
        Me.txt_tel.Text = ""
        Me.txt_vocation.Text = ""
        Me.txt_personalid.Text = ""
        Me.txt_month.Text = ""
        Me.txt_balance.Text = ""
        Me.txt_dividend.Text = ""

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

    Sub dv_interest()
        Dim sql_vi As String = ""
        Dim dta_vi As DataTable
        sql_vi += " Select * From village order by id desc"

        dta_vi = class_conn.selectbase(sql_vi)
        Me.txt_interest.Text = dta_vi.Rows(0).Item("dividend").ToString
    End Sub

    Sub cal_cost()
        Dim deposit As Decimal
        Dim Withdrawal As Decimal
        Dim cost As Decimal
        Dim count_de As Integer
        Dim count_w As Integer
        Dim sql_de As String = ""
        Dim dta_de As DataTable
        Dim sql_w As String = ""
        Dim dta_w As DataTable
        sql_de += " select * from trans_vw1 where cust_id ='" + Me.txt_id.Text + "'"
        dta_de = class_conn.selectbase(sql_de)
        count_de = dta_de.Rows.Count
        If (count_de <> 0) Then
            deposit = dta_de.Rows(0).Item("cost_de").ToString
        Else
            deposit = 0
        End If

        sql_w += " select * from trans_vw2 where cust_id ='" + Me.txt_id.Text + "'"
        dta_w = class_conn.selectbase(sql_w)
        count_w = dta_w.Rows.Count
        If (count_w <> 0) Then
            Withdrawal = dta_w.Rows(0).Item("cost_tran").ToString
        Else
            Withdrawal = 0
        End If

        Dim sql_d As String = ""
        Dim dta_d As DataTable
        Dim count_d As Integer
        sql_d += " select * from dividend where cust_id ='" + Me.txt_id.Text + "'"
        dta_d = class_conn.selectbase(sql_d)
        count_d = dta_d.Rows.Count
        If (count_d <> 0) Then
            Me.txt_dividend.Text = dta_d.Rows(0).Item("dividend_value").ToString
        Else
            Me.txt_dividend.Text = ""
        End If

        cost = deposit - Withdrawal
        Me.txt_balance.Text = cost

    End Sub

    Private Sub tst_save_ButtonClick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tst_save.ButtonClick
        If MsgBox("คุณต้องการทำการบันทึกใช่หรือไม่" & "", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
            insert_data()
        End If


    End Sub

    Private Sub tst_print_ButtonClick(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub tst_cal_ButtonClick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tst_cal.ButtonClick
        If MsgBox("คุณต้องการทำการคำนวณใช่หรือไม่" & "", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
            Me.txt_dividend.Text = (CInt(Me.txt_balance.Text) * CInt(Me.txt_interest.Text)) / 100
        End If

    End Sub

    Private Sub tst_back_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tst_back.Click
        Close()

    End Sub

    Private Sub btn_Search_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Search.Click
        load_data()

    End Sub

    Private Sub DataGridView1_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick
        Dim UserSelectRow As Integer = 0
        UserSelectRow = CInt(Me.DataGridView1.CurrentRow.Index.ToString)
        Me.txt_id.Text = DataGridView1.Rows.Item(UserSelectRow).Cells("cust_id").Value.ToString
        Me.txt_fname.Text = DataGridView1.Rows.Item(UserSelectRow).Cells("cust_fname").Value.ToString
        Me.txt_lname.Text = DataGridView1.Rows.Item(UserSelectRow).Cells("cust_lname").Value.ToString
        Me.txt_address.Text = DataGridView1.Rows.Item(UserSelectRow).Cells("cust_address").Value.ToString
        Me.txt_personalid.Text = DataGridView1.Rows.Item(UserSelectRow).Cells("personal_id").Value.ToString
        Me.txt_tel.Text = DataGridView1.Rows.Item(UserSelectRow).Cells("tel").Value.ToString
        Me.txt_vocation.Text = DataGridView1.Rows.Item(UserSelectRow).Cells("occupation").Value.ToString
        Me.txt_month.Text = DataGridView1.Rows.Item(UserSelectRow).Cells("earnings_month").Value.ToString
        Me.txt_balance.Text = DataGridView1.Rows.Item(UserSelectRow).Cells("balance").Value.ToString
        Me.txt_dividend.Text = ""
        cal_cost()
    End Sub

    Private Sub tst_clear_ButtonClick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tst_clear.ButtonClick
        clear_text()

    End Sub

    
    Private Sub Dividend_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        username_log()
        dv_interest()


    End Sub
End Class
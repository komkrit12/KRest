Imports Microsoft.VisualBasic
Imports System.Data
Imports System.Data.SqlClient

Public Class Oil_Stock
    Dim class_conn As New class_conn

    Sub data_combobox()
        Dim sql As String
        Dim dta As DataTable
        sql = " select * from oil where status_oil is null"
        dta = class_conn.selectbase(sql)
        Dim dr As DataRow = dta.NewRow()
        dr("oil_id") = 0
        dr("oil_type") = "--เลือก--"
        dta.Rows.InsertAt(dr, 0)
        Me.cbo_type.DisplayMember = "oil_type"
        Me.cbo_type.ValueMember = "oil_id"
        Me.cbo_type.DataSource = dta
    End Sub

    Sub insert_data()
        Dim balance As Integer
        Dim receive As Integer
        Dim sum_balance As Integer
        balance = Me.txt_balance.Text
        receive = Me.txt_receive.Text
        sum_balance = receive + balance
        Dim sql As String = ""
        sql += " Insert into oil_stock (oil_id,receive,price,sum_price,balance,number,receive_date,createby)"
        sql += " Values ('" + Me.cbo_type.SelectedValue.ToString + "'," + Me.txt_receive.Text + "," + Me.txt_price.Text + " "
        sql += " ," + Me.txt_sumprice.Text + "," + CStr(sum_balance) + ",'" + Me.txt_number.Text + "',getdate(),'" + Me.txt_create.Text + "')"

        If class_conn.writebase(sql) = True Then
            MessageBox.Show("ทำการบันทึกสำเร็จ", "Village Saving Management System", MessageBoxButtons.OK, MessageBoxIcon.Information)
            check_oil()
            select_data()
        Else
            MessageBox.Show("ทำการบันทึกล้มเหลว", "Village Saving Management System", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End If
    End Sub

    Sub check_data()
        If Me.txt_receive.Text = "" Or Me.txt_number.Text = "" Then
            MessageBox.Show("กรุณากรอกข้อมูลให้สมบูรณ์", "Village Saving Management System", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        ElseIf Me.txt_price.Text = "0" Then
            MessageBox.Show("กรุณาเลือกชนิดของน้ำมันก่อนการบันทึก", "Village Saving Management System", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        Else
            insert_data()

        End If
    End Sub

    Sub clear_text()
        Me.cbo_type.Text = "--เลือก--"
        Me.txt_price.Text = ""
        Me.txt_balance.Text = ""
        Me.txt_sumprice.Text = ""
        Me.txt_receive.Text = ""
        Me.txt_number.Text = ""


    End Sub

    Sub select_data()
        Dim sql As String = ""
        Dim dta As DataTable
        sql += " select Top 1 oil_type,receive,price,sum_price,number,receive_date,createby,balance from vw_oilstock ORDER BY receive_date DESC "
        dta = class_conn.selectbase(sql)
        Me.DataGridView1.DataSource = dta
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

    Sub check_oil()
        Dim sql_con As String = ""
        Dim dta_con As DataTable

        sql_con += " SELECT SUM(buy_amount) as sum_amount from vw_oil2 where oil_id = " + Me.cbo_type.SelectedValue.ToString
        dta_con = class_conn.selectbase(sql_con)

        Dim amount As Integer
        Dim status As String
        status = dta_con.Rows(0).Item("sum_amount").ToString
        If status <> "NULL" And status <> "" Then
            amount = dta_con.Rows(0).Item("sum_amount").ToString
        Else
            amount = "0"
        End If

        Dim sql_re As String = ""
        Dim dta_re As DataTable
        sql_re += " select sum(receive) as sum_amount from vw_oil1 where oil_id = " + Me.cbo_type.SelectedValue.ToString
        dta_re = class_conn.selectbase(sql_re)
        Dim receive As Integer
        Dim status2 As String
        status2 = dta_re.Rows(0).Item("sum_amount").ToString
        If status2 <> "NULL" And status2 <> "" Then
            receive = dta_re.Rows(0).Item("sum_amount").ToString
        Else
            receive = "0"
        End If

        Dim total As Integer = 0
        total = receive - amount
        Me.txt_balance.Text = total

    End Sub

    Private Sub txt_receive_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txt_receive.TextChanged

        If Me.txt_receive.Text = "" Then
            Me.txt_sumprice.Text = ""
            Exit Sub
            check_oil()

        ElseIf Not IsNumeric(Me.txt_receive.Text) Then
            MessageBox.Show("กรุณากรอกข้อมูลที่เป็นตัวเลขเท่านั้น", "Village Saving Management System", MessageBoxButtons.OK, MessageBoxIcon.Warning)

            Me.txt_receive.Text = ""

        Else
            Me.txt_sumprice.Text = Me.txt_price.Text * Me.txt_receive.Text

        End If

    End Sub

    Private Sub cbo_type_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbo_type.SelectedIndexChanged
        Dim sql As String = ""
        Dim dta As DataTable

        If cbo_type.Text <> "" And cbo_type.Text <> "System.Data.DataRowView" And cbo_type.Text <> "--เลือก--" Then
            sql += " select * from oil WHERE oil_type = '" + Me.cbo_type.Text + "' "

            dta = class_conn.selectbase(sql)

            Me.txt_price.Text = dta.Rows(0).Item("price").ToString
            check_oil()
        ElseIf cbo_type.Text = "--เลือก--" Then
            Me.txt_price.Text = "0"
        End If
    End Sub

    Private Sub Oil_Stock_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        data_combobox()
        username_log()

    End Sub

   

    Private Sub tst_save_ButtonClick_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tst_save.ButtonClick
        If MsgBox("คุณต้องการทำการบันทึกใช่หรือไม่" & "", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
            check_data()
        End If

    End Sub

    Private Sub tst_edit_ButtonClick(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub tst_clear_ButtonClick_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tst_clear.ButtonClick
        clear_text()

    End Sub

    Private Sub tst_back_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tst_back.Click
        Close()

    End Sub

End Class


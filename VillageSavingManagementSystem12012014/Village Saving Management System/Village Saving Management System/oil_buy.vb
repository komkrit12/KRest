Imports Microsoft.VisualBasic
Imports System.Data
Imports System.Data.SqlClient
Public Class oil_buy
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

    Private Sub cbo_type_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbo_type.SelectedIndexChanged
        Dim sql As String = ""
        Dim dta As DataTable

        If cbo_type.Text <> "" And cbo_type.Text <> "System.Data.DataRowView" And cbo_type.Text <> "--เลือก--" Then
            sql += " select * from oil WHERE oil_type = '" + Me.cbo_type.Text + "' "

            dta = class_conn.selectbase(sql)

            Me.txt_price.Text = dta.Rows(0).Item("price").ToString
        ElseIf cbo_type.Text = "--เลือก--" Then
            Me.txt_price.Text = "0"
        End If
    End Sub

    Sub interest()
        Dim sql As String = ""
        Dim dta As DataTable
        sql += " Select * From village order by id desc"
        dta = class_conn.selectbase(sql)
        Dim interest1 As Double

        interest1 = dta.Rows(0).Item("interest_oil").ToString
        Me.txt_interest.Text = interest1 * CInt(Me.txt_amount.Text)
        Me.txt_sumprice.Text = CInt(Me.txt_interest.Text) + (CInt(Me.txt_price.Text) * CInt(Me.txt_amount.Text))

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


        Dim sql As String = ""
        Dim dta As DataTable
        sql += " select * from oil where oil_id = " + Me.cbo_type.SelectedValue.ToString
        dta = class_conn.selectbase(sql)
        Dim point As Integer
        point = dta.Rows(0).Item("point").ToString

        If receive > (amount + CInt(Me.txt_amount.Text)) Then
            Dim total As Integer
            total = receive - (amount + CInt(Me.txt_amount.Text))

            If total > point Then
                con_num()

            ElseIf total <= point Then
                MessageBox.Show("จำนวนคงคลังมีน้อยกว่าที่ต้องการกู้", "ไม่สามารถกู้ได้", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            End If
        Else
            MessageBox.Show("จำนวนคงคลังมีน้อยกว่าที่ต้องการกู้", "ไม่สามารถกู้ได้", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End If

    End Sub

    Sub con_num()
        Dim sql_con As String = ""
        Dim dta_con As DataTable
        sql_con += " SELECT SUM(buy_amount) as sum_amount from oil_con where contract_oil_no = '" + Me.lb_id.Text + "'"
        dta_con = class_conn.selectbase(sql_con)

        Dim amount As Integer
        Dim status As String
        status = dta_con.Rows(0).Item("sum_amount").ToString
        If status <> "NULL" And status <> "" Then
            amount = dta_con.Rows(0).Item("sum_amount").ToString
        Else
            amount = "0"
        End If

        Dim sql_vi As String = ""
        Dim dta_vi As DataTable
        sql_vi += " Select * From village order by id desc"

        dta_vi = class_conn.selectbase(sql_vi)
        Dim interest1 As Double
        Dim loanlimit As Double
        interest1 = dta_vi.Rows(0).Item("interest_oil").ToString
        loanlimit = dta_vi.Rows(0).Item("oil_limit").ToString

        If amount > loanlimit Then
            MessageBox.Show("จำนวนน้ำมันที่ต้องการกู้เกินจำนวนที่กำหนด", "Village Saving Management System", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        ElseIf txt_amount.Text > loanlimit Then
            MessageBox.Show("จำนวนน้ำมันที่ต้องการกู้เกินจำนวนที่กำหนด", "Village Saving Management System", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        ElseIf CInt(Me.txt_amount.Text) + amount > loanlimit Then
            MessageBox.Show("จำนวนน้ำมันที่ต้องการกู้เกินจำนวนที่กำหนด", "Village Saving Management System", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        Else
            If amount = "0" Then
                Me.txt_interest.Text = interest1 * CInt(Me.txt_amount.Text)
                Me.txt_sumprice.Text = CInt(Me.txt_interest.Text) + (CInt(Me.txt_price.Text) * CInt(Me.txt_amount.Text))
                Me.txt_pay.Text = Me.txt_sumprice.Text
            Else
                Dim new_amount As Integer = amount + Me.txt_amount.Text
                Me.txt_interest.Text = interest1 * new_amount
                Me.txt_sumprice.Text = CInt(Me.txt_interest.Text) + (CInt(Me.txt_price.Text) * new_amount)
                Me.txt_pay.Text = Me.txt_sumprice.Text
            End If

            insert_data()

        End If
    End Sub

    Sub return_data()
        Dim sql_con As String = ""
        Dim dta_con As DataTable
        sql_con += " SELECT SUM(buy_amount) as sum_amount from oil_con where contract_oil_no = '" + Me.lb_id.Text + "'"
        dta_con = class_conn.selectbase(sql_con)

        Dim amount As Integer
        Dim status As String
        status = dta_con.Rows(0).Item("sum_amount").ToString
        If status <> "NULL" And status <> "" Then
            amount = dta_con.Rows(0).Item("sum_amount").ToString
        Else
            amount = "0"
        End If

        Dim sql_vi As String = ""
        Dim dta_vi As DataTable
        sql_vi += " Select * From village order by id desc"

        dta_vi = class_conn.selectbase(sql_vi)
        Dim interest1 As Double
        Dim loanlimit As Double
        interest1 = dta_vi.Rows(0).Item("interest_oil").ToString
        loanlimit = dta_vi.Rows(0).Item("oil_limit").ToString

        If amount = "0" Then
            Me.txt_interest.Text = interest1 * CInt(Me.txt_amount.Text)
            Me.txt_sumprice.Text = CInt(Me.txt_interest.Text) + (CInt(Me.txt_price.Text) * CInt(Me.txt_amount.Text))
            Me.txt_pay.Text = Me.txt_sumprice.Text
        Else
            Dim new_amount As Integer = amount + Me.txt_amount.Text
            Me.txt_interest.Text = interest1 * new_amount
            Me.txt_sumprice.Text = CInt(Me.txt_interest.Text) + (CInt(Me.txt_price.Text) * new_amount)
            Me.txt_pay.Text = Me.txt_sumprice.Text
        End If
    End Sub

    Sub clear_text()
        Me.cbo_type.Text = "--เลือก--"
        Me.txt_amount.Text = ""
        Me.txt_price.Text = "0"
        Me.txt_sumprice.Text = ""
        Me.txt_interest.Text = ""
        Me.txt_pay.Text = ""

    End Sub

    Sub update_statuscon()
        Dim sql As String = ""
        sql += " update oil_con set"
        sql += " status_oilcon='ยืนยัน'"
        sql += " where contract_oil_no='" + Me.lb_id.Text + "'"
        class_conn.writebase(sql)
    End Sub


    Sub insert_data()

        Dim date_from As String = dtp_date1.Value.Year.ToString & "-" & dtp_date1.Value.Month.ToString & "-" & dtp_date1.Value.Day.ToString

        Dim sql As String = ""
        sql += " Insert into oil_con (contract_oil_no,oil_id,buy_amount,sum_price,sum_interest,sum,pay_date)"
        sql += " Values ('" + Me.lb_id.Text + "','" + Me.cbo_type.SelectedValue.ToString + "'," + Me.txt_amount.Text + "," + Me.txt_price.Text + ""
        sql += " , " + Me.txt_interest.Text + "," + Me.txt_sumprice.Text + ",'" + date_from + "')"

        If class_conn.writebase(sql) = True Then
            MessageBox.Show("ทำรายการสำเร็จ", "Village Saving Management System", MessageBoxButtons.OK, MessageBoxIcon.Information)
            select_data()


        Else
            MessageBox.Show("ทำรายการล้มเหลว", "Village Saving Management System", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End If
    End Sub

    Private Sub oil_buy_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        data_combobox()

    End Sub

    Private Sub txt_amount_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txt_amount.TextChanged

        If Me.txt_amount.Text = "" Then
            Exit Sub

        ElseIf Not IsNumeric(Me.txt_amount.Text) Then
            MessageBox.Show("กรุณากรอกข้อมูลที่เป็นตัวเลขเท่านั้น", "มีปัญหา", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Me.txt_amount.Text = ""

        Else
            Me.txt_sumprice.Text = Me.txt_amount.Text * Me.txt_price.Text
            interest()

        End If
    End Sub

    Private Sub tst_select_ButtonClick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tst_select.ButtonClick
        check_oil()

    End Sub

    Private Sub tst_back_ButtonClick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tst_back.ButtonClick
        Dim sql_con As String = ""
        Dim dta_con As DataTable
        sql_con += " SELECT * from oil_con where contract_oil_no = '" + Me.lb_id.Text + "'"
        dta_con = class_conn.selectbase(sql_con)

        Dim status As String
        status = dta_con.Rows(0).Item("status_oilcon").ToString
        If status <> "NULL" And status <> "" Then
            MessageBox.Show("กรุณายืนยันการกู้", "Village Saving Management System", MessageBoxButtons.OK, MessageBoxIcon.Information)
        ElseIf status <> "ยืนยัน" Then
            MessageBox.Show("กรุณายืนยันการกู้", "Village Saving Management System", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Else
            Me.DialogResult = Windows.Forms.DialogResult.OK
            Me.Close()

        End If
    End Sub

    Sub check_data()
        If Me.txt_amount.Text = "" Then
            MessageBox.Show("กรุณากรอกข้อมูลให้สมบูรณ์", "Village Saving Management System", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        Else

            update_statuscon()

            Me.DialogResult = Windows.Forms.DialogResult.OK
            MessageBox.Show("ทำการบันทึกสำเร็จ", "Village Saving Management System", MessageBoxButtons.OK, MessageBoxIcon.Information)

            Me.Close()
        End If
    End Sub

    Private Sub tst_confirm_ButtonClick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tst_confirm.ButtonClick
        If MsgBox("คุณต้องการทำการบันทึกใช่หรือไม่" & "", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
            check_data()

        End If

    End Sub

    Sub select_data()
        Dim sql As String = ""
        Dim dta As DataTable
        sql += " select contract_oil_no,oil_id,oil_type,buy_amount,sum_price,sum_interest,sum,pay_date,o_id from vw_oil2 where contract_oil_no ='" + Me.lb_id.Text + "'"
        dta = class_conn.selectbase(sql)
        Me.DataGridView1.DataSource = dta
    End Sub

    Sub delete_data(ByVal o_id As String)
        Dim sql As String = ""
        sql += " Delete from oil_con"
        sql += " Where o_id = " + o_id + ""
        If class_conn.writebase(sql) = True Then
            MessageBox.Show("ทำการยกเลิกสำเร็จ", "", MessageBoxButtons.OK, MessageBoxIcon.Information)
            select_data()
            return_data()

        Else
            MessageBox.Show("ทำการยกเลิกล้มเหลว", "", MessageBoxButtons.OK, MessageBoxIcon.Warning)

        End If
    End Sub


    Private Sub DataGridView1_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick
        Dim UserSelectRow As Integer = 0
        UserSelectRow = CInt(Me.DataGridView1.CurrentRow.Index.ToString)
        Me.cbo_type.Text = DataGridView1.Rows.Item(UserSelectRow).Cells("oil_id").Value.ToString
        Me.txt_amount.Text = DataGridView1.Rows.Item(UserSelectRow).Cells("buy_amount").Value.ToString
        Me.txt_price.Text = DataGridView1.Rows.Item(UserSelectRow).Cells("sum_price").Value.ToString
        Me.txt_interest.Text = DataGridView1.Rows.Item(UserSelectRow).Cells("sum_interest").Value.ToString
        Me.txt_sumprice.Text = DataGridView1.Rows.Item(UserSelectRow).Cells("sum").Value.ToString
        Me.dtp_date1.Text = DataGridView1.Rows.Item(UserSelectRow).Cells("pay_date").Value.ToString

        Dim o_id As String = DataGridView1.Rows(e.RowIndex).Cells("o_id").Value.ToString()
        If DataGridView1.Columns(e.ColumnIndex).Name = "delete" Then
            Dim question As String =
                MessageBox.Show("คุณต้องการยกเลิกหรือไม่", "ยืนยัน", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
            If question = DialogResult.Yes Then
                delete_data(o_id)

            ElseIf question = DialogResult.No Then

            End If
        End If

    End Sub


    Private Sub GroupBox1_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GroupBox1.Enter
        dtp_date1.Value = Now.AddYears(+1)
    End Sub
End Class
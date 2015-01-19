Imports Microsoft.VisualBasic
Imports System.Data
Imports System.Data.SqlClient
Public Class all_customer_fercon
    Dim class_conn As New class_conn

    Sub load_data()
        Dim sql As String = ""
        Dim dta As DataTable
        If Me.cbo_search.Text = "ชื่อ" Then
            sql += " select * from customers where cust_fname like '%" + Me.txt_search.Text + "%' and status is null and fercon_status is null"
        ElseIf Me.cbo_search.Text = "รหัสสมาชิก" Then
            sql += " select * from customers where cust_id like '%" + Me.txt_search.Text + "%' and status is null and fercon_status is null"
        ElseIf Me.cbo_search.Text = "เลขบัตรประชาชน" Then
            sql += " select * from customers where personal_id like '%" + Me.txt_search.Text + "%' and status is null and fercon_status is null"
        Else
            MessageBox.Show("กรุณาเลือกคำค้นหาก่อนค่ะ", "Village Saving Management System", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End If

        dta = class_conn.selectbase(sql)
        Dim count As Integer = 0
        count = dta.Rows.Count

        If Me.txt_search.Text = "" Then
            MessageBox.Show("กรุณากรอกข้อมูลให้สมบูรณ์", "Village Saving Management System", MessageBoxButtons.OK, MessageBoxIcon.Warning)

        ElseIf count = 0 Then
            MessageBox.Show("ไม่พบข้อมูล", "Village Saving Management System", MessageBoxButtons.OK, MessageBoxIcon.Warning)

        Else
            Me.DataGridView1.DataSource = dta
        End If

    End Sub

    Private Sub btn_search_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_search.Click
        load_data()

    End Sub

    Private Sub DataGridView1_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick
        Dim UserSelectRow As Integer = 0

        UserSelectRow = CInt(Me.DataGridView1.CurrentRow.Index.ToString)
        strid = DataGridView1.Rows.Item(UserSelectRow).Cells("cust_id").Value.ToString
        strname = DataGridView1.Rows.Item(UserSelectRow).Cells("cust_fname").Value.ToString
        strsurname = DataGridView1.Rows.Item(UserSelectRow).Cells("cust_lname").Value.ToString
        straddress = DataGridView1.Rows.Item(UserSelectRow).Cells("cust_address").Value.ToString
        strtel = DataGridView1.Rows.Item(UserSelectRow).Cells("tel").Value.ToString
        strid_card = DataGridView1.Rows.Item(UserSelectRow).Cells("personal_id").Value.ToString
        strage = DataGridView1.Rows.Item(UserSelectRow).Cells("age").Value.ToString
        strjob = DataGridView1.Rows.Item(UserSelectRow).Cells("occupation").Value.ToString
        strsalary = DataGridView1.Rows.Item(UserSelectRow).Cells("earnings_month").Value.ToString

        Me.DialogResult = Windows.Forms.DialogResult.OK
        Me.Close()

        'Dim date_from As String = dtt.Value.Year.ToString
        'Dim sql As String = ""
        'Dim dta As DataTable
        'sql += " select * from fer_contracts where cust_id ='" + strid + "' and status is null and create_date >= '" + date_from + "-01-01 00:00:00' and create_date <= '" + date_from + "-12-31 23:59:59'"
        'dta = class_conn.selectbase(sql)
        'Dim count_con As String
        'count_con = dta.Rows.Count
        'If count_con = 0 Then
        '    Dim sql2 As String = ""
        '    Dim dta2 As DataTable
        '    sql2 += " select top 1 * from vw_cus_con_ferpay where cust_id ='" + strid + "' and balance = 0 order by pay_id desc"
        '    dta2 = class_conn.selectbase(sql2)
        '    Dim count_pay As String
        '    count_pay = dta2.Rows.Count
        '    If count_pay = 0 Then
        '        Me.DialogResult = Windows.Forms.DialogResult.OK
        '        Me.Close()
        '    Else
        '        MessageBox.Show("คุณยังค้างชำระอยู่ค่ะ", "มีปัญหา", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        '    End If
        'Else
        '    MessageBox.Show("คุณได้ทำการกู้ไปแล้วค่ะ", "มีปัญหา", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        'End If

    End Sub

End Class
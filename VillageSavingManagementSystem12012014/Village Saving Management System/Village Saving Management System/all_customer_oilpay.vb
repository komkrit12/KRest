Imports Microsoft.VisualBasic
Imports System.Data
Imports System.Data.SqlClient
Public Class all_customer_oilpay
    Dim class_conn As New class_conn

    Sub load_data()
        Dim sql As String = ""
        Dim dta As DataTable

        If Me.cbo_search.Text = "ชื่อ" Then
            sql += " select distinct cust_id,cust_fname , cust_lname,contract_oil_no,cust_address,tel,personal_id,age,occupation,earnings_month,pay_date from vw_oiloil where cust_fname like '%" + Me.txt_search.Text + "%' and status is null and status_oilcon is null  order by cust_id asc"
        ElseIf Me.cbo_search.Text = "รหัสสมาชิก" Then
            sql += " select distinct cust_id,cust_fname , cust_lname,contract_oil_no,cust_address,tel,personal_id,age,occupation,earnings_month,pay_date from vw_oiloil where cust_id like '%" + Me.txt_search.Text + "%' and status is null and status_oilcon is null   order by cust_id asc"
        ElseIf Me.cbo_search.Text = "เลขบัตรประชาชน" Then
            sql += " select distinct cust_id,cust_fname , cust_lname,contract_oil_no,cust_address,tel,personal_id,age,occupation,earnings_month,pay_date from vw_oiloil where personal_id like '%" + Me.txt_search.Text + "%' and status is null and status_oilcon is null   order by cust_id asc"

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

        strconid = DataGridView1.Rows.Item(UserSelectRow).Cells("contract_oil_no").Value.ToString
        strid = DataGridView1.Rows.Item(UserSelectRow).Cells("cust_id").Value.ToString
        strname = DataGridView1.Rows.Item(UserSelectRow).Cells("cust_fname").Value.ToString
        strsurname = DataGridView1.Rows.Item(UserSelectRow).Cells("cust_lname").Value.ToString
        straddress = DataGridView1.Rows.Item(UserSelectRow).Cells("cust_address").Value.ToString
        strtel = DataGridView1.Rows.Item(UserSelectRow).Cells("tel").Value.ToString
        strid_card = DataGridView1.Rows.Item(UserSelectRow).Cells("personal_id").Value.ToString
        strage = DataGridView1.Rows.Item(UserSelectRow).Cells("age").Value.ToString
        strjob = DataGridView1.Rows.Item(UserSelectRow).Cells("occupation").Value.ToString
        strsalary = DataGridView1.Rows.Item(UserSelectRow).Cells("earnings_month").Value.ToString
        strtime1 = DataGridView1.Rows.Item(UserSelectRow).Cells("pay_date").Value.ToString

        Me.DialogResult = Windows.Forms.DialogResult.OK
        Me.Close()
    End Sub

    Private Sub all_customer_oilpay_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub
End Class
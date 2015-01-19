
Public Class all_customer_oilcon
    Dim class_conn As New class_conn

    Sub load_data()
        Dim sql As String = ""
        Dim dta As DataTable
        If Me.cbo_search.Text = "ชื่อ" Then
            sql += " select * from customers where cust_fname like '%" + Me.txt_search.Text + "%' and status is null and oilcon_status is null"
        ElseIf Me.cbo_search.Text = "รหัสสมาชิก" Then
            sql += " select * from customers where cust_id like '%" + Me.txt_search.Text + "%' and status is null and oilcon_status is null"
        ElseIf Me.cbo_search.Text = "เลขบัตรประชาชน" Then
            sql += " select * from customers where personal_id like '%" + Me.txt_search.Text + "%' and status is null and oilcon_status is null"
        Else
            MessageBox.Show("กรุณาเลือกคำค้นหาก่อนค่ะ", "มีปัญหา", MessageBoxButtons.OK, MessageBoxIcon.Warning)

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
    End Sub
End Class
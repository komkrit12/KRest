Imports Microsoft.VisualBasic
Imports System.Data
Imports System.Data.SqlClient

Public Class Search
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
            MessageBox.Show("กรุณากรอกข้อมูลให้สมบูรณ์", "Village Saving Management System", MessageBoxButtons.OK, MessageBoxIcon.Warning)

        ElseIf count = 0 Then
            MessageBox.Show("ไม่พบข้อมูล", "Village Saving Management System", MessageBoxButtons.OK, MessageBoxIcon.Warning)

        Else
            Me.DataGridView1.DataSource = dta
        End If

    End Sub

    Sub select_data()
        Dim sql As String = ""
        Dim dta As DataTable
        sql += " select cust_id,cust_fname,cust_lname,cust_address,tel,occupation,personal_id,age,earnings_month,time_create from customers where status is null"
        dta = class_conn.selectbase(sql)
        Me.DataGridView1.DataSource = dta

    End Sub

    Private Sub tst_back_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tst_back.Click
        Close()

    End Sub

    Private Sub btn_search_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_search.Click
        load_data()

    End Sub

    Private Sub DataGridView1_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick
        Dim UserSelectRow As Integer = 0
        UserSelectRow = CInt(Me.DataGridView1.CurrentRow.Index.ToString)
        Me.txt_id.Text = DataGridView1.Rows.Item(UserSelectRow).Cells("cust_id").Value.ToString
        Me.txt_fname.Text = DataGridView1.Rows.Item(UserSelectRow).Cells("cust_fname").Value.ToString
        Me.txt_lname.Text = DataGridView1.Rows.Item(UserSelectRow).Cells("cust_lname").Value.ToString
        Me.txt_address.Text = DataGridView1.Rows.Item(UserSelectRow).Cells("cust_address").Value.ToString
        Me.txt_tel.Text = DataGridView1.Rows.Item(UserSelectRow).Cells("tel").Value.ToString
        Me.txt_vocation.Text = DataGridView1.Rows.Item(UserSelectRow).Cells("occupation").Value.ToString
        Me.txt_personalid.Text = DataGridView1.Rows.Item(UserSelectRow).Cells("personal_id").Value.ToString
        Me.txt_age.Text = DataGridView1.Rows.Item(UserSelectRow).Cells("age").Value.ToString
        Me.txt_month.Text = DataGridView1.Rows.Item(UserSelectRow).Cells("earnings_month").Value.ToString
        Me.dtp_time1.Text = DataGridView1.Rows.Item(UserSelectRow).Cells("time_create").Value.ToString


    End Sub

End Class
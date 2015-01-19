Imports Microsoft.VisualBasic
Imports System.Data
Imports System.Data.SqlClient
Public Class all_register
    Dim class_conn As New class_conn

    Sub load_data()
        Dim sql As String = ""
        Dim dta As DataTable

        If Me.cbo_search.Text = "ชื่อ" Then
            sql += " select * from register where name like '%" + Me.txt_search.Text + "%' and status is null"
       
        ElseIf Me.cbo_search.Text = "เลขบัตรประชาชน" Then
            sql += " select * from register where personal_id like '%" + Me.txt_search.Text + "%' and status is null"

        End If

        dta = class_conn.selectbase(sql)
        Dim count As Integer = 0
        count = dta.Rows.Count

        If Me.txt_search.Text = "" Then
            MessageBox.Show("กรุณากรอกข้อมูลให้สมบูรณ์", "มีปัญหา", MessageBoxButtons.OK, MessageBoxIcon.Warning)

        ElseIf count = 0 Then
            MessageBox.Show("ไม่พบข้อมูล", "มีปัญหา", MessageBoxButtons.OK, MessageBoxIcon.Warning)
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
        id = DataGridView1.Rows.Item(UserSelectRow).Cells("register_id").Value.ToString
        strname = DataGridView1.Rows.Item(UserSelectRow).Cells("name").Value.ToString
        strusername = DataGridView1.Rows.Item(UserSelectRow).Cells("username").Value.ToString
        straddres = DataGridView1.Rows.Item(UserSelectRow).Cells("address").Value.ToString
        strpersonal = DataGridView1.Rows.Item(UserSelectRow).Cells("personal_id").Value.ToString
        strposition = DataGridView1.Rows.Item(UserSelectRow).Cells("position").Value.ToString
        strpassword = DataGridView1.Rows.Item(UserSelectRow).Cells("password").Value.ToString

        Me.DialogResult = Windows.Forms.DialogResult.OK
        Me.Close()
    End Sub

    Private Sub all_register_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub
End Class
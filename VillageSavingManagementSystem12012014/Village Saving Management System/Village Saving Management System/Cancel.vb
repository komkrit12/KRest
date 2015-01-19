Imports Microsoft.VisualBasic
Imports System.Data
Imports System.Data.SqlClient
Public Class cancel
    Dim class_conn As New class_conn

    Sub load_data()
        Dim sql As String = ""
        Dim dta As DataTable

        If Me.cbo_search.Text = "ข้อมูลสมาชิก" Then

            If Me.cbo_search2.Text = "ชื่อ" Then
                sql += " select *, cust_fname + ' ' + cust_lname AS FullName from customers where cust_fname like '%" + Me.txt_search.Text + "%' and status = 'แจ้งยกเลิก'"
            ElseIf Me.cbo_search2.Text = "รหัสสมาชิก" Then
                sql += " select *, cust_fname + ' ' + cust_lname AS FullName from customers where cust_id like '%" + Me.txt_search.Text + "%' and status = 'แจ้งยกเลิก'"
            ElseIf Me.cbo_search2.Text = "เลขบัตรประชาชน" Then
                sql += " select *, cust_fname + ' ' + cust_lname AS FullName from customers where personal_id like '%" + Me.txt_search.Text + "%' and status = 'แจ้งยกเลิก'"
            Else
                sql += " select * from customers"
            End If

        ElseIf Me.cbo_search.Text = "ฝาก" Then

            If Me.cbo_search2.Text = "ชื่อ" Then
                sql += " select *, cust_fname + ' ' + cust_lname AS FullName from transection where cust_fname like '%" + Me.txt_search.Text + "%' and status = 'แจ้งยกเลิก'"
            ElseIf Me.cbo_search2.Text = "รหัสสมาชิก" Then
                sql += " select *, cust_fname + ' ' + cust_lname AS FullName from transection where cust_id like '%" + Me.txt_search.Text + "%' and status = 'แจ้งยกเลิก'"
            ElseIf Me.cbo_search2.Text = "เลขบัตรประชาชน" Then
                sql += " select *, cust_fname + ' ' + cust_lname AS FullName from transection where personal_id like '%" + Me.txt_search.Text + "%' and status = 'แจ้งยกเลิก'"
            Else
                sql += " select * from transection"
            End If

        ElseIf Me.cbo_search.Text = "ถอน" Then

            If Me.cbo_search2.Text = "ชื่อ" Then
                sql += " select *, cust_fname + ' ' + cust_lname AS FullName from transection where cust_fname like '%" + Me.txt_search.Text + "%' and status = 'แจ้งยกเลิก'"
            ElseIf Me.cbo_search2.Text = "รหัสสมาชิก" Then
                sql += " select *, cust_fname + ' ' + cust_lname AS FullName from transection where cust_id like '%" + Me.txt_search.Text + "%' and status = 'แจ้งยกเลิก'"
            ElseIf Me.cbo_search2.Text = "เลขบัตรประชาชน" Then
                sql += " select *, cust_fname + ' ' + cust_lname AS FullName from transection where personal_id like '%" + Me.txt_search.Text + "%' and status = 'แจ้งยกเลิก'"
            Else
                sql += " select * from transection"
            End If

        ElseIf Me.cbo_search.Text = "สัญญาเงินกู้" Then

            If Me.cbo_search2.Text = "ชื่อ" Then
                sql += " select *, cust_fname + ' ' + cust_lname AS FullName from contracts where cust_fname like '%" + Me.txt_search.Text + "%' and status = 'แจ้งยกเลิก'"
            ElseIf Me.cbo_search2.Text = "รหัสสมาชิก" Then
                sql += " select *, cust_fname + ' ' + cust_lname AS FullName from contracts where cust_id like '%" + Me.txt_search.Text + "%' and status = 'แจ้งยกเลิก'"
            ElseIf Me.cbo_search2.Text = "เลขบัตรประชาชน" Then
                sql += " select *, cust_fname + ' ' + cust_lname AS FullName from contracts where personal_id like '%" + Me.txt_search.Text + "%' and status = 'แจ้งยกเลิก'"
            Else
                sql += " select * from contracts"
            End If

        ElseIf Me.cbo_search.Text = "ชำระเงินกู้" Then

            If Me.cbo_search2.Text = "ชื่อ" Then
                sql += " select *, cust_fname + ' ' + cust_lname AS FullName from payment where cust_fname like '%" + Me.txt_search.Text + "%' and status = 'แจ้งยกเลิก'"
            ElseIf Me.cbo_search2.Text = "รหัสสมาชิก" Then
                sql += " select *, cust_fname + ' ' + cust_lname AS FullName from payment where cust_id like '%" + Me.txt_search.Text + "%' and status = 'แจ้งยกเลิก'"
            ElseIf Me.cbo_search2.Text = "เลขบัตรประชาชน" Then
                sql += " select *, cust_fname + ' ' + cust_lname AS FullName from payment where personal_id like '%" + Me.txt_search.Text + "%' and status = 'แจ้งยกเลิก'"
            Else
                sql += " select * from payment"
            End If

        ElseIf Me.cbo_search.Text = "รับปุ๋ยเข้าสต๊อก" Then

            If Me.cbo_search2.Text = "ชื่อ" Then
                sql += " select *, cust_fname + ' ' + cust_lname AS FullName from fer_receive where cust_fname like '%" + Me.txt_search.Text + "%' and status = 'แจ้งยกเลิก'"
            ElseIf Me.cbo_search2.Text = "รหัสสมาชิก" Then
                sql += " select *, cust_fname + ' ' + cust_lname AS FullName from fer_receive where cust_id like '%" + Me.txt_search.Text + "%' and status = 'แจ้งยกเลิก'"
            ElseIf Me.cbo_search2.Text = "เลขบัตรประชาชน" Then
                sql += " select *, cust_fname + ' ' + cust_lname AS FullName from fer_receive where personal_id like '%" + Me.txt_search.Text + "%' and status = 'แจ้งยกเลิก'"
            Else
                sql += " select * from fer_receive"
            End If

        ElseIf Me.cbo_search.Text = "สัญญาซื้อปุ๋ย" Then

            If Me.cbo_search2.Text = "ชื่อ" Then
                sql += " select *, cust_fname + ' ' + cust_lname AS FullName from fer_contracts where cust_fname like '%" + Me.txt_search.Text + "%' and status = 'แจ้งยกเลิก'"
            ElseIf Me.cbo_search2.Text = "รหัสสมาชิก" Then
                sql += " select *, cust_fname + ' ' + cust_lname AS FullName from fer_contracts where cust_id like '%" + Me.txt_search.Text + "%' and status = 'แจ้งยกเลิก'"
            ElseIf Me.cbo_search2.Text = "เลขบัตรประชาชน" Then
                sql += " select *, cust_fname + ' ' + cust_lname AS FullName from fer_contracts where personal_id like '%" + Me.txt_search.Text + "%' and status = 'แจ้งยกเลิก'"
            Else
                sql += " select * from fer_contracts"
            End If

        ElseIf Me.cbo_search.Text = "ชำระค่าปุ๋ย" Then

            If Me.cbo_search2.Text = "ชื่อ" Then
                sql += " select *, cust_fname + ' ' + cust_lname AS FullName from fer_payment where cust_fname like '%" + Me.txt_search.Text + "%' and status = 'แจ้งยกเลิก'"
            ElseIf Me.cbo_search2.Text = "รหัสสมาชิก" Then
                sql += " select *, cust_fname + ' ' + cust_lname AS FullName from fer_payment where cust_id like '%" + Me.txt_search.Text + "%' and status = 'แจ้งยกเลิก'"
            ElseIf Me.cbo_search2.Text = "เลขบัตรประชาชน" Then
                sql += " select *, cust_fname + ' ' + cust_lname AS FullName from fer_payment where personal_id like '%" + Me.txt_search.Text + "%' and status = 'แจ้งยกเลิก'"
            Else
                sql += " select * from fer_payment"
            End If

        ElseIf Me.cbo_search.Text = "รับน้ำมันเข้าสต๊อก" Then

            If Me.cbo_search2.Text = "ชื่อ" Then
                sql += " select *, cust_fname + ' ' + cust_lname AS FullName from oil_stock where cust_fname like '%" + Me.txt_search.Text + "%' and status = 'แจ้งยกเลิก'"
            ElseIf Me.cbo_search2.Text = "รหัสสมาชิก" Then
                sql += " select *, cust_fname + ' ' + cust_lname AS FullName from oil_stock where cust_id like '%" + Me.txt_search.Text + "%' and status = 'แจ้งยกเลิก'"
            ElseIf Me.cbo_search2.Text = "เลขบัตรประชาชน" Then
                sql += " select *, cust_fname + ' ' + cust_lname AS FullName from oil_stock where personal_id like '%" + Me.txt_search.Text + "%' and status = 'แจ้งยกเลิก'"
            Else
                sql += " select * from oil_stock"
            End If

        ElseIf Me.cbo_search.Text = "สัญญาซื้อน้ำมัน" Then

            If Me.cbo_search2.Text = "ชื่อ" Then
                sql += " select *, cust_fname + ' ' + cust_lname AS FullName from oil_contracts where cust_fname like '%" + Me.txt_search.Text + "%' and status = 'แจ้งยกเลิก'"
            ElseIf Me.cbo_search2.Text = "รหัสสมาชิก" Then
                sql += " select *, cust_fname + ' ' + cust_lname AS FullName from oil_contracts where cust_id like '%" + Me.txt_search.Text + "%' and status = 'แจ้งยกเลิก'"
            ElseIf Me.cbo_search2.Text = "เลขบัตรประชาชน" Then
                sql += " select *, cust_fname + ' ' + cust_lname AS FullName from oil_contracts where personal_id like '%" + Me.txt_search.Text + "%' and status = 'แจ้งยกเลิก'"
            Else
                sql += " select * from fer_payment"
            End If


        ElseIf Me.cbo_search.Text = "ชำระค่าน้ำมัน" Then

            If Me.cbo_search2.Text = "ชื่อ" Then
                sql += " select *, cust_fname + ' ' + cust_lname AS FullName from oil_payment where cust_fname like '%" + Me.txt_search.Text + "%' and status = 'แจ้งยกเลิก'"
            ElseIf Me.cbo_search2.Text = "รหัสสมาชิก" Then
                sql += " select *, cust_fname + ' ' + cust_lname AS FullName from oil_payment where cust_id like '%" + Me.txt_search.Text + "%' and status = 'แจ้งยกเลิก'"
            ElseIf Me.cbo_search2.Text = "เลขบัตรประชาชน" Then
                sql += " select *, cust_fname + ' ' + cust_lname AS FullName from oil_payment where personal_id like '%" + Me.txt_search.Text + "%' and status = 'แจ้งยกเลิก'"
            Else
                sql += " select * from oil_payment"

            End If

        Else
            MessageBox.Show("กรุณาเลือกรายการที่ต้องการยกเลิก", "มีปัญหา", MessageBoxButtons.OK, MessageBoxIcon.Warning)

        End If

        dta = class_conn.selectbase(sql)
        Me.DataGridView1.DataSource = dta

    End Sub

    Sub select_data()
        Dim sql As String = ""
        Dim dta As DataTable
        sql += " select * from vw_01 where status = 'แจ้งยกเลิก'"
        dta = class_conn.selectbase(sql)
        Me.DataGridView1.DataSource = dta
    End Sub


    Sub cencel_data()
        Dim sql As String = ""

        If Me.cbo_search.Text = "ข้อมูลสมาชิก" Then
            sql += " UPDATE customers SET"
            sql += " status = 'ยกเลิก'"
            sql += " WHERE cust_id=" + Me.txt_id.Text + ""

        ElseIf Me.cbo_search.Text = "ฝาก" Then
            sql += " UPDATE transection SET"
            sql += " status = 'ยกเลิก'"
            sql += " WHERE cust_id=" + Me.txt_id.Text + ""

        ElseIf Me.cbo_search.Text = "ถอน" Then
            sql += " UPDATE transection SET"
            sql += " status = 'ยกเลิก'"
            sql += " WHERE cust_id=" + Me.txt_id.Text + ""

        ElseIf Me.cbo_search.Text = "สัญญาเงินกู้" Then
            sql += " UPDATE contracts SET"
            sql += " status = 'ยกเลิก'"
            sql += " WHERE contract_no=" + Me.txt_conid.Text + ""

        ElseIf Me.cbo_search.Text = "ชำระเงินกู้" Then
            sql += " UPDATE payment SET"
            sql += " status = 'ยกเลิก'"
            sql += " WHERE contract_no=" + Me.txt_conid.Text + ""

        ElseIf Me.cbo_search.Text = "รับปุ๋ยเข้าสต๊อก" Then
            sql += " UPDATE fer_receive SET"
            sql += " status = 'ยกเลิก'"
            sql += " WHERE contract_no=" + Me.txt_conid.Text + ""

        ElseIf Me.cbo_search.Text = "สัญญาซื้อปุ๋ย" Then
            sql += " UPDATE fer_contracts SET"
            sql += " status = 'ยกเลิก'"
            sql += " WHERE contract_fer_no=" + Me.txt_conid.Text + ""

        ElseIf Me.cbo_search.Text = "ชำระเงินค่าปุ๋ย" Then
            sql += " UPDATE fer_payment SET"
            sql += " status = 'ยกเลิก'"
            sql += " WHERE contract_fer_no=" + Me.txt_conid.Text + ""

        ElseIf Me.cbo_search.Text = "รับน้ำมันเข้าสต๊อก" Then
            sql += " UPDATE oil_stock SET"
            sql += " status = 'ยกเลิก'"
            sql += " WHERE contract_no=" + Me.txt_conid.Text + ""

        ElseIf Me.cbo_search.Text = "สัญญาซื้อน้ำมัน" Then
            sql += " UPDATE oil_contracts SET"
            sql += " status = 'ยกเลิก'"
            sql += " WHERE contract_oil_no=" + Me.txt_conid.Text + ""

        ElseIf Me.cbo_search.Text = "ชำระเงินค่าน้ำมัน" Then
            sql += " UPDATE oil_payment SET"
            sql += " status = 'ยกเลิก'"
            sql += " WHERE contract_oil_no=" + Me.txt_conid.Text + ""
        Else
            MessageBox.Show("กรุณาตรวจสอบการยกเลิกอีกครั้ง", "มีปัญหา", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End If

        If class_conn.writebase(sql) = True Then
            MessageBox.Show("ยกเลิกรายการสำเร็จ", "ผลการแก้ไข", MessageBoxButtons.OK, MessageBoxIcon.Information)

        Else
            MessageBox.Show("ยกเลิกรายการล้มเหลวค่ะ", "มีปัญหา", MessageBoxButtons.OK, MessageBoxIcon.Warning)

        End If
    End Sub


    Sub cencel_dataall()
        Dim sql As String = ""
        sql += " UPDATE contracts SET"
        sql += " status = 'ยกเลิก'"
        sql += " WHERE status= 'แจ้งยกเลิก'"
        If class_conn.writebase(sql) = True Then
            MessageBox.Show("บันทึกการยกเลิกสำเร็จ", "ผลการแก้ไข", MessageBoxButtons.OK, MessageBoxIcon.Information)

        Else
            MessageBox.Show("การยกเลิกล้มเหลวค่ะ", "มีปัญหา", MessageBoxButtons.OK, MessageBoxIcon.Warning)

        End If
    End Sub


    Private Sub DataGridView1_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick
        Dim UserSelectRow As Integer = 0
        UserSelectRow = CInt(Me.DataGridView1.CurrentRow.Index.ToString)
        'Me.txt_conid.Text = DataGridView1.Rows.Item(UserSelectRow).Cells("contract_no").Value.ToString
        Me.txt_id.Text = DataGridView1.Rows.Item(UserSelectRow).Cells("cust_id").Value.ToString
        Me.txt_fullname.Text = DataGridView1.Rows.Item(UserSelectRow).Cells("cust_fname").Value.ToString
        Me.txt_address.Text = DataGridView1.Rows.Item(UserSelectRow).Cells("cust_address").Value.ToString
        Me.txt_tel.Text = DataGridView1.Rows.Item(UserSelectRow).Cells("tel").Value.ToString
        Me.txt_personalid.Text = DataGridView1.Rows.Item(UserSelectRow).Cells("personal_id").Value.ToString
        Me.txt_age.Text = DataGridView1.Rows.Item(UserSelectRow).Cells("age").Value.ToString
        Me.txt_vocation.Text = DataGridView1.Rows.Item(UserSelectRow).Cells("occupation").Value.ToString
        Me.txt_month.Text = DataGridView1.Rows.Item(UserSelectRow).Cells("earnings_month").Value.ToString

    End Sub

    Private Sub cancel_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        select_data()

    End Sub

    Private Sub tst_back_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tst_back.Click
        Close()

    End Sub

    Private Sub btn_search_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_search.Click
        load_data()

    End Sub

    
    Private Sub tst_allcancel_ButtonClick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tst_allcancel.ButtonClick
        If MsgBox("คุณต้องการยกเลิกรายการทั้งหมดใช่หรือไม่?" & "", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
            cencel_dataall()
        End If
    End Sub

    Private Sub tst_cancel_ButtonClick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tst_cancel.ButtonClick
        If MsgBox("คุณต้องการยกเลิกรายการนี้ใช่หรือไม่?" & "", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
            cencel_data()
        End If
    End Sub
End Class
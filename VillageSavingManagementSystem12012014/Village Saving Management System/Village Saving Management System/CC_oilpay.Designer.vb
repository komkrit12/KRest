<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CC_oilpay
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(CC_oilpay))
        Me.txt_search = New System.Windows.Forms.TextBox()
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.tst_cancel = New System.Windows.Forms.ToolStripSplitButton()
        Me.tst_allcancel = New System.Windows.Forms.ToolStripSplitButton()
        Me.tst_back = New System.Windows.Forms.ToolStripButton()
        Me.cbo_search2 = New System.Windows.Forms.ComboBox()
        Me.btn_search = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.txt_conid = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.dtp_1 = New System.Windows.Forms.DateTimePicker()
        Me.txt_amount = New System.Windows.Forms.TextBox()
        Me.txt_create = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.txt_personalid = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txt_fullname = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txt_id = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.cust_id = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cust_fname = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cust_lname = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.personal_id = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.pay_value = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.create_date = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.createby = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.contract_oil_no = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.pay_id = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.lb = New System.Windows.Forms.Label()
        Me.ToolStrip1.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txt_search
        '
        Me.txt_search.Location = New System.Drawing.Point(197, 31)
        Me.txt_search.Name = "txt_search"
        Me.txt_search.Size = New System.Drawing.Size(101, 20)
        Me.txt_search.TabIndex = 5
        '
        'ToolStrip1
        '
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tst_cancel, Me.tst_allcancel, Me.tst_back})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(934, 72)
        Me.ToolStrip1.TabIndex = 37
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'tst_cancel
        '
        Me.tst_cancel.Image = Global.Village_Saving_Management_System.My.Resources.Resources.Del_icon
        Me.tst_cancel.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.tst_cancel.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tst_cancel.Name = "tst_cancel"
        Me.tst_cancel.Size = New System.Drawing.Size(66, 69)
        Me.tst_cancel.Text = "ยกเลิก"
        Me.tst_cancel.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'tst_allcancel
        '
        Me.tst_allcancel.Image = Global.Village_Saving_Management_System.My.Resources.Resources.icon
        Me.tst_allcancel.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.tst_allcancel.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.tst_allcancel.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tst_allcancel.Name = "tst_allcancel"
        Me.tst_allcancel.Size = New System.Drawing.Size(88, 69)
        Me.tst_allcancel.Text = "ยกเลิกทั้งหมด"
        Me.tst_allcancel.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.tst_allcancel.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'tst_back
        '
        Me.tst_back.Image = Global.Village_Saving_Management_System.My.Resources.Resources.home_icon
        Me.tst_back.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.tst_back.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tst_back.Name = "tst_back"
        Me.tst_back.Size = New System.Drawing.Size(77, 69)
        Me.tst_back.Text = "กลับสู่หน้าหลัก"
        Me.tst_back.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'cbo_search2
        '
        Me.cbo_search2.FormattingEnabled = True
        Me.cbo_search2.Items.AddRange(New Object() {"ชื่อ", "รหัสสมาชิก", "เลขบัตรประชาชน"})
        Me.cbo_search2.Location = New System.Drawing.Point(92, 31)
        Me.cbo_search2.Name = "cbo_search2"
        Me.cbo_search2.Size = New System.Drawing.Size(99, 21)
        Me.cbo_search2.TabIndex = 4
        Me.cbo_search2.Text = "เลือกคำค้น"
        '
        'btn_search
        '
        Me.btn_search.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.btn_search.ImageAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btn_search.Location = New System.Drawing.Point(318, 22)
        Me.btn_search.Name = "btn_search"
        Me.btn_search.Size = New System.Drawing.Size(75, 37)
        Me.btn_search.TabIndex = 3
        Me.btn_search.Text = "ค้นหา"
        Me.btn_search.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.txt_search)
        Me.GroupBox1.Controls.Add(Me.cbo_search2)
        Me.GroupBox1.Controls.Add(Me.btn_search)
        Me.GroupBox1.Location = New System.Drawing.Point(399, 91)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(416, 76)
        Me.GroupBox1.TabIndex = 39
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "ค้นหา"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(25, 34)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(61, 13)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "ค้นหาจาก : "
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Cordia New", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label1.Location = New System.Drawing.Point(98, 91)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(271, 33)
        Me.Label1.TabIndex = 38
        Me.Label1.Text = "ยกเลิกรายการชำระเงินค่าน้ำมัน"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.txt_conid)
        Me.GroupBox2.Controls.Add(Me.Label2)
        Me.GroupBox2.Controls.Add(Me.dtp_1)
        Me.GroupBox2.Controls.Add(Me.txt_amount)
        Me.GroupBox2.Controls.Add(Me.txt_create)
        Me.GroupBox2.Controls.Add(Me.Label10)
        Me.GroupBox2.Controls.Add(Me.txt_personalid)
        Me.GroupBox2.Controls.Add(Me.Label8)
        Me.GroupBox2.Controls.Add(Me.Label7)
        Me.GroupBox2.Controls.Add(Me.txt_fullname)
        Me.GroupBox2.Controls.Add(Me.Label4)
        Me.GroupBox2.Controls.Add(Me.txt_id)
        Me.GroupBox2.Controls.Add(Me.Label5)
        Me.GroupBox2.Controls.Add(Me.Label11)
        Me.GroupBox2.Location = New System.Drawing.Point(73, 464)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(792, 179)
        Me.GroupBox2.TabIndex = 42
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "ข้อมูลการชำระเงินค่าปุ๋ย"
        '
        'txt_conid
        '
        Me.txt_conid.Enabled = False
        Me.txt_conid.Location = New System.Drawing.Point(137, 23)
        Me.txt_conid.Name = "txt_conid"
        Me.txt_conid.Size = New System.Drawing.Size(91, 20)
        Me.txt_conid.TabIndex = 44
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(56, 26)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(69, 13)
        Me.Label2.TabIndex = 43
        Me.Label2.Text = "เลขที่สัญญา : "
        '
        'dtp_1
        '
        Me.dtp_1.Enabled = False
        Me.dtp_1.Location = New System.Drawing.Point(498, 101)
        Me.dtp_1.Name = "dtp_1"
        Me.dtp_1.Size = New System.Drawing.Size(146, 20)
        Me.dtp_1.TabIndex = 42
        '
        'txt_amount
        '
        Me.txt_amount.Enabled = False
        Me.txt_amount.Location = New System.Drawing.Point(137, 103)
        Me.txt_amount.Name = "txt_amount"
        Me.txt_amount.Size = New System.Drawing.Size(113, 20)
        Me.txt_amount.TabIndex = 29
        '
        'txt_create
        '
        Me.txt_create.Enabled = False
        Me.txt_create.Location = New System.Drawing.Point(137, 129)
        Me.txt_create.Name = "txt_create"
        Me.txt_create.Size = New System.Drawing.Size(140, 20)
        Me.txt_create.TabIndex = 27
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(73, 132)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(52, 13)
        Me.Label10.TabIndex = 16
        Me.Label10.Text = "ผู้บันทึก : "
        '
        'txt_personalid
        '
        Me.txt_personalid.Enabled = False
        Me.txt_personalid.Location = New System.Drawing.Point(498, 75)
        Me.txt_personalid.Name = "txt_personalid"
        Me.txt_personalid.Size = New System.Drawing.Size(146, 20)
        Me.txt_personalid.TabIndex = 13
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(394, 78)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(98, 13)
        Me.Label8.TabIndex = 12
        Me.Label8.Text = "เลขบัตรประชาชน : "
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(28, 106)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(97, 13)
        Me.Label7.TabIndex = 10
        Me.Label7.Text = "จำนวนเงินที่ชำระ : "
        '
        'txt_fullname
        '
        Me.txt_fullname.Enabled = False
        Me.txt_fullname.Location = New System.Drawing.Point(137, 75)
        Me.txt_fullname.Name = "txt_fullname"
        Me.txt_fullname.Size = New System.Drawing.Size(217, 20)
        Me.txt_fullname.TabIndex = 6
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(426, 106)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(66, 13)
        Me.Label4.TabIndex = 5
        Me.Label4.Text = "วันที่บันทึก : "
        '
        'txt_id
        '
        Me.txt_id.Enabled = False
        Me.txt_id.Location = New System.Drawing.Point(137, 49)
        Me.txt_id.Name = "txt_id"
        Me.txt_id.Size = New System.Drawing.Size(91, 20)
        Me.txt_id.TabIndex = 4
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(53, 52)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(72, 13)
        Me.Label5.TabIndex = 3
        Me.Label5.Text = "เลขที่สมาชิก : "
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(48, 78)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(77, 13)
        Me.Label11.TabIndex = 1
        Me.Label11.Text = "ชื่อ - นามสกุล : "
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.cust_id, Me.cust_fname, Me.cust_lname, Me.personal_id, Me.pay_value, Me.create_date, Me.createby, Me.contract_oil_no, Me.pay_id})
        Me.DataGridView1.Location = New System.Drawing.Point(104, 185)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.DataGridView1.Size = New System.Drawing.Size(711, 273)
        Me.DataGridView1.TabIndex = 43
        '
        'cust_id
        '
        Me.cust_id.DataPropertyName = "cust_id"
        Me.cust_id.HeaderText = "เลขที่สมาชิก"
        Me.cust_id.Name = "cust_id"
        Me.cust_id.ReadOnly = True
        '
        'cust_fname
        '
        Me.cust_fname.DataPropertyName = "cust_fname"
        Me.cust_fname.HeaderText = "ชื่อ"
        Me.cust_fname.Name = "cust_fname"
        Me.cust_fname.ReadOnly = True
        '
        'cust_lname
        '
        Me.cust_lname.DataPropertyName = "cust_lname"
        Me.cust_lname.HeaderText = "นามสกุล"
        Me.cust_lname.Name = "cust_lname"
        Me.cust_lname.ReadOnly = True
        '
        'personal_id
        '
        Me.personal_id.DataPropertyName = "personal_id"
        Me.personal_id.FillWeight = 150.0!
        Me.personal_id.HeaderText = "เลขบัตรประชาชน"
        Me.personal_id.Name = "personal_id"
        Me.personal_id.ReadOnly = True
        Me.personal_id.Width = 150
        '
        'pay_value
        '
        Me.pay_value.DataPropertyName = "pay_value"
        Me.pay_value.HeaderText = "จำนวนเงินที่ชำระ"
        Me.pay_value.Name = "pay_value"
        Me.pay_value.ReadOnly = True
        '
        'create_date
        '
        Me.create_date.DataPropertyName = "create_date"
        Me.create_date.FillWeight = 120.0!
        Me.create_date.HeaderText = "วันที่บันทึก"
        Me.create_date.Name = "create_date"
        Me.create_date.ReadOnly = True
        Me.create_date.Width = 120
        '
        'createby
        '
        Me.createby.DataPropertyName = "createby"
        Me.createby.FillWeight = 150.0!
        Me.createby.HeaderText = "ผู้บันทึก"
        Me.createby.Name = "createby"
        Me.createby.ReadOnly = True
        Me.createby.Width = 150
        '
        'contract_oil_no
        '
        Me.contract_oil_no.DataPropertyName = "contract_oil_no"
        Me.contract_oil_no.HeaderText = "เลขที่สัญญา"
        Me.contract_oil_no.Name = "contract_oil_no"
        Me.contract_oil_no.ReadOnly = True
        '
        'pay_id
        '
        Me.pay_id.DataPropertyName = "pay_id"
        Me.pay_id.HeaderText = "ลำดับที่ทำรายการ"
        Me.pay_id.Name = "pay_id"
        Me.pay_id.ReadOnly = True
        '
        'lb
        '
        Me.lb.AutoSize = True
        Me.lb.Location = New System.Drawing.Point(912, 72)
        Me.lb.Name = "lb"
        Me.lb.Size = New System.Drawing.Size(10, 13)
        Me.lb.TabIndex = 44
        Me.lb.Text = "-"
        Me.lb.Visible = False
        '
        'CC_oilpay
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.AliceBlue
        Me.ClientSize = New System.Drawing.Size(934, 664)
        Me.Controls.Add(Me.lb)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Label1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "CC_oilpay"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "ระบบบริหารจัดการกลุ่มออมทรัพย์หมู่บ้าน [ยกเลิกรายการชำระเงินค่าน้ำมัน]"
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txt_search As System.Windows.Forms.TextBox
    Friend WithEvents ToolStrip1 As System.Windows.Forms.ToolStrip
    Friend WithEvents tst_cancel As System.Windows.Forms.ToolStripSplitButton
    Friend WithEvents tst_allcancel As System.Windows.Forms.ToolStripSplitButton
    Friend WithEvents tst_back As System.Windows.Forms.ToolStripButton
    Friend WithEvents cbo_search2 As System.Windows.Forms.ComboBox
    Friend WithEvents btn_search As System.Windows.Forms.Button
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents txt_conid As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents dtp_1 As System.Windows.Forms.DateTimePicker
    Friend WithEvents txt_amount As System.Windows.Forms.TextBox
    Friend WithEvents txt_create As System.Windows.Forms.TextBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents txt_personalid As System.Windows.Forms.TextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents txt_fullname As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txt_id As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents cust_id As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents cust_fname As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents cust_lname As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents personal_id As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents pay_value As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents create_date As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents createby As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents contract_oil_no As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents pay_id As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents lb As System.Windows.Forms.Label
End Class

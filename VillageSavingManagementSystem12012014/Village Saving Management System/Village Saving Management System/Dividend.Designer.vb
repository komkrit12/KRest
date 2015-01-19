<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Dividend
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Dividend))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.tst_cal = New System.Windows.Forms.ToolStripSplitButton()
        Me.tst_save = New System.Windows.Forms.ToolStripSplitButton()
        Me.tst_clear = New System.Windows.Forms.ToolStripSplitButton()
        Me.tst_back = New System.Windows.Forms.ToolStripButton()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.txt_search = New System.Windows.Forms.TextBox()
        Me.cbo_search = New System.Windows.Forms.ComboBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.btn_Search = New System.Windows.Forms.Button()
        Me.txt_interest = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.cust_id = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cust_fname = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cust_lname = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cust_address = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.personal_id = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.occupation = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.txt_create = New System.Windows.Forms.TextBox()
        Me.txt_dividend = New System.Windows.Forms.TextBox()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.txt_balance = New System.Windows.Forms.TextBox()
        Me.txt_month = New System.Windows.Forms.TextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.txt_personalid = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.txt_vocation = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.txt_tel = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txt_address = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txt_lname = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txt_fname = New System.Windows.Forms.TextBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.txt_id = New System.Windows.Forms.TextBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.lb_reid = New System.Windows.Forms.Label()
        Me.ToolStrip1.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox3.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Cordia New", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label1.Location = New System.Drawing.Point(111, 109)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(221, 33)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "คำนวณเงินปันผลประจำปี"
        '
        'ToolStrip1
        '
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tst_cal, Me.tst_save, Me.tst_clear, Me.tst_back})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(934, 72)
        Me.ToolStrip1.TabIndex = 17
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'tst_cal
        '
        Me.tst_cal.Image = Global.Village_Saving_Management_System.My.Resources.Resources.cal_icon
        Me.tst_cal.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.tst_cal.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tst_cal.Name = "tst_cal"
        Me.tst_cal.Size = New System.Drawing.Size(66, 69)
        Me.tst_cal.Text = "คำนวณ"
        Me.tst_cal.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.tst_cal.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'tst_save
        '
        Me.tst_save.Image = Global.Village_Saving_Management_System.My.Resources.Resources.iconSave1
        Me.tst_save.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.tst_save.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tst_save.Name = "tst_save"
        Me.tst_save.Size = New System.Drawing.Size(66, 69)
        Me.tst_save.Text = "บันทึก"
        Me.tst_save.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'tst_clear
        '
        Me.tst_clear.Image = Global.Village_Saving_Management_System.My.Resources.Resources.clear_icon
        Me.tst_clear.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.tst_clear.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tst_clear.Name = "tst_clear"
        Me.tst_clear.Size = New System.Drawing.Size(66, 69)
        Me.tst_clear.Text = "ล้าง"
        Me.tst_clear.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.tst_clear.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'tst_back
        '
        Me.tst_back.Image = Global.Village_Saving_Management_System.My.Resources.Resources.home_icon
        Me.tst_back.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.tst_back.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.tst_back.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tst_back.Name = "tst_back"
        Me.tst_back.Size = New System.Drawing.Size(77, 69)
        Me.tst_back.Text = "กลับสู่หน้าหลัก"
        Me.tst_back.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.txt_search)
        Me.GroupBox1.Controls.Add(Me.cbo_search)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.btn_Search)
        Me.GroupBox1.Controls.Add(Me.txt_interest)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Location = New System.Drawing.Point(475, 75)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(420, 91)
        Me.GroupBox1.TabIndex = 18
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "อัตราเงินปันผล"
        '
        'txt_search
        '
        Me.txt_search.Location = New System.Drawing.Point(209, 51)
        Me.txt_search.Name = "txt_search"
        Me.txt_search.Size = New System.Drawing.Size(89, 20)
        Me.txt_search.TabIndex = 7
        '
        'cbo_search
        '
        Me.cbo_search.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.cbo_search.FormattingEnabled = True
        Me.cbo_search.Items.AddRange(New Object() {"ชื่อ", "รหัสสมาชิก", "เลขบัตรประชาชน"})
        Me.cbo_search.Location = New System.Drawing.Point(82, 51)
        Me.cbo_search.Name = "cbo_search"
        Me.cbo_search.Size = New System.Drawing.Size(121, 21)
        Me.cbo_search.TabIndex = 6
        Me.cbo_search.Text = "เลือกคำค้น"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label4.Location = New System.Drawing.Point(24, 54)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(52, 13)
        Me.Label4.TabIndex = 5
        Me.Label4.Text = "ค้นหาจาก"
        '
        'btn_Search
        '
        Me.btn_Search.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.btn_Search.Location = New System.Drawing.Point(319, 35)
        Me.btn_Search.Name = "btn_Search"
        Me.btn_Search.Size = New System.Drawing.Size(77, 36)
        Me.btn_Search.TabIndex = 4
        Me.btn_Search.Text = "ค้นหา"
        Me.btn_Search.UseVisualStyleBackColor = True
        '
        'txt_interest
        '
        Me.txt_interest.Enabled = False
        Me.txt_interest.Location = New System.Drawing.Point(209, 25)
        Me.txt_interest.Name = "txt_interest"
        Me.txt_interest.Size = New System.Drawing.Size(89, 20)
        Me.txt_interest.TabIndex = 1
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(24, 28)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(156, 13)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "อัตราปันผลเงินฝาก (ร้อยละ/ปี) : "
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.cust_id, Me.cust_fname, Me.cust_lname, Me.cust_address, Me.personal_id, Me.occupation})
        Me.DataGridView1.Location = New System.Drawing.Point(161, 195)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(643, 198)
        Me.DataGridView1.TabIndex = 20
        '
        'cust_id
        '
        Me.cust_id.DataPropertyName = "cust_id"
        Me.cust_id.HeaderText = "เลขที่สมาชิก"
        Me.cust_id.Name = "cust_id"
        '
        'cust_fname
        '
        Me.cust_fname.DataPropertyName = "cust_fname"
        Me.cust_fname.HeaderText = "ชื่อ"
        Me.cust_fname.Name = "cust_fname"
        '
        'cust_lname
        '
        Me.cust_lname.DataPropertyName = "cust_lname"
        Me.cust_lname.HeaderText = "นามสกุล"
        Me.cust_lname.Name = "cust_lname"
        '
        'cust_address
        '
        Me.cust_address.DataPropertyName = "cust_address"
        Me.cust_address.HeaderText = "ที่อยู่"
        Me.cust_address.Name = "cust_address"
        '
        'personal_id
        '
        Me.personal_id.DataPropertyName = "personal_id"
        Me.personal_id.HeaderText = "เลขบัตรประจำตัวประชาชน"
        Me.personal_id.Name = "personal_id"
        '
        'occupation
        '
        Me.occupation.DataPropertyName = "occupation"
        Me.occupation.HeaderText = "อาชีพ"
        Me.occupation.Name = "occupation"
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.txt_create)
        Me.GroupBox3.Controls.Add(Me.txt_dividend)
        Me.GroupBox3.Controls.Add(Me.Label15)
        Me.GroupBox3.Controls.Add(Me.txt_balance)
        Me.GroupBox3.Controls.Add(Me.txt_month)
        Me.GroupBox3.Controls.Add(Me.Label12)
        Me.GroupBox3.Controls.Add(Me.txt_personalid)
        Me.GroupBox3.Controls.Add(Me.Label11)
        Me.GroupBox3.Controls.Add(Me.txt_vocation)
        Me.GroupBox3.Controls.Add(Me.Label10)
        Me.GroupBox3.Controls.Add(Me.txt_tel)
        Me.GroupBox3.Controls.Add(Me.Label9)
        Me.GroupBox3.Controls.Add(Me.Label8)
        Me.GroupBox3.Controls.Add(Me.txt_address)
        Me.GroupBox3.Controls.Add(Me.Label7)
        Me.GroupBox3.Controls.Add(Me.txt_lname)
        Me.GroupBox3.Controls.Add(Me.Label6)
        Me.GroupBox3.Controls.Add(Me.Label5)
        Me.GroupBox3.Controls.Add(Me.txt_fname)
        Me.GroupBox3.Controls.Add(Me.Label13)
        Me.GroupBox3.Controls.Add(Me.txt_id)
        Me.GroupBox3.Controls.Add(Me.Label14)
        Me.GroupBox3.Location = New System.Drawing.Point(58, 399)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(825, 233)
        Me.GroupBox3.TabIndex = 21
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "ข้อมูลสมาชิกและการปันผลเงินฝากประจำปี"
        '
        'txt_create
        '
        Me.txt_create.Enabled = False
        Me.txt_create.Location = New System.Drawing.Point(444, 188)
        Me.txt_create.Name = "txt_create"
        Me.txt_create.Size = New System.Drawing.Size(114, 20)
        Me.txt_create.TabIndex = 25
        '
        'txt_dividend
        '
        Me.txt_dividend.Enabled = False
        Me.txt_dividend.Location = New System.Drawing.Point(153, 187)
        Me.txt_dividend.Name = "txt_dividend"
        Me.txt_dividend.Size = New System.Drawing.Size(114, 20)
        Me.txt_dividend.TabIndex = 24
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(25, 190)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(118, 13)
        Me.Label15.TabIndex = 23
        Me.Label15.Text = "ยอดเงินปันผลประจำปี : "
        '
        'txt_balance
        '
        Me.txt_balance.Enabled = False
        Me.txt_balance.Location = New System.Drawing.Point(444, 162)
        Me.txt_balance.Name = "txt_balance"
        Me.txt_balance.Size = New System.Drawing.Size(114, 20)
        Me.txt_balance.TabIndex = 21
        '
        'txt_month
        '
        Me.txt_month.Enabled = False
        Me.txt_month.Location = New System.Drawing.Point(153, 162)
        Me.txt_month.Name = "txt_month"
        Me.txt_month.Size = New System.Drawing.Size(114, 20)
        Me.txt_month.TabIndex = 20
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(259, 58)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(55, 13)
        Me.Label12.TabIndex = 19
        Me.Label12.Text = "นามสกุล : "
        '
        'txt_personalid
        '
        Me.txt_personalid.Enabled = False
        Me.txt_personalid.Location = New System.Drawing.Point(444, 136)
        Me.txt_personalid.Name = "txt_personalid"
        Me.txt_personalid.Size = New System.Drawing.Size(114, 20)
        Me.txt_personalid.TabIndex = 18
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(6, 165)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(137, 13)
        Me.Label11.TabIndex = 17
        Me.Label11.Text = "รายได้เฉลี่ยต่อเดือน (บาท) :"
        '
        'txt_vocation
        '
        Me.txt_vocation.Enabled = False
        Me.txt_vocation.Location = New System.Drawing.Point(444, 110)
        Me.txt_vocation.Name = "txt_vocation"
        Me.txt_vocation.Size = New System.Drawing.Size(114, 20)
        Me.txt_vocation.TabIndex = 16
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(301, 165)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(137, 13)
        Me.Label10.TabIndex = 15
        Me.Label10.Text = "ยอดเงินฝากคงเหลือ (บาท) : "
        '
        'txt_tel
        '
        Me.txt_tel.Enabled = False
        Me.txt_tel.Location = New System.Drawing.Point(444, 84)
        Me.txt_tel.Name = "txt_tel"
        Me.txt_tel.Size = New System.Drawing.Size(114, 20)
        Me.txt_tel.TabIndex = 14
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(378, 190)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(49, 13)
        Me.Label9.TabIndex = 13
        Me.Label9.Text = "ผู้บันทึก :"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(399, 113)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(39, 13)
        Me.Label8.TabIndex = 11
        Me.Label8.Text = "อาชีพ :"
        '
        'txt_address
        '
        Me.txt_address.Enabled = False
        Me.txt_address.Location = New System.Drawing.Point(88, 81)
        Me.txt_address.Multiline = True
        Me.txt_address.Name = "txt_address"
        Me.txt_address.Size = New System.Drawing.Size(179, 74)
        Me.txt_address.TabIndex = 10
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(301, 139)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(137, 13)
        Me.Label7.TabIndex = 9
        Me.Label7.Text = "เลขบัตรประจำตัวประชาชน :"
        '
        'txt_lname
        '
        Me.txt_lname.Enabled = False
        Me.txt_lname.Location = New System.Drawing.Point(315, 55)
        Me.txt_lname.Name = "txt_lname"
        Me.txt_lname.Size = New System.Drawing.Size(123, 20)
        Me.txt_lname.TabIndex = 8
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(360, 87)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(78, 13)
        Me.Label6.TabIndex = 7
        Me.Label6.Text = "เบอร์โทรศัพท์ :"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(46, 84)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(36, 13)
        Me.Label5.TabIndex = 5
        Me.Label5.Text = "ที่อยู่ : "
        '
        'txt_fname
        '
        Me.txt_fname.Enabled = False
        Me.txt_fname.Location = New System.Drawing.Point(88, 55)
        Me.txt_fname.Name = "txt_fname"
        Me.txt_fname.Size = New System.Drawing.Size(114, 20)
        Me.txt_fname.TabIndex = 3
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(56, 58)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(26, 13)
        Me.Label13.TabIndex = 2
        Me.Label13.Text = "ชื่อ :"
        '
        'txt_id
        '
        Me.txt_id.Enabled = False
        Me.txt_id.Location = New System.Drawing.Point(88, 30)
        Me.txt_id.Name = "txt_id"
        Me.txt_id.Size = New System.Drawing.Size(80, 20)
        Me.txt_id.TabIndex = 1
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(10, 33)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(72, 13)
        Me.Label14.TabIndex = 0
        Me.Label14.Text = "เลขที่สมาชิก : "
        '
        'lb_reid
        '
        Me.lb_reid.AutoSize = True
        Me.lb_reid.Location = New System.Drawing.Point(912, 75)
        Me.lb_reid.Name = "lb_reid"
        Me.lb_reid.Size = New System.Drawing.Size(10, 13)
        Me.lb_reid.TabIndex = 8
        Me.lb_reid.Text = "-"
        Me.lb_reid.Visible = False
        '
        'Dividend
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.AliceBlue
        Me.ClientSize = New System.Drawing.Size(934, 664)
        Me.Controls.Add(Me.lb_reid)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Controls.Add(Me.Label1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Dividend"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "ระบบบริหารจัดการกลุ่มออมทรัพย์หมู่บ้าน [บันทึกการปันผลประจำปี]"
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents ToolStrip1 As System.Windows.Forms.ToolStrip
    Friend WithEvents tst_save As System.Windows.Forms.ToolStripSplitButton
    Friend WithEvents tst_back As System.Windows.Forms.ToolStripButton
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents btn_Search As System.Windows.Forms.Button
    Friend WithEvents txt_interest As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents cbo_search As System.Windows.Forms.ComboBox
    Friend WithEvents txt_search As System.Windows.Forms.TextBox
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents txt_balance As System.Windows.Forms.TextBox
    Friend WithEvents txt_month As System.Windows.Forms.TextBox
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents txt_personalid As System.Windows.Forms.TextBox
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents txt_vocation As System.Windows.Forms.TextBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents txt_tel As System.Windows.Forms.TextBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents txt_address As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents txt_lname As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents txt_fname As System.Windows.Forms.TextBox
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents txt_id As System.Windows.Forms.TextBox
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents tst_cal As System.Windows.Forms.ToolStripSplitButton
    Friend WithEvents txt_dividend As System.Windows.Forms.TextBox
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents cust_id As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents cust_fname As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents cust_lname As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents cust_address As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents personal_id As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents occupation As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents txt_create As System.Windows.Forms.TextBox
    Friend WithEvents tst_clear As System.Windows.Forms.ToolStripSplitButton
    Friend WithEvents lb_reid As System.Windows.Forms.Label
End Class

<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class cancel
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(cancel))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.cust_id = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cust_fname = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cust_lname = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.personal_id = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.occupation = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cust_address = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.tel = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.age = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.earnings_month = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.txt_age = New System.Windows.Forms.TextBox()
        Me.txt_month = New System.Windows.Forms.TextBox()
        Me.txt_vocation = New System.Windows.Forms.TextBox()
        Me.txt_personalid = New System.Windows.Forms.TextBox()
        Me.Label26 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.txt_tel = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txt_address = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txt_fullname = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txt_id = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txt_conid = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.tst_cancel = New System.Windows.Forms.ToolStripSplitButton()
        Me.tst_allcancel = New System.Windows.Forms.ToolStripSplitButton()
        Me.tst_back = New System.Windows.Forms.ToolStripButton()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txt_search = New System.Windows.Forms.TextBox()
        Me.cbo_search2 = New System.Windows.Forms.ComboBox()
        Me.btn_search = New System.Windows.Forms.Button()
        Me.cbo_search = New System.Windows.Forms.ComboBox()
        Me.Label14 = New System.Windows.Forms.Label()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.ToolStrip1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Cordia New", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label1.Location = New System.Drawing.Point(148, 115)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(70, 33)
        Me.Label1.TabIndex = 13
        Me.Label1.Text = "ยกเลิก"
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.cust_id, Me.cust_fname, Me.cust_lname, Me.personal_id, Me.occupation, Me.cust_address, Me.tel, Me.age, Me.earnings_month})
        Me.DataGridView1.Location = New System.Drawing.Point(139, 185)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.DataGridView1.Size = New System.Drawing.Size(539, 189)
        Me.DataGridView1.TabIndex = 14
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
        Me.personal_id.HeaderText = "เลขบัตรประชาชน"
        Me.personal_id.Name = "personal_id"
        Me.personal_id.ReadOnly = True
        '
        'occupation
        '
        Me.occupation.DataPropertyName = "occupation"
        Me.occupation.HeaderText = "อาชีพ"
        Me.occupation.Name = "occupation"
        Me.occupation.ReadOnly = True
        '
        'cust_address
        '
        Me.cust_address.DataPropertyName = "cust_address"
        Me.cust_address.HeaderText = "ที่อยู่"
        Me.cust_address.Name = "cust_address"
        Me.cust_address.ReadOnly = True
        '
        'tel
        '
        Me.tel.DataPropertyName = "tel"
        Me.tel.HeaderText = "เบอร์โทรศัพท์"
        Me.tel.Name = "tel"
        Me.tel.ReadOnly = True
        '
        'age
        '
        Me.age.DataPropertyName = "age"
        Me.age.HeaderText = "อายุ (ปี)"
        Me.age.Name = "age"
        Me.age.ReadOnly = True
        '
        'earnings_month
        '
        Me.earnings_month.DataPropertyName = "earnings_month"
        Me.earnings_month.HeaderText = "รายได้เฉลี่ยต่อเดือน (บาท)"
        Me.earnings_month.Name = "earnings_month"
        Me.earnings_month.ReadOnly = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.txt_age)
        Me.GroupBox1.Controls.Add(Me.txt_month)
        Me.GroupBox1.Controls.Add(Me.txt_vocation)
        Me.GroupBox1.Controls.Add(Me.txt_personalid)
        Me.GroupBox1.Controls.Add(Me.Label26)
        Me.GroupBox1.Controls.Add(Me.Label10)
        Me.GroupBox1.Controls.Add(Me.Label9)
        Me.GroupBox1.Controls.Add(Me.txt_tel)
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Controls.Add(Me.txt_address)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.txt_fullname)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.txt_id)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.txt_conid)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Location = New System.Drawing.Point(60, 389)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(704, 235)
        Me.GroupBox1.TabIndex = 15
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "ข้อมูลสมาชิก"
        '
        'txt_age
        '
        Me.txt_age.Enabled = False
        Me.txt_age.Location = New System.Drawing.Point(110, 165)
        Me.txt_age.Name = "txt_age"
        Me.txt_age.Size = New System.Drawing.Size(61, 20)
        Me.txt_age.TabIndex = 41
        '
        'txt_month
        '
        Me.txt_month.Enabled = False
        Me.txt_month.Location = New System.Drawing.Point(414, 188)
        Me.txt_month.Name = "txt_month"
        Me.txt_month.Size = New System.Drawing.Size(82, 20)
        Me.txt_month.TabIndex = 30
        '
        'txt_vocation
        '
        Me.txt_vocation.Enabled = False
        Me.txt_vocation.Location = New System.Drawing.Point(110, 139)
        Me.txt_vocation.Name = "txt_vocation"
        Me.txt_vocation.Size = New System.Drawing.Size(113, 20)
        Me.txt_vocation.TabIndex = 29
        '
        'txt_personalid
        '
        Me.txt_personalid.Enabled = False
        Me.txt_personalid.Location = New System.Drawing.Point(414, 162)
        Me.txt_personalid.Name = "txt_personalid"
        Me.txt_personalid.Size = New System.Drawing.Size(140, 20)
        Me.txt_personalid.TabIndex = 27
        '
        'Label26
        '
        Me.Label26.AutoSize = True
        Me.Label26.Location = New System.Drawing.Point(29, 36)
        Me.Label26.Name = "Label26"
        Me.Label26.Size = New System.Drawing.Size(69, 13)
        Me.Label26.TabIndex = 25
        Me.Label26.Text = "เลขที่สัญญา : "
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(268, 191)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(137, 13)
        Me.Label10.TabIndex = 16
        Me.Label10.Text = "รายได้เฉลี่ยต่อเดือน (บาท) :"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(56, 143)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(42, 13)
        Me.Label9.TabIndex = 14
        Me.Label9.Text = "อาชีพ : "
        '
        'txt_tel
        '
        Me.txt_tel.Enabled = False
        Me.txt_tel.Location = New System.Drawing.Point(110, 113)
        Me.txt_tel.Name = "txt_tel"
        Me.txt_tel.Size = New System.Drawing.Size(113, 20)
        Me.txt_tel.TabIndex = 13
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(268, 165)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(140, 13)
        Me.Label8.TabIndex = 12
        Me.Label8.Text = "เลขบัตรประจำตัวประชาชน : "
        '
        'txt_address
        '
        Me.txt_address.Enabled = False
        Me.txt_address.Location = New System.Drawing.Point(414, 88)
        Me.txt_address.Multiline = True
        Me.txt_address.Name = "txt_address"
        Me.txt_address.Size = New System.Drawing.Size(175, 68)
        Me.txt_address.TabIndex = 11
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(17, 116)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(81, 13)
        Me.Label7.TabIndex = 10
        Me.Label7.Text = "เบอร์โทรศัพท์ : "
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(372, 91)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(36, 13)
        Me.Label6.TabIndex = 8
        Me.Label6.Text = "ที่อยู่ : "
        '
        'txt_fullname
        '
        Me.txt_fullname.Enabled = False
        Me.txt_fullname.Location = New System.Drawing.Point(110, 88)
        Me.txt_fullname.Name = "txt_fullname"
        Me.txt_fullname.Size = New System.Drawing.Size(217, 20)
        Me.txt_fullname.TabIndex = 6
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(48, 169)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(50, 13)
        Me.Label4.TabIndex = 5
        Me.Label4.Text = "อายุ (ปี) : "
        '
        'txt_id
        '
        Me.txt_id.Enabled = False
        Me.txt_id.Location = New System.Drawing.Point(110, 62)
        Me.txt_id.Name = "txt_id"
        Me.txt_id.Size = New System.Drawing.Size(91, 20)
        Me.txt_id.TabIndex = 4
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(26, 65)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(72, 13)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "เลขที่สมาชิก : "
        '
        'txt_conid
        '
        Me.txt_conid.Enabled = False
        Me.txt_conid.Location = New System.Drawing.Point(110, 36)
        Me.txt_conid.Name = "txt_conid"
        Me.txt_conid.Size = New System.Drawing.Size(91, 20)
        Me.txt_conid.TabIndex = 2
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(21, 91)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(77, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "ชื่อ - นามสกุล : "
        '
        'ToolStrip1
        '
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tst_cancel, Me.tst_allcancel, Me.tst_back})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(934, 72)
        Me.ToolStrip1.TabIndex = 16
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
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.Label5)
        Me.GroupBox2.Controls.Add(Me.txt_search)
        Me.GroupBox2.Controls.Add(Me.cbo_search2)
        Me.GroupBox2.Controls.Add(Me.btn_search)
        Me.GroupBox2.Controls.Add(Me.cbo_search)
        Me.GroupBox2.Controls.Add(Me.Label14)
        Me.GroupBox2.Location = New System.Drawing.Point(331, 86)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(449, 83)
        Me.GroupBox2.TabIndex = 20
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "ค้นหา"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(74, 49)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(61, 13)
        Me.Label5.TabIndex = 6
        Me.Label5.Text = "ค้นหาจาก : "
        '
        'txt_search
        '
        Me.txt_search.Location = New System.Drawing.Point(246, 46)
        Me.txt_search.Name = "txt_search"
        Me.txt_search.Size = New System.Drawing.Size(101, 20)
        Me.txt_search.TabIndex = 5
        '
        'cbo_search2
        '
        Me.cbo_search2.FormattingEnabled = True
        Me.cbo_search2.Items.AddRange(New Object() {"ชื่อ", "รหัสสมาชิก", "เลขบัตรประชาชน"})
        Me.cbo_search2.Location = New System.Drawing.Point(141, 46)
        Me.cbo_search2.Name = "cbo_search2"
        Me.cbo_search2.Size = New System.Drawing.Size(99, 21)
        Me.cbo_search2.TabIndex = 4
        Me.cbo_search2.Text = "เลือกคำค้น"
        '
        'btn_search
        '
        Me.btn_search.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.btn_search.ImageAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btn_search.Location = New System.Drawing.Point(353, 21)
        Me.btn_search.Name = "btn_search"
        Me.btn_search.Size = New System.Drawing.Size(75, 37)
        Me.btn_search.TabIndex = 3
        Me.btn_search.Text = "ค้นหา"
        Me.btn_search.UseVisualStyleBackColor = True
        '
        'cbo_search
        '
        Me.cbo_search.FormattingEnabled = True
        Me.cbo_search.Items.AddRange(New Object() {"ข้อมูลสมาชิก", "ฝาก", "ถอน", "สัญญาเงินกู้", "ชำระเงินกู้", "รับปุ๋ยเข้าสต๊อก", "สัญญากู้ปุ๋ย", "ชำระค่าปุ๋ย", "รับน้ำมันเข้าสต๊อก", "สัญญากู้น้ำมัน", "ชำระค่าน้ำมัน"})
        Me.cbo_search.Location = New System.Drawing.Point(141, 19)
        Me.cbo_search.Name = "cbo_search"
        Me.cbo_search.Size = New System.Drawing.Size(99, 21)
        Me.cbo_search.TabIndex = 1
        Me.cbo_search.Text = "เลือกคำค้น"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label14.Location = New System.Drawing.Point(21, 25)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(114, 13)
        Me.Label14.TabIndex = 0
        Me.Label14.Text = "รายการที่ต้องการแจ้ง : "
        '
        'cancel
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.AliceBlue
        Me.ClientSize = New System.Drawing.Size(934, 664)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.Label1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "cancel"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "ระบบบริหารจัดการกลุ่มออมทรัพย์หมู่บ้าน [ยกเลิกสัญญาเงินกู้]"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents txt_age As System.Windows.Forms.TextBox
    Friend WithEvents txt_month As System.Windows.Forms.TextBox
    Friend WithEvents txt_vocation As System.Windows.Forms.TextBox
    Friend WithEvents txt_personalid As System.Windows.Forms.TextBox
    Friend WithEvents Label26 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents txt_tel As System.Windows.Forms.TextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents txt_address As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents txt_fullname As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txt_id As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txt_conid As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents ToolStrip1 As System.Windows.Forms.ToolStrip
    Friend WithEvents tst_cancel As System.Windows.Forms.ToolStripSplitButton
    Friend WithEvents tst_allcancel As System.Windows.Forms.ToolStripSplitButton
    Friend WithEvents tst_back As System.Windows.Forms.ToolStripButton
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents txt_search As System.Windows.Forms.TextBox
    Friend WithEvents cbo_search2 As System.Windows.Forms.ComboBox
    Friend WithEvents btn_search As System.Windows.Forms.Button
    Friend WithEvents cbo_search As System.Windows.Forms.ComboBox
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents cust_id As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents cust_fname As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents cust_lname As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents personal_id As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents occupation As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents cust_address As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents tel As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents age As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents earnings_month As System.Windows.Forms.DataGridViewTextBoxColumn
End Class

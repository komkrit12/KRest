<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class NC_customers
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(NC_customers))
        Me.txt_age = New System.Windows.Forms.TextBox()
        Me.txt_month = New System.Windows.Forms.TextBox()
        Me.txt_vocation = New System.Windows.Forms.TextBox()
        Me.txt_personalid = New System.Windows.Forms.TextBox()
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
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txt_search = New System.Windows.Forms.TextBox()
        Me.cbo_search2 = New System.Windows.Forms.ComboBox()
        Me.btn_search = New System.Windows.Forms.Button()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.cust_id = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cust_fname = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cust_lname = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.personal_id = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.occupation = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.age = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cust_address = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.tel = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.earnings_month = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.tst_cancel = New System.Windows.Forms.ToolStripSplitButton()
        Me.tst_back = New System.Windows.Forms.ToolStripButton()
        Me.GroupBox2.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.ToolStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'txt_age
        '
        Me.txt_age.Enabled = False
        Me.txt_age.Location = New System.Drawing.Point(114, 131)
        Me.txt_age.Name = "txt_age"
        Me.txt_age.Size = New System.Drawing.Size(61, 20)
        Me.txt_age.TabIndex = 41
        '
        'txt_month
        '
        Me.txt_month.Enabled = False
        Me.txt_month.Location = New System.Drawing.Point(418, 154)
        Me.txt_month.Name = "txt_month"
        Me.txt_month.Size = New System.Drawing.Size(82, 20)
        Me.txt_month.TabIndex = 30
        '
        'txt_vocation
        '
        Me.txt_vocation.Enabled = False
        Me.txt_vocation.Location = New System.Drawing.Point(114, 105)
        Me.txt_vocation.Name = "txt_vocation"
        Me.txt_vocation.Size = New System.Drawing.Size(113, 20)
        Me.txt_vocation.TabIndex = 29
        '
        'txt_personalid
        '
        Me.txt_personalid.Enabled = False
        Me.txt_personalid.Location = New System.Drawing.Point(418, 128)
        Me.txt_personalid.Name = "txt_personalid"
        Me.txt_personalid.Size = New System.Drawing.Size(140, 20)
        Me.txt_personalid.TabIndex = 27
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(272, 157)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(137, 13)
        Me.Label10.TabIndex = 16
        Me.Label10.Text = "รายได้เฉลี่ยต่อเดือน (บาท) :"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(60, 109)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(42, 13)
        Me.Label9.TabIndex = 14
        Me.Label9.Text = "อาชีพ : "
        '
        'txt_tel
        '
        Me.txt_tel.Enabled = False
        Me.txt_tel.Location = New System.Drawing.Point(114, 79)
        Me.txt_tel.Name = "txt_tel"
        Me.txt_tel.Size = New System.Drawing.Size(113, 20)
        Me.txt_tel.TabIndex = 13
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(272, 131)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(140, 13)
        Me.Label8.TabIndex = 12
        Me.Label8.Text = "เลขบัตรประจำตัวประชาชน : "
        '
        'txt_address
        '
        Me.txt_address.Enabled = False
        Me.txt_address.Location = New System.Drawing.Point(418, 54)
        Me.txt_address.Multiline = True
        Me.txt_address.Name = "txt_address"
        Me.txt_address.Size = New System.Drawing.Size(175, 68)
        Me.txt_address.TabIndex = 11
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(21, 82)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(81, 13)
        Me.Label7.TabIndex = 10
        Me.Label7.Text = "เบอร์โทรศัพท์ : "
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(376, 57)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(36, 13)
        Me.Label6.TabIndex = 8
        Me.Label6.Text = "ที่อยู่ : "
        '
        'txt_fullname
        '
        Me.txt_fullname.Enabled = False
        Me.txt_fullname.Location = New System.Drawing.Point(114, 54)
        Me.txt_fullname.Name = "txt_fullname"
        Me.txt_fullname.Size = New System.Drawing.Size(217, 20)
        Me.txt_fullname.TabIndex = 6
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(52, 135)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(50, 13)
        Me.Label4.TabIndex = 5
        Me.Label4.Text = "อายุ (ปี) : "
        '
        'txt_id
        '
        Me.txt_id.Enabled = False
        Me.txt_id.Location = New System.Drawing.Point(114, 28)
        Me.txt_id.Name = "txt_id"
        Me.txt_id.Size = New System.Drawing.Size(91, 20)
        Me.txt_id.TabIndex = 4
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(30, 31)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(72, 13)
        Me.Label5.TabIndex = 3
        Me.Label5.Text = "เลขที่สมาชิก : "
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(25, 57)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(77, 13)
        Me.Label11.TabIndex = 1
        Me.Label11.Text = "ชื่อ - นามสกุล : "
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.txt_age)
        Me.GroupBox2.Controls.Add(Me.txt_month)
        Me.GroupBox2.Controls.Add(Me.txt_vocation)
        Me.GroupBox2.Controls.Add(Me.txt_personalid)
        Me.GroupBox2.Controls.Add(Me.Label10)
        Me.GroupBox2.Controls.Add(Me.Label9)
        Me.GroupBox2.Controls.Add(Me.txt_tel)
        Me.GroupBox2.Controls.Add(Me.Label8)
        Me.GroupBox2.Controls.Add(Me.txt_address)
        Me.GroupBox2.Controls.Add(Me.Label7)
        Me.GroupBox2.Controls.Add(Me.Label6)
        Me.GroupBox2.Controls.Add(Me.txt_fullname)
        Me.GroupBox2.Controls.Add(Me.Label4)
        Me.GroupBox2.Controls.Add(Me.txt_id)
        Me.GroupBox2.Controls.Add(Me.Label5)
        Me.GroupBox2.Controls.Add(Me.Label11)
        Me.GroupBox2.Location = New System.Drawing.Point(76, 431)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(774, 207)
        Me.GroupBox2.TabIndex = 26
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "ข้อมูลสมาชิก"
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
        'txt_search
        '
        Me.txt_search.Location = New System.Drawing.Point(197, 31)
        Me.txt_search.Name = "txt_search"
        Me.txt_search.Size = New System.Drawing.Size(101, 20)
        Me.txt_search.TabIndex = 5
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
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.cust_id, Me.cust_fname, Me.cust_lname, Me.personal_id, Me.occupation, Me.age, Me.cust_address, Me.tel, Me.earnings_month})
        Me.DataGridView1.Location = New System.Drawing.Point(131, 182)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.DataGridView1.Size = New System.Drawing.Size(693, 234)
        Me.DataGridView1.TabIndex = 25
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Cordia New", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label1.Location = New System.Drawing.Point(143, 118)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(160, 33)
        Me.Label1.TabIndex = 23
        Me.Label1.Text = "แจ้งยกเลิกสมาชิก"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.txt_search)
        Me.GroupBox1.Controls.Add(Me.cbo_search2)
        Me.GroupBox1.Controls.Add(Me.btn_search)
        Me.GroupBox1.Location = New System.Drawing.Point(408, 88)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(416, 76)
        Me.GroupBox1.TabIndex = 24
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "ค้นหา"
        '
        'ToolStrip1
        '
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tst_cancel, Me.tst_back})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(934, 72)
        Me.ToolStrip1.TabIndex = 22
        Me.ToolStrip1.Text = "ToolStrip1"
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
        'occupation
        '
        Me.occupation.DataPropertyName = "occupation"
        Me.occupation.HeaderText = "อาชีพ"
        Me.occupation.Name = "occupation"
        Me.occupation.ReadOnly = True
        '
        'age
        '
        Me.age.DataPropertyName = "age"
        Me.age.HeaderText = "อายุ (ปี)"
        Me.age.Name = "age"
        Me.age.ReadOnly = True
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
        'earnings_month
        '
        Me.earnings_month.DataPropertyName = "earnings_month"
        Me.earnings_month.HeaderText = "รายได้เฉลี่ยต่อเดือน (บาท)"
        Me.earnings_month.Name = "earnings_month"
        Me.earnings_month.ReadOnly = True
        '
        'tst_cancel
        '
        Me.tst_cancel.Image = Global.Village_Saving_Management_System.My.Resources.Resources.notification
        Me.tst_cancel.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.tst_cancel.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.tst_cancel.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tst_cancel.Name = "tst_cancel"
        Me.tst_cancel.Size = New System.Drawing.Size(92, 69)
        Me.tst_cancel.Text = "แจ้งการยกเลิก"
        Me.tst_cancel.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.tst_cancel.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
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
        'NC_customers
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.AliceBlue
        Me.ClientSize = New System.Drawing.Size(934, 664)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "NC_customers"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "ระบบบริหารจัดการกลุ่มออมทรัพย์หมู่บ้าน [แจ้งยกเลิกสมาชิก]"
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txt_age As System.Windows.Forms.TextBox
    Friend WithEvents txt_month As System.Windows.Forms.TextBox
    Friend WithEvents txt_vocation As System.Windows.Forms.TextBox
    Friend WithEvents txt_personalid As System.Windows.Forms.TextBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents tst_cancel As System.Windows.Forms.ToolStripSplitButton
    Friend WithEvents txt_tel As System.Windows.Forms.TextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents txt_address As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents txt_fullname As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txt_id As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txt_search As System.Windows.Forms.TextBox
    Friend WithEvents cbo_search2 As System.Windows.Forms.ComboBox
    Friend WithEvents btn_search As System.Windows.Forms.Button
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents tst_back As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStrip1 As System.Windows.Forms.ToolStrip
    Friend WithEvents cust_id As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents cust_fname As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents cust_lname As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents personal_id As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents occupation As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents age As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents cust_address As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents tel As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents earnings_month As System.Windows.Forms.DataGridViewTextBoxColumn
End Class

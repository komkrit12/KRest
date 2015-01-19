<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Withdrawal
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Withdrawal))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.tst_save = New System.Windows.Forms.ToolStripSplitButton()
        Me.tst_clear = New System.Windows.Forms.ToolStripSplitButton()
        Me.tst_back = New System.Windows.Forms.ToolStripButton()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.btn_search = New System.Windows.Forms.Button()
        Me.txt_search = New System.Windows.Forms.TextBox()
        Me.cbo_search = New System.Windows.Forms.ComboBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.txt_lname = New System.Windows.Forms.TextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.txt_balance = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txt_personalid = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txt_address = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txt_fname = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txt_id = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.txt_create = New System.Windows.Forms.TextBox()
        Me.txt_wd = New System.Windows.Forms.TextBox()
        Me.dtp_time = New System.Windows.Forms.DateTimePicker()
        Me.deposit_create = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.cust_id = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cust_fname = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cust_lname = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cust_address = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.tel = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.occupation = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.personal_id = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.lb_reid = New System.Windows.Forms.Label()
        Me.ToolStrip1.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Cordia New", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label1.Location = New System.Drawing.Point(146, 91)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(163, 33)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "บันทึกการถอนเงิน"
        '
        'ToolStrip1
        '
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tst_save, Me.tst_clear, Me.tst_back})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(934, 72)
        Me.ToolStrip1.TabIndex = 18
        Me.ToolStrip1.Text = "ToolStrip1"
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
        Me.tst_clear.ImageAlign = System.Drawing.ContentAlignment.TopCenter
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
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.btn_search)
        Me.GroupBox3.Controls.Add(Me.txt_search)
        Me.GroupBox3.Controls.Add(Me.cbo_search)
        Me.GroupBox3.Controls.Add(Me.Label11)
        Me.GroupBox3.Location = New System.Drawing.Point(438, 75)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(425, 75)
        Me.GroupBox3.TabIndex = 20
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "ค้นหาสมาชิก"
        '
        'btn_search
        '
        Me.btn_search.Location = New System.Drawing.Point(341, 23)
        Me.btn_search.Name = "btn_search"
        Me.btn_search.Size = New System.Drawing.Size(75, 31)
        Me.btn_search.TabIndex = 3
        Me.btn_search.Text = "ค้นหา"
        Me.btn_search.UseVisualStyleBackColor = True
        '
        'txt_search
        '
        Me.txt_search.Location = New System.Drawing.Point(204, 29)
        Me.txt_search.Name = "txt_search"
        Me.txt_search.Size = New System.Drawing.Size(130, 20)
        Me.txt_search.TabIndex = 2
        '
        'cbo_search
        '
        Me.cbo_search.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.cbo_search.FormattingEnabled = True
        Me.cbo_search.Items.AddRange(New Object() {"ชื่อ", "รหัสสมาชิก", "เลขบัตรประชาชน"})
        Me.cbo_search.Location = New System.Drawing.Point(76, 28)
        Me.cbo_search.Name = "cbo_search"
        Me.cbo_search.Size = New System.Drawing.Size(121, 21)
        Me.cbo_search.TabIndex = 1
        Me.cbo_search.Text = "เลือกคำค้น"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label11.Location = New System.Drawing.Point(18, 32)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(52, 13)
        Me.Label11.TabIndex = 0
        Me.Label11.Text = "ค้นหาจาก"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.txt_lname)
        Me.GroupBox1.Controls.Add(Me.Label12)
        Me.GroupBox1.Controls.Add(Me.txt_balance)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.txt_personalid)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.txt_address)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.txt_fname)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.txt_id)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Location = New System.Drawing.Point(68, 367)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(795, 196)
        Me.GroupBox1.TabIndex = 24
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "ข้อมูลผู้ฝาก"
        '
        'txt_lname
        '
        Me.txt_lname.Enabled = False
        Me.txt_lname.Location = New System.Drawing.Point(448, 49)
        Me.txt_lname.Name = "txt_lname"
        Me.txt_lname.Size = New System.Drawing.Size(148, 20)
        Me.txt_lname.TabIndex = 11
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(387, 52)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(55, 13)
        Me.Label12.TabIndex = 10
        Me.Label12.Text = "นามสกุล : "
        '
        'txt_balance
        '
        Me.txt_balance.Enabled = False
        Me.txt_balance.Location = New System.Drawing.Point(448, 158)
        Me.txt_balance.Name = "txt_balance"
        Me.txt_balance.Size = New System.Drawing.Size(76, 20)
        Me.txt_balance.TabIndex = 9
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(320, 165)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(128, 13)
        Me.Label6.TabIndex = 8
        Me.Label6.Text = "ยอดเงินฝากที่มีอยู่ (บาท) : "
        '
        'txt_personalid
        '
        Me.txt_personalid.Enabled = False
        Me.txt_personalid.Location = New System.Drawing.Point(161, 162)
        Me.txt_personalid.Name = "txt_personalid"
        Me.txt_personalid.Size = New System.Drawing.Size(142, 20)
        Me.txt_personalid.TabIndex = 7
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(35, 165)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(128, 13)
        Me.Label5.TabIndex = 6
        Me.Label5.Text = "เลขบัตรประจำตัวประชน : "
        '
        'txt_address
        '
        Me.txt_address.Enabled = False
        Me.txt_address.Location = New System.Drawing.Point(161, 75)
        Me.txt_address.Multiline = True
        Me.txt_address.Name = "txt_address"
        Me.txt_address.Size = New System.Drawing.Size(181, 80)
        Me.txt_address.TabIndex = 5
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(119, 82)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(36, 13)
        Me.Label4.TabIndex = 4
        Me.Label4.Text = "ที่อยู่ : "
        '
        'txt_fname
        '
        Me.txt_fname.Enabled = False
        Me.txt_fname.Location = New System.Drawing.Point(161, 49)
        Me.txt_fname.Name = "txt_fname"
        Me.txt_fname.Size = New System.Drawing.Size(142, 20)
        Me.txt_fname.TabIndex = 3
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(126, 52)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(29, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "ชื่อ : "
        '
        'txt_id
        '
        Me.txt_id.Enabled = False
        Me.txt_id.Location = New System.Drawing.Point(161, 23)
        Me.txt_id.Name = "txt_id"
        Me.txt_id.Size = New System.Drawing.Size(101, 20)
        Me.txt_id.TabIndex = 1
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(83, 26)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(72, 13)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "เลขที่สมาชิก : "
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.txt_create)
        Me.GroupBox2.Controls.Add(Me.txt_wd)
        Me.GroupBox2.Controls.Add(Me.dtp_time)
        Me.GroupBox2.Controls.Add(Me.deposit_create)
        Me.GroupBox2.Controls.Add(Me.Label9)
        Me.GroupBox2.Controls.Add(Me.Label8)
        Me.GroupBox2.Location = New System.Drawing.Point(68, 572)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(795, 80)
        Me.GroupBox2.TabIndex = 25
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "ข้อมูลการฝาก"
        '
        'txt_create
        '
        Me.txt_create.Enabled = False
        Me.txt_create.Location = New System.Drawing.Point(161, 47)
        Me.txt_create.Name = "txt_create"
        Me.txt_create.Size = New System.Drawing.Size(159, 20)
        Me.txt_create.TabIndex = 10
        '
        'txt_wd
        '
        Me.txt_wd.Location = New System.Drawing.Point(161, 21)
        Me.txt_wd.Name = "txt_wd"
        Me.txt_wd.Size = New System.Drawing.Size(101, 20)
        Me.txt_wd.TabIndex = 9
        '
        'dtp_time
        '
        Me.dtp_time.Enabled = False
        Me.dtp_time.Location = New System.Drawing.Point(448, 47)
        Me.dtp_time.Name = "dtp_time"
        Me.dtp_time.Size = New System.Drawing.Size(135, 20)
        Me.dtp_time.TabIndex = 8
        '
        'deposit_create
        '
        Me.deposit_create.AutoSize = True
        Me.deposit_create.Location = New System.Drawing.Point(90, 47)
        Me.deposit_create.Name = "deposit_create"
        Me.deposit_create.Size = New System.Drawing.Size(65, 13)
        Me.deposit_create.TabIndex = 6
        Me.deposit_create.Text = "ชื่อผู้บันทึก : "
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(54, 24)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(101, 13)
        Me.Label9.TabIndex = 4
        Me.Label9.Text = "ต้องการถอน (บาท) : "
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(384, 47)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(56, 13)
        Me.Label8.TabIndex = 2
        Me.Label8.Text = "วันที่ฝาก : "
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.cust_id, Me.cust_fname, Me.cust_lname, Me.cust_address, Me.tel, Me.occupation, Me.personal_id})
        Me.DataGridView1.Location = New System.Drawing.Point(152, 156)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(643, 205)
        Me.DataGridView1.TabIndex = 26
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
        'occupation
        '
        Me.occupation.DataPropertyName = "occupation"
        Me.occupation.HeaderText = "อาชีพ"
        Me.occupation.Name = "occupation"
        Me.occupation.ReadOnly = True
        '
        'personal_id
        '
        Me.personal_id.DataPropertyName = "personal_id"
        Me.personal_id.HeaderText = "เลขบัตรประจำตัวประชาชน"
        Me.personal_id.Name = "personal_id"
        Me.personal_id.ReadOnly = True
        '
        'lb_reid
        '
        Me.lb_reid.AutoSize = True
        Me.lb_reid.Location = New System.Drawing.Point(912, 72)
        Me.lb_reid.Name = "lb_reid"
        Me.lb_reid.Size = New System.Drawing.Size(10, 13)
        Me.lb_reid.TabIndex = 27
        Me.lb_reid.Text = "-"
        Me.lb_reid.Visible = False
        '
        'Withdrawal
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.AliceBlue
        Me.ClientSize = New System.Drawing.Size(934, 664)
        Me.Controls.Add(Me.lb_reid)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Controls.Add(Me.Label1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Withdrawal"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "ระบบบริหารจัดการกลุ่มออมทรัพย์หมู่บ้าน [บันทึกการถอนเงิน]"
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents ToolStrip1 As System.Windows.Forms.ToolStrip
    Friend WithEvents tst_save As System.Windows.Forms.ToolStripSplitButton
    Friend WithEvents tst_back As System.Windows.Forms.ToolStripButton
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents btn_search As System.Windows.Forms.Button
    Friend WithEvents txt_search As System.Windows.Forms.TextBox
    Friend WithEvents cbo_search As System.Windows.Forms.ComboBox
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents tst_clear As System.Windows.Forms.ToolStripSplitButton
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents txt_lname As System.Windows.Forms.TextBox
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents txt_balance As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents txt_personalid As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents txt_address As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txt_fname As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txt_id As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents txt_create As System.Windows.Forms.TextBox
    Friend WithEvents txt_wd As System.Windows.Forms.TextBox
    Friend WithEvents dtp_time As System.Windows.Forms.DateTimePicker
    Friend WithEvents deposit_create As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents lb_reid As System.Windows.Forms.Label
    Friend WithEvents cust_id As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents cust_fname As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents cust_lname As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents cust_address As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents tel As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents occupation As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents personal_id As System.Windows.Forms.DataGridViewTextBoxColumn
End Class

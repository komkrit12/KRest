<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Village_Saving
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Village_Saving))
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.tst_save = New System.Windows.Forms.ToolStripSplitButton()
        Me.tst_edit = New System.Windows.Forms.ToolStripSplitButton()
        Me.tst_clear = New System.Windows.Forms.ToolStripSplitButton()
        Me.tst_back = New System.Windows.Forms.ToolStripButton()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.txt_create = New System.Windows.Forms.TextBox()
        Me.txt_mulct = New System.Windows.Forms.TextBox()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.txt_oillimit = New System.Windows.Forms.TextBox()
        Me.txt_ferlimit = New System.Windows.Forms.TextBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.lb_create = New System.Windows.Forms.Label()
        Me.txt_limit = New System.Windows.Forms.TextBox()
        Me.txt_int_oil = New System.Windows.Forms.TextBox()
        Me.txt_int_fer = New System.Windows.Forms.TextBox()
        Me.txt_int_loan = New System.Windows.Forms.TextBox()
        Me.txt_dividend = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txt_secretary = New System.Windows.Forms.TextBox()
        Me.txt_boss = New System.Windows.Forms.TextBox()
        Me.txt_address = New System.Windows.Forms.TextBox()
        Me.txt_name = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.lb_reid = New System.Windows.Forms.Label()
        Me.lb_type = New System.Windows.Forms.Label()
        Me.lb_vid = New System.Windows.Forms.Label()
        Me.lb_status = New System.Windows.Forms.Label()
        Me.ToolStrip1.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'ToolStrip1
        '
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tst_save, Me.tst_edit, Me.tst_clear, Me.tst_back})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(829, 72)
        Me.ToolStrip1.TabIndex = 17
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
        'tst_edit
        '
        Me.tst_edit.Image = Global.Village_Saving_Management_System.My.Resources.Resources.edit_icon
        Me.tst_edit.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.tst_edit.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tst_edit.Name = "tst_edit"
        Me.tst_edit.Size = New System.Drawing.Size(66, 69)
        Me.tst_edit.Text = "แก้ไข"
        Me.tst_edit.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
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
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Cordia New", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label1.Location = New System.Drawing.Point(303, 103)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(289, 30)
        Me.Label1.TabIndex = 18
        Me.Label1.Text = "ข้อมูลทั่วไปของกลุ่มออมทรัพย์หมู่บ้าน"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.txt_create)
        Me.GroupBox1.Controls.Add(Me.txt_mulct)
        Me.GroupBox1.Controls.Add(Me.Label15)
        Me.GroupBox1.Controls.Add(Me.Label14)
        Me.GroupBox1.Controls.Add(Me.txt_oillimit)
        Me.GroupBox1.Controls.Add(Me.txt_ferlimit)
        Me.GroupBox1.Controls.Add(Me.Label13)
        Me.GroupBox1.Controls.Add(Me.Label12)
        Me.GroupBox1.Controls.Add(Me.lb_create)
        Me.GroupBox1.Controls.Add(Me.txt_limit)
        Me.GroupBox1.Controls.Add(Me.txt_int_oil)
        Me.GroupBox1.Controls.Add(Me.txt_int_fer)
        Me.GroupBox1.Controls.Add(Me.txt_int_loan)
        Me.GroupBox1.Controls.Add(Me.txt_dividend)
        Me.GroupBox1.Controls.Add(Me.Label10)
        Me.GroupBox1.Controls.Add(Me.Label9)
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.txt_secretary)
        Me.GroupBox1.Controls.Add(Me.txt_boss)
        Me.GroupBox1.Controls.Add(Me.txt_address)
        Me.GroupBox1.Controls.Add(Me.txt_name)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Location = New System.Drawing.Point(96, 164)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(643, 427)
        Me.GroupBox1.TabIndex = 19
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "ข้อมูลกลุ่มออมทรัพย์หมู่บ้าน"
        '
        'txt_create
        '
        Me.txt_create.Enabled = False
        Me.txt_create.Location = New System.Drawing.Point(257, 397)
        Me.txt_create.Name = "txt_create"
        Me.txt_create.Size = New System.Drawing.Size(175, 20)
        Me.txt_create.TabIndex = 44
        '
        'txt_mulct
        '
        Me.txt_mulct.Location = New System.Drawing.Point(258, 370)
        Me.txt_mulct.Name = "txt_mulct"
        Me.txt_mulct.Size = New System.Drawing.Size(60, 20)
        Me.txt_mulct.TabIndex = 43
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(88, 347)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(161, 13)
        Me.Label15.TabIndex = 42
        Me.Label15.Text = "จำนวนน้ำมันที่สามารถกู้ได้ (ถัง) : "
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(77, 321)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(172, 13)
        Me.Label14.TabIndex = 41
        Me.Label14.Text = "จำนวนปุ๋ยที่สามารถกู้ได้ (กระสอบ) : "
        '
        'txt_oillimit
        '
        Me.txt_oillimit.Location = New System.Drawing.Point(258, 344)
        Me.txt_oillimit.Name = "txt_oillimit"
        Me.txt_oillimit.Size = New System.Drawing.Size(61, 20)
        Me.txt_oillimit.TabIndex = 38
        '
        'txt_ferlimit
        '
        Me.txt_ferlimit.Location = New System.Drawing.Point(258, 318)
        Me.txt_ferlimit.Name = "txt_ferlimit"
        Me.txt_ferlimit.Size = New System.Drawing.Size(61, 20)
        Me.txt_ferlimit.TabIndex = 37
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(81, 295)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(168, 13)
        Me.Label13.TabIndex = 36
        Me.Label13.Text = "วงเงินที่สมาชิกสามารถกู้ได้ (บาท) : "
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(40, 373)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(209, 13)
        Me.Label12.TabIndex = 35
        Me.Label12.Text = "อัตราค่าปรับกรณีผู้กู้ผิดสัญญา (ร้อยละ/วัน) : "
        '
        'lb_create
        '
        Me.lb_create.AutoSize = True
        Me.lb_create.Location = New System.Drawing.Point(197, 400)
        Me.lb_create.Name = "lb_create"
        Me.lb_create.Size = New System.Drawing.Size(52, 13)
        Me.lb_create.TabIndex = 32
        Me.lb_create.Text = "ผู้บันทึก : "
        '
        'txt_limit
        '
        Me.txt_limit.Location = New System.Drawing.Point(257, 292)
        Me.txt_limit.Name = "txt_limit"
        Me.txt_limit.Size = New System.Drawing.Size(62, 20)
        Me.txt_limit.TabIndex = 31
        '
        'txt_int_oil
        '
        Me.txt_int_oil.Location = New System.Drawing.Point(257, 265)
        Me.txt_int_oil.Name = "txt_int_oil"
        Me.txt_int_oil.Size = New System.Drawing.Size(61, 20)
        Me.txt_int_oil.TabIndex = 30
        '
        'txt_int_fer
        '
        Me.txt_int_fer.Location = New System.Drawing.Point(257, 239)
        Me.txt_int_fer.Name = "txt_int_fer"
        Me.txt_int_fer.Size = New System.Drawing.Size(61, 20)
        Me.txt_int_fer.TabIndex = 29
        '
        'txt_int_loan
        '
        Me.txt_int_loan.Location = New System.Drawing.Point(256, 213)
        Me.txt_int_loan.Name = "txt_int_loan"
        Me.txt_int_loan.Size = New System.Drawing.Size(63, 20)
        Me.txt_int_loan.TabIndex = 28
        '
        'txt_dividend
        '
        Me.txt_dividend.Location = New System.Drawing.Point(257, 187)
        Me.txt_dividend.Name = "txt_dividend"
        Me.txt_dividend.Size = New System.Drawing.Size(62, 20)
        Me.txt_dividend.TabIndex = 27
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(91, 268)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(158, 13)
        Me.Label10.TabIndex = 26
        Me.Label10.Text = "อัตราดอกเบี้ยกู้น้ำมัน (ถังละ/ปี) : "
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(98, 242)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(151, 13)
        Me.Label9.TabIndex = 25
        Me.Label9.Text = "อัตราดอกเบี้ยกู้ปุ๋ย (ร้อยละ/ปี) : "
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(94, 216)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(155, 13)
        Me.Label8.TabIndex = 24
        Me.Label8.Text = "อัตราดอกเบี้ยเงินกู้ (ร้อยละ/ปี) : "
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(94, 190)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(156, 13)
        Me.Label7.TabIndex = 23
        Me.Label7.Text = "อัตราปันผลเงินฝาก (ร้อยละ/ปี) : "
        '
        'txt_secretary
        '
        Me.txt_secretary.Location = New System.Drawing.Point(257, 161)
        Me.txt_secretary.Name = "txt_secretary"
        Me.txt_secretary.Size = New System.Drawing.Size(211, 20)
        Me.txt_secretary.TabIndex = 8
        '
        'txt_boss
        '
        Me.txt_boss.Location = New System.Drawing.Point(257, 135)
        Me.txt_boss.Name = "txt_boss"
        Me.txt_boss.Size = New System.Drawing.Size(212, 20)
        Me.txt_boss.TabIndex = 7
        '
        'txt_address
        '
        Me.txt_address.Location = New System.Drawing.Point(257, 61)
        Me.txt_address.Multiline = True
        Me.txt_address.Name = "txt_address"
        Me.txt_address.Size = New System.Drawing.Size(211, 68)
        Me.txt_address.TabIndex = 6
        '
        'txt_name
        '
        Me.txt_name.Location = New System.Drawing.Point(257, 35)
        Me.txt_name.Name = "txt_name"
        Me.txt_name.Size = New System.Drawing.Size(260, 20)
        Me.txt_name.TabIndex = 5
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(165, 164)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(84, 13)
        Me.Label5.TabIndex = 3
        Me.Label5.Text = "เลขานุการกลุ่ม : "
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(176, 138)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(73, 13)
        Me.Label4.TabIndex = 2
        Me.Label4.Text = "ประธานกลุ่ม : "
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(183, 64)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(66, 13)
        Me.Label3.TabIndex = 1
        Me.Label3.Text = "ที่ตั้ง / ที่อยู่ : "
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(154, 38)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(96, 13)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "ชื่อกลุ่มออมทรัพย์ : "
        '
        'lb_reid
        '
        Me.lb_reid.AutoSize = True
        Me.lb_reid.Location = New System.Drawing.Point(807, 72)
        Me.lb_reid.Name = "lb_reid"
        Me.lb_reid.Size = New System.Drawing.Size(10, 13)
        Me.lb_reid.TabIndex = 21
        Me.lb_reid.Text = "-"
        Me.lb_reid.Visible = False
        '
        'lb_type
        '
        Me.lb_type.AutoSize = True
        Me.lb_type.Location = New System.Drawing.Point(807, 90)
        Me.lb_type.Name = "lb_type"
        Me.lb_type.Size = New System.Drawing.Size(10, 13)
        Me.lb_type.TabIndex = 22
        Me.lb_type.Text = "-"
        Me.lb_type.Visible = False
        '
        'lb_vid
        '
        Me.lb_vid.AutoSize = True
        Me.lb_vid.Location = New System.Drawing.Point(807, 103)
        Me.lb_vid.Name = "lb_vid"
        Me.lb_vid.Size = New System.Drawing.Size(10, 13)
        Me.lb_vid.TabIndex = 23
        Me.lb_vid.Text = "-"
        Me.lb_vid.Visible = False
        '
        'lb_status
        '
        Me.lb_status.AutoSize = True
        Me.lb_status.Location = New System.Drawing.Point(807, 121)
        Me.lb_status.Name = "lb_status"
        Me.lb_status.Size = New System.Drawing.Size(10, 13)
        Me.lb_status.TabIndex = 24
        Me.lb_status.Text = "-"
        Me.lb_status.Visible = False
        '
        'Village_Saving
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.AliceBlue
        Me.ClientSize = New System.Drawing.Size(829, 661)
        Me.Controls.Add(Me.lb_status)
        Me.Controls.Add(Me.lb_vid)
        Me.Controls.Add(Me.lb_type)
        Me.Controls.Add(Me.lb_reid)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Village_Saving"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "ระบบบริหารจัดการกลุ่มออมทรัพย์หมู่บ้าน"
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ToolStrip1 As System.Windows.Forms.ToolStrip
    Friend WithEvents tst_save As System.Windows.Forms.ToolStripSplitButton
    Friend WithEvents tst_edit As System.Windows.Forms.ToolStripSplitButton
    Friend WithEvents tst_back As System.Windows.Forms.ToolStripButton
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents txt_secretary As System.Windows.Forms.TextBox
    Friend WithEvents txt_boss As System.Windows.Forms.TextBox
    Friend WithEvents txt_address As System.Windows.Forms.TextBox
    Friend WithEvents txt_name As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents lb_create As System.Windows.Forms.Label
    Friend WithEvents txt_limit As System.Windows.Forms.TextBox
    Friend WithEvents txt_int_oil As System.Windows.Forms.TextBox
    Friend WithEvents txt_int_fer As System.Windows.Forms.TextBox
    Friend WithEvents txt_int_loan As System.Windows.Forms.TextBox
    Friend WithEvents txt_dividend As System.Windows.Forms.TextBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents tst_clear As System.Windows.Forms.ToolStripSplitButton
    Friend WithEvents lb_reid As System.Windows.Forms.Label
    Friend WithEvents txt_oillimit As System.Windows.Forms.TextBox
    Friend WithEvents txt_ferlimit As System.Windows.Forms.TextBox
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents txt_create As System.Windows.Forms.TextBox
    Friend WithEvents txt_mulct As System.Windows.Forms.TextBox
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents lb_type As System.Windows.Forms.Label
    Friend WithEvents lb_vid As System.Windows.Forms.Label
    Friend WithEvents lb_status As System.Windows.Forms.Label
End Class

<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Fer_Pay
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Fer_Pay))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txt_mulct = New System.Windows.Forms.TextBox()
        Me.txt_create = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txt_sum = New System.Windows.Forms.TextBox()
        Me.txt_balance = New System.Windows.Forms.TextBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.txt_interest = New System.Windows.Forms.TextBox()
        Me.dtp_date2 = New System.Windows.Forms.DateTimePicker()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.txt_pay = New System.Windows.Forms.TextBox()
        Me.txt_sumprice = New System.Windows.Forms.TextBox()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.tst_save = New System.Windows.Forms.ToolStripSplitButton()
        Me.tst_print = New System.Windows.Forms.ToolStripSplitButton()
        Me.tst_clear = New System.Windows.Forms.ToolStripSplitButton()
        Me.tst_back = New System.Windows.Forms.ToolStripButton()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.dtp_date1 = New System.Windows.Forms.DateTimePicker()
        Me.Label22 = New System.Windows.Forms.Label()
        Me.Lab = New System.Windows.Forms.Label()
        Me.btn_Search1 = New System.Windows.Forms.Button()
        Me.txt_age = New System.Windows.Forms.TextBox()
        Me.txt_month = New System.Windows.Forms.TextBox()
        Me.txt_vocation = New System.Windows.Forms.TextBox()
        Me.txt_personalid = New System.Windows.Forms.TextBox()
        Me.Label26 = New System.Windows.Forms.Label()
        Me.Label25 = New System.Windows.Forms.Label()
        Me.Label27 = New System.Windows.Forms.Label()
        Me.txt_tel = New System.Windows.Forms.TextBox()
        Me.Label28 = New System.Windows.Forms.Label()
        Me.txt_address = New System.Windows.Forms.TextBox()
        Me.Label29 = New System.Windows.Forms.Label()
        Me.Label30 = New System.Windows.Forms.Label()
        Me.txt_fullname = New System.Windows.Forms.TextBox()
        Me.Label31 = New System.Windows.Forms.Label()
        Me.txt_id = New System.Windows.Forms.TextBox()
        Me.Label32 = New System.Windows.Forms.Label()
        Me.txt_conid = New System.Windows.Forms.TextBox()
        Me.Label33 = New System.Windows.Forms.Label()
        Me.lb_reid = New System.Windows.Forms.Label()
        Me.GroupBox3.SuspendLayout()
        Me.ToolStrip1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Cordia New", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(404, 95)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(162, 33)
        Me.Label1.TabIndex = 7
        Me.Label1.Text = "การชำระเงินค่าปุ๋ย"
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.Label2)
        Me.GroupBox3.Controls.Add(Me.txt_mulct)
        Me.GroupBox3.Controls.Add(Me.txt_create)
        Me.GroupBox3.Controls.Add(Me.Label3)
        Me.GroupBox3.Controls.Add(Me.txt_sum)
        Me.GroupBox3.Controls.Add(Me.txt_balance)
        Me.GroupBox3.Controls.Add(Me.Label13)
        Me.GroupBox3.Controls.Add(Me.Label12)
        Me.GroupBox3.Controls.Add(Me.Label11)
        Me.GroupBox3.Controls.Add(Me.txt_interest)
        Me.GroupBox3.Controls.Add(Me.dtp_date2)
        Me.GroupBox3.Controls.Add(Me.Label17)
        Me.GroupBox3.Controls.Add(Me.txt_pay)
        Me.GroupBox3.Controls.Add(Me.txt_sumprice)
        Me.GroupBox3.Controls.Add(Me.Label16)
        Me.GroupBox3.Controls.Add(Me.Label15)
        Me.GroupBox3.Location = New System.Drawing.Point(51, 467)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(847, 159)
        Me.GroupBox3.TabIndex = 11
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "ข้อมูลการชำระเงินค่าปุ๋ย"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(78, 84)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(76, 13)
        Me.Label2.TabIndex = 22
        Me.Label2.Text = "ค่าปรับ (บาท) : "
        '
        'txt_mulct
        '
        Me.txt_mulct.Enabled = False
        Me.txt_mulct.Location = New System.Drawing.Point(160, 79)
        Me.txt_mulct.Name = "txt_mulct"
        Me.txt_mulct.Size = New System.Drawing.Size(113, 20)
        Me.txt_mulct.TabIndex = 21
        '
        'txt_create
        '
        Me.txt_create.Enabled = False
        Me.txt_create.Location = New System.Drawing.Point(489, 75)
        Me.txt_create.Name = "txt_create"
        Me.txt_create.Size = New System.Drawing.Size(137, 20)
        Me.txt_create.TabIndex = 20
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(431, 77)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(52, 13)
        Me.Label3.TabIndex = 19
        Me.Label3.Text = "ผู้บันทึก : "
        '
        'txt_sum
        '
        Me.txt_sum.Enabled = False
        Me.txt_sum.Location = New System.Drawing.Point(160, 104)
        Me.txt_sum.Name = "txt_sum"
        Me.txt_sum.Size = New System.Drawing.Size(113, 20)
        Me.txt_sum.TabIndex = 17
        '
        'txt_balance
        '
        Me.txt_balance.Enabled = False
        Me.txt_balance.Location = New System.Drawing.Point(489, 49)
        Me.txt_balance.Name = "txt_balance"
        Me.txt_balance.Size = New System.Drawing.Size(113, 20)
        Me.txt_balance.TabIndex = 16
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(11, 107)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(143, 13)
        Me.Label13.TabIndex = 15
        Me.Label13.Text = "จำนวนเงินที่ต้องชำระ (บาท) : "
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(380, 27)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(103, 13)
        Me.Label12.TabIndex = 14
        Me.Label12.Text = "ต้องการชำระ (บาท) : "
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(403, 53)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(80, 13)
        Me.Label11.TabIndex = 12
        Me.Label11.Text = "คงเหลือ (บาท) : "
        '
        'txt_interest
        '
        Me.txt_interest.Enabled = False
        Me.txt_interest.Location = New System.Drawing.Point(160, 53)
        Me.txt_interest.Name = "txt_interest"
        Me.txt_interest.Size = New System.Drawing.Size(113, 20)
        Me.txt_interest.TabIndex = 11
        '
        'dtp_date2
        '
        Me.dtp_date2.Enabled = False
        Me.dtp_date2.Location = New System.Drawing.Point(489, 104)
        Me.dtp_date2.Name = "dtp_date2"
        Me.dtp_date2.Size = New System.Drawing.Size(137, 20)
        Me.dtp_date2.TabIndex = 10
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Location = New System.Drawing.Point(423, 107)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(60, 13)
        Me.Label17.TabIndex = 6
        Me.Label17.Text = "วันที่ชำระ : "
        '
        'txt_pay
        '
        Me.txt_pay.Location = New System.Drawing.Point(489, 24)
        Me.txt_pay.Name = "txt_pay"
        Me.txt_pay.Size = New System.Drawing.Size(113, 20)
        Me.txt_pay.TabIndex = 5
        '
        'txt_sumprice
        '
        Me.txt_sumprice.Enabled = False
        Me.txt_sumprice.Location = New System.Drawing.Point(160, 27)
        Me.txt_sumprice.Name = "txt_sumprice"
        Me.txt_sumprice.Size = New System.Drawing.Size(113, 20)
        Me.txt_sumprice.TabIndex = 4
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Location = New System.Drawing.Point(71, 56)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(83, 13)
        Me.Label16.TabIndex = 3
        Me.Label16.Text = "ดอกเบี้ย (บาท) : "
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(78, 30)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(80, 13)
        Me.Label15.TabIndex = 2
        Me.Label15.Text = "เงินต้น (บาท) :  "
        '
        'ToolStrip1
        '
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tst_save, Me.tst_print, Me.tst_clear, Me.tst_back})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(934, 72)
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
        'tst_print
        '
        Me.tst_print.Image = Global.Village_Saving_Management_System.My.Resources.Resources.printer_blue
        Me.tst_print.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.tst_print.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tst_print.Name = "tst_print"
        Me.tst_print.Size = New System.Drawing.Size(82, 69)
        Me.tst_print.Text = "พิมพ์ใบเสร็จ"
        Me.tst_print.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
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
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.dtp_date1)
        Me.GroupBox2.Controls.Add(Me.Label22)
        Me.GroupBox2.Controls.Add(Me.Lab)
        Me.GroupBox2.Controls.Add(Me.btn_Search1)
        Me.GroupBox2.Controls.Add(Me.txt_age)
        Me.GroupBox2.Controls.Add(Me.txt_month)
        Me.GroupBox2.Controls.Add(Me.txt_vocation)
        Me.GroupBox2.Controls.Add(Me.txt_personalid)
        Me.GroupBox2.Controls.Add(Me.Label26)
        Me.GroupBox2.Controls.Add(Me.Label25)
        Me.GroupBox2.Controls.Add(Me.Label27)
        Me.GroupBox2.Controls.Add(Me.txt_tel)
        Me.GroupBox2.Controls.Add(Me.Label28)
        Me.GroupBox2.Controls.Add(Me.txt_address)
        Me.GroupBox2.Controls.Add(Me.Label29)
        Me.GroupBox2.Controls.Add(Me.Label30)
        Me.GroupBox2.Controls.Add(Me.txt_fullname)
        Me.GroupBox2.Controls.Add(Me.Label31)
        Me.GroupBox2.Controls.Add(Me.txt_id)
        Me.GroupBox2.Controls.Add(Me.Label32)
        Me.GroupBox2.Controls.Add(Me.txt_conid)
        Me.GroupBox2.Controls.Add(Me.Label33)
        Me.GroupBox2.Location = New System.Drawing.Point(51, 144)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(847, 307)
        Me.GroupBox2.TabIndex = 24
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "ข้อมูลผู้ทำสัญญาซื้อปุ๋ย"
        '
        'dtp_date1
        '
        Me.dtp_date1.Enabled = False
        Me.dtp_date1.Location = New System.Drawing.Point(259, 260)
        Me.dtp_date1.Name = "dtp_date1"
        Me.dtp_date1.Size = New System.Drawing.Size(138, 20)
        Me.dtp_date1.TabIndex = 48
        '
        'Label22
        '
        Me.Label22.AutoSize = True
        Me.Label22.Location = New System.Drawing.Point(11, 266)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(242, 13)
        Me.Label22.TabIndex = 47
        Me.Label22.Text = "ชำระทั้งเงินต้นและดอกเบี้ย แล้วเสร็จภายในวันที่ : "
        '
        'Lab
        '
        Me.Lab.AutoSize = True
        Me.Lab.Location = New System.Drawing.Point(111, 32)
        Me.Lab.Name = "Lab"
        Me.Lab.Size = New System.Drawing.Size(43, 13)
        Me.Lab.TabIndex = 45
        Me.Lab.Text = "ค้นหา : "
        '
        'btn_Search1
        '
        Me.btn_Search1.Image = Global.Village_Saving_Management_System.My.Resources.Resources.search_mini
        Me.btn_Search1.Location = New System.Drawing.Point(160, 23)
        Me.btn_Search1.Name = "btn_Search1"
        Me.btn_Search1.Size = New System.Drawing.Size(33, 31)
        Me.btn_Search1.TabIndex = 44
        Me.btn_Search1.UseVisualStyleBackColor = True
        '
        'txt_age
        '
        Me.txt_age.Enabled = False
        Me.txt_age.Location = New System.Drawing.Point(160, 206)
        Me.txt_age.Name = "txt_age"
        Me.txt_age.Size = New System.Drawing.Size(85, 20)
        Me.txt_age.TabIndex = 41
        '
        'txt_month
        '
        Me.txt_month.Enabled = False
        Me.txt_month.Location = New System.Drawing.Point(160, 233)
        Me.txt_month.Name = "txt_month"
        Me.txt_month.Size = New System.Drawing.Size(85, 20)
        Me.txt_month.TabIndex = 30
        '
        'txt_vocation
        '
        Me.txt_vocation.Enabled = False
        Me.txt_vocation.Location = New System.Drawing.Point(489, 206)
        Me.txt_vocation.Name = "txt_vocation"
        Me.txt_vocation.Size = New System.Drawing.Size(113, 20)
        Me.txt_vocation.TabIndex = 29
        '
        'txt_personalid
        '
        Me.txt_personalid.Enabled = False
        Me.txt_personalid.Location = New System.Drawing.Point(489, 180)
        Me.txt_personalid.Name = "txt_personalid"
        Me.txt_personalid.Size = New System.Drawing.Size(187, 20)
        Me.txt_personalid.TabIndex = 27
        '
        'Label26
        '
        Me.Label26.AutoSize = True
        Me.Label26.Location = New System.Drawing.Point(85, 67)
        Me.Label26.Name = "Label26"
        Me.Label26.Size = New System.Drawing.Size(69, 13)
        Me.Label26.TabIndex = 25
        Me.Label26.Text = "เลขที่สัญญา : "
        '
        'Label25
        '
        Me.Label25.AutoSize = True
        Me.Label25.Location = New System.Drawing.Point(14, 236)
        Me.Label25.Name = "Label25"
        Me.Label25.Size = New System.Drawing.Size(140, 13)
        Me.Label25.TabIndex = 16
        Me.Label25.Text = "รายได้เฉลี่ยต่อเดือน (บาท) : "
        '
        'Label27
        '
        Me.Label27.AutoSize = True
        Me.Label27.Location = New System.Drawing.Point(441, 209)
        Me.Label27.Name = "Label27"
        Me.Label27.Size = New System.Drawing.Size(42, 13)
        Me.Label27.TabIndex = 14
        Me.Label27.Text = "อาชีพ : "
        '
        'txt_tel
        '
        Me.txt_tel.Enabled = False
        Me.txt_tel.Location = New System.Drawing.Point(160, 180)
        Me.txt_tel.Name = "txt_tel"
        Me.txt_tel.Size = New System.Drawing.Size(136, 20)
        Me.txt_tel.TabIndex = 13
        '
        'Label28
        '
        Me.Label28.AutoSize = True
        Me.Label28.Location = New System.Drawing.Point(336, 183)
        Me.Label28.Name = "Label28"
        Me.Label28.Size = New System.Drawing.Size(147, 13)
        Me.Label28.TabIndex = 12
        Me.Label28.Text = "เลขที่บัตรประจำตัวประชาชน : "
        '
        'txt_address
        '
        Me.txt_address.Enabled = False
        Me.txt_address.Location = New System.Drawing.Point(160, 116)
        Me.txt_address.Multiline = True
        Me.txt_address.Name = "txt_address"
        Me.txt_address.Size = New System.Drawing.Size(218, 56)
        Me.txt_address.TabIndex = 11
        '
        'Label29
        '
        Me.Label29.AutoSize = True
        Me.Label29.Location = New System.Drawing.Point(73, 183)
        Me.Label29.Name = "Label29"
        Me.Label29.Size = New System.Drawing.Size(81, 13)
        Me.Label29.TabIndex = 10
        Me.Label29.Text = "เบอร์โทรศัพท์ : "
        '
        'Label30
        '
        Me.Label30.AutoSize = True
        Me.Label30.Location = New System.Drawing.Point(118, 119)
        Me.Label30.Name = "Label30"
        Me.Label30.Size = New System.Drawing.Size(36, 13)
        Me.Label30.TabIndex = 8
        Me.Label30.Text = "ที่อยู่ : "
        '
        'txt_fullname
        '
        Me.txt_fullname.Enabled = False
        Me.txt_fullname.Location = New System.Drawing.Point(489, 90)
        Me.txt_fullname.Name = "txt_fullname"
        Me.txt_fullname.Size = New System.Drawing.Size(231, 20)
        Me.txt_fullname.TabIndex = 6
        '
        'Label31
        '
        Me.Label31.AutoSize = True
        Me.Label31.Location = New System.Drawing.Point(104, 209)
        Me.Label31.Name = "Label31"
        Me.Label31.Size = New System.Drawing.Size(50, 13)
        Me.Label31.TabIndex = 5
        Me.Label31.Text = "อายุ (ปี) : "
        '
        'txt_id
        '
        Me.txt_id.Enabled = False
        Me.txt_id.Location = New System.Drawing.Point(160, 90)
        Me.txt_id.Name = "txt_id"
        Me.txt_id.Size = New System.Drawing.Size(113, 20)
        Me.txt_id.TabIndex = 4
        '
        'Label32
        '
        Me.Label32.AutoSize = True
        Me.Label32.Location = New System.Drawing.Point(82, 93)
        Me.Label32.Name = "Label32"
        Me.Label32.Size = New System.Drawing.Size(72, 13)
        Me.Label32.TabIndex = 3
        Me.Label32.Text = "เลขที่สมาชิก : "
        '
        'txt_conid
        '
        Me.txt_conid.Enabled = False
        Me.txt_conid.Location = New System.Drawing.Point(160, 64)
        Me.txt_conid.Name = "txt_conid"
        Me.txt_conid.Size = New System.Drawing.Size(113, 20)
        Me.txt_conid.TabIndex = 2
        '
        'Label33
        '
        Me.Label33.AutoSize = True
        Me.Label33.Location = New System.Drawing.Point(406, 93)
        Me.Label33.Name = "Label33"
        Me.Label33.Size = New System.Drawing.Size(77, 13)
        Me.Label33.TabIndex = 1
        Me.Label33.Text = "ชื่อ - นามสกุล : "
        '
        'lb_reid
        '
        Me.lb_reid.AutoSize = True
        Me.lb_reid.Location = New System.Drawing.Point(912, 72)
        Me.lb_reid.Name = "lb_reid"
        Me.lb_reid.Size = New System.Drawing.Size(10, 13)
        Me.lb_reid.TabIndex = 26
        Me.lb_reid.Text = "-"
        Me.lb_reid.Visible = False
        '
        'Fer_Pay
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.AliceBlue
        Me.ClientSize = New System.Drawing.Size(934, 664)
        Me.Controls.Add(Me.lb_reid)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.Label1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Fer_Pay"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "ระบบบริหารจัดการกลุ่มออมทรัพย์หมู่บ้าน [การชำระเงินค่าปุ๋ย]"
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents txt_pay As System.Windows.Forms.TextBox
    Friend WithEvents txt_sumprice As System.Windows.Forms.TextBox
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents txt_interest As System.Windows.Forms.TextBox
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents txt_sum As System.Windows.Forms.TextBox
    Friend WithEvents txt_balance As System.Windows.Forms.TextBox
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents ToolStrip1 As System.Windows.Forms.ToolStrip
    Friend WithEvents tst_save As System.Windows.Forms.ToolStripSplitButton
    Friend WithEvents tst_print As System.Windows.Forms.ToolStripSplitButton
    Friend WithEvents tst_back As System.Windows.Forms.ToolStripButton
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents txt_age As System.Windows.Forms.TextBox
    Friend WithEvents txt_month As System.Windows.Forms.TextBox
    Friend WithEvents txt_vocation As System.Windows.Forms.TextBox
    Friend WithEvents txt_personalid As System.Windows.Forms.TextBox
    Friend WithEvents Label26 As System.Windows.Forms.Label
    Friend WithEvents Label25 As System.Windows.Forms.Label
    Friend WithEvents Label27 As System.Windows.Forms.Label
    Friend WithEvents txt_tel As System.Windows.Forms.TextBox
    Friend WithEvents Label28 As System.Windows.Forms.Label
    Friend WithEvents txt_address As System.Windows.Forms.TextBox
    Friend WithEvents Label29 As System.Windows.Forms.Label
    Friend WithEvents Label30 As System.Windows.Forms.Label
    Friend WithEvents txt_fullname As System.Windows.Forms.TextBox
    Friend WithEvents Label31 As System.Windows.Forms.Label
    Friend WithEvents txt_id As System.Windows.Forms.TextBox
    Friend WithEvents Label32 As System.Windows.Forms.Label
    Friend WithEvents txt_conid As System.Windows.Forms.TextBox
    Friend WithEvents Label33 As System.Windows.Forms.Label
    Friend WithEvents dtp_date2 As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txt_create As System.Windows.Forms.TextBox
    Friend WithEvents tst_clear As System.Windows.Forms.ToolStripSplitButton
    Friend WithEvents lb_reid As System.Windows.Forms.Label
    Friend WithEvents Lab As System.Windows.Forms.Label
    Friend WithEvents btn_Search1 As System.Windows.Forms.Button
    Friend WithEvents Label22 As System.Windows.Forms.Label
    Friend WithEvents dtp_date1 As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txt_mulct As System.Windows.Forms.TextBox
End Class

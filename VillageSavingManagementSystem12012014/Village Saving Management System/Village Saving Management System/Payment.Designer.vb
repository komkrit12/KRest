<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Payment
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Payment))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.dtp_date2 = New System.Windows.Forms.DateTimePicker()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.tst_save = New System.Windows.Forms.ToolStripSplitButton()
        Me.tst_print = New System.Windows.Forms.ToolStripSplitButton()
        Me.tst_clear = New System.Windows.Forms.ToolStripSplitButton()
        Me.tst_back = New System.Windows.Forms.ToolStripButton()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txt_sum = New System.Windows.Forms.TextBox()
        Me.txt_mulct = New System.Windows.Forms.TextBox()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.txt_interest = New System.Windows.Forms.TextBox()
        Me.txt_sumprice = New System.Windows.Forms.TextBox()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.txt_create = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txt_pay = New System.Windows.Forms.TextBox()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.txt_balance = New System.Windows.Forms.TextBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Lab = New System.Windows.Forms.Label()
        Me.btn_Search1 = New System.Windows.Forms.Button()
        Me.txt_age = New System.Windows.Forms.TextBox()
        Me.txt_loan = New System.Windows.Forms.TextBox()
        Me.dtp_date1 = New System.Windows.Forms.DateTimePicker()
        Me.txt_month = New System.Windows.Forms.TextBox()
        Me.txt_vocation = New System.Windows.Forms.TextBox()
        Me.txt_personalid = New System.Windows.Forms.TextBox()
        Me.Label26 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
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
        Me.Label14 = New System.Windows.Forms.Label()
        Me.lb_reid = New System.Windows.Forms.Label()
        Me.ToolStrip1.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Cordia New", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(432, 72)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(128, 33)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "การชำระเงินกู้"
        '
        'dtp_date2
        '
        Me.dtp_date2.Enabled = False
        Me.dtp_date2.Location = New System.Drawing.Point(457, 71)
        Me.dtp_date2.Name = "dtp_date2"
        Me.dtp_date2.Size = New System.Drawing.Size(142, 20)
        Me.dtp_date2.TabIndex = 13
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Location = New System.Drawing.Point(391, 74)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(60, 13)
        Me.Label17.TabIndex = 6
        Me.Label17.Text = "วันที่ชำระ : "
        '
        'ToolStrip1
        '
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tst_save, Me.tst_print, Me.tst_clear, Me.tst_back})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(934, 72)
        Me.ToolStrip1.TabIndex = 16
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
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.Label2)
        Me.GroupBox4.Controls.Add(Me.txt_sum)
        Me.GroupBox4.Controls.Add(Me.txt_mulct)
        Me.GroupBox4.Controls.Add(Me.Label18)
        Me.GroupBox4.Controls.Add(Me.txt_interest)
        Me.GroupBox4.Controls.Add(Me.txt_sumprice)
        Me.GroupBox4.Controls.Add(Me.Label16)
        Me.GroupBox4.Controls.Add(Me.Label15)
        Me.GroupBox4.Controls.Add(Me.txt_create)
        Me.GroupBox4.Controls.Add(Me.Label5)
        Me.GroupBox4.Controls.Add(Me.dtp_date2)
        Me.GroupBox4.Controls.Add(Me.txt_pay)
        Me.GroupBox4.Controls.Add(Me.Label20)
        Me.GroupBox4.Controls.Add(Me.Label21)
        Me.GroupBox4.Controls.Add(Me.Label17)
        Me.GroupBox4.Controls.Add(Me.txt_balance)
        Me.GroupBox4.Location = New System.Drawing.Point(44, 459)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(839, 141)
        Me.GroupBox4.TabIndex = 17
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "ข้อมูลการชำระเงินกู้"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(78, 76)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(76, 13)
        Me.Label2.TabIndex = 24
        Me.Label2.Text = "ค่าปรับ (บาท) : "
        '
        'txt_sum
        '
        Me.txt_sum.Enabled = False
        Me.txt_sum.Location = New System.Drawing.Point(160, 97)
        Me.txt_sum.Name = "txt_sum"
        Me.txt_sum.Size = New System.Drawing.Size(113, 20)
        Me.txt_sum.TabIndex = 24
        '
        'txt_mulct
        '
        Me.txt_mulct.Enabled = False
        Me.txt_mulct.Location = New System.Drawing.Point(160, 71)
        Me.txt_mulct.Name = "txt_mulct"
        Me.txt_mulct.Size = New System.Drawing.Size(113, 20)
        Me.txt_mulct.TabIndex = 23
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Location = New System.Drawing.Point(12, 100)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(143, 13)
        Me.Label18.TabIndex = 23
        Me.Label18.Text = "จำนวนเงินที่ต้องชำระ (บาท) : "
        '
        'txt_interest
        '
        Me.txt_interest.Enabled = False
        Me.txt_interest.Location = New System.Drawing.Point(160, 45)
        Me.txt_interest.Name = "txt_interest"
        Me.txt_interest.Size = New System.Drawing.Size(113, 20)
        Me.txt_interest.TabIndex = 22
        '
        'txt_sumprice
        '
        Me.txt_sumprice.Enabled = False
        Me.txt_sumprice.Location = New System.Drawing.Point(160, 19)
        Me.txt_sumprice.Name = "txt_sumprice"
        Me.txt_sumprice.Size = New System.Drawing.Size(113, 20)
        Me.txt_sumprice.TabIndex = 21
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Location = New System.Drawing.Point(72, 48)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(83, 13)
        Me.Label16.TabIndex = 20
        Me.Label16.Text = "ดอกเบี้ย (บาท) : "
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(77, 22)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(77, 13)
        Me.Label15.TabIndex = 19
        Me.Label15.Text = "เงินต้น (บาท) : "
        '
        'txt_create
        '
        Me.txt_create.Enabled = False
        Me.txt_create.Location = New System.Drawing.Point(457, 97)
        Me.txt_create.Name = "txt_create"
        Me.txt_create.Size = New System.Drawing.Size(142, 20)
        Me.txt_create.TabIndex = 18
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(399, 100)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(52, 13)
        Me.Label5.TabIndex = 17
        Me.Label5.Text = "ผู้บันทึก : "
        '
        'txt_pay
        '
        Me.txt_pay.Location = New System.Drawing.Point(457, 19)
        Me.txt_pay.Name = "txt_pay"
        Me.txt_pay.Size = New System.Drawing.Size(109, 20)
        Me.txt_pay.TabIndex = 14
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Location = New System.Drawing.Point(345, 19)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(106, 13)
        Me.Label20.TabIndex = 13
        Me.Label20.Text = "ต้องการชำระ (บาท) :  "
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.Location = New System.Drawing.Point(371, 48)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(80, 13)
        Me.Label21.TabIndex = 12
        Me.Label21.Text = "คงเหลือ (บาท) : "
        '
        'txt_balance
        '
        Me.txt_balance.Enabled = False
        Me.txt_balance.Location = New System.Drawing.Point(457, 45)
        Me.txt_balance.Name = "txt_balance"
        Me.txt_balance.Size = New System.Drawing.Size(109, 20)
        Me.txt_balance.TabIndex = 11
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.Lab)
        Me.GroupBox2.Controls.Add(Me.btn_Search1)
        Me.GroupBox2.Controls.Add(Me.txt_age)
        Me.GroupBox2.Controls.Add(Me.txt_loan)
        Me.GroupBox2.Controls.Add(Me.dtp_date1)
        Me.GroupBox2.Controls.Add(Me.txt_month)
        Me.GroupBox2.Controls.Add(Me.txt_vocation)
        Me.GroupBox2.Controls.Add(Me.txt_personalid)
        Me.GroupBox2.Controls.Add(Me.Label26)
        Me.GroupBox2.Controls.Add(Me.Label12)
        Me.GroupBox2.Controls.Add(Me.Label11)
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
        Me.GroupBox2.Controls.Add(Me.Label3)
        Me.GroupBox2.Controls.Add(Me.txt_conid)
        Me.GroupBox2.Controls.Add(Me.Label14)
        Me.GroupBox2.Location = New System.Drawing.Point(44, 108)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(839, 332)
        Me.GroupBox2.TabIndex = 17
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "ข้อมูลผู้ทำสัญญาเงินกู้"
        '
        'Lab
        '
        Me.Lab.AutoSize = True
        Me.Lab.Location = New System.Drawing.Point(107, 44)
        Me.Lab.Name = "Lab"
        Me.Lab.Size = New System.Drawing.Size(43, 13)
        Me.Lab.TabIndex = 43
        Me.Lab.Text = "ค้นหา : "
        '
        'btn_Search1
        '
        Me.btn_Search1.Image = Global.Village_Saving_Management_System.My.Resources.Resources.search_mini
        Me.btn_Search1.Location = New System.Drawing.Point(160, 34)
        Me.btn_Search1.Name = "btn_Search1"
        Me.btn_Search1.Size = New System.Drawing.Size(33, 31)
        Me.btn_Search1.TabIndex = 42
        Me.btn_Search1.UseVisualStyleBackColor = True
        '
        'txt_age
        '
        Me.txt_age.Enabled = False
        Me.txt_age.Location = New System.Drawing.Point(160, 213)
        Me.txt_age.Name = "txt_age"
        Me.txt_age.Size = New System.Drawing.Size(71, 20)
        Me.txt_age.TabIndex = 41
        '
        'txt_loan
        '
        Me.txt_loan.Enabled = False
        Me.txt_loan.Location = New System.Drawing.Point(457, 238)
        Me.txt_loan.Name = "txt_loan"
        Me.txt_loan.Size = New System.Drawing.Size(100, 20)
        Me.txt_loan.TabIndex = 36
        '
        'dtp_date1
        '
        Me.dtp_date1.Enabled = False
        Me.dtp_date1.Location = New System.Drawing.Point(457, 264)
        Me.dtp_date1.Name = "dtp_date1"
        Me.dtp_date1.Size = New System.Drawing.Size(157, 20)
        Me.dtp_date1.TabIndex = 34
        '
        'txt_month
        '
        Me.txt_month.Enabled = False
        Me.txt_month.Location = New System.Drawing.Point(457, 213)
        Me.txt_month.Name = "txt_month"
        Me.txt_month.Size = New System.Drawing.Size(100, 20)
        Me.txt_month.TabIndex = 30
        '
        'txt_vocation
        '
        Me.txt_vocation.Enabled = False
        Me.txt_vocation.Location = New System.Drawing.Point(160, 238)
        Me.txt_vocation.Name = "txt_vocation"
        Me.txt_vocation.Size = New System.Drawing.Size(113, 20)
        Me.txt_vocation.TabIndex = 29
        '
        'txt_personalid
        '
        Me.txt_personalid.Enabled = False
        Me.txt_personalid.Location = New System.Drawing.Point(457, 187)
        Me.txt_personalid.Name = "txt_personalid"
        Me.txt_personalid.Size = New System.Drawing.Size(161, 20)
        Me.txt_personalid.TabIndex = 27
        '
        'Label26
        '
        Me.Label26.AutoSize = True
        Me.Label26.Location = New System.Drawing.Point(56, 74)
        Me.Label26.Name = "Label26"
        Me.Label26.Size = New System.Drawing.Size(94, 13)
        Me.Label26.TabIndex = 25
        Me.Label26.Text = "เลขที่สัญญาเงินกู้ : "
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(259, 270)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(192, 13)
        Me.Label12.TabIndex = 20
        Me.Label12.Text = "ต้องชำระเงินกู้ให้แล้วเสร็จภายในวันที่ : "
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(330, 241)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(121, 13)
        Me.Label11.TabIndex = 18
        Me.Label11.Text = "จำนวนเงินที่ขอกู้ (บาท) : "
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(314, 216)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(137, 13)
        Me.Label10.TabIndex = 16
        Me.Label10.Text = "รายได้เฉลี่ยต่อเดือน (บาท) :"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(104, 241)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(42, 13)
        Me.Label9.TabIndex = 14
        Me.Label9.Text = "อาชีพ : "
        '
        'txt_tel
        '
        Me.txt_tel.Enabled = False
        Me.txt_tel.Location = New System.Drawing.Point(160, 187)
        Me.txt_tel.Name = "txt_tel"
        Me.txt_tel.Size = New System.Drawing.Size(136, 20)
        Me.txt_tel.TabIndex = 13
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(304, 190)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(147, 13)
        Me.Label8.TabIndex = 12
        Me.Label8.Text = "เลขที่บัตรประจำตัวประชาชน : "
        '
        'txt_address
        '
        Me.txt_address.Enabled = False
        Me.txt_address.Location = New System.Drawing.Point(160, 123)
        Me.txt_address.Multiline = True
        Me.txt_address.Name = "txt_address"
        Me.txt_address.Size = New System.Drawing.Size(218, 56)
        Me.txt_address.TabIndex = 11
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(65, 191)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(81, 13)
        Me.Label7.TabIndex = 10
        Me.Label7.Text = "เบอร์โทรศัพท์ : "
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(110, 128)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(36, 13)
        Me.Label6.TabIndex = 8
        Me.Label6.Text = "ที่อยู่ : "
        '
        'txt_fullname
        '
        Me.txt_fullname.Enabled = False
        Me.txt_fullname.Location = New System.Drawing.Point(457, 97)
        Me.txt_fullname.Name = "txt_fullname"
        Me.txt_fullname.Size = New System.Drawing.Size(229, 20)
        Me.txt_fullname.TabIndex = 6
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(96, 216)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(50, 13)
        Me.Label4.TabIndex = 5
        Me.Label4.Text = "อายุ (ปี) : "
        '
        'txt_id
        '
        Me.txt_id.Enabled = False
        Me.txt_id.Location = New System.Drawing.Point(160, 97)
        Me.txt_id.Name = "txt_id"
        Me.txt_id.Size = New System.Drawing.Size(113, 20)
        Me.txt_id.TabIndex = 4
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(74, 100)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(72, 13)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "เลขที่สมาชิก : "
        '
        'txt_conid
        '
        Me.txt_conid.Enabled = False
        Me.txt_conid.Location = New System.Drawing.Point(160, 71)
        Me.txt_conid.Name = "txt_conid"
        Me.txt_conid.Size = New System.Drawing.Size(113, 20)
        Me.txt_conid.TabIndex = 2
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(371, 100)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(80, 13)
        Me.Label14.TabIndex = 1
        Me.Label14.Text = "ชื่อ - นามสกุล  : "
        '
        'lb_reid
        '
        Me.lb_reid.AutoSize = True
        Me.lb_reid.Location = New System.Drawing.Point(912, 72)
        Me.lb_reid.Name = "lb_reid"
        Me.lb_reid.Size = New System.Drawing.Size(10, 13)
        Me.lb_reid.TabIndex = 19
        Me.lb_reid.Text = "-"
        Me.lb_reid.Visible = False
        '
        'Payment
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.AliceBlue
        Me.ClientSize = New System.Drawing.Size(934, 664)
        Me.Controls.Add(Me.lb_reid)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox4)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Controls.Add(Me.Label1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Payment"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "ระบบบริหารจัดการกลุ่มออมทรัพย์หมู่บ้าน [การชำระเงินกู้]"
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents dtp_date2 As System.Windows.Forms.DateTimePicker
    Friend WithEvents tst_save As System.Windows.Forms.ToolStripSplitButton
    Friend WithEvents tst_print As System.Windows.Forms.ToolStripSplitButton
    Friend WithEvents tst_back As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStrip1 As System.Windows.Forms.ToolStrip
    Friend WithEvents GroupBox4 As System.Windows.Forms.GroupBox
    Friend WithEvents txt_pay As System.Windows.Forms.TextBox
    Friend WithEvents Label20 As System.Windows.Forms.Label
    Friend WithEvents Label21 As System.Windows.Forms.Label
    Friend WithEvents txt_balance As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents txt_age As System.Windows.Forms.TextBox
    Friend WithEvents txt_loan As System.Windows.Forms.TextBox
    Friend WithEvents dtp_date1 As System.Windows.Forms.DateTimePicker
    Friend WithEvents txt_month As System.Windows.Forms.TextBox
    Friend WithEvents txt_vocation As System.Windows.Forms.TextBox
    Friend WithEvents txt_personalid As System.Windows.Forms.TextBox
    Friend WithEvents Label26 As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
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
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents txt_sum As System.Windows.Forms.TextBox
    Friend WithEvents Label18 As System.Windows.Forms.Label
    Friend WithEvents txt_interest As System.Windows.Forms.TextBox
    Friend WithEvents txt_sumprice As System.Windows.Forms.TextBox
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents txt_create As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents tst_clear As System.Windows.Forms.ToolStripSplitButton
    Friend WithEvents lb_reid As System.Windows.Forms.Label
    Friend WithEvents btn_Search1 As System.Windows.Forms.Button
    Friend WithEvents Lab As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txt_mulct As System.Windows.Forms.TextBox
End Class

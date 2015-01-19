<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class home2
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(home2))
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.ToolStripSplitButton1 = New System.Windows.Forms.ToolStripSplitButton()
        Me.st_officer = New System.Windows.Forms.ToolStripSplitButton()
        Me.st_Village_Saving = New System.Windows.Forms.ToolStripMenuItem()
        Me.st_Register = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripButton1 = New System.Windows.Forms.ToolStripSplitButton()
        Me.st_Add = New System.Windows.Forms.ToolStripMenuItem()
        Me.st_Edit = New System.Windows.Forms.ToolStripMenuItem()
        Me.st_search = New System.Windows.Forms.ToolStripMenuItem()
        Me.st_nc_customers = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripButton2 = New System.Windows.Forms.ToolStripSplitButton()
        Me.st_Deposit = New System.Windows.Forms.ToolStripMenuItem()
        Me.st_nc_deposit = New System.Windows.Forms.ToolStripMenuItem()
        Me.st_Withdrawal = New System.Windows.Forms.ToolStripMenuItem()
        Me.st_nc_withdrawal = New System.Windows.Forms.ToolStripMenuItem()
        Me.st_Contract = New System.Windows.Forms.ToolStripMenuItem()
        Me.st_nc_contracts = New System.Windows.Forms.ToolStripMenuItem()
        Me.st_Payment = New System.Windows.Forms.ToolStripMenuItem()
        Me.st_nc_payment = New System.Windows.Forms.ToolStripMenuItem()
        Me.st_dividend = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripButton3 = New System.Windows.Forms.ToolStripSplitButton()
        Me.st_Fer_Add = New System.Windows.Forms.ToolStripMenuItem()
        Me.st_Fer_Stock = New System.Windows.Forms.ToolStripMenuItem()
        Me.st_nc_ferstock = New System.Windows.Forms.ToolStripMenuItem()
        Me.st_Fer_Con = New System.Windows.Forms.ToolStripMenuItem()
        Me.st_nc_fercon = New System.Windows.Forms.ToolStripMenuItem()
        Me.st_Fer_Pay = New System.Windows.Forms.ToolStripMenuItem()
        Me.st_nc_ferpay = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripButton4 = New System.Windows.Forms.ToolStripSplitButton()
        Me.st_Oil_Add = New System.Windows.Forms.ToolStripMenuItem()
        Me.st_Oil_Stock = New System.Windows.Forms.ToolStripMenuItem()
        Me.st_nc_oilstock = New System.Windows.Forms.ToolStripMenuItem()
        Me.st_Oil_Con = New System.Windows.Forms.ToolStripMenuItem()
        Me.st_nc_oilcon = New System.Windows.Forms.ToolStripMenuItem()
        Me.st_Oil_Pay = New System.Windows.Forms.ToolStripMenuItem()
        Me.st_nc_oilpay = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripButton6 = New System.Windows.Forms.ToolStripSplitButton()
        Me.st_Help = New System.Windows.Forms.ToolStripMenuItem()
        Me.st_Close = New System.Windows.Forms.ToolStripButton()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lb_reid = New System.Windows.Forms.Label()
        Me.lb_loginid = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.ToolStrip1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ToolStrip1
        '
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripSplitButton1, Me.st_officer, Me.ToolStripButton1, Me.ToolStripButton2, Me.ToolStripButton3, Me.ToolStripButton4, Me.ToolStripButton6, Me.st_Close})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(884, 72)
        Me.ToolStrip1.TabIndex = 20
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'ToolStripSplitButton1
        '
        Me.ToolStripSplitButton1.Image = Global.Village_Saving_Management_System.My.Resources.Resources.home_icon
        Me.ToolStripSplitButton1.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.ToolStripSplitButton1.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripSplitButton1.Name = "ToolStripSplitButton1"
        Me.ToolStripSplitButton1.Size = New System.Drawing.Size(66, 69)
        Me.ToolStripSplitButton1.Text = "หน้าหลัก"
        Me.ToolStripSplitButton1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'st_officer
        '
        Me.st_officer.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.st_Village_Saving, Me.st_Register})
        Me.st_officer.Image = Global.Village_Saving_Management_System.My.Resources.Resources.officer_icon
        Me.st_officer.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.st_officer.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.st_officer.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.st_officer.Name = "st_officer"
        Me.st_officer.Size = New System.Drawing.Size(66, 69)
        Me.st_officer.Text = "เจ้าหน้าที่"
        Me.st_officer.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.st_officer.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'st_Village_Saving
        '
        Me.st_Village_Saving.Name = "st_Village_Saving"
        Me.st_Village_Saving.Size = New System.Drawing.Size(201, 22)
        Me.st_Village_Saving.Text = "ข้อมูลกลุ่มออมทรัพย์หมู่บ้าน"
        '
        'st_Register
        '
        Me.st_Register.Name = "st_Register"
        Me.st_Register.Size = New System.Drawing.Size(201, 22)
        Me.st_Register.Text = "ผู้ใช้และรหัสผ่าน"
        '
        'ToolStripButton1
        '
        Me.ToolStripButton1.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.st_Add, Me.st_Edit, Me.st_search, Me.st_nc_customers})
        Me.ToolStripButton1.Image = Global.Village_Saving_Management_System.My.Resources.Resources.membericon
        Me.ToolStripButton1.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.ToolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton1.Name = "ToolStripButton1"
        Me.ToolStripButton1.Size = New System.Drawing.Size(66, 69)
        Me.ToolStripButton1.Text = "สมาชิก"
        Me.ToolStripButton1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'st_Add
        '
        Me.st_Add.Name = "st_Add"
        Me.st_Add.Size = New System.Drawing.Size(160, 22)
        Me.st_Add.Text = "เพิ่มสมาชิกใหม่"
        '
        'st_Edit
        '
        Me.st_Edit.Name = "st_Edit"
        Me.st_Edit.Size = New System.Drawing.Size(160, 22)
        Me.st_Edit.Text = "แก้ไขข้อมูลสมาชิก"
        '
        'st_search
        '
        Me.st_search.Name = "st_search"
        Me.st_search.Size = New System.Drawing.Size(160, 22)
        Me.st_search.Text = "ค้นหาข้อมูลสมาชิก"
        '
        'st_nc_customers
        '
        Me.st_nc_customers.Name = "st_nc_customers"
        Me.st_nc_customers.Size = New System.Drawing.Size(160, 22)
        Me.st_nc_customers.Text = "แจ้งยกเลิกสมาชิก"
        '
        'ToolStripButton2
        '
        Me.ToolStripButton2.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.st_Deposit, Me.st_Withdrawal, Me.st_Contract, Me.st_Payment, Me.st_dividend})
        Me.ToolStripButton2.Image = Global.Village_Saving_Management_System.My.Resources.Resources.piggy_bank
        Me.ToolStripButton2.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.ToolStripButton2.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton2.Name = "ToolStripButton2"
        Me.ToolStripButton2.Size = New System.Drawing.Size(66, 69)
        Me.ToolStripButton2.Text = "การเงิน"
        Me.ToolStripButton2.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'st_Deposit
        '
        Me.st_Deposit.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.st_nc_deposit})
        Me.st_Deposit.Name = "st_Deposit"
        Me.st_Deposit.Size = New System.Drawing.Size(140, 22)
        Me.st_Deposit.Text = "ฝากเงิน"
        '
        'st_nc_deposit
        '
        Me.st_nc_deposit.Name = "st_nc_deposit"
        Me.st_nc_deposit.Size = New System.Drawing.Size(180, 22)
        Me.st_nc_deposit.Text = "แจ้งยกเลิกรายการฝาก"
        '
        'st_Withdrawal
        '
        Me.st_Withdrawal.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.st_nc_withdrawal})
        Me.st_Withdrawal.Name = "st_Withdrawal"
        Me.st_Withdrawal.Size = New System.Drawing.Size(140, 22)
        Me.st_Withdrawal.Text = "ถอนเงิน"
        '
        'st_nc_withdrawal
        '
        Me.st_nc_withdrawal.Name = "st_nc_withdrawal"
        Me.st_nc_withdrawal.Size = New System.Drawing.Size(182, 22)
        Me.st_nc_withdrawal.Text = "แจ้งยกเลิกรายการถอน"
        '
        'st_Contract
        '
        Me.st_Contract.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.st_nc_contracts})
        Me.st_Contract.Name = "st_Contract"
        Me.st_Contract.Size = New System.Drawing.Size(140, 22)
        Me.st_Contract.Text = "สัญญาเงินกู้"
        '
        'st_nc_contracts
        '
        Me.st_nc_contracts.Name = "st_nc_contracts"
        Me.st_nc_contracts.Size = New System.Drawing.Size(179, 22)
        Me.st_nc_contracts.Text = "แจ้งยกเลิกสัญญาเงินกู้"
        '
        'st_Payment
        '
        Me.st_Payment.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.st_nc_payment})
        Me.st_Payment.Name = "st_Payment"
        Me.st_Payment.Size = New System.Drawing.Size(140, 22)
        Me.st_Payment.Text = "การชำระเงินกู้"
        '
        'st_nc_payment
        '
        Me.st_nc_payment.Name = "st_nc_payment"
        Me.st_nc_payment.Size = New System.Drawing.Size(209, 22)
        Me.st_nc_payment.Text = "แจ้งยกเลิกรายงานชำระเงินกู้"
        '
        'st_dividend
        '
        Me.st_dividend.Name = "st_dividend"
        Me.st_dividend.Size = New System.Drawing.Size(140, 22)
        Me.st_dividend.Text = "ปันผลประจำปี"
        '
        'ToolStripButton3
        '
        Me.ToolStripButton3.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.st_Fer_Add, Me.st_Fer_Stock, Me.st_Fer_Con, Me.st_Fer_Pay})
        Me.ToolStripButton3.Image = Global.Village_Saving_Management_System.My.Resources.Resources.Fertilizer_II
        Me.ToolStripButton3.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.ToolStripButton3.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton3.Name = "ToolStripButton3"
        Me.ToolStripButton3.Size = New System.Drawing.Size(66, 69)
        Me.ToolStripButton3.Text = "ปุ๋ย"
        Me.ToolStripButton3.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'st_Fer_Add
        '
        Me.st_Fer_Add.Name = "st_Fer_Add"
        Me.st_Fer_Add.Size = New System.Drawing.Size(191, 22)
        Me.st_Fer_Add.Text = "เพิ่มสูตรปุ๋ย"
        '
        'st_Fer_Stock
        '
        Me.st_Fer_Stock.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.st_nc_ferstock})
        Me.st_Fer_Stock.Name = "st_Fer_Stock"
        Me.st_Fer_Stock.Size = New System.Drawing.Size(191, 22)
        Me.st_Fer_Stock.Text = "บันทึกการรับปุ๋ยเข้าสต๊อค"
        '
        'st_nc_ferstock
        '
        Me.st_nc_ferstock.Name = "st_nc_ferstock"
        Me.st_nc_ferstock.Size = New System.Drawing.Size(231, 22)
        Me.st_nc_ferstock.Text = "แจ้งยกเลิกรายการรับปุ๋ยเข้าสต็อก"
        '
        'st_Fer_Con
        '
        Me.st_Fer_Con.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.st_nc_fercon})
        Me.st_Fer_Con.Name = "st_Fer_Con"
        Me.st_Fer_Con.Size = New System.Drawing.Size(191, 22)
        Me.st_Fer_Con.Text = "สัญญากู้ปุ๋ย"
        '
        'st_nc_fercon
        '
        Me.st_nc_fercon.Name = "st_nc_fercon"
        Me.st_nc_fercon.Size = New System.Drawing.Size(175, 22)
        Me.st_nc_fercon.Text = "แจ้งยกเลิกสัญญากู้ปุ๋ย"
        '
        'st_Fer_Pay
        '
        Me.st_Fer_Pay.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.st_nc_ferpay})
        Me.st_Fer_Pay.Name = "st_Fer_Pay"
        Me.st_Fer_Pay.Size = New System.Drawing.Size(191, 22)
        Me.st_Fer_Pay.Text = "ชำระเงินค่าปุ๋ย"
        '
        'st_nc_ferpay
        '
        Me.st_nc_ferpay.Name = "st_nc_ferpay"
        Me.st_nc_ferpay.Size = New System.Drawing.Size(210, 22)
        Me.st_nc_ferpay.Text = "แจ้งยกเลิกรายการชำระค่าปุ๋ย"
        '
        'ToolStripButton4
        '
        Me.ToolStripButton4.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.st_Oil_Add, Me.st_Oil_Stock, Me.st_Oil_Con, Me.st_Oil_Pay})
        Me.ToolStripButton4.Image = Global.Village_Saving_Management_System.My.Resources.Resources.oilicon
        Me.ToolStripButton4.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.ToolStripButton4.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton4.Name = "ToolStripButton4"
        Me.ToolStripButton4.Size = New System.Drawing.Size(66, 69)
        Me.ToolStripButton4.Text = "น้ำมัน"
        Me.ToolStripButton4.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'st_Oil_Add
        '
        Me.st_Oil_Add.Name = "st_Oil_Add"
        Me.st_Oil_Add.Size = New System.Drawing.Size(205, 22)
        Me.st_Oil_Add.Text = "เพิ่มชนิดน้ำมัน"
        '
        'st_Oil_Stock
        '
        Me.st_Oil_Stock.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.st_nc_oilstock})
        Me.st_Oil_Stock.Name = "st_Oil_Stock"
        Me.st_Oil_Stock.Size = New System.Drawing.Size(205, 22)
        Me.st_Oil_Stock.Text = "บันทึกการรับน้ำมันเข้าสต๊อค"
        '
        'st_nc_oilstock
        '
        Me.st_nc_oilstock.Name = "st_nc_oilstock"
        Me.st_nc_oilstock.Size = New System.Drawing.Size(245, 22)
        Me.st_nc_oilstock.Text = "แจ้งยกเลิกรายการรับน้ำมันเข้าสต็อก"
        '
        'st_Oil_Con
        '
        Me.st_Oil_Con.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.st_nc_oilcon})
        Me.st_Oil_Con.Name = "st_Oil_Con"
        Me.st_Oil_Con.Size = New System.Drawing.Size(205, 22)
        Me.st_Oil_Con.Text = "สัญญากู้น้ำมัน"
        '
        'st_nc_oilcon
        '
        Me.st_nc_oilcon.Name = "st_nc_oilcon"
        Me.st_nc_oilcon.Size = New System.Drawing.Size(189, 22)
        Me.st_nc_oilcon.Text = "แจ้งยกเลิกสัญญากู้น้ำมัน"
        '
        'st_Oil_Pay
        '
        Me.st_Oil_Pay.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.st_nc_oilpay})
        Me.st_Oil_Pay.Name = "st_Oil_Pay"
        Me.st_Oil_Pay.Size = New System.Drawing.Size(205, 22)
        Me.st_Oil_Pay.Text = "ชำระเงินค่าน้ำมัน"
        '
        'st_nc_oilpay
        '
        Me.st_nc_oilpay.Name = "st_nc_oilpay"
        Me.st_nc_oilpay.Size = New System.Drawing.Size(224, 22)
        Me.st_nc_oilpay.Text = "แจ้งยกเลิกรายการชำระค่าน้ำมัน"
        '
        'ToolStripButton6
        '
        Me.ToolStripButton6.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.st_Help})
        Me.ToolStripButton6.Image = Global.Village_Saving_Management_System.My.Resources.Resources.Help
        Me.ToolStripButton6.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.ToolStripButton6.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton6.Name = "ToolStripButton6"
        Me.ToolStripButton6.Size = New System.Drawing.Size(67, 69)
        Me.ToolStripButton6.Text = "ช่วยเหลือ"
        Me.ToolStripButton6.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'st_Help
        '
        Me.st_Help.Name = "st_Help"
        Me.st_Help.Size = New System.Drawing.Size(173, 22)
        Me.st_Help.Text = "วิธีการใช้งานเบื้องต้น"
        '
        'st_Close
        '
        Me.st_Close.Image = Global.Village_Saving_Management_System.My.Resources.Resources.exit_icon
        Me.st_Close.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.st_Close.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.st_Close.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.st_Close.Name = "st_Close"
        Me.st_Close.Size = New System.Drawing.Size(73, 69)
        Me.st_Close.Text = "ออกจากระบบ"
        Me.st_Close.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Cordia New", 36.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label2.Location = New System.Drawing.Point(403, 201)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(543, 60)
        Me.Label2.TabIndex = 22
        Me.Label2.Text = "Village Saving Management System"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Cordia New", 48.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label1.Location = New System.Drawing.Point(240, 105)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(836, 80)
        Me.Label1.TabIndex = 21
        Me.Label1.Text = "ระบบบริหารจัดการกลุ่มออมทรัพย์หมู่บ้าน"
        '
        'lb_reid
        '
        Me.lb_reid.AutoSize = True
        Me.lb_reid.Location = New System.Drawing.Point(12, 85)
        Me.lb_reid.Name = "lb_reid"
        Me.lb_reid.Size = New System.Drawing.Size(10, 13)
        Me.lb_reid.TabIndex = 25
        Me.lb_reid.Text = "-"
        Me.lb_reid.Visible = False
        '
        'lb_loginid
        '
        Me.lb_loginid.AutoSize = True
        Me.lb_loginid.Location = New System.Drawing.Point(12, 72)
        Me.lb_loginid.Name = "lb_loginid"
        Me.lb_loginid.Size = New System.Drawing.Size(10, 13)
        Me.lb_loginid.TabIndex = 24
        Me.lb_loginid.Text = "-"
        Me.lb_loginid.Visible = False
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(581, 289)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(256, 256)
        Me.PictureBox1.TabIndex = 23
        Me.PictureBox1.TabStop = False
        '
        'home2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.AliceBlue
        Me.ClientSize = New System.Drawing.Size(884, 664)
        Me.Controls.Add(Me.lb_reid)
        Me.Controls.Add(Me.lb_loginid)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "home2"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "ระบบบริหารจัดการกลุ่มออมทรัพย์หมู่บ้าน [หน้าหลัก]"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ToolStrip1 As System.Windows.Forms.ToolStrip
    Friend WithEvents ToolStripSplitButton1 As System.Windows.Forms.ToolStripSplitButton
    Friend WithEvents st_officer As System.Windows.Forms.ToolStripSplitButton
    Friend WithEvents st_Register As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripButton1 As System.Windows.Forms.ToolStripSplitButton
    Friend WithEvents st_search As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents st_Add As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents st_Edit As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripButton2 As System.Windows.Forms.ToolStripSplitButton
    Friend WithEvents st_Deposit As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents st_Withdrawal As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents st_Contract As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents st_Payment As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents st_dividend As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripButton3 As System.Windows.Forms.ToolStripSplitButton
    Friend WithEvents st_Fer_Stock As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents st_Fer_Con As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents st_Fer_Pay As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripButton4 As System.Windows.Forms.ToolStripSplitButton
    Friend WithEvents st_Oil_Stock As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents st_Oil_Con As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents st_Oil_Pay As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripButton6 As System.Windows.Forms.ToolStripSplitButton
    Friend WithEvents st_Help As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents st_Close As System.Windows.Forms.ToolStripButton
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents lb_reid As System.Windows.Forms.Label
    Friend WithEvents lb_loginid As System.Windows.Forms.Label
    Friend WithEvents st_Village_Saving As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents st_Fer_Add As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents st_Oil_Add As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents st_nc_customers As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents st_nc_deposit As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents st_nc_withdrawal As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents st_nc_contracts As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents st_nc_payment As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents st_nc_ferstock As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents st_nc_fercon As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents st_nc_ferpay As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents st_nc_oilstock As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents st_nc_oilcon As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents st_nc_oilpay As System.Windows.Forms.ToolStripMenuItem
End Class

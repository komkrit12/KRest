<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Home
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Home))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.st_home = New System.Windows.Forms.ToolStripSplitButton()
        Me.st_officer = New System.Windows.Forms.ToolStripSplitButton()
        Me.st_Village_Saving = New System.Windows.Forms.ToolStripMenuItem()
        Me.st_Register = New System.Windows.Forms.ToolStripMenuItem()
        Me.st_check = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripButton1 = New System.Windows.Forms.ToolStripSplitButton()
        Me.st_Add = New System.Windows.Forms.ToolStripMenuItem()
        Me.st_Edit = New System.Windows.Forms.ToolStripMenuItem()
        Me.st_search = New System.Windows.Forms.ToolStripMenuItem()
        Me.st_cc_customers = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripButton2 = New System.Windows.Forms.ToolStripSplitButton()
        Me.st_Deposit = New System.Windows.Forms.ToolStripMenuItem()
        Me.st_cc_deposit = New System.Windows.Forms.ToolStripMenuItem()
        Me.st_Withdrawal = New System.Windows.Forms.ToolStripMenuItem()
        Me.st_cc_withdrawal = New System.Windows.Forms.ToolStripMenuItem()
        Me.st_Contract = New System.Windows.Forms.ToolStripMenuItem()
        Me.st_cc_contracts = New System.Windows.Forms.ToolStripMenuItem()
        Me.st_Payment = New System.Windows.Forms.ToolStripMenuItem()
        Me.st_cc_payment = New System.Windows.Forms.ToolStripMenuItem()
        Me.st_dividend = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripButton3 = New System.Windows.Forms.ToolStripSplitButton()
        Me.st_Fer_Add = New System.Windows.Forms.ToolStripMenuItem()
        Me.st_Fer_Stock = New System.Windows.Forms.ToolStripMenuItem()
        Me.st_cc_ferstock = New System.Windows.Forms.ToolStripMenuItem()
        Me.st_Fer_Con = New System.Windows.Forms.ToolStripMenuItem()
        Me.st_cc_fercon = New System.Windows.Forms.ToolStripMenuItem()
        Me.st_Fer_Pay = New System.Windows.Forms.ToolStripMenuItem()
        Me.st_cc_ferpay = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripButton4 = New System.Windows.Forms.ToolStripSplitButton()
        Me.st_Oil_Add = New System.Windows.Forms.ToolStripMenuItem()
        Me.st_Oil_Stock = New System.Windows.Forms.ToolStripMenuItem()
        Me.st_cc_oilstock = New System.Windows.Forms.ToolStripMenuItem()
        Me.st_Oil_Con = New System.Windows.Forms.ToolStripMenuItem()
        Me.st_cc_oilcon = New System.Windows.Forms.ToolStripMenuItem()
        Me.st_Oil_Pay = New System.Windows.Forms.ToolStripMenuItem()
        Me.st_cc_oilpay = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripButton5 = New System.Windows.Forms.ToolStripSplitButton()
        Me.st_Re_cust = New System.Windows.Forms.ToolStripMenuItem()
        Me.st_Re_deposit = New System.Windows.Forms.ToolStripMenuItem()
        Me.tst_withdrawal = New System.Windows.Forms.ToolStripMenuItem()
        Me.st_Re_loan = New System.Windows.Forms.ToolStripMenuItem()
        Me.st_Re_payment = New System.Windows.Forms.ToolStripMenuItem()
        Me.st_Re_fercon = New System.Windows.Forms.ToolStripMenuItem()
        Me.st_Re_ferpay = New System.Windows.Forms.ToolStripMenuItem()
        Me.st_Re_oilcon = New System.Windows.Forms.ToolStripMenuItem()
        Me.st_Re_oilpay = New System.Windows.Forms.ToolStripMenuItem()
        Me.st_Re_dividend = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripButton6 = New System.Windows.Forms.ToolStripSplitButton()
        Me.st_Help = New System.Windows.Forms.ToolStripMenuItem()
        Me.st_Close = New System.Windows.Forms.ToolStripButton()
        Me.lb_loginid = New System.Windows.Forms.Label()
        Me.lb_reid = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.ToolStrip1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Cordia New", 48.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label1.Location = New System.Drawing.Point(274, 120)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(836, 80)
        Me.Label1.TabIndex = 17
        Me.Label1.Text = "ระบบบริหารจัดการกลุ่มออมทรัพย์หมู่บ้าน"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Cordia New", 36.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label2.Location = New System.Drawing.Point(405, 219)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(543, 60)
        Me.Label2.TabIndex = 18
        Me.Label2.Text = "Village Saving Management System"
        '
        'ToolStrip1
        '
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.st_home, Me.st_officer, Me.ToolStripButton1, Me.ToolStripButton2, Me.ToolStripButton3, Me.ToolStripButton4, Me.ToolStripButton5, Me.ToolStripButton6, Me.st_Close})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(884, 72)
        Me.ToolStrip1.TabIndex = 19
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'st_home
        '
        Me.st_home.Image = Global.Village_Saving_Management_System.My.Resources.Resources.home_icon
        Me.st_home.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.st_home.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.st_home.Name = "st_home"
        Me.st_home.Size = New System.Drawing.Size(66, 69)
        Me.st_home.Text = "หน้าหลัก"
        Me.st_home.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'st_officer
        '
        Me.st_officer.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.st_Village_Saving, Me.st_Register, Me.st_check})
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
        Me.st_Village_Saving.Size = New System.Drawing.Size(198, 22)
        Me.st_Village_Saving.Text = "ข้อมูลกลุ่มออมทรัพย์หมู่บ้าน"
        '
        'st_Register
        '
        Me.st_Register.Name = "st_Register"
        Me.st_Register.Size = New System.Drawing.Size(198, 22)
        Me.st_Register.Text = "ผู้ใช้และรหัสผ่าน"
        '
        'st_check
        '
        Me.st_check.Name = "st_check"
        Me.st_check.Size = New System.Drawing.Size(198, 22)
        Me.st_check.Text = "ตรวจสอบการใช้งาน"
        '
        'ToolStripButton1
        '
        Me.ToolStripButton1.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.st_Add, Me.st_Edit, Me.st_search, Me.st_cc_customers})
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
        Me.st_Add.Size = New System.Drawing.Size(158, 22)
        Me.st_Add.Text = "เพิ่มสมาชิกใหม่"
        '
        'st_Edit
        '
        Me.st_Edit.Name = "st_Edit"
        Me.st_Edit.Size = New System.Drawing.Size(158, 22)
        Me.st_Edit.Text = "แก้ไขข้อมูลสมาชิก"
        '
        'st_search
        '
        Me.st_search.Name = "st_search"
        Me.st_search.Size = New System.Drawing.Size(158, 22)
        Me.st_search.Text = "ค้นหาข้อมูลสมาชิก"
        '
        'st_cc_customers
        '
        Me.st_cc_customers.Name = "st_cc_customers"
        Me.st_cc_customers.Size = New System.Drawing.Size(158, 22)
        Me.st_cc_customers.Text = "ยกเลิกสมาชิก"
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
        Me.st_Deposit.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.st_cc_deposit})
        Me.st_Deposit.Name = "st_Deposit"
        Me.st_Deposit.Size = New System.Drawing.Size(135, 22)
        Me.st_Deposit.Text = "ฝากเงิน"
        '
        'st_cc_deposit
        '
        Me.st_cc_deposit.Name = "st_cc_deposit"
        Me.st_cc_deposit.Size = New System.Drawing.Size(155, 22)
        Me.st_cc_deposit.Text = "ยกเลิกรายการฝาก"
        '
        'st_Withdrawal
        '
        Me.st_Withdrawal.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.st_cc_withdrawal})
        Me.st_Withdrawal.Name = "st_Withdrawal"
        Me.st_Withdrawal.Size = New System.Drawing.Size(135, 22)
        Me.st_Withdrawal.Text = "ถอนเงิน"
        '
        'st_cc_withdrawal
        '
        Me.st_cc_withdrawal.Name = "st_cc_withdrawal"
        Me.st_cc_withdrawal.Size = New System.Drawing.Size(156, 22)
        Me.st_cc_withdrawal.Text = "ยกเลิกรายการถอน"
        '
        'st_Contract
        '
        Me.st_Contract.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.st_cc_contracts})
        Me.st_Contract.Name = "st_Contract"
        Me.st_Contract.Size = New System.Drawing.Size(135, 22)
        Me.st_Contract.Text = "สัญญาเงินกู้"
        '
        'st_cc_contracts
        '
        Me.st_cc_contracts.Name = "st_cc_contracts"
        Me.st_cc_contracts.Size = New System.Drawing.Size(156, 22)
        Me.st_cc_contracts.Text = "ยกเลิกสัญญาเงินกู้"
        '
        'st_Payment
        '
        Me.st_Payment.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.st_cc_payment})
        Me.st_Payment.Name = "st_Payment"
        Me.st_Payment.Size = New System.Drawing.Size(135, 22)
        Me.st_Payment.Text = "การชำระเงินกู้"
        '
        'st_cc_payment
        '
        Me.st_cc_payment.Name = "st_cc_payment"
        Me.st_cc_payment.Size = New System.Drawing.Size(179, 22)
        Me.st_cc_payment.Text = "ยกเลิกรายงานชำระเงินกู้"
        '
        'st_dividend
        '
        Me.st_dividend.Name = "st_dividend"
        Me.st_dividend.Size = New System.Drawing.Size(135, 22)
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
        Me.st_Fer_Add.Size = New System.Drawing.Size(185, 22)
        Me.st_Fer_Add.Text = "เพิ่มสูตรปุ๋ย"
        '
        'st_Fer_Stock
        '
        Me.st_Fer_Stock.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.st_cc_ferstock})
        Me.st_Fer_Stock.Name = "st_Fer_Stock"
        Me.st_Fer_Stock.Size = New System.Drawing.Size(185, 22)
        Me.st_Fer_Stock.Text = "บันทึกการรับปุ๋ยเข้าสต๊อค"
        '
        'st_cc_ferstock
        '
        Me.st_cc_ferstock.Name = "st_cc_ferstock"
        Me.st_cc_ferstock.Size = New System.Drawing.Size(202, 22)
        Me.st_cc_ferstock.Text = "ยกเลิกรายการรับปุ๋ยเข้าสต็อก"
        '
        'st_Fer_Con
        '
        Me.st_Fer_Con.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.st_cc_fercon})
        Me.st_Fer_Con.Name = "st_Fer_Con"
        Me.st_Fer_Con.Size = New System.Drawing.Size(185, 22)
        Me.st_Fer_Con.Text = "สัญญากู้ปุ๋ย"
        '
        'st_cc_fercon
        '
        Me.st_cc_fercon.Name = "st_cc_fercon"
        Me.st_cc_fercon.Size = New System.Drawing.Size(154, 22)
        Me.st_cc_fercon.Text = "ยกเลิกสัญญากู้ปุ๋ย"
        '
        'st_Fer_Pay
        '
        Me.st_Fer_Pay.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.st_cc_ferpay})
        Me.st_Fer_Pay.Name = "st_Fer_Pay"
        Me.st_Fer_Pay.Size = New System.Drawing.Size(185, 22)
        Me.st_Fer_Pay.Text = "ชำระเงินค่าปุ๋ย"
        '
        'st_cc_ferpay
        '
        Me.st_cc_ferpay.Name = "st_cc_ferpay"
        Me.st_cc_ferpay.Size = New System.Drawing.Size(182, 22)
        Me.st_cc_ferpay.Text = "ยกเลิกรายการชำระค่าปุ๋ย"
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
        Me.st_Oil_Add.Size = New System.Drawing.Size(198, 22)
        Me.st_Oil_Add.Text = "เพิ่มชนิดน้ำมัน"
        '
        'st_Oil_Stock
        '
        Me.st_Oil_Stock.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.st_cc_oilstock})
        Me.st_Oil_Stock.Name = "st_Oil_Stock"
        Me.st_Oil_Stock.Size = New System.Drawing.Size(198, 22)
        Me.st_Oil_Stock.Text = "บันทึกการรับน้ำมันเข้าสต๊อค"
        '
        'st_cc_oilstock
        '
        Me.st_cc_oilstock.Name = "st_cc_oilstock"
        Me.st_cc_oilstock.Size = New System.Drawing.Size(215, 22)
        Me.st_cc_oilstock.Text = "ยกเลิกรายการรับน้ำมันเข้าสต็อก"
        '
        'st_Oil_Con
        '
        Me.st_Oil_Con.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.st_cc_oilcon})
        Me.st_Oil_Con.Name = "st_Oil_Con"
        Me.st_Oil_Con.Size = New System.Drawing.Size(198, 22)
        Me.st_Oil_Con.Text = "สัญญากู้น้ำมัน"
        '
        'st_cc_oilcon
        '
        Me.st_cc_oilcon.Name = "st_cc_oilcon"
        Me.st_cc_oilcon.Size = New System.Drawing.Size(167, 22)
        Me.st_cc_oilcon.Text = "ยกเลิกสัญญากู้น้ำมัน"
        '
        'st_Oil_Pay
        '
        Me.st_Oil_Pay.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.st_cc_oilpay})
        Me.st_Oil_Pay.Name = "st_Oil_Pay"
        Me.st_Oil_Pay.Size = New System.Drawing.Size(198, 22)
        Me.st_Oil_Pay.Text = "ชำระเงินค่าน้ำมัน"
        '
        'st_cc_oilpay
        '
        Me.st_cc_oilpay.Name = "st_cc_oilpay"
        Me.st_cc_oilpay.Size = New System.Drawing.Size(182, 22)
        Me.st_cc_oilpay.Text = "ยกเลิกรายการชำระค่าปุ๋ย"
        '
        'ToolStripButton5
        '
        Me.ToolStripButton5.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.st_Re_cust, Me.st_Re_deposit, Me.tst_withdrawal, Me.st_Re_loan, Me.st_Re_payment, Me.st_Re_fercon, Me.st_Re_ferpay, Me.st_Re_oilcon, Me.st_Re_oilpay, Me.st_Re_dividend})
        Me.ToolStripButton5.Image = Global.Village_Saving_Management_System.My.Resources.Resources.iconreports
        Me.ToolStripButton5.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.ToolStripButton5.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton5.Name = "ToolStripButton5"
        Me.ToolStripButton5.Size = New System.Drawing.Size(66, 69)
        Me.ToolStripButton5.Text = "รายงาน"
        Me.ToolStripButton5.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'st_Re_cust
        '
        Me.st_Re_cust.Name = "st_Re_cust"
        Me.st_Re_cust.Size = New System.Drawing.Size(202, 22)
        Me.st_Re_cust.Text = "สรุปยอดสมาชิก"
        '
        'st_Re_deposit
        '
        Me.st_Re_deposit.Name = "st_Re_deposit"
        Me.st_Re_deposit.Size = New System.Drawing.Size(202, 22)
        Me.st_Re_deposit.Text = "สรุปยอดเงินฝาก"
        '
        'tst_withdrawal
        '
        Me.tst_withdrawal.Name = "tst_withdrawal"
        Me.tst_withdrawal.Size = New System.Drawing.Size(202, 22)
        Me.tst_withdrawal.Text = "สรุปยอดเงินถอน"
        '
        'st_Re_loan
        '
        Me.st_Re_loan.Name = "st_Re_loan"
        Me.st_Re_loan.Size = New System.Drawing.Size(202, 22)
        Me.st_Re_loan.Text = "สรุปยอดเงินกู้"
        '
        'st_Re_payment
        '
        Me.st_Re_payment.Name = "st_Re_payment"
        Me.st_Re_payment.Size = New System.Drawing.Size(202, 22)
        Me.st_Re_payment.Text = "สรุปยอดการชำระเงินกู้"
        '
        'st_Re_fercon
        '
        Me.st_Re_fercon.Name = "st_Re_fercon"
        Me.st_Re_fercon.Size = New System.Drawing.Size(202, 22)
        Me.st_Re_fercon.Text = "สรุปยอดสัญญาซื้อปุ๋ย"
        '
        'st_Re_ferpay
        '
        Me.st_Re_ferpay.Name = "st_Re_ferpay"
        Me.st_Re_ferpay.Size = New System.Drawing.Size(202, 22)
        Me.st_Re_ferpay.Text = "สรุปยอดการชำระเงินค่าปุ๋ย"
        '
        'st_Re_oilcon
        '
        Me.st_Re_oilcon.Name = "st_Re_oilcon"
        Me.st_Re_oilcon.Size = New System.Drawing.Size(202, 22)
        Me.st_Re_oilcon.Text = "สรุปยอดสัญญาซื้อน้ำมัน"
        '
        'st_Re_oilpay
        '
        Me.st_Re_oilpay.Name = "st_Re_oilpay"
        Me.st_Re_oilpay.Size = New System.Drawing.Size(202, 22)
        Me.st_Re_oilpay.Text = "สรุปยอดการชำระเงินค่าน้ำมัน"
        '
        'st_Re_dividend
        '
        Me.st_Re_dividend.Name = "st_Re_dividend"
        Me.st_Re_dividend.Size = New System.Drawing.Size(202, 22)
        Me.st_Re_dividend.Text = "สรุปยอดเงินปันผลประจำปี"
        '
        'ToolStripButton6
        '
        Me.ToolStripButton6.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.st_Help})
        Me.ToolStripButton6.Image = Global.Village_Saving_Management_System.My.Resources.Resources.Help
        Me.ToolStripButton6.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.ToolStripButton6.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton6.Name = "ToolStripButton6"
        Me.ToolStripButton6.Size = New System.Drawing.Size(66, 69)
        Me.ToolStripButton6.Text = "ช่วยเหลือ"
        Me.ToolStripButton6.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'st_Help
        '
        Me.st_Help.Name = "st_Help"
        Me.st_Help.Size = New System.Drawing.Size(164, 22)
        Me.st_Help.Text = "วิธีการใช้งานเบื้องต้น"
        '
        'st_Close
        '
        Me.st_Close.Image = Global.Village_Saving_Management_System.My.Resources.Resources.exit_icon
        Me.st_Close.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.st_Close.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.st_Close.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.st_Close.Name = "st_Close"
        Me.st_Close.Size = New System.Drawing.Size(71, 69)
        Me.st_Close.Text = "ออกจากระบบ"
        Me.st_Close.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'lb_loginid
        '
        Me.lb_loginid.AutoSize = True
        Me.lb_loginid.Location = New System.Drawing.Point(12, 72)
        Me.lb_loginid.Name = "lb_loginid"
        Me.lb_loginid.Size = New System.Drawing.Size(10, 13)
        Me.lb_loginid.TabIndex = 21
        Me.lb_loginid.Text = "-"
        Me.lb_loginid.Visible = False
        '
        'lb_reid
        '
        Me.lb_reid.AutoSize = True
        Me.lb_reid.Location = New System.Drawing.Point(12, 85)
        Me.lb_reid.Name = "lb_reid"
        Me.lb_reid.Size = New System.Drawing.Size(10, 13)
        Me.lb_reid.TabIndex = 22
        Me.lb_reid.Text = "-"
        Me.lb_reid.Visible = False
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(591, 298)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(256, 256)
        Me.PictureBox1.TabIndex = 20
        Me.PictureBox1.TabStop = False
        '
        'Home
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.AliceBlue
        Me.ClientSize = New System.Drawing.Size(884, 664)
        Me.Controls.Add(Me.lb_reid)
        Me.Controls.Add(Me.lb_loginid)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Home"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "ระบบบริหารจัดการกลุ่มออมทรัพย์หมู่บ้าน [หน้าหลัก]"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents ToolStrip1 As System.Windows.Forms.ToolStrip
    Friend WithEvents st_home As System.Windows.Forms.ToolStripSplitButton
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
    Friend WithEvents ToolStripButton5 As System.Windows.Forms.ToolStripSplitButton
    Friend WithEvents st_Re_deposit As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents st_Re_cust As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents st_Re_loan As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents st_Re_payment As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents st_Re_fercon As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents st_Re_ferpay As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents st_Re_oilcon As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents st_Re_oilpay As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents st_Re_dividend As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripButton6 As System.Windows.Forms.ToolStripSplitButton
    Friend WithEvents st_Help As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents st_Close As System.Windows.Forms.ToolStripButton
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents st_officer As System.Windows.Forms.ToolStripSplitButton
    Friend WithEvents st_Village_Saving As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents st_Register As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents st_check As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents lb_loginid As System.Windows.Forms.Label
    Friend WithEvents lb_reid As System.Windows.Forms.Label
    Friend WithEvents st_Fer_Add As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents st_Oil_Add As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents st_cc_customers As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents st_cc_deposit As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents st_cc_withdrawal As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents st_cc_contracts As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents st_cc_payment As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents st_cc_ferstock As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents st_cc_fercon As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents st_cc_ferpay As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents st_cc_oilstock As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents st_cc_oilcon As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents st_cc_oilpay As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents tst_withdrawal As System.Windows.Forms.ToolStripMenuItem
End Class

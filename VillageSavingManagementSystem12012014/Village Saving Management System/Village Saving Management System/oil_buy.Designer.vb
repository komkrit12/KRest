<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class oil_buy
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(oil_buy))
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.tst_select = New System.Windows.Forms.ToolStripSplitButton()
        Me.tst_confirm = New System.Windows.Forms.ToolStripSplitButton()
        Me.tst_back = New System.Windows.Forms.ToolStripSplitButton()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.txt_sumprice = New System.Windows.Forms.TextBox()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.dtp_date1 = New System.Windows.Forms.DateTimePicker()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.cbo_type = New System.Windows.Forms.ComboBox()
        Me.Label22 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.txt_pay = New System.Windows.Forms.TextBox()
        Me.txt_price = New System.Windows.Forms.TextBox()
        Me.txt_interest = New System.Windows.Forms.TextBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.txt_amount = New System.Windows.Forms.TextBox()
        Me.lb_cus = New System.Windows.Forms.Label()
        Me.lb_id = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.delete = New System.Windows.Forms.DataGridViewButtonColumn()
        Me.contract_oil_no = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.oil_type = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.buy_amount = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.sum_price = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.sum_interest = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.sum = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.pay_date = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.o_id = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ToolStrip1.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ToolStrip1
        '
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tst_select, Me.tst_confirm, Me.tst_back})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(762, 72)
        Me.ToolStrip1.TabIndex = 51
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'tst_select
        '
        Me.tst_select.Image = Global.Village_Saving_Management_System.My.Resources.Resources.tick
        Me.tst_select.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.tst_select.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tst_select.Name = "tst_select"
        Me.tst_select.Size = New System.Drawing.Size(66, 69)
        Me.tst_select.Text = "เลือก"
        Me.tst_select.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'tst_confirm
        '
        Me.tst_confirm.Image = Global.Village_Saving_Management_System.My.Resources.Resources.Shopping
        Me.tst_confirm.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.tst_confirm.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.tst_confirm.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tst_confirm.Name = "tst_confirm"
        Me.tst_confirm.Size = New System.Drawing.Size(78, 69)
        Me.tst_confirm.Text = "ยืนยันการกู้"
        Me.tst_confirm.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.tst_confirm.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'tst_back
        '
        Me.tst_back.Image = Global.Village_Saving_Management_System.My.Resources.Resources.home_icon
        Me.tst_back.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.tst_back.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tst_back.Name = "tst_back"
        Me.tst_back.Size = New System.Drawing.Size(89, 69)
        Me.tst_back.Text = "กลับสู่หน้าหลัก"
        Me.tst_back.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.txt_sumprice)
        Me.GroupBox1.Controls.Add(Me.DataGridView1)
        Me.GroupBox1.Controls.Add(Me.Label15)
        Me.GroupBox1.Controls.Add(Me.dtp_date1)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Label16)
        Me.GroupBox1.Controls.Add(Me.cbo_type)
        Me.GroupBox1.Controls.Add(Me.Label22)
        Me.GroupBox1.Controls.Add(Me.Label11)
        Me.GroupBox1.Controls.Add(Me.txt_pay)
        Me.GroupBox1.Controls.Add(Me.txt_price)
        Me.GroupBox1.Controls.Add(Me.txt_interest)
        Me.GroupBox1.Controls.Add(Me.Label13)
        Me.GroupBox1.Controls.Add(Me.Label12)
        Me.GroupBox1.Controls.Add(Me.txt_amount)
        Me.GroupBox1.Location = New System.Drawing.Point(30, 88)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(695, 396)
        Me.GroupBox1.TabIndex = 52
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "บันทึกการกู้ปุ๋ย"
        '
        'txt_sumprice
        '
        Me.txt_sumprice.Enabled = False
        Me.txt_sumprice.Location = New System.Drawing.Point(453, 77)
        Me.txt_sumprice.Name = "txt_sumprice"
        Me.txt_sumprice.Size = New System.Drawing.Size(93, 20)
        Me.txt_sumprice.TabIndex = 52
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.delete, Me.contract_oil_no, Me.oil_type, Me.buy_amount, Me.sum_price, Me.sum_interest, Me.sum, Me.pay_date, Me.o_id})
        Me.DataGridView1.Location = New System.Drawing.Point(6, 109)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.DataGridView1.Size = New System.Drawing.Size(683, 190)
        Me.DataGridView1.TabIndex = 49
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(325, 80)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(121, 13)
        Me.Label15.TabIndex = 51
        Me.Label15.Text = "รวมเงินค่าน้ำมัน (บาท) : "
        '
        'dtp_date1
        '
        Me.dtp_date1.Enabled = False
        Me.dtp_date1.Location = New System.Drawing.Point(353, 350)
        Me.dtp_date1.Name = "dtp_date1"
        Me.dtp_date1.Size = New System.Drawing.Size(138, 20)
        Me.dtp_date1.TabIndex = 48
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(128, 27)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(66, 13)
        Me.Label5.TabIndex = 35
        Me.Label5.Text = "ชนิดน้ำมัน : "
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Location = New System.Drawing.Point(204, 327)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(143, 13)
        Me.Label16.TabIndex = 46
        Me.Label16.Text = "จำนวนเงินที่ต้องชำระ (บาท) : "
        '
        'cbo_type
        '
        Me.cbo_type.FormattingEnabled = True
        Me.cbo_type.Location = New System.Drawing.Point(200, 24)
        Me.cbo_type.Name = "cbo_type"
        Me.cbo_type.Size = New System.Drawing.Size(93, 21)
        Me.cbo_type.TabIndex = 36
        '
        'Label22
        '
        Me.Label22.AutoSize = True
        Me.Label22.Location = New System.Drawing.Point(154, 353)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(196, 13)
        Me.Label22.TabIndex = 47
        Me.Label22.Text = "ชำระทั้งเงินต้นและดอกเบี้ยภายในวันที่ : "
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(355, 27)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(92, 13)
        Me.Label11.TabIndex = 37
        Me.Label11.Text = "ราคาต่อถัง (บาท) : "
        '
        'txt_pay
        '
        Me.txt_pay.Enabled = False
        Me.txt_pay.Location = New System.Drawing.Point(353, 324)
        Me.txt_pay.Name = "txt_pay"
        Me.txt_pay.Size = New System.Drawing.Size(93, 20)
        Me.txt_pay.TabIndex = 45
        '
        'txt_price
        '
        Me.txt_price.Enabled = False
        Me.txt_price.Location = New System.Drawing.Point(453, 24)
        Me.txt_price.Name = "txt_price"
        Me.txt_price.Size = New System.Drawing.Size(93, 20)
        Me.txt_price.TabIndex = 38
        '
        'txt_interest
        '
        Me.txt_interest.Enabled = False
        Me.txt_interest.Location = New System.Drawing.Point(453, 51)
        Me.txt_interest.Name = "txt_interest"
        Me.txt_interest.Size = New System.Drawing.Size(93, 20)
        Me.txt_interest.TabIndex = 44
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(111, 54)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(84, 13)
        Me.Label13.TabIndex = 39
        Me.Label13.Text = "จำนวนที่กู้ (ถัง) : "
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(363, 54)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(83, 13)
        Me.Label12.TabIndex = 43
        Me.Label12.Text = "ดอกเบี้ย (บาท) : "
        '
        'txt_amount
        '
        Me.txt_amount.Location = New System.Drawing.Point(200, 51)
        Me.txt_amount.Name = "txt_amount"
        Me.txt_amount.Size = New System.Drawing.Size(93, 20)
        Me.txt_amount.TabIndex = 40
        '
        'lb_cus
        '
        Me.lb_cus.AutoSize = True
        Me.lb_cus.Location = New System.Drawing.Point(628, 72)
        Me.lb_cus.Name = "lb_cus"
        Me.lb_cus.Size = New System.Drawing.Size(10, 13)
        Me.lb_cus.TabIndex = 55
        Me.lb_cus.Text = "-"
        Me.lb_cus.Visible = False
        '
        'lb_id
        '
        Me.lb_id.AutoSize = True
        Me.lb_id.Location = New System.Drawing.Point(540, 72)
        Me.lb_id.Name = "lb_id"
        Me.lb_id.Size = New System.Drawing.Size(10, 13)
        Me.lb_id.TabIndex = 54
        Me.lb_id.Text = "-"
        Me.lb_id.Visible = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(480, 72)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(54, 13)
        Me.Label1.TabIndex = 53
        Me.Label1.Text = "รหัสการกู้:"
        Me.Label1.Visible = False
        '
        'delete
        '
        Me.delete.FillWeight = 50.0!
        Me.delete.HeaderText = "ยกเลิก"
        Me.delete.Name = "delete"
        Me.delete.UseColumnTextForButtonValue = True
        Me.delete.Width = 50
        '
        'contract_oil_no
        '
        Me.contract_oil_no.DataPropertyName = "contract_oil_no"
        Me.contract_oil_no.HeaderText = "เลขที่สัญญา"
        Me.contract_oil_no.Name = "contract_oil_no"
        Me.contract_oil_no.ReadOnly = True
        '
        'oil_type
        '
        Me.oil_type.DataPropertyName = "oil_type"
        Me.oil_type.HeaderText = "ชนิดน้ำมัน"
        Me.oil_type.Name = "oil_type"
        Me.oil_type.ReadOnly = True
        '
        'buy_amount
        '
        Me.buy_amount.DataPropertyName = "buy_amount"
        Me.buy_amount.HeaderText = "จำนวนที่กู้"
        Me.buy_amount.Name = "buy_amount"
        Me.buy_amount.ReadOnly = True
        '
        'sum_price
        '
        Me.sum_price.DataPropertyName = "sum_price"
        Me.sum_price.HeaderText = "ราคา"
        Me.sum_price.Name = "sum_price"
        Me.sum_price.ReadOnly = True
        '
        'sum_interest
        '
        Me.sum_interest.DataPropertyName = "sum_interest"
        Me.sum_interest.HeaderText = "ดอกเบี้ย"
        Me.sum_interest.Name = "sum_interest"
        Me.sum_interest.ReadOnly = True
        '
        'sum
        '
        Me.sum.DataPropertyName = "sum"
        Me.sum.HeaderText = "ราคารวม"
        Me.sum.Name = "sum"
        Me.sum.ReadOnly = True
        '
        'pay_date
        '
        Me.pay_date.DataPropertyName = "pay_date"
        Me.pay_date.HeaderText = "วันที่ต้องชำระ"
        Me.pay_date.Name = "pay_date"
        Me.pay_date.ReadOnly = True
        '
        'o_id
        '
        Me.o_id.DataPropertyName = "o_id"
        Me.o_id.HeaderText = "รหัส"
        Me.o_id.Name = "o_id"
        '
        'oil_buy
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.AliceBlue
        Me.ClientSize = New System.Drawing.Size(762, 514)
        Me.Controls.Add(Me.lb_cus)
        Me.Controls.Add(Me.lb_id)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "oil_buy"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "ระบบบริหารจัดการกลุ่มออมทรัพย์หมู่บ้าน [สัญญากู้น้ำมัน]"
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ToolStrip1 As System.Windows.Forms.ToolStrip
    Friend WithEvents tst_select As System.Windows.Forms.ToolStripSplitButton
    Friend WithEvents tst_confirm As System.Windows.Forms.ToolStripSplitButton
    Friend WithEvents tst_back As System.Windows.Forms.ToolStripSplitButton
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents txt_sumprice As System.Windows.Forms.TextBox
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents dtp_date1 As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents cbo_type As System.Windows.Forms.ComboBox
    Friend WithEvents Label22 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents txt_pay As System.Windows.Forms.TextBox
    Friend WithEvents txt_price As System.Windows.Forms.TextBox
    Friend WithEvents txt_interest As System.Windows.Forms.TextBox
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents txt_amount As System.Windows.Forms.TextBox
    Friend WithEvents lb_cus As System.Windows.Forms.Label
    Friend WithEvents lb_id As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents delete As System.Windows.Forms.DataGridViewButtonColumn
    Friend WithEvents contract_oil_no As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents oil_type As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents buy_amount As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents sum_price As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents sum_interest As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents sum As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents pay_date As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents o_id As System.Windows.Forms.DataGridViewTextBoxColumn
End Class

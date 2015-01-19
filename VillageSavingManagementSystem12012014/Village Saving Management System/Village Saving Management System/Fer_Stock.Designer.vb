<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Fer_Stock
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Fer_Stock))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.tst_save = New System.Windows.Forms.ToolStripSplitButton()
        Me.tst_clear = New System.Windows.Forms.ToolStripSplitButton()
        Me.tst_back = New System.Windows.Forms.ToolStripButton()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txt_balance = New System.Windows.Forms.TextBox()
        Me.txt_create = New System.Windows.Forms.TextBox()
        Me.dtp_time = New System.Windows.Forms.DateTimePicker()
        Me.txt_number = New System.Windows.Forms.TextBox()
        Me.txt_sumprice = New System.Windows.Forms.TextBox()
        Me.txt_price = New System.Windows.Forms.TextBox()
        Me.txt_receive = New System.Windows.Forms.TextBox()
        Me.cbo_type = New System.Windows.Forms.ComboBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.lb_reid = New System.Windows.Forms.Label()
        Me.fer_type = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.receive = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.price = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.sum_price = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.balance = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.number = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.createby = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.receive_date = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ToolStrip1.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Cordia New", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(424, 86)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(167, 33)
        Me.Label1.TabIndex = 6
        Me.Label1.Text = "บันทึกปุ๋ยเข้าสต็อก"
        '
        'ToolStrip1
        '
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tst_save, Me.tst_clear, Me.tst_back})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(934, 72)
        Me.ToolStrip1.TabIndex = 22
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
        Me.tst_clear.BackColor = System.Drawing.Color.AliceBlue
        Me.tst_clear.Image = Global.Village_Saving_Management_System.My.Resources.Resources.clear_icon
        Me.tst_clear.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.tst_clear.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tst_clear.Name = "tst_clear"
        Me.tst_clear.Size = New System.Drawing.Size(66, 69)
        Me.tst_clear.Text = "ล้าง"
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
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.txt_balance)
        Me.GroupBox1.Controls.Add(Me.txt_create)
        Me.GroupBox1.Controls.Add(Me.dtp_time)
        Me.GroupBox1.Controls.Add(Me.txt_number)
        Me.GroupBox1.Controls.Add(Me.txt_sumprice)
        Me.GroupBox1.Controls.Add(Me.txt_price)
        Me.GroupBox1.Controls.Add(Me.txt_receive)
        Me.GroupBox1.Controls.Add(Me.cbo_type)
        Me.GroupBox1.Controls.Add(Me.Label9)
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Location = New System.Drawing.Point(70, 133)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(792, 181)
        Me.GroupBox1.TabIndex = 23
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "บันทึกการรับปุ๋ยเข้าสต๊อค"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(12, 96)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(146, 13)
        Me.Label3.TabIndex = 23
        Me.Label3.Text = "จำนวนคงเหลือในสต็อก (ถัง) : "
        '
        'txt_balance
        '
        Me.txt_balance.Enabled = False
        Me.txt_balance.Location = New System.Drawing.Point(164, 93)
        Me.txt_balance.Name = "txt_balance"
        Me.txt_balance.Size = New System.Drawing.Size(106, 20)
        Me.txt_balance.TabIndex = 22
        '
        'txt_create
        '
        Me.txt_create.Enabled = False
        Me.txt_create.Location = New System.Drawing.Point(489, 118)
        Me.txt_create.Name = "txt_create"
        Me.txt_create.Size = New System.Drawing.Size(142, 20)
        Me.txt_create.TabIndex = 19
        '
        'dtp_time
        '
        Me.dtp_time.Enabled = False
        Me.dtp_time.Location = New System.Drawing.Point(164, 119)
        Me.dtp_time.Name = "dtp_time"
        Me.dtp_time.Size = New System.Drawing.Size(142, 20)
        Me.dtp_time.TabIndex = 18
        '
        'txt_number
        '
        Me.txt_number.Location = New System.Drawing.Point(489, 92)
        Me.txt_number.Name = "txt_number"
        Me.txt_number.Size = New System.Drawing.Size(106, 20)
        Me.txt_number.TabIndex = 15
        '
        'txt_sumprice
        '
        Me.txt_sumprice.Enabled = False
        Me.txt_sumprice.Location = New System.Drawing.Point(489, 42)
        Me.txt_sumprice.Name = "txt_sumprice"
        Me.txt_sumprice.Size = New System.Drawing.Size(106, 20)
        Me.txt_sumprice.TabIndex = 14
        '
        'txt_price
        '
        Me.txt_price.Enabled = False
        Me.txt_price.Location = New System.Drawing.Point(164, 67)
        Me.txt_price.Name = "txt_price"
        Me.txt_price.Size = New System.Drawing.Size(106, 20)
        Me.txt_price.TabIndex = 13
        Me.txt_price.Text = "0"
        '
        'txt_receive
        '
        Me.txt_receive.Location = New System.Drawing.Point(489, 67)
        Me.txt_receive.Name = "txt_receive"
        Me.txt_receive.Size = New System.Drawing.Size(106, 20)
        Me.txt_receive.TabIndex = 12
        '
        'cbo_type
        '
        Me.cbo_type.FormattingEnabled = True
        Me.cbo_type.Location = New System.Drawing.Point(164, 41)
        Me.cbo_type.Name = "cbo_type"
        Me.cbo_type.Size = New System.Drawing.Size(106, 21)
        Me.cbo_type.TabIndex = 8
        Me.cbo_type.Text = "--เลือก--"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(431, 121)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(52, 13)
        Me.Label9.TabIndex = 7
        Me.Label9.Text = "ผู้บันทึก : "
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(108, 125)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(50, 13)
        Me.Label8.TabIndex = 6
        Me.Label8.Text = "วันที่รับ : "
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(340, 95)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(143, 13)
        Me.Label7.TabIndex = 5
        Me.Label7.Text = "หมายเลขเอกสารที่เกี่ยวข้อง : "
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(397, 45)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(86, 13)
        Me.Label6.TabIndex = 4
        Me.Label6.Text = "ราคารวม (บาท) : "
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(66, 70)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(92, 13)
        Me.Label5.TabIndex = 3
        Me.Label5.Text = "ราคาต่อถุง (บาท) : "
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(340, 70)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(143, 13)
        Me.Label4.TabIndex = 2
        Me.Label4.Text = "จำนวนที่รับเข้ามา (กระสอบ) : "
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(85, 44)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(73, 13)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "เลือกสูตรปุ๋ย : "
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.fer_type, Me.receive, Me.price, Me.sum_price, Me.balance, Me.number, Me.createby, Me.receive_date})
        Me.DataGridView1.Location = New System.Drawing.Point(70, 343)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.DataGridView1.Size = New System.Drawing.Size(792, 240)
        Me.DataGridView1.TabIndex = 24
        '
        'lb_reid
        '
        Me.lb_reid.AutoSize = True
        Me.lb_reid.Location = New System.Drawing.Point(897, 72)
        Me.lb_reid.Name = "lb_reid"
        Me.lb_reid.Size = New System.Drawing.Size(10, 13)
        Me.lb_reid.TabIndex = 25
        Me.lb_reid.Text = "-"
        Me.lb_reid.Visible = False
        '
        'fer_type
        '
        Me.fer_type.DataPropertyName = "fer_type"
        Me.fer_type.HeaderText = "สูตรปุ๋ย"
        Me.fer_type.Name = "fer_type"
        Me.fer_type.ReadOnly = True
        '
        'receive
        '
        Me.receive.DataPropertyName = "receive"
        Me.receive.HeaderText = "จำนวนที่รับเข้า"
        Me.receive.Name = "receive"
        Me.receive.ReadOnly = True
        '
        'price
        '
        Me.price.DataPropertyName = "price"
        Me.price.HeaderText = "ราคาต่อกระสอบ (บาท)"
        Me.price.Name = "price"
        Me.price.ReadOnly = True
        '
        'sum_price
        '
        Me.sum_price.DataPropertyName = "sum_price"
        Me.sum_price.HeaderText = "ราคารวม (บาท)"
        Me.sum_price.Name = "sum_price"
        Me.sum_price.ReadOnly = True
        '
        'balance
        '
        Me.balance.DataPropertyName = "balance"
        Me.balance.HeaderText = "จำนวนคงเหลือ (กระสอบ)"
        Me.balance.Name = "balance"
        Me.balance.ReadOnly = True
        '
        'number
        '
        Me.number.DataPropertyName = "number"
        Me.number.HeaderText = "หมายเลขเอกสาร"
        Me.number.Name = "number"
        Me.number.ReadOnly = True
        '
        'createby
        '
        Me.createby.DataPropertyName = "createby"
        Me.createby.FillWeight = 160.0!
        Me.createby.HeaderText = "ผู้บันทึก"
        Me.createby.Name = "createby"
        Me.createby.ReadOnly = True
        Me.createby.Width = 160
        '
        'receive_date
        '
        Me.receive_date.DataPropertyName = "receive_date"
        Me.receive_date.HeaderText = "วันที่รับ"
        Me.receive_date.Name = "receive_date"
        Me.receive_date.ReadOnly = True
        Me.receive_date.Visible = False
        '
        'Fer_Stock
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.AliceBlue
        Me.ClientSize = New System.Drawing.Size(934, 664)
        Me.Controls.Add(Me.lb_reid)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Controls.Add(Me.Label1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Fer_Stock"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "ระบบบริหารจัดการกลุ่มออมทรัพย์หมู่บ้าน [บันทึกปุ๋ยเข้าสต็อก]"
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents ToolStrip1 As System.Windows.Forms.ToolStrip
    Friend WithEvents tst_save As System.Windows.Forms.ToolStripSplitButton
    Friend WithEvents tst_clear As System.Windows.Forms.ToolStripSplitButton
    Friend WithEvents tst_back As System.Windows.Forms.ToolStripButton
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents txt_create As System.Windows.Forms.TextBox
    Friend WithEvents dtp_time As System.Windows.Forms.DateTimePicker
    Friend WithEvents txt_number As System.Windows.Forms.TextBox
    Friend WithEvents txt_sumprice As System.Windows.Forms.TextBox
    Friend WithEvents txt_price As System.Windows.Forms.TextBox
    Friend WithEvents txt_receive As System.Windows.Forms.TextBox
    Friend WithEvents cbo_type As System.Windows.Forms.ComboBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents lb_reid As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txt_balance As System.Windows.Forms.TextBox
    Friend WithEvents fer_type As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents receive As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents price As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents sum_price As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents balance As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents number As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents createby As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents receive_date As System.Windows.Forms.DataGridViewTextBoxColumn
End Class

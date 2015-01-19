<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class NC_ferstock
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(NC_ferstock))
        Me.txt_sumprice = New System.Windows.Forms.TextBox()
        Me.txt_number = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.tst_cancel = New System.Windows.Forms.ToolStripSplitButton()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txt_receive = New System.Windows.Forms.TextBox()
        Me.txt_fertype = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.txt_create = New System.Windows.Forms.TextBox()
        Me.dtp_time = New System.Windows.Forms.DateTimePicker()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.tst_back = New System.Windows.Forms.ToolStripButton()
        Me.lb = New System.Windows.Forms.Label()
        Me.receive_date = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.fer_type = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.receive = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.sum_price = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.number = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.createby = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.re_id = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.GroupBox2.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ToolStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'txt_sumprice
        '
        Me.txt_sumprice.Enabled = False
        Me.txt_sumprice.Location = New System.Drawing.Point(174, 80)
        Me.txt_sumprice.Name = "txt_sumprice"
        Me.txt_sumprice.Size = New System.Drawing.Size(113, 20)
        Me.txt_sumprice.TabIndex = 29
        '
        'txt_number
        '
        Me.txt_number.Enabled = False
        Me.txt_number.Location = New System.Drawing.Point(488, 28)
        Me.txt_number.Name = "txt_number"
        Me.txt_number.Size = New System.Drawing.Size(142, 20)
        Me.txt_number.TabIndex = 27
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(339, 31)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(143, 13)
        Me.Label10.TabIndex = 16
        Me.Label10.Text = "หมายเลขเอกสารที่เกี่ยวข้อง : "
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
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Cordia New", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label1.Location = New System.Drawing.Point(326, 88)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(288, 33)
        Me.Label1.TabIndex = 33
        Me.Label1.Text = "แจ้งยกเลิกรายการรับปุ๋ยเข้าสต็อก"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(110, 83)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(58, 13)
        Me.Label7.TabIndex = 10
        Me.Label7.Text = "ราคารวม : "
        '
        'txt_receive
        '
        Me.txt_receive.Enabled = False
        Me.txt_receive.Location = New System.Drawing.Point(174, 54)
        Me.txt_receive.Name = "txt_receive"
        Me.txt_receive.Size = New System.Drawing.Size(98, 20)
        Me.txt_receive.TabIndex = 6
        '
        'txt_fertype
        '
        Me.txt_fertype.Enabled = False
        Me.txt_fertype.Location = New System.Drawing.Point(174, 28)
        Me.txt_fertype.Name = "txt_fertype"
        Me.txt_fertype.Size = New System.Drawing.Size(98, 20)
        Me.txt_fertype.TabIndex = 4
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(119, 31)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(49, 13)
        Me.Label5.TabIndex = 3
        Me.Label5.Text = "สูตรปุ๋ย : "
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.txt_create)
        Me.GroupBox2.Controls.Add(Me.dtp_time)
        Me.GroupBox2.Controls.Add(Me.Label9)
        Me.GroupBox2.Controls.Add(Me.Label2)
        Me.GroupBox2.Controls.Add(Me.txt_sumprice)
        Me.GroupBox2.Controls.Add(Me.txt_number)
        Me.GroupBox2.Controls.Add(Me.Label10)
        Me.GroupBox2.Controls.Add(Me.Label7)
        Me.GroupBox2.Controls.Add(Me.txt_receive)
        Me.GroupBox2.Controls.Add(Me.txt_fertype)
        Me.GroupBox2.Controls.Add(Me.Label5)
        Me.GroupBox2.Controls.Add(Me.Label11)
        Me.GroupBox2.Location = New System.Drawing.Point(68, 486)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(792, 131)
        Me.GroupBox2.TabIndex = 36
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "ข้อมูลการรับปุ๋ยเข้าสต็อก"
        '
        'txt_create
        '
        Me.txt_create.Enabled = False
        Me.txt_create.Location = New System.Drawing.Point(488, 80)
        Me.txt_create.Name = "txt_create"
        Me.txt_create.Size = New System.Drawing.Size(142, 20)
        Me.txt_create.TabIndex = 46
        '
        'dtp_time
        '
        Me.dtp_time.Enabled = False
        Me.dtp_time.Location = New System.Drawing.Point(488, 54)
        Me.dtp_time.Name = "dtp_time"
        Me.dtp_time.Size = New System.Drawing.Size(142, 20)
        Me.dtp_time.TabIndex = 45
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(430, 83)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(52, 13)
        Me.Label9.TabIndex = 44
        Me.Label9.Text = "ผู้บันทึก : "
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(416, 57)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(66, 13)
        Me.Label2.TabIndex = 43
        Me.Label2.Text = "วันที่รับเข้า : "
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(25, 57)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(143, 13)
        Me.Label11.TabIndex = 1
        Me.Label11.Text = "จำนวนที่รับเข้ามา (กระสอบ) : "
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.receive_date, Me.fer_type, Me.receive, Me.sum_price, Me.number, Me.createby, Me.re_id})
        Me.DataGridView1.Location = New System.Drawing.Point(112, 146)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.DataGridView1.Size = New System.Drawing.Size(711, 324)
        Me.DataGridView1.TabIndex = 35
        '
        'ToolStrip1
        '
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tst_cancel, Me.tst_back})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(934, 72)
        Me.ToolStrip1.TabIndex = 32
        Me.ToolStrip1.Text = "ToolStrip1"
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
        'lb
        '
        Me.lb.AutoSize = True
        Me.lb.Location = New System.Drawing.Point(912, 72)
        Me.lb.Name = "lb"
        Me.lb.Size = New System.Drawing.Size(10, 13)
        Me.lb.TabIndex = 37
        Me.lb.Text = "-"
        Me.lb.Visible = False
        '
        'receive_date
        '
        Me.receive_date.DataPropertyName = "receive_date"
        Me.receive_date.FillWeight = 120.0!
        Me.receive_date.HeaderText = "วันที่รับเข้า"
        Me.receive_date.Name = "receive_date"
        Me.receive_date.ReadOnly = True
        Me.receive_date.Width = 120
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
        Me.receive.HeaderText = "จำนวนที่รับเข้า (กระสอบ)"
        Me.receive.Name = "receive"
        Me.receive.ReadOnly = True
        '
        'sum_price
        '
        Me.sum_price.DataPropertyName = "sum_price"
        Me.sum_price.HeaderText = "ราคารวม"
        Me.sum_price.Name = "sum_price"
        Me.sum_price.ReadOnly = True
        '
        'number
        '
        Me.number.DataPropertyName = "number"
        Me.number.HeaderText = "เลขที่เอกสาร"
        Me.number.Name = "number"
        Me.number.ReadOnly = True
        '
        'createby
        '
        Me.createby.DataPropertyName = "createby"
        Me.createby.FillWeight = 150.0!
        Me.createby.HeaderText = "ผู้บันทึก"
        Me.createby.Name = "createby"
        Me.createby.ReadOnly = True
        Me.createby.Width = 150
        '
        're_id
        '
        Me.re_id.DataPropertyName = "re_id"
        Me.re_id.FillWeight = 150.0!
        Me.re_id.HeaderText = "ลำดับที่ทำรายการ"
        Me.re_id.Name = "re_id"
        Me.re_id.ReadOnly = True
        Me.re_id.Visible = False
        Me.re_id.Width = 150
        '
        'NC_ferstock
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.AliceBlue
        Me.ClientSize = New System.Drawing.Size(934, 664)
        Me.Controls.Add(Me.lb)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "NC_ferstock"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "ระบบบริหารจัดการกลุ่มออมทรัพย์หมู่บ้าน [แจ้งยกเลิกรายการรับปุ๋ยเข้าสต็อก]"
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txt_sumprice As System.Windows.Forms.TextBox
    Friend WithEvents txt_number As System.Windows.Forms.TextBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents tst_cancel As System.Windows.Forms.ToolStripSplitButton
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents txt_receive As System.Windows.Forms.TextBox
    Friend WithEvents txt_fertype As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents ToolStrip1 As System.Windows.Forms.ToolStrip
    Friend WithEvents tst_back As System.Windows.Forms.ToolStripButton
    Friend WithEvents lb As System.Windows.Forms.Label
    Friend WithEvents txt_create As System.Windows.Forms.TextBox
    Friend WithEvents dtp_time As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents receive_date As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents fer_type As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents receive As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents sum_price As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents number As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents createby As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents re_id As System.Windows.Forms.DataGridViewTextBoxColumn
End Class

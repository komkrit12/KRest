<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Fer_Add
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Fer_Add))
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.tst_save = New System.Windows.Forms.ToolStripSplitButton()
        Me.tst_clear = New System.Windows.Forms.ToolStripSplitButton()
        Me.tst_cancel = New System.Windows.Forms.ToolStripSplitButton()
        Me.tst_back = New System.Windows.Forms.ToolStripButton()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.txt_create = New System.Windows.Forms.TextBox()
        Me.dtp_date = New System.Windows.Forms.DateTimePicker()
        Me.txt_point = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txt_price = New System.Windows.Forms.TextBox()
        Me.txt_type = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.fer_type = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.price = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.point = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.lb_ferid = New System.Windows.Forms.Label()
        Me.lb_status = New System.Windows.Forms.Label()
        Me.lb_reid = New System.Windows.Forms.Label()
        Me.ToolStrip1.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ToolStrip1
        '
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tst_save, Me.tst_clear, Me.tst_cancel, Me.tst_back})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(584, 72)
        Me.ToolStrip1.TabIndex = 23
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
        'tst_cancel
        '
        Me.tst_cancel.Image = Global.Village_Saving_Management_System.My.Resources.Resources.Delete_Icon
        Me.tst_cancel.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.tst_cancel.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.tst_cancel.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tst_cancel.Name = "tst_cancel"
        Me.tst_cancel.Size = New System.Drawing.Size(66, 69)
        Me.tst_cancel.Text = "ยกเลิก"
        Me.tst_cancel.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.tst_cancel.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'tst_back
        '
        Me.tst_back.Image = Global.Village_Saving_Management_System.My.Resources.Resources.home_icon
        Me.tst_back.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.tst_back.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tst_back.Name = "tst_back"
        Me.tst_back.Size = New System.Drawing.Size(77, 69)
        Me.tst_back.Text = "กลับสู่หน้าหลัก"
        Me.tst_back.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Cordia New", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label5.Location = New System.Drawing.Point(236, 89)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(95, 30)
        Me.Label5.TabIndex = 33
        Me.Label5.Text = "เพิ่มสูตรปุ๋ย"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.txt_create)
        Me.GroupBox1.Controls.Add(Me.dtp_date)
        Me.GroupBox1.Controls.Add(Me.txt_point)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.txt_price)
        Me.GroupBox1.Controls.Add(Me.txt_type)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Location = New System.Drawing.Point(120, 132)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(344, 161)
        Me.GroupBox1.TabIndex = 34
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "เพิ่มสูตรปุ๋ย"
        '
        'txt_create
        '
        Me.txt_create.Enabled = False
        Me.txt_create.Location = New System.Drawing.Point(121, 123)
        Me.txt_create.Name = "txt_create"
        Me.txt_create.Size = New System.Drawing.Size(146, 20)
        Me.txt_create.TabIndex = 41
        '
        'dtp_date
        '
        Me.dtp_date.Enabled = False
        Me.dtp_date.Location = New System.Drawing.Point(121, 97)
        Me.dtp_date.Name = "dtp_date"
        Me.dtp_date.Size = New System.Drawing.Size(146, 20)
        Me.dtp_date.TabIndex = 40
        '
        'txt_point
        '
        Me.txt_point.Location = New System.Drawing.Point(121, 71)
        Me.txt_point.Name = "txt_point"
        Me.txt_point.Size = New System.Drawing.Size(88, 20)
        Me.txt_point.TabIndex = 39
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(39, 74)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(69, 13)
        Me.Label6.TabIndex = 38
        Me.Label6.Text = "จุดตัดสต็อก : "
        '
        'txt_price
        '
        Me.txt_price.Location = New System.Drawing.Point(121, 45)
        Me.txt_price.Name = "txt_price"
        Me.txt_price.Size = New System.Drawing.Size(88, 20)
        Me.txt_price.TabIndex = 37
        '
        'txt_type
        '
        Me.txt_type.Location = New System.Drawing.Point(121, 19)
        Me.txt_type.Name = "txt_type"
        Me.txt_type.Size = New System.Drawing.Size(88, 20)
        Me.txt_type.TabIndex = 36
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(56, 126)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(52, 13)
        Me.Label4.TabIndex = 35
        Me.Label4.Text = "ผู้บันทึก : "
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(42, 103)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(66, 13)
        Me.Label3.TabIndex = 34
        Me.Label3.Text = "วันที่บันทึก : "
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(41, 48)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(67, 13)
        Me.Label2.TabIndex = 33
        Me.Label2.Text = "ราคา (บาท) : "
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(59, 22)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(49, 13)
        Me.Label1.TabIndex = 32
        Me.Label1.Text = "สูตรปุ๋ย : "
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.fer_type, Me.price, Me.point})
        Me.DataGridView1.Location = New System.Drawing.Point(120, 314)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(344, 138)
        Me.DataGridView1.TabIndex = 35
        '
        'fer_type
        '
        Me.fer_type.DataPropertyName = "fer_type"
        Me.fer_type.HeaderText = "สูตรปุ๋ย"
        Me.fer_type.Name = "fer_type"
        '
        'price
        '
        Me.price.DataPropertyName = "price"
        Me.price.HeaderText = "ราคาปุ๋ยต่อกระสอบ (บาท)"
        Me.price.Name = "price"
        '
        'point
        '
        Me.point.DataPropertyName = "point"
        Me.point.HeaderText = "จุดตัดสต็อก"
        Me.point.Name = "point"
        '
        'lb_ferid
        '
        Me.lb_ferid.AutoSize = True
        Me.lb_ferid.Location = New System.Drawing.Point(562, 72)
        Me.lb_ferid.Name = "lb_ferid"
        Me.lb_ferid.Size = New System.Drawing.Size(10, 13)
        Me.lb_ferid.TabIndex = 36
        Me.lb_ferid.Text = "-"
        Me.lb_ferid.Visible = False
        '
        'lb_status
        '
        Me.lb_status.AutoSize = True
        Me.lb_status.Location = New System.Drawing.Point(562, 98)
        Me.lb_status.Name = "lb_status"
        Me.lb_status.Size = New System.Drawing.Size(10, 13)
        Me.lb_status.TabIndex = 37
        Me.lb_status.Text = "-"
        Me.lb_status.Visible = False
        '
        'lb_reid
        '
        Me.lb_reid.AutoSize = True
        Me.lb_reid.Location = New System.Drawing.Point(562, 122)
        Me.lb_reid.Name = "lb_reid"
        Me.lb_reid.Size = New System.Drawing.Size(10, 13)
        Me.lb_reid.TabIndex = 38
        Me.lb_reid.Text = "-"
        Me.lb_reid.Visible = False
        '
        'Fer_Add
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.AliceBlue
        Me.ClientSize = New System.Drawing.Size(584, 464)
        Me.Controls.Add(Me.lb_reid)
        Me.Controls.Add(Me.lb_status)
        Me.Controls.Add(Me.lb_ferid)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Fer_Add"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "กลุ่มออมทรัพย์หมู่บ้าน [เพิ่มสูตรปุ๋ย]"
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ToolStrip1 As System.Windows.Forms.ToolStrip
    Friend WithEvents tst_save As System.Windows.Forms.ToolStripSplitButton
    Friend WithEvents tst_clear As System.Windows.Forms.ToolStripSplitButton
    Friend WithEvents tst_back As System.Windows.Forms.ToolStripButton
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents txt_price As System.Windows.Forms.TextBox
    Friend WithEvents txt_type As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txt_create As System.Windows.Forms.TextBox
    Friend WithEvents dtp_date As System.Windows.Forms.DateTimePicker
    Friend WithEvents txt_point As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents tst_cancel As System.Windows.Forms.ToolStripSplitButton
    Friend WithEvents fer_type As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents price As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents point As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents lb_ferid As System.Windows.Forms.Label
    Friend WithEvents lb_status As System.Windows.Forms.Label
    Friend WithEvents lb_reid As System.Windows.Forms.Label
End Class

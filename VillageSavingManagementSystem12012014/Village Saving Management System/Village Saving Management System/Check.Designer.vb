<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Check
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Check))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.tst_print = New System.Windows.Forms.ToolStripSplitButton()
        Me.tst_back = New System.Windows.Forms.ToolStripButton()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.btn_search = New System.Windows.Forms.Button()
        Me.dtp_time2 = New System.Windows.Forms.DateTimePicker()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.dtp_time1 = New System.Windows.Forms.DateTimePicker()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.username = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.position = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.use_date = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.out_date = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ToolStrip1.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Cordia New", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label1.Location = New System.Drawing.Point(99, 85)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(206, 33)
        Me.Label1.TabIndex = 9
        Me.Label1.Text = "ตรวจสอบการเข้าใช้งาน"
        '
        'ToolStrip1
        '
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tst_print, Me.tst_back})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(829, 72)
        Me.ToolStrip1.TabIndex = 18
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'tst_print
        '
        Me.tst_print.Image = Global.Village_Saving_Management_System.My.Resources.Resources.printer_blue
        Me.tst_print.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.tst_print.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tst_print.Name = "tst_print"
        Me.tst_print.Size = New System.Drawing.Size(66, 69)
        Me.tst_print.Text = "พิมพ์"
        Me.tst_print.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
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
        Me.GroupBox1.Controls.Add(Me.btn_search)
        Me.GroupBox1.Controls.Add(Me.dtp_time2)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.dtp_time1)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Location = New System.Drawing.Point(424, 85)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(360, 110)
        Me.GroupBox1.TabIndex = 19
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "ช่วงเวลาที่ต้องการตรวจสอบ"
        '
        'btn_search
        '
        Me.btn_search.Location = New System.Drawing.Point(267, 38)
        Me.btn_search.Name = "btn_search"
        Me.btn_search.Size = New System.Drawing.Size(77, 36)
        Me.btn_search.TabIndex = 4
        Me.btn_search.Text = "แสดงข้อมูล"
        Me.btn_search.UseVisualStyleBackColor = True
        '
        'dtp_time2
        '
        Me.dtp_time2.Location = New System.Drawing.Point(108, 58)
        Me.dtp_time2.Name = "dtp_time2"
        Me.dtp_time2.Size = New System.Drawing.Size(142, 20)
        Me.dtp_time2.TabIndex = 3
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(53, 64)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(49, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "ถึงวันที่ : "
        '
        'dtp_time1
        '
        Me.dtp_time1.Location = New System.Drawing.Point(108, 32)
        Me.dtp_time1.Name = "dtp_time1"
        Me.dtp_time1.Size = New System.Drawing.Size(142, 20)
        Me.dtp_time1.TabIndex = 1
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(38, 38)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(64, 13)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "ตั้งแต่วันที่ : "
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.username, Me.position, Me.use_date, Me.out_date})
        Me.DataGridView1.Location = New System.Drawing.Point(44, 27)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.DataGridView1.Size = New System.Drawing.Size(572, 405)
        Me.DataGridView1.TabIndex = 20
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.DataGridView1)
        Me.GroupBox2.Location = New System.Drawing.Point(90, 201)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(647, 448)
        Me.GroupBox2.TabIndex = 21
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "ตรวจสอบการใช้งาน"
        '
        'username
        '
        Me.username.DataPropertyName = "username"
        Me.username.FillWeight = 160.0!
        Me.username.HeaderText = "ชื่อผู้เข้าใช้งาน"
        Me.username.MinimumWidth = 10
        Me.username.Name = "username"
        Me.username.ReadOnly = True
        Me.username.Width = 160
        '
        'position
        '
        Me.position.DataPropertyName = "position"
        Me.position.FillWeight = 120.0!
        Me.position.HeaderText = "ตำแหน่ง"
        Me.position.Name = "position"
        Me.position.ReadOnly = True
        Me.position.Width = 120
        '
        'use_date
        '
        Me.use_date.DataPropertyName = "use_date"
        Me.use_date.FillWeight = 120.0!
        Me.use_date.HeaderText = "เข้าใช้งาน"
        Me.use_date.Name = "use_date"
        Me.use_date.ReadOnly = True
        Me.use_date.Width = 120
        '
        'out_date
        '
        Me.out_date.DataPropertyName = "out_date"
        Me.out_date.HeaderText = "ออกจากระบบ"
        Me.out_date.Name = "out_date"
        Me.out_date.ReadOnly = True
        '
        'Check
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.AliceBlue
        Me.ClientSize = New System.Drawing.Size(829, 661)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Controls.Add(Me.Label1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Check"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "ระบบบริหารจัดการกลุ่มออมทรัพย์หมู่บ้าน [ตรวจสอบการใช้งาน]"
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents ToolStrip1 As System.Windows.Forms.ToolStrip
    Friend WithEvents tst_print As System.Windows.Forms.ToolStripSplitButton
    Friend WithEvents tst_back As System.Windows.Forms.ToolStripButton
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents btn_search As System.Windows.Forms.Button
    Friend WithEvents dtp_time2 As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents dtp_time1 As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents username As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents position As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents use_date As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents out_date As System.Windows.Forms.DataGridViewTextBoxColumn
End Class

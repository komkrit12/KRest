<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Register
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Register))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.tst_add = New System.Windows.Forms.ToolStripSplitButton()
        Me.tst_cancel = New System.Windows.Forms.ToolStripSplitButton()
        Me.tst_edit = New System.Windows.Forms.ToolStripSplitButton()
        Me.tst_clear = New System.Windows.Forms.ToolStripSplitButton()
        Me.tst_back = New System.Windows.Forms.ToolStripButton()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.lb_Search = New System.Windows.Forms.Label()
        Me.btn_Search = New System.Windows.Forms.Button()
        Me.txt_username = New System.Windows.Forms.TextBox()
        Me.txt_password = New System.Windows.Forms.TextBox()
        Me.cbo_position = New System.Windows.Forms.ComboBox()
        Me.txt_personalid = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txt_address = New System.Windows.Forms.TextBox()
        Me.txt_name = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txt_create = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.lb_id = New System.Windows.Forms.Label()
        Me.lb_status = New System.Windows.Forms.Label()
        Me.lb_reid = New System.Windows.Forms.Label()
        Me.lb_type = New System.Windows.Forms.Label()
        Me.ToolStrip1.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Cordia New", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(234, 99)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(136, 30)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "ผู้ใช้และรหัสผ่าน"
        '
        'ToolStrip1
        '
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tst_add, Me.tst_cancel, Me.tst_edit, Me.tst_clear, Me.tst_back})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(580, 72)
        Me.ToolStrip1.TabIndex = 20
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'tst_add
        '
        Me.tst_add.Image = Global.Village_Saving_Management_System.My.Resources.Resources.adduser_icon
        Me.tst_add.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.tst_add.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.tst_add.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tst_add.Name = "tst_add"
        Me.tst_add.Size = New System.Drawing.Size(92, 69)
        Me.tst_add.Text = "เพิ่มผู้เข้าใช้งาน"
        Me.tst_add.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.tst_add.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'tst_cancel
        '
        Me.tst_cancel.Image = Global.Village_Saving_Management_System.My.Resources.Resources.delete_user_icon
        Me.tst_cancel.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.tst_cancel.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.tst_cancel.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tst_cancel.Name = "tst_cancel"
        Me.tst_cancel.Size = New System.Drawing.Size(103, 69)
        Me.tst_cancel.Text = "ยกเลิกผู้เข้าใช้งาน"
        Me.tst_cancel.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.tst_cancel.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'tst_edit
        '
        Me.tst_edit.Image = Global.Village_Saving_Management_System.My.Resources.Resources.edit_icon
        Me.tst_edit.ImageAlign = System.Drawing.ContentAlignment.TopCenter
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
        Me.tst_clear.ImageAlign = System.Drawing.ContentAlignment.TopCenter
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
        Me.tst_back.Size = New System.Drawing.Size(76, 69)
        Me.tst_back.Text = "กลับสู่หน้าหลัก"
        Me.tst_back.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.lb_Search)
        Me.GroupBox1.Controls.Add(Me.btn_Search)
        Me.GroupBox1.Controls.Add(Me.txt_username)
        Me.GroupBox1.Controls.Add(Me.txt_password)
        Me.GroupBox1.Controls.Add(Me.cbo_position)
        Me.GroupBox1.Controls.Add(Me.txt_personalid)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.txt_address)
        Me.GroupBox1.Controls.Add(Me.txt_name)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Location = New System.Drawing.Point(71, 145)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(497, 281)
        Me.GroupBox1.TabIndex = 21
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "ลงทะเบียนเข้าใช้ระบบ"
        '
        'lb_Search
        '
        Me.lb_Search.AutoSize = True
        Me.lb_Search.Location = New System.Drawing.Point(85, 28)
        Me.lb_Search.Name = "lb_Search"
        Me.lb_Search.Size = New System.Drawing.Size(43, 13)
        Me.lb_Search.TabIndex = 21
        Me.lb_Search.Text = "ค้นหา : "
        '
        'btn_Search
        '
        Me.btn_Search.Image = Global.Village_Saving_Management_System.My.Resources.Resources.search_mini
        Me.btn_Search.Location = New System.Drawing.Point(135, 19)
        Me.btn_Search.Name = "btn_Search"
        Me.btn_Search.Size = New System.Drawing.Size(33, 31)
        Me.btn_Search.TabIndex = 20
        Me.btn_Search.UseVisualStyleBackColor = True
        '
        'txt_username
        '
        Me.txt_username.Location = New System.Drawing.Point(135, 217)
        Me.txt_username.Name = "txt_username"
        Me.txt_username.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txt_username.Size = New System.Drawing.Size(105, 20)
        Me.txt_username.TabIndex = 18
        '
        'txt_password
        '
        Me.txt_password.Location = New System.Drawing.Point(135, 247)
        Me.txt_password.Name = "txt_password"
        Me.txt_password.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txt_password.Size = New System.Drawing.Size(105, 20)
        Me.txt_password.TabIndex = 18
        '
        'cbo_position
        '
        Me.cbo_position.FormattingEnabled = True
        Me.cbo_position.Items.AddRange(New Object() {"ประธาน", "เจ้าหน้าที่"})
        Me.cbo_position.Location = New System.Drawing.Point(135, 182)
        Me.cbo_position.Name = "cbo_position"
        Me.cbo_position.Size = New System.Drawing.Size(93, 21)
        Me.cbo_position.TabIndex = 17
        Me.cbo_position.Text = "--เลือก--"
        '
        'txt_personalid
        '
        Me.txt_personalid.Location = New System.Drawing.Point(144, 156)
        Me.txt_personalid.MaxLength = 13
        Me.txt_personalid.Name = "txt_personalid"
        Me.txt_personalid.Size = New System.Drawing.Size(155, 20)
        Me.txt_personalid.TabIndex = 16
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(9, 159)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(120, 13)
        Me.Label7.TabIndex = 15
        Me.Label7.Text = "เลขประจำตัวประชาชน : "
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(52, 220)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(76, 13)
        Me.Label8.TabIndex = 12
        Me.Label8.Text = "ชื่อเข้าใช้งาน : "
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(73, 250)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(55, 13)
        Me.Label6.TabIndex = 12
        Me.Label6.Text = "รหัสผ่าน : "
        '
        'txt_address
        '
        Me.txt_address.Location = New System.Drawing.Point(135, 82)
        Me.txt_address.Multiline = True
        Me.txt_address.Name = "txt_address"
        Me.txt_address.Size = New System.Drawing.Size(210, 68)
        Me.txt_address.TabIndex = 5
        '
        'txt_name
        '
        Me.txt_name.Location = New System.Drawing.Point(135, 56)
        Me.txt_name.Name = "txt_name"
        Me.txt_name.Size = New System.Drawing.Size(210, 20)
        Me.txt_name.TabIndex = 4
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(93, 99)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(36, 13)
        Me.Label4.TabIndex = 2
        Me.Label4.Text = "ที่อยู่ : "
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(73, 185)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(56, 13)
        Me.Label3.TabIndex = 1
        Me.Label3.Text = "ตำแหน่ง : "
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(52, 59)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(77, 13)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "ชื่อ - นามสกุล : "
        '
        'txt_create
        '
        Me.txt_create.Enabled = False
        Me.txt_create.Location = New System.Drawing.Point(822, 281)
        Me.txt_create.Name = "txt_create"
        Me.txt_create.Size = New System.Drawing.Size(155, 20)
        Me.txt_create.TabIndex = 19
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(827, 244)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(52, 13)
        Me.Label5.TabIndex = 13
        Me.Label5.Text = "ผู้บันทึก : "
        '
        'lb_id
        '
        Me.lb_id.AutoSize = True
        Me.lb_id.Location = New System.Drawing.Point(558, 108)
        Me.lb_id.Name = "lb_id"
        Me.lb_id.Size = New System.Drawing.Size(10, 13)
        Me.lb_id.TabIndex = 22
        Me.lb_id.Text = "-"
        Me.lb_id.Visible = False
        '
        'lb_status
        '
        Me.lb_status.AutoSize = True
        Me.lb_status.Location = New System.Drawing.Point(602, 85)
        Me.lb_status.Name = "lb_status"
        Me.lb_status.Size = New System.Drawing.Size(10, 13)
        Me.lb_status.TabIndex = 23
        Me.lb_status.Text = "-"
        Me.lb_status.Visible = False
        '
        'lb_reid
        '
        Me.lb_reid.AutoSize = True
        Me.lb_reid.Location = New System.Drawing.Point(602, 98)
        Me.lb_reid.Name = "lb_reid"
        Me.lb_reid.Size = New System.Drawing.Size(10, 13)
        Me.lb_reid.TabIndex = 24
        Me.lb_reid.Text = "-"
        Me.lb_reid.Visible = False
        '
        'lb_type
        '
        Me.lb_type.AutoSize = True
        Me.lb_type.Location = New System.Drawing.Point(602, 111)
        Me.lb_type.Name = "lb_type"
        Me.lb_type.Size = New System.Drawing.Size(10, 13)
        Me.lb_type.TabIndex = 25
        Me.lb_type.Text = "-"
        Me.lb_type.Visible = False
        '
        'Register
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.AliceBlue
        Me.ClientSize = New System.Drawing.Size(580, 464)
        Me.Controls.Add(Me.lb_type)
        Me.Controls.Add(Me.lb_reid)
        Me.Controls.Add(Me.txt_create)
        Me.Controls.Add(Me.lb_status)
        Me.Controls.Add(Me.lb_id)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label5)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Register"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "ระบบบริหารจัดการกลุ่มออมทรัพย์หมู่บ้าน [การใช้งานและรหัสผ่าน]"
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents ToolStrip1 As System.Windows.Forms.ToolStrip
    Friend WithEvents tst_edit As System.Windows.Forms.ToolStripSplitButton
    Friend WithEvents tst_back As System.Windows.Forms.ToolStripButton
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents txt_address As System.Windows.Forms.TextBox
    Friend WithEvents txt_name As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents tst_add As System.Windows.Forms.ToolStripSplitButton
    Friend WithEvents tst_clear As System.Windows.Forms.ToolStripSplitButton
    Friend WithEvents tst_cancel As System.Windows.Forms.ToolStripSplitButton
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents txt_personalid As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents txt_create As System.Windows.Forms.TextBox
    Friend WithEvents txt_password As System.Windows.Forms.TextBox
    Friend WithEvents cbo_position As System.Windows.Forms.ComboBox
    Friend WithEvents lb_id As System.Windows.Forms.Label
    Friend WithEvents lb_status As System.Windows.Forms.Label
    Friend WithEvents btn_Search As System.Windows.Forms.Button
    Friend WithEvents lb_reid As System.Windows.Forms.Label
    Friend WithEvents lb_type As System.Windows.Forms.Label
    Friend WithEvents lb_Search As System.Windows.Forms.Label
    Friend WithEvents txt_username As System.Windows.Forms.TextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
End Class

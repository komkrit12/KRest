<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Fer_Con
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Fer_Con))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.tst_save = New System.Windows.Forms.ToolStripSplitButton()
        Me.tst_clear = New System.Windows.Forms.ToolStripSplitButton()
        Me.tst_back = New System.Windows.Forms.ToolStripButton()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.Label2 = New System.Windows.Forms.Label()
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
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.btn_Search2 = New System.Windows.Forms.Button()
        Me.txt_create = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txt_gmonth1 = New System.Windows.Forms.TextBox()
        Me.txt_gvocation1 = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.txt_gaddess1 = New System.Windows.Forms.TextBox()
        Me.Label34 = New System.Windows.Forms.Label()
        Me.txt_gfullname1 = New System.Windows.Forms.TextBox()
        Me.Label35 = New System.Windows.Forms.Label()
        Me.txt_gid1 = New System.Windows.Forms.TextBox()
        Me.Label36 = New System.Windows.Forms.Label()
        Me.lb_reid = New System.Windows.Forms.Label()
        Me.ToolStrip1.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Cordia New", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(423, 89)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(158, 33)
        Me.Label1.TabIndex = 7
        Me.Label1.Text = "บันทึกสัญญากู้ปุ๋ย"
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Location = New System.Drawing.Point(100, 139)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(52, 13)
        Me.Label19.TabIndex = 21
        Me.Label19.Text = "ผู้บันทึก : "
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
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.Label2)
        Me.GroupBox3.Controls.Add(Me.btn_Search1)
        Me.GroupBox3.Controls.Add(Me.txt_age)
        Me.GroupBox3.Controls.Add(Me.txt_month)
        Me.GroupBox3.Controls.Add(Me.txt_vocation)
        Me.GroupBox3.Controls.Add(Me.txt_personalid)
        Me.GroupBox3.Controls.Add(Me.Label26)
        Me.GroupBox3.Controls.Add(Me.Label25)
        Me.GroupBox3.Controls.Add(Me.Label27)
        Me.GroupBox3.Controls.Add(Me.txt_tel)
        Me.GroupBox3.Controls.Add(Me.Label28)
        Me.GroupBox3.Controls.Add(Me.txt_address)
        Me.GroupBox3.Controls.Add(Me.Label29)
        Me.GroupBox3.Controls.Add(Me.Label30)
        Me.GroupBox3.Controls.Add(Me.txt_fullname)
        Me.GroupBox3.Controls.Add(Me.Label31)
        Me.GroupBox3.Controls.Add(Me.txt_id)
        Me.GroupBox3.Controls.Add(Me.Label32)
        Me.GroupBox3.Controls.Add(Me.txt_conid)
        Me.GroupBox3.Controls.Add(Me.Label33)
        Me.GroupBox3.Location = New System.Drawing.Point(41, 142)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(867, 274)
        Me.GroupBox3.TabIndex = 23
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "ข้อมูลผู้ทำสัญญาซื้อปุ๋ย"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(111, 30)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(43, 13)
        Me.Label2.TabIndex = 43
        Me.Label2.Text = "ค้นหา : "
        '
        'btn_Search1
        '
        Me.btn_Search1.Image = Global.Village_Saving_Management_System.My.Resources.Resources.search_mini
        Me.btn_Search1.Location = New System.Drawing.Point(166, 21)
        Me.btn_Search1.Name = "btn_Search1"
        Me.btn_Search1.Size = New System.Drawing.Size(33, 31)
        Me.btn_Search1.TabIndex = 42
        Me.btn_Search1.UseVisualStyleBackColor = True
        '
        'txt_age
        '
        Me.txt_age.Enabled = False
        Me.txt_age.Location = New System.Drawing.Point(166, 197)
        Me.txt_age.Name = "txt_age"
        Me.txt_age.Size = New System.Drawing.Size(86, 20)
        Me.txt_age.TabIndex = 41
        '
        'txt_month
        '
        Me.txt_month.Enabled = False
        Me.txt_month.Location = New System.Drawing.Point(166, 223)
        Me.txt_month.Name = "txt_month"
        Me.txt_month.Size = New System.Drawing.Size(86, 20)
        Me.txt_month.TabIndex = 30
        '
        'txt_vocation
        '
        Me.txt_vocation.Enabled = False
        Me.txt_vocation.Location = New System.Drawing.Point(479, 200)
        Me.txt_vocation.Name = "txt_vocation"
        Me.txt_vocation.Size = New System.Drawing.Size(113, 20)
        Me.txt_vocation.TabIndex = 29
        '
        'txt_personalid
        '
        Me.txt_personalid.Enabled = False
        Me.txt_personalid.Location = New System.Drawing.Point(479, 175)
        Me.txt_personalid.Name = "txt_personalid"
        Me.txt_personalid.Size = New System.Drawing.Size(158, 20)
        Me.txt_personalid.TabIndex = 27
        '
        'Label26
        '
        Me.Label26.AutoSize = True
        Me.Label26.Location = New System.Drawing.Point(85, 61)
        Me.Label26.Name = "Label26"
        Me.Label26.Size = New System.Drawing.Size(69, 13)
        Me.Label26.TabIndex = 25
        Me.Label26.Text = "เลขที่สัญญา : "
        '
        'Label25
        '
        Me.Label25.AutoSize = True
        Me.Label25.Location = New System.Drawing.Point(14, 226)
        Me.Label25.Name = "Label25"
        Me.Label25.Size = New System.Drawing.Size(140, 13)
        Me.Label25.TabIndex = 16
        Me.Label25.Text = "รายได้เฉลี่ยต่อเดือน (บาท) : "
        '
        'Label27
        '
        Me.Label27.AutoSize = True
        Me.Label27.Location = New System.Drawing.Point(431, 203)
        Me.Label27.Name = "Label27"
        Me.Label27.Size = New System.Drawing.Size(42, 13)
        Me.Label27.TabIndex = 14
        Me.Label27.Text = "อาชีพ : "
        '
        'txt_tel
        '
        Me.txt_tel.Enabled = False
        Me.txt_tel.Location = New System.Drawing.Point(166, 172)
        Me.txt_tel.Name = "txt_tel"
        Me.txt_tel.Size = New System.Drawing.Size(136, 20)
        Me.txt_tel.TabIndex = 13
        '
        'Label28
        '
        Me.Label28.AutoSize = True
        Me.Label28.Location = New System.Drawing.Point(326, 178)
        Me.Label28.Name = "Label28"
        Me.Label28.Size = New System.Drawing.Size(147, 13)
        Me.Label28.TabIndex = 12
        Me.Label28.Text = "เลขที่บัตรประจำตัวประชาชน : "
        '
        'txt_address
        '
        Me.txt_address.Enabled = False
        Me.txt_address.Location = New System.Drawing.Point(166, 110)
        Me.txt_address.Multiline = True
        Me.txt_address.Name = "txt_address"
        Me.txt_address.Size = New System.Drawing.Size(215, 56)
        Me.txt_address.TabIndex = 11
        '
        'Label29
        '
        Me.Label29.AutoSize = True
        Me.Label29.Location = New System.Drawing.Point(73, 175)
        Me.Label29.Name = "Label29"
        Me.Label29.Size = New System.Drawing.Size(81, 13)
        Me.Label29.TabIndex = 10
        Me.Label29.Text = "เบอร์โทรศัพท์ : "
        '
        'Label30
        '
        Me.Label30.AutoSize = True
        Me.Label30.Location = New System.Drawing.Point(118, 113)
        Me.Label30.Name = "Label30"
        Me.Label30.Size = New System.Drawing.Size(36, 13)
        Me.Label30.TabIndex = 8
        Me.Label30.Text = "ที่อยู่ : "
        '
        'txt_fullname
        '
        Me.txt_fullname.Enabled = False
        Me.txt_fullname.Location = New System.Drawing.Point(479, 87)
        Me.txt_fullname.Name = "txt_fullname"
        Me.txt_fullname.Size = New System.Drawing.Size(226, 20)
        Me.txt_fullname.TabIndex = 6
        '
        'Label31
        '
        Me.Label31.AutoSize = True
        Me.Label31.Location = New System.Drawing.Point(104, 200)
        Me.Label31.Name = "Label31"
        Me.Label31.Size = New System.Drawing.Size(50, 13)
        Me.Label31.TabIndex = 5
        Me.Label31.Text = "อายุ (ปี) : "
        '
        'txt_id
        '
        Me.txt_id.Enabled = False
        Me.txt_id.Location = New System.Drawing.Point(166, 84)
        Me.txt_id.Name = "txt_id"
        Me.txt_id.Size = New System.Drawing.Size(113, 20)
        Me.txt_id.TabIndex = 4
        '
        'Label32
        '
        Me.Label32.AutoSize = True
        Me.Label32.Location = New System.Drawing.Point(82, 87)
        Me.Label32.Name = "Label32"
        Me.Label32.Size = New System.Drawing.Size(72, 13)
        Me.Label32.TabIndex = 3
        Me.Label32.Text = "เลขที่สมาชิก : "
        '
        'txt_conid
        '
        Me.txt_conid.Enabled = False
        Me.txt_conid.Location = New System.Drawing.Point(166, 58)
        Me.txt_conid.Name = "txt_conid"
        Me.txt_conid.Size = New System.Drawing.Size(113, 20)
        Me.txt_conid.TabIndex = 2
        '
        'Label33
        '
        Me.Label33.AutoSize = True
        Me.Label33.Location = New System.Drawing.Point(396, 90)
        Me.Label33.Name = "Label33"
        Me.Label33.Size = New System.Drawing.Size(77, 13)
        Me.Label33.TabIndex = 1
        Me.Label33.Text = "ชื่อ - นามสกุล : "
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.btn_Search2)
        Me.GroupBox1.Controls.Add(Me.txt_create)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.txt_gmonth1)
        Me.GroupBox1.Controls.Add(Me.Label19)
        Me.GroupBox1.Controls.Add(Me.txt_gvocation1)
        Me.GroupBox1.Controls.Add(Me.Label9)
        Me.GroupBox1.Controls.Add(Me.Label10)
        Me.GroupBox1.Controls.Add(Me.txt_gaddess1)
        Me.GroupBox1.Controls.Add(Me.Label34)
        Me.GroupBox1.Controls.Add(Me.txt_gfullname1)
        Me.GroupBox1.Controls.Add(Me.Label35)
        Me.GroupBox1.Controls.Add(Me.txt_gid1)
        Me.GroupBox1.Controls.Add(Me.Label36)
        Me.GroupBox1.Location = New System.Drawing.Point(41, 438)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(867, 184)
        Me.GroupBox1.TabIndex = 42
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "ข้อมูลผู้ค้ำประกัน"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(109, 20)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(43, 13)
        Me.Label4.TabIndex = 49
        Me.Label4.Text = "ค้นหา : "
        '
        'btn_Search2
        '
        Me.btn_Search2.Image = Global.Village_Saving_Management_System.My.Resources.Resources.search_mini
        Me.btn_Search2.Location = New System.Drawing.Point(166, 11)
        Me.btn_Search2.Name = "btn_Search2"
        Me.btn_Search2.Size = New System.Drawing.Size(33, 31)
        Me.btn_Search2.TabIndex = 47
        Me.btn_Search2.UseVisualStyleBackColor = True
        '
        'txt_create
        '
        Me.txt_create.Enabled = False
        Me.txt_create.Location = New System.Drawing.Point(166, 136)
        Me.txt_create.Name = "txt_create"
        Me.txt_create.Size = New System.Drawing.Size(215, 20)
        Me.txt_create.TabIndex = 46
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(620, 58)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(0, 13)
        Me.Label3.TabIndex = 45
        '
        'txt_gmonth1
        '
        Me.txt_gmonth1.Enabled = False
        Me.txt_gmonth1.Location = New System.Drawing.Point(734, 103)
        Me.txt_gmonth1.Name = "txt_gmonth1"
        Me.txt_gmonth1.Size = New System.Drawing.Size(60, 20)
        Me.txt_gmonth1.TabIndex = 44
        '
        'txt_gvocation1
        '
        Me.txt_gvocation1.Enabled = False
        Me.txt_gvocation1.Location = New System.Drawing.Point(479, 103)
        Me.txt_gvocation1.Name = "txt_gvocation1"
        Me.txt_gvocation1.Size = New System.Drawing.Size(106, 20)
        Me.txt_gvocation1.TabIndex = 9
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(591, 106)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(137, 13)
        Me.Label9.TabIndex = 8
        Me.Label9.Text = "รายได้เฉลี่ยต่อเดือน (บาท) :"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(434, 106)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(42, 13)
        Me.Label10.TabIndex = 6
        Me.Label10.Text = "อาชีพ : "
        '
        'txt_gaddess1
        '
        Me.txt_gaddess1.Enabled = False
        Me.txt_gaddess1.Location = New System.Drawing.Point(166, 74)
        Me.txt_gaddess1.Multiline = True
        Me.txt_gaddess1.Name = "txt_gaddess1"
        Me.txt_gaddess1.Size = New System.Drawing.Size(215, 56)
        Me.txt_gaddess1.TabIndex = 5
        '
        'Label34
        '
        Me.Label34.AutoSize = True
        Me.Label34.Location = New System.Drawing.Point(82, 51)
        Me.Label34.Name = "Label34"
        Me.Label34.Size = New System.Drawing.Size(72, 13)
        Me.Label34.TabIndex = 4
        Me.Label34.Text = "เลขที่สมาชิก : "
        '
        'txt_gfullname1
        '
        Me.txt_gfullname1.Enabled = False
        Me.txt_gfullname1.Location = New System.Drawing.Point(479, 74)
        Me.txt_gfullname1.Name = "txt_gfullname1"
        Me.txt_gfullname1.Size = New System.Drawing.Size(291, 20)
        Me.txt_gfullname1.TabIndex = 3
        '
        'Label35
        '
        Me.Label35.AutoSize = True
        Me.Label35.Location = New System.Drawing.Point(118, 81)
        Me.Label35.Name = "Label35"
        Me.Label35.Size = New System.Drawing.Size(36, 13)
        Me.Label35.TabIndex = 2
        Me.Label35.Text = "ที่อยู่ : "
        '
        'txt_gid1
        '
        Me.txt_gid1.Enabled = False
        Me.txt_gid1.Location = New System.Drawing.Point(166, 48)
        Me.txt_gid1.Name = "txt_gid1"
        Me.txt_gid1.Size = New System.Drawing.Size(107, 20)
        Me.txt_gid1.TabIndex = 1
        '
        'Label36
        '
        Me.Label36.AutoSize = True
        Me.Label36.Location = New System.Drawing.Point(399, 77)
        Me.Label36.Name = "Label36"
        Me.Label36.Size = New System.Drawing.Size(77, 13)
        Me.Label36.TabIndex = 0
        Me.Label36.Text = "ชื่อ - นามสกุล : "
        '
        'lb_reid
        '
        Me.lb_reid.AutoSize = True
        Me.lb_reid.Location = New System.Drawing.Point(912, 72)
        Me.lb_reid.Name = "lb_reid"
        Me.lb_reid.Size = New System.Drawing.Size(10, 13)
        Me.lb_reid.TabIndex = 43
        Me.lb_reid.Text = "-"
        Me.lb_reid.Visible = False
        '
        'Fer_Con
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.AliceBlue
        Me.ClientSize = New System.Drawing.Size(934, 664)
        Me.Controls.Add(Me.lb_reid)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Controls.Add(Me.Label1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Fer_Con"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "ระบบบริหารจัดการกลุ่มออมทรัพย์หมู่บ้าน [บันทึกสัญญากู้ปุ๋ย]"
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label19 As System.Windows.Forms.Label
    Friend WithEvents ToolStrip1 As System.Windows.Forms.ToolStrip
    Friend WithEvents tst_save As System.Windows.Forms.ToolStripSplitButton
    Friend WithEvents tst_back As System.Windows.Forms.ToolStripButton
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
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
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents txt_create As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txt_gmonth1 As System.Windows.Forms.TextBox
    Friend WithEvents txt_gvocation1 As System.Windows.Forms.TextBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents txt_gaddess1 As System.Windows.Forms.TextBox
    Friend WithEvents Label34 As System.Windows.Forms.Label
    Friend WithEvents txt_gfullname1 As System.Windows.Forms.TextBox
    Friend WithEvents Label35 As System.Windows.Forms.Label
    Friend WithEvents txt_gid1 As System.Windows.Forms.TextBox
    Friend WithEvents Label36 As System.Windows.Forms.Label
    Friend WithEvents tst_clear As System.Windows.Forms.ToolStripSplitButton
    Friend WithEvents btn_Search1 As System.Windows.Forms.Button
    Friend WithEvents btn_Search2 As System.Windows.Forms.Button
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents lb_reid As System.Windows.Forms.Label
End Class

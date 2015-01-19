<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Login
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Login))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.btn_login = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.cbo_username = New System.Windows.Forms.ComboBox()
        Me.txt_password = New System.Windows.Forms.TextBox()
        Me.btn_cancel = New System.Windows.Forms.Button()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Cordia New", 27.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label1.Location = New System.Drawing.Point(75, 22)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(483, 46)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "ระบบบริหารจัดการกลุ่มออมทรัพย์หมู่บ้าน"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Cordia New", 27.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label2.Location = New System.Drawing.Point(117, 83)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(404, 46)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Village Saving Management System"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Cordia New", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label4.Location = New System.Drawing.Point(215, 36)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(154, 26)
        Me.Label4.TabIndex = 4
        Me.Label4.Text = "ชื่อผู้ใช้ (User name) : "
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Cordia New", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label5.Location = New System.Drawing.Point(215, 66)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(155, 26)
        Me.Label5.TabIndex = 5
        Me.Label5.Text = "รหัสผ่าน (Password) : "
        '
        'btn_login
        '
        Me.btn_login.Font = New System.Drawing.Font("Cordia New", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.btn_login.Location = New System.Drawing.Point(325, 115)
        Me.btn_login.Name = "btn_login"
        Me.btn_login.Size = New System.Drawing.Size(80, 37)
        Me.btn_login.TabIndex = 8
        Me.btn_login.Text = "ตกลง"
        Me.btn_login.UseVisualStyleBackColor = True
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.Village_Saving_Management_System.My.Resources.Resources.signin_icon
        Me.PictureBox1.Location = New System.Drawing.Point(36, 19)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(134, 144)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 2
        Me.PictureBox1.TabStop = False
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.cbo_username)
        Me.GroupBox1.Controls.Add(Me.txt_password)
        Me.GroupBox1.Controls.Add(Me.btn_cancel)
        Me.GroupBox1.Controls.Add(Me.PictureBox1)
        Me.GroupBox1.Controls.Add(Me.btn_login)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Location = New System.Drawing.Point(47, 153)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(551, 198)
        Me.GroupBox1.TabIndex = 9
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "เข้าใช้ระบบ"
        '
        'cbo_username
        '
        Me.cbo_username.FormattingEnabled = True
        Me.cbo_username.Location = New System.Drawing.Point(371, 39)
        Me.cbo_username.Name = "cbo_username"
        Me.cbo_username.Size = New System.Drawing.Size(140, 21)
        Me.cbo_username.TabIndex = 11
        Me.cbo_username.Text = "--เลือก--"
        '
        'txt_password
        '
        Me.txt_password.Location = New System.Drawing.Point(371, 69)
        Me.txt_password.Name = "txt_password"
        Me.txt_password.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txt_password.Size = New System.Drawing.Size(140, 20)
        Me.txt_password.TabIndex = 10
        '
        'btn_cancel
        '
        Me.btn_cancel.Font = New System.Drawing.Font("Cordia New", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.btn_cancel.Location = New System.Drawing.Point(431, 115)
        Me.btn_cancel.Name = "btn_cancel"
        Me.btn_cancel.Size = New System.Drawing.Size(80, 37)
        Me.btn_cancel.TabIndex = 9
        Me.btn_cancel.Text = "ยกเลิก"
        Me.btn_cancel.UseVisualStyleBackColor = True
        '
        'Login
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.AliceBlue
        Me.ClientSize = New System.Drawing.Size(662, 444)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Login"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "ระบบบริหารจัดการกลุ่มออมทรัพย์หมู่บ้าน"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents btn_login As System.Windows.Forms.Button
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents btn_cancel As System.Windows.Forms.Button
    Friend WithEvents txt_password As System.Windows.Forms.TextBox
    Friend WithEvents cbo_username As System.Windows.Forms.ComboBox
End Class

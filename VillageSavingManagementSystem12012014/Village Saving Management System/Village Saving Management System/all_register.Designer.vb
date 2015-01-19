<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class all_register
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(all_register))
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.btn_search = New System.Windows.Forms.Button()
        Me.txt_search = New System.Windows.Forms.TextBox()
        Me.cbo_search = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.username = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.address = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.personal_id = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.position = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.GroupBox1.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.btn_search)
        Me.GroupBox1.Controls.Add(Me.txt_search)
        Me.GroupBox1.Controls.Add(Me.cbo_search)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Location = New System.Drawing.Point(94, 62)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(430, 80)
        Me.GroupBox1.TabIndex = 20
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "ค้นหาสมาชิก"
        '
        'btn_search
        '
        Me.btn_search.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.btn_search.ImageAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btn_search.Location = New System.Drawing.Point(338, 27)
        Me.btn_search.Name = "btn_search"
        Me.btn_search.Size = New System.Drawing.Size(75, 30)
        Me.btn_search.TabIndex = 3
        Me.btn_search.Text = "ค้นหา"
        Me.btn_search.UseVisualStyleBackColor = True
        '
        'txt_search
        '
        Me.txt_search.Location = New System.Drawing.Point(197, 33)
        Me.txt_search.Name = "txt_search"
        Me.txt_search.Size = New System.Drawing.Size(130, 20)
        Me.txt_search.TabIndex = 2
        '
        'cbo_search
        '
        Me.cbo_search.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.cbo_search.FormattingEnabled = True
        Me.cbo_search.Items.AddRange(New Object() {"ชื่อ", "เลขบัตรประชาชน"})
        Me.cbo_search.Location = New System.Drawing.Point(70, 32)
        Me.cbo_search.Name = "cbo_search"
        Me.cbo_search.Size = New System.Drawing.Size(121, 21)
        Me.cbo_search.TabIndex = 1
        Me.cbo_search.Text = "เลือกคำค้น"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label2.Location = New System.Drawing.Point(12, 35)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(52, 13)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "ค้นหาจาก"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label1.Location = New System.Drawing.Point(89, 24)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(349, 25)
        Me.Label1.TabIndex = 19
        Me.Label1.Text = "ค้นหาข้อมูลผู้ลงทะเบียนเข้าใช้งานระบบ"
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.username, Me.address, Me.personal_id, Me.position})
        Me.DataGridView1.Location = New System.Drawing.Point(12, 160)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.DataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect
        Me.DataGridView1.Size = New System.Drawing.Size(512, 255)
        Me.DataGridView1.TabIndex = 18
        '
        'username
        '
        Me.username.DataPropertyName = "username"
        Me.username.FillWeight = 140.0!
        Me.username.HeaderText = "ชื่อ"
        Me.username.Name = "username"
        Me.username.Width = 140
        '
        'address
        '
        Me.address.DataPropertyName = "address"
        Me.address.HeaderText = "ที่อยู่"
        Me.address.Name = "address"
        '
        'personal_id
        '
        Me.personal_id.DataPropertyName = "personal_id"
        Me.personal_id.FillWeight = 130.0!
        Me.personal_id.HeaderText = "เลขที่บัตรประจำตัวประชาชน"
        Me.personal_id.Name = "personal_id"
        Me.personal_id.Width = 130
        '
        'position
        '
        Me.position.DataPropertyName = "position"
        Me.position.HeaderText = "ตำแหน่ง"
        Me.position.Name = "position"
        Me.position.ReadOnly = True
        '
        'all_register
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.AliceBlue
        Me.ClientSize = New System.Drawing.Size(555, 428)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.DataGridView1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "all_register"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "ระบบบริหารจัดการกลุ่มออมทรัพย์หมู่บ้าน"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents btn_search As System.Windows.Forms.Button
    Friend WithEvents txt_search As System.Windows.Forms.TextBox
    Friend WithEvents cbo_search As System.Windows.Forms.ComboBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents username As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents address As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents personal_id As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents position As System.Windows.Forms.DataGridViewTextBoxColumn
End Class

<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class all_customer_con
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(all_customer_con))
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.cust_id = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cust_fname = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cust_lname = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.personal_id = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cust_address = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.tel = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lb_id = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.btn_search = New System.Windows.Forms.Button()
        Me.txt_search = New System.Windows.Forms.TextBox()
        Me.cbo_search = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.dtt = New System.Windows.Forms.DateTimePicker()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.cust_id, Me.cust_fname, Me.cust_lname, Me.personal_id, Me.cust_address, Me.tel})
        Me.DataGridView1.Location = New System.Drawing.Point(29, 163)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.DataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect
        Me.DataGridView1.Size = New System.Drawing.Size(487, 279)
        Me.DataGridView1.TabIndex = 13
        '
        'cust_id
        '
        Me.cust_id.DataPropertyName = "cust_id"
        Me.cust_id.Frozen = True
        Me.cust_id.HeaderText = "เลขที่สมาชิก"
        Me.cust_id.Name = "cust_id"
        Me.cust_id.ReadOnly = True
        '
        'cust_fname
        '
        Me.cust_fname.DataPropertyName = "cust_fname"
        Me.cust_fname.Frozen = True
        Me.cust_fname.HeaderText = "ชื่อ"
        Me.cust_fname.Name = "cust_fname"
        Me.cust_fname.ReadOnly = True
        '
        'cust_lname
        '
        Me.cust_lname.DataPropertyName = "cust_lname"
        Me.cust_lname.Frozen = True
        Me.cust_lname.HeaderText = "นามสกุล"
        Me.cust_lname.Name = "cust_lname"
        Me.cust_lname.ReadOnly = True
        '
        'personal_id
        '
        Me.personal_id.DataPropertyName = "personal_id"
        Me.personal_id.FillWeight = 150.0!
        Me.personal_id.HeaderText = "เลขบัตรประชาชน"
        Me.personal_id.Name = "personal_id"
        Me.personal_id.ReadOnly = True
        Me.personal_id.Width = 150
        '
        'cust_address
        '
        Me.cust_address.DataPropertyName = "cust_address"
        Me.cust_address.HeaderText = "ที่อยู่"
        Me.cust_address.Name = "cust_address"
        Me.cust_address.ReadOnly = True
        '
        'tel
        '
        Me.tel.DataPropertyName = "tel"
        Me.tel.HeaderText = "เบอร์โทรศัพท์"
        Me.tel.Name = "tel"
        Me.tel.ReadOnly = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label1.Location = New System.Drawing.Point(139, 21)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(360, 25)
        Me.Label1.TabIndex = 15
        Me.Label1.Text = "ค้นหาข้อมูลสมาชิกกลุ่มออมทรัพย์หมู่บ้าน"
        '
        'lb_id
        '
        Me.lb_id.AutoSize = True
        Me.lb_id.Enabled = False
        Me.lb_id.Location = New System.Drawing.Point(705, 23)
        Me.lb_id.Name = "lb_id"
        Me.lb_id.Size = New System.Drawing.Size(10, 13)
        Me.lb_id.TabIndex = 16
        Me.lb_id.Text = "-"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.btn_search)
        Me.GroupBox1.Controls.Add(Me.txt_search)
        Me.GroupBox1.Controls.Add(Me.cbo_search)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Location = New System.Drawing.Point(86, 66)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(430, 77)
        Me.GroupBox1.TabIndex = 17
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "ค้นหาสมาชิก"
        '
        'btn_search
        '
        Me.btn_search.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.btn_search.ImageAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btn_search.Location = New System.Drawing.Point(332, 19)
        Me.btn_search.Name = "btn_search"
        Me.btn_search.Size = New System.Drawing.Size(75, 30)
        Me.btn_search.TabIndex = 3
        Me.btn_search.Text = "ค้นหา"
        Me.btn_search.UseVisualStyleBackColor = True
        '
        'txt_search
        '
        Me.txt_search.Location = New System.Drawing.Point(191, 25)
        Me.txt_search.Name = "txt_search"
        Me.txt_search.Size = New System.Drawing.Size(130, 20)
        Me.txt_search.TabIndex = 2
        '
        'cbo_search
        '
        Me.cbo_search.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.cbo_search.FormattingEnabled = True
        Me.cbo_search.Items.AddRange(New Object() {"ชื่อ", "รหัสสมาชิก", "เลขบัตรประชาชน"})
        Me.cbo_search.Location = New System.Drawing.Point(64, 24)
        Me.cbo_search.Name = "cbo_search"
        Me.cbo_search.Size = New System.Drawing.Size(121, 21)
        Me.cbo_search.TabIndex = 1
        Me.cbo_search.Text = "เลือกคำค้น"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label2.Location = New System.Drawing.Point(6, 27)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(52, 13)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "ค้นหาจาก"
        '
        'dtt
        '
        Me.dtt.Location = New System.Drawing.Point(12, 12)
        Me.dtt.Name = "dtt"
        Me.dtt.Size = New System.Drawing.Size(119, 20)
        Me.dtt.TabIndex = 18
        Me.dtt.Visible = False
        '
        'all_customer_con
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.AliceBlue
        Me.ClientSize = New System.Drawing.Size(554, 484)
        Me.Controls.Add(Me.dtt)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.lb_id)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.DataGridView1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "all_customer_con"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "ระบบบริหารจัดการกลุ่มออมทรัพย์หมู่บ้าน"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents lb_id As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents btn_search As System.Windows.Forms.Button
    Friend WithEvents txt_search As System.Windows.Forms.TextBox
    Friend WithEvents cbo_search As System.Windows.Forms.ComboBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents dtt As System.Windows.Forms.DateTimePicker
    Friend WithEvents cust_id As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents cust_fname As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents cust_lname As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents personal_id As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents cust_address As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents tel As System.Windows.Forms.DataGridViewTextBoxColumn
End Class

<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FrmCreateNewUser
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmCreateNewUser))
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.txtusertype = New System.Windows.Forms.ComboBox()
        Me.txtpassword = New System.Windows.Forms.TextBox()
        Me.txtusername = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.dgvuser = New System.Windows.Forms.DataGridView()
        Me.imag = New System.Windows.Forms.DataGridViewImageColumn()
        Me.id = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.username = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.password = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.usertype = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.txtid = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Img = New System.Windows.Forms.PictureBox()
        Me.btnimage = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Button6 = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.cbmanageuseraccount = New System.Windows.Forms.CheckBox()
        Me.cbmanagedata = New System.Windows.Forms.CheckBox()
        Me.cbmanagedataschedule = New System.Windows.Forms.CheckBox()
        Me.cbomanagedatasubject = New System.Windows.Forms.CheckBox()
        Me.cbmanagedatastudent = New System.Windows.Forms.CheckBox()
        Me.cbmanagedataemployee = New System.Windows.Forms.CheckBox()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvuser, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        CType(Me.Img, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.ThesisNanaManagementSystem.My.Resources.Resources.images
        Me.PictureBox1.Location = New System.Drawing.Point(619, 12)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(70, 52)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 13
        Me.PictureBox1.TabStop = False
        '
        'txtusertype
        '
        Me.txtusertype.Font = New System.Drawing.Font("Khmer Kep", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtusertype.Items.AddRange(New Object() {"បុគ្គលិក", "អ្នកគ្រប់គ្រង"})
        Me.txtusertype.Location = New System.Drawing.Point(221, 263)
        Me.txtusertype.Name = "txtusertype"
        Me.txtusertype.Size = New System.Drawing.Size(247, 32)
        Me.txtusertype.TabIndex = 9
        '
        'txtpassword
        '
        Me.txtpassword.Font = New System.Drawing.Font("Khmer Kep", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtpassword.Location = New System.Drawing.Point(221, 207)
        Me.txtpassword.Name = "txtpassword"
        Me.txtpassword.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtpassword.Size = New System.Drawing.Size(247, 32)
        Me.txtpassword.TabIndex = 7
        '
        'txtusername
        '
        Me.txtusername.Font = New System.Drawing.Font("Khmer Kep", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtusername.Location = New System.Drawing.Point(221, 151)
        Me.txtusername.Name = "txtusername"
        Me.txtusername.Size = New System.Drawing.Size(247, 32)
        Me.txtusername.TabIndex = 5
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Khmer Kep", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Blue
        Me.Label4.Location = New System.Drawing.Point(82, 260)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(132, 33)
        Me.Label4.TabIndex = 8
        Me.Label4.Text = "ប្រភេទអ្នកប្រើប្រាស់"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Khmer Kep", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Blue
        Me.Label3.Location = New System.Drawing.Point(82, 207)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(86, 33)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "ពាក្យសម្ងាត់"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Khmer Kep", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.Blue
        Me.Label5.Location = New System.Drawing.Point(82, 148)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(101, 33)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "ឈ្មោះគណនីថ្មី"
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.White
        Me.Button1.Font = New System.Drawing.Font("Khmer Kep", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.ForeColor = System.Drawing.Color.Lime
        Me.Button1.Location = New System.Drawing.Point(150, 329)
        Me.Button1.Name = "Button1"
        Me.Button1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Button1.Size = New System.Drawing.Size(143, 33)
        Me.Button1.TabIndex = 10
        Me.Button1.Text = "បន្ថែមចូលបញ្ជីគណនីថ្មី"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'Button3
        '
        Me.Button3.BackColor = System.Drawing.Color.White
        Me.Button3.Font = New System.Drawing.Font("Khmer Kep", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button3.ForeColor = System.Drawing.Color.Red
        Me.Button3.Location = New System.Drawing.Point(908, 329)
        Me.Button3.Name = "Button3"
        Me.Button3.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Button3.Size = New System.Drawing.Size(119, 33)
        Me.Button3.TabIndex = 12
        Me.Button3.Text = "បិទ"
        Me.Button3.UseVisualStyleBackColor = False
        '
        'Button4
        '
        Me.Button4.BackColor = System.Drawing.Color.White
        Me.Button4.Font = New System.Drawing.Font("Khmer Kep", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button4.ForeColor = System.Drawing.Color.DarkGreen
        Me.Button4.Location = New System.Drawing.Point(313, 329)
        Me.Button4.Name = "Button4"
        Me.Button4.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Button4.Size = New System.Drawing.Size(124, 33)
        Me.Button4.TabIndex = 11
        Me.Button4.Text = "រក្សាទុក"
        Me.Button4.UseVisualStyleBackColor = False
        '
        'dgvuser
        '
        Me.dgvuser.AllowUserToAddRows = False
        Me.dgvuser.AllowUserToDeleteRows = False
        Me.dgvuser.AllowUserToResizeColumns = False
        Me.dgvuser.AllowUserToResizeRows = False
        Me.dgvuser.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.ColumnHeader
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Khmer Kep", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvuser.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.dgvuser.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvuser.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.imag, Me.id, Me.username, Me.password, Me.usertype, Me.Column1, Me.Column2, Me.Column3, Me.Column4, Me.Column5, Me.Column6})
        Me.dgvuser.Location = New System.Drawing.Point(29, 400)
        Me.dgvuser.Name = "dgvuser"
        Me.dgvuser.ReadOnly = True
        Me.dgvuser.RowHeadersVisible = False
        Me.dgvuser.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvuser.Size = New System.Drawing.Size(1212, 239)
        Me.dgvuser.TabIndex = 13
        '
        'imag
        '
        Me.imag.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        Me.imag.HeaderText = "រូបភាព"
        Me.imag.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Stretch
        Me.imag.MinimumWidth = 50
        Me.imag.Name = "imag"
        Me.imag.ReadOnly = True
        Me.imag.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.imag.Width = 50
        '
        'id
        '
        Me.id.HeaderText = "លេខរៀង"
        Me.id.Name = "id"
        Me.id.ReadOnly = True
        Me.id.Width = 81
        '
        'username
        '
        Me.username.HeaderText = "ឈ្មោះគណនី"
        Me.username.Name = "username"
        Me.username.ReadOnly = True
        Me.username.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic
        Me.username.Width = 97
        '
        'password
        '
        Me.password.HeaderText = "ពាក្យសម្ងាត់"
        Me.password.Name = "password"
        Me.password.ReadOnly = True
        Me.password.Width = 95
        '
        'usertype
        '
        Me.usertype.HeaderText = "ប្រភេទអ្នកប្រើប្រាស់"
        Me.usertype.Name = "usertype"
        Me.usertype.ReadOnly = True
        Me.usertype.Width = 132
        '
        'Column1
        '
        Me.Column1.HeaderText = "(សិទ្ធិ)គ្រប់គ្រងទិន្នន័យគណនី"
        Me.Column1.Name = "Column1"
        Me.Column1.ReadOnly = True
        Me.Column1.Width = 173
        '
        'Column2
        '
        Me.Column2.HeaderText = "(សិទ្ធិ)បញ្ជីសិស្ស"
        Me.Column2.Name = "Column2"
        Me.Column2.ReadOnly = True
        Me.Column2.Width = 116
        '
        'Column3
        '
        Me.Column3.HeaderText = "(សិទ្ធិ)បញ្ជីបុគ្គលិក"
        Me.Column3.Name = "Column3"
        Me.Column3.ReadOnly = True
        Me.Column3.Width = 125
        '
        'Column4
        '
        Me.Column4.HeaderText = "(សិទ្ធិ)បញ្ជីមុខវិជ្ជាសិក្សា"
        Me.Column4.Name = "Column4"
        Me.Column4.ReadOnly = True
        Me.Column4.Width = 151
        '
        'Column5
        '
        Me.Column5.HeaderText = "(សិទ្ធិ)តារាងពេលវេលា"
        Me.Column5.Name = "Column5"
        Me.Column5.ReadOnly = True
        Me.Column5.Width = 145
        '
        'Column6
        '
        Me.Column6.HeaderText = "(សិទ្ធិ)DataManagement"
        Me.Column6.Name = "Column6"
        Me.Column6.ReadOnly = True
        Me.Column6.Width = 167
        '
        'txtid
        '
        Me.txtid.Font = New System.Drawing.Font("Khmer Kep", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtid.Location = New System.Drawing.Point(221, 96)
        Me.txtid.Name = "txtid"
        Me.txtid.Size = New System.Drawing.Size(247, 32)
        Me.txtid.TabIndex = 3
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Khmer Kep", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.Blue
        Me.Label6.Location = New System.Drawing.Point(82, 93)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(65, 33)
        Me.Label6.TabIndex = 2
        Me.Label6.Text = "អត្តលេខ"
        '
        'Panel1
        '
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.Img)
        Me.Panel1.Location = New System.Drawing.Point(1053, 96)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(140, 182)
        Me.Panel1.TabIndex = 14
        '
        'Img
        '
        Me.Img.Location = New System.Drawing.Point(2, 1)
        Me.Img.Name = "Img"
        Me.Img.Size = New System.Drawing.Size(134, 176)
        Me.Img.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.Img.TabIndex = 0
        Me.Img.TabStop = False
        '
        'btnimage
        '
        Me.btnimage.BackColor = System.Drawing.Color.White
        Me.btnimage.Font = New System.Drawing.Font("Khmer Kep", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnimage.ForeColor = System.Drawing.Color.Lime
        Me.btnimage.Location = New System.Drawing.Point(1053, 280)
        Me.btnimage.Name = "btnimage"
        Me.btnimage.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.btnimage.Size = New System.Drawing.Size(140, 33)
        Me.btnimage.TabIndex = 15
        Me.btnimage.Text = "រូបភាព"
        Me.btnimage.UseVisualStyleBackColor = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Khmer Wat Phnom", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label2.Location = New System.Drawing.Point(499, 18)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(129, 46)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "បង្កើតគណនីថ្មី"
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.White
        Me.Button2.Font = New System.Drawing.Font("Khmer Kep", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.ForeColor = System.Drawing.Color.Red
        Me.Button2.Location = New System.Drawing.Point(620, 329)
        Me.Button2.Name = "Button2"
        Me.Button2.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Button2.Size = New System.Drawing.Size(124, 33)
        Me.Button2.TabIndex = 16
        Me.Button2.Text = "លុប"
        Me.Button2.UseVisualStyleBackColor = False
        '
        'Button5
        '
        Me.Button5.BackColor = System.Drawing.Color.White
        Me.Button5.Font = New System.Drawing.Font("Khmer Kep", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button5.ForeColor = System.Drawing.Color.Aqua
        Me.Button5.Location = New System.Drawing.Point(766, 329)
        Me.Button5.Name = "Button5"
        Me.Button5.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Button5.Size = New System.Drawing.Size(124, 33)
        Me.Button5.TabIndex = 17
        Me.Button5.Text = "កែប្រែ"
        Me.Button5.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Khmer Kep", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Blue
        Me.Label1.Location = New System.Drawing.Point(23, 364)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(90, 33)
        Me.Label1.TabIndex = 18
        Me.Label1.Text = "បញ្ជីគណនីថ្មី"
        '
        'Button6
        '
        Me.Button6.BackColor = System.Drawing.Color.White
        Me.Button6.Font = New System.Drawing.Font("Khmer Kep", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button6.ForeColor = System.Drawing.Color.Gray
        Me.Button6.Location = New System.Drawing.Point(471, 329)
        Me.Button6.Name = "Button6"
        Me.Button6.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Button6.Size = New System.Drawing.Size(124, 33)
        Me.Button6.TabIndex = 19
        Me.Button6.Text = "ជម្រះ"
        Me.Button6.UseVisualStyleBackColor = False
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.cbmanageuseraccount)
        Me.GroupBox1.Controls.Add(Me.cbmanagedata)
        Me.GroupBox1.Controls.Add(Me.cbmanagedataschedule)
        Me.GroupBox1.Controls.Add(Me.cbomanagedatasubject)
        Me.GroupBox1.Controls.Add(Me.cbmanagedatastudent)
        Me.GroupBox1.Controls.Add(Me.cbmanagedataemployee)
        Me.GroupBox1.Font = New System.Drawing.Font("Khmer Kep", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.ForeColor = System.Drawing.Color.Blue
        Me.GroupBox1.Location = New System.Drawing.Point(531, 79)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(469, 216)
        Me.GroupBox1.TabIndex = 20
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "សិទ្ធប្រើប្រាស់ប្រព័ន្ធ"
        '
        'cbmanageuseraccount
        '
        Me.cbmanageuseraccount.AutoSize = True
        Me.cbmanageuseraccount.Location = New System.Drawing.Point(30, 163)
        Me.cbmanageuseraccount.Name = "cbmanageuseraccount"
        Me.cbmanageuseraccount.Size = New System.Drawing.Size(167, 37)
        Me.cbmanageuseraccount.TabIndex = 5
        Me.cbmanageuseraccount.Text = "គ្រប់គ្រងទិន្នន័យគណនី"
        Me.cbmanageuseraccount.UseVisualStyleBackColor = True
        '
        'cbmanagedata
        '
        Me.cbmanagedata.AutoSize = True
        Me.cbmanagedata.Location = New System.Drawing.Point(181, 102)
        Me.cbmanagedata.Name = "cbmanagedata"
        Me.cbmanagedata.Size = New System.Drawing.Size(161, 37)
        Me.cbmanagedata.TabIndex = 4
        Me.cbmanagedata.Text = "Data Management"
        Me.cbmanagedata.UseVisualStyleBackColor = True
        '
        'cbmanagedataschedule
        '
        Me.cbmanagedataschedule.AutoSize = True
        Me.cbmanagedataschedule.Location = New System.Drawing.Point(30, 102)
        Me.cbmanagedataschedule.Name = "cbmanagedataschedule"
        Me.cbmanagedataschedule.Size = New System.Drawing.Size(129, 37)
        Me.cbmanagedataschedule.TabIndex = 3
        Me.cbmanagedataschedule.Text = "តារាងពេលវេលា"
        Me.cbmanagedataschedule.UseVisualStyleBackColor = True
        '
        'cbomanagedatasubject
        '
        Me.cbomanagedatasubject.AutoSize = True
        Me.cbomanagedatasubject.Location = New System.Drawing.Point(316, 40)
        Me.cbomanagedatasubject.Name = "cbomanagedatasubject"
        Me.cbomanagedatasubject.Size = New System.Drawing.Size(137, 37)
        Me.cbomanagedatasubject.TabIndex = 2
        Me.cbomanagedatasubject.Text = "បញ្ជីមុខវិជ្ជាសិក្សា"
        Me.cbomanagedatasubject.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.cbomanagedatasubject.UseVisualStyleBackColor = True
        '
        'cbmanagedatastudent
        '
        Me.cbmanagedatastudent.AutoSize = True
        Me.cbmanagedatastudent.Location = New System.Drawing.Point(181, 40)
        Me.cbmanagedatastudent.Name = "cbmanagedatastudent"
        Me.cbmanagedatastudent.Size = New System.Drawing.Size(94, 37)
        Me.cbmanagedatastudent.TabIndex = 1
        Me.cbmanagedatastudent.Text = "បញ្ជីសិស្ស"
        Me.cbmanagedatastudent.UseVisualStyleBackColor = True
        '
        'cbmanagedataemployee
        '
        Me.cbmanagedataemployee.AutoSize = True
        Me.cbmanagedataemployee.Location = New System.Drawing.Point(30, 40)
        Me.cbmanagedataemployee.Name = "cbmanagedataemployee"
        Me.cbmanagedataemployee.Size = New System.Drawing.Size(105, 37)
        Me.cbmanagedataemployee.TabIndex = 0
        Me.cbmanagedataemployee.Text = "បញ្ជីបុគ្គលិក"
        Me.cbmanagedataemployee.UseVisualStyleBackColor = True
        '
        'FrmCreateNewUser
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1272, 676)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Button6)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Button5)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.btnimage)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.txtid)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.dgvuser)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.txtusertype)
        Me.Controls.Add(Me.txtpassword)
        Me.Controls.Add(Me.txtusername)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.PictureBox1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "FrmCreateNewUser"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "ប្រព័ន្ធគ្រប់គ្រងទិន្នន័យសិស្ស និង បុគ្គលិក"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgvuser, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        CType(Me.Img, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents txtusertype As ComboBox
    Friend WithEvents txtpassword As TextBox
    Friend WithEvents txtusername As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents Button4 As Button
    Friend WithEvents dgvuser As DataGridView
    Friend WithEvents txtid As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents btnimage As Button
    Friend WithEvents Img As PictureBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Button2 As Button
    Friend WithEvents Button5 As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Button6 As Button
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents cbmanagedatastudent As CheckBox
    Friend WithEvents cbmanagedataemployee As CheckBox
    Friend WithEvents cbomanagedatasubject As CheckBox
    Friend WithEvents cbmanageuseraccount As CheckBox
    Friend WithEvents cbmanagedata As CheckBox
    Friend WithEvents cbmanagedataschedule As CheckBox
    Friend WithEvents imag As DataGridViewImageColumn
    Friend WithEvents id As DataGridViewTextBoxColumn
    Friend WithEvents username As DataGridViewTextBoxColumn
    Friend WithEvents password As DataGridViewTextBoxColumn
    Friend WithEvents usertype As DataGridViewTextBoxColumn
    Friend WithEvents Column1 As DataGridViewTextBoxColumn
    Friend WithEvents Column2 As DataGridViewTextBoxColumn
    Friend WithEvents Column3 As DataGridViewTextBoxColumn
    Friend WithEvents Column4 As DataGridViewTextBoxColumn
    Friend WithEvents Column5 As DataGridViewTextBoxColumn
    Friend WithEvents Column6 As DataGridViewTextBoxColumn
End Class

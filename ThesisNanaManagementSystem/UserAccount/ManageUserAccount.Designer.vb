<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ManageUserAccount
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ManageUserAccount))
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.cbmanageuseraccount = New System.Windows.Forms.CheckBox()
        Me.cbmanagedata = New System.Windows.Forms.CheckBox()
        Me.cbmanagedataschedule = New System.Windows.Forms.CheckBox()
        Me.cbmanagedatasubject = New System.Windows.Forms.CheckBox()
        Me.cbmanagedatastudent = New System.Windows.Forms.CheckBox()
        Me.cbmanagedataemployee = New System.Windows.Forms.CheckBox()
        Me.Button6 = New System.Windows.Forms.Button()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.btnimage = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Imageuser = New System.Windows.Forms.PictureBox()
        Me.txtid = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
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
        Me.Button3 = New System.Windows.Forms.Button()
        Me.txtusertype = New System.Windows.Forms.ComboBox()
        Me.txtpassword = New System.Windows.Forms.TextBox()
        Me.txtusername = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.txtsearch = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        Me.Panel1.SuspendLayout()
        CType(Me.Imageuser, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvuser, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.cbmanageuseraccount)
        Me.GroupBox1.Controls.Add(Me.cbmanagedata)
        Me.GroupBox1.Controls.Add(Me.cbmanagedataschedule)
        Me.GroupBox1.Controls.Add(Me.cbmanagedatasubject)
        Me.GroupBox1.Controls.Add(Me.cbmanagedatastudent)
        Me.GroupBox1.Controls.Add(Me.cbmanagedataemployee)
        Me.GroupBox1.Font = New System.Drawing.Font("Khmer Kep", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.ForeColor = System.Drawing.Color.Blue
        Me.GroupBox1.Location = New System.Drawing.Point(525, 71)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(469, 216)
        Me.GroupBox1.TabIndex = 41
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
        'cbmanagedatasubject
        '
        Me.cbmanagedatasubject.AutoSize = True
        Me.cbmanagedatasubject.Location = New System.Drawing.Point(316, 40)
        Me.cbmanagedatasubject.Name = "cbmanagedatasubject"
        Me.cbmanagedatasubject.Size = New System.Drawing.Size(137, 37)
        Me.cbmanagedatasubject.TabIndex = 2
        Me.cbmanagedatasubject.Text = "បញ្ជីមុខវិជ្ជាសិក្សា"
        Me.cbmanagedatasubject.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.cbmanagedatasubject.UseVisualStyleBackColor = True
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
        'Button6
        '
        Me.Button6.BackColor = System.Drawing.Color.White
        Me.Button6.Font = New System.Drawing.Font("Khmer Kep", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button6.ForeColor = System.Drawing.Color.Blue
        Me.Button6.Location = New System.Drawing.Point(530, 317)
        Me.Button6.Name = "Button6"
        Me.Button6.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Button6.Size = New System.Drawing.Size(116, 33)
        Me.Button6.TabIndex = 6
        Me.Button6.Text = "ជម្រះ"
        Me.Button6.UseVisualStyleBackColor = False
        '
        'Button5
        '
        Me.Button5.BackColor = System.Drawing.Color.White
        Me.Button5.Font = New System.Drawing.Font("Khmer Kep", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button5.ForeColor = System.Drawing.Color.Aqua
        Me.Button5.Location = New System.Drawing.Point(203, 317)
        Me.Button5.Name = "Button5"
        Me.Button5.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Button5.Size = New System.Drawing.Size(116, 33)
        Me.Button5.TabIndex = 4
        Me.Button5.Text = "កែប្រែ"
        Me.Button5.UseVisualStyleBackColor = False
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.White
        Me.Button2.Font = New System.Drawing.Font("Khmer Kep", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.ForeColor = System.Drawing.Color.Red
        Me.Button2.Location = New System.Drawing.Point(365, 317)
        Me.Button2.Name = "Button2"
        Me.Button2.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Button2.Size = New System.Drawing.Size(116, 33)
        Me.Button2.TabIndex = 5
        Me.Button2.Text = "លុប"
        Me.Button2.UseVisualStyleBackColor = False
        '
        'btnimage
        '
        Me.btnimage.BackColor = System.Drawing.Color.White
        Me.btnimage.Font = New System.Drawing.Font("Khmer Kep", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnimage.ForeColor = System.Drawing.Color.Lime
        Me.btnimage.Location = New System.Drawing.Point(1055, 267)
        Me.btnimage.Name = "btnimage"
        Me.btnimage.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.btnimage.Size = New System.Drawing.Size(140, 33)
        Me.btnimage.TabIndex = 3
        Me.btnimage.Text = "រូបភាព"
        Me.btnimage.UseVisualStyleBackColor = False
        '
        'Panel1
        '
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.Imageuser)
        Me.Panel1.Location = New System.Drawing.Point(1055, 83)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(140, 182)
        Me.Panel1.TabIndex = 35
        '
        'Imageuser
        '
        Me.Imageuser.Location = New System.Drawing.Point(2, 1)
        Me.Imageuser.Name = "Imageuser"
        Me.Imageuser.Size = New System.Drawing.Size(134, 176)
        Me.Imageuser.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.Imageuser.TabIndex = 0
        Me.Imageuser.TabStop = False
        '
        'txtid
        '
        Me.txtid.Font = New System.Drawing.Font("Khmer Kep", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtid.Location = New System.Drawing.Point(215, 88)
        Me.txtid.Name = "txtid"
        Me.txtid.ReadOnly = True
        Me.txtid.Size = New System.Drawing.Size(247, 32)
        Me.txtid.TabIndex = 23
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Khmer Kep", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.Blue
        Me.Label6.Location = New System.Drawing.Point(76, 85)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(65, 33)
        Me.Label6.TabIndex = 22
        Me.Label6.Text = "អត្តលេខ"
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
        Me.dgvuser.Location = New System.Drawing.Point(30, 378)
        Me.dgvuser.Name = "dgvuser"
        Me.dgvuser.ReadOnly = True
        Me.dgvuser.RowHeadersVisible = False
        Me.dgvuser.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvuser.Size = New System.Drawing.Size(1212, 239)
        Me.dgvuser.TabIndex = 34
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
        'Button3
        '
        Me.Button3.BackColor = System.Drawing.Color.White
        Me.Button3.Font = New System.Drawing.Font("Khmer Kep", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button3.ForeColor = System.Drawing.Color.Red
        Me.Button3.Location = New System.Drawing.Point(695, 317)
        Me.Button3.Name = "Button3"
        Me.Button3.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Button3.Size = New System.Drawing.Size(111, 33)
        Me.Button3.TabIndex = 7
        Me.Button3.Text = "បិទ"
        Me.Button3.UseVisualStyleBackColor = False
        '
        'txtusertype
        '
        Me.txtusertype.Font = New System.Drawing.Font("Khmer Kep", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtusertype.Items.AddRange(New Object() {"បុគ្គលិក", "អ្នកគ្រប់គ្រង"})
        Me.txtusertype.Location = New System.Drawing.Point(215, 255)
        Me.txtusertype.Name = "txtusertype"
        Me.txtusertype.Size = New System.Drawing.Size(247, 32)
        Me.txtusertype.TabIndex = 2
        '
        'txtpassword
        '
        Me.txtpassword.Font = New System.Drawing.Font("Khmer Kep", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtpassword.Location = New System.Drawing.Point(215, 199)
        Me.txtpassword.Name = "txtpassword"
        Me.txtpassword.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtpassword.Size = New System.Drawing.Size(247, 32)
        Me.txtpassword.TabIndex = 1
        '
        'txtusername
        '
        Me.txtusername.Font = New System.Drawing.Font("Khmer Kep", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtusername.Location = New System.Drawing.Point(215, 143)
        Me.txtusername.Name = "txtusername"
        Me.txtusername.Size = New System.Drawing.Size(247, 32)
        Me.txtusername.TabIndex = 0
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Khmer Kep", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Blue
        Me.Label4.Location = New System.Drawing.Point(76, 252)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(132, 33)
        Me.Label4.TabIndex = 28
        Me.Label4.Text = "ប្រភេទអ្នកប្រើប្រាស់"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Khmer Kep", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Blue
        Me.Label3.Location = New System.Drawing.Point(76, 199)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(86, 33)
        Me.Label3.TabIndex = 26
        Me.Label3.Text = "ពាក្យសម្ងាត់"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Khmer Kep", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.Blue
        Me.Label5.Location = New System.Drawing.Point(76, 140)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(90, 33)
        Me.Label5.TabIndex = 24
        Me.Label5.Text = "ឈ្មោះគណនី"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Khmer Wat Phnom", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label2.Location = New System.Drawing.Point(508, 7)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(195, 46)
        Me.Label2.TabIndex = 21
        Me.Label2.Text = "គ្រប់គ្រងទិន្នន័យគណនី"
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.ThesisNanaManagementSystem.My.Resources.Resources.images
        Me.PictureBox1.Location = New System.Drawing.Point(695, 4)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(70, 52)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 33
        Me.PictureBox1.TabStop = False
        '
        'txtsearch
        '
        Me.txtsearch.Font = New System.Drawing.Font("Khmer Kep", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtsearch.Location = New System.Drawing.Point(859, 330)
        Me.txtsearch.Name = "txtsearch"
        Me.txtsearch.Size = New System.Drawing.Size(247, 32)
        Me.txtsearch.TabIndex = 8
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Khmer Kep", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Blue
        Me.Label1.Location = New System.Drawing.Point(895, 294)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(175, 33)
        Me.Label1.TabIndex = 42
        Me.Label1.Text = "ស្វែងរកទិន្នន័យដោយឈ្មោះ"
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.White
        Me.Button1.Font = New System.Drawing.Font("Khmer Kep", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.ForeColor = System.Drawing.Color.Lime
        Me.Button1.Location = New System.Drawing.Point(46, 317)
        Me.Button1.Name = "Button1"
        Me.Button1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Button1.Size = New System.Drawing.Size(116, 33)
        Me.Button1.TabIndex = 43
        Me.Button1.Text = "Export to Excel"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'ManageUserAccount
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1269, 642)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.txtsearch)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Button6)
        Me.Controls.Add(Me.Button5)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.btnimage)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.txtid)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.dgvuser)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.txtusertype)
        Me.Controls.Add(Me.txtpassword)
        Me.Controls.Add(Me.txtusername)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Label1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "ManageUserAccount"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "ប្រព័ន្ធគ្រប់គ្រងទិន្នន័យសិស្ស និង បុគ្គលិក"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        CType(Me.Imageuser, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgvuser, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents cbmanageuseraccount As CheckBox
    Friend WithEvents cbmanagedata As CheckBox
    Friend WithEvents cbmanagedataschedule As CheckBox
    Friend WithEvents cbmanagedatasubject As CheckBox
    Friend WithEvents cbmanagedatastudent As CheckBox
    Friend WithEvents cbmanagedataemployee As CheckBox
    Friend WithEvents Button6 As Button
    Friend WithEvents Button5 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents btnimage As Button
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Imageuser As PictureBox
    Friend WithEvents txtid As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents dgvuser As DataGridView
    Friend WithEvents Button3 As Button
    Friend WithEvents txtusertype As ComboBox
    Friend WithEvents txtpassword As TextBox
    Friend WithEvents txtusername As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents txtsearch As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Button1 As Button
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

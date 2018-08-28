<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FrmSchedule
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmSchedule))
        Me.cbotimenameid = New System.Windows.Forms.ComboBox()
        Me.txtdesc = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.btndelete = New System.Windows.Forms.Button()
        Me.btnclose = New System.Windows.Forms.Button()
        Me.btnmodify = New System.Windows.Forms.Button()
        Me.btnclear = New System.Windows.Forms.Button()
        Me.btnadd = New System.Windows.Forms.Button()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.dgvschedule = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Desc = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.subject = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Descs = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txtid = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.cbodayid = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.cbotimeid = New System.Windows.Forms.ComboBox()
        Me.tbnadddaystudy = New System.Windows.Forms.Button()
        Me.btnaddtimestudy = New System.Windows.Forms.Button()
        Me.btnaddtimenamestudy = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.cbosubject = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.dtpstartdate = New System.Windows.Forms.DateTimePicker()
        CType(Me.dgvschedule, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'cbotimenameid
        '
        Me.cbotimenameid.Font = New System.Drawing.Font("Khmer Kep", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbotimenameid.Items.AddRange(New Object() {"ព្រឹក", "រសៀល", "ល្ងាច"})
        Me.cbotimenameid.Location = New System.Drawing.Point(170, 157)
        Me.cbotimenameid.Name = "cbotimenameid"
        Me.cbotimenameid.Size = New System.Drawing.Size(247, 32)
        Me.cbotimenameid.TabIndex = 2
        '
        'txtdesc
        '
        Me.txtdesc.Font = New System.Drawing.Font("Khmer Kep", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtdesc.Location = New System.Drawing.Point(170, 209)
        Me.txtdesc.Name = "txtdesc"
        Me.txtdesc.Size = New System.Drawing.Size(247, 32)
        Me.txtdesc.TabIndex = 6
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Khmer Kep", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.ForeColor = System.Drawing.Color.Blue
        Me.Label11.Location = New System.Drawing.Point(31, 206)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(112, 33)
        Me.Label11.TabIndex = 67
        Me.Label11.Text = "សេចក្តីអធិប្បាយ"
        '
        'btndelete
        '
        Me.btndelete.BackColor = System.Drawing.Color.White
        Me.btndelete.Font = New System.Drawing.Font("Khmer Kep", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btndelete.ForeColor = System.Drawing.Color.Lime
        Me.btndelete.Location = New System.Drawing.Point(600, 270)
        Me.btndelete.Name = "btndelete"
        Me.btndelete.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.btndelete.Size = New System.Drawing.Size(133, 33)
        Me.btndelete.TabIndex = 10
        Me.btndelete.Text = "លុប"
        Me.btndelete.UseVisualStyleBackColor = False
        '
        'btnclose
        '
        Me.btnclose.BackColor = System.Drawing.Color.White
        Me.btnclose.Font = New System.Drawing.Font("Khmer Kep", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnclose.ForeColor = System.Drawing.Color.Red
        Me.btnclose.Location = New System.Drawing.Point(793, 270)
        Me.btnclose.Name = "btnclose"
        Me.btnclose.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.btnclose.Size = New System.Drawing.Size(133, 33)
        Me.btnclose.TabIndex = 11
        Me.btnclose.Text = "បិទ"
        Me.btnclose.UseVisualStyleBackColor = False
        '
        'btnmodify
        '
        Me.btnmodify.BackColor = System.Drawing.Color.White
        Me.btnmodify.Font = New System.Drawing.Font("Khmer Kep", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnmodify.ForeColor = System.Drawing.Color.Lime
        Me.btnmodify.Location = New System.Drawing.Point(407, 270)
        Me.btnmodify.Name = "btnmodify"
        Me.btnmodify.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.btnmodify.Size = New System.Drawing.Size(133, 33)
        Me.btnmodify.TabIndex = 9
        Me.btnmodify.Text = "កែប្រែ"
        Me.btnmodify.UseVisualStyleBackColor = False
        '
        'btnclear
        '
        Me.btnclear.BackColor = System.Drawing.Color.White
        Me.btnclear.Font = New System.Drawing.Font("Khmer Kep", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnclear.ForeColor = System.Drawing.Color.Lime
        Me.btnclear.Location = New System.Drawing.Point(220, 270)
        Me.btnclear.Name = "btnclear"
        Me.btnclear.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.btnclear.Size = New System.Drawing.Size(133, 33)
        Me.btnclear.TabIndex = 8
        Me.btnclear.Text = "ជម្រះ"
        Me.btnclear.UseVisualStyleBackColor = False
        '
        'btnadd
        '
        Me.btnadd.BackColor = System.Drawing.Color.White
        Me.btnadd.Font = New System.Drawing.Font("Khmer Kep", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnadd.ForeColor = System.Drawing.Color.Lime
        Me.btnadd.Location = New System.Drawing.Point(36, 270)
        Me.btnadd.Name = "btnadd"
        Me.btnadd.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.btnadd.Size = New System.Drawing.Size(133, 33)
        Me.btnadd.TabIndex = 7
        Me.btnadd.Text = "រក្សាទុក"
        Me.btnadd.UseVisualStyleBackColor = False
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Khmer Kep", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.Blue
        Me.Label5.Location = New System.Drawing.Point(30, 315)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(78, 33)
        Me.Label5.TabIndex = 60
        Me.Label5.Text = "កាលវិភាគ"
        '
        'dgvschedule
        '
        Me.dgvschedule.AllowUserToAddRows = False
        Me.dgvschedule.AllowUserToDeleteRows = False
        Me.dgvschedule.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Khmer Kep", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvschedule.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.dgvschedule.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvschedule.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.Desc, Me.subject, Me.Column1, Me.Descs})
        Me.dgvschedule.Location = New System.Drawing.Point(36, 351)
        Me.dgvschedule.Name = "dgvschedule"
        Me.dgvschedule.ReadOnly = True
        Me.dgvschedule.RowHeadersVisible = False
        Me.dgvschedule.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvschedule.Size = New System.Drawing.Size(897, 226)
        Me.dgvschedule.TabIndex = 59
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.HeaderText = "អត្តលេខ"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.ReadOnly = True
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.HeaderText = "ថ្ងៃសិក្សា"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        Me.DataGridViewTextBoxColumn2.ReadOnly = True
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.HeaderText = "ពេលសិក្សា"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        Me.DataGridViewTextBoxColumn3.ReadOnly = True
        '
        'Desc
        '
        Me.Desc.HeaderText = "ម៉ោងសិក្សា"
        Me.Desc.Name = "Desc"
        Me.Desc.ReadOnly = True
        '
        'subject
        '
        Me.subject.HeaderText = "មុខវិជ្ជាសិក្សា"
        Me.subject.Name = "subject"
        Me.subject.ReadOnly = True
        '
        'Column1
        '
        Me.Column1.HeaderText = "ថ្ងៃចាប់ផ្តើមសិក្សា"
        Me.Column1.Name = "Column1"
        Me.Column1.ReadOnly = True
        '
        'Descs
        '
        Me.Descs.HeaderText = "សេចក្តីអធិប្បាយ"
        Me.Descs.Name = "Descs"
        Me.Descs.ReadOnly = True
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Khmer Kep", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.Blue
        Me.Label7.Location = New System.Drawing.Point(507, 53)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(81, 33)
        Me.Label7.TabIndex = 57
        Me.Label7.Text = "ម៉ោងសិក្សា"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Khmer Kep", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.Blue
        Me.Label8.Location = New System.Drawing.Point(31, 154)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(80, 33)
        Me.Label8.TabIndex = 56
        Me.Label8.Text = "ពេលសិក្សា"
        '
        'txtid
        '
        Me.txtid.Font = New System.Drawing.Font("Khmer Kep", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtid.Location = New System.Drawing.Point(170, 56)
        Me.txtid.Name = "txtid"
        Me.txtid.ReadOnly = True
        Me.txtid.Size = New System.Drawing.Size(247, 32)
        Me.txtid.TabIndex = 0
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Khmer Kep", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.Blue
        Me.Label9.Location = New System.Drawing.Point(31, 53)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(65, 33)
        Me.Label9.TabIndex = 54
        Me.Label9.Text = "អត្តលេខ"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Khmer Wat Phnom", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.Color.Blue
        Me.Label10.Location = New System.Drawing.Point(381, -12)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(219, 67)
        Me.Label10.TabIndex = 53
        Me.Label10.Text = "តារាងពេលវេលា"
        '
        'cbodayid
        '
        Me.cbodayid.Font = New System.Drawing.Font("Khmer Kep", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbodayid.Items.AddRange(New Object() {"ច័ន្ទ - សុក្រ", "សៅរ៍ - អាទិត្យ"})
        Me.cbodayid.Location = New System.Drawing.Point(170, 107)
        Me.cbodayid.Name = "cbodayid"
        Me.cbodayid.Size = New System.Drawing.Size(247, 32)
        Me.cbodayid.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Khmer Kep", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Blue
        Me.Label1.Location = New System.Drawing.Point(31, 104)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(66, 33)
        Me.Label1.TabIndex = 71
        Me.Label1.Text = "ថ្ងៃសិក្សា"
        '
        'cbotimeid
        '
        Me.cbotimeid.Font = New System.Drawing.Font("Khmer Kep", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbotimeid.Items.AddRange(New Object() {"ព្រឹក", "រសៀល", "ល្ងាច"})
        Me.cbotimeid.Location = New System.Drawing.Point(646, 56)
        Me.cbotimeid.Name = "cbotimeid"
        Me.cbotimeid.Size = New System.Drawing.Size(247, 32)
        Me.cbotimeid.TabIndex = 4
        '
        'tbnadddaystudy
        '
        Me.tbnadddaystudy.BackColor = System.Drawing.Color.White
        Me.tbnadddaystudy.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbnadddaystudy.ForeColor = System.Drawing.Color.Lime
        Me.tbnadddaystudy.Location = New System.Drawing.Point(419, 105)
        Me.tbnadddaystudy.Name = "tbnadddaystudy"
        Me.tbnadddaystudy.Size = New System.Drawing.Size(31, 35)
        Me.tbnadddaystudy.TabIndex = 1
        Me.tbnadddaystudy.Text = "+"
        Me.tbnadddaystudy.UseVisualStyleBackColor = False
        '
        'btnaddtimestudy
        '
        Me.btnaddtimestudy.BackColor = System.Drawing.Color.White
        Me.btnaddtimestudy.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnaddtimestudy.ForeColor = System.Drawing.Color.Lime
        Me.btnaddtimestudy.Location = New System.Drawing.Point(895, 54)
        Me.btnaddtimestudy.Name = "btnaddtimestudy"
        Me.btnaddtimestudy.Size = New System.Drawing.Size(31, 35)
        Me.btnaddtimestudy.TabIndex = 5
        Me.btnaddtimestudy.Text = "+"
        Me.btnaddtimestudy.UseVisualStyleBackColor = False
        '
        'btnaddtimenamestudy
        '
        Me.btnaddtimenamestudy.BackColor = System.Drawing.Color.White
        Me.btnaddtimenamestudy.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnaddtimenamestudy.ForeColor = System.Drawing.Color.Lime
        Me.btnaddtimenamestudy.Location = New System.Drawing.Point(419, 155)
        Me.btnaddtimenamestudy.Name = "btnaddtimenamestudy"
        Me.btnaddtimenamestudy.Size = New System.Drawing.Size(31, 35)
        Me.btnaddtimenamestudy.TabIndex = 3
        Me.btnaddtimenamestudy.Text = "+"
        Me.btnaddtimenamestudy.UseVisualStyleBackColor = False
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.White
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.ForeColor = System.Drawing.Color.Lime
        Me.Button1.Location = New System.Drawing.Point(895, 105)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(31, 35)
        Me.Button1.TabIndex = 73
        Me.Button1.Text = "+"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'cbosubject
        '
        Me.cbosubject.Font = New System.Drawing.Font("Khmer Kep", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbosubject.Items.AddRange(New Object() {"ព្រឹក", "រសៀល", "ល្ងាច"})
        Me.cbosubject.Location = New System.Drawing.Point(646, 107)
        Me.cbosubject.Name = "cbosubject"
        Me.cbosubject.Size = New System.Drawing.Size(247, 32)
        Me.cbosubject.TabIndex = 72
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Khmer Kep", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Blue
        Me.Label2.Location = New System.Drawing.Point(507, 106)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(93, 33)
        Me.Label2.TabIndex = 74
        Me.Label2.Text = "មុខវិជ្ជាសិក្សា"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Khmer Kep", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Blue
        Me.Label3.Location = New System.Drawing.Point(507, 154)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(119, 33)
        Me.Label3.TabIndex = 75
        Me.Label3.Text = "ថ្ងៃចាប់ផ្តើមសិក្សា"
        '
        'dtpstartdate
        '
        Me.dtpstartdate.CustomFormat = "dd-mmmm-YYYY"
        Me.dtpstartdate.Font = New System.Drawing.Font("Times New Roman", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpstartdate.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpstartdate.Location = New System.Drawing.Point(646, 161)
        Me.dtpstartdate.Name = "dtpstartdate"
        Me.dtpstartdate.Size = New System.Drawing.Size(247, 29)
        Me.dtpstartdate.TabIndex = 76
        '
        'FrmSchedule
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(964, 602)
        Me.Controls.Add(Me.dtpstartdate)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.cbosubject)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.btnaddtimenamestudy)
        Me.Controls.Add(Me.btnaddtimestudy)
        Me.Controls.Add(Me.tbnadddaystudy)
        Me.Controls.Add(Me.cbotimeid)
        Me.Controls.Add(Me.cbodayid)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.cbotimenameid)
        Me.Controls.Add(Me.txtdesc)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.btndelete)
        Me.Controls.Add(Me.btnclose)
        Me.Controls.Add(Me.btnmodify)
        Me.Controls.Add(Me.btnclear)
        Me.Controls.Add(Me.btnadd)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.dgvschedule)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.txtid)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label10)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "FrmSchedule"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "ប្រព័ន្ធគ្រប់គ្រងទិន្នន័យសិស្ស និង បុគ្គលិក"
        CType(Me.dgvschedule, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents cbotimenameid As ComboBox
    Friend WithEvents txtdesc As TextBox
    Friend WithEvents Label11 As Label
    Friend WithEvents btndelete As Button
    Friend WithEvents btnclose As Button
    Friend WithEvents btnmodify As Button
    Friend WithEvents btnclear As Button
    Friend WithEvents btnadd As Button
    Friend WithEvents Label5 As Label
    Friend WithEvents dgvschedule As DataGridView
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents txtid As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents cbodayid As ComboBox
    Friend WithEvents Label1 As Label
    Friend WithEvents cbotimeid As ComboBox
    Friend WithEvents tbnadddaystudy As Button
    Friend WithEvents btnaddtimestudy As Button
    Friend WithEvents btnaddtimenamestudy As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents cbosubject As ComboBox
    Friend WithEvents Label2 As Label
    Friend WithEvents DataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As DataGridViewTextBoxColumn
    Friend WithEvents Desc As DataGridViewTextBoxColumn
    Friend WithEvents subject As DataGridViewTextBoxColumn
    Friend WithEvents Column1 As DataGridViewTextBoxColumn
    Friend WithEvents Descs As DataGridViewTextBoxColumn
    Friend WithEvents Label3 As Label
    Friend WithEvents dtpstartdate As DateTimePicker
End Class

<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmDeleteAndRestoreDataEmployee
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmDeleteAndRestoreDataEmployee))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtidcard = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txtid = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtname = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.txtnation = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.dgvdeleteemployee = New System.Windows.Forms.DataGridView()
        Me.Column12 = New System.Windows.Forms.DataGridViewImageColumn()
        Me.id = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.names = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column8 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column10 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column11 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column9 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.dtpstartwork = New System.Windows.Forms.DateTimePicker()
        Me.dtpstopwork = New System.Windows.Forms.DateTimePicker()
        Me.dtpdob = New System.Windows.Forms.DateTimePicker()
        Me.cbogender = New System.Windows.Forms.ComboBox()
        Me.Button6 = New System.Windows.Forms.Button()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        CType(Me.dgvdeleteemployee, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Khmer Wat Phnom", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Red
        Me.Label1.Location = New System.Drawing.Point(319, 18)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(442, 56)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Restore  និង លុបទិន្នន័យបុគ្គលិកជាអចិន្ត្រៃ"
        '
        'txtidcard
        '
        Me.txtidcard.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtidcard.Font = New System.Drawing.Font("Khmer Kep", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtidcard.Location = New System.Drawing.Point(221, 158)
        Me.txtidcard.Name = "txtidcard"
        Me.txtidcard.ReadOnly = True
        Me.txtidcard.Size = New System.Drawing.Size(247, 32)
        Me.txtidcard.TabIndex = 122
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Khmer Kep", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.Blue
        Me.Label8.Location = New System.Drawing.Point(57, 202)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(119, 33)
        Me.Label8.TabIndex = 121
        Me.Label8.Text = "ឈ្មោះជាអក្សរខ្មែរ"
        '
        'txtid
        '
        Me.txtid.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtid.Font = New System.Drawing.Font("Khmer Kep", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtid.Location = New System.Drawing.Point(221, 114)
        Me.txtid.Name = "txtid"
        Me.txtid.ReadOnly = True
        Me.txtid.Size = New System.Drawing.Size(247, 32)
        Me.txtid.TabIndex = 120
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Khmer Kep", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.Blue
        Me.Label9.Location = New System.Drawing.Point(57, 111)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(65, 33)
        Me.Label9.TabIndex = 119
        Me.Label9.Text = "អត្តលេខ"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Khmer Kep", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Blue
        Me.Label2.Location = New System.Drawing.Point(57, 155)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(152, 33)
        Me.Label2.TabIndex = 121
        Me.Label2.Text = "លេខអត្តសញ្ញាណប័ណ្ណ"
        '
        'txtname
        '
        Me.txtname.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtname.Font = New System.Drawing.Font("Khmer Kep", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtname.Location = New System.Drawing.Point(221, 205)
        Me.txtname.Name = "txtname"
        Me.txtname.ReadOnly = True
        Me.txtname.Size = New System.Drawing.Size(247, 32)
        Me.txtname.TabIndex = 122
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Khmer Kep", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Blue
        Me.Label3.Location = New System.Drawing.Point(512, 155)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(39, 33)
        Me.Label3.TabIndex = 123
        Me.Label3.Text = "ភេទ"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Khmer Kep", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Blue
        Me.Label4.Location = New System.Drawing.Point(57, 250)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(92, 33)
        Me.Label4.TabIndex = 125
        Me.Label4.Text = "ថ្ងៃចូលធ្វើការ"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Khmer Kep", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.Blue
        Me.Label5.Location = New System.Drawing.Point(512, 250)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(97, 33)
        Me.Label5.TabIndex = 127
        Me.Label5.Text = "ថ្ងៃឈប់ធ្វើការ"
        '
        'PictureBox1
        '
        Me.PictureBox1.Location = New System.Drawing.Point(3, 3)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(133, 185)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'Panel1
        '
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.PictureBox1)
        Me.Panel1.Location = New System.Drawing.Point(951, 96)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(139, 191)
        Me.Panel1.TabIndex = 136
        '
        'txtnation
        '
        Me.txtnation.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtnation.Font = New System.Drawing.Font("Khmer Kep", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtnation.Location = New System.Drawing.Point(642, 114)
        Me.txtnation.Name = "txtnation"
        Me.txtnation.ReadOnly = True
        Me.txtnation.Size = New System.Drawing.Size(247, 32)
        Me.txtnation.TabIndex = 140
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Khmer Kep", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.Blue
        Me.Label7.Location = New System.Drawing.Point(512, 206)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(106, 33)
        Me.Label7.TabIndex = 139
        Me.Label7.Text = "ថ្ងៃខែឆ្នាំកំណើត"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Khmer Kep", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.Color.Blue
        Me.Label10.Location = New System.Drawing.Point(512, 111)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(61, 33)
        Me.Label10.TabIndex = 139
        Me.Label10.Text = "សញ្ជាតិ"
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.White
        Me.Button1.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.ForeColor = System.Drawing.Color.Lime
        Me.Button1.Location = New System.Drawing.Point(661, 563)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(97, 35)
        Me.Button1.TabIndex = 144
        Me.Button1.Text = "RESTORE"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.White
        Me.Button2.Font = New System.Drawing.Font("Khmer Kep", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.ForeColor = System.Drawing.Color.Red
        Me.Button2.Location = New System.Drawing.Point(789, 563)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(100, 35)
        Me.Button2.TabIndex = 145
        Me.Button2.Text = "លុប"
        Me.Button2.UseVisualStyleBackColor = False
        '
        'Button3
        '
        Me.Button3.BackColor = System.Drawing.Color.White
        Me.Button3.Font = New System.Drawing.Font("Khmer Kep", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button3.ForeColor = System.Drawing.Color.Red
        Me.Button3.Location = New System.Drawing.Point(1040, 563)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(103, 35)
        Me.Button3.TabIndex = 146
        Me.Button3.Text = "បិទ"
        Me.Button3.UseVisualStyleBackColor = False
        '
        'dgvdeleteemployee
        '
        Me.dgvdeleteemployee.AllowUserToAddRows = False
        Me.dgvdeleteemployee.AllowUserToDeleteRows = False
        Me.dgvdeleteemployee.AllowUserToResizeRows = False
        Me.dgvdeleteemployee.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.ColumnHeader
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Khmer Kep", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvdeleteemployee.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.dgvdeleteemployee.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvdeleteemployee.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column12, Me.id, Me.names, Me.Column6, Me.Column2, Me.Column1, Me.Column3, Me.Column4, Me.Column5, Me.Column7, Me.Column8, Me.Column10, Me.Column11, Me.Column9})
        Me.dgvdeleteemployee.Location = New System.Drawing.Point(28, 306)
        Me.dgvdeleteemployee.Name = "dgvdeleteemployee"
        Me.dgvdeleteemployee.ReadOnly = True
        Me.dgvdeleteemployee.RowHeadersVisible = False
        Me.dgvdeleteemployee.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvdeleteemployee.Size = New System.Drawing.Size(1115, 236)
        Me.dgvdeleteemployee.TabIndex = 177
        '
        'Column12
        '
        Me.Column12.HeaderText = "រូបភាព"
        Me.Column12.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Stretch
        Me.Column12.Name = "Column12"
        Me.Column12.ReadOnly = True
        Me.Column12.Width = 52
        '
        'id
        '
        Me.id.HeaderText = "អត្តលេខ"
        Me.id.Name = "id"
        Me.id.ReadOnly = True
        Me.id.Width = 78
        '
        'names
        '
        Me.names.HeaderText = "លេខអត្តសញ្ញាណប័ណ្ណ"
        Me.names.Name = "names"
        Me.names.ReadOnly = True
        Me.names.Width = 147
        '
        'Column6
        '
        Me.Column6.HeaderText = "ឈ្មោះបុគ្គលិក"
        Me.Column6.Name = "Column6"
        Me.Column6.ReadOnly = True
        Me.Column6.Width = 103
        '
        'Column2
        '
        Me.Column2.HeaderText = "សញ្ជាតិ"
        Me.Column2.Name = "Column2"
        Me.Column2.ReadOnly = True
        Me.Column2.Width = 74
        '
        'Column1
        '
        Me.Column1.HeaderText = "ភេទ"
        Me.Column1.Name = "Column1"
        Me.Column1.ReadOnly = True
        Me.Column1.Width = 57
        '
        'Column3
        '
        Me.Column3.HeaderText = "ថ្ងៃខែឆ្នាំកំណើត"
        Me.Column3.Name = "Column3"
        Me.Column3.ReadOnly = True
        Me.Column3.Width = 110
        '
        'Column4
        '
        Me.Column4.HeaderText = "លេខទូរស័ព្ទ"
        Me.Column4.Name = "Column4"
        Me.Column4.ReadOnly = True
        Me.Column4.Width = 93
        '
        'Column5
        '
        Me.Column5.HeaderText = "អ៊ីម៉ែល"
        Me.Column5.Name = "Column5"
        Me.Column5.ReadOnly = True
        Me.Column5.Width = 71
        '
        'Column7
        '
        Me.Column7.HeaderText = "ថ្ងៃចាប់ផ្តើមធ្វើការ"
        Me.Column7.Name = "Column7"
        Me.Column7.ReadOnly = True
        Me.Column7.Width = 122
        '
        'Column8
        '
        Me.Column8.HeaderText = "ថ្ងៃឈប់ធ្វើការ"
        Me.Column8.Name = "Column8"
        Me.Column8.ReadOnly = True
        Me.Column8.Width = 104
        '
        'Column10
        '
        Me.Column10.HeaderText = "លិខិតបញ្ជាក់បទពិសោធន៍ការងារ"
        Me.Column10.Name = "Column10"
        Me.Column10.ReadOnly = True
        Me.Column10.Width = 192
        '
        'Column11
        '
        Me.Column11.HeaderText = "ថ្ងៃទទូល"
        Me.Column11.Name = "Column11"
        Me.Column11.ReadOnly = True
        Me.Column11.Width = 78
        '
        'Column9
        '
        Me.Column9.HeaderText = "សេចក្តីអធិប្បាយ"
        Me.Column9.Name = "Column9"
        Me.Column9.ReadOnly = True
        Me.Column9.Width = 115
        '
        'dtpstartwork
        '
        Me.dtpstartwork.CalendarForeColor = System.Drawing.Color.Black
        Me.dtpstartwork.CalendarMonthBackground = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.dtpstartwork.CustomFormat = "dd-mmmm-YYYY"
        Me.dtpstartwork.Font = New System.Drawing.Font("Times New Roman", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpstartwork.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpstartwork.Location = New System.Drawing.Point(221, 250)
        Me.dtpstartwork.Name = "dtpstartwork"
        Me.dtpstartwork.Size = New System.Drawing.Size(247, 29)
        Me.dtpstartwork.TabIndex = 183
        '
        'dtpstopwork
        '
        Me.dtpstopwork.CalendarForeColor = System.Drawing.Color.Black
        Me.dtpstopwork.CalendarMonthBackground = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.dtpstopwork.CustomFormat = "dd-mmmm-YYYY"
        Me.dtpstopwork.Font = New System.Drawing.Font("Times New Roman", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpstopwork.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpstopwork.Location = New System.Drawing.Point(642, 250)
        Me.dtpstopwork.Name = "dtpstopwork"
        Me.dtpstopwork.Size = New System.Drawing.Size(247, 29)
        Me.dtpstopwork.TabIndex = 184
        '
        'dtpdob
        '
        Me.dtpdob.CalendarForeColor = System.Drawing.Color.Black
        Me.dtpdob.CalendarMonthBackground = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.dtpdob.CustomFormat = "dd-mmmm-YYYY"
        Me.dtpdob.Font = New System.Drawing.Font("Times New Roman", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpdob.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpdob.Location = New System.Drawing.Point(642, 208)
        Me.dtpdob.Name = "dtpdob"
        Me.dtpdob.Size = New System.Drawing.Size(247, 29)
        Me.dtpdob.TabIndex = 185
        '
        'cbogender
        '
        Me.cbogender.Font = New System.Drawing.Font("Khmer Kep", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbogender.FormattingEnabled = True
        Me.cbogender.Items.AddRange(New Object() {"ប្រុស", "ស្រី"})
        Me.cbogender.Location = New System.Drawing.Point(642, 156)
        Me.cbogender.Name = "cbogender"
        Me.cbogender.Size = New System.Drawing.Size(247, 32)
        Me.cbogender.TabIndex = 186
        '
        'Button6
        '
        Me.Button6.BackColor = System.Drawing.Color.White
        Me.Button6.Font = New System.Drawing.Font("Khmer Kep", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button6.ForeColor = System.Drawing.Color.Aqua
        Me.Button6.Location = New System.Drawing.Point(918, 563)
        Me.Button6.Name = "Button6"
        Me.Button6.Size = New System.Drawing.Size(100, 35)
        Me.Button6.TabIndex = 187
        Me.Button6.Text = "ជម្រះ"
        Me.Button6.UseVisualStyleBackColor = False
        '
        'FrmDeleteAndRestoreDataEmployee
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1167, 613)
        Me.Controls.Add(Me.Button6)
        Me.Controls.Add(Me.cbogender)
        Me.Controls.Add(Me.dtpdob)
        Me.Controls.Add(Me.dtpstopwork)
        Me.Controls.Add(Me.dtpstartwork)
        Me.Controls.Add(Me.dgvdeleteemployee)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.txtnation)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txtname)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtidcard)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.txtid)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "FrmDeleteAndRestoreDataEmployee"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "ប្រព័ន្ធគ្រប់គ្រងទិន្នន័យសិស្ស និង បុគ្គលិក"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        CType(Me.dgvdeleteemployee, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents txtidcard As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents txtid As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents txtname As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Panel1 As Panel
    Friend WithEvents txtnation As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents dgvdeleteemployee As DataGridView
    Friend WithEvents Column12 As DataGridViewImageColumn
    Friend WithEvents id As DataGridViewTextBoxColumn
    Friend WithEvents names As DataGridViewTextBoxColumn
    Friend WithEvents Column6 As DataGridViewTextBoxColumn
    Friend WithEvents Column2 As DataGridViewTextBoxColumn
    Friend WithEvents Column1 As DataGridViewTextBoxColumn
    Friend WithEvents Column3 As DataGridViewTextBoxColumn
    Friend WithEvents Column4 As DataGridViewTextBoxColumn
    Friend WithEvents Column5 As DataGridViewTextBoxColumn
    Friend WithEvents Column7 As DataGridViewTextBoxColumn
    Friend WithEvents Column8 As DataGridViewTextBoxColumn
    Friend WithEvents Column10 As DataGridViewTextBoxColumn
    Friend WithEvents Column11 As DataGridViewTextBoxColumn
    Friend WithEvents Column9 As DataGridViewTextBoxColumn
    Friend WithEvents dtpstartwork As DateTimePicker
    Friend WithEvents dtpstopwork As DateTimePicker
    Friend WithEvents dtpdob As DateTimePicker
    Friend WithEvents cbogender As ComboBox
    Friend WithEvents Button6 As Button
End Class

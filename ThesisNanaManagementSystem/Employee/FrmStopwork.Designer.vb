<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FrmStopwork
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmStopwork))
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.dtpdategetcertificate = New System.Windows.Forms.DateTimePicker()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtgender = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtnation = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtname = New System.Windows.Forms.TextBox()
        Me.lbstudentname = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.dgvstopwork = New System.Windows.Forms.DataGridView()
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
        Me.txtid = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.dtpstartwork = New System.Windows.Forms.DateTimePicker()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.cbocertificate = New System.Windows.Forms.ComboBox()
        Me.txtidcard = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txtdesc = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.dtpstopwork = New System.Windows.Forms.DateTimePicker()
        Me.txtsearch = New System.Windows.Forms.TextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.cboshowdata = New System.Windows.Forms.ComboBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.pimage = New System.Windows.Forms.PictureBox()
        CType(Me.dgvstopwork, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        CType(Me.pimage, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Button3
        '
        Me.Button3.BackColor = System.Drawing.Color.White
        Me.Button3.Font = New System.Drawing.Font("Khmer Kep", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button3.ForeColor = System.Drawing.Color.Navy
        Me.Button3.Location = New System.Drawing.Point(965, 643)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(111, 35)
        Me.Button3.TabIndex = 180
        Me.Button3.Text = "ជម្រះ"
        Me.Button3.UseVisualStyleBackColor = False
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.White
        Me.Button2.Font = New System.Drawing.Font("Khmer Kep", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.ForeColor = System.Drawing.Color.Red
        Me.Button2.Location = New System.Drawing.Point(1103, 643)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(111, 35)
        Me.Button2.TabIndex = 179
        Me.Button2.Text = "បិទ"
        Me.Button2.UseVisualStyleBackColor = False
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.White
        Me.Button1.Font = New System.Drawing.Font("Khmer Kep", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.ForeColor = System.Drawing.Color.Lime
        Me.Button1.Location = New System.Drawing.Point(659, 643)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(111, 35)
        Me.Button1.TabIndex = 178
        Me.Button1.Text = "រក្សាទុក"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'dtpdategetcertificate
        '
        Me.dtpdategetcertificate.CustomFormat = "dd-mmmm-YYYY"
        Me.dtpdategetcertificate.Font = New System.Drawing.Font("Times New Roman", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpdategetcertificate.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpdategetcertificate.Location = New System.Drawing.Point(688, 218)
        Me.dtpdategetcertificate.Name = "dtpdategetcertificate"
        Me.dtpdategetcertificate.Size = New System.Drawing.Size(247, 29)
        Me.dtpdategetcertificate.TabIndex = 174
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Khmer Kep", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.Blue
        Me.Label9.Location = New System.Drawing.Point(549, 146)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(112, 33)
        Me.Label9.TabIndex = 175
        Me.Label9.Text = "លិខិតបញ្ជាក់បទ"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Khmer Kep", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.Blue
        Me.Label6.Location = New System.Drawing.Point(549, 216)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(66, 33)
        Me.Label6.TabIndex = 173
        Me.Label6.Text = "ថ្ងៃទទួល"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Khmer Kep", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Blue
        Me.Label2.Location = New System.Drawing.Point(549, 102)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(114, 33)
        Me.Label2.TabIndex = 171
        Me.Label2.Text = "ថ្ងៃឈប់ពីការងារ"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Khmer Kep", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.Blue
        Me.Label5.Location = New System.Drawing.Point(549, 50)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(120, 33)
        Me.Label5.TabIndex = 169
        Me.Label5.Text = "ថ្ងៃចាប់ផ្តើមធ្វើការ"
        '
        'txtgender
        '
        Me.txtgender.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtgender.Font = New System.Drawing.Font("Khmer Kep", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtgender.Location = New System.Drawing.Point(224, 267)
        Me.txtgender.Name = "txtgender"
        Me.txtgender.ReadOnly = True
        Me.txtgender.Size = New System.Drawing.Size(247, 32)
        Me.txtgender.TabIndex = 166
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Khmer Kep", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Blue
        Me.Label4.Location = New System.Drawing.Point(85, 264)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(39, 33)
        Me.Label4.TabIndex = 167
        Me.Label4.Text = "ភេទ"
        '
        'txtnation
        '
        Me.txtnation.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtnation.Font = New System.Drawing.Font("Khmer Kep", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtnation.Location = New System.Drawing.Point(224, 212)
        Me.txtnation.Name = "txtnation"
        Me.txtnation.ReadOnly = True
        Me.txtnation.Size = New System.Drawing.Size(247, 32)
        Me.txtnation.TabIndex = 164
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Khmer Kep", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Blue
        Me.Label3.Location = New System.Drawing.Point(85, 209)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(61, 33)
        Me.Label3.TabIndex = 165
        Me.Label3.Text = "សញ្ជាតិ"
        '
        'txtname
        '
        Me.txtname.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtname.Font = New System.Drawing.Font("Khmer Kep", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtname.Location = New System.Drawing.Point(224, 158)
        Me.txtname.Name = "txtname"
        Me.txtname.ReadOnly = True
        Me.txtname.Size = New System.Drawing.Size(247, 32)
        Me.txtname.TabIndex = 162
        '
        'lbstudentname
        '
        Me.lbstudentname.AutoSize = True
        Me.lbstudentname.Font = New System.Drawing.Font("Khmer Kep", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbstudentname.ForeColor = System.Drawing.Color.Blue
        Me.lbstudentname.Location = New System.Drawing.Point(85, 155)
        Me.lbstudentname.Name = "lbstudentname"
        Me.lbstudentname.Size = New System.Drawing.Size(97, 33)
        Me.lbstudentname.TabIndex = 163
        Me.lbstudentname.Text = "ឈ្មោះបុគ្គលិក"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Khmer Kep", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.ForeColor = System.Drawing.Color.Blue
        Me.Label11.Location = New System.Drawing.Point(85, 49)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(65, 33)
        Me.Label11.TabIndex = 161
        Me.Label11.Text = "អត្តលេខ"
        '
        'dgvstopwork
        '
        Me.dgvstopwork.AllowUserToAddRows = False
        Me.dgvstopwork.AllowUserToDeleteRows = False
        Me.dgvstopwork.AllowUserToResizeRows = False
        Me.dgvstopwork.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.ColumnHeader
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Khmer Kep", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvstopwork.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.dgvstopwork.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvstopwork.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column12, Me.id, Me.names, Me.Column6, Me.Column2, Me.Column1, Me.Column3, Me.Column4, Me.Column5, Me.Column7, Me.Column8, Me.Column10, Me.Column11, Me.Column9})
        Me.dgvstopwork.Location = New System.Drawing.Point(26, 371)
        Me.dgvstopwork.Name = "dgvstopwork"
        Me.dgvstopwork.ReadOnly = True
        Me.dgvstopwork.RowHeadersVisible = False
        Me.dgvstopwork.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvstopwork.Size = New System.Drawing.Size(1173, 253)
        Me.dgvstopwork.TabIndex = 176
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
        'txtid
        '
        Me.txtid.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtid.Font = New System.Drawing.Font("Khmer Kep", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtid.Location = New System.Drawing.Point(224, 52)
        Me.txtid.Name = "txtid"
        Me.txtid.ReadOnly = True
        Me.txtid.Size = New System.Drawing.Size(247, 32)
        Me.txtid.TabIndex = 160
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Khmer Wat Phnom", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Red
        Me.Label1.Location = New System.Drawing.Point(484, -8)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(272, 56)
        Me.Label1.TabIndex = 159
        Me.Label1.Text = "ទិន្នន័យបុគ្គលិកឈប់ធ្វើការ"
        '
        'Panel1
        '
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.pimage)
        Me.Panel1.Location = New System.Drawing.Point(987, 57)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(161, 220)
        Me.Panel1.TabIndex = 177
        '
        'dtpstartwork
        '
        Me.dtpstartwork.CalendarForeColor = System.Drawing.Color.Black
        Me.dtpstartwork.CalendarMonthBackground = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.dtpstartwork.CustomFormat = "dd-mmmm-YYYY"
        Me.dtpstartwork.Font = New System.Drawing.Font("Times New Roman", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpstartwork.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpstartwork.Location = New System.Drawing.Point(688, 56)
        Me.dtpstartwork.Name = "dtpstartwork"
        Me.dtpstartwork.Size = New System.Drawing.Size(247, 29)
        Me.dtpstartwork.TabIndex = 182
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Khmer Kep", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.Blue
        Me.Label7.Location = New System.Drawing.Point(549, 173)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(112, 33)
        Me.Label7.TabIndex = 183
        Me.Label7.Text = "ពិសោធន៍ការងារ"
        '
        'cbocertificate
        '
        Me.cbocertificate.Font = New System.Drawing.Font("Khmer Kep", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbocertificate.FormattingEnabled = True
        Me.cbocertificate.Items.AddRange(New Object() {"បានទទួល", "មិនបានទទួល"})
        Me.cbocertificate.Location = New System.Drawing.Point(688, 160)
        Me.cbocertificate.Name = "cbocertificate"
        Me.cbocertificate.Size = New System.Drawing.Size(247, 32)
        Me.cbocertificate.TabIndex = 184
        '
        'txtidcard
        '
        Me.txtidcard.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtidcard.Font = New System.Drawing.Font("Khmer Kep", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtidcard.Location = New System.Drawing.Point(224, 105)
        Me.txtidcard.Name = "txtidcard"
        Me.txtidcard.ReadOnly = True
        Me.txtidcard.Size = New System.Drawing.Size(247, 32)
        Me.txtidcard.TabIndex = 185
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Khmer Kep", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.Blue
        Me.Label8.Location = New System.Drawing.Point(85, 102)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(132, 33)
        Me.Label8.TabIndex = 186
        Me.Label8.Text = "លេខអត្តសញ្ញាប័ណ្ណ"
        '
        'txtdesc
        '
        Me.txtdesc.Font = New System.Drawing.Font("Khmer Kep", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtdesc.Location = New System.Drawing.Point(688, 267)
        Me.txtdesc.Name = "txtdesc"
        Me.txtdesc.Size = New System.Drawing.Size(247, 32)
        Me.txtdesc.TabIndex = 187
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Khmer Kep", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.Color.Blue
        Me.Label10.Location = New System.Drawing.Point(549, 264)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(112, 33)
        Me.Label10.TabIndex = 188
        Me.Label10.Text = "សេចក្តីអធិ​ប្បាយ"
        '
        'dtpstopwork
        '
        Me.dtpstopwork.CustomFormat = "dd-mmmm-YYYY"
        Me.dtpstopwork.Font = New System.Drawing.Font("Times New Roman", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpstopwork.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpstopwork.Location = New System.Drawing.Point(688, 109)
        Me.dtpstopwork.Name = "dtpstopwork"
        Me.dtpstopwork.Size = New System.Drawing.Size(247, 29)
        Me.dtpstopwork.TabIndex = 189
        '
        'txtsearch
        '
        Me.txtsearch.Font = New System.Drawing.Font("Khmer Kep", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtsearch.Location = New System.Drawing.Point(339, 324)
        Me.txtsearch.Name = "txtsearch"
        Me.txtsearch.Size = New System.Drawing.Size(247, 32)
        Me.txtsearch.TabIndex = 190
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Khmer Kep", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.ForeColor = System.Drawing.Color.Blue
        Me.Label12.Location = New System.Drawing.Point(157, 323)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(166, 33)
        Me.Label12.TabIndex = 191
        Me.Label12.Text = "ស្វែងរកទិន្នន័យតាមឈ្មោះ"
        '
        'cboshowdata
        '
        Me.cboshowdata.Font = New System.Drawing.Font("Khmer Kep", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboshowdata.FormattingEnabled = True
        Me.cboshowdata.Items.AddRange(New Object() {"បុគ្គលិកទាំងអស់", "បុគ្គលិកឈប់ធ្វើការ"})
        Me.cboshowdata.Location = New System.Drawing.Point(771, 324)
        Me.cboshowdata.Name = "cboshowdata"
        Me.cboshowdata.Size = New System.Drawing.Size(247, 32)
        Me.cboshowdata.TabIndex = 192
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Khmer Kep", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.ForeColor = System.Drawing.Color.Blue
        Me.Label13.Location = New System.Drawing.Point(655, 323)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(99, 33)
        Me.Label13.TabIndex = 193
        Me.Label13.Text = "បង្ហាញទិន្នន័យ"
        '
        'Button5
        '
        Me.Button5.BackColor = System.Drawing.Color.White
        Me.Button5.Font = New System.Drawing.Font("Khmer Kep", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button5.ForeColor = System.Drawing.Color.Blue
        Me.Button5.Location = New System.Drawing.Point(799, 643)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(140, 35)
        Me.Button5.TabIndex = 195
        Me.Button5.Text = "Export Data to Excel"
        Me.Button5.UseVisualStyleBackColor = False
        '
        'pimage
        '
        Me.pimage.Location = New System.Drawing.Point(2, 3)
        Me.pimage.Name = "pimage"
        Me.pimage.Size = New System.Drawing.Size(154, 212)
        Me.pimage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pimage.TabIndex = 0
        Me.pimage.TabStop = False
        '
        'FrmStopwork
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1226, 693)
        Me.Controls.Add(Me.Button5)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.cboshowdata)
        Me.Controls.Add(Me.txtsearch)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.dtpstopwork)
        Me.Controls.Add(Me.txtdesc)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.txtidcard)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.cbocertificate)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.dtpstartwork)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.dtpdategetcertificate)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.txtgender)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.txtnation)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txtname)
        Me.Controls.Add(Me.lbstudentname)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.dgvstopwork)
        Me.Controls.Add(Me.txtid)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Panel1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "FrmStopwork"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "ប្រព័ន្ធគ្រប់គ្រងទិន្នន័យសិស្ស និង បុគ្គលិក"
        CType(Me.dgvstopwork, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        CType(Me.pimage, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Button3 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents dtpdategetcertificate As DateTimePicker
    Friend WithEvents Label9 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents txtgender As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents txtnation As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents txtname As TextBox
    Friend WithEvents lbstudentname As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents dgvstopwork As DataGridView
    Friend WithEvents txtid As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents pimage As PictureBox
    Friend WithEvents Panel1 As Panel
    Friend WithEvents dtpstartwork As DateTimePicker
    Friend WithEvents Label7 As Label
    Friend WithEvents cbocertificate As ComboBox
    Friend WithEvents txtidcard As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents txtdesc As TextBox
    Friend WithEvents Label10 As Label
    Friend WithEvents dtpstopwork As DateTimePicker
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
    Friend WithEvents txtsearch As TextBox
    Friend WithEvents Label12 As Label
    Friend WithEvents cboshowdata As ComboBox
    Friend WithEvents Label13 As Label
    Friend WithEvents Button5 As Button
End Class

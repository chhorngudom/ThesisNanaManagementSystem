﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmAllstudent
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmAllstudent))
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.ComboBox5 = New System.Windows.Forms.ComboBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.ComboBox4 = New System.Windows.Forms.ComboBox()
        Me.cbosubjectaddstudent = New System.Windows.Forms.ComboBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtsearchmanagedatastudent = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.ComboBox6 = New System.Windows.Forms.ComboBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.dgvmanagedatastudent = New System.Windows.Forms.DataGridView()
        Me.Column18 = New System.Windows.Forms.DataGridViewImageColumn()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.លេខអត្តសញ្ញាណប័ណ្ណ = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column19 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column20 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column8 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column21 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column11 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column12 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column13 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column9 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column10 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column14 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.GroupBox1.SuspendLayout()
        CType(Me.dgvmanagedatastudent, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Khmer Wat Phnom", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Navy
        Me.Label2.Location = New System.Drawing.Point(600, 56)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(167, 44)
        Me.Label2.TabIndex = 138
        Me.Label2.Text = "ស្វែងរកទិន្នន័យតាម"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Khmer Wat Phnom", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Red
        Me.Label1.Location = New System.Drawing.Point(563, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(227, 56)
        Me.Label1.TabIndex = 137
        Me.Label1.Text = "ទិន្នន័យសិស្សទាំងអស់"
        '
        'ComboBox5
        '
        Me.ComboBox5.Font = New System.Drawing.Font("Khmer Kep", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ComboBox5.FormattingEnabled = True
        Me.ComboBox5.Location = New System.Drawing.Point(635, 165)
        Me.ComboBox5.Name = "ComboBox5"
        Me.ComboBox5.Size = New System.Drawing.Size(176, 32)
        Me.ComboBox5.TabIndex = 184
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Khmer Kep", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(512, 165)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(80, 33)
        Me.Label9.TabIndex = 183
        Me.Label9.Text = "ពេលសិក្សា"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Khmer Kep", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(30, 165)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(66, 33)
        Me.Label8.TabIndex = 181
        Me.Label8.Text = "ថ្ងៃសិក្សា"
        '
        'ComboBox4
        '
        Me.ComboBox4.Font = New System.Drawing.Font("Khmer Kep", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ComboBox4.FormattingEnabled = True
        Me.ComboBox4.Location = New System.Drawing.Point(109, 165)
        Me.ComboBox4.Name = "ComboBox4"
        Me.ComboBox4.Size = New System.Drawing.Size(197, 32)
        Me.ComboBox4.TabIndex = 182
        '
        'cbosubjectaddstudent
        '
        Me.cbosubjectaddstudent.Font = New System.Drawing.Font("Khmer Kep", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbosubjectaddstudent.FormattingEnabled = True
        Me.cbosubjectaddstudent.Location = New System.Drawing.Point(635, 114)
        Me.cbosubjectaddstudent.Name = "cbosubjectaddstudent"
        Me.cbosubjectaddstudent.Size = New System.Drawing.Size(176, 32)
        Me.cbosubjectaddstudent.TabIndex = 180
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Khmer Kep", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(512, 114)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(93, 33)
        Me.Label3.TabIndex = 179
        Me.Label3.Text = "មុខវិជ្ជាសិក្សា"
        '
        'txtsearchmanagedatastudent
        '
        Me.txtsearchmanagedatastudent.Font = New System.Drawing.Font("Khmer Kep", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtsearchmanagedatastudent.Location = New System.Drawing.Point(109, 115)
        Me.txtsearchmanagedatastudent.Name = "txtsearchmanagedatastudent"
        Me.txtsearchmanagedatastudent.Size = New System.Drawing.Size(197, 32)
        Me.txtsearchmanagedatastudent.TabIndex = 178
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Khmer Kep", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(30, 115)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(51, 33)
        Me.Label5.TabIndex = 177
        Me.Label5.Text = "ឈ្មោះ"
        '
        'ComboBox6
        '
        Me.ComboBox6.Font = New System.Drawing.Font("Khmer Kep", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ComboBox6.FormattingEnabled = True
        Me.ComboBox6.Location = New System.Drawing.Point(1148, 165)
        Me.ComboBox6.Name = "ComboBox6"
        Me.ComboBox6.Size = New System.Drawing.Size(176, 32)
        Me.ComboBox6.TabIndex = 187
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Khmer Kep", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(1016, 165)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(80, 33)
        Me.Label10.TabIndex = 186
        Me.Label10.Text = "ពេលសិក្សា"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.DateTimePicker1)
        Me.GroupBox1.Font = New System.Drawing.Font("Khmer Kep", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(1022, 78)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(302, 81)
        Me.GroupBox1.TabIndex = 185
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "ថ្ងៃខែចាប់ផ្តើមសិក្សា"
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.CustomFormat = "dd-mmmm-YYYY"
        Me.DateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DateTimePicker1.Location = New System.Drawing.Point(33, 29)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(243, 41)
        Me.DateTimePicker1.TabIndex = 0
        '
        'Button5
        '
        Me.Button5.BackColor = System.Drawing.Color.White
        Me.Button5.Font = New System.Drawing.Font("Khmer Kep", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button5.ForeColor = System.Drawing.Color.Cyan
        Me.Button5.Location = New System.Drawing.Point(1033, 607)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(140, 35)
        Me.Button5.TabIndex = 189
        Me.Button5.Text = "Export Data to Excel"
        Me.Button5.UseVisualStyleBackColor = False
        '
        'Button4
        '
        Me.Button4.BackColor = System.Drawing.Color.White
        Me.Button4.Font = New System.Drawing.Font("Khmer Kep", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Button4.Location = New System.Drawing.Point(1213, 607)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(111, 35)
        Me.Button4.TabIndex = 188
        Me.Button4.Text = "REPORT"
        Me.Button4.UseVisualStyleBackColor = False
        '
        'dgvmanagedatastudent
        '
        Me.dgvmanagedatastudent.AllowUserToAddRows = False
        Me.dgvmanagedatastudent.AllowUserToDeleteRows = False
        Me.dgvmanagedatastudent.AllowUserToResizeRows = False
        Me.dgvmanagedatastudent.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.ColumnHeader
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Khmer Kep", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvmanagedatastudent.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.dgvmanagedatastudent.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvmanagedatastudent.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column18, Me.Column1, Me.លេខអត្តសញ្ញាណប័ណ្ណ, Me.Column3, Me.Column4, Me.Column2, Me.Column19, Me.Column5, Me.Column6, Me.Column20, Me.Column7, Me.Column8, Me.Column21, Me.Column11, Me.Column12, Me.Column13, Me.Column9, Me.Column10, Me.Column14})
        Me.dgvmanagedatastudent.Location = New System.Drawing.Point(23, 212)
        Me.dgvmanagedatastudent.Name = "dgvmanagedatastudent"
        Me.dgvmanagedatastudent.ReadOnly = True
        Me.dgvmanagedatastudent.RowHeadersVisible = False
        Me.dgvmanagedatastudent.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvmanagedatastudent.Size = New System.Drawing.Size(1301, 374)
        Me.dgvmanagedatastudent.TabIndex = 190
        '
        'Column18
        '
        Me.Column18.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        Me.Column18.HeaderText = "រូបភាព"
        Me.Column18.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Stretch
        Me.Column18.MinimumWidth = 50
        Me.Column18.Name = "Column18"
        Me.Column18.ReadOnly = True
        Me.Column18.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.Column18.Width = 50
        '
        'Column1
        '
        Me.Column1.HeaderText = "អត្តលេខសិស្ស"
        Me.Column1.Name = "Column1"
        Me.Column1.ReadOnly = True
        Me.Column1.Width = 106
        '
        'លេខអត្តសញ្ញាណប័ណ្ណ
        '
        Me.លេខអត្តសញ្ញាណប័ណ្ណ.HeaderText = "លេខអត្តសញ្ញាណប័ណ្ណ"
        Me.លេខអត្តសញ្ញាណប័ណ្ណ.Name = "លេខអត្តសញ្ញាណប័ណ្ណ"
        Me.លេខអត្តសញ្ញាណប័ណ្ណ.ReadOnly = True
        Me.លេខអត្តសញ្ញាណប័ណ្ណ.Width = 147
        '
        'Column3
        '
        Me.Column3.HeaderText = "ឈ្មោះសិស្សជាអក្សរខ្មែរ"
        Me.Column3.Name = "Column3"
        Me.Column3.ReadOnly = True
        Me.Column3.Width = 149
        '
        'Column4
        '
        Me.Column4.HeaderText = "ឈ្មោះជាអក្សរឡាតាំង"
        Me.Column4.Name = "Column4"
        Me.Column4.ReadOnly = True
        Me.Column4.Width = 140
        '
        'Column2
        '
        Me.Column2.HeaderText = "ជាតិ"
        Me.Column2.Name = "Column2"
        Me.Column2.ReadOnly = True
        Me.Column2.Width = 59
        '
        'Column19
        '
        Me.Column19.HeaderText = "សញ្ជាតិ"
        Me.Column19.Name = "Column19"
        Me.Column19.ReadOnly = True
        Me.Column19.Width = 74
        '
        'Column5
        '
        Me.Column5.HeaderText = "ភេទ"
        Me.Column5.Name = "Column5"
        Me.Column5.ReadOnly = True
        Me.Column5.Width = 57
        '
        'Column6
        '
        Me.Column6.HeaderText = "ថ្ងៃខែឆ្នាំកំណើត"
        Me.Column6.Name = "Column6"
        Me.Column6.ReadOnly = True
        Me.Column6.Width = 110
        '
        'Column20
        '
        Me.Column20.HeaderText = "ទីកន្លែងកំណើត"
        Me.Column20.Name = "Column20"
        Me.Column20.ReadOnly = True
        Me.Column20.Width = 109
        '
        'Column7
        '
        Me.Column7.HeaderText = "លេខទូរស័ព្ទ"
        Me.Column7.Name = "Column7"
        Me.Column7.ReadOnly = True
        Me.Column7.Width = 93
        '
        'Column8
        '
        Me.Column8.HeaderText = "អ៊ីមែល"
        Me.Column8.Name = "Column8"
        Me.Column8.ReadOnly = True
        Me.Column8.Width = 71
        '
        'Column21
        '
        Me.Column21.HeaderText = "អាស័យដ្ឋានបច្ចុប្បន្ន"
        Me.Column21.Name = "Column21"
        Me.Column21.ReadOnly = True
        Me.Column21.Width = 129
        '
        'Column11
        '
        Me.Column11.HeaderText = "ថ្ងៃសិក្សា"
        Me.Column11.Name = "Column11"
        Me.Column11.ReadOnly = True
        Me.Column11.Width = 78
        '
        'Column12
        '
        Me.Column12.HeaderText = "ពេលសិក្សា"
        Me.Column12.Name = "Column12"
        Me.Column12.ReadOnly = True
        Me.Column12.Width = 89
        '
        'Column13
        '
        Me.Column13.HeaderText = "ម៉ោងសិក្សា"
        Me.Column13.Name = "Column13"
        Me.Column13.ReadOnly = True
        Me.Column13.Width = 90
        '
        'Column9
        '
        Me.Column9.HeaderText = "ផ្នែកសិក្សា"
        Me.Column9.Name = "Column9"
        Me.Column9.ReadOnly = True
        Me.Column9.Width = 86
        '
        'Column10
        '
        Me.Column10.HeaderText = "មុខវិជ្ជា"
        Me.Column10.Name = "Column10"
        Me.Column10.ReadOnly = True
        Me.Column10.Width = 72
        '
        'Column14
        '
        Me.Column14.HeaderText = "ថ្ងៃចាប់ផ្តើមសិក្សា"
        Me.Column14.Name = "Column14"
        Me.Column14.ReadOnly = True
        Me.Column14.Width = 121
        '
        'FrmAllstudent
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1344, 657)
        Me.Controls.Add(Me.dgvmanagedatastudent)
        Me.Controls.Add(Me.Button5)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.ComboBox6)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.ComboBox5)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.ComboBox4)
        Me.Controls.Add(Me.cbosubjectaddstudent)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txtsearchmanagedatastudent)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "FrmAllstudent"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "ប្រព័ន្ធគ្រប់គ្រងទិន្នន័យសិស្ស និង បុគ្គលិក"
        Me.GroupBox1.ResumeLayout(False)
        CType(Me.dgvmanagedatastudent, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents ComboBox5 As ComboBox
    Friend WithEvents Label9 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents ComboBox4 As ComboBox
    Friend WithEvents cbosubjectaddstudent As ComboBox
    Friend WithEvents Label3 As Label
    Friend WithEvents txtsearchmanagedatastudent As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents ComboBox6 As ComboBox
    Friend WithEvents Label10 As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents DateTimePicker1 As DateTimePicker
    Friend WithEvents Button5 As Button
    Friend WithEvents Button4 As Button
    Friend WithEvents dgvmanagedatastudent As DataGridView
    Friend WithEvents Column18 As DataGridViewImageColumn
    Friend WithEvents Column1 As DataGridViewTextBoxColumn
    Friend WithEvents លេខអត្តសញ្ញាណប័ណ្ណ As DataGridViewTextBoxColumn
    Friend WithEvents Column3 As DataGridViewTextBoxColumn
    Friend WithEvents Column4 As DataGridViewTextBoxColumn
    Friend WithEvents Column2 As DataGridViewTextBoxColumn
    Friend WithEvents Column19 As DataGridViewTextBoxColumn
    Friend WithEvents Column5 As DataGridViewTextBoxColumn
    Friend WithEvents Column6 As DataGridViewTextBoxColumn
    Friend WithEvents Column20 As DataGridViewTextBoxColumn
    Friend WithEvents Column7 As DataGridViewTextBoxColumn
    Friend WithEvents Column8 As DataGridViewTextBoxColumn
    Friend WithEvents Column21 As DataGridViewTextBoxColumn
    Friend WithEvents Column11 As DataGridViewTextBoxColumn
    Friend WithEvents Column12 As DataGridViewTextBoxColumn
    Friend WithEvents Column13 As DataGridViewTextBoxColumn
    Friend WithEvents Column9 As DataGridViewTextBoxColumn
    Friend WithEvents Column10 As DataGridViewTextBoxColumn
    Friend WithEvents Column14 As DataGridViewTextBoxColumn
End Class

<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmSubject
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmSubject))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtdesc = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.btndelete = New System.Windows.Forms.Button()
        Me.btnclose = New System.Windows.Forms.Button()
        Me.btnupdate = New System.Windows.Forms.Button()
        Me.btnclear = New System.Windows.Forms.Button()
        Me.btnsave = New System.Windows.Forms.Button()
        Me.dgvsubject = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Desc = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Descr = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txtid = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.txtsubject = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.cbopartstudy = New System.Windows.Forms.ComboBox()
        Me.btnaddpartstudy = New System.Windows.Forms.Button()
        CType(Me.dgvsubject, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Khmer Kep", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Blue
        Me.Label1.Location = New System.Drawing.Point(37, 306)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(83, 33)
        Me.Label1.TabIndex = 102
        Me.Label1.Text = "បញ្ជីមុខវិជ្ជា"
        '
        'txtdesc
        '
        Me.txtdesc.Font = New System.Drawing.Font("Khmer Kep", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtdesc.Location = New System.Drawing.Point(263, 207)
        Me.txtdesc.Name = "txtdesc"
        Me.txtdesc.Size = New System.Drawing.Size(247, 32)
        Me.txtdesc.TabIndex = 3
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Khmer Kep", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.ForeColor = System.Drawing.Color.Blue
        Me.Label11.Location = New System.Drawing.Point(124, 204)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(112, 33)
        Me.Label11.TabIndex = 99
        Me.Label11.Text = "សេចក្តីអធិប្បាយ"
        '
        'btndelete
        '
        Me.btndelete.BackColor = System.Drawing.Color.White
        Me.btndelete.Font = New System.Drawing.Font("Khmer Kep", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btndelete.ForeColor = System.Drawing.Color.Lime
        Me.btndelete.Location = New System.Drawing.Point(456, 262)
        Me.btndelete.Name = "btndelete"
        Me.btndelete.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.btndelete.Size = New System.Drawing.Size(112, 33)
        Me.btndelete.TabIndex = 7
        Me.btndelete.Text = "លុប"
        Me.btndelete.UseVisualStyleBackColor = False
        '
        'btnclose
        '
        Me.btnclose.BackColor = System.Drawing.Color.White
        Me.btnclose.Font = New System.Drawing.Font("Khmer Kep", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnclose.ForeColor = System.Drawing.Color.Red
        Me.btnclose.Location = New System.Drawing.Point(592, 262)
        Me.btnclose.Name = "btnclose"
        Me.btnclose.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.btnclose.Size = New System.Drawing.Size(112, 33)
        Me.btnclose.TabIndex = 8
        Me.btnclose.Text = "បិទ"
        Me.btnclose.UseVisualStyleBackColor = False
        '
        'btnupdate
        '
        Me.btnupdate.BackColor = System.Drawing.Color.White
        Me.btnupdate.Font = New System.Drawing.Font("Khmer Kep", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnupdate.ForeColor = System.Drawing.Color.Lime
        Me.btnupdate.Location = New System.Drawing.Point(326, 262)
        Me.btnupdate.Name = "btnupdate"
        Me.btnupdate.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.btnupdate.Size = New System.Drawing.Size(112, 33)
        Me.btnupdate.TabIndex = 6
        Me.btnupdate.Text = "កែប្រែ"
        Me.btnupdate.UseVisualStyleBackColor = False
        '
        'btnclear
        '
        Me.btnclear.BackColor = System.Drawing.Color.White
        Me.btnclear.Font = New System.Drawing.Font("Khmer Kep", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnclear.ForeColor = System.Drawing.Color.Lime
        Me.btnclear.Location = New System.Drawing.Point(187, 262)
        Me.btnclear.Name = "btnclear"
        Me.btnclear.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.btnclear.Size = New System.Drawing.Size(112, 33)
        Me.btnclear.TabIndex = 5
        Me.btnclear.Text = "ជម្រះ"
        Me.btnclear.UseVisualStyleBackColor = False
        '
        'btnsave
        '
        Me.btnsave.BackColor = System.Drawing.Color.White
        Me.btnsave.Font = New System.Drawing.Font("Khmer Kep", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnsave.ForeColor = System.Drawing.Color.Lime
        Me.btnsave.Location = New System.Drawing.Point(43, 262)
        Me.btnsave.Name = "btnsave"
        Me.btnsave.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.btnsave.Size = New System.Drawing.Size(112, 33)
        Me.btnsave.TabIndex = 4
        Me.btnsave.Text = "រក្សាទុក"
        Me.btnsave.UseVisualStyleBackColor = False
        '
        'dgvsubject
        '
        Me.dgvsubject.AllowUserToAddRows = False
        Me.dgvsubject.AllowUserToDeleteRows = False
        Me.dgvsubject.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Khmer Kep", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvsubject.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.dgvsubject.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvsubject.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.Desc, Me.Descr})
        Me.dgvsubject.Location = New System.Drawing.Point(43, 342)
        Me.dgvsubject.Name = "dgvsubject"
        Me.dgvsubject.ReadOnly = True
        Me.dgvsubject.RowHeadersVisible = False
        Me.dgvsubject.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvsubject.Size = New System.Drawing.Size(673, 161)
        Me.dgvsubject.TabIndex = 92
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.HeaderText = "អត្តលេខ"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.ReadOnly = True
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.HeaderText = "ផ្នែកសិក្សា"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        Me.DataGridViewTextBoxColumn2.ReadOnly = True
        '
        'Desc
        '
        Me.Desc.HeaderText = "មុខវិជ្ជាសិក្សា"
        Me.Desc.Name = "Desc"
        Me.Desc.ReadOnly = True
        '
        'Descr
        '
        Me.Descr.HeaderText = "សេចក្តីអធិប្បាយ"
        Me.Descr.Name = "Descr"
        Me.Descr.ReadOnly = True
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Khmer Kep", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.Blue
        Me.Label8.Location = New System.Drawing.Point(124, 158)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(94, 33)
        Me.Label8.TabIndex = 91
        Me.Label8.Text = "ឈ្មោះមុខវិជ្ជា"
        '
        'txtid
        '
        Me.txtid.Font = New System.Drawing.Font("Khmer Kep", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtid.Location = New System.Drawing.Point(263, 69)
        Me.txtid.Name = "txtid"
        Me.txtid.ReadOnly = True
        Me.txtid.Size = New System.Drawing.Size(247, 32)
        Me.txtid.TabIndex = 90
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Khmer Kep", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.Blue
        Me.Label9.Location = New System.Drawing.Point(124, 66)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(65, 33)
        Me.Label9.TabIndex = 89
        Me.Label9.Text = "អត្តលេខ"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Khmer Wat Phnom", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.Color.Blue
        Me.Label10.Location = New System.Drawing.Point(316, 4)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(150, 56)
        Me.Label10.TabIndex = 88
        Me.Label10.Text = "មុខវិជ្ជាសិក្សា"
        '
        'txtsubject
        '
        Me.txtsubject.Font = New System.Drawing.Font("Khmer Kep", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtsubject.Location = New System.Drawing.Point(263, 158)
        Me.txtsubject.Name = "txtsubject"
        Me.txtsubject.Size = New System.Drawing.Size(247, 32)
        Me.txtsubject.TabIndex = 2
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Khmer Kep", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Blue
        Me.Label2.Location = New System.Drawing.Point(124, 110)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(76, 33)
        Me.Label2.TabIndex = 104
        Me.Label2.Text = "ផ្នែកសិក្សា"
        '
        'cbopartstudy
        '
        Me.cbopartstudy.Font = New System.Drawing.Font("Khmer Kep", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbopartstudy.Items.AddRange(New Object() {"ព្រឹក", "រសៀល", "ល្ងាច"})
        Me.cbopartstudy.Location = New System.Drawing.Point(263, 113)
        Me.cbopartstudy.Name = "cbopartstudy"
        Me.cbopartstudy.Size = New System.Drawing.Size(247, 32)
        Me.cbopartstudy.TabIndex = 1
        '
        'btnaddpartstudy
        '
        Me.btnaddpartstudy.BackColor = System.Drawing.Color.White
        Me.btnaddpartstudy.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnaddpartstudy.ForeColor = System.Drawing.Color.Lime
        Me.btnaddpartstudy.Location = New System.Drawing.Point(512, 111)
        Me.btnaddpartstudy.Name = "btnaddpartstudy"
        Me.btnaddpartstudy.Size = New System.Drawing.Size(31, 35)
        Me.btnaddpartstudy.TabIndex = 9
        Me.btnaddpartstudy.Text = "+"
        Me.btnaddpartstudy.UseVisualStyleBackColor = False
        '
        'FrmSubject
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(758, 526)
        Me.Controls.Add(Me.btnaddpartstudy)
        Me.Controls.Add(Me.cbopartstudy)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtsubject)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtdesc)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.btndelete)
        Me.Controls.Add(Me.btnclose)
        Me.Controls.Add(Me.btnupdate)
        Me.Controls.Add(Me.btnclear)
        Me.Controls.Add(Me.btnsave)
        Me.Controls.Add(Me.dgvsubject)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.txtid)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label10)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "FrmSubject"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "ប្រព័ន្ធគ្រប់គ្រងទិន្នន័យសិស្ស និង បុគ្គលិក"
        CType(Me.dgvsubject, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents txtdesc As TextBox
    Friend WithEvents Label11 As Label
    Friend WithEvents btndelete As Button
    Friend WithEvents btnclose As Button
    Friend WithEvents btnupdate As Button
    Friend WithEvents btnclear As Button
    Friend WithEvents btnsave As Button
    Friend WithEvents dgvsubject As DataGridView
    Friend WithEvents Label8 As Label
    Friend WithEvents txtid As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents txtsubject As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents cbopartstudy As ComboBox
    Friend WithEvents DataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
    Friend WithEvents Desc As DataGridViewTextBoxColumn
    Friend WithEvents Descr As DataGridViewTextBoxColumn
    Friend WithEvents btnaddpartstudy As Button
End Class

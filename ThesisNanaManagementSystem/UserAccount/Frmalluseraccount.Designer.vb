<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Frmalluseraccount
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Frmalluseraccount))
        Me.Label2 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.dgvuser = New System.Windows.Forms.DataGridView()
        Me.imag = New System.Windows.Forms.DataGridViewImageColumn()
        Me.id = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.username = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.password = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.usertype = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.datamanaagement = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Label105 = New System.Windows.Forms.Label()
        Me.txtsearch = New System.Windows.Forms.TextBox()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.Button4 = New System.Windows.Forms.Button()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvuser, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Khmer Wat Phnom", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label2.Location = New System.Drawing.Point(460, 20)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(194, 46)
        Me.Label2.TabIndex = 14
        Me.Label2.Text = "ទិន្នន័យគណនីទាំងអស់"
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.ThesisNanaManagementSystem.My.Resources.Resources.images
        Me.PictureBox1.Location = New System.Drawing.Point(649, 14)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(70, 52)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 15
        Me.PictureBox1.TabStop = False
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
        Me.dgvuser.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.imag, Me.id, Me.username, Me.password, Me.usertype, Me.Column5, Me.Column1, Me.Column2, Me.Column3, Me.Column4, Me.datamanaagement})
        Me.dgvuser.Location = New System.Drawing.Point(34, 135)
        Me.dgvuser.Name = "dgvuser"
        Me.dgvuser.ReadOnly = True
        Me.dgvuser.RowHeadersVisible = False
        Me.dgvuser.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvuser.Size = New System.Drawing.Size(1123, 296)
        Me.dgvuser.TabIndex = 16
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
        'Column5
        '
        Me.Column5.HeaderText = "(សិទ្ធិ)បង្កើតគណនីថ្មី"
        Me.Column5.Name = "Column5"
        Me.Column5.ReadOnly = True
        Me.Column5.Width = 137
        '
        'Column1
        '
        Me.Column1.HeaderText = "(សិទ្ធិ)បញ្ជីគ្រប់គ្រងសិស្ស"
        Me.Column1.Name = "Column1"
        Me.Column1.ReadOnly = True
        Me.Column1.Width = 157
        '
        'Column2
        '
        Me.Column2.HeaderText = "(សិទ្ធិ)បញ្ជីគ្រប់គ្រងបុគ្គលិក"
        Me.Column2.Name = "Column2"
        Me.Column2.ReadOnly = True
        Me.Column2.Width = 166
        '
        'Column3
        '
        Me.Column3.HeaderText = "(សិទ្ធិ)បញ្ជីមុខវិជ្ជាសិក្សា"
        Me.Column3.Name = "Column3"
        Me.Column3.ReadOnly = True
        Me.Column3.Width = 151
        '
        'Column4
        '
        Me.Column4.HeaderText = "(សិទ្ធិ)តារាងពេលវេលា"
        Me.Column4.Name = "Column4"
        Me.Column4.ReadOnly = True
        Me.Column4.Width = 145
        '
        'datamanaagement
        '
        Me.datamanaagement.HeaderText = "(សិទ្ធិ)DataManagement"
        Me.datamanaagement.Name = "datamanaagement"
        Me.datamanaagement.ReadOnly = True
        Me.datamanaagement.Width = 167
        '
        'Label105
        '
        Me.Label105.AutoSize = True
        Me.Label105.Font = New System.Drawing.Font("Khmer Kep", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label105.Location = New System.Drawing.Point(360, 82)
        Me.Label105.Name = "Label105"
        Me.Label105.Size = New System.Drawing.Size(175, 33)
        Me.Label105.TabIndex = 33
        Me.Label105.Text = "ស្វែងរកទិន្នន័យដោយឈ្មោះ"
        '
        'txtsearch
        '
        Me.txtsearch.Font = New System.Drawing.Font("Khmer Kep", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtsearch.Location = New System.Drawing.Point(570, 82)
        Me.txtsearch.Name = "txtsearch"
        Me.txtsearch.Size = New System.Drawing.Size(244, 30)
        Me.txtsearch.TabIndex = 34
        '
        'Button5
        '
        Me.Button5.BackColor = System.Drawing.Color.White
        Me.Button5.Font = New System.Drawing.Font("Khmer Kep", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button5.ForeColor = System.Drawing.Color.Red
        Me.Button5.Location = New System.Drawing.Point(1048, 448)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(109, 35)
        Me.Button5.TabIndex = 228
        Me.Button5.Text = "បិទ"
        Me.Button5.UseVisualStyleBackColor = False
        '
        'Button4
        '
        Me.Button4.BackColor = System.Drawing.Color.White
        Me.Button4.Font = New System.Drawing.Font("Khmer Kep", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Button4.Location = New System.Drawing.Point(897, 448)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(111, 35)
        Me.Button4.TabIndex = 227
        Me.Button4.Text = "REPORT"
        Me.Button4.UseVisualStyleBackColor = False
        '
        'Frmalluseraccount
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1183, 495)
        Me.Controls.Add(Me.Button5)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.Label105)
        Me.Controls.Add(Me.txtsearch)
        Me.Controls.Add(Me.dgvuser)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.PictureBox1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "Frmalluseraccount"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "ប្រព័ន្ធគ្រប់គ្រងទិន្នន័យសិស្ស​ និង បុគ្គលិក"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgvuser, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label2 As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents dgvuser As DataGridView
    Friend WithEvents Label105 As Label
    Friend WithEvents txtsearch As TextBox
    Friend WithEvents imag As DataGridViewImageColumn
    Friend WithEvents id As DataGridViewTextBoxColumn
    Friend WithEvents username As DataGridViewTextBoxColumn
    Friend WithEvents password As DataGridViewTextBoxColumn
    Friend WithEvents usertype As DataGridViewTextBoxColumn
    Friend WithEvents Column5 As DataGridViewTextBoxColumn
    Friend WithEvents Column1 As DataGridViewTextBoxColumn
    Friend WithEvents Column2 As DataGridViewTextBoxColumn
    Friend WithEvents Column3 As DataGridViewTextBoxColumn
    Friend WithEvents Column4 As DataGridViewTextBoxColumn
    Friend WithEvents datamanaagement As DataGridViewTextBoxColumn
    Friend WithEvents Button5 As Button
    Friend WithEvents Button4 As Button
End Class

<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FormBuku
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.grpTambah = New System.Windows.Forms.GroupBox()
        Me.btnTambah = New System.Windows.Forms.Button()
        Me.txtGenre = New System.Windows.Forms.TextBox()
        Me.txtJudul = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.grpHapus = New System.Windows.Forms.GroupBox()
        Me.btnHapus = New System.Windows.Forms.Button()
        Me.txtHapus = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.lstBuku = New System.Windows.Forms.ListBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.grpTambah.SuspendLayout()
        Me.grpHapus.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Monotype Corsiva", 19.8!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(249, 21)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(366, 40)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Daftar Buku Perpustakaan"
        '
        'grpTambah
        '
        Me.grpTambah.BackColor = System.Drawing.Color.LavenderBlush
        Me.grpTambah.Controls.Add(Me.btnTambah)
        Me.grpTambah.Controls.Add(Me.txtGenre)
        Me.grpTambah.Controls.Add(Me.txtJudul)
        Me.grpTambah.Controls.Add(Me.Label3)
        Me.grpTambah.Controls.Add(Me.Label2)
        Me.grpTambah.Location = New System.Drawing.Point(57, 91)
        Me.grpTambah.Name = "grpTambah"
        Me.grpTambah.Size = New System.Drawing.Size(358, 177)
        Me.grpTambah.TabIndex = 1
        Me.grpTambah.TabStop = False
        Me.grpTambah.Text = "Tambah Buku"
        '
        'btnTambah
        '
        Me.btnTambah.BackColor = System.Drawing.Color.PaleGreen
        Me.btnTambah.Font = New System.Drawing.Font("Mongolian Baiti", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnTambah.ForeColor = System.Drawing.Color.Black
        Me.btnTambah.Location = New System.Drawing.Point(199, 136)
        Me.btnTambah.Name = "btnTambah"
        Me.btnTambah.Size = New System.Drawing.Size(76, 28)
        Me.btnTambah.TabIndex = 4
        Me.btnTambah.Text = "Tambah"
        Me.btnTambah.UseVisualStyleBackColor = False
        '
        'txtGenre
        '
        Me.txtGenre.Location = New System.Drawing.Point(145, 90)
        Me.txtGenre.Name = "txtGenre"
        Me.txtGenre.Size = New System.Drawing.Size(187, 30)
        Me.txtGenre.TabIndex = 3
        '
        'txtJudul
        '
        Me.txtJudul.Location = New System.Drawing.Point(145, 45)
        Me.txtJudul.Name = "txtJudul"
        Me.txtJudul.Size = New System.Drawing.Size(187, 30)
        Me.txtJudul.TabIndex = 2
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Mongolian Baiti", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(24, 97)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(56, 18)
        Me.Label3.TabIndex = 1
        Me.Label3.Text = "Genre"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Mongolian Baiti", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(24, 52)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(99, 18)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Judul Buku"
        '
        'grpHapus
        '
        Me.grpHapus.BackColor = System.Drawing.Color.LavenderBlush
        Me.grpHapus.Controls.Add(Me.btnHapus)
        Me.grpHapus.Controls.Add(Me.txtHapus)
        Me.grpHapus.Controls.Add(Me.Label4)
        Me.grpHapus.Location = New System.Drawing.Point(57, 292)
        Me.grpHapus.Name = "grpHapus"
        Me.grpHapus.Size = New System.Drawing.Size(358, 177)
        Me.grpHapus.TabIndex = 2
        Me.grpHapus.TabStop = False
        Me.grpHapus.Text = "Hapus Buku"
        '
        'btnHapus
        '
        Me.btnHapus.BackColor = System.Drawing.Color.LightCoral
        Me.btnHapus.Font = New System.Drawing.Font("Mongolian Baiti", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnHapus.Location = New System.Drawing.Point(199, 129)
        Me.btnHapus.Name = "btnHapus"
        Me.btnHapus.Size = New System.Drawing.Size(76, 28)
        Me.btnHapus.TabIndex = 2
        Me.btnHapus.Text = "Hapus"
        Me.btnHapus.UseVisualStyleBackColor = False
        '
        'txtHapus
        '
        Me.txtHapus.Location = New System.Drawing.Point(145, 66)
        Me.txtHapus.Name = "txtHapus"
        Me.txtHapus.Size = New System.Drawing.Size(187, 30)
        Me.txtHapus.TabIndex = 1
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Mongolian Baiti", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(24, 73)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(99, 18)
        Me.Label4.TabIndex = 0
        Me.Label4.Text = "Judul Buku"
        '
        'lstBuku
        '
        Me.lstBuku.BackColor = System.Drawing.Color.Thistle
        Me.lstBuku.FormattingEnabled = True
        Me.lstBuku.ItemHeight = 24
        Me.lstBuku.Location = New System.Drawing.Point(465, 143)
        Me.lstBuku.Name = "lstBuku"
        Me.lstBuku.Size = New System.Drawing.Size(327, 268)
        Me.lstBuku.TabIndex = 3
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(583, 116)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(112, 24)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "Daftar Buku"
        '
        'FormBuku
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(11.0!, 24.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Pink
        Me.ClientSize = New System.Drawing.Size(832, 503)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.lstBuku)
        Me.Controls.Add(Me.grpHapus)
        Me.Controls.Add(Me.grpTambah)
        Me.Controls.Add(Me.Label1)
        Me.Font = New System.Drawing.Font("Monotype Corsiva", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "FormBuku"
        Me.Text = "Library Book Manager 📚"
        Me.grpTambah.ResumeLayout(False)
        Me.grpTambah.PerformLayout()
        Me.grpHapus.ResumeLayout(False)
        Me.grpHapus.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents grpTambah As GroupBox
    Friend WithEvents grpHapus As GroupBox
    Friend WithEvents txtGenre As TextBox
    Friend WithEvents txtJudul As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents btnTambah As Button
    Friend WithEvents Label4 As Label
    Friend WithEvents txtHapus As TextBox
    Friend WithEvents btnHapus As Button
    Friend WithEvents lstBuku As ListBox
    Friend WithEvents Label5 As Label
End Class

<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.pictureBoxFoto = New System.Windows.Forms.PictureBox()
        Me.btnBrowse = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtNama = New System.Windows.Forms.TextBox()
        Me.txtUmur = New System.Windows.Forms.TextBox()
        Me.txtTelepon = New System.Windows.Forms.TextBox()
        Me.txtAlamat = New System.Windows.Forms.TextBox()
        Me.dtpTanggal = New System.Windows.Forms.DateTimePicker()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.rbPerempuan = New System.Windows.Forms.RadioButton()
        Me.RbLaki = New System.Windows.Forms.RadioButton()
        Me.GroupBoxHobby = New System.Windows.Forms.GroupBox()
        Me.cbTidur = New System.Windows.Forms.CheckBox()
        Me.cbMakeup = New System.Windows.Forms.CheckBox()
        Me.cbMemancing = New System.Windows.Forms.CheckBox()
        Me.cbShopping = New System.Windows.Forms.CheckBox()
        Me.cbMenari = New System.Windows.Forms.CheckBox()
        Me.cbMenyanyi = New System.Windows.Forms.CheckBox()
        Me.cbMenggambar = New System.Windows.Forms.CheckBox()
        Me.cbOlahraga = New System.Windows.Forms.CheckBox()
        Me.cbMembaca = New System.Windows.Forms.CheckBox()
        Me.cbTravelling = New System.Windows.Forms.CheckBox()
        Me.cbCoding = New System.Windows.Forms.CheckBox()
        Me.cbGaming = New System.Windows.Forms.CheckBox()
        Me.btnCetak = New System.Windows.Forms.Button()
        CType(Me.pictureBoxFoto, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBoxHobby.SuspendLayout()
        Me.SuspendLayout()
        '
        'pictureBoxFoto
        '
        Me.pictureBoxFoto.BackColor = System.Drawing.Color.Maroon
        Me.pictureBoxFoto.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pictureBoxFoto.Location = New System.Drawing.Point(22, 32)
        Me.pictureBoxFoto.Name = "pictureBoxFoto"
        Me.pictureBoxFoto.Size = New System.Drawing.Size(273, 417)
        Me.pictureBoxFoto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pictureBoxFoto.TabIndex = 0
        Me.pictureBoxFoto.TabStop = False
        '
        'btnBrowse
        '
        Me.btnBrowse.BackColor = System.Drawing.Color.Maroon
        Me.btnBrowse.Font = New System.Drawing.Font("Times New Roman", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBrowse.ForeColor = System.Drawing.SystemColors.Window
        Me.btnBrowse.Location = New System.Drawing.Point(95, 469)
        Me.btnBrowse.Name = "btnBrowse"
        Me.btnBrowse.Size = New System.Drawing.Size(100, 30)
        Me.btnBrowse.TabIndex = 1
        Me.btnBrowse.Text = "Browse"
        Me.btnBrowse.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.SeaShell
        Me.Label1.ForeColor = System.Drawing.Color.Firebrick
        Me.Label1.Location = New System.Drawing.Point(337, 32)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(59, 23)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Nama"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.ForeColor = System.Drawing.Color.Firebrick
        Me.Label2.Location = New System.Drawing.Point(337, 84)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(57, 23)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Umur"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.ForeColor = System.Drawing.Color.Firebrick
        Me.Label3.Location = New System.Drawing.Point(337, 138)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(127, 23)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Tanggal Lahir"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.ForeColor = System.Drawing.Color.Firebrick
        Me.Label4.Location = New System.Drawing.Point(337, 190)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(110, 23)
        Me.Label4.TabIndex = 5
        Me.Label4.Text = "No. Telepon"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.ForeColor = System.Drawing.Color.Firebrick
        Me.Label5.Location = New System.Drawing.Point(339, 239)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(71, 23)
        Me.Label5.TabIndex = 6
        Me.Label5.Text = "Alamat"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(3, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(127, 23)
        Me.Label6.TabIndex = 7
        Me.Label6.Text = "Jenis Kelamin"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.ForeColor = System.Drawing.Color.Firebrick
        Me.Label7.Location = New System.Drawing.Point(6, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(65, 23)
        Me.Label7.TabIndex = 8
        Me.Label7.Text = "Hobby"
        '
        'txtNama
        '
        Me.txtNama.Location = New System.Drawing.Point(562, 32)
        Me.txtNama.Name = "txtNama"
        Me.txtNama.Size = New System.Drawing.Size(330, 30)
        Me.txtNama.TabIndex = 9
        '
        'txtUmur
        '
        Me.txtUmur.Location = New System.Drawing.Point(562, 81)
        Me.txtUmur.Name = "txtUmur"
        Me.txtUmur.Size = New System.Drawing.Size(330, 30)
        Me.txtUmur.TabIndex = 10
        '
        'txtTelepon
        '
        Me.txtTelepon.Location = New System.Drawing.Point(562, 187)
        Me.txtTelepon.Name = "txtTelepon"
        Me.txtTelepon.Size = New System.Drawing.Size(330, 30)
        Me.txtTelepon.TabIndex = 11
        '
        'txtAlamat
        '
        Me.txtAlamat.Location = New System.Drawing.Point(562, 236)
        Me.txtAlamat.Name = "txtAlamat"
        Me.txtAlamat.Size = New System.Drawing.Size(330, 30)
        Me.txtAlamat.TabIndex = 12
        '
        'dtpTanggal
        '
        Me.dtpTanggal.CalendarForeColor = System.Drawing.Color.Firebrick
        Me.dtpTanggal.CalendarTitleForeColor = System.Drawing.Color.Firebrick
        Me.dtpTanggal.Font = New System.Drawing.Font("Times New Roman", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpTanggal.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpTanggal.Location = New System.Drawing.Point(562, 132)
        Me.dtpTanggal.Name = "dtpTanggal"
        Me.dtpTanggal.Size = New System.Drawing.Size(144, 27)
        Me.dtpTanggal.TabIndex = 13
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.SystemColors.Window
        Me.GroupBox1.Controls.Add(Me.rbPerempuan)
        Me.GroupBox1.Controls.Add(Me.RbLaki)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.ForeColor = System.Drawing.Color.Firebrick
        Me.GroupBox1.Location = New System.Drawing.Point(334, 293)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(212, 156)
        Me.GroupBox1.TabIndex = 14
        Me.GroupBox1.TabStop = False
        '
        'rbPerempuan
        '
        Me.rbPerempuan.AutoSize = True
        Me.rbPerempuan.Font = New System.Drawing.Font("Times New Roman", 10.8!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbPerempuan.ForeColor = System.Drawing.SystemColors.InactiveCaptionText
        Me.rbPerempuan.Location = New System.Drawing.Point(16, 101)
        Me.rbPerempuan.Name = "rbPerempuan"
        Me.rbPerempuan.Size = New System.Drawing.Size(118, 25)
        Me.rbPerempuan.TabIndex = 9
        Me.rbPerempuan.TabStop = True
        Me.rbPerempuan.Text = "Perempuan"
        Me.rbPerempuan.UseVisualStyleBackColor = True
        '
        'RbLaki
        '
        Me.RbLaki.AutoSize = True
        Me.RbLaki.Font = New System.Drawing.Font("Times New Roman", 10.8!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RbLaki.ForeColor = System.Drawing.SystemColors.InactiveCaptionText
        Me.RbLaki.Location = New System.Drawing.Point(16, 46)
        Me.RbLaki.Name = "RbLaki"
        Me.RbLaki.Size = New System.Drawing.Size(99, 25)
        Me.RbLaki.TabIndex = 8
        Me.RbLaki.TabStop = True
        Me.RbLaki.Text = "Laki-laki"
        Me.RbLaki.UseVisualStyleBackColor = True
        '
        'GroupBoxHobby
        '
        Me.GroupBoxHobby.BackColor = System.Drawing.SystemColors.Window
        Me.GroupBoxHobby.Controls.Add(Me.cbTidur)
        Me.GroupBoxHobby.Controls.Add(Me.cbMakeup)
        Me.GroupBoxHobby.Controls.Add(Me.cbMemancing)
        Me.GroupBoxHobby.Controls.Add(Me.cbShopping)
        Me.GroupBoxHobby.Controls.Add(Me.cbMenari)
        Me.GroupBoxHobby.Controls.Add(Me.cbMenyanyi)
        Me.GroupBoxHobby.Controls.Add(Me.cbMenggambar)
        Me.GroupBoxHobby.Controls.Add(Me.cbOlahraga)
        Me.GroupBoxHobby.Controls.Add(Me.cbMembaca)
        Me.GroupBoxHobby.Controls.Add(Me.cbTravelling)
        Me.GroupBoxHobby.Controls.Add(Me.cbCoding)
        Me.GroupBoxHobby.Controls.Add(Me.cbGaming)
        Me.GroupBoxHobby.Controls.Add(Me.Label7)
        Me.GroupBoxHobby.Location = New System.Drawing.Point(562, 293)
        Me.GroupBoxHobby.Name = "GroupBoxHobby"
        Me.GroupBoxHobby.Size = New System.Drawing.Size(342, 156)
        Me.GroupBoxHobby.TabIndex = 15
        Me.GroupBoxHobby.TabStop = False
        '
        'cbTidur
        '
        Me.cbTidur.AutoSize = True
        Me.cbTidur.Font = New System.Drawing.Font("Times New Roman", 10.2!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbTidur.ForeColor = System.Drawing.SystemColors.InactiveCaptionText
        Me.cbTidur.Location = New System.Drawing.Point(104, 119)
        Me.cbTidur.Name = "cbTidur"
        Me.cbTidur.Size = New System.Drawing.Size(70, 24)
        Me.cbTidur.TabIndex = 20
        Me.cbTidur.Text = "Tidur"
        Me.cbTidur.UseVisualStyleBackColor = True
        '
        'cbMakeup
        '
        Me.cbMakeup.AutoSize = True
        Me.cbMakeup.Font = New System.Drawing.Font("Times New Roman", 10.2!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbMakeup.ForeColor = System.Drawing.SystemColors.InactiveCaptionText
        Me.cbMakeup.Location = New System.Drawing.Point(10, 119)
        Me.cbMakeup.Name = "cbMakeup"
        Me.cbMakeup.Size = New System.Drawing.Size(90, 24)
        Me.cbMakeup.TabIndex = 19
        Me.cbMakeup.Text = "Makeup"
        Me.cbMakeup.UseVisualStyleBackColor = True
        '
        'cbMemancing
        '
        Me.cbMemancing.AutoSize = True
        Me.cbMemancing.Font = New System.Drawing.Font("Times New Roman", 10.2!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbMemancing.ForeColor = System.Drawing.SystemColors.InactiveCaptionText
        Me.cbMemancing.Location = New System.Drawing.Point(214, 119)
        Me.cbMemancing.Name = "cbMemancing"
        Me.cbMemancing.Size = New System.Drawing.Size(116, 24)
        Me.cbMemancing.TabIndex = 18
        Me.cbMemancing.Text = "Memancing"
        Me.cbMemancing.UseVisualStyleBackColor = True
        '
        'cbShopping
        '
        Me.cbShopping.AutoSize = True
        Me.cbShopping.Font = New System.Drawing.Font("Times New Roman", 10.2!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbShopping.ForeColor = System.Drawing.SystemColors.InactiveCaptionText
        Me.cbShopping.Location = New System.Drawing.Point(214, 89)
        Me.cbShopping.Name = "cbShopping"
        Me.cbShopping.Size = New System.Drawing.Size(98, 24)
        Me.cbShopping.TabIndex = 17
        Me.cbShopping.Text = "Shopping"
        Me.cbShopping.UseVisualStyleBackColor = True
        '
        'cbMenari
        '
        Me.cbMenari.AutoSize = True
        Me.cbMenari.Font = New System.Drawing.Font("Times New Roman", 10.2!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbMenari.ForeColor = System.Drawing.SystemColors.InactiveCaptionText
        Me.cbMenari.Location = New System.Drawing.Point(10, 89)
        Me.cbMenari.Name = "cbMenari"
        Me.cbMenari.Size = New System.Drawing.Size(84, 24)
        Me.cbMenari.TabIndex = 16
        Me.cbMenari.Text = "Menari"
        Me.cbMenari.UseVisualStyleBackColor = True
        '
        'cbMenyanyi
        '
        Me.cbMenyanyi.AutoSize = True
        Me.cbMenyanyi.Font = New System.Drawing.Font("Times New Roman", 10.2!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbMenyanyi.ForeColor = System.Drawing.SystemColors.InactiveCaptionText
        Me.cbMenyanyi.Location = New System.Drawing.Point(104, 89)
        Me.cbMenyanyi.Name = "cbMenyanyi"
        Me.cbMenyanyi.Size = New System.Drawing.Size(100, 24)
        Me.cbMenyanyi.TabIndex = 15
        Me.cbMenyanyi.Text = "Menyanyi"
        Me.cbMenyanyi.UseVisualStyleBackColor = True
        '
        'cbMenggambar
        '
        Me.cbMenggambar.AutoSize = True
        Me.cbMenggambar.Font = New System.Drawing.Font("Times New Roman", 10.2!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbMenggambar.ForeColor = System.Drawing.SystemColors.InactiveCaptionText
        Me.cbMenggambar.Location = New System.Drawing.Point(214, 59)
        Me.cbMenggambar.Name = "cbMenggambar"
        Me.cbMenggambar.Size = New System.Drawing.Size(128, 24)
        Me.cbMenggambar.TabIndex = 14
        Me.cbMenggambar.Text = "Menggambar"
        Me.cbMenggambar.UseVisualStyleBackColor = True
        '
        'cbOlahraga
        '
        Me.cbOlahraga.AutoSize = True
        Me.cbOlahraga.Font = New System.Drawing.Font("Times New Roman", 10.2!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbOlahraga.ForeColor = System.Drawing.SystemColors.InactiveCaptionText
        Me.cbOlahraga.Location = New System.Drawing.Point(214, 29)
        Me.cbOlahraga.Name = "cbOlahraga"
        Me.cbOlahraga.Size = New System.Drawing.Size(100, 24)
        Me.cbOlahraga.TabIndex = 13
        Me.cbOlahraga.Text = "Olahraga"
        Me.cbOlahraga.UseVisualStyleBackColor = True
        '
        'cbMembaca
        '
        Me.cbMembaca.AutoSize = True
        Me.cbMembaca.Font = New System.Drawing.Font("Times New Roman", 10.2!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbMembaca.ForeColor = System.Drawing.SystemColors.InactiveCaptionText
        Me.cbMembaca.Location = New System.Drawing.Point(104, 59)
        Me.cbMembaca.Name = "cbMembaca"
        Me.cbMembaca.Size = New System.Drawing.Size(102, 24)
        Me.cbMembaca.TabIndex = 12
        Me.cbMembaca.Text = "Membaca"
        Me.cbMembaca.UseVisualStyleBackColor = True
        '
        'cbTravelling
        '
        Me.cbTravelling.AutoSize = True
        Me.cbTravelling.BackColor = System.Drawing.SystemColors.Window
        Me.cbTravelling.Font = New System.Drawing.Font("Times New Roman", 10.2!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbTravelling.ForeColor = System.Drawing.SystemColors.InactiveCaptionText
        Me.cbTravelling.Location = New System.Drawing.Point(104, 29)
        Me.cbTravelling.Name = "cbTravelling"
        Me.cbTravelling.Size = New System.Drawing.Size(104, 24)
        Me.cbTravelling.TabIndex = 11
        Me.cbTravelling.Text = "Travelling"
        Me.cbTravelling.UseVisualStyleBackColor = False
        '
        'cbCoding
        '
        Me.cbCoding.AutoSize = True
        Me.cbCoding.Font = New System.Drawing.Font("Times New Roman", 10.2!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbCoding.ForeColor = System.Drawing.SystemColors.InactiveCaptionText
        Me.cbCoding.Location = New System.Drawing.Point(10, 59)
        Me.cbCoding.Name = "cbCoding"
        Me.cbCoding.Size = New System.Drawing.Size(82, 24)
        Me.cbCoding.TabIndex = 10
        Me.cbCoding.Text = "Coding"
        Me.cbCoding.UseVisualStyleBackColor = True
        '
        'cbGaming
        '
        Me.cbGaming.AutoSize = True
        Me.cbGaming.Font = New System.Drawing.Font("Times New Roman", 10.2!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbGaming.ForeColor = System.Drawing.SystemColors.InactiveCaptionText
        Me.cbGaming.Location = New System.Drawing.Point(10, 29)
        Me.cbGaming.Name = "cbGaming"
        Me.cbGaming.Size = New System.Drawing.Size(88, 24)
        Me.cbGaming.TabIndex = 9
        Me.cbGaming.Text = "Gaming"
        Me.cbGaming.UseVisualStyleBackColor = True
        '
        'btnCetak
        '
        Me.btnCetak.BackColor = System.Drawing.Color.Maroon
        Me.btnCetak.ForeColor = System.Drawing.SystemColors.Window
        Me.btnCetak.Location = New System.Drawing.Point(435, 469)
        Me.btnCetak.Name = "btnCetak"
        Me.btnCetak.Size = New System.Drawing.Size(353, 34)
        Me.btnCetak.TabIndex = 16
        Me.btnCetak.Text = "Cetak Kartu"
        Me.btnCetak.UseVisualStyleBackColor = False
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(12.0!, 23.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.SeaShell
        Me.ClientSize = New System.Drawing.Size(932, 522)
        Me.Controls.Add(Me.btnCetak)
        Me.Controls.Add(Me.GroupBoxHobby)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.dtpTanggal)
        Me.Controls.Add(Me.txtAlamat)
        Me.Controls.Add(Me.txtTelepon)
        Me.Controls.Add(Me.txtUmur)
        Me.Controls.Add(Me.txtNama)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnBrowse)
        Me.Controls.Add(Me.pictureBoxFoto)
        Me.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ForeColor = System.Drawing.Color.MediumVioletRed
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "Form1"
        Me.Text = "Form Input"
        CType(Me.pictureBoxFoto, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBoxHobby.ResumeLayout(False)
        Me.GroupBoxHobby.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents pictureBoxFoto As PictureBox
    Friend WithEvents btnBrowse As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents txtNama As TextBox
    Friend WithEvents txtUmur As TextBox
    Friend WithEvents txtTelepon As TextBox
    Friend WithEvents txtAlamat As TextBox
    Friend WithEvents dtpTanggal As DateTimePicker
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents RbLaki As RadioButton
    Friend WithEvents rbPerempuan As RadioButton
    Friend WithEvents GroupBoxHobby As GroupBox
    Friend WithEvents cbCoding As CheckBox
    Friend WithEvents cbGaming As CheckBox
    Friend WithEvents cbMenyanyi As CheckBox
    Friend WithEvents cbMenggambar As CheckBox
    Friend WithEvents cbOlahraga As CheckBox
    Friend WithEvents cbMembaca As CheckBox
    Friend WithEvents cbTravelling As CheckBox
    Friend WithEvents cbTidur As CheckBox
    Friend WithEvents cbMakeup As CheckBox
    Friend WithEvents cbMemancing As CheckBox
    Friend WithEvents cbShopping As CheckBox
    Friend WithEvents cbMenari As CheckBox
    Friend WithEvents btnCetak As Button
End Class

<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class adminakun
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(adminakun))
        Dim CustomizableEdges1 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges2 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        PictureBox1 = New PictureBox()
        DataGridView1 = New DataGridView()
        email = New TextBox()
        nama = New TextBox()
        sandi = New TextBox()
        Label1 = New Label()
        Label2 = New Label()
        Label3 = New Label()
        simpan = New Button()
        ubah = New Button()
        hapus = New Button()
        kembali = New Guna.UI2.WinForms.Guna2Button()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        CType(DataGridView1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' PictureBox1
        ' 
        PictureBox1.BackgroundImage = CType(resources.GetObject("PictureBox1.BackgroundImage"), Image)
        PictureBox1.Location = New Point(-1, -4)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(1460, 1070)
        PictureBox1.TabIndex = 0
        PictureBox1.TabStop = False
        ' 
        ' DataGridView1
        ' 
        DataGridView1.BackgroundColor = SystemColors.ButtonHighlight
        DataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridView1.Location = New Point(80, 227)
        DataGridView1.Name = "DataGridView1"
        DataGridView1.RowHeadersWidth = 62
        DataGridView1.Size = New Size(743, 706)
        DataGridView1.TabIndex = 1
        ' 
        ' email
        ' 
        email.Location = New Point(977, 255)
        email.Name = "email"
        email.Size = New Size(312, 31)
        email.TabIndex = 2
        ' 
        ' nama
        ' 
        nama.Location = New Point(977, 315)
        nama.Name = "nama"
        nama.Size = New Size(312, 31)
        nama.TabIndex = 3
        ' 
        ' sandi
        ' 
        sandi.Location = New Point(977, 373)
        sandi.Name = "sandi"
        sandi.Size = New Size(312, 31)
        sandi.TabIndex = 4
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(875, 255)
        Label1.Name = "Label1"
        Label1.Size = New Size(54, 25)
        Label1.TabIndex = 5
        Label1.Text = "Email"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(875, 379)
        Label2.Name = "Label2"
        Label2.Size = New Size(87, 25)
        Label2.TabIndex = 6
        Label2.Text = "Password"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(875, 315)
        Label3.Name = "Label3"
        Label3.Size = New Size(59, 25)
        Label3.TabIndex = 7
        Label3.Text = "Nama"
        ' 
        ' simpan
        ' 
        simpan.Location = New Point(850, 448)
        simpan.Name = "simpan"
        simpan.Size = New Size(112, 34)
        simpan.TabIndex = 8
        simpan.Text = "Tambah"
        simpan.UseVisualStyleBackColor = True
        ' 
        ' ubah
        ' 
        ubah.Location = New Point(1015, 448)
        ubah.Name = "ubah"
        ubah.Size = New Size(112, 34)
        ubah.TabIndex = 9
        ubah.Text = "Ubah"
        ubah.UseVisualStyleBackColor = True
        ' 
        ' hapus
        ' 
        hapus.Location = New Point(1202, 448)
        hapus.Name = "hapus"
        hapus.Size = New Size(112, 34)
        hapus.TabIndex = 10
        hapus.Text = "Hapus"
        hapus.UseVisualStyleBackColor = True
        ' 
        ' kembali
        ' 
        kembali.BackColor = Color.Transparent
        kembali.CustomizableEdges = CustomizableEdges1
        kembali.DisabledState.BorderColor = Color.DarkGray
        kembali.DisabledState.CustomBorderColor = Color.DarkGray
        kembali.DisabledState.FillColor = Color.FromArgb(CByte(169), CByte(169), CByte(169))
        kembali.DisabledState.ForeColor = Color.FromArgb(CByte(141), CByte(141), CByte(141))
        kembali.FillColor = Color.Transparent
        kembali.Font = New Font("Segoe UI", 9F)
        kembali.ForeColor = Color.White
        kembali.Location = New Point(46, 51)
        kembali.Name = "kembali"
        kembali.ShadowDecoration.CustomizableEdges = CustomizableEdges2
        kembali.Size = New Size(145, 47)
        kembali.TabIndex = 11
        kembali.UseTransparentBackground = True
        ' 
        ' adminakun
        ' 
        AutoScaleDimensions = New SizeF(10F, 25F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1438, 1014)
        Controls.Add(kembali)
        Controls.Add(hapus)
        Controls.Add(ubah)
        Controls.Add(simpan)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Controls.Add(sandi)
        Controls.Add(nama)
        Controls.Add(email)
        Controls.Add(DataGridView1)
        Controls.Add(PictureBox1)
        Name = "adminakun"
        Text = "adminakun"
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        CType(DataGridView1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents email As TextBox
    Friend WithEvents nama As TextBox
    Friend WithEvents sandi As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents simpan As Button
    Friend WithEvents ubah As Button
    Friend WithEvents hapus As Button
    Friend WithEvents kembali As Guna.UI2.WinForms.Guna2Button
End Class

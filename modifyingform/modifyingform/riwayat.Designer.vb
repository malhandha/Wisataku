<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class riwayat
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(riwayat))
        Dim CustomizableEdges1 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges2 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        PictureBox1 = New PictureBox()
        kembali = New Guna.UI2.WinForms.Guna2Button()
        DataGridView1 = New DataGridView()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        CType(DataGridView1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' PictureBox1
        ' 
        PictureBox1.BackgroundImage = CType(resources.GetObject("PictureBox1.BackgroundImage"), Image)
        PictureBox1.Location = New Point(-18, 0)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(1460, 1070)
        PictureBox1.TabIndex = 0
        PictureBox1.TabStop = False
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
        kembali.Location = New Point(29, 57)
        kembali.Name = "kembali"
        kembali.ShadowDecoration.CustomizableEdges = CustomizableEdges2
        kembali.Size = New Size(145, 47)
        kembali.TabIndex = 8
        kembali.UseTransparentBackground = True
        ' 
        ' DataGridView1
        ' 
        DataGridView1.BackgroundColor = SystemColors.ButtonHighlight
        DataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridView1.Location = New Point(264, 267)
        DataGridView1.Name = "DataGridView1"
        DataGridView1.RowHeadersWidth = 62
        DataGridView1.Size = New Size(876, 566)
        DataGridView1.TabIndex = 9
        ' 
        ' riwayat
        ' 
        AutoScaleDimensions = New SizeF(10F, 25F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1423, 1014)
        Controls.Add(DataGridView1)
        Controls.Add(kembali)
        Controls.Add(PictureBox1)
        Name = "riwayat"
        StartPosition = FormStartPosition.CenterScreen
        Text = "riwayat"
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        CType(DataGridView1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
    End Sub

    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents kembali As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents DataGridView1 As DataGridView
End Class

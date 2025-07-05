<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class register
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
        components = New ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(register))
        Dim CustomizableEdges1 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges2 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges3 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges4 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        PictureBox1 = New PictureBox()
        nama = New TextBox()
        email = New TextBox()
        sandi = New TextBox()
        ksandi = New TextBox()
        Guna2Button3 = New Guna.UI2.WinForms.Guna2Button()
        ErrorProvider1 = New ErrorProvider(components)
        Guna2Button1 = New Guna.UI2.WinForms.Guna2Button()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        CType(ErrorProvider1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' PictureBox1
        ' 
        PictureBox1.BackgroundImage = CType(resources.GetObject("PictureBox1.BackgroundImage"), Image)
        PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), Image)
        PictureBox1.Location = New Point(-1, 0)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(1443, 1026)
        PictureBox1.TabIndex = 0
        PictureBox1.TabStop = False
        ' 
        ' nama
        ' 
        nama.BackColor = SystemColors.ScrollBar
        nama.BorderStyle = BorderStyle.FixedSingle
        nama.Font = New Font("High Tower Text", 16F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        nama.Location = New Point(492, 409)
        nama.Name = "nama"
        nama.Size = New Size(459, 45)
        nama.TabIndex = 8
        ' 
        ' email
        ' 
        email.BackColor = SystemColors.ScrollBar
        email.BorderStyle = BorderStyle.FixedSingle
        email.Font = New Font("High Tower Text", 16F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        email.Location = New Point(492, 515)
        email.Name = "email"
        email.Size = New Size(459, 45)
        email.TabIndex = 9
        ' 
        ' sandi
        ' 
        sandi.BackColor = SystemColors.ScrollBar
        sandi.BorderStyle = BorderStyle.FixedSingle
        sandi.Font = New Font("High Tower Text", 16F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        sandi.Location = New Point(492, 627)
        sandi.Name = "sandi"
        sandi.Size = New Size(459, 45)
        sandi.TabIndex = 10
        ' 
        ' ksandi
        ' 
        ksandi.BackColor = SystemColors.ScrollBar
        ksandi.BorderStyle = BorderStyle.FixedSingle
        ksandi.Font = New Font("High Tower Text", 16F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        ksandi.Location = New Point(492, 733)
        ksandi.Name = "ksandi"
        ksandi.Size = New Size(459, 45)
        ksandi.TabIndex = 11
        ' 
        ' Guna2Button3
        ' 
        Guna2Button3.BackColor = Color.Transparent
        Guna2Button3.CustomizableEdges = CustomizableEdges1
        Guna2Button3.DisabledState.BorderColor = Color.DarkGray
        Guna2Button3.DisabledState.CustomBorderColor = Color.DarkGray
        Guna2Button3.DisabledState.FillColor = Color.FromArgb(CByte(169), CByte(169), CByte(169))
        Guna2Button3.DisabledState.ForeColor = Color.FromArgb(CByte(141), CByte(141), CByte(141))
        Guna2Button3.FillColor = Color.Transparent
        Guna2Button3.Font = New Font("Segoe UI", 9F)
        Guna2Button3.ForeColor = Color.White
        Guna2Button3.Location = New Point(617, 833)
        Guna2Button3.Name = "Guna2Button3"
        Guna2Button3.ShadowDecoration.CustomizableEdges = CustomizableEdges2
        Guna2Button3.Size = New Size(204, 42)
        Guna2Button3.TabIndex = 12
        Guna2Button3.UseTransparentBackground = True
        ' 
        ' ErrorProvider1
        ' 
        ErrorProvider1.ContainerControl = Me
        ' 
        ' Guna2Button1
        ' 
        Guna2Button1.BackColor = Color.Transparent
        Guna2Button1.CustomizableEdges = CustomizableEdges3
        Guna2Button1.DisabledState.BorderColor = Color.DarkGray
        Guna2Button1.DisabledState.CustomBorderColor = Color.DarkGray
        Guna2Button1.DisabledState.FillColor = Color.FromArgb(CByte(169), CByte(169), CByte(169))
        Guna2Button1.DisabledState.ForeColor = Color.FromArgb(CByte(141), CByte(141), CByte(141))
        Guna2Button1.FillColor = Color.Transparent
        Guna2Button1.Font = New Font("Segoe UI", 9F)
        Guna2Button1.ForeColor = Color.White
        Guna2Button1.Location = New Point(767, 787)
        Guna2Button1.Name = "Guna2Button1"
        Guna2Button1.ShadowDecoration.CustomizableEdges = CustomizableEdges4
        Guna2Button1.Size = New Size(182, 19)
        Guna2Button1.TabIndex = 13
        Guna2Button1.UseTransparentBackground = True
        ' 
        ' register
        ' 
        AutoScaleDimensions = New SizeF(10F, 25F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1441, 1028)
        Controls.Add(Guna2Button1)
        Controls.Add(Guna2Button3)
        Controls.Add(ksandi)
        Controls.Add(sandi)
        Controls.Add(email)
        Controls.Add(nama)
        Controls.Add(PictureBox1)
        Name = "register"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Form1"
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        CType(ErrorProvider1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents nama As TextBox
    Friend WithEvents email As TextBox
    Friend WithEvents sandi As TextBox
    Friend WithEvents ksandi As TextBox
    Friend WithEvents Guna2Button3 As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents ErrorProvider1 As ErrorProvider
    Friend WithEvents Guna2Button1 As Guna.UI2.WinForms.Guna2Button
End Class

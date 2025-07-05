<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class login_admin
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(login_admin))
        Dim CustomizableEdges1 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges2 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        PictureBox1 = New PictureBox()
        emailadmin = New TextBox()
        passadmin = New TextBox()
        Guna2Button3 = New Guna.UI2.WinForms.Guna2Button()
        ErrorProvider1 = New ErrorProvider(components)
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        CType(ErrorProvider1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' PictureBox1
        ' 
        PictureBox1.BackgroundImage = CType(resources.GetObject("PictureBox1.BackgroundImage"), Image)
        PictureBox1.Location = New Point(0, -1)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(1462, 1068)
        PictureBox1.TabIndex = 0
        PictureBox1.TabStop = False
        ' 
        ' emailadmin
        ' 
        emailadmin.BackColor = SystemColors.ScrollBar
        emailadmin.BorderStyle = BorderStyle.FixedSingle
        emailadmin.Font = New Font("High Tower Text", 15F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        emailadmin.Location = New Point(493, 408)
        emailadmin.Name = "emailadmin"
        emailadmin.Size = New Size(459, 42)
        emailadmin.TabIndex = 8
        ' 
        ' passadmin
        ' 
        passadmin.BackColor = SystemColors.ScrollBar
        passadmin.BorderStyle = BorderStyle.FixedSingle
        passadmin.Font = New Font("High Tower Text", 15F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        passadmin.Location = New Point(493, 515)
        passadmin.Name = "passadmin"
        passadmin.PasswordChar = "*"c
        passadmin.Size = New Size(459, 42)
        passadmin.TabIndex = 9
        passadmin.UseSystemPasswordChar = True
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
        Guna2Button3.Location = New Point(620, 642)
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
        ' login_admin
        ' 
        AutoScaleDimensions = New SizeF(10F, 25F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1440, 1012)
        Controls.Add(Guna2Button3)
        Controls.Add(passadmin)
        Controls.Add(emailadmin)
        Controls.Add(PictureBox1)
        Name = "login_admin"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Login Admin"
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        CType(ErrorProvider1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents emailadmin As TextBox
    Friend WithEvents passadmin As TextBox
    Friend WithEvents Guna2Button3 As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents ErrorProvider1 As ErrorProvider
End Class

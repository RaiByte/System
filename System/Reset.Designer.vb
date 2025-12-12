<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Reset
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
        Me.components = New System.ComponentModel.Container()
        Me.Guna2GradientPanel1 = New Guna.UI2.WinForms.Guna2GradientPanel()
        Me.Guna2ShadowPanel1 = New Guna.UI2.WinForms.Guna2ShadowPanel()
        Me.passbx = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.OTPbtn = New Guna.UI2.WinForms.Guna2Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Username2txtbox = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Guna2ControlBox1 = New Guna.UI2.WinForms.Guna2ControlBox()
        Me.Guna2Elipse1 = New Guna.UI2.WinForms.Guna2Elipse(Me.components)
        Me.PasswordCB2 = New Guna.UI2.WinForms.Guna2CheckBox()
        Me.Backbtn = New Guna.UI2.WinForms.Guna2Button()
        Me.Guna2Elipse2 = New Guna.UI2.WinForms.Guna2Elipse(Me.components)
        Me.Guna2GradientPanel1.SuspendLayout()
        Me.Guna2ShadowPanel1.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Guna2GradientPanel1
        '
        Me.Guna2GradientPanel1.BorderRadius = 13
        Me.Guna2GradientPanel1.Controls.Add(Me.Guna2ShadowPanel1)
        Me.Guna2GradientPanel1.Controls.Add(Me.Panel1)
        Me.Guna2GradientPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Guna2GradientPanel1.FillColor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(42, Byte), Integer), CType(CType(82, Byte), Integer))
        Me.Guna2GradientPanel1.FillColor2 = System.Drawing.Color.FromArgb(CType(CType(58, Byte), Integer), CType(CType(176, Byte), Integer), CType(CType(158, Byte), Integer))
        Me.Guna2GradientPanel1.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical
        Me.Guna2GradientPanel1.Location = New System.Drawing.Point(0, 0)
        Me.Guna2GradientPanel1.Name = "Guna2GradientPanel1"
        Me.Guna2GradientPanel1.Size = New System.Drawing.Size(800, 687)
        Me.Guna2GradientPanel1.TabIndex = 16
        '
        'Guna2ShadowPanel1
        '
        Me.Guna2ShadowPanel1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Guna2ShadowPanel1.BackColor = System.Drawing.Color.Transparent
        Me.Guna2ShadowPanel1.Controls.Add(Me.PasswordCB2)
        Me.Guna2ShadowPanel1.Controls.Add(Me.passbx)
        Me.Guna2ShadowPanel1.Controls.Add(Me.Label3)
        Me.Guna2ShadowPanel1.Controls.Add(Me.OTPbtn)
        Me.Guna2ShadowPanel1.Controls.Add(Me.Label2)
        Me.Guna2ShadowPanel1.Controls.Add(Me.Username2txtbox)
        Me.Guna2ShadowPanel1.Controls.Add(Me.Label1)
        Me.Guna2ShadowPanel1.FillColor = System.Drawing.Color.White
        Me.Guna2ShadowPanel1.Location = New System.Drawing.Point(95, 99)
        Me.Guna2ShadowPanel1.Name = "Guna2ShadowPanel1"
        Me.Guna2ShadowPanel1.ShadowColor = System.Drawing.Color.Black
        Me.Guna2ShadowPanel1.ShadowShift = 30
        Me.Guna2ShadowPanel1.Size = New System.Drawing.Size(611, 494)
        Me.Guna2ShadowPanel1.TabIndex = 15
        '
        'passbx
        '
        Me.passbx.Font = New System.Drawing.Font("Segoe UI", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.passbx.Location = New System.Drawing.Point(161, 285)
        Me.passbx.Name = "passbx"
        Me.passbx.Size = New System.Drawing.Size(308, 38)
        Me.passbx.TabIndex = 17
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Segoe UI", 16.0!, System.Drawing.FontStyle.Bold)
        Me.Label3.Location = New System.Drawing.Point(154, 244)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(285, 37)
        Me.Label3.TabIndex = 16
        Me.Label3.Text = "Enter New Password:"
        '
        'OTPbtn
        '
        Me.OTPbtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.OTPbtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.OTPbtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.OTPbtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.OTPbtn.FillColor = System.Drawing.Color.FromArgb(CType(CType(58, Byte), Integer), CType(CType(176, Byte), Integer), CType(CType(158, Byte), Integer))
        Me.OTPbtn.Font = New System.Drawing.Font("Segoe UI", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.OTPbtn.ForeColor = System.Drawing.Color.White
        Me.OTPbtn.Location = New System.Drawing.Point(161, 349)
        Me.OTPbtn.Name = "OTPbtn"
        Me.OTPbtn.Size = New System.Drawing.Size(308, 45)
        Me.OTPbtn.TabIndex = 15
        Me.OTPbtn.Text = "Reset"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 25.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(42, Byte), Integer), CType(CType(82, Byte), Integer))
        Me.Label2.Location = New System.Drawing.Point(142, 43)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(336, 59)
        Me.Label2.TabIndex = 14
        Me.Label2.Text = "Reset Password"
        '
        'Username2txtbox
        '
        Me.Username2txtbox.Font = New System.Drawing.Font("Segoe UI", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Username2txtbox.Location = New System.Drawing.Point(161, 203)
        Me.Username2txtbox.Name = "Username2txtbox"
        Me.Username2txtbox.Size = New System.Drawing.Size(308, 38)
        Me.Username2txtbox.TabIndex = 2
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(154, 162)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(84, 41)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "OTP:"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Black
        Me.Panel1.Controls.Add(Me.Backbtn)
        Me.Panel1.Controls.Add(Me.Guna2ControlBox1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(800, 41)
        Me.Panel1.TabIndex = 14
        '
        'Guna2ControlBox1
        '
        Me.Guna2ControlBox1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Guna2ControlBox1.FillColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Guna2ControlBox1.IconColor = System.Drawing.Color.White
        Me.Guna2ControlBox1.Location = New System.Drawing.Point(743, 6)
        Me.Guna2ControlBox1.Name = "Guna2ControlBox1"
        Me.Guna2ControlBox1.Size = New System.Drawing.Size(45, 29)
        Me.Guna2ControlBox1.TabIndex = 0
        '
        'Guna2Elipse1
        '
        Me.Guna2Elipse1.BorderRadius = 30
        Me.Guna2Elipse1.TargetControl = Me.OTPbtn
        '
        'PasswordCB2
        '
        Me.PasswordCB2.AutoSize = True
        Me.PasswordCB2.CheckedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.PasswordCB2.CheckedState.BorderRadius = 0
        Me.PasswordCB2.CheckedState.BorderThickness = 0
        Me.PasswordCB2.CheckedState.FillColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.PasswordCB2.Font = New System.Drawing.Font("Segoe UI Semibold", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PasswordCB2.Location = New System.Drawing.Point(161, 326)
        Me.PasswordCB2.Name = "PasswordCB2"
        Me.PasswordCB2.Size = New System.Drawing.Size(125, 21)
        Me.PasswordCB2.TabIndex = 18
        Me.PasswordCB2.Text = "Show Password"
        Me.PasswordCB2.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(125, Byte), Integer), CType(CType(137, Byte), Integer), CType(CType(149, Byte), Integer))
        Me.PasswordCB2.UncheckedState.BorderRadius = 0
        Me.PasswordCB2.UncheckedState.BorderThickness = 0
        Me.PasswordCB2.UncheckedState.FillColor = System.Drawing.Color.FromArgb(CType(CType(125, Byte), Integer), CType(CType(137, Byte), Integer), CType(CType(149, Byte), Integer))
        '
        'Backbtn
        '
        Me.Backbtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.Backbtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.Backbtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.Backbtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.Backbtn.FillColor = System.Drawing.Color.Red
        Me.Backbtn.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Backbtn.ForeColor = System.Drawing.Color.White
        Me.Backbtn.Location = New System.Drawing.Point(12, 6)
        Me.Backbtn.Name = "Backbtn"
        Me.Backbtn.Size = New System.Drawing.Size(95, 29)
        Me.Backbtn.TabIndex = 2
        Me.Backbtn.Text = "Back"
        '
        'Guna2Elipse2
        '
        Me.Guna2Elipse2.BorderRadius = 15
        Me.Guna2Elipse2.TargetControl = Me.Backbtn
        '
        'Reset
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 687)
        Me.Controls.Add(Me.Guna2GradientPanel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Reset"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Reset"
        Me.Guna2GradientPanel1.ResumeLayout(False)
        Me.Guna2ShadowPanel1.ResumeLayout(False)
        Me.Guna2ShadowPanel1.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Guna2GradientPanel1 As Guna.UI2.WinForms.Guna2GradientPanel
    Friend WithEvents Guna2ShadowPanel1 As Guna.UI2.WinForms.Guna2ShadowPanel
    Friend WithEvents OTPbtn As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents Label2 As Label
    Friend WithEvents Username2txtbox As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Guna2ControlBox1 As Guna.UI2.WinForms.Guna2ControlBox
    Friend WithEvents passbx As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Guna2Elipse1 As Guna.UI2.WinForms.Guna2Elipse
    Friend WithEvents PasswordCB2 As Guna.UI2.WinForms.Guna2CheckBox
    Friend WithEvents Backbtn As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents Guna2Elipse2 As Guna.UI2.WinForms.Guna2Elipse
End Class

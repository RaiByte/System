<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Report
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
        Me.components = New System.ComponentModel.Container()
        Me.Descriptiontxtbox = New System.Windows.Forms.TextBox()
        Me.locationtxtbox = New System.Windows.Forms.TextBox()
        Me.Incidenttxtbox = New System.Windows.Forms.TextBox()
        Me.Descriptionlbl = New System.Windows.Forms.Label()
        Me.Locationlbl = New System.Windows.Forms.Label()
        Me.typelbl = New System.Windows.Forms.Label()
        Me.Guna2GradientPanel1 = New Guna.UI2.WinForms.Guna2GradientPanel()
        Me.Guna2ShadowPanel1 = New Guna.UI2.WinForms.Guna2ShadowPanel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Submit = New Guna.UI2.WinForms.Guna2GradientButton()
        Me.Back = New Guna.UI2.WinForms.Guna2GradientButton()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Guna2ControlBox1 = New Guna.UI2.WinForms.Guna2ControlBox()
        Me.Guna2Elipse1 = New Guna.UI2.WinForms.Guna2Elipse(Me.components)
        Me.Guna2Elipse2 = New Guna.UI2.WinForms.Guna2Elipse(Me.components)
        Me.Howlbl = New System.Windows.Forms.Label()
        Me.Howtxtbox = New System.Windows.Forms.TextBox()
        Me.Wholbl = New System.Windows.Forms.Label()
        Me.Whotxtbox = New System.Windows.Forms.TextBox()
        Me.Guna2GradientPanel1.SuspendLayout()
        Me.Guna2ShadowPanel1.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Descriptiontxtbox
        '
        Me.Descriptiontxtbox.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Descriptiontxtbox.Location = New System.Drawing.Point(230, 283)
        Me.Descriptiontxtbox.Multiline = True
        Me.Descriptiontxtbox.Name = "Descriptiontxtbox"
        Me.Descriptiontxtbox.Size = New System.Drawing.Size(313, 68)
        Me.Descriptiontxtbox.TabIndex = 8
        '
        'locationtxtbox
        '
        Me.locationtxtbox.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.locationtxtbox.Location = New System.Drawing.Point(229, 150)
        Me.locationtxtbox.Name = "locationtxtbox"
        Me.locationtxtbox.Size = New System.Drawing.Size(313, 27)
        Me.locationtxtbox.TabIndex = 6
        '
        'Incidenttxtbox
        '
        Me.Incidenttxtbox.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Incidenttxtbox.Location = New System.Drawing.Point(229, 108)
        Me.Incidenttxtbox.Name = "Incidenttxtbox"
        Me.Incidenttxtbox.ReadOnly = True
        Me.Incidenttxtbox.Size = New System.Drawing.Size(313, 27)
        Me.Incidenttxtbox.TabIndex = 5
        Me.Incidenttxtbox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Descriptionlbl
        '
        Me.Descriptionlbl.AutoSize = True
        Me.Descriptionlbl.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Descriptionlbl.Location = New System.Drawing.Point(54, 301)
        Me.Descriptionlbl.Name = "Descriptionlbl"
        Me.Descriptionlbl.Size = New System.Drawing.Size(120, 28)
        Me.Descriptionlbl.TabIndex = 4
        Me.Descriptionlbl.Text = "Description:"
        '
        'Locationlbl
        '
        Me.Locationlbl.AutoSize = True
        Me.Locationlbl.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Locationlbl.Location = New System.Drawing.Point(54, 146)
        Me.Locationlbl.Name = "Locationlbl"
        Me.Locationlbl.Size = New System.Drawing.Size(94, 28)
        Me.Locationlbl.TabIndex = 2
        Me.Locationlbl.Text = "Location:"
        '
        'typelbl
        '
        Me.typelbl.AutoSize = True
        Me.typelbl.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.typelbl.Location = New System.Drawing.Point(54, 104)
        Me.typelbl.Name = "typelbl"
        Me.typelbl.Size = New System.Drawing.Size(140, 28)
        Me.typelbl.TabIndex = 1
        Me.typelbl.Text = "Incident Type:"
        '
        'Guna2GradientPanel1
        '
        Me.Guna2GradientPanel1.Controls.Add(Me.Guna2ShadowPanel1)
        Me.Guna2GradientPanel1.Controls.Add(Me.Panel1)
        Me.Guna2GradientPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Guna2GradientPanel1.FillColor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(42, Byte), Integer), CType(CType(82, Byte), Integer))
        Me.Guna2GradientPanel1.FillColor2 = System.Drawing.Color.FromArgb(CType(CType(58, Byte), Integer), CType(CType(176, Byte), Integer), CType(CType(158, Byte), Integer))
        Me.Guna2GradientPanel1.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical
        Me.Guna2GradientPanel1.Location = New System.Drawing.Point(0, 0)
        Me.Guna2GradientPanel1.Name = "Guna2GradientPanel1"
        Me.Guna2GradientPanel1.Size = New System.Drawing.Size(800, 800)
        Me.Guna2GradientPanel1.TabIndex = 1
        '
        'Guna2ShadowPanel1
        '
        Me.Guna2ShadowPanel1.BackColor = System.Drawing.Color.Transparent
        Me.Guna2ShadowPanel1.Controls.Add(Me.Wholbl)
        Me.Guna2ShadowPanel1.Controls.Add(Me.Whotxtbox)
        Me.Guna2ShadowPanel1.Controls.Add(Me.Howlbl)
        Me.Guna2ShadowPanel1.Controls.Add(Me.Howtxtbox)
        Me.Guna2ShadowPanel1.Controls.Add(Me.Label1)
        Me.Guna2ShadowPanel1.Controls.Add(Me.Submit)
        Me.Guna2ShadowPanel1.Controls.Add(Me.Back)
        Me.Guna2ShadowPanel1.Controls.Add(Me.typelbl)
        Me.Guna2ShadowPanel1.Controls.Add(Me.Locationlbl)
        Me.Guna2ShadowPanel1.Controls.Add(Me.Descriptiontxtbox)
        Me.Guna2ShadowPanel1.Controls.Add(Me.Descriptionlbl)
        Me.Guna2ShadowPanel1.Controls.Add(Me.locationtxtbox)
        Me.Guna2ShadowPanel1.Controls.Add(Me.Incidenttxtbox)
        Me.Guna2ShadowPanel1.FillColor = System.Drawing.Color.White
        Me.Guna2ShadowPanel1.Location = New System.Drawing.Point(92, 116)
        Me.Guna2ShadowPanel1.Name = "Guna2ShadowPanel1"
        Me.Guna2ShadowPanel1.Radius = 10
        Me.Guna2ShadowPanel1.ShadowColor = System.Drawing.Color.Black
        Me.Guna2ShadowPanel1.ShadowShift = 20
        Me.Guna2ShadowPanel1.Size = New System.Drawing.Size(598, 572)
        Me.Guna2ShadowPanel1.TabIndex = 17
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 22.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(166, 33)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(270, 50)
        Me.Label1.TabIndex = 11
        Me.Label1.Text = "Report Details"
        '
        'Submit
        '
        Me.Submit.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.Submit.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.Submit.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.Submit.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.Submit.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.Submit.FillColor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(42, Byte), Integer), CType(CType(82, Byte), Integer))
        Me.Submit.FillColor2 = System.Drawing.Color.FromArgb(CType(CType(58, Byte), Integer), CType(CType(176, Byte), Integer), CType(CType(158, Byte), Integer))
        Me.Submit.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Submit.ForeColor = System.Drawing.Color.White
        Me.Submit.Location = New System.Drawing.Point(304, 481)
        Me.Submit.Name = "Submit"
        Me.Submit.Size = New System.Drawing.Size(180, 45)
        Me.Submit.TabIndex = 10
        Me.Submit.Text = "Submit"
        '
        'Back
        '
        Me.Back.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.Back.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.Back.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.Back.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.Back.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.Back.FillColor = System.Drawing.Color.Red
        Me.Back.FillColor2 = System.Drawing.Color.Black
        Me.Back.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Back.ForeColor = System.Drawing.Color.White
        Me.Back.Location = New System.Drawing.Point(96, 481)
        Me.Back.Name = "Back"
        Me.Back.Size = New System.Drawing.Size(180, 45)
        Me.Back.TabIndex = 9
        Me.Back.Text = "Back"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Black
        Me.Panel1.Controls.Add(Me.Guna2ControlBox1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(800, 41)
        Me.Panel1.TabIndex = 16
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
        Me.Guna2Elipse1.TargetControl = Me.Submit
        '
        'Guna2Elipse2
        '
        Me.Guna2Elipse2.BorderRadius = 30
        Me.Guna2Elipse2.TargetControl = Me.Back
        '
        'Howlbl
        '
        Me.Howlbl.AutoSize = True
        Me.Howlbl.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Howlbl.Location = New System.Drawing.Point(56, 226)
        Me.Howlbl.Name = "Howlbl"
        Me.Howlbl.Size = New System.Drawing.Size(59, 28)
        Me.Howlbl.TabIndex = 12
        Me.Howlbl.Text = "How:"
        '
        'Howtxtbox
        '
        Me.Howtxtbox.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Howtxtbox.Location = New System.Drawing.Point(230, 196)
        Me.Howtxtbox.Multiline = True
        Me.Howtxtbox.Name = "Howtxtbox"
        Me.Howtxtbox.Size = New System.Drawing.Size(313, 68)
        Me.Howtxtbox.TabIndex = 13
        '
        'Wholbl
        '
        Me.Wholbl.AutoSize = True
        Me.Wholbl.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Wholbl.Location = New System.Drawing.Point(55, 401)
        Me.Wholbl.Name = "Wholbl"
        Me.Wholbl.Size = New System.Drawing.Size(60, 28)
        Me.Wholbl.TabIndex = 14
        Me.Wholbl.Text = "Who:"
        '
        'Whotxtbox
        '
        Me.Whotxtbox.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Whotxtbox.Location = New System.Drawing.Point(230, 376)
        Me.Whotxtbox.Multiline = True
        Me.Whotxtbox.Name = "Whotxtbox"
        Me.Whotxtbox.Size = New System.Drawing.Size(313, 68)
        Me.Whotxtbox.TabIndex = 15
        '
        'Report
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.LightBlue
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(800, 800)
        Me.Controls.Add(Me.Guna2GradientPanel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Report"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Report"
        Me.Guna2GradientPanel1.ResumeLayout(False)
        Me.Guna2ShadowPanel1.ResumeLayout(False)
        Me.Guna2ShadowPanel1.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Descriptionlbl As Label
    Friend WithEvents Locationlbl As Label
    Friend WithEvents typelbl As Label
    Friend WithEvents Descriptiontxtbox As TextBox
    Friend WithEvents locationtxtbox As TextBox
    Friend WithEvents Incidenttxtbox As TextBox
    Friend WithEvents Guna2GradientPanel1 As Guna.UI2.WinForms.Guna2GradientPanel
    Friend WithEvents Guna2ShadowPanel1 As Guna.UI2.WinForms.Guna2ShadowPanel
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Guna2ControlBox1 As Guna.UI2.WinForms.Guna2ControlBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Submit As Guna.UI2.WinForms.Guna2GradientButton
    Friend WithEvents Back As Guna.UI2.WinForms.Guna2GradientButton
    Friend WithEvents Guna2Elipse1 As Guna.UI2.WinForms.Guna2Elipse
    Friend WithEvents Guna2Elipse2 As Guna.UI2.WinForms.Guna2Elipse
    Friend WithEvents Wholbl As Label
    Friend WithEvents Whotxtbox As TextBox
    Friend WithEvents Howlbl As Label
    Friend WithEvents Howtxtbox As TextBox
End Class

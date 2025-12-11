<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class IncidentDetailsForm
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
        Me.Howlbl = New System.Windows.Forms.Label()
        Me.DateReportedTxt = New System.Windows.Forms.TextBox()
        Me.Guna2Elipse2 = New Guna.UI2.WinForms.Guna2Elipse(Me.components)
        Me.Closebtn = New Guna.UI2.WinForms.Guna2GradientButton()
        Me.Guna2Elipse1 = New Guna.UI2.WinForms.Guna2Elipse(Me.components)
        Me.Guna2ControlBox1 = New Guna.UI2.WinForms.Guna2ControlBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.IncidentIdLbl = New System.Windows.Forms.Label()
        Me.Guna2GradientPanel1 = New Guna.UI2.WinForms.Guna2GradientPanel()
        Me.Guna2ShadowPanel1 = New Guna.UI2.WinForms.Guna2ShadowPanel()
        Me.ReporterNameTxt = New System.Windows.Forms.TextBox()
        Me.typelbl = New System.Windows.Forms.Label()
        Me.Locationlbl = New System.Windows.Forms.Label()
        Me.DescriptionTxt = New System.Windows.Forms.TextBox()
        Me.Descriptionlbl = New System.Windows.Forms.Label()
        Me.LocationTxt = New System.Windows.Forms.TextBox()
        Me.IncidentTypeTxt = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel1.SuspendLayout()
        Me.Guna2GradientPanel1.SuspendLayout()
        Me.Guna2ShadowPanel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Howlbl
        '
        Me.Howlbl.AutoSize = True
        Me.Howlbl.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Howlbl.Location = New System.Drawing.Point(56, 307)
        Me.Howlbl.Name = "Howlbl"
        Me.Howlbl.Size = New System.Drawing.Size(149, 28)
        Me.Howlbl.TabIndex = 12
        Me.Howlbl.Text = "Date Reported:"
        '
        'DateReportedTxt
        '
        Me.DateReportedTxt.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DateReportedTxt.Location = New System.Drawing.Point(230, 302)
        Me.DateReportedTxt.Multiline = True
        Me.DateReportedTxt.Name = "DateReportedTxt"
        Me.DateReportedTxt.ReadOnly = True
        Me.DateReportedTxt.Size = New System.Drawing.Size(313, 33)
        Me.DateReportedTxt.TabIndex = 13
        '
        'Guna2Elipse2
        '
        Me.Guna2Elipse2.BorderRadius = 30
        Me.Guna2Elipse2.TargetControl = Me.Closebtn
        '
        'Closebtn
        '
        Me.Closebtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.Closebtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.Closebtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.Closebtn.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.Closebtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.Closebtn.FillColor = System.Drawing.Color.Red
        Me.Closebtn.FillColor2 = System.Drawing.Color.Black
        Me.Closebtn.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Closebtn.ForeColor = System.Drawing.Color.White
        Me.Closebtn.Location = New System.Drawing.Point(210, 483)
        Me.Closebtn.Name = "Closebtn"
        Me.Closebtn.Size = New System.Drawing.Size(180, 45)
        Me.Closebtn.TabIndex = 9
        Me.Closebtn.Text = "Close"
        '
        'Guna2Elipse1
        '
        Me.Guna2Elipse1.BorderRadius = 30
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
        'IncidentIdLbl
        '
        Me.IncidentIdLbl.AutoSize = True
        Me.IncidentIdLbl.Font = New System.Drawing.Font("Segoe UI", 22.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.IncidentIdLbl.Location = New System.Drawing.Point(277, 29)
        Me.IncidentIdLbl.Name = "IncidentIdLbl"
        Me.IncidentIdLbl.Size = New System.Drawing.Size(252, 50)
        Me.IncidentIdLbl.TabIndex = 11
        Me.IncidentIdLbl.Text = "IncidentIdLbl"
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
        Me.Guna2GradientPanel1.TabIndex = 2
        '
        'Guna2ShadowPanel1
        '
        Me.Guna2ShadowPanel1.BackColor = System.Drawing.Color.Transparent
        Me.Guna2ShadowPanel1.Controls.Add(Me.IncidentTypeTxt)
        Me.Guna2ShadowPanel1.Controls.Add(Me.Label1)
        Me.Guna2ShadowPanel1.Controls.Add(Me.ReporterNameTxt)
        Me.Guna2ShadowPanel1.Controls.Add(Me.Howlbl)
        Me.Guna2ShadowPanel1.Controls.Add(Me.DateReportedTxt)
        Me.Guna2ShadowPanel1.Controls.Add(Me.IncidentIdLbl)
        Me.Guna2ShadowPanel1.Controls.Add(Me.Closebtn)
        Me.Guna2ShadowPanel1.Controls.Add(Me.typelbl)
        Me.Guna2ShadowPanel1.Controls.Add(Me.Locationlbl)
        Me.Guna2ShadowPanel1.Controls.Add(Me.DescriptionTxt)
        Me.Guna2ShadowPanel1.Controls.Add(Me.Descriptionlbl)
        Me.Guna2ShadowPanel1.Controls.Add(Me.LocationTxt)
        Me.Guna2ShadowPanel1.FillColor = System.Drawing.Color.White
        Me.Guna2ShadowPanel1.Location = New System.Drawing.Point(92, 116)
        Me.Guna2ShadowPanel1.Name = "Guna2ShadowPanel1"
        Me.Guna2ShadowPanel1.Radius = 10
        Me.Guna2ShadowPanel1.ShadowColor = System.Drawing.Color.Black
        Me.Guna2ShadowPanel1.ShadowShift = 20
        Me.Guna2ShadowPanel1.Size = New System.Drawing.Size(598, 572)
        Me.Guna2ShadowPanel1.TabIndex = 17
        '
        'ReporterNameTxt
        '
        Me.ReporterNameTxt.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ReporterNameTxt.Location = New System.Drawing.Point(229, 104)
        Me.ReporterNameTxt.Name = "ReporterNameTxt"
        Me.ReporterNameTxt.ReadOnly = True
        Me.ReporterNameTxt.Size = New System.Drawing.Size(313, 27)
        Me.ReporterNameTxt.TabIndex = 16
        '
        'typelbl
        '
        Me.typelbl.AutoSize = True
        Me.typelbl.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.typelbl.Location = New System.Drawing.Point(54, 104)
        Me.typelbl.Name = "typelbl"
        Me.typelbl.Size = New System.Drawing.Size(156, 28)
        Me.typelbl.TabIndex = 1
        Me.typelbl.Text = "Reporter Name:"
        '
        'Locationlbl
        '
        Me.Locationlbl.AutoSize = True
        Me.Locationlbl.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Locationlbl.Location = New System.Drawing.Point(54, 227)
        Me.Locationlbl.Name = "Locationlbl"
        Me.Locationlbl.Size = New System.Drawing.Size(94, 28)
        Me.Locationlbl.TabIndex = 2
        Me.Locationlbl.Text = "Location:"
        '
        'DescriptionTxt
        '
        Me.DescriptionTxt.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DescriptionTxt.Location = New System.Drawing.Point(230, 364)
        Me.DescriptionTxt.Multiline = True
        Me.DescriptionTxt.Name = "DescriptionTxt"
        Me.DescriptionTxt.ReadOnly = True
        Me.DescriptionTxt.Size = New System.Drawing.Size(313, 68)
        Me.DescriptionTxt.TabIndex = 8
        '
        'Descriptionlbl
        '
        Me.Descriptionlbl.AutoSize = True
        Me.Descriptionlbl.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Descriptionlbl.Location = New System.Drawing.Point(54, 382)
        Me.Descriptionlbl.Name = "Descriptionlbl"
        Me.Descriptionlbl.Size = New System.Drawing.Size(120, 28)
        Me.Descriptionlbl.TabIndex = 4
        Me.Descriptionlbl.Text = "Description:"
        '
        'LocationTxt
        '
        Me.LocationTxt.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LocationTxt.Location = New System.Drawing.Point(229, 231)
        Me.LocationTxt.Name = "LocationTxt"
        Me.LocationTxt.ReadOnly = True
        Me.LocationTxt.Size = New System.Drawing.Size(313, 27)
        Me.LocationTxt.TabIndex = 6
        '
        'IncidentTypeTxt
        '
        Me.IncidentTypeTxt.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.IncidentTypeTxt.Location = New System.Drawing.Point(230, 151)
        Me.IncidentTypeTxt.Name = "IncidentTypeTxt"
        Me.IncidentTypeTxt.ReadOnly = True
        Me.IncidentTypeTxt.Size = New System.Drawing.Size(313, 27)
        Me.IncidentTypeTxt.TabIndex = 18
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(55, 151)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(156, 28)
        Me.Label1.TabIndex = 17
        Me.Label1.Text = "Reporter Name:"
        '
        'IncidentDetailsForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 800)
        Me.Controls.Add(Me.Guna2GradientPanel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "IncidentDetailsForm"
        Me.Text = "IncidentDetailsForm"
        Me.Panel1.ResumeLayout(False)
        Me.Guna2GradientPanel1.ResumeLayout(False)
        Me.Guna2ShadowPanel1.ResumeLayout(False)
        Me.Guna2ShadowPanel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Howlbl As Label
    Friend WithEvents DateReportedTxt As TextBox
    Friend WithEvents Guna2Elipse2 As Guna.UI2.WinForms.Guna2Elipse
    Friend WithEvents Closebtn As Guna.UI2.WinForms.Guna2GradientButton
    Friend WithEvents Guna2Elipse1 As Guna.UI2.WinForms.Guna2Elipse
    Friend WithEvents Guna2ControlBox1 As Guna.UI2.WinForms.Guna2ControlBox
    Friend WithEvents Panel1 As Panel
    Friend WithEvents IncidentIdLbl As Label
    Friend WithEvents Guna2GradientPanel1 As Guna.UI2.WinForms.Guna2GradientPanel
    Friend WithEvents Guna2ShadowPanel1 As Guna.UI2.WinForms.Guna2ShadowPanel
    Friend WithEvents ReporterNameTxt As TextBox
    Friend WithEvents typelbl As Label
    Friend WithEvents Locationlbl As Label
    Friend WithEvents DescriptionTxt As TextBox
    Friend WithEvents Descriptionlbl As Label
    Friend WithEvents LocationTxt As TextBox
    Friend WithEvents IncidentTypeTxt As TextBox
    Friend WithEvents Label1 As Label
End Class

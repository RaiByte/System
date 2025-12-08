<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AboutUs
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(AboutUs))
        Me.Guna2GradientPanel1 = New Guna.UI2.WinForms.Guna2GradientPanel()
        Me.Guna2Panel1 = New Guna.UI2.WinForms.Guna2Panel()
        Me.Guna2PictureBox1 = New Guna.UI2.WinForms.Guna2PictureBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.PanelBttn = New Guna.UI2.WinForms.Guna2GradientPanel()
        Me.Contactbtnn = New Guna.UI2.WinForms.Guna2GradientButton()
        Me.Profbtn = New Guna.UI2.WinForms.Guna2GradientButton()
        Me.hmbtn = New Guna.UI2.WinForms.Guna2GradientButton()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Guna2ControlBox1 = New Guna.UI2.WinForms.Guna2ControlBox()
        Me.Guna2Elipse1 = New Guna.UI2.WinForms.Guna2Elipse(Me.components)
        Me.Guna2GradientPanel1.SuspendLayout()
        Me.Guna2Panel1.SuspendLayout()
        CType(Me.Guna2PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelBttn.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Guna2GradientPanel1
        '
        Me.Guna2GradientPanel1.Controls.Add(Me.Guna2Panel1)
        Me.Guna2GradientPanel1.Controls.Add(Me.PanelBttn)
        Me.Guna2GradientPanel1.Controls.Add(Me.Panel1)
        Me.Guna2GradientPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Guna2GradientPanel1.FillColor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(42, Byte), Integer), CType(CType(82, Byte), Integer))
        Me.Guna2GradientPanel1.FillColor2 = System.Drawing.Color.FromArgb(CType(CType(58, Byte), Integer), CType(CType(176, Byte), Integer), CType(CType(158, Byte), Integer))
        Me.Guna2GradientPanel1.Location = New System.Drawing.Point(0, 0)
        Me.Guna2GradientPanel1.Name = "Guna2GradientPanel1"
        Me.Guna2GradientPanel1.Size = New System.Drawing.Size(783, 853)
        Me.Guna2GradientPanel1.TabIndex = 0
        '
        'Guna2Panel1
        '
        Me.Guna2Panel1.Controls.Add(Me.Guna2PictureBox1)
        Me.Guna2Panel1.Controls.Add(Me.Label1)
        Me.Guna2Panel1.FillColor = System.Drawing.Color.White
        Me.Guna2Panel1.Location = New System.Drawing.Point(131, 110)
        Me.Guna2Panel1.Name = "Guna2Panel1"
        Me.Guna2Panel1.Size = New System.Drawing.Size(541, 588)
        Me.Guna2Panel1.TabIndex = 19
        '
        'Guna2PictureBox1
        '
        Me.Guna2PictureBox1.BackColor = System.Drawing.Color.Transparent
        Me.Guna2PictureBox1.BackgroundImage = CType(resources.GetObject("Guna2PictureBox1.BackgroundImage"), System.Drawing.Image)
        Me.Guna2PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Guna2PictureBox1.FillColor = System.Drawing.Color.Transparent
        Me.Guna2PictureBox1.ImageRotate = 0!
        Me.Guna2PictureBox1.Location = New System.Drawing.Point(125, 3)
        Me.Guna2PictureBox1.Name = "Guna2PictureBox1"
        Me.Guna2PictureBox1.Size = New System.Drawing.Size(300, 283)
        Me.Guna2PictureBox1.TabIndex = 1
        Me.Guna2PictureBox1.TabStop = False
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.White
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(5, 289)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(535, 209)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = resources.GetString("Label1.Text")
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'PanelBttn
        '
        Me.PanelBttn.BackColor = System.Drawing.Color.Transparent
        Me.PanelBttn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.PanelBttn.BorderRadius = 20
        Me.PanelBttn.BorderThickness = 20
        Me.PanelBttn.Controls.Add(Me.Contactbtnn)
        Me.PanelBttn.Controls.Add(Me.Profbtn)
        Me.PanelBttn.Controls.Add(Me.hmbtn)
        Me.PanelBttn.FillColor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(42, Byte), Integer), CType(CType(82, Byte), Integer))
        Me.PanelBttn.FillColor2 = System.Drawing.Color.FromArgb(CType(CType(58, Byte), Integer), CType(CType(176, Byte), Integer), CType(CType(158, Byte), Integer))
        Me.PanelBttn.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.BackwardDiagonal
        Me.PanelBttn.Location = New System.Drawing.Point(-14, 755)
        Me.PanelBttn.Name = "PanelBttn"
        Me.PanelBttn.Size = New System.Drawing.Size(817, 100)
        Me.PanelBttn.TabIndex = 18
        '
        'Contactbtnn
        '
        Me.Contactbtnn.BackgroundImage = CType(resources.GetObject("Contactbtnn.BackgroundImage"), System.Drawing.Image)
        Me.Contactbtnn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.Contactbtnn.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.Contactbtnn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.Contactbtnn.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.Contactbtnn.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.Contactbtnn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.Contactbtnn.FillColor = System.Drawing.Color.Empty
        Me.Contactbtnn.FillColor2 = System.Drawing.Color.Empty
        Me.Contactbtnn.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.Contactbtnn.ForeColor = System.Drawing.Color.White
        Me.Contactbtnn.Location = New System.Drawing.Point(672, 10)
        Me.Contactbtnn.Name = "Contactbtnn"
        Me.Contactbtnn.Size = New System.Drawing.Size(113, 73)
        Me.Contactbtnn.TabIndex = 18
        '
        'Profbtn
        '
        Me.Profbtn.BackgroundImage = CType(resources.GetObject("Profbtn.BackgroundImage"), System.Drawing.Image)
        Me.Profbtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.Profbtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.Profbtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.Profbtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.Profbtn.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.Profbtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.Profbtn.FillColor = System.Drawing.Color.Empty
        Me.Profbtn.FillColor2 = System.Drawing.Color.Empty
        Me.Profbtn.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.Profbtn.ForeColor = System.Drawing.Color.White
        Me.Profbtn.Location = New System.Drawing.Point(367, 10)
        Me.Profbtn.Name = "Profbtn"
        Me.Profbtn.Size = New System.Drawing.Size(113, 73)
        Me.Profbtn.TabIndex = 17
        '
        'hmbtn
        '
        Me.hmbtn.BackgroundImage = CType(resources.GetObject("hmbtn.BackgroundImage"), System.Drawing.Image)
        Me.hmbtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.hmbtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.hmbtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.hmbtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.hmbtn.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.hmbtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.hmbtn.FillColor = System.Drawing.Color.Empty
        Me.hmbtn.FillColor2 = System.Drawing.Color.Empty
        Me.hmbtn.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.hmbtn.ForeColor = System.Drawing.Color.White
        Me.hmbtn.Location = New System.Drawing.Point(33, 10)
        Me.hmbtn.Name = "hmbtn"
        Me.hmbtn.Size = New System.Drawing.Size(113, 73)
        Me.hmbtn.TabIndex = 16
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Black
        Me.Panel1.Controls.Add(Me.Guna2ControlBox1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(783, 41)
        Me.Panel1.TabIndex = 13
        '
        'Guna2ControlBox1
        '
        Me.Guna2ControlBox1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Guna2ControlBox1.FillColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Guna2ControlBox1.IconColor = System.Drawing.Color.White
        Me.Guna2ControlBox1.Location = New System.Drawing.Point(726, 6)
        Me.Guna2ControlBox1.Name = "Guna2ControlBox1"
        Me.Guna2ControlBox1.Size = New System.Drawing.Size(45, 29)
        Me.Guna2ControlBox1.TabIndex = 0
        '
        'Guna2Elipse1
        '
        Me.Guna2Elipse1.BorderRadius = 20
        Me.Guna2Elipse1.TargetControl = Me.Guna2Panel1
        '
        'AboutUs
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(783, 853)
        Me.Controls.Add(Me.Guna2GradientPanel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "AboutUs"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "AboutUs"
        Me.Guna2GradientPanel1.ResumeLayout(False)
        Me.Guna2Panel1.ResumeLayout(False)
        CType(Me.Guna2PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelBttn.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Guna2GradientPanel1 As Guna.UI2.WinForms.Guna2GradientPanel
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Guna2ControlBox1 As Guna.UI2.WinForms.Guna2ControlBox
    Friend WithEvents PanelBttn As Guna.UI2.WinForms.Guna2GradientPanel
    Friend WithEvents Contactbtnn As Guna.UI2.WinForms.Guna2GradientButton
    Friend WithEvents Profbtn As Guna.UI2.WinForms.Guna2GradientButton
    Friend WithEvents hmbtn As Guna.UI2.WinForms.Guna2GradientButton
    Friend WithEvents Guna2Panel1 As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents Guna2PictureBox1 As Guna.UI2.WinForms.Guna2PictureBox
    Friend WithEvents Guna2Elipse1 As Guna.UI2.WinForms.Guna2Elipse
End Class

<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Profile
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Profile))
        Me.Greetingslbl = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.FNamelbl = New System.Windows.Forms.Label()
        Me.Addresslbl = New System.Windows.Forms.Label()
        Me.Emaillbl = New System.Windows.Forms.Label()
        Me.Numberlbl = New System.Windows.Forms.Label()
        Me.LNametxtbox = New System.Windows.Forms.TextBox()
        Me.Addresstxtbox = New System.Windows.Forms.TextBox()
        Me.Numbertxtbox = New System.Windows.Forms.TextBox()
        Me.Emailtxtbox = New System.Windows.Forms.TextBox()
        Me.Guna2GradientPanel1 = New Guna.UI2.WinForms.Guna2GradientPanel()
        Me.PanelBttn = New Guna.UI2.WinForms.Guna2GradientPanel()
        Me.Aboutbtn = New Guna.UI2.WinForms.Guna2GradientButton()
        Me.Contactbtn = New Guna.UI2.WinForms.Guna2GradientButton()
        Me.HomeBtn = New Guna.UI2.WinForms.Guna2GradientButton()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.LogOutbtn = New Guna.UI2.WinForms.Guna2Button()
        Me.Guna2ControlBox1 = New Guna.UI2.WinForms.Guna2ControlBox()
        Me.Guna2ShadowPanel1 = New Guna.UI2.WinForms.Guna2ShadowPanel()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Middletextbox = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.FNametxtbox = New System.Windows.Forms.TextBox()
        Me.GunaUpdate = New Guna.UI2.WinForms.Guna2GradientButton()
        Me.GunaSave = New Guna.UI2.WinForms.Guna2GradientButton()
        Me.Guna2Elipse1 = New Guna.UI2.WinForms.Guna2Elipse(Me.components)
        Me.Guna2Elipse2 = New Guna.UI2.WinForms.Guna2Elipse(Me.components)
        Me.Guna2Elipse3 = New Guna.UI2.WinForms.Guna2Elipse(Me.components)
        Me.Guna2Elipse4 = New Guna.UI2.WinForms.Guna2Elipse(Me.components)
        Me.Guna2GradientPanel1.SuspendLayout()
        Me.PanelBttn.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.Guna2ShadowPanel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Greetingslbl
        '
        Me.Greetingslbl.AutoSize = True
        Me.Greetingslbl.BackColor = System.Drawing.Color.Transparent
        Me.Greetingslbl.Font = New System.Drawing.Font("Segoe UI", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Greetingslbl.ForeColor = System.Drawing.Color.White
        Me.Greetingslbl.Location = New System.Drawing.Point(3, -3)
        Me.Greetingslbl.Name = "Greetingslbl"
        Me.Greetingslbl.Size = New System.Drawing.Size(66, 41)
        Me.Greetingslbl.TabIndex = 0
        Me.Greetingslbl.Text = "Hi, "
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 25.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Navy
        Me.Label1.Location = New System.Drawing.Point(146, 39)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(410, 59)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Profile Information"
        '
        'FNamelbl
        '
        Me.FNamelbl.AutoSize = True
        Me.FNamelbl.Font = New System.Drawing.Font("Segoe UI", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FNamelbl.Location = New System.Drawing.Point(46, 120)
        Me.FNamelbl.Name = "FNamelbl"
        Me.FNamelbl.Size = New System.Drawing.Size(132, 31)
        Me.FNamelbl.TabIndex = 2
        Me.FNamelbl.Text = "Last Name:"
        '
        'Addresslbl
        '
        Me.Addresslbl.AutoSize = True
        Me.Addresslbl.Font = New System.Drawing.Font("Segoe UI", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Addresslbl.Location = New System.Drawing.Point(46, 295)
        Me.Addresslbl.Name = "Addresslbl"
        Me.Addresslbl.Size = New System.Drawing.Size(105, 31)
        Me.Addresslbl.TabIndex = 3
        Me.Addresslbl.Text = "Address:"
        '
        'Emaillbl
        '
        Me.Emaillbl.AutoSize = True
        Me.Emaillbl.Font = New System.Drawing.Font("Segoe UI", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Emaillbl.Location = New System.Drawing.Point(46, 415)
        Me.Emaillbl.Name = "Emaillbl"
        Me.Emaillbl.Size = New System.Drawing.Size(85, 31)
        Me.Emaillbl.TabIndex = 5
        Me.Emaillbl.Text = "Email: "
        '
        'Numberlbl
        '
        Me.Numberlbl.AutoSize = True
        Me.Numberlbl.Font = New System.Drawing.Font("Segoe UI", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Numberlbl.Location = New System.Drawing.Point(46, 355)
        Me.Numberlbl.Name = "Numberlbl"
        Me.Numberlbl.Size = New System.Drawing.Size(204, 31)
        Me.Numberlbl.TabIndex = 4
        Me.Numberlbl.Text = "Contact Number: "
        '
        'LNametxtbox
        '
        Me.LNametxtbox.Font = New System.Drawing.Font("Segoe UI", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LNametxtbox.Location = New System.Drawing.Point(278, 120)
        Me.LNametxtbox.Name = "LNametxtbox"
        Me.LNametxtbox.Size = New System.Drawing.Size(350, 38)
        Me.LNametxtbox.TabIndex = 6
        '
        'Addresstxtbox
        '
        Me.Addresstxtbox.Font = New System.Drawing.Font("Segoe UI", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Addresstxtbox.Location = New System.Drawing.Point(278, 288)
        Me.Addresstxtbox.Name = "Addresstxtbox"
        Me.Addresstxtbox.Size = New System.Drawing.Size(350, 38)
        Me.Addresstxtbox.TabIndex = 7
        '
        'Numbertxtbox
        '
        Me.Numbertxtbox.Font = New System.Drawing.Font("Segoe UI", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Numbertxtbox.Location = New System.Drawing.Point(278, 348)
        Me.Numbertxtbox.Name = "Numbertxtbox"
        Me.Numbertxtbox.Size = New System.Drawing.Size(350, 38)
        Me.Numbertxtbox.TabIndex = 8
        '
        'Emailtxtbox
        '
        Me.Emailtxtbox.Font = New System.Drawing.Font("Segoe UI", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Emailtxtbox.Location = New System.Drawing.Point(278, 408)
        Me.Emailtxtbox.Name = "Emailtxtbox"
        Me.Emailtxtbox.Size = New System.Drawing.Size(350, 38)
        Me.Emailtxtbox.TabIndex = 9
        '
        'Guna2GradientPanel1
        '
        Me.Guna2GradientPanel1.Controls.Add(Me.PanelBttn)
        Me.Guna2GradientPanel1.Controls.Add(Me.Panel1)
        Me.Guna2GradientPanel1.Controls.Add(Me.Guna2ShadowPanel1)
        Me.Guna2GradientPanel1.FillColor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(42, Byte), Integer), CType(CType(82, Byte), Integer))
        Me.Guna2GradientPanel1.FillColor2 = System.Drawing.Color.FromArgb(CType(CType(58, Byte), Integer), CType(CType(176, Byte), Integer), CType(CType(158, Byte), Integer))
        Me.Guna2GradientPanel1.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical
        Me.Guna2GradientPanel1.Location = New System.Drawing.Point(0, 0)
        Me.Guna2GradientPanel1.Name = "Guna2GradientPanel1"
        Me.Guna2GradientPanel1.Size = New System.Drawing.Size(801, 900)
        Me.Guna2GradientPanel1.TabIndex = 14
        '
        'PanelBttn
        '
        Me.PanelBttn.BackColor = System.Drawing.Color.Transparent
        Me.PanelBttn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.PanelBttn.BorderRadius = 20
        Me.PanelBttn.BorderThickness = 20
        Me.PanelBttn.Controls.Add(Me.Aboutbtn)
        Me.PanelBttn.Controls.Add(Me.Contactbtn)
        Me.PanelBttn.Controls.Add(Me.HomeBtn)
        Me.PanelBttn.FillColor = System.Drawing.Color.FromArgb(CType(CType(58, Byte), Integer), CType(CType(176, Byte), Integer), CType(CType(158, Byte), Integer))
        Me.PanelBttn.FillColor2 = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(42, Byte), Integer), CType(CType(82, Byte), Integer))
        Me.PanelBttn.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.BackwardDiagonal
        Me.PanelBttn.Location = New System.Drawing.Point(-8, 797)
        Me.PanelBttn.Name = "PanelBttn"
        Me.PanelBttn.Size = New System.Drawing.Size(817, 100)
        Me.PanelBttn.TabIndex = 18
        '
        'Aboutbtn
        '
        Me.Aboutbtn.BackgroundImage = CType(resources.GetObject("Aboutbtn.BackgroundImage"), System.Drawing.Image)
        Me.Aboutbtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.Aboutbtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.Aboutbtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.Aboutbtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.Aboutbtn.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.Aboutbtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.Aboutbtn.FillColor = System.Drawing.Color.Empty
        Me.Aboutbtn.FillColor2 = System.Drawing.Color.Empty
        Me.Aboutbtn.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.Aboutbtn.ForeColor = System.Drawing.Color.White
        Me.Aboutbtn.Location = New System.Drawing.Point(692, 10)
        Me.Aboutbtn.Name = "Aboutbtn"
        Me.Aboutbtn.Size = New System.Drawing.Size(113, 73)
        Me.Aboutbtn.TabIndex = 18
        '
        'Contactbtn
        '
        Me.Contactbtn.BackgroundImage = CType(resources.GetObject("Contactbtn.BackgroundImage"), System.Drawing.Image)
        Me.Contactbtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.Contactbtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.Contactbtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.Contactbtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.Contactbtn.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.Contactbtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.Contactbtn.FillColor = System.Drawing.Color.Empty
        Me.Contactbtn.FillColor2 = System.Drawing.Color.Empty
        Me.Contactbtn.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.Contactbtn.ForeColor = System.Drawing.Color.White
        Me.Contactbtn.Location = New System.Drawing.Point(373, 10)
        Me.Contactbtn.Name = "Contactbtn"
        Me.Contactbtn.Size = New System.Drawing.Size(113, 73)
        Me.Contactbtn.TabIndex = 17
        '
        'HomeBtn
        '
        Me.HomeBtn.BackgroundImage = CType(resources.GetObject("HomeBtn.BackgroundImage"), System.Drawing.Image)
        Me.HomeBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.HomeBtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.HomeBtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.HomeBtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.HomeBtn.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.HomeBtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.HomeBtn.FillColor = System.Drawing.Color.Empty
        Me.HomeBtn.FillColor2 = System.Drawing.Color.Empty
        Me.HomeBtn.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.HomeBtn.ForeColor = System.Drawing.Color.White
        Me.HomeBtn.Location = New System.Drawing.Point(10, 10)
        Me.HomeBtn.Name = "HomeBtn"
        Me.HomeBtn.Size = New System.Drawing.Size(113, 73)
        Me.HomeBtn.TabIndex = 16
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Black
        Me.Panel1.Controls.Add(Me.LogOutbtn)
        Me.Panel1.Controls.Add(Me.Guna2ControlBox1)
        Me.Panel1.Controls.Add(Me.Greetingslbl)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(801, 41)
        Me.Panel1.TabIndex = 15
        '
        'LogOutbtn
        '
        Me.LogOutbtn.BackColor = System.Drawing.Color.Red
        Me.LogOutbtn.BorderRadius = 20
        Me.LogOutbtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.LogOutbtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.LogOutbtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.LogOutbtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.LogOutbtn.FillColor = System.Drawing.Color.Empty
        Me.LogOutbtn.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.LogOutbtn.ForeColor = System.Drawing.Color.White
        Me.LogOutbtn.Location = New System.Drawing.Point(621, 6)
        Me.LogOutbtn.Name = "LogOutbtn"
        Me.LogOutbtn.Size = New System.Drawing.Size(100, 30)
        Me.LogOutbtn.TabIndex = 19
        Me.LogOutbtn.Text = "Log out"
        '
        'Guna2ControlBox1
        '
        Me.Guna2ControlBox1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Guna2ControlBox1.FillColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Guna2ControlBox1.IconColor = System.Drawing.Color.White
        Me.Guna2ControlBox1.Location = New System.Drawing.Point(744, 6)
        Me.Guna2ControlBox1.Name = "Guna2ControlBox1"
        Me.Guna2ControlBox1.Size = New System.Drawing.Size(45, 29)
        Me.Guna2ControlBox1.TabIndex = 0
        '
        'Guna2ShadowPanel1
        '
        Me.Guna2ShadowPanel1.BackColor = System.Drawing.Color.Transparent
        Me.Guna2ShadowPanel1.Controls.Add(Me.Label3)
        Me.Guna2ShadowPanel1.Controls.Add(Me.Middletextbox)
        Me.Guna2ShadowPanel1.Controls.Add(Me.Label2)
        Me.Guna2ShadowPanel1.Controls.Add(Me.FNametxtbox)
        Me.Guna2ShadowPanel1.Controls.Add(Me.GunaUpdate)
        Me.Guna2ShadowPanel1.Controls.Add(Me.GunaSave)
        Me.Guna2ShadowPanel1.Controls.Add(Me.Label1)
        Me.Guna2ShadowPanel1.Controls.Add(Me.FNamelbl)
        Me.Guna2ShadowPanel1.Controls.Add(Me.LNametxtbox)
        Me.Guna2ShadowPanel1.Controls.Add(Me.Addresslbl)
        Me.Guna2ShadowPanel1.Controls.Add(Me.Emaillbl)
        Me.Guna2ShadowPanel1.Controls.Add(Me.Emailtxtbox)
        Me.Guna2ShadowPanel1.Controls.Add(Me.Addresstxtbox)
        Me.Guna2ShadowPanel1.Controls.Add(Me.Numbertxtbox)
        Me.Guna2ShadowPanel1.Controls.Add(Me.Numberlbl)
        Me.Guna2ShadowPanel1.FillColor = System.Drawing.Color.White
        Me.Guna2ShadowPanel1.Location = New System.Drawing.Point(57, 126)
        Me.Guna2ShadowPanel1.Name = "Guna2ShadowPanel1"
        Me.Guna2ShadowPanel1.Radius = 10
        Me.Guna2ShadowPanel1.ShadowColor = System.Drawing.Color.Black
        Me.Guna2ShadowPanel1.ShadowShift = 20
        Me.Guna2ShadowPanel1.Size = New System.Drawing.Size(680, 600)
        Me.Guna2ShadowPanel1.TabIndex = 0
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Segoe UI", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(46, 235)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(165, 31)
        Me.Label3.TabIndex = 19
        Me.Label3.Text = "Middle Initial:"
        '
        'Middletextbox
        '
        Me.Middletextbox.Font = New System.Drawing.Font("Segoe UI", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Middletextbox.Location = New System.Drawing.Point(278, 235)
        Me.Middletextbox.Name = "Middletextbox"
        Me.Middletextbox.Size = New System.Drawing.Size(350, 38)
        Me.Middletextbox.TabIndex = 20
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(46, 177)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(142, 31)
        Me.Label2.TabIndex = 17
        Me.Label2.Text = "First Name: "
        '
        'FNametxtbox
        '
        Me.FNametxtbox.Font = New System.Drawing.Font("Segoe UI", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FNametxtbox.Location = New System.Drawing.Point(278, 177)
        Me.FNametxtbox.Name = "FNametxtbox"
        Me.FNametxtbox.Size = New System.Drawing.Size(350, 38)
        Me.FNametxtbox.TabIndex = 18
        '
        'GunaUpdate
        '
        Me.GunaUpdate.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.GunaUpdate.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.GunaUpdate.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.GunaUpdate.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.GunaUpdate.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.GunaUpdate.FillColor = System.Drawing.Color.Blue
        Me.GunaUpdate.FillColor2 = System.Drawing.Color.Blue
        Me.GunaUpdate.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.GunaUpdate.ForeColor = System.Drawing.Color.White
        Me.GunaUpdate.Location = New System.Drawing.Point(448, 471)
        Me.GunaUpdate.Name = "GunaUpdate"
        Me.GunaUpdate.Size = New System.Drawing.Size(180, 50)
        Me.GunaUpdate.TabIndex = 16
        Me.GunaUpdate.Text = "Update"
        '
        'GunaSave
        '
        Me.GunaSave.BackColor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(42, Byte), Integer), CType(CType(82, Byte), Integer))
        Me.GunaSave.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.GunaSave.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.GunaSave.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.GunaSave.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.GunaSave.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.GunaSave.FillColor = System.Drawing.Color.Gray
        Me.GunaSave.FillColor2 = System.Drawing.Color.Black
        Me.GunaSave.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.GunaSave.ForeColor = System.Drawing.Color.White
        Me.GunaSave.Location = New System.Drawing.Point(37, 471)
        Me.GunaSave.Name = "GunaSave"
        Me.GunaSave.Size = New System.Drawing.Size(180, 50)
        Me.GunaSave.TabIndex = 14
        Me.GunaSave.Text = "Save"
        '
        'Guna2Elipse1
        '
        Me.Guna2Elipse1.BorderRadius = 10
        Me.Guna2Elipse1.TargetControl = Me.LogOutbtn
        '
        'Guna2Elipse2
        '
        Me.Guna2Elipse2.BorderRadius = 10
        Me.Guna2Elipse2.TargetControl = Me.GunaSave
        '
        'Guna2Elipse3
        '
        Me.Guna2Elipse3.BorderRadius = 10
        Me.Guna2Elipse3.TargetControl = Me.GunaUpdate
        '
        'Guna2Elipse4
        '
        Me.Guna2Elipse4.BorderRadius = 10
        '
        'Profile
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(801, 900)
        Me.Controls.Add(Me.Guna2GradientPanel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Profile"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Profile"
        Me.Guna2GradientPanel1.ResumeLayout(False)
        Me.PanelBttn.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Guna2ShadowPanel1.ResumeLayout(False)
        Me.Guna2ShadowPanel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Greetingslbl As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents FNamelbl As Label
    Friend WithEvents Addresslbl As Label
    Friend WithEvents Emaillbl As Label
    Friend WithEvents Numberlbl As Label
    Friend WithEvents LNametxtbox As TextBox
    Friend WithEvents Addresstxtbox As TextBox
    Friend WithEvents Numbertxtbox As TextBox
    Friend WithEvents Emailtxtbox As TextBox
    Friend WithEvents Guna2GradientPanel1 As Guna.UI2.WinForms.Guna2GradientPanel
    Friend WithEvents Guna2ShadowPanel1 As Guna.UI2.WinForms.Guna2ShadowPanel
    Friend WithEvents GunaSave As Guna.UI2.WinForms.Guna2GradientButton
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Guna2ControlBox1 As Guna.UI2.WinForms.Guna2ControlBox
    Friend WithEvents PanelBttn As Guna.UI2.WinForms.Guna2GradientPanel
    Friend WithEvents Aboutbtn As Guna.UI2.WinForms.Guna2GradientButton
    Friend WithEvents Contactbtn As Guna.UI2.WinForms.Guna2GradientButton
    Friend WithEvents HomeBtn As Guna.UI2.WinForms.Guna2GradientButton
    Friend WithEvents GunaUpdate As Guna.UI2.WinForms.Guna2GradientButton
    Friend WithEvents LogOutbtn As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents Guna2Elipse1 As Guna.UI2.WinForms.Guna2Elipse
    Friend WithEvents Guna2Elipse2 As Guna.UI2.WinForms.Guna2Elipse
    Friend WithEvents Guna2Elipse3 As Guna.UI2.WinForms.Guna2Elipse
    Friend WithEvents Guna2Elipse4 As Guna.UI2.WinForms.Guna2Elipse
    Friend WithEvents Label3 As Label
    Friend WithEvents Middletextbox As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents FNametxtbox As TextBox
End Class

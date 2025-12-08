<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class UsersTable
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(UsersTable))
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Guna2ControlBox1 = New Guna.UI2.WinForms.Guna2ControlBox()
        Me.UserTB = New System.Windows.Forms.DataGridView()
        Me.Guna2GradientPanel1 = New Guna.UI2.WinForms.Guna2GradientPanel()
        Me.Deletebtn = New Guna.UI2.WinForms.Guna2Button()
        Me.Updatebtn = New Guna.UI2.WinForms.Guna2Button()
        Me.Usersbtn = New Guna.UI2.WinForms.Guna2ImageButton()
        Me.Refreshbtn = New Guna.UI2.WinForms.Guna2ImageButton()
        Me.LogOutbtn = New Guna.UI2.WinForms.Guna2Button()
        Me.Guna2Elipse1 = New Guna.UI2.WinForms.Guna2Elipse(Me.components)
        Me.Guna2Elipse2 = New Guna.UI2.WinForms.Guna2Elipse(Me.components)
        Me.Guna2Elipse3 = New Guna.UI2.WinForms.Guna2Elipse(Me.components)
        Me.Panel1.SuspendLayout()
        CType(Me.UserTB, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Guna2GradientPanel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Black
        Me.Panel1.Controls.Add(Me.LogOutbtn)
        Me.Panel1.Controls.Add(Me.Guna2ControlBox1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1000, 41)
        Me.Panel1.TabIndex = 21
        '
        'Guna2ControlBox1
        '
        Me.Guna2ControlBox1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Guna2ControlBox1.FillColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Guna2ControlBox1.IconColor = System.Drawing.Color.White
        Me.Guna2ControlBox1.Location = New System.Drawing.Point(943, 6)
        Me.Guna2ControlBox1.Name = "Guna2ControlBox1"
        Me.Guna2ControlBox1.Size = New System.Drawing.Size(45, 29)
        Me.Guna2ControlBox1.TabIndex = 0
        '
        'UserTB
        '
        Me.UserTB.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.UserTB.Location = New System.Drawing.Point(12, 47)
        Me.UserTB.Name = "UserTB"
        Me.UserTB.RowHeadersWidth = 51
        Me.UserTB.RowTemplate.Height = 24
        Me.UserTB.Size = New System.Drawing.Size(976, 472)
        Me.UserTB.TabIndex = 20
        '
        'Guna2GradientPanel1
        '
        Me.Guna2GradientPanel1.Controls.Add(Me.Deletebtn)
        Me.Guna2GradientPanel1.Controls.Add(Me.Updatebtn)
        Me.Guna2GradientPanel1.Controls.Add(Me.Usersbtn)
        Me.Guna2GradientPanel1.Controls.Add(Me.Refreshbtn)
        Me.Guna2GradientPanel1.FillColor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(42, Byte), Integer), CType(CType(82, Byte), Integer))
        Me.Guna2GradientPanel1.FillColor2 = System.Drawing.Color.FromArgb(CType(CType(58, Byte), Integer), CType(CType(176, Byte), Integer), CType(CType(158, Byte), Integer))
        Me.Guna2GradientPanel1.Location = New System.Drawing.Point(0, 41)
        Me.Guna2GradientPanel1.Name = "Guna2GradientPanel1"
        Me.Guna2GradientPanel1.Size = New System.Drawing.Size(1066, 603)
        Me.Guna2GradientPanel1.TabIndex = 22
        '
        'Deletebtn
        '
        Me.Deletebtn.BackColor = System.Drawing.Color.White
        Me.Deletebtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.Deletebtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.Deletebtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.Deletebtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.Deletebtn.FillColor = System.Drawing.Color.Red
        Me.Deletebtn.Font = New System.Drawing.Font("Segoe UI", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Deletebtn.ForeColor = System.Drawing.Color.White
        Me.Deletebtn.Location = New System.Drawing.Point(808, 484)
        Me.Deletebtn.Name = "Deletebtn"
        Me.Deletebtn.Size = New System.Drawing.Size(180, 45)
        Me.Deletebtn.TabIndex = 24
        Me.Deletebtn.Text = "Delete"
        '
        'Updatebtn
        '
        Me.Updatebtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.Updatebtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.Updatebtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.Updatebtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.Updatebtn.Font = New System.Drawing.Font("Segoe UI", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Updatebtn.ForeColor = System.Drawing.Color.White
        Me.Updatebtn.Location = New System.Drawing.Point(12, 484)
        Me.Updatebtn.Name = "Updatebtn"
        Me.Updatebtn.Size = New System.Drawing.Size(180, 45)
        Me.Updatebtn.TabIndex = 23
        Me.Updatebtn.Text = "Update"
        '
        'Usersbtn
        '
        Me.Usersbtn.BackColor = System.Drawing.Color.Transparent
        Me.Usersbtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.Usersbtn.CheckedState.ImageSize = New System.Drawing.Size(64, 64)
        Me.Usersbtn.HoverState.ImageSize = New System.Drawing.Size(64, 64)
        Me.Usersbtn.Image = CType(resources.GetObject("Usersbtn.Image"), System.Drawing.Image)
        Me.Usersbtn.ImageOffset = New System.Drawing.Point(0, 0)
        Me.Usersbtn.ImageRotate = 0!
        Me.Usersbtn.Location = New System.Drawing.Point(429, 503)
        Me.Usersbtn.Name = "Usersbtn"
        Me.Usersbtn.PressedState.ImageSize = New System.Drawing.Size(64, 64)
        Me.Usersbtn.Size = New System.Drawing.Size(80, 72)
        Me.Usersbtn.TabIndex = 17
        '
        'Refreshbtn
        '
        Me.Refreshbtn.BackColor = System.Drawing.Color.Transparent
        Me.Refreshbtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.Refreshbtn.CheckedState.ImageSize = New System.Drawing.Size(64, 64)
        Me.Refreshbtn.HoverState.ImageSize = New System.Drawing.Size(64, 64)
        Me.Refreshbtn.Image = CType(resources.GetObject("Refreshbtn.Image"), System.Drawing.Image)
        Me.Refreshbtn.ImageOffset = New System.Drawing.Point(0, 0)
        Me.Refreshbtn.ImageRotate = 0!
        Me.Refreshbtn.Location = New System.Drawing.Point(532, 503)
        Me.Refreshbtn.Name = "Refreshbtn"
        Me.Refreshbtn.PressedState.ImageSize = New System.Drawing.Size(64, 64)
        Me.Refreshbtn.Size = New System.Drawing.Size(80, 72)
        Me.Refreshbtn.TabIndex = 18
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
        Me.LogOutbtn.Location = New System.Drawing.Point(10, 6)
        Me.LogOutbtn.Name = "LogOutbtn"
        Me.LogOutbtn.Size = New System.Drawing.Size(100, 30)
        Me.LogOutbtn.TabIndex = 23
        Me.LogOutbtn.Text = "Log out"
        '
        'Guna2Elipse1
        '
        Me.Guna2Elipse1.BorderRadius = 20
        Me.Guna2Elipse1.TargetControl = Me.Updatebtn
        '
        'Guna2Elipse2
        '
        Me.Guna2Elipse2.BorderRadius = 20
        Me.Guna2Elipse2.TargetControl = Me.Deletebtn
        '
        'Guna2Elipse3
        '
        Me.Guna2Elipse3.BorderRadius = 20
        Me.Guna2Elipse3.TargetControl = Me.LogOutbtn
        '
        'UsersTable
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1000, 640)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.UserTB)
        Me.Controls.Add(Me.Guna2GradientPanel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "UsersTable"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "UsersTable"
        Me.Panel1.ResumeLayout(False)
        CType(Me.UserTB, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Guna2GradientPanel1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Guna2ControlBox1 As Guna.UI2.WinForms.Guna2ControlBox
    Friend WithEvents UserTB As DataGridView
    Friend WithEvents Guna2GradientPanel1 As Guna.UI2.WinForms.Guna2GradientPanel
    Friend WithEvents Usersbtn As Guna.UI2.WinForms.Guna2ImageButton
    Friend WithEvents Refreshbtn As Guna.UI2.WinForms.Guna2ImageButton
    Friend WithEvents Deletebtn As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents Updatebtn As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents LogOutbtn As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents Guna2Elipse1 As Guna.UI2.WinForms.Guna2Elipse
    Friend WithEvents Guna2Elipse2 As Guna.UI2.WinForms.Guna2Elipse
    Friend WithEvents Guna2Elipse3 As Guna.UI2.WinForms.Guna2Elipse
End Class

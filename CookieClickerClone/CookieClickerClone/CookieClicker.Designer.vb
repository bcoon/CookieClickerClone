<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CookieClicker
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
        Me.pnlLeft = New System.Windows.Forms.Panel()
        Me.tmrCounter = New System.Windows.Forms.Timer(Me.components)
        Me.pnlCenter = New System.Windows.Forms.Panel()
        Me.pnlRight = New System.Windows.Forms.Panel()
        Me.pnlMessages = New System.Windows.Forms.Panel()
        Me.pnlUpgrades = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.pbCookie = New System.Windows.Forms.PictureBox()
        Me.pnlLeft.SuspendLayout()
        CType(Me.pbCookie, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'pnlLeft
        '
        Me.pnlLeft.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pnlLeft.Controls.Add(Me.Label1)
        Me.pnlLeft.Controls.Add(Me.pbCookie)
        Me.pnlLeft.Location = New System.Drawing.Point(0, 0)
        Me.pnlLeft.Name = "pnlLeft"
        Me.pnlLeft.Size = New System.Drawing.Size(340, 562)
        Me.pnlLeft.TabIndex = 0
        '
        'tmrCounter
        '
        Me.tmrCounter.Enabled = True
        '
        'pnlCenter
        '
        Me.pnlCenter.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pnlCenter.Location = New System.Drawing.Point(340, 81)
        Me.pnlCenter.Name = "pnlCenter"
        Me.pnlCenter.Size = New System.Drawing.Size(404, 481)
        Me.pnlCenter.TabIndex = 1
        '
        'pnlRight
        '
        Me.pnlRight.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pnlRight.Location = New System.Drawing.Point(744, 81)
        Me.pnlRight.Name = "pnlRight"
        Me.pnlRight.Size = New System.Drawing.Size(340, 481)
        Me.pnlRight.TabIndex = 2
        '
        'pnlMessages
        '
        Me.pnlMessages.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pnlMessages.Location = New System.Drawing.Point(340, 0)
        Me.pnlMessages.Name = "pnlMessages"
        Me.pnlMessages.Size = New System.Drawing.Size(404, 81)
        Me.pnlMessages.TabIndex = 3
        '
        'pnlUpgrades
        '
        Me.pnlUpgrades.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pnlUpgrades.Location = New System.Drawing.Point(744, 0)
        Me.pnlUpgrades.Name = "pnlUpgrades"
        Me.pnlUpgrades.Size = New System.Drawing.Size(340, 81)
        Me.pnlUpgrades.TabIndex = 4
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(167, 28)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(39, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Label1"
        '
        'pbCookie
        '
        Me.pbCookie.Image = Global.CookieClickerClone.My.Resources.Resources.cookie
        Me.pbCookie.InitialImage = Nothing
        Me.pbCookie.Location = New System.Drawing.Point(60, 80)
        Me.pbCookie.Name = "pbCookie"
        Me.pbCookie.Size = New System.Drawing.Size(220, 220)
        Me.pbCookie.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.pbCookie.TabIndex = 0
        Me.pbCookie.TabStop = False
        '
        'CookieClicker
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1084, 562)
        Me.Controls.Add(Me.pnlUpgrades)
        Me.Controls.Add(Me.pnlMessages)
        Me.Controls.Add(Me.pnlRight)
        Me.Controls.Add(Me.pnlCenter)
        Me.Controls.Add(Me.pnlLeft)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.MaximumSize = New System.Drawing.Size(1090, 590)
        Me.MinimumSize = New System.Drawing.Size(1090, 590)
        Me.Name = "CookieClicker"
        Me.Text = "Cookie Clicker"
        Me.pnlLeft.ResumeLayout(False)
        Me.pnlLeft.PerformLayout()
        CType(Me.pbCookie, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents pnlLeft As System.Windows.Forms.Panel
    Friend WithEvents tmrCounter As System.Windows.Forms.Timer
    Friend WithEvents pnlCenter As System.Windows.Forms.Panel
    Friend WithEvents pnlRight As System.Windows.Forms.Panel
    Friend WithEvents pbCookie As System.Windows.Forms.PictureBox
    Friend WithEvents pnlMessages As System.Windows.Forms.Panel
    Friend WithEvents pnlUpgrades As System.Windows.Forms.Panel
    Friend WithEvents Label1 As System.Windows.Forms.Label

End Class

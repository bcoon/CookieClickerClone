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
        Me.lblCurrentCookies = New System.Windows.Forms.Label()
        Me.lblCpS = New System.Windows.Forms.Label()
        Me.picCookie = New System.Windows.Forms.PictureBox()
        Me.tmrCounter = New System.Windows.Forms.Timer(Me.components)
        Me.pnlCenter = New System.Windows.Forms.Panel()
        Me.pnlRight = New System.Windows.Forms.Panel()
        Me.picAntimatterCondenser = New System.Windows.Forms.PictureBox()
        Me.picTimeMachine = New System.Windows.Forms.PictureBox()
        Me.picPortal = New System.Windows.Forms.PictureBox()
        Me.picAlchemyLab = New System.Windows.Forms.PictureBox()
        Me.picShipment = New System.Windows.Forms.PictureBox()
        Me.picMine = New System.Windows.Forms.PictureBox()
        Me.picFactory = New System.Windows.Forms.PictureBox()
        Me.picFarm = New System.Windows.Forms.PictureBox()
        Me.picGrandma = New System.Windows.Forms.PictureBox()
        Me.picCursor = New System.Windows.Forms.PictureBox()
        Me.lblAntimatterCondenser = New System.Windows.Forms.Label()
        Me.lblTimeMachine = New System.Windows.Forms.Label()
        Me.lblPortal = New System.Windows.Forms.Label()
        Me.lblAlchemyLab = New System.Windows.Forms.Label()
        Me.lblShipment = New System.Windows.Forms.Label()
        Me.lblMine = New System.Windows.Forms.Label()
        Me.lblFactory = New System.Windows.Forms.Label()
        Me.lblFarm = New System.Windows.Forms.Label()
        Me.lblGrandma = New System.Windows.Forms.Label()
        Me.lblCursor = New System.Windows.Forms.Label()
        Me.btnAntimatterCondenser = New System.Windows.Forms.Button()
        Me.btnTimeMachine = New System.Windows.Forms.Button()
        Me.btnPortal = New System.Windows.Forms.Button()
        Me.btnAlchemyLab = New System.Windows.Forms.Button()
        Me.btnShipment = New System.Windows.Forms.Button()
        Me.btnMine = New System.Windows.Forms.Button()
        Me.btnFactory = New System.Windows.Forms.Button()
        Me.btnFarm = New System.Windows.Forms.Button()
        Me.btnGrandma = New System.Windows.Forms.Button()
        Me.btnCursor = New System.Windows.Forms.Button()
        Me.pnlMessages = New System.Windows.Forms.Panel()
        Me.pnlUpgrades = New System.Windows.Forms.Panel()
        Me.lblStore = New System.Windows.Forms.Label()
        Me.pnlLeft.SuspendLayout()
        CType(Me.picCookie, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlRight.SuspendLayout()
        CType(Me.picAntimatterCondenser, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picTimeMachine, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picPortal, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picAlchemyLab, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picShipment, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picMine, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picFactory, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picFarm, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picGrandma, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picCursor, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlUpgrades.SuspendLayout()
        Me.SuspendLayout()
        '
        'pnlLeft
        '
        Me.pnlLeft.BackColor = System.Drawing.Color.Transparent
        Me.pnlLeft.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pnlLeft.Controls.Add(Me.lblCurrentCookies)
        Me.pnlLeft.Controls.Add(Me.lblCpS)
        Me.pnlLeft.Controls.Add(Me.picCookie)
        Me.pnlLeft.Location = New System.Drawing.Point(0, 0)
        Me.pnlLeft.Name = "pnlLeft"
        Me.pnlLeft.Size = New System.Drawing.Size(340, 562)
        Me.pnlLeft.TabIndex = 0
        '
        'lblCurrentCookies
        '
        Me.lblCurrentCookies.Font = New System.Drawing.Font("Book Antiqua", 11.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCurrentCookies.ForeColor = System.Drawing.Color.White
        Me.lblCurrentCookies.Location = New System.Drawing.Point(0, 70)
        Me.lblCurrentCookies.Name = "lblCurrentCookies"
        Me.lblCurrentCookies.Size = New System.Drawing.Size(340, 23)
        Me.lblCurrentCookies.TabIndex = 2
        Me.lblCurrentCookies.Text = "0 cookies"
        Me.lblCurrentCookies.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblCpS
        '
        Me.lblCpS.Font = New System.Drawing.Font("Book Antiqua", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCpS.ForeColor = System.Drawing.Color.White
        Me.lblCpS.Location = New System.Drawing.Point(0, 90)
        Me.lblCpS.Name = "lblCpS"
        Me.lblCpS.Size = New System.Drawing.Size(340, 18)
        Me.lblCpS.TabIndex = 1
        Me.lblCpS.Text = "per second: 0"
        Me.lblCpS.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'picCookie
        '
        Me.picCookie.Image = Global.CookieClickerClone.My.Resources.Resources.cookie
        Me.picCookie.InitialImage = Nothing
        Me.picCookie.Location = New System.Drawing.Point(60, 80)
        Me.picCookie.Name = "picCookie"
        Me.picCookie.Size = New System.Drawing.Size(220, 220)
        Me.picCookie.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.picCookie.TabIndex = 0
        Me.picCookie.TabStop = False
        '
        'tmrCounter
        '
        Me.tmrCounter.Enabled = True
        Me.tmrCounter.Interval = 250
        '
        'pnlCenter
        '
        Me.pnlCenter.BackColor = System.Drawing.SystemColors.Control
        Me.pnlCenter.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pnlCenter.Location = New System.Drawing.Point(340, 81)
        Me.pnlCenter.Name = "pnlCenter"
        Me.pnlCenter.Size = New System.Drawing.Size(404, 481)
        Me.pnlCenter.TabIndex = 1
        '
        'pnlRight
        '
        Me.pnlRight.AutoScroll = True
        Me.pnlRight.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pnlRight.Controls.Add(Me.picAntimatterCondenser)
        Me.pnlRight.Controls.Add(Me.picTimeMachine)
        Me.pnlRight.Controls.Add(Me.picPortal)
        Me.pnlRight.Controls.Add(Me.picAlchemyLab)
        Me.pnlRight.Controls.Add(Me.picShipment)
        Me.pnlRight.Controls.Add(Me.picMine)
        Me.pnlRight.Controls.Add(Me.picFactory)
        Me.pnlRight.Controls.Add(Me.picFarm)
        Me.pnlRight.Controls.Add(Me.picGrandma)
        Me.pnlRight.Controls.Add(Me.picCursor)
        Me.pnlRight.Controls.Add(Me.lblAntimatterCondenser)
        Me.pnlRight.Controls.Add(Me.lblTimeMachine)
        Me.pnlRight.Controls.Add(Me.lblPortal)
        Me.pnlRight.Controls.Add(Me.lblAlchemyLab)
        Me.pnlRight.Controls.Add(Me.lblShipment)
        Me.pnlRight.Controls.Add(Me.lblMine)
        Me.pnlRight.Controls.Add(Me.lblFactory)
        Me.pnlRight.Controls.Add(Me.lblFarm)
        Me.pnlRight.Controls.Add(Me.lblGrandma)
        Me.pnlRight.Controls.Add(Me.lblCursor)
        Me.pnlRight.Controls.Add(Me.btnAntimatterCondenser)
        Me.pnlRight.Controls.Add(Me.btnTimeMachine)
        Me.pnlRight.Controls.Add(Me.btnPortal)
        Me.pnlRight.Controls.Add(Me.btnAlchemyLab)
        Me.pnlRight.Controls.Add(Me.btnShipment)
        Me.pnlRight.Controls.Add(Me.btnMine)
        Me.pnlRight.Controls.Add(Me.btnFactory)
        Me.pnlRight.Controls.Add(Me.btnFarm)
        Me.pnlRight.Controls.Add(Me.btnGrandma)
        Me.pnlRight.Controls.Add(Me.btnCursor)
        Me.pnlRight.Location = New System.Drawing.Point(744, 81)
        Me.pnlRight.Name = "pnlRight"
        Me.pnlRight.Size = New System.Drawing.Size(340, 481)
        Me.pnlRight.TabIndex = 2
        '
        'picAntimatterCondenser
        '
        Me.picAntimatterCondenser.Enabled = False
        Me.picAntimatterCondenser.Location = New System.Drawing.Point(5, 550)
        Me.picAntimatterCondenser.Name = "picAntimatterCondenser"
        Me.picAntimatterCondenser.Size = New System.Drawing.Size(40, 40)
        Me.picAntimatterCondenser.TabIndex = 29
        Me.picAntimatterCondenser.TabStop = False
        '
        'picTimeMachine
        '
        Me.picTimeMachine.Enabled = False
        Me.picTimeMachine.Location = New System.Drawing.Point(5, 490)
        Me.picTimeMachine.Name = "picTimeMachine"
        Me.picTimeMachine.Size = New System.Drawing.Size(40, 40)
        Me.picTimeMachine.TabIndex = 28
        Me.picTimeMachine.TabStop = False
        '
        'picPortal
        '
        Me.picPortal.Enabled = False
        Me.picPortal.Location = New System.Drawing.Point(5, 430)
        Me.picPortal.Name = "picPortal"
        Me.picPortal.Size = New System.Drawing.Size(40, 40)
        Me.picPortal.TabIndex = 27
        Me.picPortal.TabStop = False
        '
        'picAlchemyLab
        '
        Me.picAlchemyLab.Enabled = False
        Me.picAlchemyLab.Location = New System.Drawing.Point(5, 370)
        Me.picAlchemyLab.Name = "picAlchemyLab"
        Me.picAlchemyLab.Size = New System.Drawing.Size(40, 40)
        Me.picAlchemyLab.TabIndex = 26
        Me.picAlchemyLab.TabStop = False
        '
        'picShipment
        '
        Me.picShipment.Enabled = False
        Me.picShipment.Location = New System.Drawing.Point(5, 310)
        Me.picShipment.Name = "picShipment"
        Me.picShipment.Size = New System.Drawing.Size(40, 40)
        Me.picShipment.TabIndex = 25
        Me.picShipment.TabStop = False
        '
        'picMine
        '
        Me.picMine.Enabled = False
        Me.picMine.Location = New System.Drawing.Point(5, 250)
        Me.picMine.Name = "picMine"
        Me.picMine.Size = New System.Drawing.Size(40, 40)
        Me.picMine.TabIndex = 24
        Me.picMine.TabStop = False
        '
        'picFactory
        '
        Me.picFactory.Enabled = False
        Me.picFactory.Location = New System.Drawing.Point(5, 190)
        Me.picFactory.Name = "picFactory"
        Me.picFactory.Size = New System.Drawing.Size(40, 40)
        Me.picFactory.TabIndex = 23
        Me.picFactory.TabStop = False
        '
        'picFarm
        '
        Me.picFarm.Enabled = False
        Me.picFarm.Location = New System.Drawing.Point(5, 130)
        Me.picFarm.Name = "picFarm"
        Me.picFarm.Size = New System.Drawing.Size(40, 40)
        Me.picFarm.TabIndex = 22
        Me.picFarm.TabStop = False
        '
        'picGrandma
        '
        Me.picGrandma.Enabled = False
        Me.picGrandma.Location = New System.Drawing.Point(5, 70)
        Me.picGrandma.Name = "picGrandma"
        Me.picGrandma.Size = New System.Drawing.Size(40, 40)
        Me.picGrandma.TabIndex = 21
        Me.picGrandma.TabStop = False
        '
        'picCursor
        '
        Me.picCursor.Enabled = False
        Me.picCursor.Location = New System.Drawing.Point(4, 10)
        Me.picCursor.Name = "picCursor"
        Me.picCursor.Size = New System.Drawing.Size(40, 40)
        Me.picCursor.TabIndex = 20
        Me.picCursor.TabStop = False
        '
        'lblAntimatterCondenser
        '
        Me.lblAntimatterCondenser.BackColor = System.Drawing.Color.Transparent
        Me.lblAntimatterCondenser.Enabled = False
        Me.lblAntimatterCondenser.Font = New System.Drawing.Font("Lucida Console", 12.75!)
        Me.lblAntimatterCondenser.Location = New System.Drawing.Point(254, 543)
        Me.lblAntimatterCondenser.Name = "lblAntimatterCondenser"
        Me.lblAntimatterCondenser.Size = New System.Drawing.Size(65, 55)
        Me.lblAntimatterCondenser.TabIndex = 19
        Me.lblAntimatterCondenser.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblTimeMachine
        '
        Me.lblTimeMachine.BackColor = System.Drawing.Color.Transparent
        Me.lblTimeMachine.Enabled = False
        Me.lblTimeMachine.Font = New System.Drawing.Font("Lucida Console", 12.75!)
        Me.lblTimeMachine.Location = New System.Drawing.Point(252, 483)
        Me.lblTimeMachine.Name = "lblTimeMachine"
        Me.lblTimeMachine.Size = New System.Drawing.Size(65, 55)
        Me.lblTimeMachine.TabIndex = 18
        Me.lblTimeMachine.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblPortal
        '
        Me.lblPortal.BackColor = System.Drawing.Color.Transparent
        Me.lblPortal.Enabled = False
        Me.lblPortal.Font = New System.Drawing.Font("Lucida Console", 12.75!)
        Me.lblPortal.Location = New System.Drawing.Point(252, 423)
        Me.lblPortal.Name = "lblPortal"
        Me.lblPortal.Size = New System.Drawing.Size(65, 55)
        Me.lblPortal.TabIndex = 17
        Me.lblPortal.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblAlchemyLab
        '
        Me.lblAlchemyLab.BackColor = System.Drawing.Color.Transparent
        Me.lblAlchemyLab.Enabled = False
        Me.lblAlchemyLab.Font = New System.Drawing.Font("Lucida Console", 12.75!)
        Me.lblAlchemyLab.Location = New System.Drawing.Point(252, 363)
        Me.lblAlchemyLab.Name = "lblAlchemyLab"
        Me.lblAlchemyLab.Size = New System.Drawing.Size(65, 55)
        Me.lblAlchemyLab.TabIndex = 16
        Me.lblAlchemyLab.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblShipment
        '
        Me.lblShipment.BackColor = System.Drawing.Color.Transparent
        Me.lblShipment.Enabled = False
        Me.lblShipment.Font = New System.Drawing.Font("Lucida Console", 12.75!)
        Me.lblShipment.Location = New System.Drawing.Point(252, 303)
        Me.lblShipment.Name = "lblShipment"
        Me.lblShipment.Size = New System.Drawing.Size(65, 55)
        Me.lblShipment.TabIndex = 15
        Me.lblShipment.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblMine
        '
        Me.lblMine.BackColor = System.Drawing.Color.Transparent
        Me.lblMine.Enabled = False
        Me.lblMine.Font = New System.Drawing.Font("Lucida Console", 12.75!)
        Me.lblMine.Location = New System.Drawing.Point(254, 243)
        Me.lblMine.Name = "lblMine"
        Me.lblMine.Size = New System.Drawing.Size(65, 55)
        Me.lblMine.TabIndex = 14
        Me.lblMine.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblFactory
        '
        Me.lblFactory.BackColor = System.Drawing.Color.Transparent
        Me.lblFactory.Enabled = False
        Me.lblFactory.Font = New System.Drawing.Font("Lucida Console", 12.75!)
        Me.lblFactory.Location = New System.Drawing.Point(252, 184)
        Me.lblFactory.Name = "lblFactory"
        Me.lblFactory.Size = New System.Drawing.Size(65, 55)
        Me.lblFactory.TabIndex = 13
        Me.lblFactory.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblFarm
        '
        Me.lblFarm.BackColor = System.Drawing.Color.Transparent
        Me.lblFarm.Enabled = False
        Me.lblFarm.Font = New System.Drawing.Font("Lucida Console", 12.75!)
        Me.lblFarm.Location = New System.Drawing.Point(252, 123)
        Me.lblFarm.Name = "lblFarm"
        Me.lblFarm.Size = New System.Drawing.Size(65, 55)
        Me.lblFarm.TabIndex = 12
        Me.lblFarm.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblGrandma
        '
        Me.lblGrandma.BackColor = System.Drawing.Color.Transparent
        Me.lblGrandma.Enabled = False
        Me.lblGrandma.Font = New System.Drawing.Font("Lucida Console", 12.75!)
        Me.lblGrandma.Location = New System.Drawing.Point(252, 63)
        Me.lblGrandma.Name = "lblGrandma"
        Me.lblGrandma.Size = New System.Drawing.Size(65, 55)
        Me.lblGrandma.TabIndex = 11
        Me.lblGrandma.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblCursor
        '
        Me.lblCursor.BackColor = System.Drawing.Color.Transparent
        Me.lblCursor.Enabled = False
        Me.lblCursor.Font = New System.Drawing.Font("Lucida Console", 12.75!)
        Me.lblCursor.Location = New System.Drawing.Point(252, 2)
        Me.lblCursor.Name = "lblCursor"
        Me.lblCursor.Size = New System.Drawing.Size(65, 55)
        Me.lblCursor.TabIndex = 10
        Me.lblCursor.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'btnAntimatterCondenser
        '
        Me.btnAntimatterCondenser.Enabled = False
        Me.btnAntimatterCondenser.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAntimatterCondenser.Font = New System.Drawing.Font("Lucida Console", 12.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAntimatterCondenser.Location = New System.Drawing.Point(0, 540)
        Me.btnAntimatterCondenser.Name = "btnAntimatterCondenser"
        Me.btnAntimatterCondenser.Padding = New System.Windows.Forms.Padding(40, 0, 0, 0)
        Me.btnAntimatterCondenser.Size = New System.Drawing.Size(321, 60)
        Me.btnAntimatterCondenser.TabIndex = 9
        Me.btnAntimatterCondenser.Text = "Antimatter Condenser"
        Me.btnAntimatterCondenser.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnAntimatterCondenser.UseVisualStyleBackColor = True
        '
        'btnTimeMachine
        '
        Me.btnTimeMachine.Enabled = False
        Me.btnTimeMachine.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnTimeMachine.Font = New System.Drawing.Font("Lucida Console", 12.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnTimeMachine.Location = New System.Drawing.Point(0, 480)
        Me.btnTimeMachine.Name = "btnTimeMachine"
        Me.btnTimeMachine.Padding = New System.Windows.Forms.Padding(40, 0, 0, 0)
        Me.btnTimeMachine.Size = New System.Drawing.Size(321, 60)
        Me.btnTimeMachine.TabIndex = 8
        Me.btnTimeMachine.Text = "Time Machine"
        Me.btnTimeMachine.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnTimeMachine.UseVisualStyleBackColor = True
        '
        'btnPortal
        '
        Me.btnPortal.Enabled = False
        Me.btnPortal.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnPortal.Font = New System.Drawing.Font("Lucida Console", 12.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPortal.Location = New System.Drawing.Point(0, 420)
        Me.btnPortal.Name = "btnPortal"
        Me.btnPortal.Padding = New System.Windows.Forms.Padding(40, 0, 0, 0)
        Me.btnPortal.Size = New System.Drawing.Size(321, 60)
        Me.btnPortal.TabIndex = 7
        Me.btnPortal.Text = "Portal"
        Me.btnPortal.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnPortal.UseVisualStyleBackColor = True
        '
        'btnAlchemyLab
        '
        Me.btnAlchemyLab.Enabled = False
        Me.btnAlchemyLab.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAlchemyLab.Font = New System.Drawing.Font("Lucida Console", 12.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAlchemyLab.Location = New System.Drawing.Point(0, 360)
        Me.btnAlchemyLab.Name = "btnAlchemyLab"
        Me.btnAlchemyLab.Padding = New System.Windows.Forms.Padding(40, 0, 0, 0)
        Me.btnAlchemyLab.Size = New System.Drawing.Size(321, 60)
        Me.btnAlchemyLab.TabIndex = 6
        Me.btnAlchemyLab.Text = "Alchemy Lab"
        Me.btnAlchemyLab.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnAlchemyLab.UseVisualStyleBackColor = True
        '
        'btnShipment
        '
        Me.btnShipment.Enabled = False
        Me.btnShipment.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnShipment.Font = New System.Drawing.Font("Lucida Console", 12.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnShipment.Location = New System.Drawing.Point(0, 300)
        Me.btnShipment.Name = "btnShipment"
        Me.btnShipment.Padding = New System.Windows.Forms.Padding(40, 0, 0, 0)
        Me.btnShipment.Size = New System.Drawing.Size(321, 60)
        Me.btnShipment.TabIndex = 5
        Me.btnShipment.Text = "Shipment"
        Me.btnShipment.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnShipment.UseVisualStyleBackColor = True
        '
        'btnMine
        '
        Me.btnMine.Enabled = False
        Me.btnMine.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnMine.Font = New System.Drawing.Font("Lucida Console", 12.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnMine.Location = New System.Drawing.Point(0, 240)
        Me.btnMine.Name = "btnMine"
        Me.btnMine.Padding = New System.Windows.Forms.Padding(40, 0, 0, 0)
        Me.btnMine.Size = New System.Drawing.Size(321, 60)
        Me.btnMine.TabIndex = 4
        Me.btnMine.Text = "Mine"
        Me.btnMine.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnMine.UseVisualStyleBackColor = True
        '
        'btnFactory
        '
        Me.btnFactory.Enabled = False
        Me.btnFactory.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnFactory.Font = New System.Drawing.Font("Lucida Console", 12.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnFactory.Location = New System.Drawing.Point(0, 180)
        Me.btnFactory.Name = "btnFactory"
        Me.btnFactory.Padding = New System.Windows.Forms.Padding(40, 0, 0, 0)
        Me.btnFactory.Size = New System.Drawing.Size(321, 60)
        Me.btnFactory.TabIndex = 3
        Me.btnFactory.Text = "Factory"
        Me.btnFactory.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnFactory.UseVisualStyleBackColor = True
        '
        'btnFarm
        '
        Me.btnFarm.Enabled = False
        Me.btnFarm.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnFarm.Font = New System.Drawing.Font("Lucida Console", 12.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnFarm.Location = New System.Drawing.Point(0, 120)
        Me.btnFarm.Name = "btnFarm"
        Me.btnFarm.Padding = New System.Windows.Forms.Padding(40, 0, 0, 0)
        Me.btnFarm.Size = New System.Drawing.Size(321, 60)
        Me.btnFarm.TabIndex = 2
        Me.btnFarm.Tag = ""
        Me.btnFarm.Text = "Farm"
        Me.btnFarm.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnFarm.UseVisualStyleBackColor = True
        '
        'btnGrandma
        '
        Me.btnGrandma.Enabled = False
        Me.btnGrandma.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnGrandma.Font = New System.Drawing.Font("Lucida Console", 12.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnGrandma.Location = New System.Drawing.Point(0, 60)
        Me.btnGrandma.Name = "btnGrandma"
        Me.btnGrandma.Padding = New System.Windows.Forms.Padding(40, 0, 0, 0)
        Me.btnGrandma.Size = New System.Drawing.Size(321, 60)
        Me.btnGrandma.TabIndex = 1
        Me.btnGrandma.Tag = ""
        Me.btnGrandma.Text = "Grandma"
        Me.btnGrandma.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnGrandma.UseVisualStyleBackColor = True
        '
        'btnCursor
        '
        Me.btnCursor.Enabled = False
        Me.btnCursor.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCursor.Font = New System.Drawing.Font("Lucida Console", 12.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCursor.Location = New System.Drawing.Point(0, 0)
        Me.btnCursor.Name = "btnCursor"
        Me.btnCursor.Padding = New System.Windows.Forms.Padding(40, 0, 0, 0)
        Me.btnCursor.Size = New System.Drawing.Size(321, 60)
        Me.btnCursor.TabIndex = 0
        Me.btnCursor.Tag = ""
        Me.btnCursor.Text = "Cursor"
        Me.btnCursor.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnCursor.UseVisualStyleBackColor = True
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
        Me.pnlUpgrades.BackColor = System.Drawing.Color.Transparent
        Me.pnlUpgrades.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pnlUpgrades.Controls.Add(Me.lblStore)
        Me.pnlUpgrades.Location = New System.Drawing.Point(744, 0)
        Me.pnlUpgrades.Name = "pnlUpgrades"
        Me.pnlUpgrades.Size = New System.Drawing.Size(340, 81)
        Me.pnlUpgrades.TabIndex = 4
        '
        'lblStore
        '
        Me.lblStore.Font = New System.Drawing.Font("Book Antiqua", 15.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblStore.ForeColor = System.Drawing.Color.White
        Me.lblStore.Location = New System.Drawing.Point(3, 0)
        Me.lblStore.Name = "lblStore"
        Me.lblStore.Size = New System.Drawing.Size(332, 23)
        Me.lblStore.TabIndex = 0
        Me.lblStore.Text = "Store"
        Me.lblStore.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'CookieClicker
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.CookieClickerClone.My.Resources.Resources.bg
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
        CType(Me.picCookie, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlRight.ResumeLayout(False)
        CType(Me.picAntimatterCondenser, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picTimeMachine, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picPortal, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picAlchemyLab, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picShipment, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picMine, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picFactory, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picFarm, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picGrandma, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picCursor, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlUpgrades.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents pnlLeft As System.Windows.Forms.Panel
    Friend WithEvents tmrCounter As System.Windows.Forms.Timer
    Friend WithEvents pnlCenter As System.Windows.Forms.Panel
    Friend WithEvents pnlRight As System.Windows.Forms.Panel
    Friend WithEvents picCookie As System.Windows.Forms.PictureBox
    Friend WithEvents pnlMessages As System.Windows.Forms.Panel
    Friend WithEvents pnlUpgrades As System.Windows.Forms.Panel
    Friend WithEvents lblCpS As System.Windows.Forms.Label
    Friend WithEvents lblCurrentCookies As System.Windows.Forms.Label
    Friend WithEvents lblStore As System.Windows.Forms.Label
    Friend WithEvents btnMine As System.Windows.Forms.Button
    Friend WithEvents btnFactory As System.Windows.Forms.Button
    Friend WithEvents btnFarm As System.Windows.Forms.Button
    Friend WithEvents btnGrandma As System.Windows.Forms.Button
    Friend WithEvents btnCursor As System.Windows.Forms.Button
    Friend WithEvents btnAlchemyLab As System.Windows.Forms.Button
    Friend WithEvents btnShipment As System.Windows.Forms.Button
    Friend WithEvents btnTimeMachine As System.Windows.Forms.Button
    Friend WithEvents btnPortal As System.Windows.Forms.Button
    Friend WithEvents btnAntimatterCondenser As System.Windows.Forms.Button
    Friend WithEvents lblCursor As System.Windows.Forms.Label
    Friend WithEvents lblShipment As System.Windows.Forms.Label
    Friend WithEvents lblMine As System.Windows.Forms.Label
    Friend WithEvents lblFactory As System.Windows.Forms.Label
    Friend WithEvents lblFarm As System.Windows.Forms.Label
    Friend WithEvents lblGrandma As System.Windows.Forms.Label
    Friend WithEvents lblAntimatterCondenser As System.Windows.Forms.Label
    Friend WithEvents lblTimeMachine As System.Windows.Forms.Label
    Friend WithEvents lblPortal As System.Windows.Forms.Label
    Friend WithEvents lblAlchemyLab As System.Windows.Forms.Label
    Friend WithEvents picAntimatterCondenser As System.Windows.Forms.PictureBox
    Friend WithEvents picTimeMachine As System.Windows.Forms.PictureBox
    Friend WithEvents picPortal As System.Windows.Forms.PictureBox
    Friend WithEvents picAlchemyLab As System.Windows.Forms.PictureBox
    Friend WithEvents picShipment As System.Windows.Forms.PictureBox
    Friend WithEvents picMine As System.Windows.Forms.PictureBox
    Friend WithEvents picFactory As System.Windows.Forms.PictureBox
    Friend WithEvents picFarm As System.Windows.Forms.PictureBox
    Friend WithEvents picGrandma As System.Windows.Forms.PictureBox
    Friend WithEvents picCursor As System.Windows.Forms.PictureBox

End Class

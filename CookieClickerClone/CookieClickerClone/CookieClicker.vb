Public Class CookieClicker
    Dim currentCookies As Long = 0
    Dim alltimeCookies As Long = 0
    Dim buildingsOwned As Integer = 0
    Dim CpS As Double = 0.0             'cookies per second
    Dim cookiesPerClick As Long = 1
    Dim handMadeCookies As Long = 0
    Dim goldenCookies As Integer = 0

    Shadows cursor As New Cursor
    Dim grandma As New Grandma
    Dim farm As New Farm
    Dim factory As New Factory
    Dim mine As New Mine
    Dim shipment As New Shipment
    Dim alchemyLab As New AlchemyLab
    Dim portal As New Portal
    Dim timeMachine As New TimeMachine
    Dim antimatterCondenser As New AntimatterCondenser

    'used to persistantly update values
    Dim enableButtonsThread As New System.Threading.Thread(AddressOf Me.enableButtons)

    'Keeping track of the generators listed on the form (pic, button, label)
    Const NUMBER_OF_GENERATORS = 10
    Dim generatorArray(NUMBER_OF_GENERATORS, 3) As Object 'each element of generatorArray contains: [pic, button, label]
    Dim typeArray() As Generator = {cursor, grandma, farm, factory, mine, shipment, alchemyLab, portal, timeMachine, antimatterCondenser}

    Dim time As Integer = 0

    Public Shared Sub Main()

        Dim form As CookieClicker = New CookieClicker()
        form.tmrCounter.Start()
        Application.Run(form)

        'persistantly check for which things can be purchased
        form.enableButtonsThread.IsBackground = True
        form.enableButtonsThread.Start()

    End Sub

    'timer will tick every tenth of a second
    Private Sub tmrCounter_Tick(ByVal sender As Object, ByVal e As System.EventArgs) Handles tmrCounter.Tick
        If enableButtonsThread.IsAlive Then
            enableButtonsThread.Suspend()
        End If
        
        'update values
        time += 1
        currentCookies += CpS / 10
        alltimeCookies += CpS / 10

        'update displays
        lblCurrentCookies.Text = currentCookies

        If time Mod 10 = 0 Then 'one second has passed

        End If

        If enableButtonsThread.IsAlive Then
            enableButtonsThread.Resume()
        End If

    End Sub

    Private Sub picCookie_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles picCookie.Click
        'update values
        currentCookies += 1
        alltimeCookies += 1

        'update displays
        lblCurrentCookies.Text = currentCookies

        'enable necessary buttons
        enableButtons()

    End Sub

    Private Sub cursor_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles picCursor.Click, btnCursor.Click, lblCursor.Click

    End Sub

    'continuously enable/disable all generators that can/can't be purchased with the current amount of currency possessed
    Private Sub enableButtons()
        'each element of generatorArray contains: [pic, button, label]
        'the following code populates the list of generators
        Dim index() As Integer = {0, 0, 0}    'keep track of number of [pic, button, label] seen

        'For Each obj As Object In pnlRight.Controls
        'If TypeOf obj Is PictureBox Then
        'End If
        'Next

        For Each item As Control In pnlRight.Controls
            If TypeOf item Is PictureBox Then
                generatorArray(index(0), 0) = item
                index(0) += 1
            ElseIf TypeOf item Is Button Then
                generatorArray(index(1), 1) = item
                index(1) += 1
            ElseIf TypeOf item Is Label Then
                generatorArray(index(2), 2) = item
                index(2) += 1
            End If
        Next

        'code for enabling/disabling buttons
        While (True)
            For i As Integer = 0 To NUMBER_OF_GENERATORS - 1
                'if player has enough money to buy a generator, the correspoding button, etc. should be enabled & vise-versa
                If currentCookies < typeArray(i).getCost() Then
                    TryCast(generatorArray(i, 0), PictureBox).Enabled = False
                    TryCast(generatorArray(i, 1), Button).Enabled = False
                    TryCast(generatorArray(i, 2), Label).Enabled = False
                Else
                    TryCast(generatorArray(i, 0), PictureBox).Enabled = True
                    TryCast(generatorArray(i, 1), Button).Enabled = True
                    TryCast(generatorArray(i, 2), Label).Enabled = True
                End If
            Next

        End While
    End Sub
End Class

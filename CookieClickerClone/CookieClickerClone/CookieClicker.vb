Public Class CookieClicker
    Dim currentCookies As Double = 1000.0   'cookies onhand
    Dim alltimeCookies As Double = 0        'all cookies made ever
    Dim buildingsOwned As Integer = 0   'generators owned
    Dim CpS As Double = 1.2             'cookies per second
    Dim cookiesPerClick As Long = 1     'cookies received for clicking the cookie
    Dim handMadeCookies As Long = 0     'cookies made by clicking and golden cookie clicks
    Dim goldenCookies As Integer = 0    'golden cookies clicked
    Dim multiplyer As Double = 1.0      'some upgrades will change this

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

    'Keeping track of the generators listed on the form (button, label)
    Const NUMBER_OF_GENERATORS = 10
    Dim generatorArray(NUMBER_OF_GENERATORS - 1, 1) As Object 'each element of generatorArray contains: [button, label]
    Dim typeArray() As Generator = {antimatterCondenser, timeMachine, portal, alchemyLab, shipment, mine, factory, farm, grandma, cursor}

    Dim time As Integer = 0

    Public Shared Sub Main()
        'each element of generatorArray contains: [button, label]
        'the following code populates the list of generators
        Dim index() As Integer = {0, 0}    'keep track of number of [button, label] seen

        Dim form As CookieClicker = New CookieClicker()

        For Each item As Control In form.pnlRight.Controls
            If TypeOf item Is Button Then
                form.generatorArray(index(0), 0) = TryCast(item, Button)
                index(0) += 1
            ElseIf TypeOf item Is Label Then
                form.generatorArray(index(1), 1) = TryCast(item, Label)
                index(1) += 1
            End If
        Next

        form.tmrCounter.Start()
        form.tmrButtonEnabler.Start()
        Application.Run(form)

    End Sub

    'timer will tick every tenth of a second
    Private Sub tmrCounter_Tick(ByVal sender As Object, ByVal e As System.EventArgs) Handles tmrCounter.Tick

        'update values
        time += 1
        currentCookies += CpS * tmrCounter.Interval / 1000
        alltimeCookies += CpS * tmrCounter.Interval / 1000

        'update displays
        lblCurrentCookies.Text = Math.Round(currentCookies, 1)

    End Sub

    Private Sub picCookie_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles picCookie.Click
        'update values
        currentCookies += cookiesPerClick
        alltimeCookies += cookiesPerClick
        handMadeCookies += cookiesPerClick

        'update displays
        lblCurrentCookies.Text = Math.Round(currentCookies, 1)

    End Sub

    'called by a timer every tick to persistently check which buttons can be enabled
    Private Sub enableButtons()
        'used to persistantly update values
        'code for enabling/disabling buttons
        For i As Integer = 0 To NUMBER_OF_GENERATORS - 1
            'if player has enough money to buy a generator, the correspoding button, etc. should be enabled & vise-versa
            If currentCookies < typeArray(i).getCost() Then
                TryCast(generatorArray(i, 0), Button).Enabled = False
                TryCast(generatorArray(i, 1), Label).Enabled = False
            Else
                TryCast(generatorArray(i, 0), Button).Enabled = True
                TryCast(generatorArray(i, 1), Label).Enabled = True
            End If
        Next

    End Sub

    'continuously enable/disable all generators that can/can't be purchased with the current amount of currency possessed
    Private Sub tmrButtonEnabler_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tmrButtonEnabler.Tick
        enableButtons()
    End Sub

    'handles events for the label and button that make up a Generator's button
    Private Sub cursor_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCursor.Click, lblCursor.Click
        currentCookies -= cursor.getCost
        buildingsOwned += 1
        CpS += cursor.getCpS
        cursor.updateCost()

        'update displays
        'cost
        btnCursor.Text = "Cursor: " + Convert.ToString(cursor.getCost)
        'number owned
        cursor.Quantity() = 1
        lblCursor.Text = cursor.Quantity()
    End Sub
End Class

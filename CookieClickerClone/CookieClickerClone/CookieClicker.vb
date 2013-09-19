Public Class CookieClicker
    Dim currentCookies As Integer = 0
    Dim alltimeCookies As Integer = 0
    Dim buildingsOwned As Integer = 0
    Dim CpS As Double = 0.0             'cookies per second
    Dim cookiesPerClick As Integer = 1
    Dim handMadeCookies As Integer = 0
    Dim goldenCookies As Integer = 0

    Dim time As Double = 0

    Public Shared Sub Main()

        Dim form As CookieClicker = New CookieClicker()
        form.tmrCounter.Start()
        Application.Run(form)

    End Sub

    'timer will tick every tenth of a second
    Private Sub tmrCounter_Tick(ByVal sender As Object, ByVal e As System.EventArgs) Handles tmrCounter.Tick
        time += 0.1
        Label1.Text = time
    End Sub
End Class

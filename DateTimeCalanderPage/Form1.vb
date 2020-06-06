Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim today As Date = Date.Now

        LblYear.Text = Format(today, "yyyy")
        LblMonth.Text = Format(today, "MMM")
        LblDay.Text = Format(today, "dd")
        LblTime.Text = Format("hh:mm:ss")
        Timer1.Start()
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Dim temp As Date = Date.Now
        LblTime.Text = Format(temp, "hh:mm:ss")
        Text = Format(temp, "D")
    End Sub

End Class

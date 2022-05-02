Public Class Form1

    Dim i, c, redon, n, ib As Integer
    Dim x(), y(), vx, vy As Single

    Private Sub salir_Click(sender As Object, e As EventArgs) Handles salir.Click
        End
    End Sub

    Dim g As Graphics


    Private Sub pg_Click(sender As Object, e As EventArgs) Handles pg.Click

        redon = c + 2

        vy = (((vx - x(ib + 1)) / (x(ib) - x(ib + 1))) * y(ib)) + (((vx - x(ib)) / (x(ib + 1) - x(ib))) * y(ib + 1))
        tv.Text = Math.Round(vy, redon)
    End Sub

    Private Sub sg_Click(sender As Object, e As EventArgs) Handles sg.Click

        redon = c + 2

        vy = (((vx - x(ib + 1)) * (vx - x(ib + 2))) / ((x(ib) - x(ib + 1)) * (x(ib) - x(ib + 2))) * y(ib))
        tv.Text = Math.Round(vy, redon)

    End Sub



    Private Sub parejas_Click(sender As Object, e As EventArgs) Handles parejas.Click

        n = tn.Text
        c = tc.Text
        vx = tx.Text
        ReDim x(0 To n)
        ReDim y(0 To n)

        For i = 0 To n - 1

            x(i) = InputBox(" x(" & i & ")= ")
            y(i) = InputBox(" y(" & i & ")= ")

            salida.Rows.Add(i, x(i), y(i))
        Next

        'For i = 0 To n - 1
        ' If vx > x(i) Then
        'ib = i
        'End If
        'Next 
        i = 0
        Do While vx > x(i)
            i = i + 1

        Loop
        ib = i - 1
        ibb.Text = ib

    End Sub

    Private Sub graficar_Click(sender As Object, e As EventArgs) Handles graficar.Click
        g = graf.CreateGraphics()


        For i = 0 To n - 1
            graf.Series(0).Points.AddXY(Math.Round(x(i), 1), y(i))
        Next

        graf.Series(1).Points.AddXY(Math.Round(vx, 1), vy)

    End Sub





End Class

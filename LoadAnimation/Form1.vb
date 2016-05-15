Public Class Form1
    Dim TimeInt As Integer
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        TimeInt = 0
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick

        TimeInt = TimeInt + 1

        If TimeInt = 1 Then
            img1.Visible = True
            img2.Visible = False
            img3.Visible = False
            img4.Visible = False
            img5.Visible = False
            img6.Visible = False
            img7.Visible = False
            img8.Visible = False
        End If

        If TimeInt = 2 Then
            img1.Visible = False
            img2.Visible = True
            img3.Visible = False
            img4.Visible = False
            img5.Visible = False
            img6.Visible = False
            img7.Visible = False
            img8.Visible = False
        End If

        If TimeInt = 3 Then
            img1.Visible = False
            img2.Visible = False
            img3.Visible = True
            img4.Visible = False
            img5.Visible = False
            img6.Visible = False
            img7.Visible = False
            img8.Visible = False
        End If

        If TimeInt = 4 Then
            img1.Visible = False
            img2.Visible = False
            img3.Visible = False
            img4.Visible = True
            img5.Visible = False
            img6.Visible = False
            img7.Visible = False
            img8.Visible = False
        End If

        If TimeInt = 5 Then
            img1.Visible = False
            img2.Visible = False
            img3.Visible = False
            img4.Visible = False
            img5.Visible = True
            img6.Visible = False
            img7.Visible = False
            img8.Visible = False
        End If

        If TimeInt = 6 Then
            img1.Visible = False
            img2.Visible = False
            img3.Visible = False
            img4.Visible = False
            img5.Visible = False
            img6.Visible = True
            img7.Visible = False
            img8.Visible = False
        End If

        If TimeInt = 7 Then
            img1.Visible = False
            img2.Visible = False
            img3.Visible = False
            img4.Visible = False
            img5.Visible = False
            img6.Visible = False
            img7.Visible = True
            img8.Visible = False
        End If

        If TimeInt = 8 Then
            img1.Visible = False
            img2.Visible = False
            img3.Visible = False
            img4.Visible = False
            img5.Visible = False
            img6.Visible = False
            img7.Visible = False
            img8.Visible = True
            TimeInt = 0
        End If
    End Sub

End Class

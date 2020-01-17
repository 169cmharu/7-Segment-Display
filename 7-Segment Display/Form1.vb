Public Class Form1
    Private counter As Integer
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        If counter = 0 Then
            DisplayDigit(True, True, True, True, True, True, False)
        ElseIf counter = 1 Then
            DisplayDigit(False, True, True, False, False, False, False)
        ElseIf counter = 2 Then
            DisplayDigit(True, True, False, True, True, False, True)
        ElseIf counter = 3 Then
            DisplayDigit(True, True, True, True, False, False, True)
        ElseIf counter = 4 Then
            DisplayDigit(False, True, True, False, False, True, True)
        ElseIf counter = 5 Then
            DisplayDigit(True, False, True, True, False, True, True)
        ElseIf counter = 6 Then
            DisplayDigit(True, False, True, True, True, True, True)
        ElseIf counter = 7 Then
            DisplayDigit(True, True, True, False, False, False, False)
        ElseIf counter = 8 Then
            DisplayDigit(True, True, True, True, True, True, True)
        ElseIf counter = 9 Then
            DisplayDigit(True, True, True, True, False, True, True)
            counter = -1
        End If
        counter += 1
    End Sub

    Function DisplayDigit(ByVal segA As Boolean, ByVal segB As Boolean, ByVal segC As Boolean, ByVal segD As Boolean, ByVal segE As Boolean, ByVal segF As Boolean, ByVal segG As Boolean) As Integer
        If segA = True Then
            seg_a.BackColor = Color.Red
        Else
            seg_a.BackColor = Color.DimGray
        End If

        If segB = True Then
            seg_b.BackColor = Color.Red
        Else
            seg_b.BackColor = Color.DimGray
        End If

        If segC = True Then
            seg_c.BackColor = Color.Red
        Else
            seg_c.BackColor = Color.DimGray
        End If

        If segD = True Then
            seg_d.BackColor = Color.Red
        Else
            seg_d.BackColor = Color.DimGray
        End If

        If segE = True Then
            seg_e.BackColor = Color.Red
        Else
            seg_e.BackColor = Color.DimGray
        End If

        If segF = True Then
            seg_f.BackColor = Color.Red
        Else
            seg_f.BackColor = Color.DimGray
        End If

        If segG = True Then
            seg_g.BackColor = Color.Red
        Else
            seg_g.BackColor = Color.DimGray
        End If

        Return Nothing
    End Function
End Class

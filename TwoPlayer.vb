Public Class TwoPlayer
    Dim MiseJ1 As Integer
    Dim MiseJ2 As Integer
    Private Sub BtnFermer_Click(sender As Object, e As EventArgs) Handles BtnFermer.Click
        Me.Close()
    End Sub



    Private Sub TwoPlayer_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub btnJ1_Click(sender As Object, e As EventArgs) Handles btnJ1.Click

        Dim i As Integer
        Dim j As Integer
        Dim k As Integer

        If MiseJ1 >= 2 Then



            My.Computer.Audio.Play("image\roule.wav")
            For tourne = 1 To 30
                Dim random As New Random()
                Threading.Thread.Sleep(200)
                Update()
                i = random.Next(1, 10)
                j = random.Next(1, 10)
                k = random.Next(1, 10)



                Dim MonImage1 As String = "image\jpot" & Trim(Str(i)) & ".jpg"
                Dim MonImage2 As String = "image\jpot" & Trim(Str(j)) & ".jpg"
                Dim MonImage3 As String = "image\jpot" & Trim(Str(k)) & ".jpg"

                Me.PB1.Load(MonImage1)
                Me.PB2.Load(MonImage2)
                Me.PB3.Load(MonImage3)


                lb1.Text = i
                lb2.Text = j
                lb3.Text = k


            Next

            If i <> j <> k Then
                lb7.Text = "perdu"
                lb8.Text = "1"
                MiseJ1 -= 1
                lblJ1.Text = MiseJ1
            End If

            If i = j Or i = k Or j = k Then
                lb7.Text = "gagne"
                lb8.Text = "5"
                MiseJ1 += 5
                lblJ1.Text = MiseJ1
            End If

            If i <= 3 And j <= 3 And k <= 3 Or
                3 < i > 6 And 3 < j > 6 And 3 < k > 6 Or
                i > 6 And j > 6 And k > 6 Then
                lb7.Text = "gagne"
                lb8.Text = "BANCO 10"
                MiseJ1 += 10
                lblJ1.Text = MiseJ1
            End If

            If i = j And i = k And j = k Then
                lb7.Text = "gagne"
                lb8.Text = "SUPER BANCO 20"
                My.Computer.Audio.Play("image\banco.wav")
                MiseJ1 += 20
                lblJ1.Text = MiseJ1
            End If
        End If
        If MiseJ1 < 2 Then
            MsgBox("le joueur 1 manque Decimal jeton pour jouer !")
        End If


    End Sub

    Private Sub btnJ2_Click(sender As Object, e As EventArgs) Handles btnJ2.Click


        Dim l As Integer
        Dim m As Integer
        Dim n As Integer

        If MiseJ2 >= 2 Then


            My.Computer.Audio.Play("image\roule.wav")
            For tourne = 1 To 30
                Dim random As New Random()


                Threading.Thread.Sleep(200)
                Update()

                l = random.Next(1, 10)
                m = random.Next(1, 10)
                n = random.Next(1, 10)


                Dim MonImage4 As String = "image\jpot" & Trim(Str(l)) & ".jpg"
                Dim MonImage5 As String = "image\jpot" & Trim(Str(m)) & ".jpg"
                Dim MonImage6 As String = "image\jpot" & Trim(Str(n)) & ".jpg"


                Me.PB4.Load(MonImage4)
                Me.PB5.Load(MonImage5)
                Me.PB6.Load(MonImage6)


                lb4.Text = l
                lb5.Text = m
                lb6.Text = n

            Next

            If l <> m <> n Then
                lb9.Text = "perdu"
                lb10.Text = "1"
                MiseJ2 -= 1
                lblJ2.Text = MiseJ2
            End If

            If l = m Or l = n Or m = n Then
                lb9.Text = "gagne"
                lb10.Text = "5"
                MiseJ2 += 5
                lblJ2.Text = MiseJ2
            End If

            If l <= 3 And m <= 3 And n <= 3 Or
                3 < l > 6 And 3 < m > 6 And 3 < n > 6 Or
                l > 6 And n > 6 And m > 6 Then
                lb9.Text = "gagne"
                lb10.Text = "10"
                MiseJ2 += 10
                lblJ2.Text = MiseJ2
            End If

            If l = m And m = n And l = n Then
                lb9.Text = "gagne"
                lb10.Text = "BANCO 20"
                My.Computer.Audio.Play("image\banco.wav")
                MiseJ2 += 20
                lblJ2.Text = MiseJ2
            End If
        End If

        If MiseJ2 < 2 Then
            MsgBox("le joueur 2 n'a pas assez de jeton pour jouer !")
        End If
    End Sub

    Private Sub Label13_Click(sender As Object, e As EventArgs) Handles lblJ1.Click

    End Sub

    Private Sub btnAJ2_Click(sender As Object, e As EventArgs) Handles btnAJ2.Click
        MiseJ2 += 5
        lblJ2.Text = MiseJ2
    End Sub

    Private Sub btnAJ1_Click(sender As Object, e As EventArgs) Handles btnAJ1.Click
        MiseJ1 += 5
        lblJ1.Text = MiseJ1
    End Sub
End Class
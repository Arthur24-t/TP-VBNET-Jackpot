Public Class Jackpot
    Dim i As Integer
    Dim j As Integer
    Dim k As Integer
    Dim mise As Integer
    Private Sub BtnFermer_Click(sender As Object, e As EventArgs) Handles BtnFermer.Click
        My.Computer.Audio.Play("image\aurevoir.wav", AudioPlayMode.WaitToComplete)
        Me.Close()

    End Sub

    Private Sub BtnJouer_Click(sender As Object, e As EventArgs) Handles BtnJouer.Click
        My.Computer.Audio.Play("image\CLIC.wav")

        If mise >= 2 Then
            mise -= 2
            lblMise.Text = mise


            My.Computer.Audio.Play("image\roule.wav")
            For tourne = 1 To 25
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
                lb4.Text = "perdu"
                lb5.Text = "1"
                mise -= 1
                lblMise.Text = mise
            End If

            If i = j Or i = k Or j = k Then
                lb4.Text = "gagne"
                lb5.Text = "5"
                mise += 5
                lblMise.Text = mise
            End If

            If i <= 3 And j <= 3 And k <= 3 Or
                3 < i > 6 And 3 < j > 6 And 3 < k > 6 Or
                i > 6 And j > 6 And k > 6 Then
                lb4.Text = "gagne"
                lb5.Text = "10"
                mise += 10
                lblMise.Text = mise
            End If

            If i = j And i = k And j = k Then
                lb4.Text = "gagne"
                lb5.Text = "BANCO 20"
                My.Computer.Audio.Play("image\banco.wav")
                mise += 20
                lblMise.Text = mise
            End If

        End If
        If mise < 2 Then
            MsgBox("vous n'avez pas assez d'argent rajouter en")
        End If



    End Sub

    Private Sub BtnTwoPlayer_Click(sender As Object, e As EventArgs) Handles BtnTwoPlayer.Click
        TwoPlayer.Show()
    End Sub

    Private Sub lb5_Click(sender As Object, e As EventArgs) Handles lb5.Click

    End Sub

    Private Sub lb4_Click(sender As Object, e As EventArgs) Handles lb4.Click

    End Sub

    Private Sub btnArgent_Click(sender As Object, e As EventArgs) Handles btnArgent.Click
        mise += 5
        lblMise.Text = mise
        Update()
    End Sub
End Class

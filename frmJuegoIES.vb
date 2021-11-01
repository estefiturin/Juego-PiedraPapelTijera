Public Class frmJuegoIES

    Dim rounds As Integer = 3
    Dim timerPerRound As Integer = 6
    Dim gameover As Boolean = False

    Dim CPUchoiceList As String() = {"Piedra", "Papel", "Tijera", "Papel", "Tijera", "Piedra"}

    Dim randomNumber As Integer = 0
    Dim rnd As Random = New Random()

    Dim CPUChoice As String

    Dim playerChoice As String

    Dim playerScore As Integer
    Dim CPUScore As Integer
    Dim Winner As Integer
    Dim Loser As Integer



    Public Sub New()


        InitializeComponent()

        countDownTimer.Enabled = True

        playerChoice = "ninguno"

        txtCountDown.Text = "5"


    End Sub

    Private Sub btnRock_Click(sender As Object, e As EventArgs) Handles btnRock.Click
        picplayer.Image = My.Resources.piedra
        playerChoice = "Piedra"
    End Sub

    Private Sub btnPapel_Click(sender As Object, e As EventArgs) Handles btnPapel.Click
        picplayer.Image = My.Resources.Papel
        playerChoice = "Papel"
    End Sub

    Private Sub btnScissors_Click(sender As Object, e As EventArgs) Handles btnScissors.Click
        picplayer.Image = My.Resources.Tijera
        playerChoice = "Tijera"
    End Sub

    Private Sub btnRestart_Click(sender As Object, e As EventArgs) Handles btnRestart.Click

        playerScore = 0
        CPUScore = 0
        rounds = 3

        txtScore.Text = "Jugador: " & playerScore & " - " & "CPU" & CPUScore

        txtganado.Text = "Ha ganado: " & Winner

        txtloser.Text = "Ha Perdido " & Loser

        playerChoice = "ninguno"

        countDownTimer.Enabled = True

        picplayer.Image = My.Resources.Titulo
        picCPU.Image = My.Resources.Titulo


        gameover = False
    End Sub

    Private Sub countDownTimerEvent(sender As Object, e As EventArgs) Handles countDownTimer.Tick
        timerPerRound -= 1

        txtCountDown.Text = timerPerRound.ToString()

        txtRounds.Text = "Rounds:" & rounds

        If (timerPerRound < 1) Then
            countDownTimer.Enabled = False

            timerPerRound = 6

            randomNumber = rnd.Next(0, CPUchoiceList.Length)

            CPUChoice = CPUchoiceList(randomNumber)

            Select Case (CPUChoice)
                Case "Piedra"
                    picCPU.Image = My.Resources.piedra
                Case "Papel"
                    picCPU.Image = My.Resources.Papel
                Case "Tijera"
                    picCPU.Image = My.Resources.Tijera
                Case Else
            End Select

            If (rounds > 0) Then

                checkGame()
            Else
                If (playerScore > CPUScore) Then

                    MessageBox.Show("USUARIO GANA")
                    Winner += 1
                Else

                    MessageBox.Show("CPU GANA")
                    Loser += 1
                End If

                gameover = True

            End If


        End If

    End Sub

    Private Sub checkGame()

        If playerChoice = "Piedra" And CPUChoice = "Papel" Then
            CPUScore += 1

            rounds -= 1

            MessageBox.Show("Gana Computador")
        ElseIf playerChoice = "Tijera" And CPUChoice = "Piedra" Then
            CPUScore += 1

            rounds -= 1

            MessageBox.Show("Gana Computador")

        ElseIf playerChoice = "Papel" And CPUChoice = "Tijera" Then
            CPUScore += 1

            rounds -= 1

            MessageBox.Show("Gana Computador")
        ElseIf playerChoice = "Piedra" And CPUChoice = "Tijera" Then
            playerScore += 1

            rounds -= 1

            MessageBox.Show("Gana Usuario")
        ElseIf playerChoice = "Papel" And CPUChoice = "Piedra" Then
            playerScore += 1

            rounds -= 1

            MessageBox.Show("Gana Usuario")
        ElseIf playerChoice = "Tijera" And CPUChoice = "Papel" Then
            playerScore += 1

            rounds -= 1

            MessageBox.Show("Gana Usuario")
        ElseIf playerChoice = "ninguno" Then
            MessageBox.Show("Elegir opcion ")
        Else
            MessageBox.Show("Empate")
        End If

        startNextRound()
    End Sub
    Private Sub startNextRound()

        If (gameover = True) Then
            Return
        End If

        txtScore.Text = "Jugador: " & playerScore & " - " & "CPU" & CPUScore

        txtganado.Text = "Ha ganado: " & Winner

        txtloser.Text = "Ha Perdido " & Loser

        playerChoice = "ninguno"

        countDownTimer.Enabled = True

        picplayer.Image = My.Resources.Titulo
        picCPU.Image = My.Resources.Titulo


    End Sub

    Private Sub btnSalir_Click(sender As Object, e As EventArgs) Handles btnSalir.Click
        Me.Close()
    End Sub
End Class

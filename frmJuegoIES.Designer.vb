<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmJuegoIES
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.picplayer = New System.Windows.Forms.PictureBox()
        Me.picCPU = New System.Windows.Forms.PictureBox()
        Me.btnRock = New System.Windows.Forms.Button()
        Me.btnPapel = New System.Windows.Forms.Button()
        Me.btnScissors = New System.Windows.Forms.Button()
        Me.btnRestart = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtScore = New System.Windows.Forms.Label()
        Me.txtCountDown = New System.Windows.Forms.Label()
        Me.txtRounds = New System.Windows.Forms.Label()
        Me.countDownTimer = New System.Windows.Forms.Timer(Me.components)
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtganado = New System.Windows.Forms.Label()
        Me.txtloser = New System.Windows.Forms.Label()
        Me.btnSalir = New System.Windows.Forms.Button()
        CType(Me.picplayer, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picCPU, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'picplayer
        '
        Me.picplayer.BackColor = System.Drawing.Color.PeachPuff
        Me.picplayer.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.picplayer.Image = Global.JuegoIES.My.Resources.Resources.Titulo
        Me.picplayer.Location = New System.Drawing.Point(114, 91)
        Me.picplayer.Name = "picplayer"
        Me.picplayer.Size = New System.Drawing.Size(151, 145)
        Me.picplayer.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picplayer.TabIndex = 0
        Me.picplayer.TabStop = False
        '
        'picCPU
        '
        Me.picCPU.BackColor = System.Drawing.Color.PeachPuff
        Me.picCPU.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.picCPU.Image = Global.JuegoIES.My.Resources.Resources.Titulo
        Me.picCPU.Location = New System.Drawing.Point(401, 91)
        Me.picCPU.Name = "picCPU"
        Me.picCPU.Size = New System.Drawing.Size(151, 145)
        Me.picCPU.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picCPU.TabIndex = 1
        Me.picCPU.TabStop = False
        '
        'btnRock
        '
        Me.btnRock.BackColor = System.Drawing.Color.PeachPuff
        Me.btnRock.Location = New System.Drawing.Point(23, 91)
        Me.btnRock.Name = "btnRock"
        Me.btnRock.Size = New System.Drawing.Size(75, 23)
        Me.btnRock.TabIndex = 2
        Me.btnRock.Text = "Piedra"
        Me.btnRock.UseVisualStyleBackColor = False
        '
        'btnPapel
        '
        Me.btnPapel.BackColor = System.Drawing.Color.PeachPuff
        Me.btnPapel.Location = New System.Drawing.Point(23, 154)
        Me.btnPapel.Name = "btnPapel"
        Me.btnPapel.Size = New System.Drawing.Size(75, 23)
        Me.btnPapel.TabIndex = 3
        Me.btnPapel.Text = "Papel"
        Me.btnPapel.UseVisualStyleBackColor = False
        '
        'btnScissors
        '
        Me.btnScissors.BackColor = System.Drawing.Color.PeachPuff
        Me.btnScissors.Location = New System.Drawing.Point(23, 213)
        Me.btnScissors.Name = "btnScissors"
        Me.btnScissors.Size = New System.Drawing.Size(75, 23)
        Me.btnScissors.TabIndex = 4
        Me.btnScissors.Text = "Tijera"
        Me.btnScissors.UseVisualStyleBackColor = False
        '
        'btnRestart
        '
        Me.btnRestart.BackColor = System.Drawing.Color.PeachPuff
        Me.btnRestart.Location = New System.Drawing.Point(477, 242)
        Me.btnRestart.Name = "btnRestart"
        Me.btnRestart.Size = New System.Drawing.Size(75, 23)
        Me.btnRestart.TabIndex = 5
        Me.btnRestart.Text = "Restart"
        Me.btnRestart.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Coral
        Me.Label1.Font = New System.Drawing.Font("Roboto", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(141, 59)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(97, 23)
        Me.Label1.TabIndex = 6
        Me.Label1.Text = "JUGADOR"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Coral
        Me.Label2.Font = New System.Drawing.Font("Roboto Condensed", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(416, 59)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(121, 23)
        Me.Label2.TabIndex = 7
        Me.Label2.Text = "COMPUTADOR"
        '
        'txtScore
        '
        Me.txtScore.AutoSize = True
        Me.txtScore.BackColor = System.Drawing.Color.PeachPuff
        Me.txtScore.Font = New System.Drawing.Font("Roboto Condensed", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtScore.Location = New System.Drawing.Point(241, 269)
        Me.txtScore.Name = "txtScore"
        Me.txtScore.Size = New System.Drawing.Size(179, 23)
        Me.txtScore.TabIndex = 8
        Me.txtScore.Text = "Jugador = 0 -  CPU = 0"
        '
        'txtCountDown
        '
        Me.txtCountDown.AutoSize = True
        Me.txtCountDown.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCountDown.Location = New System.Drawing.Point(321, 146)
        Me.txtCountDown.Name = "txtCountDown"
        Me.txtCountDown.Size = New System.Drawing.Size(30, 31)
        Me.txtCountDown.TabIndex = 9
        Me.txtCountDown.Text = "5"
        '
        'txtRounds
        '
        Me.txtRounds.AutoSize = True
        Me.txtRounds.Font = New System.Drawing.Font("Roboto Black", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtRounds.Location = New System.Drawing.Point(280, 20)
        Me.txtRounds.Name = "txtRounds"
        Me.txtRounds.Size = New System.Drawing.Size(117, 29)
        Me.txtRounds.TabIndex = 10
        Me.txtRounds.Text = "Round: 3 "
        '
        'countDownTimer
        '
        Me.countDownTimer.Interval = 1000
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Roboto Condensed", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(313, 131)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(48, 15)
        Me.Label3.TabIndex = 11
        Me.Label3.Text = "TIEMPO"
        '
        'txtganado
        '
        Me.txtganado.AutoSize = True
        Me.txtganado.Font = New System.Drawing.Font("Roboto Condensed", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtganado.Location = New System.Drawing.Point(40, 259)
        Me.txtganado.Name = "txtganado"
        Me.txtganado.Size = New System.Drawing.Size(88, 19)
        Me.txtganado.TabIndex = 12
        Me.txtganado.Text = "Ha Ganado: "
        '
        'txtloser
        '
        Me.txtloser.AutoSize = True
        Me.txtloser.Font = New System.Drawing.Font("Roboto Condensed", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtloser.Location = New System.Drawing.Point(40, 287)
        Me.txtloser.Name = "txtloser"
        Me.txtloser.Size = New System.Drawing.Size(89, 19)
        Me.txtloser.TabIndex = 13
        Me.txtloser.Text = "Ha Perdido: "
        '
        'btnSalir
        '
        Me.btnSalir.BackColor = System.Drawing.Color.PeachPuff
        Me.btnSalir.Location = New System.Drawing.Point(477, 287)
        Me.btnSalir.Name = "btnSalir"
        Me.btnSalir.Size = New System.Drawing.Size(75, 23)
        Me.btnSalir.TabIndex = 14
        Me.btnSalir.Text = "Salir"
        Me.btnSalir.UseVisualStyleBackColor = False
        '
        'frmJuegoIES
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Coral
        Me.ClientSize = New System.Drawing.Size(621, 328)
        Me.Controls.Add(Me.btnSalir)
        Me.Controls.Add(Me.txtloser)
        Me.Controls.Add(Me.txtganado)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txtRounds)
        Me.Controls.Add(Me.txtCountDown)
        Me.Controls.Add(Me.txtScore)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnRestart)
        Me.Controls.Add(Me.btnScissors)
        Me.Controls.Add(Me.btnPapel)
        Me.Controls.Add(Me.btnRock)
        Me.Controls.Add(Me.picCPU)
        Me.Controls.Add(Me.picplayer)
        Me.Name = "frmJuegoIES"
        Me.Text = "Piedra Papel o Tijera Game"
        CType(Me.picplayer, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picCPU, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents picplayer As PictureBox
    Friend WithEvents picCPU As PictureBox
    Friend WithEvents btnRock As Button
    Friend WithEvents btnPapel As Button
    Friend WithEvents btnScissors As Button
    Friend WithEvents btnRestart As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents txtScore As Label
    Friend WithEvents txtCountDown As Label
    Friend WithEvents txtRounds As Label
    Friend WithEvents countDownTimer As Timer
    Friend WithEvents Label3 As Label
    Friend WithEvents txtganado As Label
    Friend WithEvents txtloser As Label
    Friend WithEvents btnSalir As Button
End Class

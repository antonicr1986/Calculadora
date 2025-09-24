Public Class Calculadora

    Private valorAnterior As Double = 0
    Private operadorActual As String = ""
    Private nuevaEntrada As Boolean = True

    Private calc As New Calculator()

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LimpiarResultado()
    End Sub

    Private Sub LimpiarResultado()
        TextBoxResultado.Text = "0"
    End Sub


#Region "Métodos/operaciones de la calculadora"

    Private Sub BtnOperacion_Click(sender As Object, e As EventArgs) Handles ButtonSumar.Click, ButtonRestar.Click, ButtonMultiplicar.Click, ButtonDividir.Click
        valorAnterior = CDbl(TextBoxResultado.Text)
        operadorActual = CType(sender, Button).Text
        nuevaEntrada = True

        TextBoxValorAnterior.Text = valorAnterior.ToString() & " " & operadorActual

    End Sub

    Private Sub ButtonIgual_Click(sender As Object, e As EventArgs) Handles ButtonIgual.Click
        Try
            Dim valorActual As Double = CDbl(TextBoxResultado.Text)
            Dim resultado As Double

            Select Case operadorActual
                Case "+"
                    resultado = calc.Sumar(valorAnterior, valorActual)
                Case "-"
                    resultado = calc.Restar(valorAnterior, valorActual)
                Case "X"
                    resultado = calc.Multiplicar(valorAnterior, valorActual)
                Case "/"
                    resultado = calc.Dividir(valorAnterior, valorActual)
                Case Else
                    resultado = valorActual
            End Select

            TextBoxResultado.Text = resultado.ToString()
            nuevaEntrada = True
            operadorActual = ""
        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message)
        End Try
    End Sub

#End Region


#Region "Gestión de teclado numerico"
    Private Sub BtnNumero_Click(sender As Object, e As EventArgs) Handles Button0.Click, Button1.Click, Button2.Click, Button3.Click, Button4.Click, Button5.Click, Button6.Click, Button7.Click, Button8.Click, Button9.Click
        Dim boton As Button = CType(sender, Button)

        ' Si es una nueva entrada, limpiamos el campo
        If nuevaEntrada Or TextBoxResultado.Text = "0" Then
            TextBoxResultado.Text = boton.Text
            nuevaEntrada = False
        Else
            TextBoxResultado.Text &= boton.Text
        End If

    End Sub

    Private Sub ButtonCambioSigno_Click(sender As Object, e As EventArgs) Handles ButtonCambioSigno.Click
        Dim textoActual As String = TextBoxResultado.Text

        ' Verificamos si es un número válido
        If IsNumeric(textoActual) Then
            Dim numero As Double = CDbl(textoActual)

            ' Cambiamos el signo
            numero *= -1

            ' Actualizamos el TextBox
            TextBoxResultado.Text = numero.ToString()
        End If

    End Sub

    Private Sub ButtonComa_Click(sender As Object, e As EventArgs) Handles ButtonComa.Click
        If Not TextBoxResultado.Text.Contains(",") Then
            TextBoxResultado.Text &= ","
        End If

    End Sub

#End Region

#Region "Gestión de teclas relacionadas con el borrado"

    Private Sub ButtonC_Click(sender As Object, e As EventArgs) Handles ButtonC.Click


        'Aquí también reseteare otras variables en el futuro
        TextBoxValorAnterior.Text = ""
        valorAnterior = 0
    End Sub

    Private Sub ButtonCE_Click(sender As Object, e As EventArgs) Handles ButtonCE.Click
        LimpiarResultado()

        nuevaEntrada = True 'LChanges
    End Sub

    Private Sub ButtonBorrar1_Click(sender As Object, e As EventArgs) Handles ButtonBorrar1.Click
        Dim textoActual As String = TextBoxResultado.Text

        If textoActual.Length > 1 Then
            TextBoxResultado.Text = textoActual.Substring(0, textoActual.Length - 1)
        Else
            LimpiarResultado()
        End If

    End Sub

#End Region

End Class

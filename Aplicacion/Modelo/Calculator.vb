Public Class Calculator
    Public Function Sumar(a As Double, b As Double) As Double
        Return a + b
    End Function

    Public Function Restar(a As Double, b As Double) As Double
        Return a - b
    End Function

    Public Function Multiplicar(a As Double, b As Double) As Double
        Return a * b
    End Function

    Public Function Dividir(a As Double, b As Double) As Double
        If b = 0 Then Throw New DivideByZeroException()
        Return a / b
    End Function
End Class
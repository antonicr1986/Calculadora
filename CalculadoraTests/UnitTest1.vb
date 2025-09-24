Imports System.Text
Imports Microsoft.VisualStudio.TestTools.UnitTesting
Imports Aplicacion


<TestClass()> Public Class UnitTest1

    Private calc As New Calculator()

    <TestMethod>
    Public Sub TestSumar()
        Dim resultado = calc.Sumar(10, 5)
        Assert.AreEqual(15, resultado)
    End Sub

    <TestMethod>
    Public Sub TestRestar()
        Dim resultado = calc.Restar(10, 5)
        Assert.AreEqual(5, resultado)
    End Sub

    <TestMethod>
    Public Sub TestMultiplicar()
        Dim resultado = calc.Multiplicar(10, 5)
        Assert.AreEqual(50, resultado)
    End Sub

    <TestMethod>
    Public Sub TestDividir()
        Dim resultado = calc.Dividir(10, 2)
        Assert.AreEqual(5, resultado)
    End Sub

    <TestMethod>
    Public Sub TestDividirPorCero()
        Assert.ThrowsException(Of DivideByZeroException)(Function() calc.Dividir(10, 0))
    End Sub

    <TestMethod>
    Public Sub TestSumarNegativos()
        Dim resultado = calc.Sumar(-3, -7)
        Assert.AreEqual(-10, resultado)
    End Sub

    <TestMethod>
    Public Sub TestMultiplicarPorCero()
        Dim resultado = calc.Multiplicar(10, 0)
        Assert.AreEqual(0, resultado)
    End Sub

End Class
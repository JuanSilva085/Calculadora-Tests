using System;
using Xunit;

namespace Test;

public class UnitTest1
{
    [Theory]
    [InlineData (1, 2, 3)]
    [InlineData (5, 4, 9)]
    public void TestSomar(int val1, int val2, int resultado)
    {
        Calculadora calc = new Calculadora();

        int resultadoCalculadora = calc.Somar(val1, val2);

        Assert.Equal(resultado , resultadoCalculadora);
    }

    [Theory]
    [InlineData(2, 1, 1)]
    [InlineData(5, 4, 1)]
    public void TestSubtrair(int val1, int val2, int resultado)
    {
        Calculadora calc = new Calculadora();

        int resultadoCalculadora = calc.Subtrair(val1, val2);

        Assert.Equal(resultado, resultadoCalculadora);
    }

    [Theory]
    [InlineData(1, 2, 2)]
    [InlineData(5, 4, 20)]
    public void TestMultiplicar(int val1, int val2, int resultado)
    {
        Calculadora calc = new Calculadora();

        int resultadoCalculadora = calc.Multiplicar(val1, val2);

        Assert.Equal(resultado, resultadoCalculadora);
    }

    [Theory]
    [InlineData(10, 2, 5)]
    [InlineData(16, 2, 8)]
    public void TestDividir(int val1, int val2, int resultado)
    {
        Calculadora calc = new Calculadora();

        int resultadoCalculadora = calc.Dividir(val1, val2);

        Assert.Equal(resultado, resultadoCalculadora);
    }

    [Fact]
    public void DivisaoPorZero()
    {
        Calculadora calc = new Calculadora();

        Assert.Throws<DivideByZeroException>( () => calc.Dividir(3, 0));
    }

    [Fact]
    public void TestandoHistorico()
    {
        Calculadora calc = new Calculadora();

        calc.Somar(1, 2);
        calc.Subtrair(2, 8);
        calc.Multiplicar(3, 7);
        calc.Dividir(4, 1);

        var lista = calc.historico();

        Assert.NotEmpty(calc.historico());
        Assert.Equal(3, lista.Count);
    }
}


namespace CalculadoraTests;
public class CalculadoraTests
{

    Calculadora _calc;

    public CalculadoraTests()
    {
        _calc = new Calculadora();
    }

    [Theory]
    [InlineData(1, 2 , 3)]
    [InlineData(2, 2 , 4)]
    [InlineData(4, 6 , 10)]
    [InlineData(8, 3 , 11)]
    [InlineData(3, 7 , 10)]
    public void Somar_SomaDeDoisValoresValoresPositivos_RetornarVerdadeiro(int num1, int num2, int resultado)
    {
        var resultadoCalculado = _calc.Somar(num1, num2, DateTime.Now);

        Assert.Equal(resultado, resultadoCalculado);
    }

    [Theory]
    [InlineData(1, 2 , 3)]
    [InlineData(-1, 2 , 1)]
    [InlineData(4, -6 , -2)]
    [InlineData(8, -5 , 3)]
    [InlineData(3, -6 , -3)]
    public void Somar_SomaDeDoisValoresValoresSemSinalDefinido_RetornarVerdadeiro(int num1, int num2, int resultado)
    {
        var resultadoCalculado = _calc.Somar(num1, num2, DateTime.Now);

        Assert.Equal(resultado, resultadoCalculado);
    }

    [Theory]
    [InlineData(1, 2 , -1)]
    [InlineData(3, 2 , 1)]
    [InlineData(4, 6 , -2)]
    [InlineData(8, 3 , 5)]
    [InlineData(3, 7 , -4)]
    public void Subtrair_SubtracaoDeDoisValoresPositivos_RetornarVerdadeiro(int num1, int num2, int resultado)
    {
        var resultadoCalculado = _calc.Subtrair(num1, num2, DateTime.Now);

        Assert.Equal(resultado, resultadoCalculado);
    }

    [Theory]
    [InlineData(-2, 2 , -4)]
    [InlineData(-5, 2 , -7)]
    [InlineData(4, -5 , 9)]
    [InlineData(8, 3 , 5)]
    [InlineData(3, 7 , -4)]
    public void Subtrair_SubtracaoDeDoisValoresSemSinalDefinido_RetornarVerdadeiro(int num1, int num2, int resultado)
    {
        var resultadoCalculado = _calc.Subtrair(num1, num2, DateTime.Now);

        Assert.Equal(resultado, resultadoCalculado);
    }

    [Theory]
    [InlineData(1, 2 , 2)]
    [InlineData(3, 2 , 6)]
    [InlineData(4, 6 , 24)]
    [InlineData(8, 3 , 24)]
    [InlineData(3, 7 , 21)]
    public void Multiplicacao_MultiplicacaoDeDois_RetornarPositivo(int num1, int num2, int resultado)
    {
        var resultadoCalculado = _calc.Multiplicar(num1, num2, DateTime.Now);

        Assert.Equal(resultado, resultadoCalculado);
    }

    [Theory]
    [InlineData(2, 2 , 1)]
    [InlineData(6, 2 , 3)]
    [InlineData(24, 6 , 4)]
    [InlineData(24, 3 , 8)]
    [InlineData(21, 7 , 3)]
    public void Divisao_DivisaoDeDoisValores_RetornarPositivo(int num1, int num2, int resultado)
    {
        var resultadoCalculado = _calc.Divisao(num1, num2, DateTime.Now);

        Assert.Equal(resultado, resultadoCalculado);
    }

    [Theory]
    [InlineData(2, 2)]
    [InlineData(3, 6)]
    [InlineData(4, 24)]
    [InlineData(5, 120)]
    public void Fatorial_FatorialDeUmNumeroPositivo_RetornarPositivo(int num1, int resultado)
    {
        var fatorial = _calc.Fatoracao(num1, DateTime.Now);

        Assert.Equal(resultado, fatorial);
    }

    [Fact]
    public void Historico_HistoricoPossui3Valores_RetornarSucesso()
    {

        _calc.Somar(1,3, DateTime.Now);
        _calc.Subtrair(1,3, DateTime.Now);
        _calc.Multiplicar(1,3, DateTime.Now);
        _calc.Somar(1,3, DateTime.Now);

        var historico = _calc.Historico().GetRange(0,3);

        Assert.Equal(3, historico.Count);
    } 
}
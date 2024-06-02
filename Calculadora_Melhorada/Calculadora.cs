using System.Reflection.Metadata.Ecma335;
using Microsoft.VisualBasic;

public class Calculadora
{

    
    List<(string, DateTime)> _Historico = new List<(string, DateTime)> ();
    public int Somar(int num1, int num2, DateTime data)
    {
        var Somar = num1 + num2;

        _Historico.Add(($"Soma || Valor1 = {num1} || Valor2 = {num2} || Resultado = {Somar}", data));
        return Somar;
    }

    public int Subtrair(int num1, int num2, DateTime data)
    {
        var Subtrair = num1 - num2; 

        _Historico.Add(($"Subtracao || Valor1 = {num1} || Valor2 = {num2} || Resultado = {Subtrair}", data));
        return Subtrair;
    }

    public int Multiplicar(int num1, int num2, DateTime data)
    {
        var Multiplicar = num1 * num2;

        _Historico.Add(($"Multiplicacao || Valor1 = {num1} || Valor2 = {num2} || Resultado = {Multiplicar}", data));
        return Multiplicar;
    }

    public int Divisao(int num1, int num2, DateTime data)
    {
        var Divisao = num1/num2;

        _Historico.Add(($"Divisao || Valor1 = {num1} || Valor2 = {num2} || Resultado = {Divisao}", DateTime.Now));
        return Divisao;
    }

    public int Fatoracao(int num1, DateTime data)
    {
        if(num1 == 0)
        {
            return 1;
        }
        var resultado = num1 * Fatoracao(num1-1, data);
        _Historico.Add(($"Fatoracao || Valor = {num1} || Resultado = {resultado}", data));
        return resultado;
    }

    public List<(string, DateTime)> Historico()
    {
        return _Historico;
    }
    
}
using System;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;

public class Calculadora
{
    private List<string> listaHistorico = new List<string>();

    public int Somar(int val1, int val2)
	{
        int resultado = val1 + val2;
        listaHistorico.Insert(0, "Resultado: " + resultado);
        return resultado;
    }

    public int Subtrair(int val1, int val2)
    {
        int resultado = val1 - val2;
        listaHistorico.Insert(0, "Resultado: " + resultado);
        return resultado;
    }

    public int Multiplicar(int val1, int val2)
    {
        int resultado = val1 * val2;
        listaHistorico.Insert(0, "Resultado: " + resultado);
        return resultado;
    }

    public int Dividir(int val1, int val2)
    {
        int resultado = val1 / val2;
        listaHistorico.Insert(0, "Resultado: " + resultado);
        return resultado;
    }

     public List<string> historico()
    {
        listaHistorico.RemoveRange(3, listaHistorico.Count - 3);
        return listaHistorico;
    }

}

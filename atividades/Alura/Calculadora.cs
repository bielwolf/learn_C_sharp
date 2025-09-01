using System.Text.RegularExpressions;

namespace Atividades.Alura;

public class Calculadora
{
    public static double Calcular(double num1, double num2, char operacao)
    {
        double resultado = 0;

        switch (operacao)
        {
            case '+':
                resultado = Somar(num1, num2);
                break;
            case '-':
                resultado = Subtair(num1, num2);
                break;
            case '*':
                resultado = Multiplicar(num1, num2);
                break;
            case '/':
                resultado = Dividir(num1, num2);
                break;
            case '^':
                resultado = Potencia(num1, num2);
                break;
            case 'r':
                resultado = RaizQuadrada(num1);
                break;
            default:
                Console.WriteLine("Operação Inválida!");
                break;
        }

        return resultado;
    }

    private static double Somar(double a, double b)
    {
        return a + b;
    }

    private static double Subtair(double a, double b)
    {
        return a - b;
    }

    private static double Multiplicar(double a, double b)
    {
        return (a * b);
    }

    private static double Dividir(double a, double b)
    {
        return a / b;
    }

    private static double Potencia(double a, double b)
    {
        return Math.Pow(a, b);
    }

    private static double RaizQuadrada(double a)
    {
        return Math.Sqrt(a);
    }
}
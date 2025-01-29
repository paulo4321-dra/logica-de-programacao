using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace logica02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Definindo as constantes

            const int valor1 = 10;
            const int valor2 = 5;

            // soma

            int soma = valor1 + valor2;
            Console.WriteLine($"Soma : {valor1} + {valor2} = {soma}");

            // subtração

            int subtracao = valor1 - valor2;
            Console.WriteLine($"Subtração : {valor1} - {valor2} = {subtracao}");

            // multiplicação 

            int multiplicacao = valor1 * valor2;
            Console.WriteLine($"Multiplicação : {valor1} * {valor2} = {multiplicacao}");

            // Divisão

            int divisao = valor1 / valor2;
            Console.WriteLine($"Divisão : {valor1} / {valor2} = {divisao}");

            // Resto de divisão 

            int resto = valor1 % valor2;
            Console.WriteLine($"Resto de divisão : {valor1} % {valor2} = {resto}");

            // Potenciação (usando Math para calcular a pot~encia

            double potencia = Math.Pow(valor1, valor2);
            Console.WriteLine($"Potência : {valor1} elevado a {valor2} = {potencia}");

            // ordem de grandeza

            // exemplo 1 : Sem parenteses

            int resultado1 = 3 + 5 * 2; // Multiplicação tem prioridade
            Console.WriteLine($"Resultado 1 (Sem parenteses) : 3 + 5 * 2 = {resultado1} ");

            // exemplo 1 : Com parenteses

            int resultado2 = (3 + 5) * 2; // Parenteses alteram a ordem 
            Console.WriteLine($"Resultado 2 (Com parenteses) : (3 + 5) * 2 = {resultado2} ");

            // Exemplo 2 : Sem parenteses

            int resultado3 = 8 / 4 + 3;  // Divisão tem prioridade
            Console.WriteLine($"Resultado 3 (Sem parenteses) : 8 /4 + 3 = {resultado3}");

            // Exemplo 2: Com parênteses
            double resultado4 = 8.0 / (4 + 3);  // Parênteses alteram a ordem
            Console.WriteLine($"Resultado 4 (com parênteses): 8 / (4 + 3) = {resultado4}");


          Console.ReadLine();
        }
    }
}

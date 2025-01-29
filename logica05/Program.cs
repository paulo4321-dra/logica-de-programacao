using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace logica05
{
    internal class Program
    {
        static void Main(string[] args)
        {
            for (int i = 0; i <= 10; i++)
            {
                Console.WriteLine(i);
            }

         // While

            int contador = 1;

            while (contador <= 5)
            {
                Console.WriteLine(contador);
                contador++;  // Icrmenta o contador
            }

            // Do while
            int novoContador = 2;

            do
            {
                Console.WriteLine(novoContador);
                novoContador++; // Incrementa o contador

            } while (novoContador <= 5);

            // Laço Foreach
            // Uma lista de strings
            List<string> nomes = new List<string> {"Ana", "Carlos", "João", "Maria"};

           // Usando o Foreach para percorrer a lista 
           foreach ( string nome in nomes)
            {
                Console.WriteLine(nome); // Imprime cada nome
            }

            //Um vetor de números inteiros
            int[] numeros = { 1, 2, 3, 4, 5 };

            // Usando o foreach para percorrer o vetor
            foreach (int numero in numeros)
            {
                Console.WriteLine(numero); // Imprime cada número
            }

                Console.ReadLine();
        }
    }
}

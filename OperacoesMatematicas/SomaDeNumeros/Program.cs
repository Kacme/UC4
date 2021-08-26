using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SomaDeNumeros
{
    class Program
    {
        static void Main(string[] args)
        {
            // Console.WriteLine é um comando que escreve texto. Comandos devem ser colocado entre parêntesis.
            // Está entre parêntesis, é um comando.
            //Pra saber que é um texto deve estar entre aspas duplas " ".

            /*Exemplos de variáveis:
            
            string -> texto (arjazena texto)
            int -> números inteiros (armazena números inteiros)
            Double e Float -> Decimais 1, 1.2, 5.7, -7. -8.9 ... (armazena números decimais)
            */
            
            //Exercício 01

            // n1 - armazena o primeiro número informado
            // n2 - armazena o segundo número informado

            Double n1 = 0;
            Double n2 = 0;
            Double total = 0;
            string pergunta = "";

            Console.WriteLine(); 
            
            Console.WriteLine("Programa que soma dois números");
            Console.WriteLine("----------------------------------");
            Console.WriteLine();
           
            Console.Write("Informe o primeiro número: ");
            pergunta = Console.ReadLine();
            n1 = Convert.ToDouble(pergunta);
            Console.WriteLine();
            
            Console.Write("Informe o segundo número: ");
            pergunta = Console.ReadLine();
            n2 = Convert.ToDouble(pergunta);
            Console.WriteLine();
            
            Console.WriteLine($"Os números digitados foram: {n1} e {n2}");
            Console.WriteLine();
            
            total = n1 + n2;
            Console.WriteLine($"O total da soma é: {total}");
            Console.WriteLine();
            Console.WriteLine();
            //Outra forma de exibir o resultado é como a linha abaixo

            Console.WriteLine(n1 + " + " + n2 + " = " + total);
            Console.ReadKey();
            
            
            
        }
    }
}

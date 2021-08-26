using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Olá_Mundo
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Declaração de variável
        
            string nome = "Kleber Augusto Costa Moreno";
            //string idade = "46";
            Int16 idade = 35;
            Console.WriteLine("Olá Mundo, eu sou o "+nome+" e tenho "+idade+" anos de idade!");
            Console.WriteLine(); //Pula linha
            //Console.WriteLine(idade);
            //Calculos
            //int num1 = 13;
            //int num2 = 21;
            int num1 = 13, num2 = 5;
            Console.WriteLine($"Mostrando número 1 ... {num1} e número 2 ... {num2}");
            Console.WriteLine();
            //Console.WriteLine(""+num1, ""+num2);

            // Soma
            int soma = num1 + num2;
            Console.WriteLine($"A soma do valor (1), {num1} + valor (2), {num2}, é: {soma}");
            Console.WriteLine();

            //Divisão Inteira
            int divisao = num1 / num2;
            Console.WriteLine($"A divisão do valor (1), {num1} / valor (2), {num2}, é: {divisao}");
            Console.WriteLine();

            // Divisão Com números "reais" (casas decimais)
            float divisaof = (float)num1 / (float)num2;
            Console.WriteLine($"A divisao do valor (1), {num1} / valor (2), {num2}, é: {divisaof}");
            Console.WriteLine();

            // Multiplicação
            int multiplicacao = num1 * num2;
            Console.WriteLine($"A multiplicação do valor (1), {num1} * valor (2), {num2}, é: {multiplicacao}");
            Console.WriteLine();

            // Subtração
            int subtracao = num1 - num2;
            Console.WriteLine($"A subtracao do valor (1), {num1} - valor (2), {num2}, é: {subtracao}");
            Console.WriteLine();

            // Para resto
            float resto = (float)num1 % (float)num2;
            Console.WriteLine($"O resto do valor (1), {num1} / valor (2), {num2}, é: {resto}");
            Console.WriteLine();


            // Para declarar vaore de Double e Float
            float coordenadaX = 0.05f;
            double coordenadaY = 0.07d;

            Console.WriteLine(coordenadaX);
            Console.WriteLine();
            
            Console.WriteLine(coordenadaY);
            Console.WriteLine();
            

            // Entrada de Dados
            Console.Write("Digite um número: ");
            string numero = Console.ReadLine();
            Console.WriteLine("Número digitado: " + numero);
            

            // Exercício 1
            // Entrada de dois números e retornar com resultado da subtração

            Console.Write("Digite um número: ");
            string numero1 = Console.ReadLine();
            Console.Write("Digite outro número: ");
            string numero2 = Console.ReadLine();
            Console.WriteLine("Os números digitados foram: " + numero1 + numero2);
            int subtracao = Convert.ToInt16(numero1) - Convert.ToInt16(numero2);
            Console.Write("O resultado da subtração é: " + subtracao);
           */

            // Exercício 2
            // Entrada de dois números e retornar com resultado da subtração

            Console.Write("Digite um número: ");
            int numero1 = Int32.Parse(Console.ReadLine());
            Console.Write("Digite outro número: ");
            int numero2 = Int32.Parse(Console.ReadLine());
            Console.WriteLine($"Os números digitados foram:  {numero1} e {numero2}");
            int subtracao = Convert.ToInt16(numero1) - Convert.ToInt16(numero2);
            Console.Write("O resultado da subtração é: " + subtracao);
             

            // Exercício 3
            // Fazendo comparação - Usando o If
            // se numero 1 > numero 2 entao
            // escreva("numero1 é maior")
            // senão
            //escreva(numero2 é maior")
            //fimse

            /*Console.Write("Digite um número: ");
            int numero1 = Int32.Parse(Console.ReadLine());
            Console.Write("Digite outro número: ");
            int numero2 = Int32.Parse(Console.ReadLine());
            if (numero1 > numero2)
            {
                Console.WriteLine(numero1 + " é maior.");
            } else
            {
                Console.WriteLine(numero2 + " é maior.");
            }
            */
            Console.ReadKey();


        }
    }
}

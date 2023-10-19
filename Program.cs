using System;

namespace Calculadora
{
    class Program
    {
        static void Main(string[] args)
        {
            Soma();
        }
        
        static void Soma()
        {
            Console.Clear();

            Console.WriteLine("Primeiro valor: ");
            float v1 = float.Parse(Console.ReadLine());

            Console.WriteLine("Segundo valor: ");
            float v2 = float.Parse(Console.ReadLine());

            float res = v1 + v2;

            Console.WriteLine($"O valor da Soma deu: {res}");
            Console.ReadKey();
        }

        static void Subtracao()
        {
            Console.Clear();

            Console.WriteLine("Primeiro valor: ");
            float v1 = float.Parse(Console.ReadLine());

            Console.WriteLine("Segundo valor: ");
            float v2 = float.Parse(Console.ReadLine());

            float res = v1 - v2;

            Console.WriteLine($"O valor da Subtração deu: {res}");
            Console.ReadKey();
        }
        
        static void Divisao()
        {
            Console.Clear();

            Console.WriteLine("Digite o Primeiro valor: ");
            float v1 = float.Parse(Console.ReadLine());

            Console.WriteLine("Digite o Segundo valor: ");
            float v2 = float.Parse(Console.ReadLine());

            float res = v1 / v2;

            Console.WriteLine($"A Divisão que você escolheu deu: {res}");
            Console.ReadKey();
        }

        static void Multiplicacao()
        {
            Console.Clear();

            Console.WriteLine("Digite o Primeiro valor: ");
            float v1 = float.Parse(Console.ReadLine());

            Console.WriteLine("Digite o Segundo valor: ");
            float v2 = float.Parse(Console.ReadLine());

            float res = v1 * v2;

            Console.WriteLine($"A Multiplicação deu: {res}");
            Console.ReadKey();
        }


        
    }
}
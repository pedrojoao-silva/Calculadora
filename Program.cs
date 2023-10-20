using System;

namespace Calculadora
{
    class Program
    {
        static void Main(string[] args)
        {
            Menu();
        }

        static void Menu()
        {
            Console.Clear();
            Console.WriteLine("Oque deseja fazer? ");
            Console.WriteLine("1 - Soma");
            Console.WriteLine("2 - Subtração");
            Console.WriteLine("3 - Divisão");
            Console.WriteLine("4 - Multiplicação");
            Console.WriteLine("5 - Sair");

            Console.WriteLine("----------------");
            Console.WriteLine("Selecione uma Opção");
            short res = short.Parse(Console.ReadLine());

            switch(res) {
                case 1: Soma(); break;
                case 2: Subtracao(); break;
                case 3: Divisao(); break;
                case 4: Multiplicacao(); break;
                case 5: System.Environment.Exit(0); break;
                default: Menu(); break;

            }
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
            Menu();
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
            Menu();
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
            Menu();
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
            Menu();
        }


        
    }
}
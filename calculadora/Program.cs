using System;

namespace calculadora
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();
            Console.WriteLine("Primeiro valor: ");
            float v1, v2, soma;

            v1 = float.Parse(Console.ReadLine());

            Console.WriteLine("Segundo valor: ");
            v2 = float.Parse(Console.ReadLine());

            soma = v1 + v2;

            Console.WriteLine(soma);
        }
    }
}
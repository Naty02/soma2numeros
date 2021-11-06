using System;

namespace soma2numeros
{
    class Program
    {
        static void Main(string[] args)
        {
            int n1, n2;
            Console.WriteLine("--- Operações com inteiros");
            Console.WriteLine("Calcule a soma entre dois números.");

            Console.Write("Número 1: ");
            n1 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Número 2: ");
            n2 = Convert.ToInt32(Console.ReadLine());


            int soma =n1 + n2;

            Console.WriteLine($"{n1} + {n2} = {soma}");
        }
    }
}

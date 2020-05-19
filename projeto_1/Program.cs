using System;

namespace projeto_1
{
    class Program
    {
        static void Main(string[] args)
        {
            int numerogerado, numpalpi;
            string continuar = "s";
            numerogerado = new Random().Next(1,9);

            while (true)
            {
                Console.WriteLine("informe um numero: ");
                numpalpi = int.Parse(Console.ReadLine());
                if(numpalpi == numerogerado)
                {
                    Console.WriteLine("parabéns você acertou!");
                }
                else
                {
                    Console.WriteLine("você errou!");
                }

            }
        }
    }
}

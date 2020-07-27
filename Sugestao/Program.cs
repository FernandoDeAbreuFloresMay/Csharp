using System;

namespace Sugestao
{
    class Program
    {
        static void Main(string[] args)
        {
            Locatario[] vect = new Locatario[10];

            Console.WriteLine("How many rooms will be rented?");

            int n = int.Parse(Console.ReadLine());

            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine($"Rent{i}");
                Console.WriteLine("Name: ");
                string nome = Console.ReadLine();

                Console.WriteLine("e-mail: ");
                string email = Console.ReadLine();

                Console.WriteLine("Room: ");
                int quarto = int.Parse(Console.ReadLine());

                vect[quarto] = new Locatario(nome, email);
            }
            { 

                Console.WriteLine();
                Console.WriteLine("Occupied rooms: ");

                for (int i = 0; i < 10; i++)
                {
                    if (vect[i] != null)
                    {
                        Console.WriteLine(i+": "+vect[i]);
                    }
                }

            }
            Console.WriteLine("Bom dia Github!");

        }
    }
}

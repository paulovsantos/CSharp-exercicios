using System;

namespace ExercicioVetoresFixacao
{
    class Program
    {
        static void Main(string[] args)
        {
            Quarto[] vet = new Quarto[10];

            Console.Write("Quantos quartos deseja alugar? ");

            int n = int.Parse(Console.ReadLine());

            for (int i = 1; i <= n; i++)
            {
                Console.Write("Nome: ");
                string nome = Console.ReadLine();

                Console.Write("E-mail: ");
                string email = Console.ReadLine();

                Console.WriteLine("Quarto desejado: ");
                int quarto = int.Parse(Console.ReadLine());

                vet[quarto] = new Quarto(nome, email);

            }
            Console.WriteLine();
            Console.WriteLine("Quartos ocupados: ");
            for (int i = 0; i < 10; i++)
            {
                if (vet[i] != null)
                {
                    Console.WriteLine(i + ": " + vet[i]);
                }

            }
        }
    }
}


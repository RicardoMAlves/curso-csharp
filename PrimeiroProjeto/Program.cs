using System;
using System.Globalization;

namespace PrimeiroProjeto {

    class Program {

        static void Main(string[] args) {

            Estudante[] vect = new Estudante[10];

            Console.Write("Quantos quartos serão alugados? ");
            int quarto = int.Parse(Console.ReadLine());

            for (int i = 0; i < quarto; i++) {

                Console.WriteLine("Aluguel #" + (i + 1));
                Console.Write("Nome: ");
                string nome = Console.ReadLine();
                Console.Write("Email: ");
                string email = Console.ReadLine();
                Console.Write("Quarto: ");
                int num = int.Parse(Console.ReadLine());

                if (num <= 9) {
                    vect[num] = new Estudante { Nome = nome, Email = email };
                }

                Console.WriteLine();

            }

            Console.WriteLine("Quartos Ocupados:");

            for (int i = 0; i < 9; i++) {

                if (vect[i] != null) {
                    Console.WriteLine(i + ": " + vect[i]);
                }
            }

            Console.WriteLine();
            Console.WriteLine("------- Fim do Programa -------");

        }

    }

}

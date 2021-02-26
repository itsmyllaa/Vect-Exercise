using System;

namespace VectEx
{
    class Program
    {
        static void Main(string[] args)
        {
            /*---------------------------------------------------- 
             * O programa fará o check up de estudantes em um hotel
             * 0 - pedirá a quantidade de alunos que irá fazer o check up
             * 1 - pedirá o nome do aluno
             * 2 - pedirá o e-mail do aluno
             * 3 - pedirá o quarto do aluno
             * 4 - colocará em ordem de quarto cada aluno
             --------------------------------------------------------*/
            // isto é um teste

            Estudante[] vect = new Estudante[10];

            Console.Write("Quantos quartos serão alugados? ");
            int quantidade = int.Parse(Console.ReadLine());

            for (int contador = 1; contador <= quantidade; contador++)
            {
                Console.WriteLine();
                Console.WriteLine($"Aluguel #{1}:");
                Console.Write("Nome: ");
                string nome = Console.ReadLine();
                Console.Write("Email: ");
                string email = Console.ReadLine();
                Console.Write("Quarto: ");
                int quarto = int.Parse(Console.ReadLine());
                vect[quarto] = new Estudante(nome, email);
            }

            Console.WriteLine();
            Console.WriteLine("Quartos ocupados: ");
            for (int i = 0; i < 10; i++)
            {
                if (vect[i] != null)
                {
                    Console.WriteLine(i + ": " + vect[i]);
                }
            }

        }
    }
}

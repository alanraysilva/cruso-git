using System;
using System.Collections.Generic;
using System.Text;

namespace Course
{
    class Pensao
    {
        public string Nome { get; set; }
        public string Email { get; set; }
        public int Quarto { get; set; }

        public override string ToString()
        {
            return Quarto + ": " + Nome + ", " + Email;
        }
    }
}

/*
 static void Main(string[] args)
        {
            Pensao[] p = new Pensao[10];
            Console.Write("Informe a quantidade a algueis a serem contratados: ");            
            int aluguel = int.Parse(Console.ReadLine());
            Console.WriteLine();
            for (int i = 0; i < aluguel; i++)
            {
                Console.WriteLine("{0}º Aluguel: ", i + 1);                
                Console.Write("Informe o nome do estudante: ");
                string nome = Console.ReadLine();
                Console.Write("Informe o e-mail: ");
                string email = Console.ReadLine();
                Console.Write("Informe o quarto disponível: ");
                int quarto = int.Parse(Console.ReadLine());
                p[quarto] = new Pensao { Nome = nome, Email = email, Quarto = quarto};
                Console.WriteLine();
            }

            Console.WriteLine("Quartos alugados:");
            for (int i = 0; i < p.Length; i++)
            {                
                if(p[i] != null)
                {
                    Console.WriteLine(p[i]);
                }                
            }
        }
     */

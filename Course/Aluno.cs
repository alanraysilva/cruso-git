using System;
using System.Collections.Generic;
using System.Text;
using System.Globalization;

namespace Course
{
    class Aluno
    {
        public string Nome;
        public double Nota;

        public void VerificaAprovacao()
        {
            Console.WriteLine("NOTA FINAL = " + Nota.ToString("F2", CultureInfo.InvariantCulture));
            if (Nota >= 60)
            {
                Console.WriteLine("APROVADO");
            }
            else
            {
                Console.WriteLine("REPROVADO");
                double diferenca = 60 - Nota;
                Console.WriteLine("FALTARAM " + diferenca.ToString("F2", CultureInfo.InvariantCulture) + " PONTOS");
            }
        }
    }
}
/*       
 *       static void Main(string[] args)
        {
            Aluno a = new Aluno();
            Console.Write("Nome do aluno: ");
            a.Nome = Console.ReadLine();
            Console.WriteLine("Digite as três notas do aluno");
            for (int i = 0; i < 3; i++)
            {
                a.Nota += double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            }
            a.VerificaAprovacao();
        }
*/
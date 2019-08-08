using System;
using System.Collections.Generic;
using System.Text;
using System.Globalization;

namespace Course
{
    class Empregado
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public double Salario { get; set; }

        public override string ToString()
        {
            return Id + ", " + Nome + ", " + Salario.ToString("F2", CultureInfo.InvariantCulture);
        }

        public void AumentarSalario(double porcentagem)
        {
            double aumento = Salario * porcentagem / 100;
            Salario += aumento;
        }
    }
}
/*
    static void Main(string[] args)
        {
            Console.Write("Quantos funcionários seré registrado? ");
            int n = int.Parse(Console.ReadLine());

            List<Empregado> emp = new List<Empregado>();
            Empregado f;

            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("Funcionário #{0}: ", i + 1);
                Console.Write("Id: ");
                f = new Empregado();
                f.Id = int.Parse(Console.ReadLine());
                Console.Write("Nome: ");
                f.Nome = Console.ReadLine();
                Console.Write("Salário: ");
                f.Salario = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                emp.Add(f);                
                Console.WriteLine();
            }
            Console.WriteLine();
            Console.WriteLine("Listagem de Funcionários: ");
            foreach (Empregado obj in emp)
            {
                Console.WriteLine(obj.ToString());
            }

            Console.WriteLine();
            Console.Write("Entre com o Id que o salário será aumentado: ");
            int id = int.Parse(Console.ReadLine());

            
            bool achou = false;

            foreach (Empregado obj in emp)
            {
                if (obj.Id == id)
                {
                    Console.Write("Entre com a porcentagem: ");
                    double porcentagem = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                    obj.AumentarSalario(porcentagem);
                    achou = true;
                }
            }
            Console.WriteLine();
            if (achou)
            {
                Console.WriteLine("Lista atualizada de funcionários: ");
                foreach (Empregado obj in emp)
                {
                    Console.WriteLine(obj.ToString());
                }

            }
            else
            {
                Console.WriteLine("Funcionário não encontrado operação encerrada.");
                foreach (Empregado obj in emp)
                {
                    Console.WriteLine(obj.ToString());
                }
            }

        }
     */

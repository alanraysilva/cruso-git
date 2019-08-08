using System;
using System.Collections.Generic;
using System.Text;
using System.Globalization;

namespace Course
{
    class Funcionario
    {
        public string Nome;
        public double SalarioBruto;
        public double Imposto;

        public double SalarioLiquido()
        {
            return SalarioBruto - Imposto;
        }

        public void AumentarSalario(double porcentagem)
        {
            double ajuste =  ((SalarioBruto * porcentagem) / 100); 
            SalarioBruto  += ajuste;         
        }

        public override string ToString()
        {

            return Nome + ", $" + SalarioLiquido().ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}
/*
 * Funcionario f = new Funcionario();
            Console.Write("Nome: ");
            f.Nome = Console.ReadLine();
            Console.Write("Salário bruto: ");
            f.SalarioBruto = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.Write("Imposto: ");
            f.Imposto = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.WriteLine("Funcionario: " + f.ToString());
            Console.Write("Digite a porcentagem para aumentar o salário: ");
            f.AumentarSalario(double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture));
            Console.WriteLine("Dados atualizados: " + f.ToString());
 */

using System;
using System.Collections.Generic;
using System.Text;

namespace Course
{
    class Product
    {
        public string Name { get; set; }
        public double Price { get; set; }
    }
}


/*
   static void Main(string[] args)
        {
            Console.Write("Informe a quantidade de produtos que deseja inserir :");
            int n = int.Parse(Console.ReadLine());
            Product[] p = new Product[n];
            double media = 0;
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("Informe os dados do {0}º produto: ", i + 1);
                //vect[i] = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                //media += vect[i];
                Console.Write("Nome do produto: ");
                string name = Console.ReadLine();                
                Console.Write("Informe o valor do produto: $");
                double price = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                p[i] = new Product { Name = name, Price = price };
                media += p[i].Price;
            }
            media /= n;
            Console.Write("A média de preços é: " + media.ToString("F2", CultureInfo.InvariantCulture));
        }
     */

using System;
using System.Collections.Generic;
using System.Text;
using System.Globalization;

namespace Course
{
    class Produto
    {
        private string _nome;
        private double _preco;
        private int _quantidade;

        public Produto(string nome, double preco, int quantidade)
        {
            _nome = nome;
            _preco = preco;
            _quantidade = quantidade;
        }

        public Produto() { }

        public string Nome
        {
            get { return _nome; }
            set
            {
                if (value != null && value.Length > 1)
                {
                    _nome = value;
                }
            }
        }

        public double Preco
        {
            get { return _preco;}
            set
            {
                if (value != null)
                {
                    _preco = value;
                }
            }
        }
        
        public int Quantidade
        {
            get {return _quantidade; }
        }
        

        public double ValorTotalEstoque()
        {
            return _preco * _quantidade;
        }

        public override string ToString()
        {
            return _nome
                + ", $"
                + _preco.ToString("F2", CultureInfo.InvariantCulture)
                + ", "
                + _quantidade
                + " unidades, Total: $"
                + ValorTotalEstoque().ToString("F2", CultureInfo.InvariantCulture);
        }
        public void AdicionarProdutos(int quantidade)
        {
            _quantidade += quantidade;
        }

        internal void RemoverProdutos(int quantidade)
        {
            _quantidade -= quantidade;
        }
    }
}


/*
    static void Main(string[] args)
        {
            Produto p = new Produto();
            Console.WriteLine("Entre os dados do produto: ");
            Console.WriteLine("Nome: ");
            p.Nome = Console.ReadLine();
            Console.Write("Preço: ");
            p.Preco = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.Write("Quantidade no estoque: ");
            p.Quantidade = int.Parse(Console.ReadLine());

            Console.WriteLine();
            Console.WriteLine("Dados do produto: " + p);

            Console.WriteLine();
            Console.Write("Digite o número de produtos a ser adicionado ao estoque: ");
            int qtde = int.Parse(Console.ReadLine());
            p.AdicionarProdutos(qtde);

            Console.WriteLine();
            Console.WriteLine("Dados atualizados: " + p);

            Console.WriteLine();
            Console.WriteLine("Digite o número de produtos a ser removido do estoque: ");
            qtde = int.Parse(Console.ReadLine());
            p.RemoverProdutos(qtde);

            Console.WriteLine();

            Console.WriteLine("Dados atualizados: " + p);

        }
     */


// adaptado
/*
   Console.WriteLine("Entre os dados do produto: ");
        Console.Write("Nome: ");
        string nome = Console.ReadLine();
        Console.Write("Preço: ");
        double preco = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
        Console.Write("Quantidade no estoque: ");
        int quantidade = int.Parse(Console.ReadLine());

        Produto p = new Produto(nome, preco, quantidade);

        Console.WriteLine();
        Console.WriteLine("Dados do produto: " + p);

        Console.WriteLine();
        Console.Write("Digite o número de produtos a ser adicionado ao estoque: ");
        int qtde = int.Parse(Console.ReadLine());
        p.AdicionarProdutos(qtde);

        Console.WriteLine();
        Console.WriteLine("Dados atualizados: " + p);

        Console.WriteLine();
        Console.Write("Digite o número de produtos a ser removido do estoque: ");
        qtde = int.Parse(Console.ReadLine());
        p.RemoverProdutos(qtde);

        Console.WriteLine();

        Console.WriteLine("Dados atualizados: " + p);
 */

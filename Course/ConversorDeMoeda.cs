using System;
using System.Collections.Generic;
using System.Text;

namespace Course
{
    class ConversorDeMoeda
    {
        static double Iof = 6;
        public static double ConverterMoeda(double cotacao, double dolar)
        {
            double convertido = dolar * cotacao;
            return (convertido * (Iof / 100)) + convertido;
        }
    }
}


/*
             Console.Write("Qual é a cotação do dólar? ");
            double cotacao = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.Write("Quantos dólares você vai comprar? ");
            double dolar = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.WriteLine("Valor a ser pago em reais = " + ConversorDeMoeda.ConverterMoeda(cotacao, dolar).ToString("F2", CultureInfo.InvariantCulture));

     */

using System;
using System.Collections.Generic;
using System.Text;

namespace Course
{
    class Calculator
    {
        // usando params moditicador de parametros, quando preciso utilizar n valores para fazer um calculo por exemplo e não ter 
        // que ficar colocando a quantidade definidade ou explicitamente declarar um vetor e ter que instancia -lo para fazer a operação quando assim eu 
        // utilizo o parans
        public static int Sum(params int[] numbers)
        {
            int sum = 0;
            for (int i = 0; i < numbers.Length; i++)
            {
                sum += numbers[i];
            }
            return sum;
        }
    }
}

/*
 *         static void Main(string[] args)
        {
            int sum = Calculator.Sum(2, 3, 4);
            Console.WriteLine(sum);
        }
 */

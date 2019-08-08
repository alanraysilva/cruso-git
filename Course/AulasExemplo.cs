using System;
using System.Collections.Generic;
using System.Text;

namespace Course
{
    class AulasExemplo
    {
    }
}


// Laco For
/*
 *         static void Main(string[] args)
        {
            Console.Write("Informe a quantidade de alturas de deseja inserir para obter a média :");
            int n = int.Parse(Console.ReadLine());
            double[] vect = new double[n];
            double media = 0;
            for (int i = 0; i < n; i++)
            {
                Console.Write("Informa a {0}º altura: ", i + 1);
                vect[i] = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                media += vect[i];
            }
            media /= n;
            Console.Write("A média de altura é: " + media.ToString("F2", CultureInfo.InvariantCulture));
        }
    }
 
     */
/*
 *       static void Main(string[] args)
   {
       List<string> list = new List<string>();

       list.Add("Maria");
       list.Add("Alex");
       list.Add("Bob");
       list.Add("Anna");
       list.Insert(2, "Marco");

       foreach (string obj in list)
       {
           Console.WriteLine(obj);

       }
       Console.WriteLine("List count : " + list.Count);

       string s1 = list.Find(x => x[0] == 'A');
       Console.WriteLine("First 'A': " + s1);

       string s2 = list.FindLast(x => x[0] == 'A');
       Console.WriteLine("Last 'A': " + s2);

       int pos1 = list.FindIndex(x => x[0] == 'A');
       Console.WriteLine("First position 'A': " + pos1);

       int pos2 = list.FindLastIndex(x => x[0] == 'A');
       Console.WriteLine("Last position 'A': " + pos2);


       List<string> list2 = list.FindAll(x => x.Length == 5);
       Console.WriteLine("------------------");

       foreach (string obj in list2)
       {
           Console.WriteLine(obj);
       }

       list.Remove("Alex");
       Console.WriteLine("------------------");

       foreach (string obj in list)
       {
           Console.WriteLine(obj);
       }

       list.RemoveAll(x => x[0] == 'M');
       Console.WriteLine("------------------");

       foreach (string obj in list)
       {
           Console.WriteLine(obj);
       }




   }

   /*static bool Test(string s)
   {
       return s[0] == 'A';
   }*/ // substituido por lambda
       /*}
         */


/*
         static void Main(string[] args)
    {
        Console.Write("Entre com o número da matriz: ");
        int m = int.Parse(Console.ReadLine());
        int[,] mat = new int[m, m];
        for (int i = 0; i < m; i++)
        {
            string[] values = Console.ReadLine().Split(' ');

            for (int j = 0; j < m; j++)
            {
                mat[i, j] = int.Parse(values[j]);

            }
        }
        Console.WriteLine("Diagonal principal:");
        for (int i = 0; i < m; i++)
        {
            Console.Write(mat[i, i] + " ");
        }
        Console.WriteLine();

        int count = 0;
        for (int i = 0; i < m; i++)
        {
            for (int j = 0; j < m; j++)
            {
                if (mat[i, j] < 0)
                {
                    count++;
                }
            }
        }
        Console.Write("Quantidade de negativos: " + count);
    }
 */
/*
 * exercicios de fixação
      static void Main(string[] args)
       {

           //Console.Write("Entre com o número de linhas da matriz: ");
           //int linhas = int.Parse(Console.ReadLine());
           //Console.Write("Entre com o número de colunas da matriz: ");
           //int colunas = int.Parse(Console.ReadLine());

           Console.Write("Entre com o valor da matriz: ");
           string[] m = Console.ReadLine().Split(' ');


           int[,] mat = new int[int.Parse(m[0]), int.Parse(m[1])];

           for (int i = 0; i < int.Parse(m[0]); i++)
           {
               string[] values = Console.ReadLine().Split(' ');
               for (int j = 0; j < int.Parse(m[1]); j++)
               {
                   mat[i, j] = int.Parse(values[j]);
               }
           }

           Console.Write("Entre com um numero inteiro: ");
           int l = 0;
           int c = 0;
           int num = int.Parse(Console.ReadLine());

           for (int i = 0; i < int.Parse(m[0]); i++)
           {
               for (int j = 0; j < int.Parse(m[1]); j++)
               {
                   if (mat[i, j] == num)
                   {
                       l = i;
                       c = j;
                       Console.WriteLine("Posição: " + l.ToString() + "," + c.ToString() + ":");
                       if (c > 0)
                       {
                           Console.WriteLine("Esquerda: " + mat[l, c - 1]);
                       }
                       if (c < int.Parse(m[1]) - 1)
                       {
                           Console.WriteLine("Direita: " + mat[l, c + 1]);
                       }
                       if (l > 0)
                       {
                           Console.WriteLine("Acima: " + mat[l - 1, c]);
                       }
                       if (l < int.Parse(m[0]) - 1)
                       {
                           Console.WriteLine("Embaixo: " + mat[l + 1, c]);
                       }

                   }
               }
           }

       }
    */

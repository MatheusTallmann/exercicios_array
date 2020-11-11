using System;
using System.Collections.Generic;
using System.Linq;

namespace exercicios_array
{
    public class Arrays
    {
        public List<double> Exercise1(List<double> a, List<double> b)
        // Leia dois arrays A e B com 15 elementos. Construir um array C, 
        // onde cada elemento de C é a subtração do elemento correspondente de A com B.
        {
            var c = new List<double>();
            for (int i = 0; i < a.Count; i++)
            {
                c.Add(a[i] - b[i]);
            }
            return c;
            // var x = a.Select(itemA => 
            //     {
            //        return  b.Select(itemB => itemB - itemA);
            //     });
            
            // return x.;
        }
        
        public List<(double, double)> Exercise2(List<double> array)
        // Ler um array com 10 inteiros e mostrar os números na ordem direta e inversa a que foram lidos.
        {
            var ordens = new List<(double direto, double inverso)>();

            var counter = 0;
            for (int i = array.Count - 1; i >= 0 ; i--)
            {
                ordens.Add((array[counter], array[i]));
                counter++;
            }

            return ordens;
            // var ordemDireta = ordens.Select(item => item.direto).ToList();

            // for (int i = 0; i < array.Count; i++)
            // {
            //     ordemDireta.Add(array[i]);
            // }

            // array.Reverse();
            // for (int i = 0; i < array.Count; i++)
            // {
            //     ordens.Add((ordemDireta[i], array[i]));
            // }

            // return ordens;
        }
        public string Exercise3(List<double> a, double number)
        // Leia 10 elementos e armazene em um array A. 
        // Em seguida, solicite pelo teclado um número qualquer e pesquise no array se o número existe. 
        // Caso, seja verdade imprima a mensagem: “O número existe no array”, caso contrário “Número inexistente”.
        {
            var search = a.Where(item => item == number).Count();
            return search > 0 ? "O número existe no array" : "Número inexistente";
        }

        public bool Exercise4(List<double> a, List<double> b)
        // Leia dois arrays A e B com 10 elementos.  
        // Em seguida, compare os arrays e verifique se os mesmos são iguais ou diferentes.
        {
            var sum = 0;

            for (int i = 0; i < a.Count; i++)
            {
                if (a[i] == b[i])
                {
                    sum++;
                }
            }
            if (sum == a.Count)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public string Exercise5(List<double> a)
        // Leia um array A com 15 elementos, e calcule a média aritmética dos mesmos, 
        // em seguida, diga quantos dos elementos lidos estão abaixo, acima e na média.
        {
            var sum = 0.0;
            var aboveAverage = 0;
            var belowAverage = 0;
            var onAverage = 0;

            for (int i = 0; i < a.Count; i++)
            {
                sum += a[i];
            }
            var average = sum / a.Count;
            
            for (int i = 0; i < a.Count; i++)
            {
                if (a[i] > average)
                {
                    aboveAverage++;
                }
                else if (a[i] < average)
                {
                    belowAverage++;
                }
                else if (a[i] == average)
                {
                    onAverage++;
                }
            }
            return $"{aboveAverage}, {belowAverage}, {onAverage}";
        }
        public (double[], double[], double[]) Exercise6(double[] a, double[] b)
        // Leia um array A com 12 elementos. Após sua leitura, 
        // colocar os seus elementos em ordem crescente. 
        // Depois ler um array B também com doze elementos, colocar os elementos de B em ordem decrescente. 
        // Construir um array C, onde cada elemento de C é a soma do elemento correspondente de A com b. 
        // Colocar em ordem crescente a matriz C e apresentar os seus valores.
        {
            var c = new double[5];
                        
            for (int i = 0; i < c.Length; i++)
            {
                c[i] = b[i] + a[i]; 
            }
            
            Array.Sort(a);
            Array.Sort(b);
            Array.Reverse(b);

            Array.Sort(c);
            return (a, b, c);
        }
    }

}
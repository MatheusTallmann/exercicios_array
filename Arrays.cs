using System;
using System.Linq;
using System.Text;

namespace Arrays
{
    class Arrays
    {
        static void Exercise1()
        // Leia dois arrays A e B com 15 elementos. Construir um array C, 
        // onde cada elemento de C é a subtração do elemento correspondente de A com B.
        {
            var A = new double[15];
            var B = new double[15];
            var C = new double[15];
            
            for (int i = 0; i < A.Length; i++)
            {
                System.Console.WriteLine("Forneça um número para A:");
                A[i] = double.Parse(Console.ReadLine());
            }
            for (int i = 0; i < B.Length; i++)
            {
                System.Console.WriteLine("Forneça um número para B:");
                B[i] = double.Parse(Console.ReadLine());
            }

            for (int i = 0; i < C.Length; i++)
            {
                C[i] = A[i] - B[i];
                System.Console.WriteLine($"Os valores de C são: {C[i]}");
            }           
            
        }

        static void Exercise2()
        // Ler um array com 10 inteiros e mostrar os números na ordem direta e inversa a que foram lidos.
        {
            var numbers = new int[10];

            for (int i = 0; i < numbers.Length; i++)
            {
                System.Console.WriteLine("Forneça um número inteiro:");
                numbers[i] = Int32.Parse(Console.ReadLine());
            }
            System.Console.WriteLine("Números na ordem direta:");
            foreach (var item in numbers)
            {
                System.Console.WriteLine(item);
                //Para cada elemento de numbers, será imprimido
            }
            System.Console.WriteLine("Números na ordem inversa:");
            for (int i = 2; i > -1; i--)
            {
                System.Console.WriteLine(numbers[i]);
            }
        }

        static void Exercise3()
        // Leia 10 elementos e armazene em um array A. 
        // Em seguida, solicite pelo teclado um número qualquer e pesquise no array se o número existe. 
        // Caso, seja verdade imprima a mensagem: “O número existe no array”, caso contrário “Número inexistente”.
        {
            var a = new double[3];
            var x = 0;

            for (int i = 0; i < a.Length; i++)
            {
                System.Console.WriteLine("Forneça um número:");
                a[i] = double.Parse(Console.ReadLine());
            }

            System.Console.WriteLine("Forneça um número para saber se existe no Array:");
            var input = double.Parse(Console.ReadLine());
            
            foreach (var item in a)
            {  
                if (input == item)
                {
                    x++;
                }
            }

            if (x > 0)
            {
                System.Console.WriteLine("O número existe no array!");
            }
            else
            {
                System.Console.WriteLine("Número inexistente!");
            }
               
        }

        static void Exercise4()
        // Leia dois arrays A e B com 10 elementos.  
        // Em seguida, compare os arrays e verifique se os mesmos são iguais ou diferentes.
        {
            var a = new double[10];
            var b = new double[10];
            int sum = 0;

            for (int i = 0; i < a.Length; i++)
            {
                System.Console.WriteLine("Forneça um número para A:");
                a[i] = double.Parse(Console.ReadLine());
            }
            for (int i = 0; i < b.Length; i++)
            {  
                System.Console.WriteLine("Forneça um número para B:");
                b[i] = double.Parse(Console.ReadLine());
            }
            for (int i = 0; i < a.Length; i++)
            {
                if (a[i] == b[i])
                {
                    sum++;
                }
            }
            if (sum > 1)
            {
                System.Console.WriteLine("Os arrays são iguais!");
            }
            else
            {
                System.Console.WriteLine("Os arrays são diferentes!");
            }     
                                     
        }
        
        static void Exercise5()
        // Leia um array A com 15 elementos, e calcule a média aritmética dos mesmos, 
        // em seguida, diga quantos dos elementos lidos estão abaixo, acima e na média.
        {
            int arrayLength = 5;
            var notes = new double[arrayLength];
            var sum = 0.0;
            var aboveAverage = 0;
            var belowAverage = 0;

            
            for (int i = 0; i < arrayLength; i++)
            {
                Console.WriteLine("Insira um número para calcular a média aritmética:");      
                notes[i] = double.Parse(Console.ReadLine());
            }
            for (int i = 0; i < arrayLength; i++)
            {
                sum += notes[i];
            }
            double average = sum / arrayLength;
            System.Console.WriteLine($"A média das notas é {average}");
            
            for (int i = 0; i < arrayLength; i++)
            {
                if (notes[i] > average)
                {
                    aboveAverage++;
                }
                else
                {
                    belowAverage++;
                }
            }
            System.Console.WriteLine($"O número de notas acima da média é de: {aboveAverage}");
            System.Console.WriteLine($"E o número de notas abaixo da média é de: {belowAverage}"); 
        }

        static void Exercise6()
        // Leia um array A com 12 elementos. Após sua leitura, 
        // colocar os seus elementos em ordem crescente. 
        // Depois ler um array B também com doze elementos, colocar os elementos de B em ordem decrescente. 
        // Construir um array C, onde cada elemento de C é a soma do elemento correspondente de A com b. 
        // Colocar em ordem crescente a matriz C e apresentar os seus valores.
        {
            const int arrayLength = 3;
            var a = new double[arrayLength];
            var b = new double[arrayLength];
            var c = new double[arrayLength];

            for (int i = 0; i < arrayLength; i++)
            {
                System.Console.WriteLine("Forneça um número para A:");
                a[i] = double.Parse(Console.ReadLine());
                
                System.Console.WriteLine("Forneça um número para B:");
                b[i] = double.Parse(Console.ReadLine());                
            }
            
            System.Console.WriteLine("\nOrdem crescente de A:");
            foreach (var item in a)
            {
                System.Console.WriteLine(item);
            }
            
            System.Console.WriteLine("\nOrdem inversa de B:");
            
            // for (int i = 2; i > -1; i--)
            // {
            //     System.Console.WriteLine(b[i]);
            // }
            
            // System.Console.WriteLine(b.Reverse());

            for (int i = b.Length - 1; i > -1 ; i--)
            {
                System.Console.WriteLine(b[i]);
            }

            System.Console.WriteLine("\nSomatória de A com B:");

            for (int i = 0; i < arrayLength; i++)
            {
                c[i] = a[i] + b[i];
                System.Console.WriteLine(c[i]);
            }

        }

        static void Main(string[] args)
        {
            Exercise6();
        }
    }
}

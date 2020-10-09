using System.Collections.Generic;
using System.Linq;
using Xunit;

namespace exercicios_array
{
    public class ArraysTest
    {
        [Theory]
        [InlineData(new double[15]{1,2,3,4,5,6,7,8,9,10,11,12,13,14,15}, new double[15]{1,2,3,4,5,6,7,8,9,10,11,12,13,14,15},
        new double[15]{0,0,0,0,0,0,0,0,0,0,0,0,0,0,0})]
        public void Exercise1(double[] a, double[] b, double[] expectedC)
        // Leia dois arrays A e B com 15 elementos. Construir um array C, 
        // onde cada elemento de C é a subtração do elemento correspondente de A com B.
        {
            // Dado / Setup
            var exercises = new Arrays();

            // Quando / Ação
            var expectedValue = exercises.Exercise1(a.ToList(), b.ToList());

            // Deve / Asserções
            Assert.Equal(expectedC, expectedValue);
        }

        public static TheoryData<(List<double>, List<(double, double)>)> Exercise2Test()
        {
            return new TheoryData<(List<double>, List<(double, double)>)>
            {
                (new List<double>(){1,2,3,4,5,6,7,8,9,10}, //Lista que será enviada 
                new List<(double, double)>(){(1,10),(2,9),(3,8),(4,7),(5,6),(6,5),(7,4),(8,3),(9,2),(10,1)}), //Resultado esperado
                
                (new List<double>(){2,4,6,8,10,12,14,16,18,20}, //Lista que será enviada 
                new List<(double, double)>(){(2,20),(4,18),(6,16),(8,14),(10,12),(12,10),(14,8),(16,6),(18,4),(20,2)}) //Resultado esperado
            };
        }

        [Theory]
        [MemberData(nameof(Exercise2Test))]
        public void Exercise2((List<double>, List<(double, double)>) numbers)
        // Ler um array com 10 inteiros e mostrar os números na ordem direta e inversa a que foram lidos.
        {
            // Dado / Setup
            var exercises = new Arrays();

            // Quando / Ação
            var returnedValue = exercises.Exercise2(numbers.Item1);

            // Deve / Asserções
            Assert.Equal(numbers.Item2, returnedValue);
        }
        
        [Theory]
        [InlineData(new double[10]{1,2,3,4,5,6,7,8,9,10}, 4, "O número existe no array")]
        [InlineData(new double[10]{1,2,3,4,5,6,7,8,9,10}, 43, "Número inexistente")]
        [InlineData(new double[10]{1,2,3,4,5.6,64,7.7,8,9,10}, 7.7, "O número existe no array")]
        public void Exercise3(double[] a, double number, string expected)
        // Leia 10 elementos e armazene em um array A. 
        // Em seguida, solicite pelo teclado um número qualquer e pesquise no array se o número existe. 
        // Caso, seja verdade imprima a mensagem: “O número existe no array”, caso contrário “Número inexistente”.
        {
            // Dado / Setup
            var exercises = new Arrays();

            // Quando / Ação
            var expectedValue = exercises.Exercise3(a.ToList(), number);

            // Deve / Asserções
            Assert.Equal(expected, expectedValue);
        }
        [Theory]
        [InlineData(new double[10]{1,2,3,4,5,6,7,8,9,10}, new double[10]{1,2,3,4,5,6,7,8,9,10}, true)]
        [InlineData(new double[10]{1,2,3,4,5,6,7,8,9,10},new double[10]{1,2,2,4,5,44,7,4,9,11} , false)]
        public void Exercise4(double[] a, double[] b, bool expected)
        // Leia dois arrays A e B com 10 elementos.  
        // Em seguida, compare os arrays e verifique se os mesmos são iguais ou diferentes.
        {
            // Dado / Setup
            var exercises = new Arrays();

            // Quando / Ação
            var expectedValue = exercises.Exercise4(a.ToList(), b.ToList());

            // Deve / Asserções
            Assert.Equal(expected, expectedValue);
        }
        [Theory]
        [InlineData(new double[15]{0,0,0,0,0,8,8,8,8,8,8,8,8,8,8}, "10, 5, 0")]
        [InlineData(new double[15]{10,5.5,0,0,0,7,7,8,8,8,8,8,8,8,8}, "11, 4, 0")]
        [InlineData(new double[15]{10,9.5,6.5,4,4,3,9,7,8.5,5,8,8,8,8,8}, "9, 6, 0")]
        public void Exercise5(double[] a, string expected)
        // Leia um array A com 15 elementos, e calcule a média aritmética dos mesmos, 
        // em seguida, diga quantos dos elementos lidos estão abaixo, acima e na média.
        {
            // Dado / Setup
            var exercises = new Arrays();

            // Quando / Ação
            var expectedValue = exercises.Exercise5(a.ToList());

            // Deve / Asserções
            Assert.Equal(expected, expectedValue);
        }
        [Theory]
        [InlineData(new double[5]{1,2,3,4,5}, new double[5]{1,2,3,4,5},new double[5]{1,2,3,4,5},new double[5]{5,4,3,2,1}, new double[5]{0,0,0,0,0,})]
        public void Exercise6(double[] a, double[] b, double[] expectedA, double[] expectedB, double[] expectedC)
        // Leia um array A com 5 elementos. Após sua leitura, 
        // colocar os seus elementos em ordem crescente. 
        // Depois ler um array B também com 5 elementos, colocar os elementos de B em ordem decrescente. 
        // Construir um array C, onde cada elemento de C é a soma do elemento correspondente de A com b. 
        // Colocar em ordem crescente a matriz C e apresentar os seus valores.
        {
            // Dado / Setup
            var exercises = new Arrays();

            // Quando / Ação
            (int[], int[], int[]) returnedValue = exercises.Exercise6(listA.ToList(), listB.ToList());

            // Deve / Asserções
            Assert.Equal(expectedA, returnedValue.Item1);
            Assert.Equal(expectedB, returnedValue.Item2);
            Assert.Equal(expectedC, returnedValue.Item3);
        }
    }
}

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
            Assert.Equal(expectedValue, expectedC);
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
            Assert.Equal(expectedValue, expected);
        }
    }
}

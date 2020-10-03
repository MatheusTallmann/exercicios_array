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

        // [Theory]
        // [InlineData(new double[10]{1,2,3,4,5,6,7,8,9,10}, new double[20]{1,2,3,4,5,6,7,8,9,10,10,9,8,7,6,5,4,3,2,1})]
        // public void Exercise2(double[] a, double[] expected)
        // // Ler um array com 10 inteiros e mostrar os números na ordem direta e inversa a que foram lidos.
        // {
        //     // Dado / Setup
        //     var exercises = new Arrays();

        //     // Quando / Ação
        //     var expectedValue = exercises.Exercise2();

        //     // Deve / Asserções
        //     Assert.Equal(expectedValue, expected);
        // }
        
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

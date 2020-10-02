using System;
using Xunit;

namespace exercicios_array
{
    public class UnitTest1
    {
        [Theory]
        [InlineData()]
        public void Exercise1(double[] a, double[] b, double[] expected)
        // Leia dois arrays A e B com 15 elementos. Construir um array C, 
        // onde cada elemento de C é a subtração do elemento correspondente de A com B.
        {
            // Dado / Setup
            var exercises = new arrays();

            // Quando / Ação
            var expectedValue = exercises.Exercise1();

            // Deve / Asserções
            Assert.Equal();

        }
    }
}

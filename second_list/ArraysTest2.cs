using System.Collections.Generic;
using System.Linq;
using Xunit;

namespace exercicios_array
{
    public class ArraysTest2
    {
        [Theory]
        [InlineData(new double[10]{1,2,3,4,5,6,7,8,9,10}, new double[10]{1,2,3,4,5,6,7,8,9,10},
        new double[10]{0,0,0,0,0,0,0,0,0,0})]
        public void Exercise1(double[] a, double[] b, double[] expected)
        //Popule dois vetores com 10 valores cada. Após esta operação, troque o conteúdo dos vetores.            
        {
            // Dado / Setup
            var exercises = new Arrays2();

            // Quando / Ação
            var expectedValue = exercises.Exercise1(a.ToList(), b.ToList());

            // Deve / Asserções
            Assert.Equal(expected, expectedValue);
        }

        [Theory]
        [InlineData(new double[10]{1,2,3,4,5,6,7,8,9,10}, "Não há números repetidos")]
        [InlineData(new double[10]{6,6,5,4,5,6,7,8,8,8}, "Há números repetidos")]
        public void Exercise2(double[] a, string expected)
        //Dado um vetor qualquer com 10 números,faça um programa que informa se há ou não números repetidos nesse vetor
        {
            // Dado / Setup
            var exercises = new Arrays2();

            // Quando / Ação
            var expectedValue = exercises.Exercise2(a.ToList());

            // Deve / Asserções
            Assert.Equal(expected, expectedValue);
        }

        [Theory]
        [InlineData(new string[5]{"Matheus","Vinícius","Maria","Sara","Jana"}, new string[5]{"Masculino","Masculino","Feminino","Feminino","Feminino"},
        new string[5]{"Sim","Sim","Não","Não","Não"})]
        public void Exercise3(string[] nomes, string[] masculinoOuFeminino, string[] simOuNao, string expected)
        // a aplicação deverá receber o sexo do entrevistado 
        // e a sua resposta (sim ou não). Sabendo-se que foram entrevistadas 10 pessoas, fazer um algoritmo que calcule e escreva:
        // O número de pessoas que responderam sim;
        // O número de pessoas que responderam não;
        // A percentagem de pessoas do sexo feminino que responderam sim;
        // A percentagem de pessoas do sexo masculino que responderam não;
        {
            // Dado / Setup
            var exercises = new Arrays2();

            // Quando / Ação
            var expectedValue = exercises.Exercise3(nomes.ToList(), masculinoOuFeminino.ToList(), simOuNao.ToList());

            // Deve / Asserções
            Assert.Equal(expected, expectedValue);
        }
    }
}

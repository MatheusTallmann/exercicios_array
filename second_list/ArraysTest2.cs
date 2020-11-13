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
        [InlineData(new string[5]{"Matheus","Vinícius","Maria","Pamela","Karina"}, new string[5]{"Masculino","Masculino","Feminino","Feminino","Feminino"},
        new string[5]{"Sim","Sim","Não","Não","Não"}, "O número de pessoas que responderam sim: 2 O número de pessoas que responderam não: 3 A porcentagem de mulheres que responderam sim: 0% A porcentagem de homens que responderam não: 0%")]
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

        [Theory]
        [InlineData(new double[10]{1,2,3,4,5,6,7,8,9,10}, 25)]
        [InlineData(new double[5]{2,2,2,4,5}, 5)]
        [InlineData(new double[5]{2,2,1,4,5.5}, 6.5)]
        public void Exercise4(double[] a, double expected)
        // A aplicação deverá receber uma matriz A do tipo vetor e Apresentar a soma de todos os elementos que sejam impares
        {
            // Dado / Setup
            var exercises = new Arrays2();

            // Quando / Ação
            var expectedValue = exercises.Exercise4(a.ToList());

            // Deve / Asserções
            Assert.Equal(expected, expectedValue);
        }
        
        [Theory]
        [InlineData(new double[10]{1,2,3,4,5,6,7,8,9,10}, 10)]
        [InlineData(new double[10]{-1,-2,-3,-4,-5,6,7,8,9,10}, 5)]
        public void Exercise5(double[] a, double expected)
        // A  aplicação deverá retornar quantos valores de um vetor de 10 posições são positivos
        {
            // Dado / Setup
            var exercises = new Arrays2();

            // Quando / Ação
            var expectedValue = exercises.Exercise5(a.ToList());

            // Deve / Asserções
            Assert.Equal(expected, expectedValue);
        }

        [Theory]
        [InlineData(new double[10]{1,2,3,4,5,6,7,8,9,10}, "10 e 9")]
        [InlineData(new double[10]{1,2,3,4,5345,6,7,8,9,10}, "5345 e 4")]
        public void Exercise6(double[] a, string expected)
        // A aplicação deverá retornar um vetor de 10 números positivos e escrever o valor do maior elemento e a respectiva posição que ele ocupa no vetor.
        {
            // Dado / Setup
            var exercises = new Arrays2();

            // Quando / Ação
            var expectedValue = exercises.Exercise6(a.ToList());

            // Deve / Asserções
            Assert.Equal(expected, expectedValue);
        }
        
        [Theory]
        [InlineData(new double[10]{1,2,3,4,5,6,7,8,9,10}, 0)]
        [InlineData(new double[10]{1,1,2,3,4,6,7,8,9,10}, 4)]
        public void Exercise7(double[] a, int expected)
        // A aplicação deverá retornar um vetor A e imprimir na tela quantas vezes há um número residindo na mesma posição do vetor que seu valor numérico.
        {
            // Dado / Setup
            var exercises = new Arrays2();

            // Quando / Ação
            var expectedValue = exercises.Exercise7(a.ToList());

            // Deve / Asserções
            Assert.Equal(expected, expectedValue);
        }
        
        [Theory]
        [InlineData(new string[6]{"a","b","c","d","e","f"}, 2)]
        public void Exercise8(string[] letras, int expected)
        //Crie um vetor de strings de 10 posições onde cada posição recebe uma letra do alfabeto. 
        //No final, imprima quantas destas são vogais.
        {
            // Dado / Setup
            var exercises = new Arrays2();

            // Quando / Ação
            var atualValue = exercises.Exercise8(letras.ToList());

            // Deve / Asserções
            Assert.Equal(expected, atualValue);
        }        

        [Theory]
        [InlineData(new string[25]{"M","a","A","a","T","a","H","a","E","a","U","a","S","a"," ","a","É","a"," ","a","G","a","A","a","Y"}, "MATHEUS É GAY")]
        [InlineData(new string[27]{"V","a","I","a","N","a","I","a","C","a","I","a","U","a","S","a"," ","a","T","a","B","a","M","a"," ","a","É",}, "VINICIUS TBM É")]
        public void Exercise9(string[] letras, string expected)
        //Crie um vetor de strings de 10 posições onde cada posição recebe uma letra do alfabeto. 
        //No final, imprima a string resultante da soma das strings que residem em índices pares.
        {
            // Dado / Setup
            var exercises = new Arrays2();

            // Quando / Ação
            var atualValue = exercises.Exercise9(letras.ToList());

            // Deve / Asserções
            Assert.Equal(expected, atualValue);
        }

        // public void Exercise9(List<double> a) 
        // // A aplicação deverá retornar um vetor A e imprimir na tela quantas vezes há um número residindo na mesma posição do vetor que seu valor numérico.
        // {
        //     a.Select(item =>
        //     {
        //         return item == a.IndexOf(item);
        //     }).Count();
            
        //     a.Where(item => item == a.IndexOf(item)).Count();
        // }
    }
}

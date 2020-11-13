using System;
using System.Collections.Generic;
using System.Linq;

namespace exercicios_array
{
    public class Arrays2
    {
        public List<double> Exercise1(List<double> a, List<double> b)
        //Popule dois vetores com 10 valores cada. Após esta operação, troque o conteúdo dos vetores.            
        {
            var c = new List<double>();

            for (int i = 0; i < a.Count; i++)
            {
                c.Add(a[i] - b[i]);
            }

            return c;
        }

        public string Exercise2(List<double> a)
        //Dado um vetor qualquer com 10 números,faça um programa que informa se há ou não números repetidos nesse vetor
        {
            var counter = 0;
            
            for(int i = 0; i < a.Count; i++)
            {
                for (int k = 0; k < a.Count; k++)
                {
                    if (a[i] == a[k] && i != k)
                    {
                        counter++;
                    }
                }
            }

            if (counter > 0)
            {
                return "Há números repetidos";
            }
            
            else
            {
                return "Não há números repetidos";
            }
        }

        public string Exercise3(List<string> nomes, List<string> masculinoOuFeminino, List<string> simOuNao)
        // a aplicação deverá receber o sexo do entrevistado 
        // e a sua resposta (sim ou não). Sabendo-se que foram entrevistadas 10 pessoas, fazer um algoritmo que calcule e escreva:
        // O número de pessoas que responderam sim;
        // O número de pessoas que responderam não;
        // A porcentagem de pessoas do sexo feminino que responderam sim;
        // A porcentagem de pessoas do sexo masculino que responderam não;
        {
            var sim = simOuNao.Where(item => item == "Sim").Count();
            var nao = simOuNao.Where(item => item == "Não").Count();
            var masculinoNao = 0;
            var femininoSim = 0;

            for (int i = 0; i < nomes.Count; i++)
            {
                if (masculinoOuFeminino[i] == "Masculino" && simOuNao[i] == "Não")
                {
                    masculinoNao++;
                }
                else if (masculinoOuFeminino[i] == "Feminino" && simOuNao[i] == "Sim")
                {
                    femininoSim++;
                }
            }
            double totalHomens = masculinoOuFeminino.Where(item => item == "Masculino").Count();
            double totalMulheres = masculinoOuFeminino.Where(item => item == "Feminino").Count();

            var porcentagemMasculinoNao = (masculinoNao * 100) / totalHomens;
            var porcentagemFemininoSim = (femininoSim * 100) / totalMulheres;

            return $"O número de pessoas que responderam sim: {sim} O número de pessoas que responderam não: {nao} A porcentagem de mulheres que responderam sim: {femininoSim}% A porcentagem de homens que responderam não: {masculinoNao}%";
        }

        public double Exercise4(List<double> a)
        // A aplicação deverá receber uma matriz A do tipo vetor e Apresentar a soma de todos os elementos que sejam impares
        {
            return a.Where(item => item % 2 != 0).Sum();
        }

        public double Exercise5(List<double> a)
        // A  aplicação deverá retornar quantos valores de um vetor de 10 posições são positivos
        {
            return a.Where(item => item > 0).Count();
        }

        public string Exercise6(List<double> a)
        // A aplicação deverá retornar um vetor de 10 números positivos e escrever o valor do maior elemento e a respectiva posição que ele ocupa no vetor.
        {
            var maiorValor = a.Max();
            var index = a.IndexOf(maiorValor);
            return $"{maiorValor} e {index}";
        } 

        public int Exercise7(List<double> a) 
        // A aplicação deverá retornar um vetor A e imprimir na tela quantas vezes há um número residindo na mesma posição do vetor que seu valor numérico.
        {
            var counter = 0;
            for (int i = 0; i < a.Count; i++)
            {
                if (a[i] == i)
                {
                    counter++;
                }
            }
            return counter;
            // a.Where(item => item == a.IndexOf(item)).Count();
        }

        public int Exercise8(List<string> letras)
        //Crie um vetor de strings de 10 posições onde cada posição recebe uma letra do alfabeto. 
        //No final, imprima quantas destas são vogais.
        {
            // var vogais = new List<string>{"a","e","i","o","u"};
            // var counter = 0;

            // for (int i = 0; i < vogais.Count; i++)
            // {
            //     counter += letras.Where(item => item == vogais[i]).Count();
            // }
            
            return letras.Where(item => item == "a" || item == "e" || item == "i" || item == "o" || item == "u").Count();
        }

        public string Exercise9(List<string> letras)
        //Crie um vetor de strings de 10 posições onde cada posição recebe uma letra do alfabeto. 
        //No final, imprima a string resultante da soma das strings que residem em índices pares.
        {
            // var palavra = new List<string>();
            var word = "";

            for (int i = 0; i < letras.Count; i++)
            {
                if (i % 2 == 0)
                {
                    word += $"{letras[i]}"; 
                    // palavra.Add(letras[i]);        
                }
            }

            return word;
        }
    }
}
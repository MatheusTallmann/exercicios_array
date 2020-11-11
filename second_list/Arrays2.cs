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
        {
            var feminino = new List<string>();
            var masculino = new List<string>();
            var sim = new List<string>();
            var nao = new List<string>();
            
            for (int i = 0; i < nomes.Count; i++)
            {
                if (masculinoOuFeminino[i] == "Masculino")
                {
                    masculino.Add(masculinoOuFeminino[i]);
                }
                else
                {
                    feminino.Add(masculinoOuFeminino[i]);
                }

                if (simOuNao[i] == "Sim")
                {
                    sim.Add(simOuNao[i]);
                }
                else
                {
                    nao.Add(simOuNao[i]);
                }
            }
        }
    }

}
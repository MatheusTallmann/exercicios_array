using System.Collections.Generic;
using System.Linq;

namespace exercicios_array
{
    class Arrays
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
        
        // public List<double> Exercises2(List<double> a)
        // // Ler um array com 10 inteiros e mostrar os números na ordem direta e inversa a que foram lidos.
        // {
        //     var ordemDireta = new List<double>();
        //     var ordemInversa = new List<double>();
        //     var expected = new List<double>();

        //     for (int i = 0; i < a.Count; i++)
        //     {
        //         ordemDireta.Add(a[i]);
        //     }

        //     for (int i = a.Count - 1; i >= 0 ; i--)
        //     {
        //         ordemInversa.Add(a[i]);
        //     }
        //     expected.Join(ordemDireta, ordemInversa);
        // }
        public string Exercises3(List<double> a, double number)
        // Leia 10 elementos e armazene em um array A. 
        // Em seguida, solicite pelo teclado um número qualquer e pesquise no array se o número existe. 
        // Caso, seja verdade imprima a mensagem: “O número existe no array”, caso contrário “Número inexistente”.
        {
            
        }
    
    }

}
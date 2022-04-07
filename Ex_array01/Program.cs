using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex_array01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //valor double para receber decimais
            //new double define a quantidade do array
            double[] notas = new double[3];

            //(inteiro valor zerado; se i formenor que o valor de notas; adiciona +1
            //se i for menor que o valor de notas, par ao laço)
            for (int i = 0; i < notas.Length; i++)
            {   //toda vez que o laço roda acrescenta +1 a i
                                    //isso vira um contador
                Console.WriteLine("Digite a "+ (i+1) +"ª nota");
                notas[i] = double.Parse(Console.ReadLine());
            }
            //variável que irá armazenar os valor para fazer a média
            //foi settada a zero
            double soma = 0;

            for (int i =0; i < notas.Length; i++)
            {
                //atribuição composta  =  soma = soma + notas[i]
                soma += notas[i];

                //primeiro o i vale 0
                //a função do i é dizer em qual local do array que será armazenado o valor de nota
                //o for tem a função de percorrer entre os valores
                /* 
                i = 0
                soma += notas[0];
                i = 1
                soma += notas[1];
                i = 2
                soma += notas[2];
                i = 3
                */

            }
            Console.WriteLine("Sua média é " + (soma / notas.Length));
               
            Console.ReadKey();
        }
    }
}

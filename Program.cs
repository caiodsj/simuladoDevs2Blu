using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Simulado
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Escreva um programa que implemente o jogo da forca. O programa deve gerar uma palavra aleatória para ser adivinhada pelo jogador, e permitir que o jogador insira uma letra por vez para tentar adivinhar a palavra. O programa deve exibir a palavra com os espaços em branco para as letras não adivinhadas. */

            //NÃO CONSEGUI FAZER CORRETAMENTE DENTRO DO TEMPO. VOU ESTUDAR O QUE EU NÃO FIZ PRA FUNCIONAR. ATÉ A PROVA
            //JÁ VOU CONSEGUIR FAZER ESSE EXERCICIO

            string palavra = "abacate";
            char[] chars = palavra.ToCharArray();
            char[] forca = new char[chars.Length];
            while (true)
            {
                Console.Write("Digite uma letra: ");
                char c = char.Parse(Console.ReadLine());
                for (int i = 0; i < forca.Length; i++)
                {
                    if (chars[i] == c)
                    {
                        forca[i] = c;
                    }
                }
                string x = new string(forca);
                if (x == palavra)
                {
                    Console.WriteLine("Você acertou a palavra: " + palavra.ToUpper());
                    break;
                }
                Console.WriteLine(String.Join("", forca));
            }

            //EXERCICIO 2

            /*Console.WriteLine("Digite uma palavra:");
            string palavra = Console.ReadLine().ToLower();
            char[] p1 = palavra.ToCharArray();
            Array.Reverse(p1);
            string palindromo = new string(p1);
            if (palavra == palindromo) { Console.WriteLine(palavra + " é um palíndromo."); }
            else { Console.WriteLine(palavra + " não é um palíndromo"); }*/

            /*EXERCICIO 3  - Ordenar uma lista de números sem utilizar os métodos da linguagem.
            Crie um programa em C# que recebe uma lista de números inteiros e ordena essa lista em ordem crescente. Exiba a lista ordenada na tela.*/
            /*Console.Write("Quantos números vão ser adicionados? : ");
            int n = int.Parse(Console.ReadLine());
            int[] vet = new int[n];
            for (int i = 0; i < n; i++)
            {
                Console.Write($"Número #{i+1}: ");
                vet[i] = int.Parse(Console.ReadLine());
            }
            Array.Sort(vet);
            Console.WriteLine(String.Join(", ", vet));*/

            Console.ReadKey();
        }
    }
}

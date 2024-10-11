using System;
using System.Runtime.Intrinsics.Arm;

namespace MK_Challenge
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            //1. Soma:
            int s1 = 0;
            int s2 = 0;
            int s3 = 0;

            Console.WriteLine("Olá! Vamos realizar a soma de dois números");
            Console.WriteLine("Insira o primeiro número: ");
            s1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Insira o segundo número: ");
            s2 = int.Parse(Console.ReadLine());
            s3 = s1 + s2;
            Console.WriteLine($"{s1} + {s2} = {s3}");

            //2. Par ou Impar:
            int x = 0;
            Console.WriteLine("\nOlá novamente, agora vou lhe informar se um número é par ou ímpar.");
            Console.WriteLine("Insira o número:");
            x = int.Parse(Console.ReadLine());
            if (x % 2 == 0)
            {
                Console.WriteLine($"{x} é um número par");
            }
            if (x % 2 != 0 )
            {
                Console.WriteLine($"{x} é um número ímpar");
            }

            //3. Tabuada:
            int n1 = 0;
            int n2 = 0;
            int n3 = 0;

            Console.WriteLine("\nVamos realizar uma multiplicação agora.");
            Console.WriteLine("Insira o primeiro número: ");
            n1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Insira o segundo número: ");
            n2 = int.Parse(Console.ReadLine());
            n3 = n1 * n2;
            Console.WriteLine($"{n1} x {n2} = {n3}");

            //4. Fatorial
            int y = 0;
            int fatorial = 1;
            string parcial;
            string answer = "";
            Console.WriteLine("\nQue tal realizarmos o fatorial de um número agora?");
            Console.WriteLine("Vamos lá!");
            Console.WriteLine("Insira o número:");
            y = int.Parse(Console.ReadLine());
            answer = $"Fatorial de {y}: {y} ";
            for (int i = y - 1; i > 0; i--)
            {
                fatorial *= i + 1;
                parcial = $"x {i} ";
                answer += parcial;
            }
            Console.WriteLine($"{answer}= {fatorial}");

            //5. Contagem de vogais em uma palavra:
            //OBS: Tive que usar uma palavra diretamente pelo código pois com o Console.ReadLine não estava considerando caracteres especiais.
            string palavra = "Programação";
            int contagemVogais = 0;
            char[] vogais = { 'a', 'e', 'i', 'o', 'u', 'A', 'E', 'I', 'O', 'U',
                          'á', 'é', 'í', 'ó', 'ú', 'Á', 'É', 'Í', 'Ó', 'Ú',
                          'ã', 'õ', 'â', 'ê', 'ô', 'Ã', 'Õ', 'Â', 'Ê', 'Ô' };
            Console.WriteLine("\nVou lhe informar a quantidade de vogais contidas em uma palavra.");
            for(int i = 0; i < palavra.Length; i++)
            {
                if (Array.Exists(vogais, v => v == palavra[i]))
                {
                    contagemVogais++;
                }
            }
            Console.WriteLine($"A palavra \"{palavra}\" tem {contagemVogais} vogais");
        }
    }
}
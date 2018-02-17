using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/// <summary>
/// //Exercícios Interativos (com verções de recursivas) | Kayo Gamas | 601298 | 16/02/2018
/// </summary>
namespace _08_02_2018_AED
{
    class Program
    {
        static void Main(string[] args)
        {
            /*string op;
            Console.WriteLine("Exercícios Interativos (com verções de recursivas) | Kayo Gamas | 601298 | 16/02/2018 \n\n");
            Console.WriteLine(" 1 - Fatorial \n 1.1 - Fatorial Recursivo \n 2 - Fibonacci \n 2.2 - Fibonacci Recursivo \n 3a - Soma dos elementos de um Vetor \n " +
                "3b - Maior elemento de um vetor \n 3b.1 - Maior elemento de um vetor Recursivo");
            Console.Write("Digite uma opção: ");
            op = Console.ReadLine();
            switch (op)
            {
                case "1":
                    Console.Write("Digite um número inteiro para o fatorial: ");
                    int num = int.Parse(Console.ReadLine());
                    Console.WriteLine("O fatorial de {0} é: {1}", num, FatorialIterativo(num));
                    break;
            }
            */

        }
        static public int FatorialIterativo(int n)
        {
            int result = 1;
            for (int i = n; i >= 1; i--)
            {
                result *= i;

            }
            return result;
        }
        public int FatorialRecursivo(int n)
        {
            if ((n == 1) || (n == 0)) return 1;
            else return n * FatorialRecursivo(n - 1);
        }


        /* public static void inverter()
         {
             char letra;
             letra = Console.ReadKey().KeyChar;
             if (letra!= '\r')
             {
                 inverter();
                 Console.Write(letra);
             }
         }
         */

        static public int FibonacciIterativo(int n)
        {
            int fibonacci = 1;
            int antecessor = 1;
            if (n == 0 || n == 1)
            {
                return fibonacci;
            }
            else
            {
                for (int i = 2; i <= n; i++)
                {
                    fibonacci += antecessor;
                    antecessor = fibonacci - antecessor;
                }
                return fibonacci;
            }

        }

        static public int FibonacciRecursivo(int n)
        {
            if (n == 0 || n == 1) return 1;

            else
            {
                return FibonacciRecursivo(n - 1) + FibonacciRecursivo(n - 2);
            }
        }



        /*
        /// <summary>
        /// Base : Se n=2, resp = 1/2;
        /// Resp= (N-1) / n + soma(n-2)
        /// </summary>
        /// <param name="n">Número Inteiro </param>
        /// <returns></returns>
        public double Serie(int n)
        {
            if (n == 2) return 0.5;
            else
            {
                double parcela = (n - 1) / (double)n;
                return parcela + Serie(n - 2);
            }
        }
        */

        static public int SomaElementosIterativo(int[] vet)
        {
            int soma = 0;
            for (int i = 0; i < vet.Length; i++)
            {
                soma += vet[i];
            }
            return soma;
        }
        static public int MaiorElementoIterativo(int[] vet)
        {
            int num = vet[0];
            for (int i = 1; i < vet.Length; i++)
            {
                if (vet[i] > num) num = vet[i];

            }
            return num;
        }

        /// <summary>
        /// Base: Se estou na última posição, o maior é o último.
        /// Repetição: Se estou na posição x, o maior é o x ou o maior dos posteriores.
        /// </summary>
        /// <param name="nums"></param>
        /// <param name="pos"></param>
        /// <returns></returns>
        static public int MaiorElementoRecursivo(int[] vet, int pos)
        {

            if (pos == vet.Length - 1)
            {
                return vet[pos];
            }
            else
            {
                int num = MaiorElementoRecursivo(vet, (pos + 1));
                if (vet[pos] > num)
                {
                    return vet[pos];
                }
                else return num;
            }
        }

        static private bool VerificaVogal(char letra)
        {
            switch (letra)
            {
                case 'a':
                case 'A':
                case 'à':
                case 'À':
                case 'á':
                case 'Á':
                case 'ã':
                case 'Ã':
                case 'â':
                case 'Â':
                case 'e':
                case 'E':
                case 'é':
                case 'É':
                case 'ê':
                case 'Ê':
                case 'i':
                case 'I':
                case 'í':
                case 'Í':
                case 'o':
                case 'O':
                case 'ó':
                case 'Ó':
                case 'õ':
                case 'Õ':
                case 'ô':
                case 'Ô':
                case 'u':
                case 'U':
                case 'ú':
                case 'Ú':
                    return true;
                default: return false;
            }
        }
        static public string SemVogalIterativo(string frase)
        {
            string respos = "";
            for (int i = 0; i < frase.Length; i++)
            {
                if (!VerificaVogal(frase[i]))
                {
                    respos += frase[i];
                }
            }
            return respos;
        }

        static public string SemVogalRecursivo(string frase, int pos)
        {
            if (pos == frase.Length) return "";
            else if (VerificaVogal(frase[pos])) return SemVogalRecursivo(frase, pos + 1);
            else return frase[pos] + SemVogalRecursivo(frase, (pos + 1));

        }
    }
}

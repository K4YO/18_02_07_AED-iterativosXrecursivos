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
            Menu();         
            
        }

        static void Menu()
        {
            bool sair = false;
            while (!sair)
            {
                string op;
                int num;
                string aux;
                Console.Clear();
                Console.WriteLine("Exercícios Interativos (com verções de recursivas) | Kayo Gamas | 601298 | 16/02/2018 \n\n");
                Console.WriteLine(" 1 - Fatorial \n 1.1 - Fatorial Recursivo \n 2 - Fibonacci \n 2.2 - Fibonacci Recursivo \n 3a - Soma dos Elementos de um Vetor \n 3a.1 - Somar Recursiva dos Elementos de um Vetor \n " +
                    "3b - Maior Elemento de um vetor \n 3b.1 - Maior elemento de um vetor Recursivo \n 4 - String sem Vogal \n 4 - String sem Vogal Recursivo");
                Console.Write("Digite uma opção: ");
                Console.WriteLine("\n");
                op = Console.ReadLine();
                switch (op)
                {
                    case "1":
                        Console.Write("Digite um número inteiro para o fatorial: ");
                        num = int.Parse(Console.ReadLine());
                        Console.WriteLine("O fatorial de {0} é: {1}", num, FatorialIterativo(num));
                        break;
                    case "1.1":
                        Console.Write("Digite um número inteiro para o fatorial recursivo: ");
                        num = int.Parse(Console.ReadLine());
                        Console.WriteLine("O fatorial de {0} é: {1}", num, FatorialRecursivo(num));
                        break;
                    case "2":
                        Console.Write("Digite a posição para retornar o número respectivo da série Fibonacci: ");
                        num = int.Parse(Console.ReadLine());
                        Console.WriteLine("F({0}) = {1}", num, FibonacciIterativo(num));
                        break;
                    case "2.2":
                        Console.Write("Digite a posição para retornar o número respectivo da série Fibonacci recursivo: ");
                        num = int.Parse(Console.ReadLine());
                        Console.WriteLine("F({0}) = {1}", num, FibonacciRecursivo(num));
                        break;
                    case "3a":
                        Console.Write("Digite uma série de números inteiros separados por ';' (ponto e vírgula) para que seja retornado a soma: ");
                        aux = Console.ReadLine();
                        Console.WriteLine("A soma é: {0}", SomaElementosIterativo(ConvertToIntArray(aux)));
                        break;
                    case "3a.1":
                        Console.Write("Digite uma série de números inteiros separados por ';' (ponto e vírgula) para que seja retornado a soma: ");
                        aux = Console.ReadLine();
                        Console.WriteLine("A soma recursiva é: {0}", SomaElementosRecursivo(ConvertToIntArray(aux), 0));
                        break;
                    case "3b":
                        Console.Write("Digite uma série de números inteiros separados por ';' (ponto e vírgula) para que seja retornado o maior elemento: ");
                        aux = Console.ReadLine();
                        Console.WriteLine("O maior elemento da série é: {0}", MaiorElementoIterativo(ConvertToIntArray(aux)));
                        break;
                    case "3b.1":
                        Console.Write("Digite uma série de números inteiros separados por ';' (ponto e vírgula) para que seja retornado o maior elemento: ");
                        aux = Console.ReadLine();
                        Console.WriteLine("O maior elemento da série recursivamente é: {0}", MaiorElementoRecursivo(ConvertToIntArray(aux), 0));
                        break;
                    case "4":
                        Console.Write("Digite uma frase para que seja retornado a mesma, contudo, sem a(s) vogal(s):");
                        aux = Console.ReadLine();
                        Console.WriteLine("{0}", SemVogalIterativo(aux));
                        break;
                    case "4.1":
                        Console.Write("Digite uma frase para que seja retornado a mesma, contudo, sem a(s) vogal(s) recursivamente:");
                        aux = Console.ReadLine();
                        Console.WriteLine("{0}", SemVogalRecursivo(aux, 0));
                        break;
                    default:
                        Console.Write("\nEstá opção não existe, por favor digite qualquer tecla para voltar ao menu");
                        Console.ReadKey();
                        Menu();
                        break;
                }

                Console.Write("\n\n'S' para sair, ou 'M' para voltar ao menu inicial:" );
                aux = Console.ReadLine().ToLower();
                if (aux == "s") sair = true;
                else if (aux == "m") sair = false;

            }
        }

        static public int[] ConvertToIntArray(string aux)
        {
            string[] auxArray;
            int[] numArray;
            auxArray = aux.Split(';');
            numArray = new int[auxArray.Length];
            for (int i = 0; i < auxArray.Length; i++)
            {
                numArray[i] = Convert.ToInt32(auxArray[i]);
            }
            return numArray;

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
        static public int FatorialRecursivo(int n)
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

        static public int SomaElementosRecursivo(int[] vet, int pos)
        {
            if (pos == vet.Length - 1)
            {
                return vet[pos];
            }
            else
            {
                int soma = vet[pos] + SomaElementosRecursivo(vet, (pos + 1));
                return soma;
               
            }
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

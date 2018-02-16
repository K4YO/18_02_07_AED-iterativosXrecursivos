using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08_02_2018_AED
{
    class Program
    {
        static void Main(string[] args)
        {
            
        }

        public int FatorialIterativo (int n)
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
            if (( n == 1) || (n == 0)) return 1;
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

        public int FibonacciIterativo(int n)
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

        public int FibonacciRecursivo(int n)
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

        /// <summary>
        /// Base: Se estou na última posição, o menor é o último.
        /// Repetição: Se estou na posição x, o menor é o X ou o menor dos posteriores.
        /// </summary>
        /// <param name="nums"></param>
        /// <param name="pos"></param>
        /// <returns></returns>
        public double MenorElementoRecursivo(double[] vet, int pos)
        {
            
            if (pos==vet.Length-1)
            {
                return vet[pos];
            }
            else 
            {
                double candidato = MenorElementoRecursivo(vet, (pos + 1));
                if (vet[pos] < candidato)
                {
                    return vet[pos];
                }
                else return candidato;
            }
        }
        
        private bool Vogal(char letra)
        {
            switch (letra)
                {
                    case 'a': case 'A': case 'à': case 'À': case 'á': case 'Á': case 'ã': case 'Ã': case 'â': case 'Â':
                    case 'e': case 'E': case 'é': case 'É': case 'ê': case 'Ê':
                    case 'i': case 'I': case 'í': case 'Í':
                    case 'o': case 'O': case 'ó': case 'Ó': case 'õ': case 'Õ': case 'ô': case 'Ô':
                    case 'u': case 'U': case 'ú': case 'Ú':
                    return true;
                   default: return false;                      
                }  
        }
        public string SemVogalIterativo(string frase)
        {
            string respos = "";
            for (int i = 0; i < frase.Length; i++)
            {
                if (!Vogal(frase[i]))
                {
                    respos += frase[i];
                }
            }
            return respos;
        }

        public string SemVogalRecursivo(string frase)
        {

        }
    }
}

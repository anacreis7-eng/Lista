using System.ComponentModel;

namespace Lista
{
    internal class Program
    {
        static void Main(string[] args)
        {

            List<int> Numeros = new List<int>();
            int Multiplicacao = 1;

            while (true)
            {
                Console.WriteLine("Digite números para a lista (Envie 0 para parar)");
                int NumeroAdicionar = Convert.ToInt32(Console.ReadLine());
                Numeros.Add(NumeroAdicionar);
                if (NumeroAdicionar == 0)
                    break;
            }

            foreach (var numeros in Numeros)
                {
                Console.WriteLine(numeros);
                if (numeros == 0)
                    break;
                else
                    Multiplicacao *= numeros;
                }
            Numeros.Order();
            Numeros.RemoveAt(Numeros.Count() - 1);


            int MaiorNumero = Numeros.Max();
            Console.WriteLine("O maior número é:\n " + MaiorNumero);
            int MenorNumero = Numeros.Min();
            Console.WriteLine("O Menor número é:\n " + MenorNumero);

            int SomaNumeros = Numeros.Sum();
            Console.WriteLine("A soma dos números é:\n " + SomaNumeros);

            Console.WriteLine("A multiplicação dos números inseridos é de:\n " + Multiplicacao);
        }

    }
}
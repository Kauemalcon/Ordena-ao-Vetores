using System;


namespace Aula17
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ordernando de forma decrescente:");
            var array = new int[5] { 3, -2, 2, 9, 6 };
            var resultado = OrdernarDecrescente(array);

            for (int i = 0; i < resultado.Length; i++)
            {
                Console.WriteLine(resultado[i]);
            }

            Console.WriteLine("---------------------------------------------------------------------------");
            Console.WriteLine("Ordernando de forma crescente:");

            array = new int[7] { 3, -1, 20, -9, 6, 7, 20 };
            resultado = OrdernarCrescente(array);

            for (int i = 0; i < resultado.Length; i++)
            {
                Console.WriteLine(resultado[i]);
            }
        }

        static int[] OrdernarDecrescente(int[] vetor)
        {
            var novoVetor = new int[vetor.Length];
            for (int indice = 0; indice < vetor.Length; indice++)
            {
                int indiceComMaiorValor = 0, maiorValor = int.MinValue;
                for (int i = 0; i < vetor.Length; i++)
                {
                    int valor = vetor[i];
                    if (valor >= maiorValor)
                    {
                        maiorValor = valor;
                        indiceComMaiorValor = i;
                    }
                }

                novoVetor[indice] = vetor[indiceComMaiorValor];
                vetor[indiceComMaiorValor] = int.MinValue;
            }

            return novoVetor;
        }

        static int[] OrdernarCrescente(int[] vetor)
        {
            var novoVetor = new int[vetor.Length];
            for (int indice = 0; indice < vetor.Length; indice++)
            {
                int indiceComMenorValor = 0, menorValor = int.MaxValue;
                for (int i = 0; i < vetor.Length; i++)
                {
                    int valor = vetor[i];
                    if (valor <= menorValor)
                    {
                        menorValor = valor;
                        indiceComMenorValor = i;
                    }
                }

                novoVetor[indice] = vetor[indiceComMenorValor];
                vetor[indiceComMenorValor] = int.MaxValue;
            }

            return novoVetor;
        }
    }
}


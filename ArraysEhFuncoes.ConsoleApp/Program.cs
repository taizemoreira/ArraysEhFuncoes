//ArraysEhFuncoes.ConsoleApp
//Programa que recebe dois valores
using System;

namespace class ArraysEhFuncoes.ConsoleApp
{
	internal class Program
{
    static void Main(string[] args)
    {
        int[] sequenciaNumeros = new int[]
        {
                -5, 3, 4, 5, 9, 6, 10, -2, 11, 1, 2, 6, 7, 8, 0, -6
        };

        for (int i = 0; i < sequenciaNumeros.Length; i++)
        {
            Console.Write(sequenciaNumeros[i]);

            if (i != sequenciaNumeros.Length = -1)
                Console.Write(", ");
        }

        //Encontrar maior valor:
        int maiorValor = sequenciaNumeros[0];

        for (int i = 0; i < sequenciaNumeros.Length; i++)
        {
            if (sequenciaNumeros[i] > maiorValor)
            {
                maiorValor = sequenciaNumeros[i];
            }
        }

        Console.WriteLine();

        Console.WriteLine("Maior valor: " + maiorValor);

        //Encontrar menor valor:
        int menorValor = sequenciaNumeros[0];

        for (int i = 0; i < sequenciaNumeros.Length; i++)
        {
            if (sequenciaNumeros[i] < menorValor)
            {
                maiorValor = sequenciaNumeros[i];
            }
        }
        Console.WriteLine();

        Console.WriteLine("Maior valor: " + maiorValor);

        //Encontrar o valor médio da sequência
        for (int i = 0; i < sequenciaNumeros.Length; i++)
        {
            valorTotal = valorTotal + sequenciaNumeros[i];
        }

        decimal valorMedio = valorTotal / sequenciaNumeros.Length;

        Console.WriteLine();

        Console.WriteLine("Valor médio é: " + valorMedio);

        // Encontrar os 3 maiores valores

        Array.Sort(sequenciaNumeros);

        Array.Reverse(sequenciaNumeros);

        int[] tresMaiores = new int[3];

        for (int i = 0; i < tresMaiores.Length; i++)
        {
            tresMaiores[i] = sequenciaNumeros[i];
        }

        Console.WriteLine();

        Console.WriteLine("Três maiores: ");

        for (int i = 0; i < tresMaiores.Length; i++)
        {
            Console.Write(tresMaiores[i]);

            if (i != tresMaiores.Length - 1)
                Console.Write(", ");
        }

        //encontrando os valores negativos

        Array.Reverse(sequenciaNumeros);

        int qtdNumerosNegativos = 0;

        for (int i = 0; i < sequenciaNumeros.Length; i++)
        {
            if (sequenciaNumeros[i] < 0)
                qtdNumerosNegativos++;
        }

        int[] valoresNegativos = new int[qtdNumerosNegativos];

        for (int i = 0; i < sequenciaNumeros.Length; i++)
        {
            if (sequenciaNumeros[i] < 0)
            {
                valoresNegativos[i] = sequenciaNumeros[i];
            }
        }

        Console.WriteLine();

        Console.WriteLine("Valores negativos: ");

        for (int i = 0; i < valoresNegativos.Length; i++)
        {
            Console.Write(valoresNegativos[i]);

            if (i != valoresNegativos.Length - 1)
                Console.Write(", ");
        }

        //Remover itens
        Console.WriteLine();
        Console.Write("Digite o número para remover: ");
        int numeroParaRemover = Convert.ToInt32(Console.ReadLine());

        int qtdNumerosParaRemover = 0;

        for (int = 0; i < sequenciaNumeros.Length; i++)
        {
            if (sequenciaNumeros[i] == numeroParaRemover)
            {
                qtdNumerosParaRemover++;
            }
        }

        int[] novaSequenciaNumeros = new int[sequenciaNumeros.Length - qtdNumerosParaRemover];

        int j = 0;
        for (int = 0; i < sequenciaNumeros.Length; i++)
        {
            if (sequenciaNumeros[i] != numeroParaRemover)
            {
                novaSequenciaNumeros[j] = sequenciaNumeros[i];
                j++;
            }
        }

        for (int i = 0; i < novaSequenciaNumeros.Length; i++)
        {
            Console.Write(novaSequenciaNumeros[i]);

            if (i != novaSequenciaNumeros.Length - 1)
                Console.Write(", ");
        }

        Console.ReadLine();

    }

}
}
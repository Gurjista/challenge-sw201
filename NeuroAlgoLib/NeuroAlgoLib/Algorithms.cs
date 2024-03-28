using System;

namespace NeuroAlgoLib;

// TODO: Implement the Algorithms class

public static class Algorithms
{
    /// <summary>
    /// Fibonacci recursive algorithm that receives an integer n and returns the nth Fibonacci number.
    /// </summary>
    /// <param name="n"></param>
    /// <returns>The nth Fibonacci number</returns>
    public static int FibonacciRecursive(int n)
    {
        // Valores iniciais de fibonacci
        if (n == 0) return 0;
        if (n == 1) return 1;

        return FibonacciRecursive(n - 1) + FibonacciRecursive(n - 2);
        throw new NotImplementedException();
    }

    /// <summary>
    /// Fibonacci iterative algorithm that receives an integer n and returns the nth Fibonacci number.
    /// </summary>
    /// <param name="n"></param>
    /// <returns>The nth Fibonacci number</returns>
    public static int FibonacciIterative(int n)
    {
        if (n == 0) return 0;

        // Vetor para armazenar os resultados intermediários da sequência 
        int[] vet = new int[n + 1];
        vet[0] = 0;
        vet[1] = 1;

        for (int i = 2; i <= n; i++)
        {
            vet[i] = vet[i - 1] + vet[i - 2];
        }

        return vet[n];
        throw new NotImplementedException();
    }

    /// <summary>
    /// Binary search algorithm that receives an array and a target value. Array must be sorted.
    /// </summary>
    /// <param name="array">Sorted input array</param>
    /// <param name="target">Target value</param>
    /// <returns>Returns the index of the target value or -1 if not found.</returns>
    public static int BinarySearch(int[] array, int target)
    {
        // Criando pontos de esquerda e direita da busca
        int right = array.Length - 1;
        int left = 0;
        while (left <= right)
        {
            // Criando o ponto no meio do intervalo, para compara-lo com a cahve
            int mid = (left + right) / 2;

            // Checa se a chave está no meio do intervalo
            if (array[mid] == target)
            {
                return mid;
            }

            // Se a chave é maior do que o valor no meio, ignora a parte da esquerda
            if (array[mid] < target)
            {
                left = mid + 1;
            }

            // Se a chave é menor do que o valor no meio, ignora a parte da direita
            else
            {
                right = mid - 1;
            }

        }
        // Retorna -1 caso o valor não esteja presente
        return -1;

        throw new NotImplementedException();
    }
}

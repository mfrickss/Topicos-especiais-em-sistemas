using System;

class Program
{
    static void Main()
    {
        // Criando o vetor com 10 elementos aleatórios
        Random rand = new Random();
        int[] numeros = new int[10];
        
        // Preenchendo o vetor com números aleatórios entre 1 e 100
        for (int i = 0; i < numeros.Length; i++)
        {
            numeros[i] = rand.Next(1, 101); // números entre 1 e 100
        }
        
        // Exibindo os números antes de ordenar
        Console.WriteLine("Vetor antes de ordenar:");
        foreach (int numero in numeros)
        {
            Console.Write(numero + " ");
        }
        
        Console.WriteLine(); // Linha em branco
        
        // Ordenando o vetor
        Array.Sort(numeros);
        
        // Exibindo os números depois de ordenar
        Console.WriteLine("Vetor depois de ordenar:");
        foreach (int numero in numeros)
        {
            Console.Write(numero + " ");
        }
    }
}


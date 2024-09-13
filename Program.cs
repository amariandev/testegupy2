using System;

class Program
{
    static void Main()
    {
        // Solicitar ao usuário para inserir uma string
        Console.WriteLine("Informe uma string para verificar a ocorrência da letra 'a' (maiúscula ou minúscula):");
        string input = Console.ReadLine();

        // Chamar a função para contar as ocorrências da letra 'a'
        int quantidade = ContarOcorrenciasDeA(input);

        // Verificar se a letra 'a' está presente e exibir o resultado
        if (quantidade > 0)
        {
            Console.WriteLine($"A letra 'a' aparece {quantidade} vezes na string informada.");
        }
        else
        {
            Console.WriteLine("A letra 'a' não está presente na string informada.");
        }
    }

    // Função que conta as ocorrências da letra 'a' (maiúscula ou minúscula) em uma string
    static int ContarOcorrenciasDeA(string texto)
    {
        int contador = 0;

        // Percorrer cada caractere da string
        foreach (char c in texto)
        {
            // Verificar se o caractere é 'a' ou 'A'
            if (c == 'a' || c == 'A')
            {
                contador++;
            }
        }

        return contador;
    }
}

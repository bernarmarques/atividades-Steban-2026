using System;

class Exercicio5
{
    public static void Executar()
    {
        int A, B, C;
        int maior;
        int soma;

        Console.Write("Digite o valor de A: ");
        A = Convert.ToInt32(Console.ReadLine());

        Console.Write("Digite o valor de B: ");
        B = Convert.ToInt32(Console.ReadLine());

        Console.Write("Digite o valor de C: ");
        C = Convert.ToInt32(Console.ReadLine());

        // Verificando o maior número
        if (A > B && A > C)
        {
            maior = A;
        }
        else if (B > A && B > C)
        {
            maior = B;
        }
        else
        {
            maior = C;
        }

        Console.WriteLine("O maior valor é: " + maior);

        // Somando os valores
        soma = A + B + C;

        Console.WriteLine("A soma de A + B + C é: " + soma);

        // Verificando se a soma é par ou ímpar
        if (soma % 2 == 0)
        {
            Console.WriteLine("A soma é PAR");
        }
        else
        {
            Console.WriteLine("A soma é ÍMPAR");
        }
    }
}
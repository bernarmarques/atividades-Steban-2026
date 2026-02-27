using System;

class Exercicio4
{
    public static void Executar()
    {
        int numero;

        Console.Write("Digite um número inteiro: ");
        numero = Convert.ToInt32(Console.ReadLine());

        if (numero % 2 == 0)
        {
            Console.WriteLine("O número é PAR");
        }
        else
        {
            Console.WriteLine("O número é ÍMPAR");
        }
    }
}
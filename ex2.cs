using System;

class Exercicio2
{
    public static void Executar()
    {
        int A, B, C;
        double R, S, D;

        Console.Write("Digite o valor de A: ");
        A = Convert.ToInt32(Console.ReadLine());

        Console.Write("Digite o valor de B: ");
        B = Convert.ToInt32(Console.ReadLine());

        Console.Write("Digite o valor de C: ");
        C = Convert.ToInt32(Console.ReadLine());

        R = Math.Pow(A + B, 2);
        S = Math.Pow(B + C, 2);

        D = (R + S) / 2;

        Console.WriteLine("O valor de D é: " + D);
    }
}
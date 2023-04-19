using System;

class Program
{
    static void Main(string[] args)
    {
        int a, b, temp;

        Console.Write("Digite o valor de A: ");
        a = int.Parse(Console.ReadLine());
        Console.Write("Digite o valor de B: ");
        b = int.Parse(Console.ReadLine());

        temp = a;
        a = b;
        b = temp;

        Console.WriteLine("Os valores trocados são: A = " + a + " e B = " + b);
    }
}

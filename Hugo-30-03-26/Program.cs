using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("F1 comeu:");
        F1Comeu();

        Console.WriteLine("\nF2 comeu:");
        F2Comeu();

        Console.WriteLine("\nF2 e F1 comeram:");
        F2F1();

        Console.WriteLine("\nF1 e F2 comeram:");
        F1F2();
    }

    static void F1Comeu()
    {
        Console.WriteLine("α1 (pegou faca)");
        Console.WriteLine("β1 (pegou garfo)");
        Console.WriteLine("γ1 (devolveu talheres)");
    }

    static void F2Comeu()
    {
        Console.WriteLine("α2 (pegou faca)");
        Console.WriteLine("β2 (pegou garfo)");
        Console.WriteLine("γ2 (devolveu talheres)");
    }

    static void F2F1()
    {
        F2Comeu();
        F1Comeu();
    }

    static void F1F2()
    {
        F1Comeu();
        F2Comeu();
    }
}
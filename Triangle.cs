using System;

class Triangle
{
    static void Main()
    {
        int n = 4;
        int spaceBefore = n - 1;
        int spaceMid = 1;
        char copyR = '\u00A9';

        Console.Write(new string(' ', spaceBefore));
        Console.Write(copyR);
        Console.WriteLine();
        spaceBefore--;

        do
        {
            Console.Write(new string(' ', spaceBefore));
            Console.Write(copyR);
            Console.Write(new string(' ', spaceMid));
            Console.Write(copyR);
            spaceBefore--;
            spaceMid += 2;
            Console.WriteLine();

        } while (spaceBefore > 0);
        Console.Write(copyR + " " + copyR + " " + copyR + " " + copyR);
        Console.WriteLine();
    }
}
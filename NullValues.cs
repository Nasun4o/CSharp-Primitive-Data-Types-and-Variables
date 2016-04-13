using System;

class NullValues
{
    static void Main()
    {
        int? intNull = null;
        double? douNull = null;
        Console.WriteLine(intNull);
        Console.WriteLine(douNull);
        Console.WriteLine(intNull + 5);
        Console.WriteLine(douNull + 9.9);
    }
}

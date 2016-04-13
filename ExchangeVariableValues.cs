using System;

class ExchangeVariableValues
{
    static void Main()
    {
        int a = 5;
        int b = 10;

        Console.WriteLine("Before exchange:\na = {0}\nb = {1}", a, b);

        a = a + b;
        b = a - b;
        a = a - b;
        Console.WriteLine("After exchange value of \na = {0} \nb = {1}.", a, b);
    

}
}
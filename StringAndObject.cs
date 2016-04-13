using System;

class StringAndObject
{
    static void Main()
    {
        string firstString = "Hello";
        string secondString = "World";
        object helloWorld = firstString + " " + secondString;
        string thirdString = helloWorld.ToString();
        Console.WriteLine(thirdString);
    }
}

using System;

class EmployeeData
{
    static void Main()
    {
        string firstName = "Amanda";
        string lastName = "Jonson";
        ushort age = 27;
        char gender = 'f';
        ulong idNumber = 8306112507;
        ulong empNumber = 27563571;

        Console.WriteLine("First name: " + firstName);
        Console.WriteLine("Last name: " + lastName);
        Console.WriteLine("Age: " + age);
        Console.WriteLine("Gender: " + gender);
        Console.WriteLine("Personal ID: " + idNumber);
        Console.WriteLine("Unique Employee number: " + empNumber);

    }
}

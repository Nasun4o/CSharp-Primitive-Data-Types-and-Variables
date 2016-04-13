using System;

class BankAccountData
{
    static void Main()
    {
        string firstName = "Atanas";
        string middleName = "Todorov";
        string lastName = "Tankov";
        decimal balance = 10000;
        string bankName = "Lloyds";
        string iban = "BGSSTS11111123233321";
        long cardNumber1 = 112345678899000;
        long cardNumber2 = 232377661299923;
        long cardNumber3 = 331210846682929;

        Console.WriteLine("Name: {0} {1} {2}\nBalance {3}\nBank name: {4}\nIBAN: {5}\nCredit cart number:  {6}\nCredit cart number: {7}\nCredit cart number: {8}", 
        firstName , middleName , lastName , balance , bankName , iban , cardNumber1 , cardNumber2 , cardNumber3);
    }
}

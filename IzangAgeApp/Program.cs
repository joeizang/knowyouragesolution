// See https://aka.ms/new-console-template for more information

using System.Globalization;

Console.WriteLine("Welcome to our App!");

Console.WriteLine("Please enter your name: ");

string name = Console.ReadLine();

Console.WriteLine("Please enter your birth date: ");

string birthdate = Console.ReadLine();

// check that the date is in the right format, which is dd/mm/yyyy
if (DateTime.TryParseExact(birthdate, "dd/MM/yyyy", CultureInfo.InvariantCulture,
        DateTimeStyles.None, out DateTime birthDate))
{
    // calculate the age
    var age = DateTime.Now.Year - birthDate.Year;

    if (age < 1)
    {
        age = DateTime.Now.Month - birthDate.Month;
        Console.WriteLine($"By my calculations {name}, you are {age} months old.");
    }
    else
    {
        Console.WriteLine($"By my calculations {name}, you are {age * 12} months old.");
    }
}
else
{
    Console.WriteLine("""
                      Sorry but the birth date you gave me is not written correctly. 
                      It should be written following this format, day/month/year.
                      """);
}
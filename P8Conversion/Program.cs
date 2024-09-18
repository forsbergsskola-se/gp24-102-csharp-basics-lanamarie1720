// See https://aka.ms/new-console-template for more information
using System.Globalization;

Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;

Console.WriteLine("Please pick a number.");

string input = Console.ReadLine();
float numberAsDouble = float.Parse(input);

Console.WriteLine(numberAsDouble);

int number = (int) numberAsDouble;
string finalNumber = number.ToString();

Console.WriteLine(finalNumber);
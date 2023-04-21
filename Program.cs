//second project
using System;

public class Binarry
{
    public static void Main(string[] args)
    {
        Console.WriteLine ("Enter a Number");
        var input = Console.ReadLine(); // read user input
        int number = int.Parse(input!);
        string binary = Convert.ToString(number,2);
        Console.WriteLine($"The binary equivalent of {number} is {binary}");
    }
}
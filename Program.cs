using System;
using System.Linq;

class Program
{
    static void Main()
    {
        
        int[] array = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 2, 4, 6, 8 };

       
        Console.WriteLine("Масив:");
        foreach (var num in array)
        {
            Console.Write(num + " ");
        }
        Console.WriteLine();

        
        int countEven = array.Count(num => num % 2 == 0);

        
        int countOdd = array.Count(num => num % 2 != 0);

        
        int countUnique = array.Distinct().Count();

        
        Console.WriteLine($"Кількість парних елементів: {countEven}");
        Console.WriteLine($"Кількість непарних елементів: {countOdd}");
        Console.WriteLine($"Кількість унікальних елементів: {countUnique}");

        Console.ReadLine(); 
    }
}

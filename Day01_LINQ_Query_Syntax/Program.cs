using System;   
using System.Collections.Generic;


 class Program {
    private static void Main(string[] args) {
        Console.WriteLine("#------- .NET -------#");
        List<int> numbers = new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12 };

        foreach (int i in numbers) {
            if (i % 2 == 0)
                Console.WriteLine(i);

        }

        //----------------------Using LINQ---------------------//

        Console.WriteLine("#------- LINQ -------#");

        // Step 1: Getting Data Source
        List<int> numbersLinq = new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12 };

        // Step 2: Writing Query
        IEnumerable<int> evenQuery = from num in numbersLinq   // Part 1: Data Source
                                     where num % 2 == 0        // Part 2: Filter
                                     select num;               // Part 3: Select
        // Step 3: Executing Query
        foreach (int i in evenQuery) {
            Console.WriteLine(i);
        }

        Console.ReadLine();


    }
}
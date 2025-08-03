using System;

public class TriangleTypeIdentifier
{
    public static void Run()
    {
        int[] sides = new int[3];

        for (int i = 0; i < 3; i++)
        {
            Console.Write($"Enter side {i + 1}: ");
            string? input = Console.ReadLine();

            if (!int.TryParse(input, out sides[i]) || sides[i] <= 0)
            {
                Console.WriteLine("Invalid input. Please enter a positive number.");
                return;
            }
        }

        int a = sides[0], b = sides[1], c = sides[2];

        if (a + b > c && a + c > b && b + c > a)
        {
            if (a == b && b == c)
                Console.WriteLine("Equilateral Triangle");
            else if (a == b || b == c || a == c)
                Console.WriteLine("Isosceles Triangle");
            else
                Console.WriteLine("Scalene Triangle");
        }
        else
        {
            Console.WriteLine("The sides do not form a valid triangle.");
        }
    }
}

using System;

public class TicketPriceCalculator
{
    public static void Run()
    {
        Console.Write("Enter your age: ");
        string? input = Console.ReadLine();

        if (int.TryParse(input, out int age))
        {
            int price = (age <= 12 || age >= 65) ? 7 : 10;
            Console.WriteLine($"Ticket price: GHC{price}");
        }
        else
        {
            Console.WriteLine("Invalid input. Please enter a valid number.");
        }
    }
}

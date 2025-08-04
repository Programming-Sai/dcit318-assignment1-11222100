Console.WriteLine("Please enter your age:");

double price = 10.00;

if (int.TryParse(Console.ReadLine(), out int age))
{
    if (age < 13 || age > 64)
    {
        price = 7.00;
    }

    Console.WriteLine($"Your ticket price is GHC{price}");
    if (price == 7.00)
    {
        Console.WriteLine("Lucky you. Discounts are for the young and the old.");
    }
    else
    {
        Console.WriteLine("Full price. No special treatment here.");
    }
}
else
{
    Console.WriteLine("Invalid input.");
    Console.WriteLine("It’s just numbers — not that hard.");
}

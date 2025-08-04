Console.WriteLine("Enter your score (0 - 100):");

if (int.TryParse(Console.ReadLine(), out int score))
{
    if (score < 0 || score > 100)
    {
        Console.WriteLine("Invalid input.");
        Console.WriteLine("The prompt literally said 0 - 100. Do you even have eyes?");
    }
    else if (score >= 90)
    {
        Console.WriteLine("\nA");
        Console.WriteLine("Alright, leave some grades for the rest of us.");
    }
    else if (score >= 80)
    {
        Console.WriteLine("\nB");
        Console.WriteLine("Good job… but you could’ve taken a little more.");
    }
    else if (score >= 70)
    {
        Console.WriteLine("\nC");
        Console.WriteLine("Average. Just like instant noodles.");
    }
    else if (score >= 60)
    {
        Console.WriteLine("\nD");
        Console.WriteLine("At least you tried… I guess.");
    }
    else
    {
        Console.WriteLine("\nF");
        Console.WriteLine("Wow. Just wow. Did you even study?");
    }
}
else
{
    Console.WriteLine("Invalid input.");
    Console.WriteLine("Numbers only — it’s not that hard.");
}

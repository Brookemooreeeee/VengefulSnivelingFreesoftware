using System;

public static class RevCalculator
{
  public static void CalculateRev()
  {
    Console.WriteLine("\nEnter the number of contestants from last year:");
    int lastYear = int.Parse(Console.ReadLine());

    Console.WriteLine("\nEnter the number of contestants from this year:");
    int thisYear = int.Parse(Console.ReadLine());

    int rev = thisYear * 25;
    bool isMore = thisYear > lastYear;

    Console.WriteLine($"\nLast year's competition had {lastYear} contestants, and this year's has {thisYear} contestants");
    Console.WriteLine($"\nRevenue expected this year is ${rev}");
    Console.WriteLine($"\nIt is {(isMore ? "true" : "false")} that this year's competition is bigger than last year's");
    Console.WriteLine();

    GreenvilleApp app = new GreenvilleApp();
    app.Start();
  }
}
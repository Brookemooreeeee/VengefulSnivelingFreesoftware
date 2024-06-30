using System;

public static class RevCalculator
{
  //Method to calculate and display expected revenue for the year
  public static void CalculateRev()
  {
    //Prompt user for number of contestants from last year and read and parse input
    Console.Write("\nEnter the number of contestants from last year:");
    int lastYear = int.Parse(Console.ReadLine());

    //Prompt user for number of contestants from this year and read and parse input
    Console.Write("\nEnter the number of contestants from this year:");
    int thisYear = int.Parse(Console.ReadLine());

    //calulate expected revenue for this year
    int rev = thisYear * 25;
    //Determines if this years comp is larger than last years comp
    bool isMore = thisYear > lastYear;

    //Determines display message based on number of contestants
    string compMessage;
    if (thisYear > 2 * lastYear)
    {
      compMessage = "The competition is more than twice as big this year!";
    }
    else if (thisYear > lastYear)
    {
      compMessage = "The competition is bigger than ever!";
    }
    else
    {
      compMessage = "A tighter race this year! Come out and cast your vote!";
    }

    //Display results
    Console.WriteLine();
    Console.WriteLine(compMessage);
    Console.WriteLine($"Revenue expected this year is ${rev}");
    Console.WriteLine($"It is {(isMore ? "true" : "false")} that this year's competition is bigger than last year's");
    Console.WriteLine();

    //Create a new instance of GreenvilleApp and call to start the app again
    Console.WriteLine();
    GreenvilleApp app = new GreenvilleApp();
    app.Start();
  }
}
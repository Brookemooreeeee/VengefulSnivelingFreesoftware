using System;

public static class RevCalculator
{
  //Method to calculate and display expected revenue for the year
  public static void CalculateRev()
  {
    //Check if input for yeear is valid
    int lastYear = CheckContestantRange("\nEnter the number of contestants from last year:");

    //Check if input for yeear is valid
    int thisYear = CheckContestantRange("\nEnter the number of contestants from this year:");

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

  //Method to check if input is valid
  private static int CheckContestantRange(string prompt)
  {
    int contestants;
    //Loop until input is valid
    while (true)
    {
      Console.WriteLine(prompt);
      //Try to parse input as an integer
      if(int.TryParse(Console.ReadLine(), out contestants) && contestants >= 0 && contestants <= 30)
      {
        //valid input break out
        break;
      }
      //Error message for invalid input
      Console.WriteLine("Invalid input. Please enter a number between 0 and 30.");
    }
    return contestants;
  }
}
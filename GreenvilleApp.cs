using System;

public class GreenvilleApp
{
  public void Start()
  {
    DisplayMenu();
    ProcessSelection();
  }
    private void DisplayMenu()
    {
      Console.WriteLine("************************************");
      Console.WriteLine("*  The stars shine in Greenville.  *");
      Console.WriteLine("************************************");
      Console.WriteLine();
      Console.WriteLine("Please Enter the following number below from the following menu:");
      Console.WriteLine("\n1. CALCULATE Greenville Revenue Year-Over-Year");
      Console.WriteLine("2. Exit");
    }
    
    private void ProcessSelection()
    {
      string input = Console.ReadLine();

      if (input == "1")
      {
        RevCalculator.CalculateRev();
      }
      else if (input == "2")
      {
        ExitApp();
      }
      else
      {
        Console.WriteLine("Invalid selection. Please try again.");
        DisplayMenu();
        ProcessSelection();
      }
    }

  private void ExitApp()
  {
    Console.WriteLine("\nThank you for using the Greenville Revenue App, good-bye!");
  }
}
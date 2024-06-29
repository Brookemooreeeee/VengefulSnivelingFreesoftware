using System;

public class GreenvilleApp
{
  //Method to start app
  public void Start()
  {
    //Call to display motto and menu for user to select.
    DisplayMenu();
    //call to Process user selection
    ProcessSelection();
  }
  //Method to display Greenville motto and menu options
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

  //Method to process the user's menu selection
    private void ProcessSelection()
    {
      //Read user's selection
      string input = Console.ReadLine();

      //If user selects 1, call to CalculateRev
      if (input == "1")
      {
        RevCalculator.CalculateRev();
      }
      //If user selects 2, exit app
      else if (input == "2")
      {
        ExitApp();
      }
      //If user selects anything else, display error message
      else
      {
        Console.WriteLine("Invalid selection. Please try again.");
        DisplayMenu();
        ProcessSelection();
      }
    }

  //Method to exit app
  private void ExitApp()
  {
    Console.WriteLine("\nThank you for using the Greenville Revenue App, good-bye!");
  }
}
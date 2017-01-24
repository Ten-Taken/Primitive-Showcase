using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program_6
{
  class Program
  {


    //Requirement #2 - working with structures
    struct Phone
    {

      public string PhoneNumber;
      public string Manufacturer;
      public string Model;
      public string OperatingSystem;
      public double DiagonalScreenSize;

      public Phone(string number, string manuf, string model, string os)
      {
        this.PhoneNumber = number;
        this.Manufacturer = manuf;
        this.Model = model;
        this.OperatingSystem = os;
        this.DiagonalScreenSize = 10.2; //centimeters
      }

    }; //End Phone struct


    static void Main(string[] args)
    {

      Console.Title = "Program-6";

      //Main Declarations
      string myHeader = "This is Program-6";
      int counter; // quantity of instantiated structs
      char confirm; //user condition for Req5
      List<Phone> phones = new List<Phone>(); //phone list
      List<Account> accounts = new List<Account>(); //to iterate for multiple accounts
      int selection; //allows user to specify phone from phones Array
      int accSelect; //allows user to specify account from accounts Array
      string numHold;
      string manHold;
      string modelHold;
      string osHold;
      string custHold; //Account instantiation
      string addHold; //Account instantiation
      string credHold; //Account instantiation
      int accCount =0; //Counter to track accounts array
      int minsHold; //temp placeholder for minutes used



      //Requirement #1
      Console.ForegroundColor = ConsoleColor.Yellow;
      Console.WriteLine("Requirement 1: ");
      Console.ResetColor();
      Console.ForegroundColor = ConsoleColor.Magenta;
      Console.WriteLine("\t{0,7}", myHeader);
      Console.Write("\n");

      //Requirement #2 part II
      Console.ForegroundColor = ConsoleColor.Yellow;
      Console.WriteLine("Requirement 2: ");
      Console.ResetColor();

      Console.WriteLine("How many phones would you like to make?");
      int.TryParse(Console.ReadLine(), out counter);

      for (int i = 0; i < counter; i++)
      {
        Console.WriteLine("\nEnter Phone Number {0}: ", (i + 1));
        numHold = Console.ReadLine();
        Console.WriteLine("Enter Phone{0} Manufacturer: ", (i + 1));
        manHold = Console.ReadLine();
        Console.WriteLine("Enter Phone{0} Model: ", (i + 1));
        modelHold = Console.ReadLine();
        Console.WriteLine("Enter Phone{0} Operating System: ", (i + 1));
        osHold = Console.ReadLine();
        
        phones.Add(new Phone(numHold, manHold, modelHold, osHold));
      }

      //Confirm input to user
      Console.ForegroundColor = ConsoleColor.Green;
      Console.WriteLine("\nCreating {0} Phones...", counter);
      Console.ResetColor();

      var phonesArray = phones.ToArray(); //convert list to array
      Console.Write("\n");

       /* MOVED phones output to #5
      for (int j = 0; j < counter; j++)
      {
        Console.WriteLine("\n Phone{0}: {1} {2} {3} {4} {5}cm", (j + 1), phonesArray[j].PhoneNumber, phonesArray[j].Manufacturer, phonesArray[j].Model, phonesArray[j].OperatingSystem,phonesArray[j].DiagonalScreenSize);
      }
      */

      Console.Write("\n");
      Console.ForegroundColor = ConsoleColor.Yellow;
      Console.WriteLine("Requirement 3: See Account.cs ");
      Console.ResetColor();

      Console.Write("\n");
      Console.ForegroundColor = ConsoleColor.Yellow;
      Console.WriteLine("Requirement 4: See IAccountUpdate.cs ");
      Console.ResetColor();

      //Req3- Account.cs
      //Req4 - IAccountUpdate.cs

      //Requirement #5 - Tying together struct, class, interface in an application
      Console.Write("\n");
      Console.ForegroundColor = ConsoleColor.Cyan;
      Console.WriteLine("****** Hawk Mobile ******");
      Console.ResetColor();
      Console.WriteLine("Welcome to Hawk, would you like to create an account? 'y' or 'n' ");
      confirm = Console.ReadKey().KeyChar;
      Console.Write("\n");
      confirm = Char.ToUpper(confirm); // convert user entry to upper-case

      if (confirm =='Y') //If user wants to run through application, else nothing.
      {
        while (confirm != 'N')
        {
          //counter to track accounts Array
          accCount++;

          //gather account data (name, address, credit card)
          Console.WriteLine("Enter your name:");
          custHold = Console.ReadLine();
          Console.WriteLine("Enter your address:");
          addHold = Console.ReadLine();
          Console.WriteLine("Enter credit card #:");
          credHold = Console.ReadLine();


          //let user select phone from phones Array. Pass matching phone # to account
          Console.Write("\n");
          Console.WriteLine("Which phone would you like to use with your plan?");

          for (int j = 0; j < counter; j++)
          {
            Console.WriteLine("\n Phone{0}: {1} {2} {3} {4} {5}cm", (j + 1), phonesArray[j].PhoneNumber, phonesArray[j].Manufacturer, phonesArray[j].Model, phonesArray[j].OperatingSystem, phonesArray[j].DiagonalScreenSize);
          }

          int.TryParse(Console.ReadLine(),out selection);
          //prevent runtime error, check selection range
          if ((selection > counter) || (selection < 1))
          {
            Console.WriteLine("Invalid selection, using last phone in list");
            selection = counter; //smart cookie
          }


          //instantiate new account, using matching # from phones Array
          accounts.Add(new Account(phonesArray[(selection-1)].PhoneNumber, custHold, addHold,credHold));


          Console.Write("\n");
          Console.WriteLine("Create another account? 'y' or 'n' ");
          confirm = Console.ReadKey().KeyChar;
          Console.Write("\n");
          confirm = Char.ToUpper(confirm);
        } //END while loop

        //Return some details about accounts created
        var accountsArray = accounts.ToArray();

        //Work with account selected by user
        Console.WriteLine("Select account to modify:");
        //Print account customer names to user to select from
        for (int q = 0; q < accCount; q++)
        {
          Console.WriteLine("Account #{0}: Customer {1}",(q+1),accountsArray[q].CustomerName);
        }
        Console.Write("\n");
        int.TryParse(Console.ReadLine(), out accSelect);
        //validate selection
        if ((accSelect >accCount) || (accSelect < 1))
        {
          Console.WriteLine("Invalid selection, using last account choice, customer {0}",accountsArray[accCount-1].CustomerName);
          accSelect = accCount;
        }

        Console.WriteLine("How many minutes did {0} use this month?", accountsArray[accSelect - 1].CustomerName);
        int.TryParse(Console.ReadLine(),out minsHold);
        accountsArray[accSelect - 1].MinutesUsed = minsHold; //sets minutes used in account

        //set rate
        accountsArray[accSelect - 1].CostPerMinute = .15m;
        //output balance owed
        Console.ForegroundColor = ConsoleColor.Cyan;
        Console.WriteLine("Balance owed for {0} is {1:C}", accountsArray[accSelect - 1].CustomerName, accountsArray[accSelect - 1].CalculateCharge());
        Console.ResetColor();

      } //end conf IF




      //Requirement #6 - Thank user
      Console.Write("\n");
      Console.ForegroundColor = ConsoleColor.Yellow;
      Console.WriteLine("Requirement 6: ");
      Console.ForegroundColor = ConsoleColor.Magenta;
      Console.WriteLine("Thank you for running Program-6");
      Console.ResetColor();


      //Pause before exit
      Console.ReadKey(true);

    } //END MAIN
  } //END CLASS
} //END NAMESPACE

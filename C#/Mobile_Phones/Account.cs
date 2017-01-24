using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program_6
{
  class Account : IAccountUpdate //Requirement #3
  {
   
    

    //public members
    public string PhoneNumber { get; set; }
    public string CustomerName { get; set; }
    public string Address { get; set; }
    public string CreditCard { get; set; }

    //Members from implimented interface (contract to contain these)
    public decimal BalanceOwed { get; set; }
    public int MinutesUsed { get; set; }
    public decimal CostPerMinute { get; set; }

    public decimal CalculateCharge()
    {
      //finish method logic
      this.BalanceOwed = this.MinutesUsed * this.CostPerMinute;
      
      return this.BalanceOwed;
    }

    public int AdjustMinutes()
    {
      //method logic not useful
      return this.MinutesUsed;
    }


    //Programmer Defined Default Constructor
    public Account()
    {
      Console.ForegroundColor = ConsoleColor.Red;
      Console.Write("\n");
      Console.WriteLine("Account created with PDDC");
      Console.Write("\n");
      Console.ResetColor();
    }

    //Programmer Defined Constructor
    public Account(string num, string custom, string address, string card)
    {
      this.PhoneNumber = num;
      this.CustomerName = custom;
      this.Address = address;
      this.CreditCard = card;

      Console.ForegroundColor = ConsoleColor.Red;
      Console.Write("\n");
      Console.WriteLine("Account created with PDC");
      Console.Write("\n");
      Console.ResetColor();
    }


  } //END CLASS Account
}

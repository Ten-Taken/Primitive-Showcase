using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program_8
{
  class Account : IAccountUpdate
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

    }

    //Programmer Defined Constructor
    public Account(string num, string custom, string address, string card)
    {
      this.PhoneNumber = num;
      this.CustomerName = custom;
      this.Address = address;
      this.CreditCard = card;

    }



  } //END CLASS
} // END NAMESPACE

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program_6
{
  interface IAccountUpdate //Requirement #4
  {

    decimal BalanceOwed { get; set; }
    int MinutesUsed { get; set; }
    decimal CostPerMinute { get; set; }

    //interface only declares method's existence. Class defines specifications
    decimal CalculateCharge();
    int AdjustMinutes();


  } //END Interface
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Program_8
{
  public partial class Prog8Form : Form
  {

    //Declarations
    decimal counter; // quantity of instantiated structs
    List<Phone> phones = new List<Phone>(); //phone list
    List<TextBox> phoneNumberList = new List<TextBox>(); //for holding dynamic references
    List<TextBox> manufacList = new List<TextBox>(); //for holding dynamic references
    List<TextBox> modelList = new List<TextBox>(); //for holding dynamic references
    List<TextBox> oSList = new List<TextBox>(); //for holding dynamic references


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


    public Prog8Form()
    {
      InitializeComponent();
    }

    private void buttonPhones_Click(object sender, EventArgs e)
    {
      //Gather quantity of phones
      counter = quantityPhones.Value;

      //for quantity of phones, add textboxes
      for (int i = 0; i < counter; i++)
      {
        int j = i + 1; //appends label to textboxes for user clarification

        TextBox numberBox = new TextBox();
        numberBox.AppendText("Phone #"+j);
        flowPhoneBox.Controls.Add(numberBox); //add textbox to form
        phoneNumberList.Add(numberBox); //add reference to value
        TextBox manuBox = new TextBox();
        manuBox.AppendText("Manufacturer "+j);
        flowPhoneBox.Controls.Add(manuBox); //add textbox to form
        manufacList.Add(manuBox); // add reference to value
        TextBox modelBox = new TextBox();
        modelBox.AppendText("Model "+j);
        flowPhoneBox.Controls.Add(modelBox); // add textbox to form
        modelList.Add(modelBox); // add reference to value
        TextBox osBox = new TextBox();
        osBox.AppendText("OS "+j);
        flowPhoneBox.Controls.Add(osBox); // add textbox to form
        oSList.Add(osBox); //add reference to value
      }

      //make submit button visible (vs create and add button?)
      createPhonesButton.Visible = true;
      

    }

    private void createPhonesButton_Click(object sender, EventArgs e)
    {
      //convert lists to arrays (arrays belong to this method only)
      var numbersArray = phoneNumberList.ToArray();
      var manuArray = manufacList.ToArray();
      var modelArray = modelList.ToArray();
      var osArray = oSList.ToArray();

      

    //uses user entry to populate phones <List>  
  for (int i = 0; i < counter; i++)
    {
  phones.Add(new Phone(numbersArray[i].Text, manuArray[i].Text, modelArray[i].Text, osArray[i].Text));
    }

      //Convert struct list to struct array (NOT DOING THIS, EASIER TO WORK WITH LIST)
     // phonesArray = phones.ToArray();

      //make confirmation visible, append text (number of phones created)
      confirmPhones.Text = "Created "+ counter + " phones.";

      //Populate radio selection in account creation section
      for (int phone = 0; phone < counter; phone++)
      {
        RadioButton sumChoice = new RadioButton();
        string tempString = phones[phone].PhoneNumber +" "+ phones[phone].Manufacturer+" "+ phones[phone].Model+" "+ phones[phone].OperatingSystem+" "+ phones[phone].DiagonalScreenSize+"cm";

        sumChoice.AutoSize = true;

        sumChoice.Text = tempString;
        sumChoice.ForeColor = System.Drawing.Color.Orange;
        flowRadioPhones.Controls.Add(sumChoice);
      
        
        
      }

      //make account creation buttion visible
      buttAcctCreat.Visible = true;
    }

    private void buttAcctCreat_Click(object sender, EventArgs e)
    {
      //gather radio button selection into string to pass to account
      //  var checkedList = Controls.OfType<RadioButton>().Where(t => t.Checked);
      var checkedList = flowRadioPhones.Controls.OfType<RadioButton>().Where(t => t.Checked);
      

      //search for substring from checkbox, if matches number, pass number. This is a loop
      string chosenNumber="";

      for (int p = 0; p < counter; p++)
      {
        if (checkedList.ElementAt(0).Text.StartsWith(phones[p].PhoneNumber)) //must substring
        {
          chosenNumber += phones[p].PhoneNumber;
        }
      }

      //Gather user data and instantiate an account object
      Account theAccount = new Account(chosenNumber,acctNameBox.Text,acctAddrBox.Text,acctCredBox.Text);

      //pass minutes used to object
      theAccount.MinutesUsed = decimal.ToInt32(minsUpDown.Value);

      //Set cost per minute
      theAccount.CostPerMinute = .15m;

      //Status confirm account creation
      confirmAcctMade.Visible = true;

      //Output account info to user
      acctGrid.Rows.Add(theAccount.CustomerName,theAccount.Address,theAccount.PhoneNumber,theAccount.CreditCard,"$"+theAccount.CalculateCharge(),theAccount.MinutesUsed);

    }

    private void Prog8Form_FormClosing(object sender, FormClosingEventArgs e)
    {
      MessageBox.Show("#6. Thank you for running Program-8.");
    }
  } //END CLASS
} //END NAMESPACE

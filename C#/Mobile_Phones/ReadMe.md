About
-----------

This program simulates an application for signing up with a mobile phone service provider. The original purpose of the exercise was to display some competency using **structures**, **classes**, and **interfaces** in C#.

I initially built the project in Visual Studio as a solution. For simplicity,
I have stripped down the project to a single directory. 


Testing
-----------
	*Windows users can use the .bat file to compile a program.exe to test.
	*Linux and OSX users can run the .sh to compile a program.exe to test.

	For working with the .NET framework in Linux, I'm using the [Mono Platform](http://www.mono-project.com/) , this is also what the .sh script uses.

	If the file is not executable, you may need to add permissions first. 

	Example  $ chmod +x *fileName.sh*


Project Specifications
----------------------

	*Create a console application using Visual Studio
	*Output appropriate communication to the user
	*All requirements should be output and identified by number.

	1. Output a header in the console: "This is Program-6"

	2. Create a structure named Phone with the following members:
		a. Phone Number
		b. Manufacturer
		c. Model
		d. Operating System
		e. Diagonal Screen Size
		f. Constructor to set data above

	3. Ask the user how many phones to enter and configure appropriately.

	4. Create a class named Account with the following members:
		a. Inherits IAccountUpdate interface
		b. Phone Number(s)
		c. Customer Name
		d. Address
		e. Credit Card Number
		f. Constructor(s) as appropriate

	5. Create an interface named IAccountUpdate with the following members:
		a. Balance Owed
		b. Minutes Used
		c. Cost Per Minute
		d. CalculateCharge()
		e. AdjustMinutes()

	6. Using Phone, Account, and IAccountUpdate, create an application for a mobile phone company that minimally supports functionality listed. For instance: creating accounts, adding phones, calculating charges, and adjusting minutes.

	7. Output a thank you message: "Thanks for running this Program".
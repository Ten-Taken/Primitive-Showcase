About
-----------

This program simulates a GUI application for signing up with a mobile phone service provider. The original purpose of the exercise was to display some competency using Windows Forms by converting an earlier console application (see Mobile_Phones directory).

I initially built the project in Visual Studio as a solution. For simplicity,
I have stripped down the project to a single directory. 


Testing
-----------
	*Windows users can use the .bat file to compile a program.exe to test.
	*Linux and OSX users can run the .sh to compile a program.exe to test.

	For working with the .NET framework in Linux, I'm using the [Mono Platform](http://www.mono-project.com/) , this is also what the .sh script uses.

	If the file is not executable, you may need to add permissions first. 

	Example  $ chmod +x *fileName.sh*

	Display under non Windows systems may be unpredictable due to the way Windows System libraries render in the various desktop environments. For best results, build this program in Windows 7. 


Project Specifications
----------------------

	*Create a Windows Forms using Visual Studio
	*Output appropriate communication to the user
	*All requirements should be output and identified by number.

	1. Include a label : "This is Program-8"

	2. For Program 8, recreate Program 6 as a windows Form application.

	3. Include appropriate controls to accept input from the user.

	4. Include appropriate controls to message state structure and object state
		information back to the user.

	5. Include appropriate controls to invoke the methods.

	6. Include a MessageBox that displays: "Thank you for running Program-8."
	   when the application is closed.
About
-------------------------

This program demonstrates manipulation of JSON Objects, and specifically the toString
method for JSON objects in the JSON simple library. Dependencies are not included.

The JSON simple library can be acquired (with detailed instructions) from https://code.google.com/archive/p/json-simple/

Your class path will differ. An example has been included below from a batch file I used
for testing when initially authoring the Proj05Runner source file. The driver class, Proj05.java
was authored and provided by the instructor for this course. Identifying information has been 
removed to prevent future students from locating or making use of the project. 

	echo off
	cls

	del *.class

	javac -cp .;X:\Fall2016\jsonLibrary\json-simple-1.1.1.jar Proj05Runner.java
	javac -cp .;X:\Fall2016\jsonLibrary\json-simple-1.1.1.jar Proj05.java
	java -cp .;X:\Fall2016\jsonLibrary\json-simple-1.1.1.jar Proj05

	pause




Program Specifications
--------------------------

Write a program named Proj05 that uses the class definition contained in the file named Proj05.java as a driver class.

Each time your program is run, it must produce one of the following groups of three output text lines including the line containing your name. The selection of the group for any individual run is based on a random number that is generated in the driver class named Proj05.

Name: Sue  Age: 32  Student ID: 91462
Name: Sue  Age: 32  Student ID: 91462
Your name: Put your name here

Name: Tom  Age: 29  Student ID: 95360
Name: Tom  Age: 29  Student ID: 95360
Your name: Put your name here

Name: Bill  Age: 19  Student ID: 213243
Name: Bill  Age: 19  Student ID: 213243
Your name: Put your name here

Your program may also include output similar to the following with no penalty:

Note: Some input files use unchecked or unsafe operations.
Note: Recompile with -Xlint:unchecked for details. 

You may define new classes as necessary to cause your program to behave as required, but you may not modify the class definition for the class named Proj05. 
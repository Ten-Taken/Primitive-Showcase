About
-------------
This program is designed to be a manual tiny web crawler.
It allows the user to supply a web url as a command line argument,
at which point the program returns the first 10 lines of html source
from the landing page.

The purpose of the project was to show some understanding of the 
Java URL object and manipulation of stream buffers.

:boom: :boom: **Important** :boom: :boom:
	To be 100% clear, I only authored the CrawlRunner source file. I did not author the CrawlDriver source file. This file was supplied by the course instructor to be used
	as a driver class to build around. Identifying information has been removed to 
	prevent future students from using the project.


Testing
------------

While you can recompile the bytecode if you wish, there are class files present.

Without a command-line argument, the program will default to querying http://stackoverflow.com .  To test a different site, simply supply the URL at run-time

Example:
	*java CrawlDriver http://someSite.com*


Program Specifications
---------------------
Write a program that uses the driver class definition provided that will:

	* Connect to an arbitrary website identified as a command-line parameter
	* Download the default file from the website
	* Display the first ten lines of downloaded text on the command line screen
	* Number each line of text as it is displayed
	* Display your name where indicated
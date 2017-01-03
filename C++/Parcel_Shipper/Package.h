/*
Package class
Programmer: Gregory Wolfe

This is the class specification file for a class I'm using with Prog7
*/

#ifndef PACKAGE_H
#define PACKAGE_H
#include <string>	//Header file for string objects

using namespace std;

//Date Class Declaration
class Package
{
	//Member declarations
	private:
		int weight;
		int length;
		int width;
		int height;
		int girth;
		int largest; //holds largest side to calc girth
		bool stat; //true: accepted.  false: rejected
		int weightTable[15];//Holds package weight values
		float shipTable[15];//Holds shipping cost values

		

	public:
		Package(); //Default Constructor
		Package(int weigh, int lengt, int widt, int heigh,int tabWeight[15],float tabCost[15]); // Constructor
		 ~Package();
		string status(); //Returns status message
		float cost(); //Returns shipping cost of package
		bool getStat();  //returns true or false for accepted vs rejected
		int getWeight(); //Gets weight
		int getLength(); //Gets length
		int getWidth(); //Gets width
		int getHeight(); //Gets height
		void setWeght( int weigh); //Set attribute outside of constructor
		void setLength(int lengt); //Set attribute outside of constructor
		void setWidth(int widt); //Set attribute outside of constructor
		void setHeight(int heigh); //Set attribute outside of constructor


};
#endif
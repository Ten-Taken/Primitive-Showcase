/*
Package class
Programmer: Gregory Wolfe

This is the class implementation file for a class I'm using with Prog7
*/

#include "Package.h"  //Class specification header
#include <iostream> // input/output declarations
#include <iomanip>	//Header file for stream manipulators
#include <string> //string class

using namespace std;


//Programmer Defined Default Constructor
Package::Package(){
	cout <<"Default constructor, empty object.";
}

//Programmer Defined Constructor
Package::Package(int weigh, int lengt, int widt, int heigh,int tabWeight[15],float tabCost[15]){
	
	//int weightTable[15] ={1,2,3,5,7,10,13,16,20,25,30,35,40,45,50}; 
	//float shipTable[15] ={1.5,2.1,4.0,6.75,9.9,14.95,19.4,24.2,27.3,31.9,38.5,43.5,44.8,47.4,55.2};

	for (int i = 0; i < 15; i++)
	{
		weightTable[i] = tabWeight[i];
		shipTable[i]=tabCost[i];
	}

	weight = weigh;
	length = lengt;
	width = widt;
	height = heigh;


	//get largest
	largest = length;
	if (largest < width)
	{
		largest = width;
	}
	if (largest < height)
	{
		largest = height;
	}

	girth = 2*(length + width + height - largest );

	//Determine status. true: accepted.  false: rejected
	if ((width > 36)||(height > 36)||(length > 36)||(girth >60))
	{
		stat = false;
	} else if (weight > 50)
	{
		stat = false;
	} else{
		stat = true;
	}

} // end constructor

//Destructor
Package::~Package(){}

string Package::status(){
	string accepted ="Accepted";
	string rejected = "Rejected";

	if (stat)
	{
		return accepted;
	}
	else{
		return rejected;
	}

}


//cost function - THIS IS WHERE SEARCH ALGORITHM OCCURS
float Package::cost(){
	
	bool found = false; //trigger for completion
	int position = -1; //for index location found
	int index = 0; //subscript for index location

	while(index < 15 && !found)
	{
		if (weightTable[index] >= weight)
		{
			found = true;
			position = index;
		}
		index++;
	}

	//If rejected, set cost to 0, else return cost
	if (!(stat))
	{
		return 0.00;
	}
	else
	{
		return shipTable[position];
	}

} //END cost function




//Setters
void Package::setWeght( int weigh){
	weight = weigh;
}

void Package::setLength(int lengt){
	length = lengt;
}

void Package::setWidth(int widt){
	width = widt;
}

void Package::setHeight(int heigh){
	height = heigh;
}

//getters
bool Package::getStat(){
	return stat;
}

int Package::getWeight(){
	return weight;
}

int Package::getLength(){
	return length;
}

int Package::getWidth(){
	return width;
}

int Package::getHeight(){
	return height;
}
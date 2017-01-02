/*
Assignment 7 - Postal Packages
Programmer: Gregory Wolfe

Main file, begin execution here.

*/

#include <iostream> // input/output declarations
#include <iomanip>	//Header file for stream manipulators
#include <string>	//Header file for string objects
#include <cmath> //Expanded math library
#include "Package.h"  //Class specification header

using namespace std;

/*  Function Prototypes - All functions moved to Package Class  */

/*Main Function - Begin Program */
int main(){

	int weightTable[15] ={1,2,3,5,7,10,13,16,20,25,30,35,40,45,50}; 
	float shipTable[15] ={1.5,2.1,4.0,6.75,9.9,14.95,19.4,24.2,27.3,31.9,38.5,43.5,44.8,47.4,55.2}; 
	int accepted =0; //# of packages accepted
	int rejected =0; //# of packages rejected
	int weight; // holds transaction weight
	int height; // holds transaction height
	int length; // holds transaction length
	int width; // holds transaction width
	int transCount =0; //Holds loop increment count

	cout <<"For each transaction, enter package weight and 3 dimensions.";
	cout <<"\nEnter -1 to quit.\n\n";

	//transaction processing loop
	while(weight != -1)
	{
		transCount++;

		//Gather user input
		cout <<"Enter package weight length width height: ";
		cin >> weight;
		if (weight > -1)
		{
			cin >> length >> width >> height;
		}
		else{break;}
		
		cout <<endl <<endl;


		//Validate data with a nested loop
		if((weight <=0)||(length <=0)||(width <=0)||(height <=0)){
			cout<<endl<<"All dimensions must be greater than 0. Voiding transaction\n\n";
			cin.clear();
        		cin.ignore(100,'\n');
        		transCount--; //prevents counting voided transactions
			continue;
		}

		//instantiate object of Package Class
			//Package thisPackage = new Package(weight, length, width, height);
		Package thisPackage(weight, length, width, height,weightTable,shipTable);


		//Print output to user
		cout << setw(12)<<"Transaction:"<<setw(10)<<transCount<<endl;
		cout <<setw(12)<<"Status     :"<<setw(10)<<thisPackage.status()<<endl;
		cout <<setw(12)<<"Weight     :"<<setw(10)<<thisPackage.getWeight()<<endl;
		cout <<setw(12)<<"Cost       :"<<setw(10)<<setprecision(2)<<fixed<<thisPackage.cost()<<endl<<endl;


		//Increment accepted or rejected total
		if (thisPackage.getStat())
		{
			accepted++;
		}
		else
		{
			rejected++;
		}

	
	}

	
	//Print package totals, exit program
	cout <<"Number of accepted packages:"<<accepted;
	cout<<"\nNumber of rejected packages:"<<rejected;

	return 0;
}


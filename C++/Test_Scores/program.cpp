/*
Test Scores
Programmer: Gregory Wolfe


	. selector has higher priority than *

	dereference and dot operator is the equivalent of the structure pointer operator, like so:

	(*pRect).property;
	pRect->property;
*/

#include <iostream> // input/output declarations
#include <iomanip>	//Header file for stream manipulators
#include <string>	//Header file for string objects
#include <cmath> //Expanded math library

using namespace std;

/* Structures */
struct Student{
	string name;
	int score;
};



/*  Function Prototypes  */
	void recordStudents(Student *&list, int size);

	void sortStudents(Student *&list, int size);

	float avgFunction(Student *&list, int size);

	void postGrades(Student *&list, int size,float avgScore);



/*Main Function - Begin Program */
int main(){


	int sizeStudents; // Holds size of array
	float avgScore; //Holds class average
	


	//Dynamically create array for classroom
	cout << "How many students?  ";
	cin >> sizeStudents;
	Student* classRoom = new Student[sizeStudents]; //classRoom points to dynamically allocated array

	

	//Record students and scores
	recordStudents(classRoom, sizeStudents);

	//Sort array 
	sortStudents(classRoom, sizeStudents);

	//Calc average of scores
	avgScore = avgFunction(classRoom, sizeStudents);

	//Print results table to user
	postGrades(classRoom, sizeStudents,avgScore);


	return 0;
}


/* Function Definitions */

	//Gather data into the array
void recordStudents(Student *&list, int size){

	cout << "Enter Student name followed by score. \nExample: Tommy 87\n\n";

	for (int i = 0; i < size; i++)
	{
		cout << "Student "<<(i+1)<<":  ";
		cin >> (*(list + i)).name >> (*(list+i)).score;

		//validate score entry
		while((((*(list+i)).score) > 105)||(((*(list+i)).score) < 0)){
			cout <<endl<<"Invalid Score, enter value from 0 to 105: ";
			cin >>(*(list+i)).score;
		}
	} //end for loop
		cout <<endl<<endl;
}




	//Sort ascending (low to high) on score property
void sortStudents(Student *&list, int size){
	

	Student temp; //holds overwritten value
	bool swap; //flag

	do{
		swap = false;

		for (int i = 0; i < (size-1); i++)
		{
			if (((list+i)->score) > ((list+(i+1))->score) ) //if current val  greater than nextVal
			{
				temp = *(list+i); //save current student
				*(list+i) = *(list+(i+1)); //move next student down
				*(list+(i+1)) = temp; // move current student up
				swap = true; // raise flag
			}
		} //end for-loop

	} while(swap); //Loop again if a swap occurred this pass

} //END sortStudents()




	//Find score average and return it
float avgFunction(Student *&list, int size){
	float total =0;

	for (int i = 0; i < size; i++){
		total += (list+i)->score;
	}

	return (total/size);
}


	//Print grades table to user
void postGrades(Student *&list, int size, float avgScore){

	cout <<"Name"<<setw(29)<<"Score\n";
	cout <<setw(27)<<"--------------------------------\n";

	for (int i = 0; i < size; i++)
	{
		cout <<setw(30)<<left<<(list+i)->name<<setw(5)<<(list+i)->score<<endl;
	}

	cout <<setw(27)<<"--------------------------------\n";
	cout <<setw(10)<<right<<"Average"<<setw(22)<<setprecision(1)<<fixed<<avgScore;
	cout <<endl<<endl;
}

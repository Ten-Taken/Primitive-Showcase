About
----------------

This program simulates processing test scores for a class of students. The user determines
the number of students, so the program implements dynamic memory allocation and uses pointers
to reference the stored location.


Project Specifications
**********************
**********************

Input Data

For each student, the following data will be input:

    student name (your program should handle names of up to 30 characters - may contain spaces)
    score (an integer value)

Use a struct to hold the name and score for one student. The name should be storedin a C++ string object.

Validation

Processing

Your program should work for any number of students. When the program starts, it should ask the user for the number of students to be processed. Then it should dynamically allocate an array of that size (array of student/score structures).

The program should then:

    Call a function to input the student name/score pairs and store them in the array. Input validation: the score must be between 0 and 105, inclusive.
    Call a function to sort the array on the score member in ascending (increasing) order.
    Call a value-returning function that calculates the average of the scores.
    Call a function that displays a neat table of student name/score pairs in sorted order. Include appropriate column heading for your table. Following the table, display the average score with appropriate label.
    Note:In at least one of your functions, you must declare the array parameter using pointer notation instead of array notation, and inside the function you must use pointer notation instead of array notation to access the array elements. If you do not understand this requirement, email me. 

Sample Output

Name                  Score
---------------------------
Jim Smith                75
Victor Montero           81
Christa Kim              88
---------------------------
Average                  81.3

Requirements/Hints:

    Global variables are variables that are declared outside any function. Do not use global variables in your programs. Declare all your variables inside functions
    Use the C++ string class to hold the student name.
    Use a struct to store student name/score pairs.
    Use a dynamically-allocated array of structs to store the information for a class.
    In at least one of your functions, you must declare the array parameter using pointer notation instead of array notation, and inside the function you must use pointer notation instead of array notation to access the array elements. 
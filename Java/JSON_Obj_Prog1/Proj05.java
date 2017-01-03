/************************************************
Proj05

Program may produce the following or similar warnings:
Note: Some input files use unchecked or unsafe operations.
Note: Recompile with -Xlint:unchecked for details.

Program must produce one of the following groups of
three output text lines including the line containing
your name.

Name: Sue  Age: 32  Student ID: 91462
Name: Sue  Age: 32  Student ID: 91462
Your name: Put your name here

Name: Tom  Age: 29  Student ID: 95360
Name: Tom  Age: 29  Student ID: 95360
Your name: Put your name here

Name: Bill  Age: 19  Student ID: 213243
Name: Bill  Age: 19  Student ID: 213243
Your name: Put your name here

Program was tested with Java 8, Windows 7, and 
json-simple-1.1.1.
************************************************/

import org.json.simple.JSONObject;
import org.json.simple.JSONValue;
import java.util.*;

//DO NOT MODIFY THE CODE IN THIS CLASS FILE
class Proj05{

  public static void main(String[] args){
    //Construct student data
    ArrayList students = new ArrayList();
    students.add("Bill");
    students.add(new Integer(19));
    students.add(new Integer(213243));
    
    students.add("Tom");
    students.add(new Integer(29));
    students.add(new Integer(95360));
    
    students.add("Sue");
    students.add(new Integer(32));
    students.add(new Integer(91462));
    
    //Get a random bias value of 0, 3, or 6
    Random generator = new Random(new Date().getTime());
    int bias = (Math.abs(generator.nextInt()) % 3) * 3;
    
    //Display required output
    System.out.print("Name: " + (String)students.get(0 + bias));
    System.out.print("  Age: " + (Integer)students.get(1 + bias));
    System.out.println("  Student ID: " + (Integer)students.get(2 + bias));
        
    //Call the run method in the student's class
    // named Proj05Runner.
    String result = new Proj05Runner().run(
        (String)students.get(0 + bias),
        (Integer)students.get(1 + bias),
        (Integer)students.get(2 + bias));

    //Display student's output, which must match the required output
    // given above.
    JSONObject jsonObject = (JSONObject)(JSONValue.parse(result));
    System.out.print("Name: " + jsonObject.get("name"));
    System.out.print("  Age: " + jsonObject.get("age"));
    System.out.println("  Student ID: " + jsonObject.get("studentId"));
    System.out.println("Your name: " + jsonObject.get("yourName"));

  }//end main

}//end class Proj05
//=============================================//

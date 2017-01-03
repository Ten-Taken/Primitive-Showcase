/*
Gregory Wolfe


JSON (Javascript Object Notation) - language independant
 - can represent two structured types: objects and arrays.
 - An object is an unordered collection of zero or more name/value pairs
 - An array is an ordered sequence of zero or more values. 
   The values can be strings, numbers, booleans, null, and these two structured types.

 - Using the json-simple library with Java
 - toJASONString method can be used to 
   transform a Java object of type JSONObject into a JSON string.
 - JSONValue.parse() can transform a JSON string into a JSONObject object

	0,3, 6 bias generator in driver class.
	Guaranteed yield of 0,1, 2 when %3 . Further explanation found at:
	https://www.khanacademy.org/computing/computer-science/cryptography/modarithmetic/a/what-is-modular-arithmetic

Class inheritance for JSON simple library:
- ItemList: class java.lang.Object
- JSONArray: class java.util.ArrayList
- JSONObject: class java.util.HashMap
- JSONParser: class java.lang.Object
- JSONValue: class java.lang.Object
- ParseException: class java.lang.Exception
- Yytoken: class java.lang.Object

*/
import org.json.simple.JSONObject;
import java.util.*;

// 1. Create batch file(s) - set cp for json-simple library (jar file)
// 2. Reference material range (Json0195: Preface to JSON)
// 3. Contains a method run() with three parameters, returns string
	//.run(string param1, int param2, int param3)
	//driver class is passing values from ArrayList.get()

	/*
		This works because of index locations
		0, 3, 6
		1, 4, 7
		2, 5, 8
	*/

class Proj05Runner{

	String run(String name, Integer age, Integer stuID){ //Return a JSON string

		//Create JSON Object(s)
			//JSONObject myObject = new JSONObject();

		String ageString =  new Integer(age).toString();
		String stuString = new Integer(stuID).toString();

		 JSONObject myObject = new JSONObject();

		 //Populate JSON Object(s) with key/value pairs
		 myObject.put("name", name);
		 myObject.put("age", ageString);
		 myObject.put("studentId",stuString);
		 myObject.put("yourName", "Gregory Wolfe");
 
     		return myObject.toJSONString();


		

	} // END Run method

	public Proj05Runner(){ //Constructor
		
	} // End Constructor


} //END Class Proj05Runner
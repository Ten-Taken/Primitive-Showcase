/*
	General syntax of a URL.
protocol://hostname[:port]/path/filename#ref

	*protocol used to access the server (such as http),
	*name of the server,
	*port on the server (optional)
	*path and name of a specific file on the server (sometimes optional)
	*anchor or reference within the file (optional)
*/
import java.net.*;
import java.io.*;

public class CrawlRunner{

	public CrawlRunner(){ //constructor function
		System.out.println("Gregory Wolfe");
	} //end constructor

	public void run(String strURL){

		//declare String
		String dataLine;

		//try & catch blocks

		try{

			//Instantiate URL object and pass string argument
			URL url = new URL(strURL);

			//Open a connection to this URL and return an 
      			// input stream for reading from the connection.
			 BufferedReader htmlPage = 
                		new BufferedReader(new InputStreamReader(url.openStream()));
                     

      			for (int i = 0; i <10 ; i++ ) {
      				dataLine = htmlPage.readLine();
      				System.out.println((i+1)+" "+dataLine);
      			}
		} //end try

		catch(Exception e){
			e.printStackTrace();
		} //end catch

	} //end run



} //end class
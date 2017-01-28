<!DOCTYPE html>
<html>
<!--Requirement 09: -->
<head>
	<link rel="stylesheet" type="text/css" href="css/program-07.css">

		<?php 

//Declarations
	$nameErr = $yourName = $emailErr = $yourEmail = $webErr = $yourWebsite = $yourDev = $devErr = "";

//Clean up data
function test_input($data){
 	$data = trim($data);
 	 $data = stripslashes($data);
  	$data = htmlspecialchars($data);
  	return $data;

	}

//Validate submission has occurred
if ($_SERVER["REQUEST_METHOD"] == "POST") {

		if (empty($_POST["name"])) {
    		$nameErr = "Name is required";
    		
    		}

    		else{
    			$nameErr = "";
    		}



    		if (empty($_POST["email"])) {
    		$emailErr = "Email is required";
    		
    		}

    		else{
    			$emailErr = "";
    		}


    		if (empty($_POST["website"])) {
    		$webErr = "Website is required";
    		
    		}

    		else{
    			$webErr = "";
    		}



    		//Run validation and assign.
    #! multi condition allows both errors to work(no entry vs invalid entry), otherwise it's overwritten

    		$yourName = test_input($_POST["name"]);
    			#preg_match() returns true if only letters and whitespace
    		if (!preg_match("/^[a-zA-Z ]*$/",$yourName) && !empty($_POST["name"])) {
  		$nameErr = "Only letters and white space allowed";
  		#zero out assignment on validation failure
  		$yourName = ""; 
		}


		$yourEmail = test_input($_POST["email"]);
			#filver_var() php built in email validator
		if (!filter_var($yourEmail, FILTER_VALIDATE_EMAIL) && !empty($_POST["email"])) {
  		$emailErr = "Invalid email format"; 
  		#zero out assignment on validation failure
  		$yourEmail = "";
		}


		$yourWebsite = test_input($_POST["website"]);
			#Validate URL
		if (!preg_match("/\b(?:(?:https?|ftp):\/\/|www\.)[-a-z0-9+&@#\/%?=~_|!:,.;]*[-a-z0-9+&@#\/%=~_|]/i",$yourWebsite) && !empty($_POST["website"])) {
  		$webErr = "Invalid URL"; 
  		#zero out assignment on validation failure
  		$yourWebsite = "";
		}
  		

		

		if (empty($_POST["developer"])) {
    		$devErr = "You must select one.";
 		 } else {
    		$yourDev = test_input($_POST["developer"]);
  		}
    		
}


?>

</head>

<body class="gamerPage">
<a href="index.php">Return Home</a>
<p>Requirement #09</p><br><br>


<div id="finalColBox">
	
	<form method="post" action="<?php echo htmlspecialchars($_SERVER["PHP_SELF"]);?>">
	&nbsp;&nbsp;&nbsp;<span>* required field.</span>	<br><br>
	Name:<input type="text" name="name" value="<?php echo $yourName;?>">
	<span>* <?php echo $nameErr;?></span>
	<br><br>
	Email: <input type="text" name="email" value="<?php echo $yourEmail;?>">
	<span>* <?php echo $emailErr;?></span>
	<br><br>
	Website: <input type="text" name="website" value="<?php echo $yourWebsite;?>">
	<span>* <?php echo $webErr;?></span>
	<br><br>
	Which job posting?<br>
	<input type="radio" name="developer" value="front_end" <?php if (isset($yourDev) && $yourDev=="front_end") echo "checked";?>>Front-End Developer

		<input type="radio" name="developer" value="server_side" <?php if (isset($yourDev) && $yourDev=="server_side") echo "checked";?>>Server-Side Developer

		<input type="radio" name="developer" value="full_stack" <?php if (isset($yourDev) && $yourDev=="full_stack") echo "checked";?>>Full Stack Developer

		<span>* <?php echo $devErr;?></span>

		<br><br><input type="submit" value="Apply For This Job" class="formButz">

	</form>

</div>

<div id="superResults">
	<!--Display form results to user -->

	<?php 

	if ($_SERVER["REQUEST_METHOD"] == "POST") {
	echo "<h1>Thanks for your interest <samp>$yourName</samp>!</h1><br>";

	echo "You applied for our <samp>$yourDev</samp> position.";
	echo "The entry level pay is $5,000,000.  <i>cough cough </i><br><br>";

	echo "We'll be sure to check out what you've built at <samp>$yourWebsite</samp>";
	echo "<br><br>";

	echo "If we're interested, you'll hear back from us at <samp>$yourEmail</samp><br>";
}
	?>
</div>

<script type="text/javascript" src="scripts/program-07.js"></script>
</body>

</html>
<!DOCTYPE html>
<html>

<head>
	<link rel="stylesheet" type="text/css" href="css/program-07.css">

<!-- Requirement #03 -->

<?php 

#Function to validate form data as "safe"

#$today = $_GET["week"];
#$thisMonth = $_GET['year'];

function test_input($data){

 $data = trim($data);
  $data = stripslashes($data);
  $data = htmlspecialchars($data);
  return $data;

}

#trim function strips whitespace, tab, and new line
#stripslashes removes any back slashes \
#htmlspecialchars converts <> and others to PHP entities (prevents injecting Javascript code)

	// define variables and set to empty values
$today = $thisMonth ="";

if ($_SERVER["REQUEST_METHOD"] == "GET") {
  $today = test_input($_GET["week"]);
  $thisMonth = test_input($_GET["year"]);
  
}

?>

</head>


<body id="druidz">

<p>Requirement #03</p><br>
<a href="index.php">Return Home</a>

<div id="dayDiv">
	<h1>Welcome to the dayMonth processor! No XSS attacks here!</h1>
	<p>

	<?php 
	echo "<h2>Today is<samp> $today</samp>, just another day in <samp>$thisMonth</samp> </h2>";
	?>

	</p>
	
</div>

</body>

</html>
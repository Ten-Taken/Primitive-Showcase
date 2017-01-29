<!DOCTYPE html>
<html>

<head>
	<link rel="stylesheet" type="text/css" href="css/program-07.css">

<!-- Requirement #05 -->

<?php 

#Function to validate form data as "safe"

function test_input($data){

 $data = trim($data);
  $data = stripslashes($data);
  $data = htmlspecialchars($data);
  return $data;

}

	// declare variables and set to empty values
$yourName = $yourFood = $yourMovie = $yourSeason = $yourThoughts = "";

	//declare error variables to handle invalid input
#Moved to index $nameErr = $foodErr = $movieErr = "";

if ($_SERVER["REQUEST_METHOD"] == "POST") {

	/* Moved to index
	if (empty($_POST["name"])) {
    $nameErr = "Name is required";
  } else {
    $yourName = test_input($_POST["name"]);
  }

  */
	
  $yourName = test_input($_POST["name"]);
  $yourFood = test_input($_POST["food"]);
  $yourMovie = test_input($_POST["movie"]);
  $yourSeason = test_input($_POST["season"]);
  $yourThoughts = test_input($_POST["comments"]);
  	
  
}

?>

</head>


<body id="druidz">

<p>Requirement #05</p><br>
<a href="index.php">Return Home</a>

<div id="dayDiv">
	<h1>Favorites processor</h1>
	<p>

	<?php 
	echo "Hey <samp>$yourName</samp>! Thanks for telling us about your hunger for <samp>$yourFood</samp>!";
	echo "<br>We'd like to invite you out this <samp>$yourSeason</samp> to watch <samp>$yourMovie</samp> in our special theater.";
	echo "<br><br> Don't worry, we'll let our staff know your thoughts:<br><br>";
	echo "<samp>$yourThoughts</samp>";
	?>

	</p>
	
</div>

</body>

</html>
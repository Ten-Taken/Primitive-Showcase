<!DOCTYPE html>
<html>

<head>
	<link rel="stylesheet" type="text/css" href="css/program-07.css">
	<?php 

	function test_input($data){
 	$data = trim($data);
 	 $data = stripslashes($data);
  	$data = htmlspecialchars($data);
  	return $data;

	}

		//declarations
	$thyAge = $thyGender =  $thyBest = $thyReason = "";
	
		//assignment
	if ($_SERVER["REQUEST_METHOD"] == "POST") {

		$thyAge = test_input($_POST['playerAge']);
		$thyGender = test_input($_POST['sex']);
		$thyReason = test_input($_POST['whythis']);
		$thyBest = test_input($_POST['vote']);

		#test_Input can't 'array' as trim() expects string. handling in function. see below.
		

	}

	function gamezLoop(){
		#Run test_input on string values
		
		$gamesArray = $_POST['game1']; 

		foreach ($gamesArray as $game1) {
			#echo "<br />".$game1;
			echo "<br />".test_input($game1);
			
		}
		
	}
	

	?>
</head>
<body class="gamerPage">
<a href="index.php">Return Home</a>

<!--Requirement 07 -->
<div id="gameDiv">
<p>Requirement #07</p>
	<h1>Thanks for voting!</h1>

<p>Age: &nbsp;<samp><?php echo $thyAge; ?></samp></p><br><br>
<p>Gender: &nbsp;<samp><?php echo $thyGender; ?></samp></p><br><br>
<p>Games you've played: &nbsp;<samp><?php gamezLoop(); ?></samp></p><br><br>
<p>You voted for: &nbsp;<samp><?php echo $thyBest; ?></samp></p><br><br>
<p> Your reasoning: &nbsp;<samp><?php echo $thyReason; ?></samp></p>

</div>
	
	<script type="text/javascript" src="scripts/program-07.js"></script>
</body>

</html>

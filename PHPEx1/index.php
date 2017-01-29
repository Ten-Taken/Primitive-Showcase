<!DOCTYPE html>
<html>
<!--Gregory Wolfe -->
<head>
	<link rel="stylesheet" type="text/css" href="css/program-07.css">
	
</head>


<body>



<!--Requirement 01:   datalist element provides suggestions / autocomplete on input element -->
<!--Requirement 02: Form processing, Get Method-->
<div id="topBox">
	Requirements #01 and #02<br>
	<a href="selfprocessor.php">Self Processor</a> &nbsp;
	<a href="validatecontrols.php">Control Validator</a><br><br>

<form method="get" action="daymonth.php">

<datalist id="weekList">
  	<option value="Sunday">Sunday</option>
  	<option value="Monday">Monday</option>
  	<option value="Tuesday">Tuesday</option>
  	<option value="Wednesday">Wednesday</option>
  	<option value="Thursday">Thursday</option>
  	<option value="Friday">Friday</option>
  	<option value="Saturday">Saturday</option>
</datalist>

Today is: &nbsp;
<!--Input is independent / readibility -->
<input list ="weekList" name="week"/>


<datalist id="yearList">
  	<option value="January">January</option>
  	<option value="February">February</option>
  	<option value="March">March</option>
  	<option value="April">April</option>
  	<option value="May">May</option>
  	<option value="June">June</option>
  	<option value="July">July</option>
  	<option value="August">August</option>
  	<option value="September">September</option>
  	<option value="October">October</option>
  	<option value="November">November</option>
  	<option value="December">December</option>
</datalist>
&nbsp; &nbsp;
This Month: &nbsp;
<!--Input is independent / readibility -->
<input list="yearList" name="year"/>

<input type="submit" name="submit">
</form>


</div><br><br>

<!--Requirement 04:   POST Method and validation -->

<?php 

	//declare error variables to handle invalid input
$nameErr = $foodErr = $movieErr = "";

	//Conditional form action, so user can see error messages. Else head to favorites.php
	//CHANGE - handling form action variable with javascript onClick event. 
	//PHP still handles data validation and processing.
	/*
if (empty($_POST["name"]) || empty($_POST["food"]) || empty($_POST["movie"])){
$result = htmlspecialchars($_SERVER["PHP_SELF"]);}
else{$result = "favorites.php";}
	*/

	//Default form action
	# $result = "favorites.php";

	//Generating errors on submission
	if ($_SERVER["REQUEST_METHOD"] == "POST") {
		
		 if (empty($_POST["name"])) {
    		$nameErr = "Name is required";
    		
    		}

    		 if (empty($_POST["food"])) {
    		$foodErr = "Food is required";
    		
    		}

    		 if (empty($_POST["movie"])) {
    		$movieErr = "Movie is required";
    		
    		}

	}

?>
<div class="reqBox">
	Requirement #04<br><br>
	<p>Join our club today! Tell us a little about yourself. </p><br>
	<form method="POST"  id="irritatingForm">
	<span>* required field.</span><br>
		Your Name: &nbsp;&nbsp;&nbsp;&nbsp;<input type="text" name="name" id="headAche">
		<span>* <?php echo $nameErr;?></span>
		<br>
		Favorite Food: &nbsp;<input type="text" name="food" id="foodAche">
		<span>* <?php echo $foodErr;?></span>
		<br>
		Favorite Movie: <input type="text" name="movie" id="movieAche">
		<span>* <?php echo $movieErr;?></span>
		<br>
		Favorite Season:
		<input type="radio" name="season" value="Summer" checked>Summer
		<input type="radio" name="season" value="Spring">Spring
		<input type="radio" name="season" value="Fall">Fall
		<input type="radio" name="season" value="Winter">Winter
		<br>	
		Comments: <br>
		<textarea name="comments" cols="30" rows="5" id="commentsBox">Anything you'd like us to know?
		</textarea>
		<input type="submit" name="submit" onclick="sendMe()" class="formButz">
	</form>
</div>



<!--Requirement 06:   More Form Practice? -->
<div class="reqBox">
	Requirement #06<br><br>
	
	<form action="html.php" method="POST">
		Please cast your vote for 'Best Sandbox Game Ever Made ' award!<br><br>

		Your Age: <input type="number" min="1" max="108" step="1" name="playerAge" required><br><br>
		Gender: <input type="radio" name="sex" value="male" checked> Male
		<input type="radio" name="sex" value="female"> Female<br><br>
		Check any you have played:<br><!--FIXED. Break point. select options passing as undefined -->
		<input type="checkbox" name="game1[]" value="Minecraft"><span class="choices">Minecraft</span>&nbsp;
		<input type="checkbox" name="game1[]" value="Ark"> <span class="choices">Ark: Survival Evolved</span>&nbsp;
		<input type="checkbox" name="game1[]" value="LiF"><span class="choices">Life is Feudal</span>&nbsp;
		<input type="checkbox" name="game1[]" value="SE"><span class="choices">Space Engineers</span>&nbsp;
		<input type="checkbox" name="game1[]" value="X3"><span class="choices">X3TC or X3AP</span>&nbsp;
		<br><br>
		Choose the best game:
		<select name="vote">
  			<option value="Minecraft">Minecraft</option>
  			<option value="Ark Survival Evolved">Ark: Survival Evolved</option>
  			<option value="LiF">Life is Feudal</option>
  			<option value="SE">Space Engineers</option>
  			<option value="X3"> X3 Series</option>
		</select><br><br>
		Why this one?: <br>
		&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<textarea name="whythis" cols="30" rows="3"></textarea>
		<input type="submit" name="castVote" value="Vote!" class="formButz">
	</form>
	


</div>


<script type="text/javascript" src="scripts/program-07.js"></script>
</body>
</html>
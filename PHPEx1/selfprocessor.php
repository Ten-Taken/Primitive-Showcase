<!DOCTYPE html>
<html>
<!--Requirement 08: Combining forms -->
<head>
	<link rel="stylesheet" type="text/css" href="css/program-07.css">

	<?php 

//Declarations
	$nameErr = $foodErr = $movieErr = 
	$yourName = $yourFood = $yourMovie = $yourSeason = $yourThoughts = 
	$today = $thisMonth = $thyAge = $thyGender =  $thyBest = $thyReason = "";

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

    		 if (empty($_POST["food"])) {
    		$foodErr = "Food is required";
    		
    		}

    		else{
    			$foodErr = "";
    		}

    		 if (empty($_POST["movie"])) {
    		$movieErr = "Movie is required";
    		
    		}

    		else{
    			$movieErr = "";
    		}

    		//Run validation and assign.

    		$today = test_input($_POST["week"]);
  		$thisMonth = test_input($_POST["year"]);

    		$yourName = test_input($_POST["name"]);
  		$yourFood = test_input($_POST["food"]);
  		$yourMovie = test_input($_POST["movie"]);
  		$yourSeason = test_input($_POST["season"]);
  		$yourThoughts = test_input($_POST["comments"]);

    		$thyAge = test_input($_POST['playerAge']);
		$thyGender = test_input($_POST['sex']);
		$thyReason = test_input($_POST['whythis']);
		$thyBest = test_input($_POST['vote']);

    		function gamezLoop(){
		#Run test_input on string values
		
		$gamesArray = $_POST['game1']; 

		foreach ($gamesArray as $game1) {
			#echo "<br />".$game1;
			echo "<br />".test_input($game1);
			
		}
	}


}


?>

</head>

<body class="gamerPage">
<a href="index.php">Return Home</a>
<p>Requirement #08</p><br><br>

<div id="totalColBox">
<form method="post" action="<?php echo htmlspecialchars($_SERVER["PHP_SELF"]);?>">

	<!--BEGIN FORM COMBO -->

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
<input list ="weekList" name="week" value="<?php echo $today;?>" />


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
<input list="yearList" name="year" value="<?php echo $thisMonth;?>" />
<br><br>
<span>* required field.</span><br>
		Your Name: &nbsp;&nbsp;&nbsp;&nbsp;<input type="text" name="name" id="headAche" value="<?php echo $yourName;?>">
		<span>* <?php echo $nameErr;?></span>
		<br>
		Favorite Food: &nbsp;<input type="text" name="food" id="foodAche" value="<?php echo $yourFood;?>">
		<span>* <?php echo $foodErr;?></span>
		<br>
		Favorite Movie: <input type="text" name="movie" id="movieAche" value="<?php echo $yourMovie;?>">
		<span>* <?php echo $movieErr;?></span>
		<br>
		Favorite Season:
		<input type="radio" name="season" value="Summer" checked <?php if (isset($yourSeason) && $yourSeason=="Summer") echo "checked";?>>Summer
		<input type="radio" name="season" value="Spring" <?php if (isset($yourSeason) && $yourSeason=="Spring") echo "checked";?>>Spring
		<input type="radio" name="season" value="Fall" <?php if (isset($yourSeason) && $yourSeason=="Fall") echo "checked";?>>Fall
		<input type="radio" name="season" value="Winter" <?php if (isset($yourSeason) && $yourSeason=="Winter") echo "checked";?>>Winter
		<br>	
		Comments: <br>
		<textarea name="comments" cols="30" rows="5" id="commentsBox">
		<?php echo $yourThoughts;?>
		</textarea>
		<br><br>


		Your Age: <input type="number" min="1" max="108" step="1" name="playerAge" value="<?php echo $thyAge;?>" required><br><br>
		Gender: <input type="radio" name="sex" value="male" checked <?php if (isset($thyGender) && $thyGender=="male") echo "checked";?> > Male
		<input type="radio" name="sex" value="female" <?php if (isset($thyGender) && $thyGender=="female") echo "checked";?> > Female<br><br>
		Check any you have played:<br><!--FIXED. Break point. select options passing as undefined -->
		<input type="checkbox" name="game1[]" value="Minecraft" <?php if (isset($_POST['game1']) && in_array("Minecraft", $_POST['game1'])) echo 'checked="checked" '; ?>><span class="choices">Minecraft</span>&nbsp;
		<input type="checkbox" name="game1[]" value="Ark" <?php if (isset($_POST['game1']) && in_array("Ark", $_POST['game1'])) echo 'checked="checked" '; ?>> <span class="choices">Ark: Survival Evolved</span>&nbsp;
		<input type="checkbox" name="game1[]" value="LiF" <?php if (isset($_POST['game1']) && in_array("LiF", $_POST['game1'])) echo 'checked="checked" '; ?>><span class="choices">Life is Feudal</span>&nbsp;
		<input type="checkbox" name="game1[]" value="SE" <?php if (isset($_POST['game1']) && in_array("SE", $_POST['game1'])) echo 'checked="checked" '; ?>><span class="choices">Space Engineers</span>&nbsp;
		<input type="checkbox" name="game1[]" value="X3" <?php if (isset($_POST['game1']) && in_array("X3", $_POST['game1'])) echo 'checked="checked" '; ?>><span class="choices">X3TC or X3AP</span>&nbsp;
		
		<br><br>
		Choose the best game:
		<select name="vote"  required>
  			<option value="Minecraft" <?php if(isset($thyBest) &&$thyBest=="Minecraft"){echo 'selected = "selected" ';} ?>>Minecraft</option>
  			<option value="Ark Survival Evolved" <?php if(isset($thyBest) &&$thyBest=="Ark Survival Evolved"){echo 'selected = "selected" ';} ?>>Ark: Survival Evolved</option>
  			<option value="LiF" <?php if(isset($thyBest) &&$thyBest=="LiF"){echo 'selected = "selected" ';} ?>>Life is Feudal</option>
  			<option value="SE" <?php if(isset($thyBest) &&$thyBest=="SE"){echo 'selected = "selected" ';} ?>>Space Engineers</option>
  			<option value="X3" <?php if(isset($thyBest) &&$thyBest=="X3"){echo 'selected = "selected" ';} ?>> X3 Series</option>
		</select><br><br>
		Why this one?: <br>
		<textarea name="whythis" cols="30" rows="3">
			<?php echo $thyReason;?>
		</textarea>

		<input type="submit" name="makeItSo" value="Submit Big Form!" class="formButz">

	<!--END FORM COMBO -->

</form>
</div>



<div id="totalRezBox">
<h1>Form Results:</h1><br><br>
	<?php 
	//Display results to user


	echo "<h2>Today is<samp> $today</samp>, just another day in <samp>$thisMonth</samp> </h2>";
	echo "<samp>$yourName</samp>! Thanks for telling us about your hunger for <samp>$yourFood</samp>!";
	echo "<br>We'd like to invite you out this <samp>$yourSeason</samp> to watch <samp>$yourMovie</samp> in our special theater.";
	echo "<br><br> Don't worry, we'll let our staff know your thoughts:<br><br>";
	echo "<samp>$yourThoughts</samp>";

	echo "<p>Age: &nbsp;<samp>$thyAge</samp></p><br><br>";
	echo "<p>Gender: &nbsp;<samp>$thyGender</samp></p><br><br>";
	echo "<p>Games you've played: &nbsp;<samp>";
	#Only invoke function if POST has occurred. Bingo.
	if ($_SERVER["REQUEST_METHOD"] == "POST") {
	gamezLoop(); 
}
	echo "</samp></p><br><br>";
	echo "<p>You voted for: &nbsp;<samp>$thyBest</samp></p><br><br>";
	echo "<p> Your reasoning: &nbsp;<samp>$thyReason</samp></p>";

	?>
</div>
	
<script type="text/javascript" src="scripts/program-07.js"></script>
</body>

</html>
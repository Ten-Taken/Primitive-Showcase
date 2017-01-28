/*
Gregory Wolfe
*/

//Global vars
var tracker = 0;
var d = new Date();
var smartDate = d.toLocaleDateString() + " " + d.toLocaleTimeString();
var finMessage = "Safe Landing";


//Req1 function
function pushIt(){
	

	var words = ["Ah!", "Push It...", "Salt salt salt...","Salt N Pepa's here"];
	var colors = ["#DE349F","#2AE1D3","#EFBB34","#27F441"];

	document.getElementById('aud').style.display = 'inline';

	if (tracker === 0) {document.getElementById('salt').play();}

	document.getElementById('morphButton').innerHTML = words[tracker];
	document.getElementById('morphButton').style.backgroundColor = colors[tracker];
	tracker++;

	if (tracker >3 ) { tracker = 0;}
}

//allows pausing music from Req1
function stopMus(){
	document.getElementById('salt').pause();
}

//Req 2 - system time insertion
document.getElementById('today').innerHTML = smartDate;


//Req 3 - aircraft object

	/* For my own reference:
	  1.  https://developer.mozilla.org/en-US/docs/Web/JavaScript/Guide/Working_with_Objects
	  2.  https://www.youtube.com/watch?v=1bZHBHZCaAo
	*/

	//this is a constructor function
function Aircraft(type, manufacturer, maxPassengers,maxRange) {
  this.type = type;
  this.manufacturer = manufacturer;
  this.maxPassengers = maxPassengers;
  this.maxRange = maxRange;
  altitude = 0;
  ground = true;

reading = document.getElementById('redAlt');
reading.innerHTML = altitude+"ft";

  this.takeOff = function () {
  	altitude = 10000;
  	ground = false;
  	
  	document.getElementById('flameOut').innerHTML = "You lift off the runway, retract your wheels, and level off at "+altitude+ " ft";
  	reading.innerHTML = altitude+"ft";
  	return; 
  };
  this.climb = function () {
  	
  	if (ground == true) {document.getElementById('flameOut').innerHTML = "You must take off first!";
  			return;
  		}
  	else if (altitude <= 30000) {
  		altitude +=5000;
  		
  		document.getElementById('flameOut').innerHTML = "You climb 5000 ft. You are now "+altitude+" ft above sea level.";
  		reading.innerHTML = altitude+"ft";
  		return;
  	}
  	else{ document.getElementById('flameOut').innerHTML = "It is not safe to climb above "+altitude+ " ft";
  		return; }
  };
  this.descend = function () {
  	if (ground ==true) {document.getElementById('flameOut').innerHTML ="You're on the ground.";
  		return;}
  	else if (altitude>= 10000) {
  		altitude-=5000;
  		reading.innerHTML = altitude+"ft";
  		document.getElementById('flameOut').innerHTML = "You descend 5000 ft. You are now "+altitude+" ft above sea level.";
  		return;}
  	else{ document.getElementById('flameOut').innerHTML = "To go any lower than "+altitude+" ft, you must instead land.";
  		return;}
  };
  this.land = function (finMessage) {
  	ground = true;
  	altitude = 0;
  	reading.innerHTML = altitude+"ft";
  	document.getElementById('flameOut').innerHTML =finMessage;
  	return; 
  };
} //end constructor


//calls constructor and instantiates a global object with values
	//learned something new... window makes a global scope var (object here)
function createCraft(){

		//vars to hold input values for aircraft object construction
		var flyTyp = document.getElementById('crType').value;
		var flyMk = document.getElementById('crMke').value;
		var flyPas = document.getElementById('crCap').value;
		var flyRng = document.getElementById('mySlide').value;

	window.userPlane = new Aircraft(flyTyp, flyMk, flyPas, flyRng);

	document.getElementById('planeDone').style.display = "inline";
}

//function for range slider
function upSlide(a){
	document.getElementById('distance').innerHTML =a;
}

//function to display object properties to user
function retrieveCraft(){
	document.getElementById('typRslt').innerHTML = userPlane.type;
	document.getElementById('manRslt').innerHTML = userPlane.manufacturer;
	document.getElementById('capRslt').innerHTML = userPlane.maxPassengers;
	document.getElementById('RngRslt').innerHTML = userPlane.maxRange;

	document.getElementById('bldPlane').style.display="none";
	document.getElementById('poofPlane').style.display="inline-block";
}

// END AIRCRAFT ^^^ - Rest of program below *****

//Req7 string manipulations
function Req7(){

	//get typed string from user
	var A = document.getElementById('Req7In').value;
	console.log("This is A: "+A);

	document.getElementById('Req7Orgn').innerHTML = A;

	//convert all to lower case
	var B = A.toLowerCase();
	console.log("This is B: "+B);

	var typed = new RegExp('purple', 'g');
	console.log("This is typed: "+typed);

	//replace method with /g global match flag
	var C = B.replace(typed,"yellow");
	console.log("This is C: "+C);

	document.getElementById('Req7Out').innerHTML=C;
	
	/*
	var typed = new RegExp('purple', 'i'); // 'i' is case insensitive
	

	document.getElementById('Req7Out').innerHTML= A.value.replace(typed, "yellow");
*/
}

//Req8

function roundIt(){
	//get user input
	var x = document.getElementById('numba').value;

	//parse string to numeric
	x = parseFloat(x);

	//toFixed() returns a string with num at specified decimal
	x  = x.toFixed(2);
	console.log("X is "+x);

	//output back to user
	document.getElementById('moMoney').innerHTML = "$"+x;
}

//Req9
function performModulus(){
	var x = document.getElementById('numA').value;
	var y = document.getElementById('numB').value;

	var output = document.getElementById('modOut');

	output.innerHTML = (parseFloat(x) % parseFloat(y));
}

//Req10
function stringConcat(){
	var firStr = document.getElementById('phew1').value;
	var scdStr = document.getElementById('phew2').value;

	document.getElementById('bigPhew').innerHTML = firStr + scdStr;
}


//Req11
function randomRun(){
	
	var intermediate = Math.floor(Math.random()*(75-25+1)+25);
	document.getElementById('Req11').innerHTML = intermediate;
	//math.random returns 0 to .999
	// math.floor rounds down to nearest integer
}

//Req12
function setMyDate(){
	var future = new Date(2020, 0, 1);
	var answer;

	var days = ["Sunday","Monday","Tuesday","Wednesday","Thursday","Friday","Saturday"];
	answer = days[future.getDay()];
document.getElementById('secretDay').innerHTML = answer;
}


//Req13
function compareStrings(){
	var string1 = document.getElementById('req13strA').value;
	var string2 = document.getElementById('req13strB').value;
	var sanswer;

	if (string1 === string2) {sanswer = "These strings match.";}
	else{sanswer = "These strings do not match. Check punctuation and spelling.";}

	document.getElementById('stringJury').innerHTML = sanswer;
}


//Req14
document.getElementById('maximus').innerHTML = Number.MAX_VALUE;
document.getElementById('minimus').innerHTML = Number.MIN_VALUE;
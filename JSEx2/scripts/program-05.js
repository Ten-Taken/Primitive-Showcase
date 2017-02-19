//Req 1
function displaySize(){

	var width = document.getElementsByTagName('samp')[0];
	var height = document.getElementsByTagName('samp')[1];

	width.innerHTML = "Screen Width: "+ screen.width;
	height.innerHTML = "Screen Height: "+ screen.height;
}

//Req 2
function displayLocation(){
	document.getElementsByTagName('samp')[2].innerHTML = "Page location is " + window.location.href;
}

//Req 3 
function changeLocation(){
	window.location.assign("void.html");
}

//Req 4
function goBack(){
	window.history.back();
}

//Req 5
function goForward(){
	window.history.forward();
}

//Req 6
function browserInformation(){
	
document.getElementsByTagName('samp')[3].innerHTML = "App Name:   "+navigator.appName;
document.getElementsByTagName('samp')[4].innerHTML = "Code Name:   "+ navigator.appCodeName;
document.getElementsByTagName('samp')[5].innerHTML = "Product:   "+ navigator.product;
}

//Req 7
function youSure(){

	var r = confirm("Are you sure?");
	if (r === true) {
    	document.getElementsByTagName('samp')[6].innerHTML = "Version: "+navigator.appVersion;
	document.getElementsByTagName('samp')[7].innerHTML ="Version Info: "+navigator.userAgent;
	document.getElementsByTagName('samp')[8].innerHTML ="Platform: "+navigator.platform;
	} else {
		document.getElementsByTagName('samp')[6].innerHTML ="";
		document.getElementsByTagName('samp')[7].innerHTML ="";
    		document.getElementsByTagName('samp')[8].innerHTML ="You chose not to see this information.";
	}


}

//Req 8
function promptMe() {
    var person = prompt("What is your favorite browser?", "Vivaldi");
    
    if (person !== null) {
        document.getElementsByTagName('samp')[9].innerHTML = person;
    }
}


//Req 9
function clockMe(){

	/*
	9 and 10 are a scope issue
	var now = new Date();
    	var hours = now.getHours();
    	var minutes = now.getMinutes();
    	var seconds = now.getSeconds();
	*/

    	var output = document.getElementsByTagName('samp')[10];

    	window.myVar = setInterval(myTimer, 1000);

function myTimer() {
    var now = new Date();
    output.innerHTML= now.toLocaleTimeString();
	}
}



//Req 10
function pauseClock(){

	function myTimer() {
    		var now = new Date();
    		var output = document.getElementsByTagName('samp')[10];
    		output.innerHTML= now.toLocaleTimeString();
	}

	//window.clearInterval(window.myVar);
	var clock = document.getElementById('stopWatch');
	if (clock.innerHTML ==="Stop") {
		window.clearInterval(window.myVar);
		clock.innerHTML = "Start";
	}
	else{
		clock.innerHTML = "Stop";
		window.myVar = setInterval(myTimer, 1000);

	}
}

//Req 11
function slowImages(){
document.getElementsByTagName('img')[0].src = "/JSEx2/assets/noelled2.jpg";
document.getElementsByTagName('img')[1].src = "/JSEx2/assets/noelled3.jpg";
document.getElementsByTagName('img')[2].src = "/JSEx2/assets/noelled5.jpg";
}


setTimeout(slowImages, 5000);

//Req 12
function createCook(){
	document.cookie = "name="+document.getElementById('nameIn').value;
	document.cookie = "school="+document.getElementById('schoolIn').value;
	document.cookie = "hobby="+document.getElementById('hobbyIn').value;
}

function noName(){
	document.cookie = "name=; expires=Thu, 01 Jan 1970 00:00:00 UTC";
}

function noSchool(){
	document.cookie = "school=; expires=Thu, 01 Jan 1970 00:00:00 UTC";
}

function noHobby(){
	document.cookie = "hobby=; expires=Thu, 01 Jan 1970 00:00:00 UTC";
}




function getCookie(cname) {
    var name = cname + "=";
    var ca = document.cookie.split(';');
    for(var i = 0; i < ca.length; i++) {
        var c = ca[i];
        while (c.charAt(0) == ' ') {
            c = c.substring(1);
        }
        if (c.indexOf(name) === 0) {
            return c.substring(name.length, c.length);
        }
    }
    return "";
}

function finalCookie(){

	var namCook = getCookie("name");
	var schoolCook = getCookie("school");
	var hobbyCook = getCookie("hobby");
	console.log(namCook);
	console.log(schoolCook);
	console.log(hobbyCook);

	if ((namCook && schoolCook && hobbyCook) ==="") {
		alert("One or more cookies have not been set. See box #12 to set all three cookies.");
	}
	else{
		alert("name = "+namCook+"\nschool= "+schoolCook+"\nhobby = "+hobbyCook);
	}


} //end finalCookie()

finalCookie();






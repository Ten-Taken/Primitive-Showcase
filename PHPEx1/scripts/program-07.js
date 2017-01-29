

function sendMe(){
	//Get elements to check for entry
	var nameJS=document.getElementById('headAche').value;
	var foodJS=document.getElementById('foodAche').value;
	var movieJS=document.getElementById('movieAche').value;



	//Set form action element

	if ((nameJS ==="" )|| (foodJS ==="") || (movieJS ==="") ) {

		document.getElementById("irritatingForm").action = "";

	}

	else{
		document.getElementById("irritatingForm").action = "favorites.php";
	}
}



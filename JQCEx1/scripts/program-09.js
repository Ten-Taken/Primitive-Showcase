/*Gregory Wolfe */



$(document).ready(function(){

var check = 1;
var check2 = 1;
var check3 = 1;
var check4 = 1;
var check5 = 1;

   	

   //Req 2

   	$("#thePars").click(function(){
   	if (check ==1) {
   	//div	
    	$("div").parent().css("border-color","#157AA2");
    	//p
    	$("p").parent().css("border-color","#157AA2");

    	check = 0;
    }//end if

    else{
    	//div	
    	$("div").parent().css("border-color","#AFA6A6");
    	//p
    	$("p").parent().css("border-color","#AFA6A6");
    	check = 1;
    } //end else

});

   //Req 3
   $("#rememb").click(function(){

   	if (check2 ==1) {
   		$("#shaman").parents().css("border-color","#EB1818");
   		check2 = 0;
   	} //end if

   	else{
   		$("#shaman").parents().css("border-color","#AFA6A6");
   		check2 = 1;
   	}

   });

   //Req4
$("#theChildren").click(function(){
	if (check3 ==1) {
		$("nav").children().css("border-color","#000");
		$("article").children().css("border-color","#000");
		check3 = 0;
	} //end if

	else{
		$("nav").children().css("border-color","#AFA6A6");
		$("article").children().css("border-color","#AFA6A6");
		check3 =1;
	}
});
 
    //Req5
    $("#locator").click(function(){

    	if (check4 == 1) {
    		$("section").find("div").css("border-color","#90F");
    		check4 = 0;
    	}//end if

    	else{
    		$("section").find("div").css("border-color","#AFA6A6");
    		check4 = 1;
    	} //end else

    });


    //Req6
        $("#sibber").click(function(){

        	if (check5 ==1) {
        		 
        		 $("header").children("p").siblings().css("border-color","#3C3");
        		check5 = 0;
        	} //end if

        	else{
        		$("header").children("p").siblings().css("border-color","#AFA6A6");
        		check5 = 1;
        	}

        });

 }); //END DOC READY FUNCTION
/*Gregory Wolfe */


$(document).ready(function(){

   	

//Req1
$("#hide").click(function(){
    $(".cullBox").hide(300);
	});

$("#show").click(function(){
    $(".cullBox").show(300);
	});


//Req2
$("#improved").click(function(){
    $(".cullBox").toggle(700);
	});

//Req3
 $("tr:even").css("backgroundColor", "#8913BE");
 $("tr:odd").css("backgroundColor", "#CC5B40");
 	//odd
 $("#oddR").click(function(){
    $("tr:odd").toggle();
	});
 	//even
 $("#evenR").click(function(){
    $("tr:even").toggle();
	});


 //Req4
 $("#faFoot").click(function(){
    $("footer").fadeToggle(1000);
});


 //Req5
 $("#sayHello").click(function(){
 	$("#specSec").fadeTo("slow", 0.2);
 });


 //Req6
 $("#upper").click(function(){
    $("#lower").slideToggle();
});


 //Req7
 $("#leftMove").click(function(){
    $("#left-div").animate({left: '200px'});
});  


 $("#rightMove").click(function(){
    $("#right-div").animate({right: '200px'});
});  


 //Req8
$("#waterIt").click(function() {
	$("#Groot").animate({fontSize: '5em'}, "slow");
});


//Req9
   /* $(selector).hide(speed,callback); */
   $("#numNine").click(function(){

   	$("#nineleft-div").animate({left: '200px'},
   		function(){ $("#nineright-div").animate({right: '200px'});
   		});

});  

//Req10
 $("#anime").click(function(){

 	$("#tenBox").css("height", "400px").hide(3000);

});  

   }); //END DOC READY FUNCTION
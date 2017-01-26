/*Gregory Wolfe  */



$(document).ready(function(){

//Req1
$(function() {
    $("#stopDragging").draggable({ containment : "#req1div"});
  });

//Req2
$(function() {
    $("#groundDrag").draggable({ axis : "x",containment: "#req2div"});
  });

//Req3
$(function() {
$("#timeDrag").draggable({containment : "#req3div"});
  });
	//disables after 10 seconds
setTimeout(function(){$("#timeDrag").draggable('disable');},10000);

	//countdown timer for user display
var sec = 10;
var timer = setInterval(function() { 
   $('#clockIt').text(sec--);
   if (sec === -1) {
      //$('#hideMsg').fadeOut('fast');
      clearInterval(timer);
   } 
}, 1000);


//Req4
$(function() {
$("#L1").draggable({containment : "#req4div"});
  });

$(function() {
$("#R1").droppable({accept: "#L1",tolerance:"touch",hoverClass:"hover"});
  });

$(function() {
$("#L2").draggable({containment : "#req4div"});
  });

$(function() {
$("#R2").droppable({accept: "#L2",tolerance: "fit",hoverClass:"hover"});
  });


//Req5

$(function() {
$("#myArty").resizable({
               ghost: true
            });
 });


//Req6
$(function(){
	$("#myNav").resizable({

        containment: "#mySec",
         minHeight: 70,
         minWidth: 90
	});

});

/*
            $( "#changer1" ).resizable({
               alsoResize: "#changer2"
            });
            $( "#changer1" ).resizable({
               alsoResize: "#changer3"
            });
*/

//Req7
    $(function() {
            $( "#changer1" ).resizable({
               alsoResize: ".miniDivs2"
            });
});

        $(function() {
            $( "#changer2" ).resizable({
               alsoResize: ".miniDivs2"
            });
});

            $(function() {
            $( "#changer3" ).resizable({
               alsoResize: ".miniDivs2"
            });
});

                $(function() {
            $( "#changer4" ).resizable({
               alsoResize: ".miniDivs2"
            });
});



//Req8
$(function() {
$("#selectable-4").selectable({ filter : "li:first-child"});

});

$(function() {
$("#selectable-4").selectable({ filter : "li:last-child"});
});



//Req9

$(function() {
         $( "#sortable-4" ).sortable({
          placeholder: "highlight"
         });
      });

}); //END DOC READY FUNCTION
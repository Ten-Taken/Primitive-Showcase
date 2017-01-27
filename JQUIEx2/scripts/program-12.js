/*Gregory Wolfe  */

$(document).ready(function(){



	//Req1
	$(function() {
            $( "#accordion-1" ).accordion({
            collapsible: true, 
            heightStyle: "content"
        	});
         });


	//Req2
	$(function() {
 	 var dayzOf = [
               "Monday",
               "Tuesday",
               "Wednesday",
               "Thursday",
               "Friday",
               "Saturday",
               "Sunday"
            ];
            $( "#automplete-1" ).autocomplete({ source: dayzOf });
         });


	//Req3
	 $(function() {
            $( "#button-1, #button-2, #button-3").button();
            $( "#button-5" ).buttonset();
         });
   


	//Req4
	$(function() {
            $( "#datepicker-1" ).datepicker({
               beforeShowDay : function (date)
               {
                  var dayOfWeek = date.getDay ();
                  // 0 : Sunday, 1 : Monday, ...
                  if (dayOfWeek == 0 || dayOfWeek == 6) return [false];
                  else return [true];
               }
            });
         });   


	//Req5
 $(function(){
            $( "#dialog-6" ).dialog({
	       autoOpen: false, 
               buttons: {
                  OK: function() {
                     $( this ).dialog( "close" );
                  }
               },
               beforeClose: function( event, ui ) {
                  if ( !$( "#terms" ).prop( "checked" ) ) {
                     event.preventDefault();
                     $( "[for=terms]" ).addClass( "invalid" );
                  }
               },
               width: 600
            });
            $( "#opener-5" ).click(function() {
               $( "#dialog-6" ).dialog( "open" );
            });
         });




 	//Req6
 	$(function() {
            $( "#menu-2" ).menu({
               icons: { submenu: "ui-icon-circle-triangle-e"},
               position: { my: "right top", at: "right-10 top+5" }
            });
         });

 $(function() {
         $( ".menu-5" ).menu({
            create: function( event, ui ) {
               var result = $( "#result" );
               result.append( "Create event<br>" );
            },
           
            focus: function( event, ui ) {
               var result = $( "#result" );
               result.append( "Be advised: focus event<br>" );
            }
         });
       });


}); //END DOC READY FUNCTION
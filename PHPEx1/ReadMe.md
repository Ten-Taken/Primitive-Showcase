About
-----------------
This project focuses on forms processing using the GET and POST methods with PHP.

Project Specifications
------------------------------

1. The Program  index.php page should contain two datalists at the top of the page.
The first datalist contains days of the week and the second datalist contains
months of the year. Include navigation links on index.php to navigate to
selfprocessor.php and validatecontrols.php (files used later).


2. Enclose the two datalists in a form with:

	a. action=“daymonth.php’

	b. method=“get”

	c. Submit button


3. Create a form processor file named daymonth.php that displays a welcome
message and the day and month that was selected on index.php. Include a
function called “test_input” to ensure text data received from the form is
safe before displaying the data. Include an HTML element of your choice to
navigate back to index.php.


4. Create a second form with the following:

	a. action=”favorites.php”

	b. method=”post”

	c. Name textbox (required – display appropriate error message next to
	the control)

	d. Favorite Movie textbox (required – display appropriate error
	message next to the control)

	e. Favorite Food textbox (required – display appropriate error message
	next to the control)

	f. Four radio buttons for favorite season choices (make Summer the
	default setting)

	g. Comments (optional)

	h. Submit button


5. Create a form processor file named favorites.php that displays the content
of the HTML elements sent to it. Include a function called “test_input” to
ensure text data received from the form is safe before displaying the data.
Include an HTML element of your choice to navigate back to index.php.


6. Create a third form with the following:

	a. action=”html.php”

	b. method=”post”

	c. Include 5 new HTML5 input type elements

	d. Apply 5 new HTML5 input attributes to the elements (NOT 5 per; a
	total of 5)

	e. Submit button


7. Create a form processor file named html.php that displays the content of
the HTML elements sent to it. Include an HTML element of your choice to
navigate back to index.php.


8. Create a file named selfprocessor.php:

	a. Combine the contents of the three forms above into one form

	b. action= make the form call the current page, that is, call itself. Be
	sure to validate form data in this action.

	c. method=”post”

	d. Include code on the page to check whether the form was submitted

	e. Include code to process and display the data when submitted

	f. Include code in the form that retains the values in the controls after
	submission (a.k.a sticky form)

	g. Include a function called “test_input” to ensure text data received
	from the form is safe before displaying the data.


9. Create a file named validatecontrols.php that is a self-processor

	a. Name textbox (required – only letters and spaces are allowed.
	display appropriate error message next to the control)

	b. Email (required – verify email format)

	c. Website (required – verify correct URL format)

	d. Three “Developer Type” radio buttons (Front-End ; Server-Side ; Full
	Stack). No default set. Ensure one button has been selected.

	e. action= make the form call the current page, that is, call itself. Be
	sure to validate form data in this action.

	f. method=”post”

	g. Include code on the page to check whether the form was submitted

	h. Include code to process and display the data when submitted

	i. Include code in the form that retains the values in the controls after
	submission (a.k.a sticky form)

	j. Include a function called “test_input” to ensure text data received
	from the form is safe before displaying the data.
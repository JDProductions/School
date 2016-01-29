<!DOCTYPE html>
<html>
<head>
	<title></title>
</head>
<body>

	<?php
		$daysOfWeek = array("Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday", "Sunday");
		$arrLength = count($daysOfWeek);

	for($x = 0; $x <  $arrLength; $x++) {
     
     echo "The days of the week in english are " .$daysOfWeek[$x];
     echo "<br>";

}
	$daysOfWeek[0] = "Lundi";
	$daysOfWeek[1] = "Mardi";
	$daysOfWeek[2] = "Mercredi";
	$daysOfWeek[3] = "Jeudi";
	$daysOfWeek[4] = "Vendredi";
	$daysOfWeek[5] = "Samedi.";
	$daysOfWeek[6] = "Dimanche";
     
     echo "<br>";
		for($x = 0; $x <  $arrLength; $x++) {
     echo "The days of the week in french are " .$daysOfWeek[$x];
     echo "<br>";

}



	?>


</body>
</html>
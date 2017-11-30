<?php 
if (isset($_POST['submit'])) {

	include_once "database_info.php";

	$firstname = mysqli_real_escape_string($conn,$_POST['firstname']);
	$lastname= mysqli_real_escape_string($conn,$_POST['lastname']);
	$email= mysqli_real_escape_string($conn,$_POST['email']);
	$password= mysqli_real_escape_string($conn,$_POST['password']);

	$sql = "INSERT INTO users (firstname, lastname, email, password) VALUES ('$firstname', '$lastname', '$email','$password')";
	

	session_start();


	$_SESSION["username"] = $firstname;
	if(mysqli_query($conn, $sql)){
	    echo "Records inserted successfully.";


	} else{
	    echo "ERROR: Could not able to execute $sql. " . mysqli_error($link);
	}


	 



	header('Location: ../home/index.php');


	// Close connection
	mysqli_close($conn);

}
?>
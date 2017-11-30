<?php

session_start(); //Copy and paste this into the pages that requiere a session
//<?php session_start();      



//?/>//


if (isset($_POST['submit'])) {
	include 'database_info.php';


	$email = mysqli_real_escape_string($conn, $_POST['email']);
	$pwd = mysqli_real_escape_string($conn, $_POST['psw']);
	

//ERROR CHECKING
	//CHECK INPUT EMPTY

	if (empty($email) || empty($pwd)) {
		header("Location: ../index.php?login=empty");
		exit();

										}else{
												$sql = "SELECT * FROM users WHERE email='$email'";
												$result = mysqli_query($conn, $sql);
												$resultCheck = mysqli_num_rows($result);

												if ($row = mysqli_fetch_assoc($result)) {

														

																						}if($row['password'] == $pwd){
																							//Log in the user here
																							$_SESSION['username'] = $row['firstname'];
																							$_SESSION['lastname'] = $row['lastname'];
																							$_SESSION['email'] = $row['email'];
																					
																							$_SESSION['id'] = $row['id'];

																							header("Location: ../home/index.php?login=welcome");
																							exit();
																													 }
					

											}

							}else{

							header("Location: ../index.php?login=error");
							exit();  
								 }

?>
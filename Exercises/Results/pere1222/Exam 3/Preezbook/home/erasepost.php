<?php 

if (isset($_POST['submit'])) { 
	include '../includes/database_info.php';


	$postid = mysqli_real_escape_string($conn, $_POST['postid']);


	$sql = " DELETE FROM posts WHERE postid = '$postid' ";
	$result = $conn->query($sql);



	header('Location: index.php');





}






?>
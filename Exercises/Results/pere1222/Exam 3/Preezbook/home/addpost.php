<?php 

if (isset($_POST['submit'])) {
	include '../includes/database_info.php'; 

	$receiverid =	mysqli_real_escape_string($conn, $_POST['friendid']);
	$senderid = mysqli_real_escape_string($conn, $_POST['userid']);
	$post =	mysqli_real_escape_string($conn, $_POST['post']);

	$sql = " INSERT INTO posts (senderid,receiverid,text) VALUES ('$senderid','$receiverid','$post')";
	$result = $conn->query($sql);


	header('Location: index.php');
}




?>
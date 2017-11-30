<?php

if (isset($_POST['submit'])) {
	include '../includes/database_info.php';

	$friendid = mysqli_real_escape_string($conn, $_POST['friendid']);
	$userid = mysqli_real_escape_string($conn, $_POST['userid']);

	$sql = " INSERT into listoffriends (friendid, userid) VALUES ('$friendid', '$userid')";
	$result = $conn->query($sql);

	header('Location: index.php');


}


?>
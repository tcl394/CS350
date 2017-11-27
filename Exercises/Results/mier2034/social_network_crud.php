<?php
function connectDB() {
  $dbServername = "localhost";
  $dbUsername = "root";
  $dbPasswordname = "";
  $dbname = "socialnetwork";
  $conn = mysqli_connect($dbServername,$dbUsername,$dbPasswordname,$dbname);
  echo 'Successfully connected to DB <br/>';
  return $conn;
}

function addUser($conn, $firstname, $lastname, $email, $password){
  $sql = "INSERT INTO user(firstname, lastname, email, password) values ('$firstname','$lastname','$email','$password')";
  if ($conn->query($sql) == TRUE) {
    echo "New user created successfully <br/>";
  } else {
    echo "Error: " . $sql . "<br>" . $conn->error;
  }
}

function deleteUser($conn, $id, $email){
  $sql = "DELETE FROM user WHERE id='$id' AND email = '$email'";
  if ($conn->query($sql) == TRUE) {
    echo "User deleted successfully <br/>";
  } else {
    echo "Error: " . $sql . "<br>" . $conn->error;
  }
}

function addFriend($conn, $user_id, $friend_id){
  $sql = "INSERT into friends VALUES ('$user_id','$friend_id')";
  if ($conn->query($sql) == TRUE) {
    echo "Added a new friend <br/>";
  } else {
    echo "Error: " . $sql . "<br>" . $conn->error;
  }
}

function removeFriend($conn, $user_id, $friend_id){
  $sql = "DELETE FROM friends WHERE id ='$user_id' and friend_id = '$friend_id'";
  if ($conn->query($sql) == TRUE) {
    echo "Removed friendship <br/>";
  } else {
    echo "Error: " . $sql . "<br>" . $conn->error;
  }
}

function addTopic($conn,$title,$topic,$auth, $auth_id,$user_id){
  $sql = "INSERT INTO topics (title,topic,auth,auth_id,user_id) values ('$title','$topic','$auth','$auth_id','$user_id')";
  if ($conn->query($sql) == TRUE) {
    echo "Added topic <br/>";
  } else {
    echo "Error: " . $sql . "<br>" . $conn->error;
  }
}

function removeTopic($conn,$id,$auth){
  $sql = "DELETE FROM topics WHERE id ='$id' and auth = '$auth'";
  if ($conn->query($sql) == TRUE) {
    echo "Removed topic <br/>";
  } else {
    echo "Error: " . $sql . "<br>" . $conn->error;
  }
}

 function test(){
   $conn = connectDB();
   addUser($conn,'Jane' ,'Smith', 'jane@test.com', 'test');
   deleteUser($conn, '6', 'jane@test.com');
   addFriend($conn,'5','9');
   removeFriend($conn,'5','9');
   addTopic($conn,'Test','this is a test','jonny', '1','1');
   removeTopic($conn,'5','jonny');
 }
 
 ?>

<?php
if (isset($_POST['action'])) {
    switch($_POST['action']) {

    case 'signup':
      $conn = connectDB();
      $first = $_POST['FirstName'];
      $last = $_POST['LastName'];
      $email = $_POST['Email'];
      $psw = $_POST['Password'];
      addUser($conn, $first, $last, $email, $psw);

      $sql = "SELECT * FROM user WHERE email='$email'";
      $result = mysqli_query($conn, $sql);
      if ($row = mysqli_fetch_assoc($result)) {
        $_SESSION['First'] = $first;
        $_SESSION['ID'] = $row['id'];
      }

      header("Location: social_network_home.php");
      break;

      case 'login':
        $conn = connectDB();
        $email = $_POST['Email'];
        $psw = $_POST['Password'];
        $sql = "SELECT * FROM user WHERE email='$email'";
		    $result = mysqli_query($conn, $sql);

        if ($row = mysqli_fetch_assoc($result)) {
          if ($email == $row['email'] && $psw == $row['password']){
              $_SESSION['First'] = $row['firstname'];
              $_SESSION['ID'] = $row['id'];
              header("Location: social_network_home.php");
          }
          else{
            header("Location: social_network_index.html");
          }
        }
        break;

      case 'addFriend':
        $conn = connectDB();
        $email = $_POST['Email'];
        $id = $_SESSION['ID'];
        $sql = "SELECT id FROM user WHERE email='$email'";
		    $result = mysqli_query($conn, $sql);
        if ($row = mysqli_fetch_assoc($result)) {
          $friend_id = $row['id'];
          addFriend($conn, $id, $friend_id);
          header("Location: social_network_home.php");
        }else {
          header("Location: social_network_home.php");
        }
        break;

      case 'removeFriend':
        $conn = connectDB();
        $email = $_POST['Email'];
        $id = $_SESSION['ID'];
        $sql = "SELECT id FROM user WHERE email='$email'";
        $result = mysqli_query($conn, $sql);
        
        if ($row = mysqli_fetch_assoc($result)) {
          $friend_id = $row['id'];
          removeFriend($conn, $id, $friend_id);
          header("Location: social_network_home.php");
        }
          else {
            header("Location: social_network_home.php");
          }
          break;

      case 'addTopic':
        $conn = connectDB();
        $title = $_POST['Title'];
        $topic = $_POST['Topic'];
        $id = $_SESSION['ID'];
        $sql = "SELECT * FROM user WHERE id='$id'";
        $result = mysqli_query($conn, $sql);

        if ($row = mysqli_fetch_assoc($result)) {
          $auth = $row['firstname'];
          addTopic($conn,$title,$topic,$auth,$id,$id);
          header("Location: social_network_home.php");
        }
        else {
          header("Location: social_network_home.php");
        }
        break;

      case 'addTopicFriend':
          $conn = connectDB();
          $title = $_POST['Title'];
          $topic = $_POST['Topic'];
          $friend_email = $_POST['Email'];
          $id = $_SESSION['ID'];

          $sql = "SELECT * FROM user WHERE id='$id'";
          $result = mysqli_query($conn, $sql);

          $sqli = "SELECT * FROM user WHERE email='$friend_email'";
          $results = mysqli_query($conn, $sqli);

          if ($row = mysqli_fetch_assoc($result)) {
            if ($rows = mysqli_fetch_assoc($results)) {

            $auth = $row['firstname'];
            $friend_id = $rows['id'];
            addTopic($conn,$title,$topic,$auth,$id,$friend_id);
            header("Location: social_network_home.php");
            }
          }else {
            header("Location: social_network_home.php");
          }
          break;

      case 'removeTopic':
            $conn = connectDB();
            $title = $_POST['Title'];
            $id = $_SESSION['ID'];

            $sql = "SELECT * from topics WHERE topics.title = '$title' and topics.auth_id = '$id' and topics.user_id = '$id'";
            $result = mysqli_query($conn, $sql);


            if ($row = mysqli_fetch_assoc($result)) {
              $top_id = $row['id'];
              $auth = $row['auth'];
              removeTopic($conn,$top_id,$auth);
              header("Location: social_network_home.php");
          }
            else {
              header("Location: social_network_home.php");
            }
            break;

      case 'removeFriendTopic':
	    $conn = connectDB();
	    $title = $_POST['Title'];
	    $friend_email = $_POST['Email'];
	    $id = $_SESSION['ID'];

	   $sql = "SELECT id, auth from topics where topics.title = '$title' and topics.auth_id = '$id'";
	   $result = mysqli_query($conn, $sql);

	   if ($row = mysqli_fetch_assoc($result)) {
	     $top_id = $row['id'];
	     $auth = $row['auth'];
	     removeTopic($conn,$top_id,$auth);
	     header("Location: social_network_home.php");
	  }else {
	     header("Location: social_network_home.php");
	  }
	  break;
		    
        case 'dropall':
          $conn = connectDB();
          $sql = "DROP TABLE user,topics,friends";
          mysqli_query($conn, $sql);
          header("Location: social_network_index.html");
          break;

        case 'testAll':
          test();

    }
}
?>

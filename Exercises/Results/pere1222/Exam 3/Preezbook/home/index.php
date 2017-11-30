<?php 
session_start();
?>

<html>
<head>
    <title>Preez/Home</title>


<style type="text/css">

body{
    background-color: #3b5998;
    font-family:  arial;
}

#AddFriends{
    float: left;

}
#newsBox{
    background-color: white;
    width: 100%;
    height: 40em;
    margin-top: 0.5em;
}

#FriendsList{
    float: left;


}


#AddFriends,#Posttofriend,#yourpost,#FriendsList{

color: rgb(3, 0, 198);
width: 30em;
height: 20em;

}

#Posttofriend{
    float: left;

}

#yourpost{
    float: left;
    width: 25em;
}

/* Add a black background color to the top navigation */
.topnav {
    background-color: #3b5998;
    overflow: hidden;
    margin-top: 0px;

}

/* Style the links inside the navigation bar */
.topnav a {
    float: left;
    color: #f2f2f2;
    text-align: center;
    padding: 14px 16px;
    text-decoration: none;
    font-size: 17px;
}

.topnav #Name{
    float: right;
    color: #f2f2f2;
    text-align: center;
    padding: 14px 16px;
    text-decoration: none;
    font-size: 17px;
    margin: 0px;
    margin-right: 2em;

}

/* Change the color of links on hover */
.topnav a:hover {
    background-color: #ddd;
    color: black;
}

/* Add a color to the active/current link */
.topnav a.active {
    background-color: #0e1f56;
    color: white;
}

</style>

</head>
<body>

<?php 

include_once '../includes/database_info.php';


//Get the ID of current user using Name
$name = $_SESSION["username"];
$sql = " SELECT id FROM users WHERE firstname='$name' ";
$result = $conn->query($sql);

//returns the raw values of the row instead of the object
$row = mysqli_fetch_row($result);

//echo $row[0]; // <- ID OF THE CURRENT USER


// Get list of friend to add 
$sql2 = " SELECT * FROM users WHERE id != '$row[0]'";
$resultFriends = $conn->query($sql2);


// Get list of current friends
$sql3 = " SELECT * FROM listoffriends WHERE userid = '$row[0]'";
$CurrentFriends = $conn->query($sql3);






?>


<div class="topnav" id="myTopnav">
      <a class="active" href="#home">Home</a>

      <p id="Name"> Hello <?php echo $_SESSION["username"]." ".$_SESSION['lastname']; ?> ! </p>
      <!-- <a href="#news">News</a>
      <a href="#contact">Contact</a>
      <a href="#about">About</a> -->
</div>

<center>
    <div id="newsBox">

        <div id="AddFriends">
            <h3> Add new Friends </h3>

            <table>

                
                    
                    <?php  foreach ($resultFriends as $possiblefriend) { ?>
                    <tr>
                   
                    <td>  <?php echo $possiblefriend['firstname']; echo " "; echo $possiblefriend['lastname']; ?> </td> 

                        <td>
                            <form action="addfriend.php" method="post">
                            <input type="hidden" name="friendid" value="<?php  echo $possiblefriend['id']; ?>">
                            <input type="hidden" name="userid" value="<?php  echo $row[0]; ?>">

                            <input type="submit" name="submit" value="add friend">
                            </form>
                        </td>
                    </tr>


                    <?php  }  ?>
 
            </table>
        </div> <!-- End of Add Friends Box-->


        <div id="FriendsList">
            <h3> List of Current Friends </h3>

                <!-- Displays all the id of the user's friends -->
                <?php foreach ($CurrentFriends as $friend) {

                    $CurrentFriendforuser = $friend['friendid'];

                    $sql4 = " SELECT * FROM users WHERE id = '$CurrentFriendforuser'";

                    $FriendRelationship = $conn->query($sql4);



                    foreach ($FriendRelationship as $UniqueFriend) {  ?>


                            <!--  DISPLAY AND DELETE FRIEND BUTTON FORM-->
                            <form action="deletefriend.php" method="post">
                            <?php echo $UniqueFriend['firstname']." ".$UniqueFriend['lastname'];  ?>
                            <input type="hidden" name="friendid" value="<?php  echo $UniqueFriend['id']; ?>">
                            <input type="hidden" name="userid" value="<?php  echo $row[0]; ?>">
                            <input type="submit" name="submit" value="delete friend">
                            </form>
                            <br>




                   
                <?php } }   ?>




        </div> <!-- End of FriendsList Box-->



        <div id="yourpost">  <!-- post Box-->
            <h3> Your post</h3>

            <?php  
            // Get post of the user
            $sql5 = " SELECT * FROM posts WHERE receiverid = '$row[0]';";
            $posts = $conn->query($sql5); 
            foreach ($posts as $post) { ?>
       

            <form action="erasepost.php" method="post">
            <p> <?php echo $post['text']; ?> </p>



            <input type="hidden" name="postid" value="<?php  echo $post['postid']; ?>">

            <input type="submit" name="submit" value="Erase this post">


            </form>






            <?php  } ?>



        </div> <!-- End of your post Box-->

                          





        <!-- Box to post to friends -->
        <div id="Posttofriend">
            <h3> Friends to post</h3>


                <!-- Displays all the id of the user's friends -->
                <?php foreach ($CurrentFriends as $friend) {

                    $CurrentFriendforuser = $friend['friendid'];

                    $sql4 = " SELECT * FROM users WHERE id = '$CurrentFriendforuser'";

                    $FriendRelationship = $conn->query($sql4);



                    foreach ($FriendRelationship as $UniqueFriend) {  ?>


                            <!--  DISPLAY AND DELETE FRIEND BUTTON FORM-->
                            <form action="addpost.php" method="post">

                            <?php echo $UniqueFriend['firstname']." ".$UniqueFriend['lastname'];  ?>
                            <input type="hidden" name="friendid" value="<?php  echo $UniqueFriend['id']; ?>">
                            <input type="hidden" name="userid" value="<?php  echo $row[0]; ?>">

                            <input type="text"  name="post" >
                            <input type="submit" name="submit" value="Post">
                            </form>
                            <br>




                   
        <?php } }   ?>



        </div>  <!-- End of add post to friends -->



    </div> <!-- End News Box-->

  
</center>

</body>
</html>
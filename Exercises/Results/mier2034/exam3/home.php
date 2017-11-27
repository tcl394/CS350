<?php
session_start();

$dbServername = "localhost";
$dbUsername = "root";
$dbPasswordname = "";
$dbname = "socialnetwork";
$mysqli = mysqli_connect($dbServername,$dbUsername,$dbPasswordname,$dbname);
$id = $_SESSION['ID'];
$sql = "SELECT firstname, lastname, email FROM user";
$users = $mysqli->query($sql);
?>

<html>
  <head>
    <link rel="stylesheet" href="https://maxcdn.bootstrapcdn.com/bootstrap/3.3.7/css/bootstrap.min.css">
    <script src="https://ajax.googleapis.com/ajax/libs/jquery/3.2.1/jquery.min.js"></script>
    <script src="https://maxcdn.bootstrapcdn.com/bootstrap/3.3.7/js/bootstrap.min.js"></script>
  </head>

  <body>
    <center><h1><?php echo $_SESSION['First'];?> Profile</h1></center>
    <div class="container">
          <h3>All Users</h3>
    </div>

<center>
    <div class="container">
      <table class="table table-striped">
        <thead>
          <tr>
            <th>Firstname</th>
            <th>Lastname</th>
            <th>Email</th>
          </tr>
        </thead>
        <tbody>

        <?php foreach ($users as $user) {?>
          <tr>
            <td><?php echo $user['firstname']?></td>
            <td><?php echo $user['lastname']?></td>
            <td><?php echo $user['email']?></td>
          </tr>
        <?php }?>

        </tbody>
      </table>
    </div>
</center>



<?php
$sqli = "SELECT firstname, lastname, email FROM user, friends WHERE (friends.id = $id and user.id = friends.friend_id) or (friends.friend_id = $id and user.id = friends.id) ";
$friends = $mysqli->query($sqli);
?>


<div class="container">
      <h3>Friends</h3>
</div>

<center>
    <div class="container">
      <table class="table table-striped">
        <thead>
          <tr>
            <th>Firstname</th>
            <th>Lastname</th>
            <th>Email</th>
          </tr>
        </thead>
        <tbody>

        <?php foreach ($friends as $friend) {?>
          <tr>
            <td><?php echo $friend['firstname']?></td>
            <td><?php echo $friend['lastname']?></td>
            <td><?php echo $friend['email']?></td>
          </tr>
        <?php }?>

        </tbody>
      </table>
    </div>
</center>

<center>
  <div class="form-group">
    <form class="" action="social_network_test.php" method="POST">
      <input type="hidden" name="action" value="addFriend" />
      <label><b>Email</b></label>
      <input type="text" placeholder="Enter Friends Email" name="Email" id="Email" required>
      <button type="submit">Add friend </button>
    </form>
  </div>
</center>

<center>
  <div class="form-group">
    <form class="" action="social_network_test.php" method="POST">
      <input type="hidden" name="action" value="removeFriend" />
      <label><b>Email</b></label>
      <input type="text" placeholder="Enter Friends Email" name="Email" id="Email" required>
      <button type="submit">Remove friend </button>
    </form>
  </div>
</center>


<?php
$sq = "SELECT title, topic, auth FROM topics WHERE topics.user_id = $id";
$topics = $mysqli->query($sq);
?>

<div class="container">
      <h3>My Topics</h3>
</div>

<center>
    <div class="container">
      <table class="table table-striped">
        <thead>
          <tr>
            <th>Title</th>
            <th>Topic</th>
            <th>Author</th>
          </tr>
        </thead>
        <tbody>

        <?php foreach ($topics as $topic) {?>
          <tr>
            <td><?php echo $topic['title']?></td>
            <td><?php echo $topic['topic']?></td>
            <td><?php echo $topic['auth']?></td>
          </tr>
        <?php }?>

        </tbody>
      </table>
    </div>
</center>

<center>
  <div class="form-group">
    <form class="" action="social_network_test.php" method="POST">
      <input type="hidden" name="action" value="addTopic" />
      <label><b>Title</b></label>
      <input type="text" placeholder="Title" name="Title" id="Title" required>
      <label><b>Topic</b></label>
      <input type="text" placeholder="Topic" name="Topic" id="Topic" required>
      <button type="submit">Add Topic </button>
    </form>
  </div>
</center>

<center>
  <div class="form-group">
    <form class="" action="social_network_test.php" method="POST">
      <input type="hidden" name="action" value="removeTopic" />
      <label><b>Title</b></label>
      <input type="text" placeholder="Title" name="Title" id="Title" required>
      <button type="submit">Remove Topic </button>
    </form>
  </div>
</center>






<?php
$sq = "SELECT title, topic, auth, firstname FROM topics, user WHERE topics.auth_id = $id and topics.user_id = user.id";
$topics = $mysqli->query($sq);
?>

<div class="container">
      <h3>Topics Sent</h3>
</div>

<center>
    <div class="container">
      <table class="table table-striped">
        <thead>
          <tr>
            <th>Title</th>
            <th>Topic</th>
            <th>Author</th>
            <th>Recipiant</th>
          </tr>
        </thead>
        <tbody>

        <?php foreach ($topics as $topic) {?>
          <tr>
            <td><?php echo $topic['title']?></td>
            <td><?php echo $topic['topic']?></td>
            <td><?php echo $topic['auth']?></td>
            <td><?php echo $topic['firstname']?></td>
          </tr>
        <?php }?>

        </tbody>
      </table>
    </div>
</center>

<center>
  <div class="form-group">
    <form class="" action="social_network_test.php" method="POST">
      <input type="hidden" name="action" value="addTopicFriend" />
      <label><b>Title</b></label>
      <input type="text" placeholder="Title" name="Title" id="Title" required>
      <label><b>Topic</b></label>
      <input type="text" placeholder="Topic" name="Topic" id="Topic" required>
      <label><b>Friends Email</b></label>
      <input type="text" placeholder="Freinds Email" name="Email" id="Email" required>
      <button type="submit">Add Topic to Friend </button>
    </form>
  </div>
</center>



<center>
  <div class="form-group">
    <form class="" action="social_network_test.php" method="POST">
      <input type="hidden" name="action" value="removeFriendTopic" />
      <label><b>Title</b></label>
      <input type="text" placeholder="Title" name="Title" id="Title" required>
      <label><b>Email</b></label>
      <input type="text" placeholder="Email" name="Email" id="Email" required>
      <button type="submit">Remove Topic Sent</button>
    </form>
  </div>
</center>

    <a href="social_network_index.html"><h2>Logout</h2></a>

  </body>
</html>

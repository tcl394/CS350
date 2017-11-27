var mongo = require('mongodb');
var MongoClient = require('mongodb').MongoClient;
var url = "mongodb://localhost/socialdb";


  function newUser(firstName, lastName, userName, password){

    MongoClient.connect(url, function(err, db) {
      if (err) throw err;
      var newUser = { firstName: firstName, lastName: lastName, userName: userName, password:password, friends:[]};
      db.collection("users").insertOne(newUser, function(err, res) {
        if (err) throw err;
        console.log("1 user created");
        db.close();
      });
    });

  }

  function displayUsers(){

    MongoClient.connect(url, function(err, db) {
    if (err) throw err;
    db.collection("users").find({}).toArray(function(err, result) {
      if (err) throw err;
      console.log(result);
      db.close();
    });
  });

  }

  function displayPosts(){

    MongoClient.connect(url, function(err, db) {
    if (err) throw err;
    db.collection("posts").find({}).toArray(function(err, result) {
      if (err) throw err;
      console.log(result);
      db.close();
    });
  });

  }

  function userLogin(username, password){

    MongoClient.connect(url, function(err, db) {
    db.collection("users").findOne({userName: username, password: password}, function(err, user){
          if(err) {
              console.log(err);
          }
          else if(user){
              console.log('Login success!');
          }
          else {
              console.log('Invalid login.');
          }
          db.close();
      });

    });

  }

  function addFriend (username1, username2){

    MongoClient.connect(url, function(err, db) {
    if (err) throw err;
    var query = { userName: username1};
    var friendID = {$addToSet: {friends: username2}};
    db.collection("users").updateOne(query, friendID, function(err, res) {
      if (err) throw err;
      console.log("success - friendship added");
      db.close();
    });
  });

    MongoClient.connect(url, function(err, db) {
    if (err) throw err;
    var query = { userName: username2};
    var friendID = {$addToSet: {friends: username1}};
    db.collection("users").updateOne(query, friendID, function(err, res) {
      if (err) throw err;
      console.log("success - friendship added");
      db.close();
    });
    });

  }


  function removeFriendship(username1, username2){

    MongoClient.connect(url, function(err, db) {
    if (err) throw err;
    var query = { userName: username1};
    var friendID = {$pull: {friends: username2}};
    db.collection("users").updateOne(query, friendID, function(err, res) {
      if (err) throw err;
      console.log("success - removal of friendship");
      db.close();
    });
  });

    MongoClient.connect(url, function(err, db) {
    if (err) throw err;
    var query = { userName: username2};
    var friendID = {$pull: {friends: username1}};
    db.collection("users").updateOne(query, friendID, function(err, res) {
      if (err) throw err;
      console.log("success - removal of friendship");
      db.close();
    });
    });



  }

  function returnFriends(username){

    MongoClient.connect(url, function(err, db) {
    if (err) throw err;
    db.collection("users").find({ userName: username },{ friends: 1 } ).toArray(function(err, result) {
      if (err) throw err;
      console.log(result);
      db.close();
    });
  });


}






  function listTopics(username){

    MongoClient.connect(url, function(err, db) {
    if (err) throw err;
    db.collection("posts").find({ userName: username },{ topics: 1 } ).toArray(function(err, result) {
      if (err) throw err;
      console.log(result);
      db.close();
    });
  });


  }

  function addTopic(username, topic){

    MongoClient.connect(url, function(err, db) {
    if (err) throw err;
    var query = { userName: username};
    var addTopic = {$addToSet: {topics: topic}};
    db.collection("users").updateOne(query, addTopic, function(err, res) {
      if (err) throw err;
      console.log("success - topic added");
      db.close();
    });
  });


  }

  function newPost(username){

    MongoClient.connect(url, function(err, db) {
      if (err) throw err;
      var newPost = { userName: username, topics:['birdwatching', 'friendship', 'marriage', 'religion']};
      db.collection("posts").insertOne(newPost, function(err, res) {
        if (err) throw err;
        console.log("1 post created");
        db.close();
      });
    });

  }

  function removeTopic(username, topic){

    MongoClient.connect(url, function(err, db) {
    if (err) throw err;
    var query = { userName: username};
    var topicToRemove = {$pull: { topics: topic }};
    db.collection("posts").updateOne(query, topicToRemove, function(err, res) {
      if (err) throw err;
      console.log("success - removal of topic");
      db.close();
    });
  });



};

  function resetData(){

    dropConnections();
    createUserCollection();
    createPostCollection();

    function dropConnections(){

      MongoClient.connect(url, function(err, db) {
        if (err) throw err;
        db.collection("posts").drop(function(err, delOK) {
          if (err) throw err;
          if (delOK) console.log("Collection deleted");
          db.close();
        });
      });

      MongoClient.connect(url, function(err, db) {
        if (err) throw err;
        db.collection("users").drop(function(err, delOK) {
          if (err) throw err;
          if (delOK) console.log("Collection deleted");
          db.close();
        });
      });
    }


    function createUserCollection(){

      MongoClient.connect(url, function(err, db) {
        if (err) throw err;
        db.createCollection("users", function(err, res) {
          if (err) throw err;
          console.log("Collection created!");
          db.close();
        });
      });

    }

    function createPostCollection(){

      MongoClient.connect(url, function(err, db) {
        if (err) throw err;
        db.createCollection("posts", function(err, res) {
          if (err) throw err;
          console.log("Collection created!");
          db.close();
        });
      });

    }

  }



////TEST FUNCTIONS START HERE



function testAll(){
  test_newUser('Billy', 'Bob', 'billyBob', 'samPass');
  test_userLogin('samBob', 'samPass');
  test_addFriend('billBob', 'samPass');
  test_removeFriendship('hannah555', 'samPass');
  test_returnFriends('hannah555');
  test_newPost('hannah555');
  test_addTopic ('hannah555', 'literature');
  test_removeTopic('hannah555', 'birdwatching');
  test_listTopics('hannah555');
  //test_resetData();

}


function test_newUser(firstName, lastName, userName, password){

  newUser(firstName, lastName, userName, password);

  MongoClient.connect(url, function(err, db) {
  db.collection("users").findOne({firstName: firstName, lastName: lastName, userName: userName, password: password}, function(err, user){
        if(err) {
            console.log(err);
        }
        else if(user){
            console.log('User exists.');
        }
        else {
            console.log('Cannot find user.');
        }
        db.close();
    });

  });

}

function test_userLogin(firstname, lastname, username, password){

  newUser(firstname, lastname, username, password);

  userLogin(username, password);


}

function test_addFriend(username1, username2){

  addFriend(username1, username2);

  MongoClient.connect(url, function(err, db) {
  if (err) throw err;
  db.collection("users").find({user: username1, friends: username2}, function(err, result) {
    if (err) throw err;
    console.log(result.name);
    db.close();
  });
  });

  MongoClient.connect(url, function(err, db) {
  if (err) throw err;
  db.collection("users").find({user: username2, friends: username1}, function(err, result) {
    if (err) throw err;
    console.log(result.name);
    db.close();
  });
  });


}

function test_removeFriendship(username1, username2){

  removeFriendship(username1, username2);

  MongoClient.connect(url, function(err, db) {
  if (err) throw err;
  db.collection("users").find({user: username1, friends: username2}, function(err, result) {
    if (err) throw err;
    console.log('Friendship removal successful.');
    db.close();
  });
  });

  MongoClient.connect(url, function(err, db) {
  if (err) throw err;
  db.collection("users").find({user: username2, friends: username1}, function(err, result) {
    if (err) throw err;
    console.log('Friendship removal successful.');
    db.close();
  });
  });

}


function test_returnFriends(username){

  returnFriends(username);
}

function test_listTopics(username){
  listTopics(username);
}

function test_addTopic(username, topic){
  addTopic(username, topic);

  MongoClient.connect(url, function(err, db) {
  if (err) throw err;
  db.collection("users").find({userName: username, topics: topic}, function(err, result) {
    if (err) throw err;
    console.log('Topic not added - test fail.');
    db.close();
  });
  });

}

function test_newPost(userName){

  newPost(userName);

  MongoClient.connect(url, function(err, db) {
  db.collection("posts").find({userName: userName}, function(err, result) {
    if (err) throw err;
    console.log('Topic removed - test pass');
    db.close();
  });
  });
  }

function test_removeTopic(username, topic){

  removeTopic(username, topic);

  MongoClient.connect(url, function(err, db) {
  if (err) throw err;
  db.collection("users").find({user: username, topics: topic}, function(err, result) {
    if (err) throw err;
    console.log('Topic removed - test pass');
    db.close();
  });
  });
}

function test_resetData(){

  resetData();

  MongoClient.connect(url, function(err, db) {
  db.collectionNames('users', function(err, names) {
    console.log('Exists: ', names.length > 0);
    });
    });

}

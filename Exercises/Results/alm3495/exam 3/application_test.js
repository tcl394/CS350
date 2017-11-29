var mongoDB = require('./mongo/mongodb.js');
var user_model = require('./mongo/user_model.js');
var post_model = require('./mongo/post_model.js');
var user = require('./objects/user.js');


//test to create a new user:

function test_create_user(first, last, password, email){
    console.log("Testing user creation");
    user_model.create_user(first, last, password, email);

}

function test_create_post(creator_id, title, body){ 
    console.log("Testing post creation");
    post_model.create_post(creator_id, title, body);

}


//test to create a new friendship between two users
function test_create_friendship(user_id_one, user_id_two){
    user_model.create_friendship(user_id_one, user_id_two);
}

var nick = new user('nick', 'alm', 'pass', 'test@test.com');

console.log(nick.get_last_name());

// RUN ALL TESTS:
function test_all(){
  test_create_post("5a13493450c4400509b8c638","first Post","Here is the body - Test");
  test_create_friendship("5a13493450c4400509b8c638", "5a1349cf40dad8051baae596");
  test_create_user("nick", "alm", "testpassword123", "test@test.com");
  test_create_friendship("5a1349cf40dad8051baae596", "5a13493450c4400509b8c638");
}
test_all();

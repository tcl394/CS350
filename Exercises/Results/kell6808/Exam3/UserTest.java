package com;
import org.junit.Assert;
import org.junit.Test;

/**
 * Created by Michael on 11/24/2017.
 */
public class UserTest {

    @Test
    public void userTestGetId(){
        User user = new User(0, "Michael");
        Assert.assertEquals(0, user.getId());
    }
    @Test
    public void userTestLogIn(){
        User user = new User(0, "Michael");
        Assert.assertEquals("Michael", user.getName());
    }
    @Test
    public void userTestGetAllUsers(){
        SystemManager systemManager = new SystemManager();
        systemManager.createUser("Michael");
        systemManager.createUser("Mark");
        String users =systemManager.listAllUsers();
        System.out.println(users);
    }
    @Test
    public  void userTestAbilityToAddFriends(){
        SystemManager systemManager= new SystemManager();
        systemManager.createUser("Michael");
        systemManager.createUser("Mark");
        User tempUser1 = systemManager.getUser(0);
        User tempUser2 = systemManager.getUser(1);
        Friends friends = tempUser1.getFriends();
        friends.addfriend(tempUser2);
        String names = "";
        for(User friend: tempUser1.getFriends().getFriendsList()){
            if (names.equals("")){
                names = friend.getName();
            }
            else {
                names = names+ ", " + friend.getName();
            }
        }
        System.out.println(names);
    }
    @Test
    public void userTestAllFriends(){
        SystemManager systemManager= new SystemManager();
        systemManager.createUser("Michael");
        systemManager.createUser("Mark");
        User tempUser1 = systemManager.getUser(0);
        User tempUser2 = systemManager.getUser(1);
        Friends friends = tempUser1.getFriends();
        friends.addfriend(tempUser2);

        String names = "";
        for(User friend: tempUser1.getFriends().getFriendsList()){
            if (names.equals("")){
                names = friend.getName();
            }
            else {
                names = names+ ", " + friend.getName();
            }
        }
        Assert.assertEquals("Mark",names);
    }
    @Test
    public  void userTestAbilityToDeleteFriends(){
        SystemManager systemManager= new SystemManager();
        systemManager.createUser("Michael");
        systemManager.createUser("Mark");
        User tempUser1 = systemManager.getUser(0);
        User tempUser2 = systemManager.getUser(1);
        Friends friends = tempUser1.getFriends();
        friends.addfriend(tempUser2);
        friends.removeFriend(1);
        String names = "";
        for(User friend: tempUser1.getFriends().getFriendsList()){
            if (names.equals("")){
                names = friend.getName();
            }
            else {
                names = names+ ", " + friend.getName();
            }
        }
        Assert.assertEquals("",names);
    }
    @Test
    public void userTestMakeAPost(){
        SystemManager systemManager= new SystemManager();
        systemManager.createUser("Michael");
        User tempUser1 = systemManager.getUser(0);
        tempUser1.addPost("New Post Title", "Hello World");
        Assert.assertEquals(1,tempUser1.getPosts().size());

    }
    @Test
    public void userTestCanDeleteAPost(){
        SystemManager systemManager= new SystemManager();
        systemManager.createUser("Michael");
        User tempUser1 = systemManager.getUser(0);
        tempUser1.addPost("New Post Title", "Hello World");
        tempUser1.addPost("A Brave new World", "Hello new world");
        tempUser1.getPosts().remove("New Post Title");
        Assert.assertEquals(1,tempUser1.getPosts().size());

    }
    @Test
    public void userTestCanPostToAFriendsPosts(){
        SystemManager systemManager= new SystemManager();
        systemManager.createUser("Michael");
        systemManager.createUser("Mark");
        User tempUser1 = systemManager.getUser(0);
        User tempUser2 = systemManager.getUser(1);
        Friends friends = tempUser1.getFriends();
        friends.addfriend(tempUser2);
        tempUser1.addPost(0,"New Post Title", "Hello World" );
        Assert.assertEquals(1,tempUser1.getPosts().size());

    }
    @Test
    public void userTestCanListPostsByTitle(){
        SystemManager systemManager= new SystemManager();
        systemManager.createUser("Michael");
        User tempUser1 = systemManager.getUser(0);
        tempUser1.addPost("New Post Title", "Hello World");
        tempUser1.addPost("A Brave new World", "Hello new world");
        String titles = "";
        for(Post tester: tempUser1.getPosts().values()){
            if (titles.equals("")){
                titles = tester.getTitel();
            }
            else {
                titles = titles+ ", " + tester.getTitel();
            }
        }
        System.out.println(titles);
    }
    @Test
    public void testAbilityToDeleteAllInformation(){
        SystemManager systemManager= new SystemManager();
        systemManager.createUser("Michael");
        systemManager.createUser("Mark");
        User tempUser1 = systemManager.getUser(0);
        User tempUser2 = systemManager.getUser(1);
        tempUser1.addPost("New Post Title", "Hello World");
        tempUser2.addPost("A Brave new World", "Hello new world");
        systemManager.resetAllInforantion();
        String users =systemManager.listAllUsers();
        System.out.println(users);

    }
    @Test
    public void testAbilityToAccessTheOptionsMenu(){
        SystemManager systemManager = new SystemManager();
        systemManager.printOptions();

    }
    @Test
    public void userTestRegisterUserInputForCasesOutsideTheNorm(){
        SystemManager systemManager= new SystemManager();
        systemManager.createUser("Michael");
        systemManager.createUser("Mark");
        User tempUser1 = systemManager.getUser(0);
        User tempUser2 = systemManager.getUser(1);
        Friends friends = tempUser1.getFriends();
        friends.addfriend(tempUser2);
        tempUser1.addPost("New Post Title", "Hello World");
        tempUser2.addPost("A Brave new World", "Hello new world");
        systemManager.registerUserInput(14);

    }
    @Test
    public void userTestExport(){
        System.out.println("Needs implementation");
    }
    @Test
    public void userTestImport(){
        System.out.println("Needs implementation");
    }

}

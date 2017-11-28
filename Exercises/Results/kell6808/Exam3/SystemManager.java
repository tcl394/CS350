package com;
import java.util.HashMap;
import java.util.Map;
import java.util.Scanner;

/**
 * Created by Michael on 11/24/2017.
 */
public class SystemManager {
    private int getLastUserId =0;
    private Map<Integer, User> allUsers = new HashMap<>();
    private int loggedInUserId = -1;

    public User createUser(String name){
        int newUserId = getLastUserId++;
        User newUser = new User(newUserId, name);
        allUsers.put(newUserId, newUser);

        return newUser;
    }

    public void importData (String fileName){

    }

    public void exportData (String fileName) {

    }

    public void registerUserInput(int userChoice){
        Scanner keyboard = new Scanner(System.in);

        switch (userChoice){
            case 0:
                System.out.println("Enter your name to register for an account");
                String NameOfNewUser = keyboard.next();
                createUser(NameOfNewUser);
                break;
            case 1:
                System.out.println("enter your name to log in");
                String NameOfUserLoggingIn = keyboard.next();
                loginUser(NameOfUserLoggingIn);
                break;
            case 2:
                System.out.println("enter the id of the user whos friendslist you would like to see");
                int userIdToSeeFriendsList = keyboard.nextInt();
                getUserFriends(userIdToSeeFriendsList);
                break;
            case 3:
                this.listAllUsers();
                break;
            case 4:
                System.out.println("enter the Id of the person you would like to add");
                int userToAddToFriendsList = keyboard.nextInt();
                addFriend(loggedInUserId,userToAddToFriendsList);
                break;
            case 5:
                System.out.println("enter the Id of the friend you would like to remove");
                int idOfFriendToRemove = keyboard.nextInt();
                removeFriend(loggedInUserId,idOfFriendToRemove);
                break;
            case 6:
                System.out.println("enter the Id of the user who's posts you would like to ");
                int idOfUserToCheckAllPosts = keyboard.nextInt();
                getUserPosts(idOfUserToCheckAllPosts);
                break;
            case 7:
                System.out.println("What is the title of your new post? ");
                String titelOfNewPost = keyboard.next();
                System.out.println("enter the body of the post you would like to make");
                String bodyOfNewPost = keyboard.next();
                createNewPost(loggedInUserId, titelOfNewPost, bodyOfNewPost);
                break;
            case 8:
                System.out.println("What is the id of the user you would like to post to?");
                int IdOfUserBeingPostedTo = keyboard.nextInt();
                System.out.println("Enter the title of the post you would like to make to user "+ IdOfUserBeingPostedTo+
                        ".");
                String titleOfPostToAnotherUser = keyboard.next();
                System.out.println("enter the body of the post you you would like to make the user "+
                        IdOfUserBeingPostedTo+ ".");
                String bodyOfPost = keyboard.next();
                oneUserPostToAnotherUser(loggedInUserId, IdOfUserBeingPostedTo,titleOfPostToAnotherUser,bodyOfPost);
                break;
            case 9:
                System.out.println("What is the title of the post you want to delete? ");
                String title = keyboard.next();
                deleatePost(loggedInUserId, title);
                break;
            case 10:
                //this.exportData();
                break;
            case 11:
                // this.importData();
                break;
            case 12:
                this.resetAllInforantion();
                break;
            case 13:
                this.printOptions();
                break;
            default:
                System.err.println(userChoice+" is not an option in the options menu");
                printOptions();
                break;

        }

    }

    public void printOptions(){

        System.out.println("Here are the following options you can perform");
        System.out.println("0-- Register for an account" +
                "\n 1-- Sign in "+
                "\n 2-- List all friends by id " +
                "\n 3-- list all users"+
                "\n 4-- add friend by id " +
                "\n 5-- un-friend a friend by id " +
                "\n 6-- list all posts by id" +
                "\n 7-- Make a new post" +
                "\n 8-- post to a friends posts " +
                "\n 9-- delete posts" +
                "\n 10-- export all data" +
                "\n 11-- import all data" +
                "\n 12-- wipe all data."+
                "\n 13-- Print options");

    }
    public User getUser (int id){
        return allUsers.get(id);
    }

    public Map<String,Post> getUserPosts(int id){
        return allUsers.get(id).getPosts();
    }

    public Friends getUserFriends(int id){
        return allUsers.get(id).getFriends();

    }
    public boolean removeFriend(int loggedInUserID, int friendID){
        User loggedInUser = allUsers.get(loggedInUserID);
        return loggedInUser.getFriends().removeFriend(friendID);
    }
    public boolean addFriend(int loggedInUserID, int newFriendId){
        User loggedInUser = allUsers.get(loggedInUserID);
        if(allUsers.keySet().contains(newFriendId)) {
            User friend = allUsers.get(newFriendId);
            return loggedInUser.getFriends().addfriend(friend);
        }
        return false;
    }
    public String listAllUsers (){
        String names = "";
        for(int userId : allUsers.keySet()){
            if (names.equals("")){
                names = allUsers.get(userId).getName();
            }
            else {
                names = names+ ", " + allUsers.get(userId).getName();
            }
        }

        return names;
    }

    public boolean loginUser(String userName){
        for (int id: allUsers.keySet()) {
            if (userName.equals(allUsers.get(id).getName())) {
                return true;

            }

        }
        return false;
    }

    public boolean createNewPost(int loggedInUserId, String title, String text){
        User loggedInUser = allUsers.get(loggedInUserId);
        loggedInUser.addPost(title, text);
        return true;
    }

    public boolean oneUserPostToAnotherUser(int loggedInUserId, int targetUserId, String title, String text){
        User targetUser = allUsers.get(targetUserId);
        targetUser.addPost(loggedInUserId, title,text);
        return true;
    }

    public boolean deleatePost(int loggedinUderId, String title){
        User loggedInUser=allUsers.get(loggedinUderId);
        if( loggedInUser.getPosts().containsKey(title)) {
            loggedInUser.getPosts().remove(title);
            return true;
        }
        return false;
    }

    public void resetAllInforantion(){
        allUsers = new HashMap<>();
        getLastUserId = 0;
    }

    public static void main(String[] args) {
        SystemManager systemManager = new SystemManager();
        systemManager.printOptions();

        Scanner keyboard = new Scanner(System.in);
        int nextInputOnCommandLine = keyboard.nextInt();
        systemManager.registerUserInput(nextInputOnCommandLine);
    }

}


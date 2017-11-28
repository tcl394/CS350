package com;

import java.util.ArrayList;
import java.util.List;

/**
 * Created by Michael on 11/24/2017.
 */
public class Friends {
    private List<User> friendsList = new ArrayList<>();

    public Friends(List<User> friendsList) {
        this.friendsList = friendsList;
    }

    public Friends() {

    }

    public List<User> getFriendsList() {
        return friendsList;
    }

    public void setFriendsList(List<User> friendsList) {
        this.friendsList = friendsList;
    }
    public boolean removeFriend (int id){
        for(User friend: friendsList){
            if(id == friend.getId()){
                friendsList.remove(friend);
                return true;

            }
        }
        return false;
    }
    public boolean addfriend (User friend){
        if (friendsList.contains(friend)){
            return false;
        }
        else{
            friendsList.add(friend);
            return true;
        }
    }


}

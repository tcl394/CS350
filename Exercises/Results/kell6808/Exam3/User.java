package com;

import java.util.HashMap;
import java.util.Map;

/**
 * Created by Michael on 11/24/2017.
 */
public class User {
    private int id;
    private String name;
    private Map<String , Post> posts = new HashMap<>();
    private Friends friends = new Friends();

    public User(int id, String name) {
        this.id = id;
        this.name = name;
    }

    public Map<String, Post> getPosts() {
        return posts;
    }

    public void setPosts(Map<String, Post> posts) {
        this.posts = posts;
    }

    public Friends getFriends() {
        return friends;
    }

    public void setFriends(Friends friends) {
        this.friends = friends;
    }

    public String getName() {
        return name;
    }

    public int getId() {
        return id;
    }

    public void addPost(String title, String text){
        addPost(this.id, title, text);
    }

    public void addPost(int authorId, String title, String text){
        Post post  = new Post(authorId, title, text);
        posts.put(title, post);
    }

    //A user can register to use the system
    //After login the user ID is used for all other calls

}

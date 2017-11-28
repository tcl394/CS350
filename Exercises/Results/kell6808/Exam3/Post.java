package com;

/**
 * Created by Michael on 11/24/2017.
 */
public class Post {
    private int authorId;
    private String titel;
    private String text;


    public Post(int authorId, String titel, String text) {
        this.authorId = authorId;
        this.titel = titel;
        this.text = text;
    }
    public String getText() {
        return text;
    }

    public void setText(String text) {
        this.text = text;
    }

    public String getTitel() {
        return titel;
    }

    public void setTitel(String titel) {
        this.titel = titel;
    }

    public int getAuthorId() {
        return authorId;
    }

    public void setAuthorId(int authorId) {
        this.authorId = authorId;
    }


}

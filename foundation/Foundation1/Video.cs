using System;

public class Video
{
    private string _title;
    private string _creator;
    private int _length;

    private List<Video> _video;

    private List<Comment> _comments;
    
    public Video
    {

    }

    public int CommentsCounter(_comments)
    {
        int numberOfComments = _comments.count();
        return numberOfComments;
    }
    
}
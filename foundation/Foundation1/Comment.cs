using System;

public class Comment
{
    public string _personName;
    public string _commentText;


    public Comment(string commenter, string text)
    {
        _personName = commenter;
        _commentText = text;
    }

    public string GetPersonName()
    {
        return _personName;
    }

    public string GetCommentText()
    {
        return _commentText;
    }
} 
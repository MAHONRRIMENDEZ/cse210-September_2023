using System;
using System.Collections;
public class Comments
{
    private string _name; // comment's author
    private string _commentText;
    

    //public void AddComment(string name, string commentText);
    
    public string GetName()
    {
        return _name;
    }
    public void SetName(string name)
    {
        _name = name;
    }
    public string GetCommentText()
    {
        return _commentText;
    }
    public void SetCommentText(string commentText)
    {
        _commentText = commentText;
    }

    public void Display()
    {
        Console.WriteLine($"{_name} - has commented: {_commentText} ");
    }


}

using System;
using System.Collections;
public class Video
{
    private string _title;
    private string _author;
    private int _length;
    public List<Comments> _comments = new List<Comments>();
    public void AddComment(Comments newComment)
    {
        //_comments.Add(newName);
        _comments.Add(newComment);
    }
    public void DisplayAllComments()
    {
        foreach (Comments comment in _comments)
        {
            comment.Display();
        }
    }
    public int NumberOfComments()
    {
        return _comments.Count();
    }



    public string GetTitle()
    {
        return _title;
    }
    public void SetTitle(string title)
    {
        _title = title;
    }

    public string GetAuthor()
    {
        return _author;
    }
    public void SetAuthor(string author)
    {
        _author = author;
    }
    public int GetLength()
    {
        return _length;
    }
    public void SetLength(int length)
    {
        _length = length;
    }

    public void AddComents(string name, string text)
    {
        Comments comment = new Comments();
        comment.SetName(name);
        comment.SetCommentText(text);
        _comments.Add(comment);
    }

    
    public void DisplayVideo()
    {
        
        
        Console.WriteLine($"Title: {_title} - by {_author}.");
        Console.WriteLine($"Duration in seconds {_length}.");

        foreach(Comments comment in _comments){
            comment.Display();
        }
        Console.WriteLine($"The total of comments for this vide is {_comments.Count}.");

        
        

    }
}
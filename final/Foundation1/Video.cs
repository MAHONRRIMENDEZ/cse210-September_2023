using System;
using System.Collections;
public class Video
{
    private string _title;
    private string _author;
    private int _length;
    public List<Comments> _comments = new List<Comments>();
    public List<Video> _videos = new List<Video>();
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

    public void AddVideo(Video video)
    {
        // adding videos to the list of videos
        _videos.Add(video);
    }
    public void DisplayAllVideos()
    {
        foreach (Video video in _videos)
        {
            Console.WriteLine($"Title: {_title} - by {_author}");
            Console.WriteLine($"Duration in seconds {_length}");
        }

    }
}
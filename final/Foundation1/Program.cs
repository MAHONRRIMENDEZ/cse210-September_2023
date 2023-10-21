using System;

class Program
{
    

    static void Main(string[] args)
    
    {
        
        List<Video> _videos = new List<Video>();

        
        /*
            
            Video v1 = new Video();
            v1.SetTitle("Video 1");
            v1.SetAuthor("Author 1");
            v1.SetLength(240);
            v1.AddComents("Mendez", "I liked the video");
            v1.AddComents("Mahonnri", "Cool video bro");
            _videos.Add(v1)
        */

        // First Video
        Video v1 = new Video();
        v1.SetTitle("Video 1");
        v1.SetAuthor("Author 1");
        v1.SetLength(240);
        //First Video's comments
        v1.AddComents("Mendez", "I liked the video");
        v1.AddComents("Mahonnri", "Cool video bro");
        v1.AddComents("pepito", "I don't like the video");
        _videos.Add(v1);

        
        ///Second video
        Video v2 = new Video(); 
        v2.SetTitle("Video 2");
        v2.SetAuthor("Author 2");
        v2.SetLength(440);
        //Second Video's comments
        v2.AddComents("", "");
        v2.AddComents("", "");
        v2.AddComents("", "");
        v2.AddComents("", "");
        _videos.Add(v2);

        //3rd Video
        Video v3 = new Video();
        v3.SetTitle("Video 3");
        v3.SetAuthor("Author 3");
        v3.SetLength(640);
        //3rd Video's comments
        v3.AddComents("", "");
        v3.AddComents("", "");
        v3.AddComents("", "");
        v3.AddComents("", "");
        _videos.Add(v3);
    
        //4th Video
        Video v4 = new Video();
        v4.SetTitle("Video 4");
        v4.SetAuthor("Author 4");
        v4.SetLength(840);
        //4th Video's comments
        v4.AddComents("", "");
        v4.AddComents("", "");
        v4.AddComents("", "");
        v4.AddComents("", "");
        _videos.Add(v4); 

        foreach (Video video in _videos)
        { 
            video.DisplayVideo();

        }
        /*v1.DisplayAllVideos();
        v1.DisplayAllComments();
        Console.WriteLine($"The total of comments for this vide is {v1.NumberOfComments()}");
        
        v2.DisplayAllVideos();
        v2.DisplayAllComments();
        Console.WriteLine($"The total of comments for this video is {v2.NumberOfComments()}");

        v3.DisplayAllVideos();
        v3.DisplayAllComments();
        Console.WriteLine($"The total of comments for this video is {v3.NumberOfComments()}");

        v4.DisplayAllVideos();
        v4.DisplayAllComments();
        Console.WriteLine($"The total of comments for this video is {v4.NumberOfComments()}");
        */
    }
    
}
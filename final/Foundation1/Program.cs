using System;

class Program
{
    

    static void Main(string[] args)
    
    {
        
        
        // First Video
        Video v1 = new Video();
        v1.SetTitle("Video 1");
        v1.SetAuthor("Author 1");
        v1.SetLength(240);
        v1.AddVideo(v1);

        //First Video's comments
        Comments c1 = new Comments();
        c1.SetName("guy 1");
        c1.SetCommentText("I like this video");
        v1.AddComment(c1);
        Comments c2 = new Comments();
        c2.SetName("guy 2");
        c2.SetCommentText("I like this video too");
        v1.AddComment(c2);
        

        ///Second video
        Video v2 = new Video(); 
        v2.SetTitle("Video 2");
        v2.SetAuthor("Author 2");
        v2.SetLength(440);
        v2.AddVideo(v2);

        //Second Video's comments
        Comments c3 = new Comments();
        c3.SetName("guy 1");
        c3.SetCommentText("I don't like this video");
        v2.AddComment(c3);
        Comments c4 = new Comments();
        c4.SetName("guy 2");
        c4.SetCommentText("I'm sharing this video");
        v2.AddComment(c4);


        //3rd Video
        Video v3 = new Video();
        v3.SetTitle("Video 3");
        v3.SetAuthor("Author 3");
        v3.SetLength(640);
        v3.AddVideo(v3);

        //3rd Video's comments
        Comments c5 = new Comments();
        c5.SetName("guy 1");
        c5.SetCommentText("I Prefer Mr beast's videos");
        v3.AddComment(c5);
        Comments c6 = new Comments();
        c6.SetName("guy 2");
        c6.SetCommentText("PewDeePie is better");
        v3.AddComment(c6);

        //4th Video
        Video v4 = new Video();
        v4.SetTitle("Video 4");
        v4.SetAuthor("Author 4");
        v4.SetLength(840);
        v4.AddVideo(v4);
        //4th Video's comments

        Comments c7 = new Comments();
        c7.SetName("guy 1");
        c7.SetCommentText("I don't understand this video");
        v4.AddComment(c7);
        Comments c8 = new Comments();
        c8.SetName("guy 2");
        c8.SetCommentText("it's confusing");
        v4.AddComment(c8);
        
        v1.DisplayAllVideos();
        v1.DisplayAllComments();
        Console.WriteLine($"The total of comments for this vide is {v1.NumberOfComments()}");
        
        v2.DisplayAllVideos();
        v2.DisplayAllComments();
        Console.WriteLine($"The total of comments for this video is {v1.NumberOfComments()}");

        v3.DisplayAllVideos();
        v3.DisplayAllComments();
        Console.WriteLine($"The total of comments for this video is {v1.NumberOfComments()}");

        v4.DisplayAllVideos();
        v4.DisplayAllComments();
        Console.WriteLine($"The total of comments for this video is {v1.NumberOfComments()}");
    }
    
}
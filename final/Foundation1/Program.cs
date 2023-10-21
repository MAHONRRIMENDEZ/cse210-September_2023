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
        v1.SetTitle("How to program with classes");
        v1.SetAuthor("Mahonrri Mendez");
        v1.SetLength(240);
        //First Video's comments
        v1.AddComents("Mahonrri Mendez", "I liked the video");
        v1.AddComents("Jared Mendez", "Cool video bro");
        v1.AddComents("Pepito Mendoza", "I don't like the video");
        _videos.Add(v1);

        
        ///Second video
        Video v2 = new Video(); 
        v2.SetTitle("Get ready with me for a weeding");
        v2.SetAuthor("Maria lupita");
        v2.SetLength(440);
        //Second Video's comments
        v2.AddComents("Valeria Mendoza", "I would prefer make up videos");
        v2.AddComents("Valentina Lara", "I think is better if you just make better videos");
        v2.AddComents(" Leonela Chura", "I don't think we can aford that product");
        v2.AddComents("Abish Mendez", "I love this king of videos");
        _videos.Add(v2);

        //3rd Video
        Video v3 = new Video();
        v3.SetTitle("The best shampoo ever");
        v3.SetAuthor("Yuya");
        v3.SetLength(640);
        //3rd Video's comments
        v3.AddComents("Marlon Wyans", "I want more info please");
        v3.AddComents("Aracely Dominguez", "This is the best product so far");
        v3.AddComents("Eugenio Dervez", "We can't wait for the next version");
        v3.AddComents("Vadir Dervez", "I will buy this product for my wife");
        _videos.Add(v3);
    
        //4th Video
        Video v4 = new Video();
        v4.SetTitle("Minecraft Gameplay");
        v4.SetAuthor("Juan Guarnizo");
        v4.SetLength(840);
        //4th Video's comments
        v4.AddComents("Ludovico Peluche", "is there any spanish Version?");
        v4.AddComents("Juan Fernandez", " I prefer pewdiepie's videos");
        v4.AddComents("Luis Flores", "Man STOP playing this game");
        v4.AddComents("Camilo Juaquin", "what a good video bro!");
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
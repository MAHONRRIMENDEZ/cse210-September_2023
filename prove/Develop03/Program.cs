using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Welcome to the Scripture memorizer");  
        Console.WriteLine("The Scripture of today is:");

        Reference R1 = new Reference("1 Nefi", 3, 7);
    
        Scripture S1 = new Scripture(R1, "Y sucedió que yo, Nefi, dije a mi padre: Iré y haré lo que el Señor ha mandado, porque sé que él nunca da mandamientos a los hijos de los hombres sin prepararles una vía para que cumplan lo que les ha mandado.");       

        string userComand = "";

        while (userComand != "quit")
        {
            S1.GetDisplayText();
            Console.WriteLine("Please use 'Enter' to Hide words and Write 'quit to finish");
        
            userComand = Console.ReadLine();
            if (userComand == "")
            {
                S1.HideRandomWords(1);
            }

            //if (S1.IsHidden == true)
            {

            }
            

        }
    }
}
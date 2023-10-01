using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Welcome to the Scripture memorizer");  
        Console.WriteLine("The Scripture of today is:");      
        Reference R1 = new Reference();
        R1.TheReference("1 Nefi", 3, 7);
        R1.GetDisplayText();

        Word S1 = new Word();
        S1.TheWord("Y sucedió que yo, Nefi, dije a mi padre: Iré y haré lo que el Señor ha mandado, porque sé que él nunca da mandamientos a los hijos de los hombres sin prepararles una vía para que cumplan lo que les ha mandado.");
        S1.GetDisplayText();


        Console.WriteLine("Please use 'Enter' to Hide words and Write 'quit to finish");
        
        string userComand = Console.ReadLine();

        while (userComand != "quit")
        {
            if (userComand == "")
            {
                S1.Hide();
            }

            //if (S1.IsHidden == true)
            {

            }
            

        }
    }
}
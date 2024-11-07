using System.IO;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //varibles
            int score = -430;
            string name = "AWWWWFFFUUULLLLLL";

            //Functions
            static int increaseScore(int num)
            {
                num = num + 1;
                return num;
            }

            static void ClearCurrentConsoleLine()
            {
                Console.SetCursorPosition(0, Console.CursorTop);
                Console.Write(new string(' ', Console.WindowWidth));
                Console.SetCursorPosition(0, Console.CursorTop - 1);
            }

            //---initalize
            score = 0;
            name = "";

            //Start____________________

            //input Name
            Console.WriteLine("Welcome, please enter your name.");
            name = Console.ReadLine();

            //Intsruct player to get points and/or leave
            Console.WriteLine($"Hello {name}. press any key to increase Score! Press 'Enter' to exit ");

            //code for getting score
            Console.WriteLine($"{name}'s Score: {score} ");

            ConsoleKeyInfo c = new ConsoleKeyInfo();
            do
            {

                ClearCurrentConsoleLine();
                Console.WriteLine($"{name}'s Score: {score} ");
                // inner loop to check whether a key 
                // is pressed using KeyAvailable 
                while (Console.KeyAvailable == false)

                    // Loop until input is entered.
                    Thread.Sleep(50);
                c = Console.ReadKey(true);
                score++;

            } while (c.Key != ConsoleKey.Enter);
             score--;
            //code for Exiting
            
            Console.WriteLine($"Wow Quite the Haul! You got a score of {score}! \nLets save this shall we?");

            string path = @"C:[username].txt"; 
            TextWriter tsw = new StreamWriter(@"C:[username].txt" , true);

            //Writing text to the file.
            tsw.WriteLine($"User: {name}");
            tsw.WriteLine($"Score: {score}");

            //Close the file.
            tsw.Close();

            //read the file
            string readText = File.ReadAllText(path);
            Console.WriteLine(readText);



        }
        
    }
}

using System;

namespace Justice
{
    class Program
    {
        static void Main(string[] args)
        {


            string title = @" _        _                          _    _                   _  _  _    _  _       
(_) _ _  | |_  ___  _ _  _ _   __ _ | |_ (_) ___  _ _   __ _ | |(_)| |_ | || |      
| || ' \ |  _|/ -_)| '_|| ' \ / _` ||  _|| |/ _ \| ' \ / _` || || ||  _| \_. |      
|_||_||_| \__|\___||_|  |_||_|\__/_| \__||_|\___/|_||_|\__/_||_||_| \__| |__/       

";
            Console.Write(title);



            string guess1;
            string answer1 = "Texas";
            int point = 0;

            Console.WriteLine("What state in america starts with T");
            Console.WriteLine("What is your guess?");
            guess1 = Console.ReadLine();
          
            if (guess1 == answer1)
            {
                Console.WriteLine("You are right");
                point++;
            }
            if (guess1 != answer1)
            {
                Console.WriteLine("You are wrong");
            }

            string guess2;
            string answer2 = "Ohio";

            Console.WriteLine("What state starts with O");
            Console.WriteLine("What is your guess?");
            guess2 = Console.ReadLine();

            if (guess2 == answer2)
            {
                Console.WriteLine("You are right");
                point++;
            }
            if (guess2!= answer2)
            {
                Console.WriteLine("You are wrong");
            }


            string guess3;
            string answer3 = "California";

            Console.WriteLine("What state starts with C");
            Console.WriteLine("What is your guess?");
            guess3= Console.ReadLine();

            if (guess3 == answer3)
            {
                Console.WriteLine("You are right");
                point++;
            }
            if (guess3 != answer3)
            {
                Console.WriteLine("You are wrong");
            }

            string guess4;
            string answer4 = "Pakistan";

            Console.WriteLine("What country starts with P and has the colour green in thier flag");
            Console.WriteLine("What is your guess?");
            guess4 = Console.ReadLine();

            if (guess4 == answer4)
            {
                Console.WriteLine("You are right");
                point++;
            }
            if (guess4 != answer4)
            {
                Console.WriteLine("You are wrong");
            }

            string guess5;
            string answer5 = "China";

            Console.WriteLine("What country has a red flag with golden stars");
            Console.WriteLine("What is your guess?");
            guess5 = Console.ReadLine();

            if (guess5 == answer5)
            {
                Console.WriteLine("You are right");
                point++;
            }
            if (guess5 != answer5)
            {
                Console.WriteLine("You are wrong");
            }

            Console.WriteLine("You win with {0} points", point);

            
                                                    






        }


    }
}

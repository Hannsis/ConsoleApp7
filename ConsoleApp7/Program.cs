using System;

namespace GameGenerator
{
    class Program
    {
        static void Main(string[] args)

        {


            Random Random = new Random(); //in charge of generating random numbers 
            bool incorrectGuess = true; //set to true, alltså är det felgissning.
            int max = 100;// en lek mellan 1 - 100
            int min = 1;
            int randomNum = Random.Next(min, max + 1);//plus ett pga annars blir det 99
            string responses;//den skippar 
            int tries = 1;


            Console.WriteLine("Roses are red and voilets are blue, here is a game made just for you.");
            Console.WriteLine("Guess the correct number and you will win, ");
            Console.WriteLine("Guess wrong ten times, you won't get a new chance to begin, ");
            Console.WriteLine("because you failed. ");


            while (incorrectGuess) // keep playing
            {
                Console.WriteLine("Guess a number: ");
                string guess = Console.ReadLine();


                int num = 0;
                bool wrongNumber = Int32.TryParse(guess, out num);//BroCode youtube - tryparse

                if (wrongNumber)
                {
                    Console.WriteLine("You guessed " + num);
                }

                else
                {
                    Console.WriteLine("Incorrect Value, please try again.");
                    continue;//jens hjälpte mig
                }

                if (num < randomNum)
                {
                    Console.WriteLine(num + " is too low");
                    Console.WriteLine("you have tried " + tries + " times");
                }

                else if (num > randomNum)//exception handling GiraffeAcademy youtube, tutorial 24
                {
                    Console.WriteLine(num + " is too high");
                    Console.WriteLine("you have tried " + tries + " times");
                }

                if (num == randomNum)

                {

                    Console.WriteLine("YOU WIN");
                    //  Console.WriteLine("You've guessed " + tries + " times");
                    Console.WriteLine("Do you wish to play again? Y/N");

                    responses = Console.ReadLine();
                    responses = responses.ToUpper();

                    if (responses == ("N"))
                    {
                        incorrectGuess = false;

                    }
                    else
                    {
                        //randomNum

                    }

                }

                tries++;
                if (tries == 11)
                {
                    Console.WriteLine("I'm sorry to say, you will have to pay. You have failed the mission, and Harley Quinn now has my permission.");
                    Console.WriteLine("To end you.");

                    break;


                }

            }
        }
    }
}

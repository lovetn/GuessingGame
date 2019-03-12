using System;

namespace GuessingGame
{
    class Program
    {
        static void Main(string[] args)
        {
            bool restartApp = true;

            while(restartApp){
            int guess = 0;
            Random rng = new Random();
            int rInt = rng.Next(0, 30); //for ints
            int range = 30;
            double rngDouble = rng.NextDouble()* range; //for doubles
            int guessAmount = 1;
            
            Console.WriteLine("Welcome to the guessing game. Your job is to guess a number between 0-30. If Right the game restarts else you keep tryying until you get it right.");
            Console.Write("Enter your guess (0-30)");
       

            // // Restart func
            // void restart()
            // {
            //     Console.WriteLine("If you would like to restart and try again type, 'retry', if you would like to exit type 'exit'");

            //     string end = Console.ReadLine();


            // }
       
            // GET STARTED
            while (guess != rInt) {

                guess = Convert.ToInt32(Console.ReadLine());


                if (guess < rInt && guess < 31 && guess > 0) {
                       Console.WriteLine("That's not it. Go Higher");
                       guessAmount++;
                }
                else if (guess > rInt && guess < 31 && guess > 0) {
                    Console.WriteLine("That's not it. Go Lower");
                    guessAmount++;
                       
                 }
                else if ( guess > 30 ){
                    Console.WriteLine("Your guess was higher than  30. Try again between 1 and 30");
                }
                else if ( guess < 1 ) {
                    Console.WriteLine("Your guess was lower than 1. Try again between 1 and 30");
                }
                else if (guess == rInt) {
                       Console.WriteLine("CORRECT! You guessed a number of {0} times.", guessAmount);
                       Console.WriteLine("(R)estart or (Q)uit");
                       if (Console.ReadLine() == "Q"){
                           restartApp = false;
                       }

                }
                else {
                       Console.WriteLine("I don't understand.");
                }
            }
                                                                    

            // END OF WHILE TRUE LOOP
            }
        
    }

}
}

 
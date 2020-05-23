/* Simran Ravichandran
 * April 16, 2020
 * DiceGame.cs
 * Purpose: This program is a dice game that randomly generates 2 dice. 
 *          The 2 dice that are randomly generated are added then divided by 2 to check if the value is even or odd.
 *          Each time the game is played it adds to the number of times the dice is thrown.
 *          At the end, the game asks if the user would like to play again or not.
 *          If the user wants to play again the game continues. 
 *          If the user does not, the number of times the game was played is printed and then the game ends.
 *          
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Major_Coding_Assignment_1
{
    class DiceGame
    {
        static int numOfTimesPlayed = 0; //this integer keeps track of the number of times a player plays the game
        public static void PlayGame() //This method plays the game in a do while loop. The game will play while the wantToPlay boolean is true
        {
            bool wantToPlay = true;
            do
            {
                //This sets the values for dice1 and dice2 from the rollDie method which randomly generates the values for each die
                int dice1 = rollDie();
                int dice2 = rollDie();

                //Prints the dice values to screen
                Console.WriteLine("Dice 1 = " + dice1);
                Console.WriteLine("Dice 2 = " + dice2);

                isEven(dice1, dice2); //prints the isEven method
                
                numOfTimesPlayed++; //increase the number of games played by one

                /* The keepPlaying method checks if the player wants to keep playing
                 * if they do this function will return true, and set the wantToPlay boolean to true again
                 * if they don't, it will return false and set the wantToPlay boolean to false
                */
                wantToPlay = keepPlaying(); 

            } while (wantToPlay);
           
        }

        //This method randomly generates the value between 1 and 6 for the dice
        public static int rollDie()
        {
            //Create new Random object.
            Random diceRandom = new Random();
            // Return the random number
            return diceRandom.Next(1, 7);
        }


        /* This method checks if the sum both both dice is even or not
         * If a number is divisible by 2 with the remainder 0 then the number is an Even number. 
         * If the number is not divisible by 2 then that number will be an Odd number.
         */
        public static void isEven(int d1, int d2)
        {
            if ((d1+d2)% 2 == 0) //checks if both dice added together are even
            {
                Console.Write("Evens are better than odds!");
                Console.ReadLine();
            }
            else //this means both dice added together are odd
            {
                Console.Write("Odds are still cool!");
                Console.ReadLine();
            }
        }

        //This method checks if the user wants to keep playing or not then returns this value as true or false
        public static bool keepPlaying()
        {
            Console.WriteLine();
            Console.WriteLine("Would you like to play again? Y/N"); //asks the user if they would like to play again
            char answer = Console.ReadKey().KeyChar; //takes in their answer as a char
            Console.ReadLine();
            if (answer == 'Y' || answer =='y') //if their answer was a Y or y keepPlaying returns true and will continue the game
            {
                //Console.ReadLine();
                return true;
            }
            else //this will end the game because the user typed anything other than y or Y
            {
                Console.WriteLine("The number of times the dice was thrown is: " + numOfTimesPlayed); //prints the number of times the game was played
                Console.WriteLine("Nice Game!");
                Console.WriteLine("Thank you for Playing!Come play again soon!");
                Console.ReadLine();
                return false;
            }
        }

        //The main calls the play game functions and makes the game excecute
        static void Main(string[] args)
        {
            Console.WriteLine("Hey! Welcome to Tina's Dice Game!");
            Console.WriteLine("Let's start!");
            PlayGame(); //method
        }
    }
}

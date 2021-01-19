using System;

namespace Lektion_9_rock_paper_scissors
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the wonderful game of Rock/Paper/Scissors!\n");
            Console.WriteLine("Rules: You choose between Rock, Paper or Scissors.");
            Console.WriteLine("The computer will randomly do the same.\n");
            Console.WriteLine("How you win: Rock wins Scissors, Paper wins Rock and Scissors wins Paper.");

            bool continuePlay = true;

            do
            {
                Choose:
                Console.WriteLine("\nChoose your hand!");
                Console.WriteLine("Rock [1]\nPaper [2]\nScissors [3]");
                int chosenNum = Convert.ToInt32(Console.ReadLine());

                string chosenHand;

                switch (chosenNum)
                {
                    case 1:
                    chosenHand = "Rock";
                    break;
                    case 2:
                    chosenHand = "Paper";
                    break;
                    case 3:
                    chosenHand = "Scissors";
                    break;
                    default:
                    Console.WriteLine("That was an invalid entry. Please try again.\n");
                    goto Choose;
                }
                Console.WriteLine("\nYour chosen hand is: " + chosenHand);
            } while (continuePlay == true);
        }
    }
}

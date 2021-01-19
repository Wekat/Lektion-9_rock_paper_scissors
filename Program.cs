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

                if (0 < chosenNum && chosenNum < 4) {
                    chosenHand = ChosenHand(chosenNum);
                } else {
                    Console.WriteLine("That was an invalid entry. Please try again.\n");
                    goto Choose;
                }

                Console.WriteLine("\nYour chosen hand is: " + chosenHand);

                Random numberGenerator = new Random();
                int computerNum = numberGenerator.Next(1,4); //randomly generate number between 1 and 3

                switch (computerNum)
                {
                    case 1:
                    Console.WriteLine("The computer's hand is: Rock");
                    break;
                    case 2:
                    Console.WriteLine("The computer's hand is: Paper");
                    break;
                    case 3:
                    Console.WriteLine("The computer's hand is: Scissors");
                    break;
                }

            } while (continuePlay == true);
        }
        static string ChosenHand(int number) {
            string chosenHand;
            switch (number)
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
                chosenHand = "Not defined";
                break;
            }
            return chosenHand;
        }
    }
}

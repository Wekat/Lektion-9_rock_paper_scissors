using System;

namespace Lektion_9_rock_paper_scissors
{
    class Program
    {
        static void Main(string[] args)
        {
            Introduction(); //function for introduction text

            bool continuePlay = true;

            do
            {
                Choose:
                Console.WriteLine("\nChoose your hand!");
                Console.WriteLine("Rock [1]\nPaper [2]\nScissors [3]");
                string selectionNumber = Console.ReadLine();
                int chosenNum;

                switch (selectionNumber)
                {
                    case "1":
                    chosenNum = Convert.ToInt32(selectionNumber);
                    break;

                    case "2":
                    chosenNum = Convert.ToInt32(selectionNumber);
                    break;

                    case "3":
                    chosenNum = Convert.ToInt32(selectionNumber);
                    break;
                    
                    default:
                    Console.WriteLine("That was an invalid entry. Please try again.\n");
                    goto Choose;
                }
                
                string chosenHand = ChosenHand(chosenNum); //assign the player a hand;

                /*if (0 < chosenNum && chosenNum < 4) {
                    chosenHand = ChosenHand(chosenNum); //assign the player a hand
                }*/

                Console.WriteLine("\nYour chosen hand is: " + chosenHand);

                Random numberGenerator = new Random();
                int computerNum = numberGenerator.Next(1,4); //randomly generate number between 1 and 3

                string computerHand = ChosenHand(computerNum); //assign the coputer a hand

                Console.WriteLine("The computer's hand is: " + computerHand);

                if (chosenNum == computerNum + 1 || chosenNum == computerNum - 2)
                {
                    Console.WriteLine("\nYou win!");
                } else if (chosenNum == computerNum) {
                    Console.WriteLine("\nIt is a tie!");
                } else {
                    Console.WriteLine("\nYou loose!");
                }

                PlayAgain:
                Console.WriteLine("\nDo you want to play again?");
                Console.WriteLine("[1] Yes");
                Console.WriteLine("[2] No");
                int continueToPlaySelection = Convert.ToInt32(Console.ReadLine());

                if (continueToPlaySelection == 1) {
                    Console.Clear();
                    Console.WriteLine("\nLovely! Let's play again! :)");
                } else if (continueToPlaySelection ==2) {
                    Console.WriteLine("\nThank you for playing!");
                    continuePlay = false;
                } else {
                    Console.WriteLine("\nThis is an invalid entry! Please try again.");
                    goto PlayAgain;
                }

            } while (continuePlay == true);
            
            Console.WriteLine("Press any key to exit...");
            Console.ReadKey();
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

        static void Introduction() {
            Console.WriteLine("Welcome to the wonderful game of Rock/Paper/Scissors!\n");
            Console.WriteLine("Rules: You choose between Rock, Paper or Scissors.");
            Console.WriteLine("The computer will randomly do the same.\n");
            Console.WriteLine("How you win: Rock wins Scissors, Paper wins Rock and Scissors wins Paper.");
        }
    }
}

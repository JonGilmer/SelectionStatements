using System;

namespace SelectionStatements
{
    class Program
    {
        static void Main(string[] args)
        {
            //Exercise 1:
            Random randomNumber = new Random();
            var favNumber = randomNumber.Next(1, 1000);

            int userInput;

            Console.Write("Enter a number between 1 & 1000 to guess my favorite number: ");

            do
            {
                userInput = int.Parse(Console.ReadLine());

                if (userInput > favNumber)
                {
                    Console.WriteLine("Too high");
                }
                else if (userInput < favNumber)
                {
                    Console.WriteLine("Too Low");
                }
                else
                {
                    Console.WriteLine("Congratulations!, you've guessed my favorite number!");
                }

                Console.Write("Please try again: ");
            }
            while (userInput != favNumber);


            //--------------------------------------------
            //Exercise 2:
            Console.Write("What is your favorite school subject? ");

            string favSubject = Console.ReadLine();

            switch (favSubject)
            {
                case "science":
                    Console.WriteLine("science: the study of the structure and behavior of the physical and natural world through observation and experimentation.");
                    break;
                case "literature":
                    Console.WriteLine("literature: the study of books, writings, or prose published on a particular subject.");
                    break;
                case "music":
                    Console.WriteLine("music: the art of arranging sounds in time as to produce beauty of form, harmony, and expression of emotion.");
                    break;
                case "history":
                    Console.WriteLine("history: the study of past events, typically in human affairs.");
                    break;
                case "math":
                    Console.WriteLine("math: the study of numbers and their operations.");
                    break;
                case "art":
                    Console.WriteLine("art: the expression of human imagination, typically in a visual form.");
                    break;
                case "computer science":
                    Console.WriteLine("computer science: the study of compyters and computer systems.");
                    break;
                default:
                    Console.WriteLine("other subjects: physical education is generally a favorite!");
                    break;
            }
        }
    }
}

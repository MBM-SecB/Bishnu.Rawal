using System;

namespace SelectAndLoop
{
    class SelectionStatement
    {
        static void Main234()
        {
            SelectionStatement s = new SelectionStatement();
            s.LearnSwitchStatements();
        }

        void CheckNumber()
        {
            Console.Write("Enter number: ");
            string input = Console.ReadLine();

            int number = int.Parse(input);

            if ((number & 1) == 0)
            {
                Console.WriteLine("You entered EVEN number.");
            }
            else
            {
                Console.WriteLine("You entered ODD number.");
            }
        }

        void LearnSwitchStatements()
        {
            Console.Write("Enter your hobby: ");
            string input = Console.ReadLine();

            switch (input)
            {
                case "books":
                    Console.WriteLine("That's great, you must be a great learner.");
                    break;

                case "badminton":
                    Console.WriteLine("Wow, badminton is great indoor game for excercise.");
                    break;

                case "swimming":
                    Console.WriteLine("You are in love with water?");
                    break;

                case "teaching":
                    Console.WriteLine("That's a rare hobby :)");
                    break;

                default:
                    Console.WriteLine("You like nothing? that's strange.");
                    break;
            }
        }
    }
}
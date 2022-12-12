
bool challengeRight = false;
bool startQuiz = false;
string input = "";
int incorrectGuesses = 0;
Console.WriteLine("Would you like to start the Treaty Scavenger Hunt? (yes / no)");
input = Console.ReadLine();

if (input.ToLower().Equals("yes"))
{
    startQuiz = true;
    while (startQuiz)
    {
        while (challengeRight == false)
        {
            //Challenge 1
            Console.WriteLine("Question 1: Which Treaty Encampesses Emerson? (1, 2 ,3 etc..)");
            input = Console.ReadLine();
            if (input.Equals("1"))
            {
                Console.Clear();
                Console.WriteLine("Correct!\n");
                Console.WriteLine("Press any key to continue!\n");
                Console.ReadLine();
                challengeRight = true;
                incorrectGuesses = 0;
            }
            else
            {
                incorrectGuesses++;
                Console.Clear();
                if (incorrectGuesses == 1)
                {
                    Console.WriteLine("That is not correct.\nHINT: Under Education, Discover.\n");
                }
                else if (incorrectGuesses == 2) {
                    Console.WriteLine("That is not correct.\nHINT: Treaty Poster Map, Second Section.\n");
                }
            }
        }
        challengeRight = false;
        while (challengeRight == false)
        {
            Console.Clear();
            Console.WriteLine("Question 2: What are wampum belts used for?");
            input = Console.ReadLine();

        }

    }

}
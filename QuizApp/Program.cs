using System;

class Program
{
    static void Main()
    {
        string question1 = "What is the capital of Slovakia?";
        string answer1 = "bratislava";

        string question2 = "What is 2+2?";
        string answer2 = "4";

        string question3 = "What color do you get by mixing blue and yellow?";
        string answer3 = "green";

        int score = 0;
        score += AskQuestion(question1, answer1);
        score += AskQuestion(question2, answer2);
        score += AskQuestion(question3, answer3);

        if (score == 3)
        {
            Console.WriteLine("Brilliant! Your score is 3 out of 3!");
        }
        else
        {
            Console.WriteLine("Your score is: " + score + " out of 3");
        }
    }
        public static int AskQuestion(string question, string answer)
    {
        Console.WriteLine(question);
        string userAnswer = Console.ReadLine();

        if (userAnswer.ToLower().Trim() == answer)
        {
            Console.WriteLine("Correct!");
            return 1;
        }
        else
        {
            Console.WriteLine("Wrong! The correct answer is: " + answer);
            return 0;
        }
    }
}
namespace SelectionStatementExercise
{
    public class Program
    {
        static void Main(string[] args)
        {
            //both exercises are their own separate method below
            GuessingGame();
            FavoriteSchoolSubject();
        }

        //==EXERCISE 1: Guess the Number Game==//
        // with the bonus of loop, will break out of loop when game is won
        static void GuessingGame()
        {
            Console.WriteLine("Player 1: Please give a number player 2 has to guess:");
            int playerOneNum = Convert.ToInt32(Console.ReadLine());
            Console.Clear();

            while (true)
            {
                Console.WriteLine("Player 2: Guess Player 1's number:");
                int playerTwoNum = Convert.ToInt32(Console.ReadLine());

                if(playerOneNum > playerTwoNum)
                {
                    Console.WriteLine("You guess too low. Please try again.");
                    Console.WriteLine(); //extra spacing
                }
                else if(playerOneNum < playerTwoNum)
                {
                    Console.WriteLine("You guess too high. Please try again.");
                    Console.WriteLine(); //extra spacing
                }
                else
                {
                    Console.WriteLine("You guessed right!");
                    Console.WriteLine(); //extra spacing
                    break;
                }

            }
            
            Console.WriteLine("Thanks for playing! :)");
        }

        //==EXERCISE 2: Favorite School Subject==//
        static void FavoriteSchoolSubject()
        {
            Console.WriteLine("What is your favorite subject in school?");
            string favoriteSubject = Console.ReadLine();

            switch(favoriteSubject.ToLower())
            {
                case "math":
                    Console.WriteLine("Math is cool because it's all about solving problems!");
                    break;
                case "science":
                    Console.WriteLine("Science is great understanding to the riddles of our universe!");
                    break;
                case "history":
                    Console.WriteLine("History is a great way for us to learn from our past!");
                    break;
                default:
                    Console.WriteLine("Interesting choice! What do you like about it?");
                    break;
            }
        }
    }
}

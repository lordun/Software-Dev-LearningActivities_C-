using System;
using System.Threading;

namespace Game
{
    public abstract class GussingGameBase //base class for all 
    { //abstract class cannot instantiate objects of its own, but can be used as a super class
        public static int guessMe { get; protected set; }
        public static int LOW = 0;
        public static int HIGH = 100;  //change me to change the number range
        //public field, every subclass objects and external methods needs to access this field, including the main method


        protected static Random r;
        protected static int steps;
        protected string playerName; //default field for a single player game
        //protected fileds will be shared in subclasses

        public GussingGameBase() //base class constructor
        {
            r = new Random(); //instantiate random object
            SetupANewGame();  //initialize game variables
            playerName = "Computer";  //default player name is computer
        }
        public GussingGameBase(string name):this()
        {
            playerName = name;   //if player name is given, update player name
        }
        protected static void SetupANewGame()  //initialize variables for a new game
        {
            steps = 0;
            guessMe = r.Next(LOW, HIGH);
        }
        public int CheckWin(int currentGuess)  //check for a winning condition
        {
            if (guessMe == currentGuess)
                return 0;
            else if (guessMe > currentGuess)
                return 1;
            else return -1;
        }
        public virtual void Reset() //reset the game
        {
            SetupANewGame();
        }
        public virtual int GetPlayerId(int winCondition = 0)
        {
            if (winCondition == 1) 
                return (steps - 1) % 2 + 1;  
            //a player wins at step-1, a player plays at current step, 
            return steps % 2 + 1;
        }
        public virtual int WhoesTurn()
        {
            return steps % 2 + 1; //check who will play next
        }
        public virtual string GetPlayerName(int winCondition = 0)
        {
            return playerName;  //get the default player name
        }
        public abstract int Play(); //abstract method, must override in the derived classes
        public abstract void GiveHints(int guess); 
    }
    public class GussingGame : GussingGameBase   //Novice Computer Vs Novice Computer class
    {
        // A novice computer can only remember last given hint.

        private string Player2;   //second player name
        protected int guessMin = LOW;  
        protected int guessMax = HIGH;
        protected int prevGuess = 0; //A Novice computer only remembers last guess

        public GussingGame() : base("Novice Computer-01")
        {
            Player2 = "Novice Computer-02";
        }
        public GussingGame(string name1) : base(name1)
        {
            Player2 = name1;
        }
        public GussingGame(string name1, string name2) : base(name1)
        {
            Player2 = name2;
        }
        public override string GetPlayerName(int winCondition = 0)
        {
            if (winCondition == 1) steps--;  //at step-1 we have a winner.  
            if (steps % 2 == 1)
                return Player2;
            return base.GetPlayerName();
        }
        public override int Play()
        {
            int computerGuess;
            steps++;
            if (CheckWin(prevGuess) > 0)
            {
                    guessMin = prevGuess + 1;
                    guessMax = HIGH;
            }
            else if (CheckWin(prevGuess) < 0)
            {

                guessMin = LOW;
                guessMax = prevGuess; //do not need +1 since max value is range-1
            }


            computerGuess = r.Next(guessMin, guessMax);
            Console.WriteLine(computerGuess);
            prevGuess = computerGuess;
            return computerGuess;
        }
        public override void GiveHints(int guess)
        {
            if (CheckWin(guess) > 0)
            {
                Console.WriteLine("Guess Higher >>>");
            }
            else if (CheckWin(guess) < 0)
            {
                Console.WriteLine("Guess Lower <<<");
            }
        }
        public override void Reset()
        {
            base.Reset();
            guessMin = LOW;
            guessMax = HIGH;
            prevGuess = 0;

        }
    }
    class OnePlayerGussingGame : GussingGame  //human vs novice computer
    {
        private string Player2;
        public OnePlayerGussingGame(string name):base("Novice Computer")
        {
            Player2 = name; //player 2 is human, player 1 is computer
        }
        public override string GetPlayerName(int winCondition = 0)
        {
            if (winCondition == 1) steps--;  //at step-1 we have a winner.  
            if (steps % 2 == 0)  //human player plays at every even step
                return Player2;
            return base.GetPlayerName();  // computer plays at every odd step
        }
        public override int Play()
        {
            int currentGuess;
            if (steps % 2 == 0) //human player plays at every even step
            {
                steps++;
                Console.WriteLine("Please enter your guess: ");//Human player given input
                currentGuess = int.Parse(Console.ReadLine());
                prevGuess = currentGuess;
                return currentGuess;
            }

            return base.Play(); //computer player predicts a move
        }
        
    }
    class OnePlayerAIComputerGussingGame : GussingGame   //Human vs Expert AI Computer
    {
        //An AI computer not only considers given hint, but also updates the possible solution range.
        private string Player2;
        public OnePlayerAIComputerGussingGame(string name):base("Expert AI Computer")
        {
            Player2 = name;
        }
        public override string GetPlayerName(int winCondition = 0)
        {
            if (winCondition == 1) steps--; //at step-1 we have a winner
            if (steps % 2 == 0)
                return Player2;
            return base.GetPlayerName();
        }
        protected void UpdateGuessRange() 
        {
            //AI computer not only monitors last guess, but also updates the range 

            if (CheckWin(prevGuess) > 0)
            {
                if(guessMin<=prevGuess)
                guessMin = prevGuess + 1;   
            }
            else if (CheckWin(prevGuess) < 0)
            {
                if (guessMax>prevGuess)//do not need to check equal this value is range-1
                guessMax = prevGuess-1;  
            }
        }
        public override int Play()
        {
            int currGuess;
            if (steps % 2 == 0) //human player plays at even steps
            {
                steps++;
                Console.WriteLine("Please enter your guess: ");
                prevGuess = int.Parse(Console.ReadLine());
                return prevGuess;
            }

            //AI computer plays at every odd step

            steps++;
            UpdateGuessRange();   //update guess based on previous players number
            currGuess = r.Next(guessMin, guessMax);
            Console.WriteLine(currGuess);
            prevGuess = currGuess;
            UpdateGuessRange();  //update guess based on computer's current number
            return currGuess;

        }
    }
    class AIComputerAIComputerGussingGame : OnePlayerAIComputerGussingGame   //AI Computer vs AI Computer
    {
        private string Player2;
        public AIComputerAIComputerGussingGame() : base("AI Computer 01")
        {
            Player2= "AI Computer 02";
        }
        public AIComputerAIComputerGussingGame(string name): base("AI Computer 01")
        {
            Player2 = name;
        }
        public override string GetPlayerName(int winCondition = 0)
        {
            if (winCondition == 1) steps--; //at step-1 we have a winner
            if (steps % 2 == 1)
                return Player2;
            return base.GetPlayerName();
        }
        
        public override int Play()
        {
            int currGuess; //AI player plays at every even or odd step
            if (steps % 2 == 1) //AI player playing for odd steps 
            {
                return base.Play();
            }

            //AI player playing for odd steps
            steps++;
            UpdateGuessRange();   //update guess based on other players number
            currGuess = r.Next(guessMin, guessMax);
            Console.WriteLine(currGuess);
            prevGuess = currGuess;
            UpdateGuessRange();  //update guess based on computer's current number
            return currGuess;
        }
    }
    class TwoPlayerGussingGame : OnePlayerGussingGame   //human vs human class
    {
        private string Player2;
        public TwoPlayerGussingGame(string name1, string name2) : base(name1)
        {
            Player2 = name2;
        }
        public override string GetPlayerName(int winCondition = 0)
        {
            if (winCondition == 1) steps--; //at step-1 we have a winner
            if (steps % 2 == 1)
                return Player2;
            return base.GetPlayerName();
        }
        public override int Play()
        {
            if (steps % 2 == 1)  //human player playing for the odd step 
            {
                steps++;
                Console.WriteLine("Please enter your guess: ");
                return int.Parse(Console.ReadLine()); //input for human player
            }
            return base.Play(); //in the base class human player also plays for even step
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            string choice;
            string player1, player2;
            GussingGameBase playAgent;
            do
            {
                Console.Clear();
                Console.WriteLine("Please enter your choice: ");
                Console.WriteLine("Enter 1 for watching (Novice/Inexperienced) Computer VS Computer game.");
                Console.WriteLine("Enter 2 for playing Human VS Novice Computer game.");
                Console.WriteLine("Enter 3 for playing Human VS (Expert) AI Computer game.");
                Console.WriteLine("Enter 4 for playing Human VS Human game.");
                Console.WriteLine("Enter 5 for watching AI Computer VS AI Computer game.");
                Console.WriteLine("Enter 6 for Exit.");
                choice = Console.ReadLine();
                if (choice == "1")
                {
                    playAgent = new GussingGame();   //Computer VS Computer
                }
                else if (choice == "2")
                {
                    Console.WriteLine("Please enter human player name: ");
                    player1 = Console.ReadLine();
                    playAgent = new OnePlayerGussingGame(player1); //Human VS Novice Computer
                }
                else if (choice == "3") 
                {
                    Console.WriteLine("Please enter human player name: ");
                    player1 = Console.ReadLine();
                    playAgent = new OnePlayerAIComputerGussingGame(player1);  //Human VS AI Computer
                }
                else if (choice == "4")
                {
                    Console.WriteLine("Please enter player-01 name: ");
                    player1 = Console.ReadLine();
                    Console.WriteLine("Please enter player-02 name: ");
                    player2 = Console.ReadLine();
                    playAgent = new TwoPlayerGussingGame(player1, player2); //Human VS Human
                }
                else if (choice == "5")
                {
                    playAgent = new AIComputerAIComputerGussingGame(); //AI Computer VS AI Computer
                }

                else if (choice == "6")
                {
                    break;
                }
                else
                {
                    Console.WriteLine("Incorrect Selection. Please enter correctly! ");
                    Console.ReadKey();
                    continue;
                }

                int currentGuess;
                playAgent.Reset();
                Console.WriteLine("Assume The Hidden Number: " + GussingGame.guessMe + ", is unknown to all players!");
                Thread.Sleep(3000);
                do
                {
                    Console.Clear();
                    Console.WriteLine("Guess a number in range {0} to {1}: ", GussingGameBase.LOW, GussingGameBase.HIGH);
                    Console.WriteLine("Now playing player: {0}: {1}", playAgent.WhoesTurn(), playAgent.GetPlayerName());

                    Thread.Sleep(1500);
                    currentGuess = playAgent.Play();
                    playAgent.GiveHints(currentGuess);
                    Thread.Sleep(1000);

                } while (playAgent.CheckWin(currentGuess) != 0);
                Console.WriteLine("Congratulations! Player {0}: {1} Wins...", playAgent.GetPlayerId(1), playAgent.GetPlayerName(1));
                Console.WriteLine("Do you want to play again? (Y/N): ");
                choice = Console.ReadLine();
                if (choice == "n" || choice == "N") break;
            } while (true);
        }
    }
}
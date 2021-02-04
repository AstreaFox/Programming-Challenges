using System;
using System.Threading;

namespace GuessTheNumber
{
	class Program
	{


		public static int failureCounter = 1;


		static void Main(string[] args)
		{

			Console.BackgroundColor = ConsoleColor.White;
			Console.Clear();
			Introduction();

		}


		static private void Introduction()
		{

			Console.ForegroundColor = ConsoleColor.Red;
			Console.WriteLine(
				"Welcome to this guessing game!\n" +

				"\nYou will have the option to select your own range and whether the random number is an integer or a fractional number." +
				"\nIf you choose a fractional number, you will also have the option to specify the the number of decimal places, increasing difficulty." +
				"\nThe range you select will dictate the range of numbers the random number may appear within." +
				"\nIf you guess too low or high, you will be told. You'll also be bullied upon each incorrect attempt to increase satisfaction at the cost of sanity.\n" +
				"\nYou'll see what I mean ;) ... Press any key to continue...\n");

			Console.ReadKey(true);
			Setup();

		}


		static private void Setup()
		{

			Console.Clear();

			var rangeMin = 0;
			var rangeMax = 0;

			Console.ForegroundColor = ConsoleColor.Blue;

			while (true)
			{

				rangeMin = PromptForInt("Enter the minimum range (integer): ");
				rangeMax = PromptForInt("Enter the maximum range (integer): ");

				if (rangeMax <= rangeMin)
				{

					Console.BackgroundColor = ConsoleColor.Yellow;
					Console.ForegroundColor = ConsoleColor.Red;
					Console.Write("In what world is the minimum higher or equal to the maximum!? ");
					insultSelector();

				}

				else { break; }

			}

			var choice = 0;

			while (true)
			{

				choice = PromptForInt("\nEnter '1' to set the randomized number as an integer, or '2' or a fractional number: ");

				switch (choice)
				{

					case 1: IntegerRandomizer(rangeMin, rangeMax); break;
					case 2: DoubleRandomizer(rangeMin, rangeMax); break;
					default: Console.WriteLine("Enter '1' or '2'. It's not hard...is it?"); insultSelector(); break;

				}

			}

		}


		static int PromptForInt(string message = "")
		{

			while (true)
			{
				Console.ForegroundColor = ConsoleColor.Blue;
				Console.Write(message);

				if (int.TryParse(Console.ReadLine(), out var result)) { return result; }
				insultSelector();

			}

		}


		static double PromptForDouble(string message = "")
		{

			while (true)
			{

				Console.ForegroundColor = ConsoleColor.Blue;
				Console.Write(message);

				if (double.TryParse(Console.ReadLine(), out var result)) { return result; }
				insultSelector();

			}

		}


		private static void IntegerRandomizer(int min, int max)
		{

			int rangeMin = min;
			int rangeMax = max;

			Random random = new Random();
			int randomInteger = random.Next(rangeMin, rangeMax + 1);

			Console.ForegroundColor = ConsoleColor.Red;
			Console.WriteLine("\nThe number has been generated. You may begin.");

			BeginWithInteger(randomInteger);

		}


		private static void BeginWithInteger(int randInt)
		{

			int randomInteger = randInt;
			var guess = 0;

			Console.ForegroundColor = ConsoleColor.Blue;

			while (true)
			{

				guess = PromptForInt("\nYour guess (integer): ");

				if (guess < randomInteger) { TooLow(); BeginWithInteger(randomInteger); }
				else if (guess > randomInteger) { TooHigh(); BeginWithInteger(randomInteger); }
				else if (guess == randomInteger) { WrapUp(); }

			}

		}


		private static void DoubleRandomizer(int rangeMin, int rangeMax)
		{

			var decimal_places = 0;

			Random random = new Random();
			double randomDouble = random.NextDouble() * (rangeMax - rangeMin) + rangeMin;

			while (true)
			{

				decimal_places = PromptForInt("\nEnter the decimal precision (integer): ");
				randomDouble = Math.Round(randomDouble, decimal_places);

				Console.ForegroundColor = ConsoleColor.Red;
				Console.WriteLine("\nThe number has been generated. You may begin.");

				BeginWithDouble(randomDouble);

			}

		}


		private static void BeginWithDouble(double randomDouble)
		{

			var guess = 0.0;

			Console.ForegroundColor = ConsoleColor.Blue;

			while (true)
			{

				guess = PromptForDouble("\nYour guess (integer or double): ");

				if (guess < randomDouble) { TooLow(); BeginWithDouble(randomDouble); }
				else if (guess > randomDouble) { TooHigh(); BeginWithDouble(randomDouble); }
				else if (guess == randomDouble) { WrapUp(); }

			}

		}


		private static void insultSelector()
		{

			string[] insults = new string[]
			{

				"Don’t feel bad, there are many people who have no talent.",
				"You're living proof that someone can live without a brain.",
				"I’ve seen people like you but I had to pay admission.",//
				"You’re the reason God created the middle finger.",
				"I’m not insulting you, I’m describing you.",
				"Keep rolling your eyes, you might eventually find a brain.",//
				"You are the human version of period cramps.",//
				"You are so full of shit, the toilet’s jealous.",
				"I can see your point, but I still think you're full of shit.",
				"Ahhh...I see the fuck-up fairy has visited us again...",
				"Thank you. We're all refreshed and challenged by your unique point of view.",
				"If I said anything to offend you it was purely intentional.",
				"I'd like to help you out. Which way did you come in?",
				"If I throw a stick, will you go away?",
				"I’d explain it to you, but I don’t have any crayons with me.",
				"The last time I saw a face like yours I fed it a banana.",
				"If stupidity was painful, you'd be in agony.",
				"You started at the bottom and it's been downhill ever since.",
				"Someday you'll find yourself, and will you be disappointed.",
				"Anybody who told you to just be yourself couldn't have given you worse advice.",
				"You are proof that God has a sense of humour.",
				"Don't be ashamed of yourself. That's your parents' job.",
				"What doesn't kill you just disappoints me.",//
				"Hey, train wreck! This isn't your station.",
				"If you ran like your mouth, you'd be in good shape.",
				"Two wrongs don't make a right. Take your parents for example.",//
				"You're like the ends of a loaf of bread. We all see you, but none of us want you.",
				"I have neither the time nor crayons to explain this to you.",
				"You're as important as a white crayon.",
				"You're like Rapunzel, except instead of letting down your hair, you let down everyone in your life.",///
				"You're the reason we can't have nice things."

			}; //31 total

			failureCounter += 1;

			Random random = new Random();
			int selectedInsult = random.Next(0, insults.Length);

			Console.BackgroundColor = ConsoleColor.Yellow;
			Console.ForegroundColor = ConsoleColor.Red;

			Console.WriteLine(insults[selectedInsult]);
			Console.BackgroundColor = ConsoleColor.White;

		}


		private static void TooLow()
		{

			Console.BackgroundColor = ConsoleColor.Red;
			Console.ForegroundColor = ConsoleColor.Yellow;
			Console.Write(" HIGHER! ");
			insultSelector();
			Console.BackgroundColor = ConsoleColor.White;
			Console.ForegroundColor = ConsoleColor.Red;

		}


		private static void TooHigh()
		{

			Console.BackgroundColor = ConsoleColor.Red;
			Console.ForegroundColor = ConsoleColor.Yellow;
			Console.Write(" LOWER! ");
			insultSelector();
			Console.BackgroundColor = ConsoleColor.White;
			Console.ForegroundColor = ConsoleColor.Red;

		}


		private static void WrapUp()
		{

			string degrade = "degrade me further";
			string give_up = "i give up";

			Console.ForegroundColor = ConsoleColor.Yellow;
			Console.BackgroundColor = ConsoleColor.Red;

			Console.WriteLine("\nSomehow, it took you " + failureCounter + " attempt(s) before guessing correctly.");

			Console.ForegroundColor = ConsoleColor.Red;
			Console.BackgroundColor = ConsoleColor.White;

			Console.WriteLine(
				"\nIf you want to degrade yourself more,  enter 'degrade me further' to play again." +
				"\nIf you've had enough of the truth, enter 'i give up', because that's what you do.");

			while (true)
			{

				Console.ForegroundColor = ConsoleColor.Blue;
				Console.Write("\nYour decision: ");
				var decision = Console.ReadLine().ToLower();
				Console.ForegroundColor = ConsoleColor.Red;

				if (decision == degrade)
				{

					Console.ForegroundColor = ConsoleColor.Yellow;
					Console.BackgroundColor = ConsoleColor.Red;
					Console.Write(" RESETTING ");
					insultSelector();
					Console.ForegroundColor = ConsoleColor.Red;
					Console.BackgroundColor = ConsoleColor.White;
					Thread.Sleep(2000);
					Console.Clear();
					failureCounter = 1;
					Introduction();

				}
				else if (decision == give_up)
				{

					Console.WriteLine("\nWhy am I not surprised?");
					Thread.Sleep(1500);
					Environment.Exit(1);

				}

				else{Console.Write("You love creating problems don't you? ");insultSelector();}

			}

		}

	}
}

using System;
using System.Data;

namespace MathQuestionGenerator
{
	class Program
	{
		static void Main(string[] args)
		{
			Console.Write("Minimum range: ");
			int min_range = Convert.ToInt32(Console.ReadLine());

			Console.Write("Maximum Range: ");
			int max_range = Convert.ToInt32(Console.ReadLine());

			int score = 0;

			while (true)
			{
				Random random = new Random();
				int num_1 = random.Next(min_range, max_range);
				int num_2 = random.Next(min_range, max_range);

				var op_index = random.Next(0, 4);
				string[] operators = new string[4] { "+", "-", "*", "%" };
				var using_op = operators[op_index];

				DataTable dt = new DataTable();
				int answer = Convert.ToInt32(dt.Compute(num_1 + using_op + num_2, ""));

				Console.WriteLine("\nQuestion: " + num_1 + " " + using_op + " " + num_2);

				Console.Write("\nYour answer: ");

				int attempt = Convert.ToInt32(Console.ReadLine());

				if (answer == attempt)
				{
					Console.WriteLine("Correct!");
					score++;
				}
				else
				{
					Console.WriteLine("Incorrect!");
					insultSelector();
					if (score < 1) { score = 0; } else { score--; }
					Console.WriteLine("Correct answer: " + answer);
				}
				Console.WriteLine("Score: " + score);
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

			Random random = new Random();
			int selectedInsult = random.Next(0, insults.Length);
			Console.WriteLine(insults[selectedInsult]);
		}
	}
}
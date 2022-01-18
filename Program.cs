using System;

namespace EnthusiasticMoose
{
    class Program
    {
        static void Main(string[] args)
        {
          Console.WriteLine("Welcome to the Enthusiastic Moose Simulator!");
          Console.WriteLine("--------------------------------------------");
          Console.WriteLine();

          // Let the moose speak!
          MooseSays("H I, I'M E N T H U S I A S T I C !");
          MooseSays("DERP DERP I'm HAPPY!");

          // Ask some questions!
          AskQuestion("Is Canada real?");
          AskQuestion("Are you enthusiastic?");
          AskQuestion("Do you love C# yet?");
          AskQuestion("Do you want to know a secret?");
        }

        static void AskQuestion(string question)
        {
          bool isTrue = MooseAsks(question);
          if (isTrue)
          {
            MooseSays("That's cool!");
          }
          else
          {
            MooseSays("That's okay too.");
          }
        }

        static void MooseSays(string message)
        {
            Console.WriteLine($@"
                                       _.--^^^--,
                                    .'          `\
  .-^^^^^^-.                      .'              |
 /          '.                   /            .-._/
|             `.                |             |
 \              \          .-._ |          _   \
  `^^'-.         \_.-.     \   `          ( \__/
        |             )     '=.       .,   \
       /             (         \     /  \  /
     /`               `\        |   /    `'
     '..-`\        _.-. `\ _.__/   .=.
          |  _    / \  '.-`    `-.'  /
          \_/ |  |   './ _     _  \.'
               '-'    | /       \ |
                      |  .-. .-.  |
                      \ / o| |o \ /
                       |   / \   |    {message}
                      / `^`   `^` \
                     /             \
                    | '._.'         \
                    |  /             |
                     \ |             |
                      ||    _    _   /
                      /|\  (_\  /_) /
                      \ \'._  ` '_.'
                       `^^` `^^^`
            ");
        }

        static bool MooseAsks(string question)
        {
          Console.Write($"{question} (Y/N): ");
          string answer = Console.ReadLine().ToLower();

          while (answer != "y" && answer != "n")
          {
            Console.Write($"{question} (Y/N): ");
            answer = Console.ReadLine().ToLower();
          }

          if (answer == "y")
          {
            return true;
          }
          else
          {
            return false;
          }
        }
    }
}

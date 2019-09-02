using System;
using static System.Console;

namespace AsciiX
{
    class Program
    {
        static void WriteMenu(string output)
        {
            Clear();
            WriteLine("Choose an option:\n1 = ASCII Art X\n2 = Algorithmic X\n");
            WriteLine("To exit, press 0 (zero) key.\n\n");
            WriteLine(output);
        }

        static void RepeatChar(string character, int reps)
        {
            for (int i = 0; i < reps; i++)
            {
                Write(character);
            }
        }

        static void GenerateX(int height)
        {
            WriteLine("The desired height is {0}.", height);

            //generate algorithmic X
            for (int i = 0; i < height/2; i++)
            {
                RepeatChar(" ", i+1);
                RepeatChar("#", 1);
                RepeatChar(" ", height - (2 * (i + 1)));
                WriteLine("#");
            }
            if (height % 2 != 0)
            {
                RepeatChar(" ", (height / 2) + 1);
                WriteLine("#");
            }
            for (int i = (height / 2) - 1; i > -1; i--)
            {
                RepeatChar(" ", i + 1);
                RepeatChar("#", 1);
                RepeatChar(" ", height - (2 * (i + 1)));
                WriteLine("#");
            }
        }
        static void Main(string[] args)
        {
            string input;
            string message = "";
            int choice = 0;
            while (0 == 0)
            {
                WriteMenu(message);
                input = ReadLine();
                while (!int.TryParse(input, out choice))
                {
                    message = "Invalid input.\nPlease choose a number: 0, 1, or 2.";
                    WriteMenu(message);
                    input = ReadLine();
                }
                switch (choice)
                {
                    case 0:
                        Console.WriteLine("Exiting...");
                        Environment.Exit(0);
                        break;
                    case 1:
                        WriteLine("Generating ASCII Art X ...");
                        WriteLine();
                        WriteLine(" __   __");
                        WriteLine(" \\ \\ / /");
                        WriteLine("  \\ V /");
                        WriteLine("   > <");
                        WriteLine("  / . \\");
                        WriteLine(" /_/ \\_\\");
                        WriteLine();
                        WriteLine("Press any key to return to menu.");
                        ReadKey();
                        break;
                    case 2:
                        message = "Generating Algorithmic X ...\nEnter desired height of X:";
                        WriteMenu(message);
                        input = ReadLine();
                        while (!int.TryParse(input, out choice))
                        {
                            message = "Generating Algorithmic X ...\nEnter desired height of X:\n";
                            message += "\nInvalid input.\nPlease choose a number greater than two.";
                            message += "\nLarge values require a large console to display correctly.";
                            WriteMenu(message);
                            input = ReadLine();
                        }
                        GenerateX(choice);
                        message = "";
                        WriteLine("Press any key to return to menu.");
                        ReadKey();
                        break;
                    default:
                        message = "Please choose 0, 1, or 2 next time.";
                        WriteMenu(message);
                        break;
                }
            }
        }
    }
}

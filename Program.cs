using System;

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

        static void GenerateX()
        {
            WriteLine("Generating Algorithmic X ...");
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
                        WriteLine(" __   __");
                        WriteLine(" \\ \\ / /");
                        WriteLine("  \\ V /");
                        WriteLine("   > <");
                        WriteLine("  / . \\");
                        WriteLine(" /_/ \\_\\");
                        WriteLine();
                        break;
                    case 2:
                        GenerateX();
                        break;
                    default:
                        message = "Please choose 0, 1, or 2 next time.";
                        WriteMenu(message);
                        break;
                }
            }
        }
}

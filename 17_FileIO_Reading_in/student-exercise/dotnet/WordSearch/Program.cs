using System;
using System.IO;

namespace WordSearch
{
    class Program
    {
        static void Main(string[] args)
        {
            
                Console.Clear();
                //1. Ask the user for the search string

                Console.Write("Please enter a string to search for: ");
                string searchTerm = Console.ReadLine();

                //string searchTerm = "Dog";

                //1.1 Ask the user for the search string
                Console.Write("Should the search be case sensitive? (Y/N): ");
                string caseSensDecision = Console.ReadLine();

                bool isCaseSensitive = false;

                if (caseSensDecision.ToLower() == "y")
                {
                    isCaseSensitive = true;
                }

                //2.Ask the user for the file path

                Console.Write("Please enter the file path to the text file (including the file name and extension): ");
                string filePath = Console.ReadLine();

                //string filePath = @"C:\workspace\exercises\17_FileIO_Reading_in\student-exercise\dotnet\alices_adventures_in_wonderland.txt";

                while (!FileExists(filePath))
                {
                    Console.Clear();
                    Console.WriteLine("File does not exist...");
                    Console.WriteLine("\nPlease re-enter the absolute file path: ");
                    filePath = Console.ReadLine();
                }

                SearchForWord(searchTerm, isCaseSensitive, filePath);

                Console.ReadKey();
            
        }


        public static void SearchForWord(string searchTerm, bool isCaseSensitive, string filePath)
        {
            if (!isCaseSensitive)
            {
                searchTerm = searchTerm.ToLower();
            }

            int lineNumber = 0;
            int numberOfHits = 0;

            using (StreamReader sr = new StreamReader(filePath))
            {
                string line;

                Console.WriteLine();

                while (!sr.EndOfStream)
                {
                    lineNumber++;

                    line = sr.ReadLine();

                    if (isCaseSensitive)
                    {
                        if (line.Contains(searchTerm))
                        {
                            //5. If the line contains the search string, print it out along with its line number

                            numberOfHits++;
                            Console.WriteLine($"{lineNumber}) {line}");
                        }
                    }
                    else if (!isCaseSensitive)
                    {
                        if (line.ToLower().Contains(searchTerm.ToLower()))
                        {
                            //5. If the line contains the search string, print it out along with its line number

                            numberOfHits++;
                            Console.WriteLine($"{lineNumber}) {line}");
                        }
                    }
                }

                if (numberOfHits == 0)
                {
                    Console.WriteLine($"\n\"{searchTerm}\" is not present in the file...");
                }

            }
        }

        public static bool FileExists(string filePath)
        {
            return File.Exists(filePath);
        }
        
    }
}

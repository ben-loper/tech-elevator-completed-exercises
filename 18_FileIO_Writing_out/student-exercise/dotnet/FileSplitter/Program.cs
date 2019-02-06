using System;
using System.Collections.Generic;
using System.IO;

namespace FileSplitter
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Where is the input file (please include the path to the file)?:");
            string filePath = Console.ReadLine();

            while (!File.Exists(filePath))
            {
                Console.Clear();
                Console.WriteLine("Entered file does not exist. Please re-enter the file path\n");
                Console.Write("Where is the input file (please include the path to the file)?:");
                filePath = Console.ReadLine();
            }
            //string filePath = @"C:\workspace\exercises\18_FileIO_Writing_out\student-exercise\dotnet\FileSplitter\input.txt";

            Console.Write("How many lines of text(max) should there be in the split files?: ");

            bool maxNumberSet = false;

            while (!maxNumberSet)
            {
                try
                {
                    int maxNumberOfLines = int.Parse(Console.ReadLine());

                    if (maxNumberOfLines > 0)
                    {
                        maxNumberSet = true;

                        long numOfLines = GetNumberOfLines(filePath);

                        Console.WriteLine($"\nThe input file has {numOfLines} lines of text\n");

                        Console.WriteLine($"For a {numOfLines} line file, this will produce {Math.Ceiling((decimal)numOfLines / maxNumberOfLines)} output files\n");

                        PrintToFileSpecificNumOfLine(filePath, maxNumberOfLines);
                    } else
                    {
                        Console.WriteLine("Please enter only whole value, positive numbers greater than 0: ");
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message+"\n");
                    Console.Write("How many lines of text(max) should there be in the split files?:");
                }
                }
            

            Console.ReadKey();
        }

        public static long GetNumberOfLines(string filePath)
        {
            long lineCounter = 0;

            try
            {
                using (StreamReader sr = new StreamReader(filePath))
                {
                    while (!sr.EndOfStream)
                    {
                        sr.ReadLine();
                        lineCounter++;
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            return lineCounter;
        }

        public static void PrintToFileSpecificNumOfLine(string filePath, int maxNumOfLines)
        {
            string destinationDirectory = @"C:\workspace\exercises\18_FileIO_Writing_out\student-exercise\dotnet\FileSplitter\output\";

            int i = 1;
            string fileName = $"input-{i}.txt";

            string destinationFullPath = destinationDirectory + fileName;

            int lineCount = 1;

            List<string> lines = new List<string>();

            try
            {
                using (StreamReader sr = new StreamReader(filePath))
                {
                    
                    while (!sr.EndOfStream)
                    {
                        if (lineCount > maxNumOfLines)
                        {
                            

                            Console.WriteLine($"Generating input-{i}.txt");

                            i++;

                            PrintToFile(destinationFullPath, lines.ToArray());

                            destinationFullPath = destinationDirectory + $"input-{i}.txt";
                            lineCount = 1;
                            lines.Clear();
                        }
                        else
                        {
                            lineCount++;

                            string line = sr.ReadLine();

                            lines.Add(line);
                        }  
                    }

                    if (lines.Count > 0)
                    {
                        Console.WriteLine($"Generating input-{i}.txt");

                        PrintToFile(destinationFullPath, lines.ToArray());
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            
        }

        private static void PrintToFile(string destinationFullPath, string[] lines)
        {
            try
            {
                
                using (StreamWriter sw = new StreamWriter(destinationFullPath))
                {
                    foreach (string line in lines)
                    {
                        sw.WriteLine(line);
                    }
                }
            } catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }

}

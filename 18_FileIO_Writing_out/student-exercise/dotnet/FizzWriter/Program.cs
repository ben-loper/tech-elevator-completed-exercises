using System;
using System.IO;

namespace FizzWriter
{
    class Program
    {
        static void Main(string[] args)
        {

            string currentDirectory = Directory.GetCurrentDirectory();

            string filePath = currentDirectory + @"\..\..\..\..\";

            string fileName = "FizzBuzz.txt";

            string fullPath = Path.Combine(filePath, fileName);

            Console.WriteLine(PrintToFile(fullPath, fileName));

            Console.ReadKey();
        }


        public static string PrintToFile(string destinationFile, string fileName)
        {
            string message = "";

            try
            {
                using (StreamWriter sr = new StreamWriter(destinationFile))
                {
                    for (int i = 1; i <= 300; i++)
                    {
                        sr.WriteLine($"{i} - {FizzBuzz.FizzBuzzBuilder(i)}");
                    }
                }

                message = $"{fileName} has been created.";
            }
            catch (Exception ex)
            {
                message = "Something went wrong\n";
                message += ex.Message;
            }

            return message;
        }
    }
}

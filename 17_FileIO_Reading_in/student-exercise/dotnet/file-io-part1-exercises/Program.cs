using System;
using System.IO;

namespace file_io_part1_exercises
{
    class Program
    {
        static void Main(string[] args)
        {
            Quiz quiz = new Quiz();

            //string filePath = @"C:\workspace\exercises\17_FileIO_Reading_in\student-exercise\dotnet\sample-quiz-file.txt";

            Console.Write("Please enter the file path to the text file (including the file name and extension): ");
            string filePath = Console.ReadLine();

            while (!File.Exists(filePath))
            {
                Console.Clear();
                Console.WriteLine("File does not exist...");
                Console.WriteLine("\nPlease re-enter the absolute file path: ");
                filePath = Console.ReadLine();
            }

            try
            {
                using (StreamReader sr = new StreamReader(filePath))
                {
                    while (!sr.EndOfStream)
                    {
                        string line = sr.ReadLine();

                        quiz.AddQuestionToList(new QuizQuestion(line));
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                Console.ReadKey();
            }

            foreach(QuizQuestion question in quiz.QuizQuestions)
            {
                try
                {
                    Console.WriteLine();
                    Console.WriteLine(question.DisplayQuestionsAndAnswer());

                    Console.Write("Your answer: ");

                    int answer = int.Parse(Console.ReadLine());

                    if (question.AnswerQuestion(answer))
                    {
                        Console.WriteLine("RIGHT!\n");
                        quiz.AnsweredCorrectly();
                    }
                    else
                    {
                        Console.WriteLine("WRONG!\n");
                    }
                }
                catch (Exception)
                {
                    Console.WriteLine("WRONG!\n");
                }
            }
            Console.WriteLine($"You got {quiz.NumOfCorrectAnswers} answer(s) correct out of the {quiz.NumOfQuestions} questions asked.");
            Console.ReadKey();

        }
    }
}

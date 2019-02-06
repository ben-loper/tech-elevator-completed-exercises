using System;
using System.Collections.Generic;
using System.Text;

namespace file_io_part1_exercises
{
    [Serializable]
    public class QuizQuestion
    {
        public string Question { get; set; }

        public List<string> Answers = new List<string>();

        public string CorrectAnswer { get; set; }
        

        public QuizQuestion(string questionAndAnswers)
        {
            CreateQuestionAndAnswers(questionAndAnswers);
        }

        public QuizQuestion()
        {

        }

        private void DetermineCorrectAnswer(string[] answers)
        {
            for (int i = 0; i < answers.Length; i++)
            {
                if (answers[i].Contains("*"))
                {
                    answers[i] = answers[i].Remove(answers[i].Length - 1);
                    CorrectAnswer = answers[i];
                }
            }
        }

        private void CreateQuestionAndAnswers(string questionAndAnswers)
        {
            String[] questionsArray = questionAndAnswers.Split("|");

            Question = questionsArray[0];

            for (int i = 1; i < questionsArray.Length; i++)
            {
                if (questionsArray[i].Contains("*"))
                {
                    CorrectAnswer = questionsArray[i].Remove(questionsArray[i].Length - 1);
                    Answers.Add(CorrectAnswer);
                }
                else
                {
                    Answers.Add(questionsArray[i]);
                }
            }
        }

        public string DisplayQuestionsAndAnswer()
        {
            string questionAndAnswers = Question + "\n";

            for (int i = 0; i < Answers.Count; i++)
            {
                questionAndAnswers += $"{i + 1}. {Answers[i]}\n";
            }
            return questionAndAnswers;
        }

        public bool AnswerQuestion(int answer)
        {
            bool result = false;

            if (Answers[answer - 1] == CorrectAnswer)
            {
                result = true;
            }

            return result;
        }
    }
}

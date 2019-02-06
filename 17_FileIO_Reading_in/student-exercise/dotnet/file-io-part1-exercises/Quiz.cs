using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace file_io_part1_exercises
{
    [Serializable]
    public class Quiz
    {
        public int NumOfCorrectAnswers { get; set; } = 0;

        public int NumOfQuestions
        {
            get
            {
                return QuizQuestions.Count;
            }
        }

        public List<QuizQuestion> QuizQuestions = new List<QuizQuestion>();

        public void AddQuestionToList(QuizQuestion question)
        {
            QuizQuestions.Add(question);
        }

        
        public void AnsweredCorrectly()
        {
            NumOfCorrectAnswers++;
        }
    }
}

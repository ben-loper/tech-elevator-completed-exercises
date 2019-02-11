using file_io_part1_exercises;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;

namespace QuizMakerTests
{
    [TestClass]
    public class QuizQuestionsTests
    {
        QuizQuestion questionOne = new QuizQuestion("Question 1?|Answer One|Answer Two|Answer Three*|Answer Four");

        [TestMethod]
        public void CreateQuestionAndAnswersTest()
        {
            QuizQuestion questionTwo = new QuizQuestion("Question 2?|Answer One|Answer Two|Answer Three*|Answer Four");

            Assert.AreEqual("Question 2?", questionTwo.Question, "Question for created question should display as \"Question 2?\"");

            Assert.AreEqual(4, questionTwo.Answers.Count, "Question should have 4 answers");

            Assert.AreEqual("Answer One", questionTwo.Answers[0], "First question displays correctly");

            Assert.AreEqual("Answer Two", questionTwo.Answers[1], "Second question displays correctly");

            Assert.AreEqual("Answer Three", questionTwo.Answers[2], "Third question displays correctly");

            Assert.AreEqual("Answer Four", questionTwo.Answers[3], "Fourth question displays correctly");
        }

        [TestMethod]
        public void DisplayQuestionAndAnswersTest()
        {
            QuizQuestion questionThree = new QuizQuestion("Question 3?|Answer One|Answer Two|Answer Three*|Answer Four");

            string actual = questionThree.DisplayQuestionsAndAnswer();

            Assert.AreEqual("Question 3?\n1. Answer One\n2. Answer Two\n3. Answer Three\n4. Answer Four\n", actual, "Question and answers displayed in the correct format");
        }

        [TestMethod]
        public void AnswerQuestionTest()
        {
            QuizQuestion questionThree = new QuizQuestion("Question 3?|Answer One|Answer Two|Answer Three*|Answer Four");           

            Assert.AreEqual(true, questionThree.AnswerQuestion(3), "Answer question correctly");

            Assert.AreEqual(false, questionThree.AnswerQuestion(2), "Answer question incorrectly");
        }

        [TestMethod]
        public void DeterimeCorrectAnswerTest()
        {
            QuizQuestion questionFour = new QuizQuestion("Question 3?|Answer One|Answer Two|Answer Three*|Answer Four");

            Assert.AreEqual("Answer Three", questionFour.CorrectAnswer, "Correct answer is set and formatted properly");
        }
    }
}

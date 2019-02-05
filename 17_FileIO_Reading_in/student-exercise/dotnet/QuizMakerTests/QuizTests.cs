using file_io_part1_exercises;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace QuizMakerTests
{
    [TestClass]
    public class QuizTests
    {
        Quiz quiz = new Quiz();

        [TestMethod]
        public void NumOfCorrectAnswersDefault()
        {
            Assert.AreEqual(0, quiz.NumOfCorrectAnswers, "Number of correct answers defaults to 0 upon quiz object creation");
        }

        [TestMethod]
        public void AnswerCorrectlyTest()
        {
            quiz.AnsweredCorrectly();
            Assert.AreEqual(1, quiz.NumOfCorrectAnswers, "Correct answers counter increases after calling AnsweredCorrectly method on a quiz object");
        }

        [TestMethod]
        public void AddQuestionsToQuizTest()
        {
            quiz.AddQuestionToList(new QuizQuestion("Test Question|First answer|Second Answer|Correct Answer*|Fourth answer"));

            Assert.AreEqual(1, quiz.NumOfQuestions, "Add one test to the quiz object");
        }

        [TestMethod]
        public void NumOfQuestionsTest()
        {
            quiz.AddQuestionToList(new QuizQuestion("Test Question|First answer|Second Answer|Correct Answer*|Fourth answer"));
            quiz.AddQuestionToList(new QuizQuestion("2nd Test Question|First answer|Second Answer|Correct Answer*|Fourth answer"));
            quiz.AddQuestionToList(new QuizQuestion("3nd Test Question|First answer|Second Answer|Correct Answer*|Fourth answer"));
            Assert.AreEqual(3, quiz.NumOfQuestions, "Correct number of questions are displayed");
        }
    }
}

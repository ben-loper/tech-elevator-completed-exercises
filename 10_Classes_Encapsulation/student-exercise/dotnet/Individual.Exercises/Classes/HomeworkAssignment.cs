using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Individual.Exercises.Classes
{
    public class HomeworkAssignment
    {
        // Properties
        public int TotalMarks { get; set; }

        public int PossibleMarks { get; }

        public string SubmitterName { get; }

        // Derived property
        public string LetterGrade
        {
            get
            {
                double grade = (TotalMarks / (double)PossibleMarks) * 100;
                string letterGrade = "A";

                if(grade >= 80 && grade < 89)
                {
                    letterGrade = "B";
                }
                else if(grade >= 70 && grade <= 79)
                {
                    letterGrade = "C";
                }
                else if (grade >= 60 && grade <= 69)
                {
                    letterGrade = "D";
                } 
                else if (grade < 60)
                {
                    letterGrade = "F";
                }

                return letterGrade;
            }
        }

        public HomeworkAssignment(int possibleMarks, string submitterName)
        {
            PossibleMarks = possibleMarks;
            SubmitterName = submitterName;
        }
    }
}

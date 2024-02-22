using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamOOP
{
    internal abstract class Exam
    {
        #region Attributes
        public double examTime;
        public int numberOfQuestions;
        public Question[] examQusstionsList;

        #endregion
        
        //Constructor
        public Exam(double examTime, int numberOfQuestions)
        {
            this.examTime = examTime;
            this.numberOfQuestions = numberOfQuestions;
            examQusstionsList = new Question[numberOfQuestions];
        }
        //Abstraction
        public abstract void MakeExam();

        public  void StduentDoExam()
        {
            if (examQusstionsList is not null)
            {
                #region Student Perform the exam
                int GradesCounter = 0;
                int TotalGradesCounter = 0;
                for (int i = 0; i < examQusstionsList.Length; i++)
                {
                    examQusstionsList[i].ShowQandAnswers();
                    int Stanswer;
                    do
                    {
                        Console.WriteLine("Enter Your answer chioce");
                    } while (!int.TryParse(Console.ReadLine(), out Stanswer));
                    GradesCounter += examQusstionsList[i].CheckAnswer(Stanswer);
                    TotalGradesCounter += examQusstionsList[i].GetQGrade();
                }
                Console.WriteLine("Exam Finsihed"); 
                #endregion
                #region Exam Result
                for (int i = 0; i < examQusstionsList.Length; i++)
                {
                    Console.WriteLine($"Q{i+1}");
                    examQusstionsList[i].ShowQandAnswers();
                    examQusstionsList[i].ShowCorrectAnswer();
                    // GradesCounter+=examQusstionsList[i].CheckAnswer(Stanswer);
                }
                Console.WriteLine($"Your final Grade is: {GradesCounter}" +
                    $"out of {TotalGradesCounter}"); 
                #endregion
            }

        } 

    }
}

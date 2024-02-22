using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamOOP
{
    internal class FinalExam:Exam
    {
        public FinalExam(double examTime, int numberOfQuestions)
           : base(examTime, numberOfQuestions)
        {
            //Final Exam
        }

        public override void MakeExam()
        {
            for (int i = 0; i < numberOfQuestions; i++)
            {
                int McqOrTf;
                bool  GoodInput;
                int LocalGrade;
                #region T/f then Grade then Question Input
                do
                {
                    Console.WriteLine("Enter 1 For Mcq or 2 For T/F");
                    GoodInput = int.TryParse(Console.ReadLine(), out McqOrTf);
                } while ((!GoodInput) ||
                       (GoodInput && (McqOrTf < 1 || McqOrTf > 2)));
                do
                {
                    Console.WriteLine($"Enter Question {i + 1} Grade");
                } while (!int.TryParse(Console.ReadLine(), out LocalGrade));
                Console.WriteLine($"Enter The Question {i + 1}");
                string? QestionI = Console.ReadLine(); 
                #endregion
                if (McqOrTf==1)
                {  
                    examQusstionsList[i] = new McqQuestion(QestionI, LocalGrade);
                }
                else
                {    
                 examQusstionsList[i] = new TrurFalseQuestion(QestionI, LocalGrade);
                }
                
            }
        }

    }
}

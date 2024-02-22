using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamOOP
{
    internal class PracticalExam:Exam
    {
        public PracticalExam(double examTime, int numberOfQuestions)
            :base(examTime, numberOfQuestions)
        {
            //Practical Exam
        }

        public override void MakeExam()
        {
           for(int i=0; i<numberOfQuestions; i++)
           {
             
                int LocalGrade;
                do
                {
                    Console.WriteLine($"Enter Mcq Question {i + 1} Grade");
                } while (!int.TryParse(Console.ReadLine(), out LocalGrade));
                Console.WriteLine($"Enter Mcq Question {i + 1}");
                string? QestionI = Console.ReadLine();
                examQusstionsList[i] = new McqQuestion(QestionI,LocalGrade);
           }
        }

      
    }
}

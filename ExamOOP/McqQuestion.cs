using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamOOP
{
    internal class McqQuestion:Question
    {
        public McqQuestion(string body, int qGrade)
            : base(body, qGrade)
        {
            header = "Mcq Question";
            AnswersList = new Answer[3];
            SetAnswers();

        }

       

        public override void SetAnswers()
        {
            // Set Possible Solutions
            if (AnswersList is not null)
            {
                // Setting 3 Choices
                for (int i = 1; i <= 3; i++)
                {
                    // AnswersList[0] = new Answer(1, "True");
                    Console.WriteLine($"Enter Poosible Answer {i}");
                    string? PossibleAnswerTemp;
                    PossibleAnswerTemp = Console.ReadLine();
                    AnswersList[i - 1] = new Answer(i, PossibleAnswerTemp);
                }

                // Choose Correct Answer
                bool GoodInput;
                do
                {
                    Console.WriteLine("Enter the Correct Answer id 1,2 or 3");
                    GoodInput = int.TryParse(Console.ReadLine(), out CorrectAnswer);
                } while ((!GoodInput) || 
                (GoodInput && (CorrectAnswer < 1) || (CorrectAnswer > 3)));
            }
        }
    }
}

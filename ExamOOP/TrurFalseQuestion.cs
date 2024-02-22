using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamOOP
{
    internal class TrurFalseQuestion : Question
    {
        public TrurFalseQuestion( string body, int qGrade)
            :base(body,qGrade)
        {
            header = "True False Question";
            AnswersList = new Answer[2];
            AnswersList[0] = new Answer(1, "True");
            AnswersList[1] = new Answer(2, "False");
            SetAnswers();
            
        }

        

        public override void SetAnswers()
        {
            bool GoodInput;
            do
            {
                Console.WriteLine("Enter the Correct Answer 1 For True" +
                    "Or 2 For False");
                GoodInput = int.TryParse(Console.ReadLine(), out CorrectAnswer);
            } while ((!GoodInput) ||
            (GoodInput && (CorrectAnswer < 1) || (CorrectAnswer > 2)));
           
        }
    }
}

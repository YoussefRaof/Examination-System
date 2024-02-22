using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamOOP
{
    internal abstract class Question
    {
        #region Attributes
        public string? header;
        public string? body;
        public int qGrade;
        public Answer[]? AnswersList;
        public int CorrectAnswer; 
        #endregion
        //Constructor
        public Question(string body, int qGrade)
        {
            this.body = body;
            this.qGrade = qGrade;
        }
        public abstract void SetAnswers();
        public void ShowQandAnswers()
        {
            if (AnswersList is not null)
            {
                Console.WriteLine(header);
                Console.WriteLine(body);
                for (int i = 0; i < AnswersList.Length; i++)
                {
                    AnswersList[i].ShowAnswer();
                }
            }
        }
        public void ShowCorrectAnswer()
        {
            if (AnswersList is not null)
            {
                Console.WriteLine("The Right Answer is ");
                AnswersList[CorrectAnswer-1].ShowAnswer();
            }
        }
        public int CheckAnswer(int ChosenAnswerid)//Returns Answer Grade
        // If Right Return Grade else Return 0
        {
            if (ChosenAnswerid == CorrectAnswer)
            {
                return qGrade;
            }
            else
                return 0;
        }
        public int GetQGrade()
        {
            return qGrade;
        }

        public int AnswersCount()
        {
            if (AnswersList is not null)
                return AnswersList.Length;
            else
                return -1;
        }

    }
}

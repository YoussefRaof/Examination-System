using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamOOP
{
    internal class Answer
    {
        int id;
        string? answer;

        public Answer(int id,string answer)
        {
            this.id = id;
            this.answer = answer;
        }
        public void ShowAnswer()
        {
            Console.WriteLine($"Choice {id} is {answer}");
        }
    }
}

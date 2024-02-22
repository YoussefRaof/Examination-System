using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamOOP
{
    internal class Subject
    {
        int subjId;
        string? subjName;
        Exam? subjExam;
        public Subject(int subjId, string? subjName)
        {
            this.subjId = subjId;
            this.subjName = subjName;
            
        }

        public void CreateExam()
        {
            bool GoodInput;
            int ExamType;
            int ExamQCountVar;
            double ExamTimeVar;
            #region Choose Exam Type
            do
            {
                Console.WriteLine("Enter 1 To Create Final Exam" +
                    "Or 2 For Practical Exam");
                GoodInput = int.TryParse(Console.ReadLine(), out ExamType);
            } while ((!GoodInput)
              || (GoodInput && (ExamType < 1) || (ExamType > 2)));
            #endregion
            do
            {
                Console.WriteLine("Enter Time of Exam");
                GoodInput = double.TryParse(Console.ReadLine(), out ExamTimeVar);
            } while ((!GoodInput)
             || (GoodInput && (ExamType < 1) || (ExamType > 2)));
            
            do
            {
                Console.WriteLine("Enter Number of Questions of Exam");
                GoodInput = int.TryParse(Console.ReadLine(), out ExamQCountVar);
            } while (!GoodInput);

            if (ExamType== 1)
            {
                subjExam = new FinalExam(ExamTimeVar,ExamQCountVar);
            }
            else
            {
                subjExam = new PracticalExam(ExamTimeVar, ExamQCountVar);
            }
            subjExam.MakeExam();
        }

        public void DoSubjExam()
        {
            if(subjExam!= null) 
            {
                subjExam.StduentDoExam();
            }
        }
    }
}

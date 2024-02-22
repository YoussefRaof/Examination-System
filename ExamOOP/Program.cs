using System.Diagnostics;

namespace ExamOOP
{
    #region TESTING FOR ME Not Fot You
    // Don't Look I was just testing 
    //internal abstract class Parent
    //{
    //    public int id;
    //    public string? name;
    //    public Parent(int id, string? name)
    //    {
    //        this.id = id;
    //        this.name = name;
    //        Console.WriteLine("Parent");
    //    }

    //    public void Do()
    //    {
    //        Console.WriteLine("Parent");
    //    }
    //    public abstract void DoSon();
    //}
    //class Son : Parent
    //{
    //    public int id3;
    //    public Son(int id3, int idP, string name) : base(id3, name)
    //    {
    //        this.id3 = id3;
    //    }

    //    public override void DoSon()
    //    {
    //        Console.WriteLine("Son");
    //    }
    //} 
    #endregion
    internal class Program
    {
        static void Main(string[] args)
        {
            #region InputTesingNotForYou
            /*
               Don't Look I was just testing
               bool GoodInput;
               do
               {
                   Console.WriteLine("Enter the Correct Answer id");
                    GoodInput = int.TryParse(Console.ReadLine(), out CorrectAnswer);
               } while ((!GoodInput)||(GoodInput&&(CorrectAnswer <1)||(CorrectAnswer >3)));
               */
            #endregion

            Subject s1 = new Subject(10, "C#");
            s1.CreateExam();
            Console.Clear();
            char DoExamYN;
            do
            {
                Console.WriteLine("Enter y To Do The Exam" +
                    "Or Any Other Cahr to Stop");
            } while (!char.TryParse(Console.ReadLine(),out DoExamYN));
            if (DoExamYN=='y')
            {
                Console.WriteLine("Exam Satrted");
                Stopwatch sw = new Stopwatch();
                sw.Start();
                s1.DoSubjExam();
                Console.WriteLine(sw.Elapsed);
            }
        }
    }
}
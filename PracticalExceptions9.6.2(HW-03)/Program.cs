
using System.Runtime.InteropServices;
class Program
{
namespace ProgramExceptionTwo;
public class ExceptionTwo
{
    public int input = Convert.ToInt32(Console.ReadLine());
    public delegate void MethodContainer();
    public event MethodContainer input;

    class EventOne
    {

        public void Message()
        {
            ExceptionTwo exceptiontwo = new ExceptionTwo();
            if (exceptiontwo.input == 1)
                input();
                Console.WriteLine("You have chosen the first method");
        }

    }
    class EventTwo
    {
        public void Message()
        {
            ExceptionTwo exceptiontwo = new ExceptionTwo();
            if (exceptiontwo.input == 2)
                Console.WriteLine("You have chosen the first method");
        }

    }
}

    static void Main(string[] args)
    {
    ExceptionTwo input = new ExceptionTwo();
        EventOne eventOne = new EventOne();
        EventTwo eventTwo = new EventTwo();

        Counter.input += Handler1.Message;
        Counter.input += Handler2.Message;

        //Запустили счетчик
        Counter.input();
    }
}
using System.Runtime.ConstrainedExecution;

namespace CsharpPracticeSession3._2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Built-in function call
            // className.functionName(Parameter)

            //Math.Cos(90);
            //Math.Pow(2, 3);
            //Console.WriteLine("Print");
            ////Console.Clear();

            //double result = Math.Cos(90);
            //Console.WriteLine(result);

            //Console.WriteLine(Math.Pow(2, 3));

            ////////////////////////////////////////////
            ///

            //Console.WriteLine("Enter number: ");
            //float userInput = float.Parse(Console.ReadLine());

            //double result = Math.Cos(userInput);
            //Console.WriteLine(result);

            ////////////////////////////////////////////
            ///

            //Console.WriteLine("Enter base number: ");
            //float baseNumber = float.Parse(Console.ReadLine());

            //Console.WriteLine("Enter powr number: ");
            //float powerNumber = float.Parse(Console.ReadLine());

            //double result = Math.Pow(baseNumber, powerNumber);
            //Console.WriteLine(result);

            ////////////////////////////////////////////
            ///

            //DateTime currentTiming = DateTime.Now;
            //Console.WriteLine(currentTiming);

            //DateTime timing = DateTime.Today;
            //Console.WriteLine(timing);

            //DateTime startSub = DateTime.Today;
            //DateTime endSub = startSub.AddDays(30);
            //Console.WriteLine("Your subscription ends on: " + endSub);

            ////////////////////////////////////////////
            ///

            // String function format

            Console.WriteLine("Enter a word: ");
            string word = Console.ReadLine();

            // String word = "Hello, world!"
            int length = word.Length; // returns 13
                        /* word.Substring(7, 5);*/    // returns "world"
            string upperedWord = word.ToUpper(); // returns "HELLO, WORLD!"
            string loweredWord = word.ToLower(); // returns "hello, world!"
        }
    }
}

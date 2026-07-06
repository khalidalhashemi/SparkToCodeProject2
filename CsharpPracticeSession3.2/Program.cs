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

            Console.WriteLine("Enter number: ");
            float userInput = float.Parse(Console.ReadLine());

            double result = Math.Cos(userInput);
            Console.WriteLine(result);
        }
    }
}

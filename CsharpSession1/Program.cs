namespace CsharpSession1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Input & Output Program

            //Console.WriteLine("Welcome to Spark to Code!");

            //Console.WriteLine("Please enter your name: ");
            //string name = Console.ReadLine();
            //Console.WriteLine("Hello, " + name + " Nice to meet you.");

            //Console.WriteLine("Please enter your age: ");
            //int age = int.Parse(Console.ReadLine());
            //Console.WriteLine("You are " + age + " years old.");

            //Console.WriteLine("Please enter your height: ");
            //float height = float.Parse(Console.ReadLine());
            //Console.WriteLine("Yor are " + height + " meters");
            ///////////////////////////////////////////////////////////////////////////////////



            // Operations Program

            Console.WriteLine("Enter first number: ");
            float num1 = float.Parse(Console.ReadLine());

            Console.WriteLine("Enter second number: ");
            float num2 = float.Parse(Console.ReadLine());

            float SumResult = num1 + num2;
            float SubResult = num1 - num2;
            float MulResult = num1 * num2;
            float DivResult = num1 / num2;

            bool ComparisonResult = num1 > num2;
            bool ComparisonResult2 = num1 == num2;

            Console.WriteLine("Your Sum is: " + SumResult);
            Console.WriteLine("Your Sub is: " + SubResult);
            Console.WriteLine("Your Mul is: " + MulResult);
            Console.WriteLine("Your Div is: " + DivResult);

            Console.WriteLine("Is the first number greater than the second? " + ComparisonResult);
            Console.WriteLine("Are the two numbers equal? " + ComparisonResult2);
            ///////////////////////////////////////////////////////////////////////////////////
        }
    }
}

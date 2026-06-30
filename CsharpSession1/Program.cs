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

            //Console.WriteLine("Enter first number: ");
            //float num1 = float.Parse(Console.ReadLine());

            //Console.WriteLine("Enter second number: ");
            //float num2 = float.Parse(Console.ReadLine());

            //float SumResult = num1 + num2;
            //float SubResult = num1 - num2;
            //float MulResult = num1 * num2;
            //float DivResult = num1 / num2;

            //bool ComparisonResult = num1 > num2;
            //bool ComparisonResult2 = num1 == num2;

            //Console.WriteLine("Your Sum is: " + SumResult);
            //Console.WriteLine("Your Sub is: " + SubResult);
            //Console.WriteLine("Your Mul is: " + MulResult);
            //Console.WriteLine("Your Div is: " + DivResult);

            //Console.WriteLine("Is the first number greater than the second? " + ComparisonResult);
            //Console.WriteLine("Are the two numbers equal? " + ComparisonResult2);
            ///////////////////////////////////////////////////////////////////////////////////



            // if-else Program

            //Console.WriteLine("Enter your test degree: ");
            //float degree = float.Parse(Console.ReadLine());

            //if (degree >= 0 && degree <= 20)
            //{
            //    Console.WriteLine("Failed the test.");
            //}
            //else if (degree > 20 && degree <= 50)
            //{
            //    Console.WriteLine("Good result.");
            //}
            //else if (degree > 50 && degree <= 80)
            //{
            //    Console.WriteLine("Very good result.");
            //}
            //else if (degree > 80 && degree <= 100)
            //{
            //    Console.WriteLine("Excellent result.");
            //}
            //else
            //{
            //    Console.WriteLine("Invalid degree.");
                ///////////////////////////////////////////////////////////////////////////////////



                // Switch Program

                Console.WriteLine("Welcome, Please pick your favorite color from the list: ");
                Console.WriteLine("1. Red");
                Console.WriteLine("2. Blue");
                Console.WriteLine("3. Green");
                Console.WriteLine("4. Yellow");
                Console.WriteLine("5. othet");

                int option = int.Parse(Console.ReadLine());

                switch (option)
                {
                    case 1: 
                        Console.WriteLine("Your favorite color is Red.");
                        break;

                    case 2:
                        Console.WriteLine("Your favorite color is Blue.");
                        break;

                    case 3:
                        Console.WriteLine("Your favorite color is Green.");
                        break;

                    case 4:
                        Console.WriteLine("Your favorite color is Yellow.");
                        break;

                    case 5:
                        Console.WriteLine("Your favorite color is something else.");
                        break;

                    default:
                        Console.WriteLine("Invalid option.");
                        Console.WriteLine("Please select a valid option from the list.");
                        break;
                }
        }
    }
}

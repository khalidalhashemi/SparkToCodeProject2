namespace CsharpSession3._1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Looping Codes

            // For Loop statement

            //int counter = 0;

            //for(counter = 10; counter >= 1; counter--)
            //{
            //    Console.WriteLine("Your count start: " + counter);
            //}

            //Console.WriteLine("Counter finished! ");

            ////////////////////////////////////////////////////////////////////////////////
            ///


            // While Loop


            bool exitDecision = false;
            string userInput;

            while (exitDecision == false)
            {
                Console.WriteLine("print menu");

                Console.WriteLine("Do you want to exit? (yes/no)");
                userInput = Console.ReadLine();

                if (userInput == "yes")
                {
                    exitDecision = true;
                }
            }

            ////////////////////////////////////////////////////////////////////////////////

        }
    }
}

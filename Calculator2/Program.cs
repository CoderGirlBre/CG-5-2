using System;

namespace Calculator2
{
    class Program
    {
        static void Main(string[] args)
        {
            //Title
            Console.WriteLine("Calculator");

            //In this line I am asking the user to input a number.
            Console.Write("First number: ");

            //Now, I am assigning the number to a variable called firstNumber.
            string firstNumber = Console.ReadLine();

            //In this line I am asking the user to input another number.
            Console.Write("Second number: ");

            //Now, I am assigning the second number to a variable called secondNumber.
            string secondNumber = Console.ReadLine();

            //Converting the numbers the user entered from strings to integers.
            int first = int.Parse(firstNumber);
            int second = int.Parse(secondNumber);

            //Here, I am asking the user what they would like to do with their two numbers.
            Console.Write("add, subtract, multiply, or divide: ");

            //Now, I am assigning the mathmatical operation to a variable called operation.
            string operation = Console.ReadLine();

            
            //Lines 36 - 59: I am calling and printing the value of the method that corresponds to the operation that the user requested.
            if (operation == "add")
            {
               Console.WriteLine("Answer: " + Addition(first, second));
                Console.ReadLine();
                
            }
            else if (operation == "subtract")
            {
                Console.WriteLine("Answer: " + Subtraction(first, second));
                Console.ReadLine();
            }
            else if (operation == "multiply")
            {
                Console.WriteLine("Answer: " + Multiplication(first, second));
                Console.ReadLine();
            }
            else if (operation == "divide")
            {
                Console.WriteLine("Answer: " + Division(first, second));
                Console.ReadLine();
            }
            else
            Console.WriteLine("Sorry, we didn't understand what you entered.");
            Console.ReadLine();
        }


        /// <summary>
        /// This method will add the user's two numbers together.
        /// </summary>
        /// <param name="first"></param>
        /// <param name="second"></param>
        /// <returns> The answer to the user's two numbers being added. </returns>
        private static int Addition(int first, int second)
        {
            return (first + second);
        }

        /// <summary>
        /// This method subtracts the user's two numbers. 
        /// </summary>
        /// <param name="first"></param>
        /// <param name="second"></param>
        /// <returns> The answer to the user's two numbers being subtracted. </returns>
        private static int Subtraction(int first, int second)
        { 
            return (first - second);    
        }
        /// <summary>
        /// This method multiplies the user's two numbers.
        /// </summary>
        /// <param name="first"></param>
        /// <param name="second"></param>
        /// <returns> The answer to the user's two numbers being multiplied. </returns>
        private static int Multiplication(int first, int second)
        {
            return (first * second);
        }

        /// <summary>
        /// Divides the user's two numbers.
        /// </summary>
        /// <param name="first"></param>
        /// <param name="second"></param>
        /// <returns> The answer to the users two numbers being divided. </returns>
        private static int Division(int first, int second)
        {
            return (first / second);
        }
    } 
}

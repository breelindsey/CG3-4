using System;

namespace CG3_4
{
    class Program
    {
        static void Main(string[] args)
        {
            /* Create a simple calculator that asks the user to input two different numbers and 
             whether they want to add, subtract, multiple or divide them. 
             Output the answer back to the console.
             Be sure to include clear code comments to make your code readable to other programmers and your future self.
             Upload your program to a new repository called CG 3 - 4.  */
        

            //In these first two lines, I am declaring my variables. 
            int firstNumber, secondNumber, answer;
            string operators;

            //This is a title for my calculator.
            Console.WriteLine("Bree's Calculator");

            /*Here I am asking the user for the first number to be calculated, parsing that value into an integer,
            and then telling the program to print the number. */
            Console.WriteLine("Enter the first number: ");
            firstNumber = int.Parse(Console.ReadLine());

            //Here I am asking the user which operator they would like to use, and then telling the program to print the operator.
            Console.WriteLine("Choose an operator: *, -, +, /, or %. ");
            operators = Console.ReadLine();

            /*Here I am asking the user for the second number to be calculated, parsing that value into an integer,
            and then telling the program to print the number. */
            Console.WriteLine("Enter the second number: ");
            secondNumber = int.Parse(Console.ReadLine());

            //From here I am giving the program instructions on what to do with the user input.
            if (operators == "*")
            {
                answer = firstNumber * secondNumber;
                Console.WriteLine(answer);
            }
            else if (operators == "/") 
            {
                answer = firstNumber / secondNumber;
                Console.WriteLine(answer);
            }
            else if (operators == "+")
            {
                answer = firstNumber + secondNumber;
                Console.WriteLine(answer);
            }

            else if (operators == "-")
            {
                answer = firstNumber - secondNumber;
                Console.WriteLine(answer);
            }


            else if (operators == "%")
            {
                answer = firstNumber % secondNumber;
                Console.WriteLine(answer);
            }
            Console.ReadLine();













        }
    }
}

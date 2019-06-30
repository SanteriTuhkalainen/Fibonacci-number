using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fibonacci_number
{
    class Program
    {
        static void Main(string[] args)
        {
            //Here we initialize the first two numbers.
            int number1 = 0;
            int number2 = 1;

            //Here we create the third number that we will need later.
            int number3;
            
            //First we print out the two first numbers.
            Console.WriteLine(number1);
            Console.WriteLine(number2);



            //Here we start a loop that prints out 10 more numbers of the sequence.
            for (int i = 0; i < 10; i++)
            {
                //Here we give number3 a value. This value will now be 0+1 so 1 at first. 
                //After that number3 will start to grow as we give number1 and number2 new values.
                number3 = number1 + number2;

                //Here we print number3 current value.
                Console.WriteLine(number3);

                //Here number1 gets a new value (on the first loop it gets the value of 1).
                number1 = number2;
                //Here number2 gets a new value (on the first loop it gets the value of 1).
                number2 = number3;

                //As the loop begins again with the new values for number1 and number2, number3 will start to grow as wanted.



            }
            //Here we stop the program to display the results of the loop.
            Console.ReadLine();




        }
    }
}

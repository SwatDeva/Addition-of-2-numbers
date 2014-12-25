using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Addition_of_2_numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            Program program = new Program();
            
            Console.WriteLine("The sum of number1 and number2 is " + program.addTwoNumbers(2, 3));
        }


        private int addTwoNumbers(int number1, int number2)
        {
            return number1 + number2;
        }
    }
}

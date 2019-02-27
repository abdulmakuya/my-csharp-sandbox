using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practical_test
{   
    class Operations
    {   //member variables
        protected int sum;

        //member functions
        public int summation(int a,int b,int c)
         {
            sum = a + b + c;
            return sum;
         }

        public void swapping(int a,int b)
        {
            int temporary = b;
            b = temporary;
            b = a;
            a = temporary;

            Console.WriteLine("Value after swapping");
            Console.WriteLine("Value of first number is now:" + a);
            Console.WriteLine("Value of second number is now:" + b);
        }

        public void basic_ops(int a,int b)
        {
            int product = a * b;
            Console.WriteLine("The product is:" + product);

            int division = a / b;
            Console.WriteLine("The division is:" + division);

            int remainder = a % b;
            Console.WriteLine("The division is:" + division);


        }
    }
    
    class Program
    {
        public int selection,user_selection;

        protected static int user_Menu()
        {
            Console.WriteLine("Enter the operation you want to perfom");
            Console.WriteLine("1. Summation");
            Console.WriteLine("2. Swapping");
            Console.WriteLine("3. Basic Ops (multiplication,division,remainder)");
            Console.WriteLine("4. Exit");

            int selection = Convert.ToInt32(Console.ReadLine());
            return selection;
        }

        static void Main(string[] args)
        {
            int user_selection,num1,num2,num3,answer;
            //Operations my_op = new Operations();

            do{   
                user_selection = user_Menu();
                switch (user_selection)
                {
                    case 1:
                        Console.WriteLine("You are attempting to make summation");
                        Console.WriteLine("Please enter the first number");
                        num1 = Convert.ToInt32(Console.ReadLine());

                        Console.WriteLine("Please enter the second number");
                        num2 = Convert.ToInt32(Console.ReadLine());

                        Console.WriteLine("Please enter the third number");
                        num3 = Convert.ToInt32(Console.ReadLine());

                        Operations my_op = new Operations();
                        answer = my_op.summation(num1, num2, num3);
                        Console.WriteLine("The sum of the numbers is:" + answer);

                        break;

                    case 2:
                        Console.WriteLine("You are attempting to make swapping");

                        Console.WriteLine("Please enter the first number");
                        num1 = Convert.ToInt32(Console.ReadLine());

                        Console.WriteLine("Please enter the second number");
                        num2 = Convert.ToInt32(Console.ReadLine());

                        Operations my_op2 = new Operations();
                        my_op2.swapping(num1, num2);

                        break;

                    case 3:
                        Console.WriteLine("You are attemping to do all basic operations");

                        Console.WriteLine("Please enter the first number");
                        num1 = Convert.ToInt32(Console.ReadLine());

                        Console.WriteLine("Please enter the second number");
                        num2 = Convert.ToInt32(Console.ReadLine());

                        Operations my_op3 = new Operations();
                        my_op3.basic_ops(num1,num2);


                        break;                          
                }
            } while (user_selection != 4);
        }
    }
}

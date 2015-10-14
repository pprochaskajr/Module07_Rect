using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module07_Rect
{
    class TestClass
    {
        static void Main(string[] args)
        {
            // sum two integers and save the result
            int num1 = 10, num2 = 20, sum;
            int length = 4, width = 5;
            int numba = 25, numbb = 50, numbc = 75;
            sum = num1 + num2;
            Console.WriteLine("1. Sum two integers");
            Console.WriteLine();
            Console.WriteLine("First number = {0} ,second number = {1}, sum = {2}", num1, num2, sum);
            Console.WriteLine();

            Console.WriteLine("2. Sum two integers using Add method");
            Console.WriteLine();
            Console.WriteLine("From method Add - First number = {0} ,second number = {1}, sum = {2}", numba, numbb, Add(numba,numbb));
            Console.WriteLine();

            Console.WriteLine("3. Sum three integers using overloaded Add method");
            Console.WriteLine();
            Console.WriteLine("From method Add - First number = {0} ,second number = {1}, third number = {2}, sum = {3}", numba, numbb, numbc, Add(numba, numbb, numbc));
            Console.WriteLine();

            Console.WriteLine("3. Return value from call to method RectangleArea");
            Console.WriteLine();
            Rectangle areaNew = new Rectangle();
            Console.WriteLine("From public method RectangleArea in Rectangle class length = {0} , width = {1}, area = {2}", 
                               length, width, areaNew.RectangleArea(4,5));
            Console.WriteLine();
            Console.ReadKey();

            
        }
            // sum two integers and return the result
            public static int Add(int number1, int number2)
         {

           return(number1 + number2);
         }

            // sum three integers and return the result
            public static int Add(int number1, int number2, int number3)
            {

                return (number1 + number2+ number3);
            }
    }

    class Rectangle
    {
        int length, width;

        public Rectangle(int l, int w)  //  constructor 
        { 
            this.length = l;
            this.width = w;  
        }
  
        public Rectangle() {
            // default constructor 
        }

        public int Length
        {
            get
            {
                return length;
            }

            set
            {
                length = 0;
            }

        }

        public int Width
        {
            get
            {
                return width;
            }

            set
            {
                width = 0;
            }

        }

        public int RectangleArea(int len, int wid)
        {

            return (len * wid);

        }



    }
}

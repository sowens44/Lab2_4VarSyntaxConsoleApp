using System;

namespace Lab2_4VarSyntaxConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            // Lab 2_4 Var Syntax
            //int myFirstNumber = 19;
            //int mySecondNumber = 244;
            //Console.WriteLine(myFirstNumber * mySecondNumber);
            Console.WriteLine("Hello World2333!!");
            int myFirstNumber = 19;
            int mySecondNumber = 244;
            Console.WriteLine(myFirstNumber * mySecondNumber);
            string mytext = "Some Text";
            Console.WriteLine(mytext + mySecondNumber);
            Console.WriteLine(mytext + "" + mySecondNumber);
            // 6
            string moreText = "Goes Here";
            Console.WriteLine(mytext + "" + moreText);
            Console.WriteLine($"{mytext} {moreText}");

            string color1 = "Yellow";
            string color2 = "Red";

            bool isYellow = true;
            bool isGreen = false;

            Console.WriteLine(color1 + "" + isYellow + "" + color2 + "" + isGreen);
            Console.WriteLine($"{color1} {isYellow} {color2} {isGreen}");

            double numbers;
            //12
            numbers = mySecondNumber / myFirstNumber;

            Console.WriteLine(numbers);
            //14
            numbers = mySecondNumber / (double)myFirstNumber;
            //15
            Console.WriteLine(numbers);

            //16
            Console.WriteLine("Breakpoint Here");
            //17
            string textToNumber = "80473";

            //18
            int results = 99 * int.Parse(textToNumber);
            //19
            DateTime rightNow = DateTime.Now;



        }
    }
}


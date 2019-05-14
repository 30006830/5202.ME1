using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5202.ME1
{
    public class Program
    {
        public static void Main()
        {
            Task1();
        }

        static void Task1()
        {
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("BMI Calculator. This program will take your weight and height");
            Console.WriteLine("Enter your weight (kg's): ");
            double weight = double.Parse(Console.ReadLine());
            Console.WriteLine("Enter your height (metres): ");
            double height = double.Parse(Console.ReadLine());

            double total = bmi(weight, height);
            Console.WriteLine(total);
            Task2(total);
            Console.ReadLine();
        }

        static double bmi(double w, double h)
        {
            return Math.Round(w / (h * h), 1);
        }

        static void Task2(double BMI)
        {
            if(BMI >= 30)
                Console.WriteLine("You seriously need to cut down on the cheeseburgers.");
            else if(BMI >= 25 && BMI < 30)
                Console.WriteLine("To the gym with you! >:3");
            else if(BMI >= 18.5 && BMI <25)
                Console.WriteLine("Nice. Thats a good spot, now stay there.");
            else
                Console.WriteLine("Bruh what are you a toothpick?");
        }
    }
}

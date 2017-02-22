using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 * CITP180 - Assignment 4
 * Programming Exercises, Problems 1, 3, 4, and 9 in chapter 5
 */

namespace assignment04
{
    class Program
    {
        static void Main(string[] args)
        {
            displayProblem(1);
            problem1();
            displayProblem(3);
            problem3();
            displayProblem(4);
            problem4();
            displayProblem(9);
            problem9();
        }

        public static void problem1()
        {
            /*
            1. Write an application that will enable you to display an aquarium’s pH level. The
            pH is a measure of the aquarium water’s alkalinity and is typically given on a 0-14
            scale. For most freshwater fish tanks, 7 is neutral. Tanks with a pH lower than 7
            are considered acidic. Tanks with a pH higher than 7 are alkaline. Allow the user
            to input the pH level number. Display a message indicating the health (i.e.,
            acidic, neutral, or alkaline) of the aquarium.
            */

            Console.WriteLine("What is the PH?: ");
            var userPH = Console.ReadLine();

            int ph = int.Parse(userPH);

            if (ph > 0 && ph < 8)
                Console.WriteLine("PH is acidic.");
            else if (ph > 7 && ph < 15)
                Console.WriteLine("PH is alkaline.");
            else
                Console.WriteLine("Invalid ph level, must be between 1 and 14.");
        }

        public static void problem3()
        {
            /*
            Write a program to calculate and display a person’s Body Mass Index (BMI).
            BMI is an internationally used measure of obesity. Depending on where you live,
            either use the Imperial BMI formula or the Metric Imperial Formula. Once the
            BMI is calculated, display a message of the person’s status. Prompt the user for
            both their weight and height. The BMI status categories, as recognized by the
            U.S. Department of Health & Human Services, are shown in the table below:

            BMI Weight Status
            Below 18.5 Underweight
            18.5 - 24.9 Normal
            25 - 29.9 Overweight
            30 & above Obese
            */

            Console.WriteLine("What is your height in meters?: ");
            var height = float.Parse(Console.ReadLine());
            Console.WriteLine("What is your weight in kilograms?: ");
            var weight = int.Parse(Console.ReadLine());

            var bmi = weight / (height * height);

            if (bmi > 0 && bmi <= 18.5)
                Console.WriteLine("BMI = Underweight");
            else if (bmi > 18.5 && bmi <= 24.9)
                Console.WriteLine("BMI = Normal");
            else if (bmi >= 24.9 && bmi <= 29.9)
                Console.WriteLine("BMI = Overweight");
            else if (bmi > 29.9)
                Console.WriteLine("BMI = Obese");
            else
                Console.WriteLine("Invalid BMI level.");
        }

        public static void problem4()
        {
            /*
            4. Write a program that calculates the take-home pay for an employee. The two
            types of employees are salaried and hourly. Allow the user to input the employee
            first and last name, id, and type. If an employee is salaried, allow the user to input
            the salary amount. If an employee is hourly, allow the user to input the hourly rate
            and the number of hours clocked for the week. For hourly employees, overtime is
            paid for hours over 40 at a rate of 1.5 of the base rate. For all employees’ takehome
            pay, federal tax of 18% is deducted. A retirement contribution of 10% and a
            Social Security tax rate of 6% should also be deducted. Use appropriate constants.
            Design an object-oriented solution. Create a second class to test your design.
            */

            // create new employee object
            employee emp1 = new employee();

            const double tax = 0.66; // salary percentage - total taxes and contributions

            Console.WriteLine("What is your name?");
            var emp1nm = Console.ReadLine();
            emp1.setName(emp1nm);

            Console.WriteLine("What is your hourly rate?");
            var emp1rate = double.Parse(Console.ReadLine());
            emp1.setRate(emp1rate);

            Console.WriteLine("How many hours did you work?");
            var emp1hr = double.Parse(Console.ReadLine());
            emp1.setHR(emp1hr);

            string employeeName = emp1.getName();
            double employeeSalary = (emp1.getHR() * emp1.getRate()) * tax;

            Console.WriteLine("Employee Name :\t\t" +  employeeName);
            Console.WriteLine("Salary        :\t\t" +  employeeSalary.ToString("C"));
        }

        public static void problem9()
        {
            /*
            9. Two fuel stops, CanadianFuel and AmericanFuel, are positioned near the U.S.–
            Canadian border. At the Canadian station, gas is sold by the liter. On the
            American side, it is sold by the gallon. Write an application that allows the user
            to input information from both stations and make a decision as to which station
            offers the most economical fuel price. Test your application with 1.259 per liter
            against 4.50 per gallon. Once the decision is made, display the equivalent prices.
            */
            Console.WriteLine("Max Gas Tank Size in Gallons: ");
            float gallons = float.Parse(Console.ReadLine());

            double ac;
            double cc;
            double ag = 4.5; // american gallon cost
            const double cg = 1.259; // canadian gallon cost   

            ac = gallons * ag;

            // liters to gallons
            double liters = gallons * 3.78;
            cc = liters * cg;

            Console.WriteLine("Cost of refilling your tank in Canada:   " + ac.ToString("C"));
            Console.WriteLine("Cost of refilling your tank in America:  " + cc.ToString("c"));
        }

        public static void displayProblem(int problemNumber)
        {
            Console.WriteLine("\n/// Problem " + problemNumber);
        }
    }

    public class employee
    {
        public string nm; // name
        public string et; // employee type
        public double samt; // salary amount
        public double hr;
        public double rate;

        public employee()
        {
            nm = "";
            et = "";
            samt = 0;
            hr = 0;
            rate = 0;
        }
        public void setName(string name)
        {
            nm = name;
        }
        public string getName()
        {
            return nm;
        }
        public void setRate(double hourlyRate)
        {
            rate = hourlyRate;
        }
        public double getRate()
        {
            return rate;
        }
        public void setHR(double hours)
        {
            hr = hours;
        }
        public double getHR()
        {
            return hr;
        }
    }
}
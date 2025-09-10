// HW1b Grade

// Your Name: Elizabeth Grimes
// Did you seek help ? If yes, specify the helper or web link here: TA

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW1b_Grade
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What is your first name?");
            string firstName = Console.ReadLine();  

            Console.WriteLine("What is your last name?");   
            string lastName = Console.ReadLine();

            Console.WriteLine("What is your student id?");
            string studentId = Console.ReadLine();

            Console.WriteLine("What is your overall percentage grade for homework?");
            string homeworkGrade = Console.ReadLine();

            Console.WriteLine("What is your overall percentage grade for participations?");
            string participationGrade = Console.ReadLine();

            Console.WriteLine("What is your overall percentage grade for quizzes?");
            string quizGrade = Console.ReadLine();

            Console.WriteLine("What is your overall percentage grade for midterm?");
            string midtermGrade = Console.ReadLine();

            Console.WriteLine("What is your overall percentage grade for final?");
            string finalGrade = Console.ReadLine();

            Console.WriteLine(firstName + " " + lastName + " " + studentId + " "  + finalGrade);

            Console.ReadKey();
        }
    }
}

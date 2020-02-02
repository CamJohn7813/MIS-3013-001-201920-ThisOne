using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_1__2nd_question_
{
    class Program
    {
        static void Main(string[] args)
        {
            string firsName, lastName;
            int id;
            //overall percentage grade
            double quizzes, participations, homeworks, midterm, finalexam;
            Console.Write("Enter first name: ");
            firsName = Console.ReadLine();
            Console.Write("Enter last name: ");
            lastName = Console.ReadLine();
            Console.Write("Enter student id: ");
            id = int.Parse(Console.ReadLine());
            Console.Write("Enter quizzes percentage: ");
            quizzes = double.Parse(Console.ReadLine());
            Console.Write("Enter participations percentage: ");
            participations = double.Parse(Console.ReadLine());
            Console.Write("Enter midterm percentage: ");
            midterm = double.Parse(Console.ReadLine());
            Console.Write("Enter homeworks percentage: ");
            homeworks = double.Parse(Console.ReadLine());
            Console.Write("Enter finalexam percentage: ");
            finalexam = double.Parse(Console.ReadLine());
            double finalGrade = (quizzes + participations + homeworks + midterm + finalexam) / 5;
            Console.WriteLine("Final grade: " + finalGrade.ToString("F") + "%");
            //pause
            Console.ReadLine();

        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Marksheet
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Your Name: ");
            string name= Console.ReadLine();
            Console.WriteLine("Enter Your Roll No: ");
            string rollNo= Console.ReadLine();
            Console.WriteLine("Enter Your Class: ");
            string clas= Console.ReadLine();
            Console.WriteLine("Enter English Marks: ");
            int english = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter Hindi Marks: ");
            int hindi = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter Math Marks: ");
            int math = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter Urdu Marks: ");
            int urdu = int.Parse(Console.ReadLine());

            int obtain = english + hindi + math + urdu;
            int percentage = obtain * 100 / 400;

            Console.WriteLine("----------Marksheet Generated--------");
            Console.WriteLine($"Your Name is {name}");
            Console.WriteLine($"Your Class is {clas}");
            Console.WriteLine($"Your ROll No. is {rollNo}");
            Console.WriteLine($"Your Total Marks is {obtain}");
            Console.WriteLine($"Your Percentage is {percentage}%");


            //Grades
            if (percentage > 90)
            {
                Console.WriteLine("Grade : A++");
            }
            else if (percentage > 80)
            {
                Console.WriteLine("Grade : A+");

            }
            else if (percentage > 70)
            {
                Console.WriteLine("Grade : A");
            }
            else if (percentage > 60)
            {
                Console.WriteLine("Grade : B");
            }
            else if (percentage > 50)
            {
                Console.WriteLine("Grade : C");
            }
            else
            {
                Console.WriteLine("Grade : Fail");
            }

            //Remakrs 
            if (percentage > 90)
            {
                Console.WriteLine("Remarks: Excellent");
            }
            else if (percentage > 80)
            {
                Console.WriteLine("Remarks: Good");

            }
            else if (percentage > 70)
            {
                Console.WriteLine("Remarks: Need Improvement");
            }
            else if (percentage > 60)
            {
                Console.WriteLine("Remarks: Work Hard");
            }
            else if (percentage > 50)
            {
                Console.WriteLine("Remarks: Need Guidance");
            }
            else
            {
                Console.WriteLine("Remarks: Call Your Parents Tommorow");
            }

            //Supply

            int supply = 0;
            if (english < 33)
            {
                supply++;
            }
            if (hindi < 33)
            {
                supply++;
            }
            if (math < 33)
            {
                supply++;
            }
            if (urdu < 33)
            {
                supply++;
            }

            Console.WriteLine($"You are failed in {supply} subjects");


            Console.ReadKey();
        }
    }
}

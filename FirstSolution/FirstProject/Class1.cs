using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstProject
{
    class Class2
    {
        string studentName = "Sophia Johnson";
        string course1Name = "English 101";
        string course2Name = "Algebra 101";
        string course3Name = "Biology 101";
        string course4Name = "Computer Science I";
        string course5Name = "Psychology 101";

        int course1Credit = 3;
        int course2Credit = 3;
        int course3Credit = 4;
        int course4Credit = 4;
        int course5Credit = 3;

        void Display()
        {
            

            Console.WriteLine(studentName + "\n");
            Console.WriteLine("Course\t\t\tGrade\t\tCredit Hours");
            Console.WriteLine(course1Name + "\t\t4\t\t" + course1Credit);
            Console.WriteLine(course2Name + "\t\t3\t\t" + course2Credit);
            Console.WriteLine(course3Name + "\t\t3\t\t" + course3Credit);
            Console.WriteLine(course4Name + "\t3\t\t" + course4Credit);
            Console.WriteLine(course5Name + "\t\t4\t\t" + course5Credit);

            Console.WriteLine();

            decimal totalcredit = course1Credit * 4+ 
                course2Credit * 3+ course3Credit * 3+ course4Credit * 3
                + course5Credit * 4;
            decimal totalgrade = 4 + 3 + 3 + 3 + 4;

            decimal gpa = totalcredit / totalgrade;

            Console.WriteLine($"Final GPA: \t{gpa:F2}");


        }

        static void Main(string[] args)
        {
            Class2 obj = new Class2();
            //obj.Display();

            string[] arr = new string[3];
            arr[0] = "Tousif";
            arr[1] = "Anika";
            arr[2] = "Nondi";

            /*Console.WriteLine(arr[0]);
            Console.WriteLine(arr[1]);
            Console.WriteLine(arr[2]);*/

            string[] arr2 =
            {
                "Tousif",
                "Nondi",
                "Tushu",
                "Anika"
            };

            foreach (string name in arr2)
            {
              //  Console.WriteLine(name);
            }

            Console.WriteLine();

            int[] inventory = { 200, 450, 700, 175, 250 };
            foreach (int items in inventory)
            {
                //Console.WriteLine(items);
            }

            //Console.WriteLine();

            int sum = 0;

            foreach(int items in inventory)
            {
                sum += items;
            }

            //Console.WriteLine("Sum of the inventory items: " + sum);

            string[] ids =
            {
                "B123",
                "C234",
                "A345",
                "C15",
                "B177",
                "G3003",
                "C235",
                "B179"
            };

            foreach(string id in ids)
            {
                if (id.StartsWith("B"))
                {
                    Console.WriteLine(id);
                }
            }
        }
    }

   
}

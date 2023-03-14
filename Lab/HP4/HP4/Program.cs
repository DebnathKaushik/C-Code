using System;

namespace HP4
{
    class Student
    {
        public string name;
        public int age;
        public double mark1;
        public double mark2;
        public double mark3;

        public Student(string name, int age, double mark1, double mark2, double mark3)
        {
            this.name = name;
            this.age = age;
            this.mark1 = mark1;
            this.mark2 = mark2;
            this.mark3 = mark3;
        }

        public double calculateAverage()
        {
            return (mark1 + mark2 + mark3) / 3;
        }
    }


    class Program
    {
        public static void Main(string[] args)
        {
            Student[] stu = new Student[5];                     // input in array

            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine("Enter details for student {0}:", i + 1);
                Console.Write("Name: ");
                string name = Console.ReadLine();
                Console.Write("Age: ");
                int age = int.Parse(Console.ReadLine());
                Console.Write("Mark 1: ");
                double mark1 = Convert.ToDouble(Console.ReadLine());
                Console.Write("Mark 2: ");
                double mark2 = double.Parse(Console.ReadLine());
                Console.Write("Mark 3: ");
                double mark3 = double.Parse(Console.ReadLine());
                stu[i] = new Student(name, age, mark1, mark2, mark3);

            }

            double highavarage = 0;
            string highname = "";
            double highage = 0;


            for (int i = 0; i < 5; i++)
            {
                double average = stu[i].calculateAverage();

                Console.WriteLine("Details for student :", i + 1);
                Console.WriteLine("Name: "+stu[i].name);
                Console.WriteLine("Age: "+stu[i].age);
                Console.WriteLine("Average marks: "+ average);



                if (average > highavarage)
                {
                    highavarage = average;
                    highname = stu[i].name;
                    highage = stu[i].age;
                }
            }


            Console.WriteLine("The student with the highest average marks is:");
            Console.WriteLine("Name: {0}", highname);
            Console.WriteLine("Age: {0}", highage);
            Console.WriteLine("Average marks: {0}", highavarage);




        }


    }
}

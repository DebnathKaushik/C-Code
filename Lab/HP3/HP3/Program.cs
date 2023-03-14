/*using System;

namespace HP3
{
    class student
    {
        public string name;
        public int age;
        public int id;

        public student()
        {

        }

        public student(string name,int age,int id)
        {
            this.name = name;
            this.age = age; 
            this.id = id;

        }
   
        public void display()
        {
            Console.WriteLine("name is :" + name);
            Console.WriteLine("name is :" + age);
            Console.WriteLine("name is :" + id);
        }


        class Program
        {
            public static void Main(string[] args)
            {

                student obj1 = new student("kaushik",20,22465391);
                obj1.display();
            }
        }
    }
}*/



/*using System;

namespace HP3
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] arr = new string[5];


           Console.WriteLine("Enter Five Name :");
            for(int i = 0;i<5;i++)
            {
                arr[i] = Console.ReadLine();
            }

            Console.WriteLine("Output is :");
            for (int i = 4; i >= 0; i--)
            {
                Console.WriteLine(arr[i]);
            }

        }
    }
}*/


/*using System;

namespace HP3
{
    class person
    {
        public string name = "kaushik";
        public int age = 20;

        public void display()
        {
            Console.WriteLine(name);
            Console.WriteLine(age);
        }
    }

    class student : person
    {
        public string stu_name = "sokal";
        public int stu_id = 22465391;

        public void display()
        {
            Console.WriteLine(stu_name);
            Console.WriteLine(stu_id);
            Console.WriteLine();
        }
    }
    class teacher : person
    {
        public string teacher_name = "Sir";
        public string major = "computer science";

        public void display()
        {
            Console.WriteLine(teacher_name);
            Console.WriteLine(major);
            Console.WriteLine();
        }
    }


                class Program
                {
                    public static void Main(string[] args)
                    {
                        teacher t_1 = new teacher();    
                        student s_1 = new student();
                        person  p_1 = new person();
            
                        s_1.display();
                        t_1.display();
                        p_1.display();
            

                    } 


                }





 }
*/




                                                              // Interface 


/*using System;

namespace HP3
{
   public  interface person
    {
        public void energy();
    }


   public  class student:person

    {
        public void energy()
        {
            Console.WriteLine("I have lot of potential");
        }
    }

    class Program
    {
        public static void Main(string[] ars)
        {
            person s1 = new student();
            s1.energy();


        }


*/
    }





}




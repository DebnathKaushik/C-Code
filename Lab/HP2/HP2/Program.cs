/*using System;                   // Inheritance 

namespace HP2
{
    class parent
    {
       
        internal void ear(string x)
        {
          
            Console.WriteLine(x + "  hi i can hear you");
        }
        public void face()
        {
            Console.WriteLine("hi i am visiable");
        }

    }

    class child : parent
    {
        public void grade()
        {
            Console.WriteLine("yooo good ");
        }
    }

    class Program {
        public static void Main(string[] args)
        {
           child c1 = new child();
            c1.ear("Kaushik");
            c1.grade();
            c1.face();
        }

    }

}
*/

// Polymorphism




/*using System;                  // Overloading

namespace HP2
{
    class Vehicle
    {
        
        public void power(string x,string y)         // func has same name but Diff paremeter
        {
            Console.WriteLine(x+y+" Very good power");
        }

        public void power(int x,int y)
        {
            Console.WriteLine("Nissan Gtr "+(x+y)+" Drift king ");

        }

    }

    class Program
    {

        public static void Main(string[] args) 
        {
          Vehicle v = new Vehicle();   
            v.power(7,1);
            v.power("Nissan"," has");
            


        }
    }

}*/


// OverRidding


/*using System;

namespace HP2
{

    class Animal
    {
        public virtual void  animalsound()
        {
            Console.WriteLine("Animal Sound");
        }
    }

    class Dog:Animal
    {
        public  override void animalsound()
        {
            Console.WriteLine("Dog Sound baw baw");
        }
    }

    class Cat:Animal
    {
        public  override void  animalsound() 
        {
            Console.WriteLine("Cat sound meow meow");

        }
    }



    class Program
    {
        public static void Main(string[] args)
        {
            Animal myanimal = new Animal();
            Animal mydog = new Dog ();
            Animal mycat = new Cat();

            myanimal.animalsound();
            mydog .animalsound();
            mycat.animalsound();

        }
    }

}*/

                                       // static 

using System;

namespace HP2
{

    class car
    {

        public static  int numberofcars;
        string model;
        public car(string model)
        {
            this.model = model;
            System.Console.WriteLine(model);
            numberofcars++;
        }
    }
    class program
    {
        public static void Main(string[] args)
        {
            car obj1 = new car("lambo");
            car obj2 = new car("nissan");
            car obj3 = new car("benz");

            Console.WriteLine(car.numberofcars);
          


        }

    }
}
    







// See https://aka.ms/new-console-template for more information



/*namespace MyTest
{
    class Vehicle
    {
        public string brand = "Ford";
        public void honk()
        {
            Console.WriteLine("Tuut, Tuut!");
        }
    }

    class Car : Vehicle
    {
        public string modelName = "Mustang";
    }

    class Program
    {
        static void Main(string[] args)
        {
            Car myCar = new Car();
            myCar.honk();
            Console.WriteLine(myCar.brand + " " + myCar.modelName);
        }
    }
}*/

/*namespace MyTest
{
    class Animal
    {
        public virtual void animalSound()
        {
            Console.WriteLine("The animal make a sound");
        }
    }

    class Cat : Animal
    {
        public override void animalSound()
        {
            Console.WriteLine("The cat says: meow meow");
        }
    }

    class Dog : Animal
    {
        public override void animalSound()
        {
            Console.WriteLine("The dog says: bow wow");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Animal myAnimal = new Animal();
            Animal myCat = new Cat();
            Animal myDog = new Dog();

            myAnimal.animalSound();
            myCat.animalSound();
            myDog.animalSound();
        }
    }
}*/

/*namespace MyTest
{
    abstract class Animal()
    {
        public abstract void animalSound();
        public virtual void sleep()
        {
            Console.WriteLine("Zzz");
        }
    }

    class Cat : Animal
    {
        public override void animalSound()
        {
            Console.WriteLine("The cat say: meow meow");
        }
    }

    class Program()
    {
        static void Main(string[] args)
        {
            Animal myCat = new Cat();
            myCat.animalSound();
            myCat.sleep();
        }
    }
}*/

/*namespace MyTest
{
    interface IAnimal
    {
        void animalSound();
    }

    class Cat : IAnimal
    {
        public void animalSound()
        {
            Console.WriteLine("The cat says: meow meow");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            IAnimal myCat = new Cat();
            myCat.animalSound();
        }
    }
}*/

/*namespace MyTest
{
    class Program
    {
        enum Level
        {
            Low = 5,
            Medium = 10,
            High = 15
        }

        static void Main(string[] args)
        {
            Level myVar1 = Level.Medium;
            int myVar2 = (int) Level.High;
            Console.WriteLine(myVar1);
            Console.WriteLine(myVar2);
        }
    }
}*/


/*string writeText = "Hello World";
File.WriteAllText("filename.txt", writeText);

string readText = File.ReadAllText("filename.txt");
Console.WriteLine(readText);*/


/*class Test
{
    public static void Main()
    {
        string path = @"c:\temp\MyTest.txt";
        if (!File.Exists(path))
        {
            // Create a file to write to.
            using (StreamWriter sw = File.CreateText(path))
            {
                sw.WriteLine("Hello");
                sw.WriteLine("And");
                sw.WriteLine("Welcome");
            }
        }

        // Open the file to read from.
        using (StreamReader sr = File.OpenText(path))
        {
            string s;
            while ((s = sr.ReadLine()) != null)
            {
                Console.WriteLine(s);
            }
        }
    }
}*/

/*try
{
    int[] Number = [1, 2, 3];
    Console.WriteLine(Number[10]);
}
catch (Exception e)
{
    Console.WriteLine("Something is wrong");
}*/

/*namespace MyTest
{
    class Program
    {
        static void checkAge(int Age)
        {
            if (Age < 18)
            {
                throw new ArithmeticException("Access denied - You must be at least 18 years old");
            }
            else
            {
                Console.WriteLine("Access granted - You are old enough");
            }
        }

        static void Main(string[] args)
        {
            checkAge(17);
        }
    }
}*/

/*namespace MyApplication
{
    class Program
    {
        static int PlusMethod(int x, int y)
        {
            return x + y;
        }

        static double PlusMethod(double x, double y)
        {
            return x + y;
        }

        static void Main(string[] args)
        {
            int myNum1 = PlusMethod(8, 5);
            double myNum2 = PlusMethod(4.3, 6.26);
            Console.WriteLine("Int: " + myNum1);
            Console.WriteLine("Double: " + myNum2);
        }
    }
}*/


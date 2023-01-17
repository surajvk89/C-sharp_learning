//object-oriented programming language 
//based  on .net framework

// See https://aka.ms/new-console-template for more information

using System;
//we use classes from the System namespace.
using System.IO;


//namespace is used to organize your code, and it is a container for classes and other namespaces.
namespace HelloWorld
{
    // class is a container for data and methods, which brings functionality to your program.
    class Program
    {
        static void Main(string[] args)
        {
            //Console is a class of the System namespace
            //To output values or print text in C#, you can use the WriteLine() method:
            Console.WriteLine("Hello World!");
            //Every C# statement ends with a semicolon ;
            //Write() method does not insert a new line at the end of the output
            //single line comment '//' and multi-line comment '/*...*/'

            //Variables are containers for storing data values.
            //types of variables - int, double, char, string, bool

            int myNum = 5;
            double myDoubleNum = 5.99D;
            float myFloatNum = 1.2f;
            char myLetter = 'D';
            bool myBool = true;
            string myText = "Hello";
            long myNumLong = 15000000000L;


            //you can add the const keyword in front of the variable type to declare constants
            const double pi = 3.14159D;
            //To combine both text and a variable, use the + character
            string name = "John";
            Console.WriteLine("Hello " + name);
            //Names are case sensitive ("myVar" and "myvar" are different variables)
            //A floating point number can also be a scientific number with an "e" to indicate the power of 10:
            float f1 = 35e3F;
            double d1 = 12E4D;

            //two types of casting
            //Implicit Casting (automatically) - converting a smaller type to a larger type size
            //Explicit Casting (manually) - converting a larger type to a smaller size type
            int myInt = 9;
            double myDouble = myInt;       // Automatic casting: int to double

            myDouble = 9.78;
            myInt = (int)myDouble;    // Manual casting: double to int

            // It is also possible to convert data types explicitly by using built-in methods,
            // such as Convert.ToBoolean, Convert.ToDouble, Convert.ToString, Convert.ToInt32(int) and Convert.ToInt64(long)

            //Console.ReadLine() to get user input
            Console.WriteLine("Enter username:");
            // Create a string variable and get user input from the keyboard and store it in the variable
            string userName = Console.ReadLine();

            //Arithmetic operators : +,-,%,/,*,--,++
            //Comparison operators : ==, >, <, <=, >=, !=
            //logical operators : &&, ||, !

            // Math class methods
            //The Math.Max(x,y) method can be used to find the highest value of x and y
            //The Math.Min(x, y) method can be used to find the lowest value of of x and y
            //The Math.Sqrt(x) method returns the square root of x
            //The Math.Abs(x) method returns the absolute (positive) value of x
            //Math.Round() rounds a number to the nearest whole number

            //A string variable contains a collection of characters surrounded by double quotes
            string greeting = "Hello";

            //A string in C# is actually an object, string length ca be obtained using length property
            Console.WriteLine(greeting.Length);
            //The + operator can be used between strings to combine them. This is called concatenation:
            string firstName = "John ";
            string lastName = "Doe";
            string fullName = firstName + lastName;
            Console.WriteLine(fullName);

            //string.Concat() method to concatenate two strings
            string fname = string.Concat(firstName, lastName);
            //string interpolation, substitutes values of variables into placeholders in a string.
            //String interpolation was introduced in C# version 6.
            fname = $"My full name is: {firstName} {lastName}";
            Console.WriteLine(fname);

            //You can access the characters in a string by referring to its index number inside square brackets [].
            Console.WriteLine(fname[0]);
            //You can also find the index position of a specific character in a string, by using the IndexOf() method
            Console.WriteLine(fname.IndexOf("y"));  // Outputs "1"

            int charPos = fname.IndexOf("D");
            //Substring(), extracts the characters from a string, starting from the specified character position/ index, and returns a new string.
            lastName = name.Substring(charPos);

            // The backslash (\) escape character turns special characters into string characters
            // \' - insert '
            // \'' - insert ''
            // \\ - insert \ 
            // \n, \t, \b - backspace

            // Boolean values and boolean expressions, if...else
            bool isTrue = true;
            bool isFalse = false;

            int age = 20;
            if (age >= 18)
            {

            }
            else
            {

            }

            // if(), if()..else, if..else if, switch
            //ternary operator
            Console.WriteLine(age > 18 ? age : "Not voter");

            // Use the switch statement to select one of many code blocks to be executed.
            // The switch expression is evaluated once
            /* switch (expression)
             {
                 case x:
                     // code block
                     break;
                 case y:
                     // code block
                     break;
                 default:
                     // code block
                     break;
             }*/

            // The default keyword is optional and specifies some code to run if there is no case match

            // The while loop loops through a block of code as long as a specified condition is True

            int i = 0;
            while (i < 5)
            {
                Console.WriteLine(i);
                i++;
            }


            // The do/while loop is a variant of the while loop. This loop will execute the code block once,
            // before checking if the condition is true, then it will repeat the loop as long as the condition is true.

            i = 0;
            do
            {
                Console.WriteLine(i);
                i++;
            }
            while (i < 5);


            // When you know exactly how many times you want to loop through a block of code,
            // use the for loop instead of a while loop
            for (i = 0; i < 5; i++)
            {
                Console.WriteLine(i);
            }

            // It is also possible to place a loop inside another loop. This is called a nested loop.
            // The "inner loop" will be executed one time for each iteration of the "outer loop"

            // Outer loop
            for (i = 1; i <= 2; ++i)
            {
                Console.WriteLine("Outer: " + i);  // Executes 2 times

                // Inner loop
                for (int j = 1; j <= 3; j++)
                {
                    Console.WriteLine(" Inner: " + j); // Executes 6 times (2 * 3)
                }
            }

            // There is also a foreach loop, which is used exclusively to loop through elements in an array
            string[] cars = { "Volvo", "BMW", "Ford", "Mazda" };
            foreach (string c in cars)
            {
                Console.WriteLine(c);
            }




            //break - The break statement can also be used to jump out of a loop.
            //        When C# reaches a break keyword, it breaks out of the switch block.
            //continue - The continue statement breaks one iteration (in the loop), if a specified condition occurs,
            //           and continues with the next iteration in the loop.

            for (i = 0; i < 10; i++)
            {
                if (i == 4)
                {
                    continue;
                }
                Console.WriteLine(i);
            }



            //  Arrays are used to store multiple values in a single variable,
            //  instead of declaring separate variables for each value.
            int[] myNumber = { 10, 20, 30, 40 };
            // You access an array element by referring to the index number.
            Console.WriteLine(cars[0]);
            // Length of array
            Console.WriteLine(cars.Length);


            // Other ways to create arrays
            // Create an array of four elements, and add values later
            // string[] cars = new string[4];

            // Create an array of four elements and add values right away 
            // string[] cars = new string[4] { "Volvo", "BMW", "Ford", "Mazda" };

            // Create an array of four elements without specifying the size 
            // string[] cars = new string[] { "Volvo", "BMW", "Ford", "Mazda" };

            // Create an array of four elements, omitting the new keyword, and without specifying the size
            // string[] cars = { "Volvo", "BMW", "Ford", "Mazda" };

            // Array method -Array.Sort(cars)
            // Other useful array methods, such as Min, Max, and Sum, can be found in the System.Linq namespace

            // A multidimensional array is basically an array of arrays.
            // Arrays can have any number of dimensions.The most common are two - dimensional arrays(2D).

            int[,] numbers = { { 1, 4, 2 }, { 3, 6, 8 } };
            // To access an element of a two-dimensional array, you must specify two indexes:
            // one for the array, and one for the element inside that array. 

            for (i = 0; i < numbers.GetLength(0); i++)
            {
                for (int j = 0; j < numbers.GetLength(1); j++)
                {
                    Console.WriteLine(numbers[i, j]);
                }
            }

            // ******* Methods **********
            // A method is a block of code which only runs when it is called. Why use methods? To reuse code
            // C# provides some pre-defined methods, which you already are familiar with, such as Main(),
            // but you can also create your own methods to perform certain actions

            // Creating method
            /*   class Program
                {
                    static void MyMethod()
                    {
                        // code to be executed
                    }
                }*/

            // call method using method_name();
            // method can be called multiple times

            // When a parameter is passed to the method, it is called an argument.
            // So, from the example above: fname is a parameter, while Liam, Jenny and Anja are arguments.
            // Note that when you are working with multiple parameters, the method call must have
            // the same number of arguments as there are parameters, and the arguments must be passed in the same order.


        }

        // You can also use a default parameter value, by using the equals sign (=).
        static void MyMethod(string country = "Norway")
        {
            Console.WriteLine(country);
        }

        // call method with paramaeter :  MyMethod("India");
        // call method without paramaeter :  MyMethod(); //use default value

        // If you want the method to return a value, you can use a primitive data type
        // (such as int or double) instead of void, and use the return keyword inside the method
        static int Add(int x = 0)
        {
            return 5 + x;
        }

        // It is also possible to send arguments with the key: value syntax.
        // That way, the order of the arguments does not matter
        static void MyNameMethod(string child1, string child2, string child3)
        {
            Console.WriteLine("The youngest child is: " + child3);
        }

        // call method by changing argument sequence :   MyNameMethod(child3: "John", child1: "Liam", child2: "Liam");
        // With method overloading, multiple methods can have the same name with different parameters
        static int PlusMethod(int x, int y)
        {
            return x + y;
        }

        static double PlusMethod(double x, double y)
        {
            return x + y;
        }

        int myNum1 = PlusMethod(8, 5);
        double myNum2 = PlusMethod(4.3, 6.26);


        // OOP 

        // Classes and objects are the two main aspects of object-oriented programming.
        // So, a class is a template for objects, and an object is an instance of a class.
        // A Class is like an object constructor, or a "blueprint" for creating objects.
        // When a variable is declared directly in a class, it is often referred to as a field (or attribute).
        // To create an object of Car, specify the class name, followed by the object name, and use the keyword new:
        // Car myObj = new Car();
        // we use the dot syntax (.) to access variables/fields inside a class
        // Fields and methods inside classes are often referred to as "Class Members".
        // Methods normally belongs to a class, and they define how an object of a class behaves.
        // Example: 
        /*class Car
        {
            string color;                 // field
            int maxSpeed;                 // field
            public void fullThrottle()    // method
            {
                Console.WriteLine("The car is going as fast as it can!");
            }

            static void Main(string[] args)
            {
                Car myObj = new Car();
                myObj.fullThrottle();  // Call the method
            }
        }*/



        // Constructors - A constructor is a special method that is used to initialize objects.
        // The advantage of a constructor, is that it is called when an object of a class is created. It can be used to set initial values for fields
        // All classes have constructors by default: if you do not create a class constructor yourself,
        // C# creates one for you. However, then you are not able to set initial values for fields.
        // Constructors can also take parameters, which is used to initialize fields.
        // Constructor name and file name is same - not compulsory but will be helpful
        class Car
        {
            public string model;
            public string color;
            public int year;

            // Create a class constructor with multiple parameters
            public Car(string modelName, string modelColor, int modelYear)
            {
                model = modelName;
                color = modelColor;
                year = modelYear;
            }

            static void Main(string[] args)
            {
                Car Ford = new Car("Mustang", "Red", 1969);
                Console.WriteLine(Ford.color + " " + Ford.year + " " + Ford.model);
            }
        }


        // An access modifier, which is used to set the access level/visibility for classes, fields, methods and properties.
        // To achieve "Encapsulation" - which is the process of making sure that "sensitive" data is hidden from users.This is done by declaring fields as private
        // public (accessible for all classes)
        // private (accessed within the same class, all members of a class are private)
        // protected (The code is accessible within the same class, or in a class that is inherited from that class.)
        // and internal (The code is only accessible within its own assembly,but not from another assembly.)

        private string model = "Mustang";
        public string model2 = "WagnoR";

        // A property is like a combination of a variable and a method, and it has two methods: a get and a set method
        class Person
        {
            private string name; // field
            public string Name   // property
            {
                get { return name; }
                set { name = value; }
            }
        }

        class MyProgram
        {
            static void Main(string[] args)
            {
                Person myObj = new Person();
                myObj.Name = "Liam";
                Console.WriteLine(myObj.Name);
            }
        }

        // C# also provides a way to use short-hand / automatic properties,
        // where you do not have to define the field for the property, and you only have to write get; and set; inside the property.
        // Above code can be written as below using automic property with same result.
        class PersonOne
        {
            public string Name  // property
            { get; set; }
        }

        // Why Encapsulation?
        // Better control of class members, Fields can be made read-only or write-only, change one part of the code without affecting other parts,
        //                   increased security of data


        // Inheritance 
        // To inherit from a class, use the : symbol
        // It is useful for code reusability
        class Vehicle  // base class (parent) 
        {
            public string brand = "Ford";  // Vehicle field
            public void honk()             // Vehicle method 
            {
                Console.WriteLine("Tuut, tuut!");
            }
        }
        class MyCar : Vehicle  // derived class (child)
        {
            public string modelName = "Mustang";  // Car field
        }

        // If you don't want other classes to inherit from a class, use the sealed keyword
        sealed class NewVehicle
        {
        }
        // Inheriting from this class will generate error


        // Polymorphism allows us to perform a single action in different ways.
        // For example, think of a base class called Animal that has a method called animalSound().
        // Derived classes of Animals could be Pigs, Cats, Dogs, Birds - And they also have their own implementation of an animal sound
        // (the pig oinks, and the cat meows, etc.)

        // Unlike other OOP languages, the base class method overrides the derived class method, when they share the same name.
        // However, C# provides an option to override the base class method, by adding the virtual keyword to the method inside the base class,
        // and by using the override keyword for each derived class methods
        class Animal  // Base class (parent) 
        {
            public virtual void animalSound()
            {
                Console.WriteLine("The animal makes a sound");
            }
        }

        class Pig : Animal  // Derived class (child) 
        {
            public override void animalSound()
            {
                Console.WriteLine("The pig says: wee wee");
            }
        }


        // Abstraction can be achieved with either abstract classes or interfaces
        // The abstract keyword is used for classes and methods
        // Abstract class
        abstract class AnimalNew
        {
            // Abstract method (does not have a body)
            public abstract void animalSound();
            // Regular method
            public void sleep()
            {
                Console.WriteLine("Zzz");
            }
        }

        // Another way for abstraction is interfaces
        // An interface is a completely "abstract class", which can only contain abstract methods and properties (with empty bodies)
        
        // interface
        interface AnimalInt
        {
            void animalSound(); // interface method (does not have a body)
            void run(); // interface method (does not have a body)
        }

        // Good practice - start with the letter "I" at the beginning of an interface : IAnimal
        // By default, members of an interface are abstract and public
        // C# does not support "multiple inheritance" (a class can only inherit from one base class). However, it can be achieved with
        // interfaces, because the class can implement multiple interfaces. Note: To implement multiple interfaces, separate them
        // with a comma (see example below).
        interface IFirstInterface
        {
            void myMethod(); // interface method
        }

        interface ISecondInterface
        {
            void myOtherMethod(); // interface method
        }

        class DemoClass : IFirstInterface, ISecondInterface
        { 
            public void myMethod() { }
            public void myOtherMethod() { }
        }

        // An enum is a special "class" that represents a group of constants(unchangeable/read-only variables).
        // Enum is short for "enumerations", which means "specifically listed".
        // To create an enum, use the enum keyword (instead of class or interface),
        // and separate the enum items with a comma

        enum Grade
        {
            A,
            B,
            C
        }
        //Access enum items using dot operator
        Grade myGrade = Grade.A;

        // You can also have an enum inside a class
        // By default, the first item of an enum has the value 0. The second has the value 1, and so on.
        // To get nt value, convert them explicitely to int
        class ProgramEnum
        {
            enum Level
            {
                Low,
                Medium,
                High
            }
            static void Main(string[] args)
            {
               int myVar = (int) Level.Medium;
                Console.WriteLine(myVar);
            }
        }

        // You can also assign your own enum values, and the next items will update their numbers accordingly
        enum Months
        {
            January,    // 0
            February,   // 1
            March = 6,    // 6
            April,      // 7
            May,        // 8
            June,       // 9
            July        // 10
        }

        // Use enums when you have values that you know aren't going to change,
        // like month days, days, colors, deck of cards, etc.
        // Enums can be used in switch statement as switch case varibale
        // case Months.June : statements; break;

        // Files
        // The File class from the System.IO namespace, allows us to work with files
        // using System.IO;  // include the System.IO namespace
        // File.SomeFileMethod();  // use the file class with methods

        public void fileHandling() {
            // Some of the file methods :
            // Create(), Delete(), AppendText(), Copy(), Exists(), ReadAllText(),
            // Replace(), WriteAllText(), AppendAllLines(String, IEnumerable<String>),
            // AppendAllLines(String, IEnumerable<String>, Encoding), AppendAllText(String, String),
            // AppendAllText(String, String, Encoding), Copy(String, String, Boolean), CreateText(String),
            // Encrypt(String), GetAccessControl(String), GetLastAccessTimeUtc(String), Move(String, String),ReadAllBytes(String)
            string writeText = "Hello World!";  // Create a text string
            File.WriteAllText("filename.txt", writeText);  // Create a file and write the content of writeText to it

            string readText = File.ReadAllText("filename.txt");  // Read the contents of the file
            Console.WriteLine(readText);  // Output the content
        }


        //      Exception handling
        // When an error occurs, C# will normally stop and generate an error message.
        // The technical term for this is: C# will throw an exception (throw an error).
        // The try statement allows you to define a block of code to be tested for errors while it is being executed.
        // The catch statement allows you to define a block of code to be executed, if an error occurs in the try block.
        // The finally statement lets you execute code, after try...catch, regardless of the result
        // The throw statement allows you to create a custom error.
        // The throw statement is used together with an exception class. There are many exception classes available in C#:
        // ArithmeticException, FileNotFoundException, IndexOutOfRangeException, TimeOutException, etc



        static void checkAge(int age)
        {
            try
            {
                int[] myNumbers = { 1, 2, 3 };
                Console.WriteLine(myNumbers[10]);
            }
            catch (Exception e)
            {
                // You can print exception message using e.message
                Console.WriteLine("Something went wrong.");
            }
            finally
            {
                Console.WriteLine("The 'try catch' is finished.");
            }

            if (age < 18)
            {
                throw new ArithmeticException("Access denied - You must be at least 18 years old.");
            }
            else
            {
                Console.WriteLine("Access granted - You are old enough!");
            }
        }

        public void checkException()
        {
            try
            {
                checkAge(19);
            }catch(ArithmeticException ae)
            {
                Console.WriteLine(ae.Message);
            }
        }

            


    }

}



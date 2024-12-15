// The first lesson on s sharp : Basic to get started in c#
using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello student "); // TO Print a text in the C#;
            Console.Beep(); // Use to beep when the console end ;
                
        }
    }
}
------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
//lesson 2 : The output in C#;
using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            // Console.Write writes text to the console without adding a new line at the end.
            // So, the next output will appear on the same line.
            Console.Write("Kader   ");

            // Console.WriteLine writes text to the console and automatically adds a new line at the end.
            // The next output will appear on a new line.
            Console.WriteLine("Hello World!");

            // Another example of Console.WriteLine to demonstrate its behavior.
            Console.WriteLine("Hello World! just to clarify");
            // This is a  comment ;
            // How to do a new line 
            Console.WriteLine("Hello Andrey \nLearn C# with kader");// \n to do a new line ;
        }
    }
}
------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
// Lesson 3: Variables in C#
using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            // Declaring a variable of type integer
            int Number; // Declaration of the variable
            Number = 15; // Initialization (assigning a value to the variable)

            // Declaring and initializing an integer variable in one step
            int Number2 = 30;

            // Declaring a variable of type double (used for decimal numbers)
            double height; // Declaration
            height = 167.7; // Initialization

            // Declaring a variable of type boolean (true/false values)
            bool alive; // Declaration
            alive = true; // Initialization

            // Declaring and initializing a char (single character)
            char symbol = '@'; // A character data type

            // Declaring a string (used for text)
            string name; // Declaration
            name = "kader"; // Initialization

            // Displaying the variables using Console.WriteLine
            Console.WriteLine(Number); // Output: 15
            Console.WriteLine(Number2); // Output: 30
            Console.WriteLine(height); // Output: 167.7

            // Concatenating strings and variables for output
            Console.WriteLine("Hello, your age is " + Number + " and your height is " + height);

            // Displaying boolean value
            Console.WriteLine(alive); // Output: True

            // Displaying the character
            Console.WriteLine(symbol); // Output: @

            // Displaying the string
            Console.WriteLine(name); // Output: kader
        }
    }
}
------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
// Lesson 4: Constants in C#
using System;

namespace ConsoleApp1
{
    class Program
    {
        // A constant is a value that cannot be changed or modified after its declaration.
        static void Main(string[] args)
        {
            // Declaring a constant using the 'const' keyword
            const double PI = 3.14159265358979323846;

            // Trying to modify 'PI' will result in a compilation error because constants are immutable.
            // Example (uncommenting the line below will cause an error):
            // PI = 3.14;

            // Displaying the value of the constant
            Console.WriteLine(PI); // Output: 3.14159265358979323846
        }
    }
}
------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
// Lesson 5: Type Casting in C#
using System;

namespace ConsoleApp1
{
    class Program
    {
        // Type casting is converting a value from one data type to another.
        static void Main(string[] args)
        {
            // Implicit casting (smaller to larger type) happens automatically in C#, like int to double.
            // Explicit casting (larger to smaller type) needs to be specified or handled using Convert methods.

            // Example of converting (casting) from a double to an int:
            double a = 3.14; // A double value
            int b; // Declare an integer variable
            b = Convert.ToInt32(a); // Explicitly cast (convert) the double to an int using Convert.ToInt32
            Console.WriteLine(b); // Output: 3 (decimal portion is truncated)

            // Example of converting from an int to a string:
            int e = 3; // An integer value
            string c; // Declare a string variable
            c = Convert.ToString(e); // Convert the integer to a string using Convert.ToString
            Console.WriteLine(c); // Output: "3"
        }
    }
}
------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
// Lesson 6: User Input in C#
using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            // Reading a string input from the user
            string name = Console.ReadLine(); // Similar to scanf in C for strings

            // Reading an integer input from the user
            // Convert.ToInt32() is used to convert the string input to an integer
            int age = Convert.ToInt32(Console.ReadLine());

            // Reading a double (floating-point number)
            // Convert.ToDouble() is used to convert the string input to a double
            double height = Convert.ToDouble(Console.ReadLine());

            // Reading a boolean input
            // Convert.ToBoolean() converts the string input to a boolean (true/false)
            bool isStudent = Convert.ToBoolean(Console.ReadLine());

            // Displaying the collected user inputs
            Console.WriteLine("Name: " + name);
            Console.WriteLine("Age: " + age);
            Console.WriteLine("Height: " + height);
            Console.WriteLine("Is Student: " + isStudent);
        }
    }
}
------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
// Lesson 7: Arithmetic Operations in C#
using System;

namespace ArithmeticExample
{
    class Program
    {
        static void Main(string[] args)
        {
            // Declaring variables
            int a = 10;
            int b = 5;
            double x = 12.5;
            double y = 4.2;

            // Addition
            int sum = a + b;
            Console.WriteLine("Sum: " + sum); // Output: 15

            // Subtraction
            int difference = a - b;
            Console.WriteLine("Difference: " + difference); // Output: 5

            // Multiplication
            int product = a * b;
            Console.WriteLine("Product: " + product); // Output: 50

            // Division (integer division will truncate the decimal part)
            int quotient = a / b;
            Console.WriteLine("Quotient (int): " + quotient); // Output: 2

            // Division (for floating-point numbers)
            double floatQuotient = x / y;
            Console.WriteLine("Quotient (double): " + floatQuotient); // Output: 2.9761904761904763

            // Modulus (remainder)
            int remainder = a % b;
            Console.WriteLine("Remainder: " + remainder); // Output: 0

            // Increment (Increase by 1)
            a++;
            Console.WriteLine("Incremented a: " + a); // Output: 11

            // Decrement (Decrease by 1)
            b--;
            Console.WriteLine("Decremented b: " + b); // Output: 4
        }
    }
}
------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
// Lesson 9: Using Common Math Methods in C#
using System;

namespace MathExample
{
    class Program
    {
        static void Main(string[] args)
        {
            // Math.Abs(x): Returns the absolute value of x
            int a = -10;
            Console.WriteLine("Absolute Value of " + a + ": " + Math.Abs(a)); // Output: 10

            // Math.Pow(x, y): Returns x raised to the power of y (x^y)
            double baseNumber = 2;
            double exponent = 3;
            Console.WriteLine(baseNumber + " raised to the power of " + exponent + ": " + Math.Pow(baseNumber, exponent)); // Output: 8

            // Math.Sqrt(x): Returns the square root of x
            double number = 16;
            Console.WriteLine("Square Root of " + number + ": " + Math.Sqrt(number)); // Output: 4

            // Math.Floor(x): Returns the largest integer less than or equal to x
            double floorExample = 3.99;
            Console.WriteLine("Floor of " + floorExample + ": " + Math.Floor(floorExample)); // Output: 3

            // Math.Round(x): Rounds x to the nearest integer
            double roundingExample = 4.5;
            Console.WriteLine("Round of " + roundingExample + ": " + Math.Round(roundingExample)); // Output: 4

            // Math.Max(x, y): Returns the larger of the two numbers x and y
            int num1 = 7;
            int num2 = 3;
            Console.WriteLine("Max of " + num1 + " and " + num2 + ": " + Math.Max(num1, num2)); // Output: 7

            // Math.Min(x, y): Returns the smaller of the two numbers x and y
            Console.WriteLine("Min of " + num1 + " and " + num2 + ": " + Math.Min(num1, num2)); // Output: 3
        }
    }
}
------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
// Lesson 10: Common String Methods in C#
using System;

namespace StringMethodsExample
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = "   Hello, C# World!   ";

            // 1. Length
            Console.WriteLine("Length: " + text.Length); // Output: 23

            // 2. ToUpper() - Converts the string to uppercase
            Console.WriteLine("ToUpper: " + text.ToUpper()); // Output: "   HELLO, C# WORLD!   "

            // 3. ToLower() - Converts the string to lowercase
            Console.WriteLine("ToLower: " + text.ToLower()); // Output: "   hello, c# world!   "

            // 4. Trim() - Removes leading and trailing whitespace
            Console.WriteLine("Trim: '" + text.Trim() + "'"); // Output: "Hello, C# World!"

            // 5. Substring(startIndex)
            Console.WriteLine("Substring(7): " + text.Substring(7)); // Output: "C# World!   "

            // 6. Substring(startIndex, length)
            Console.WriteLine("Substring(7, 3): " + text.Substring(7, 3)); // Output: "C# "

            // 7. Replace(oldValue, newValue)
            Console.WriteLine("Replace('C#', 'CSharp'): " + text.Replace("C#", "CSharp")); // Output: "   Hello, CSharp World!   "

            // 8. Contains(value) - Checks if the string contains a substring
            Console.WriteLine("Contains('C#'): " + text.Contains("C#")); // Output: True

            // 9. IndexOf(value) - Finds the first occurrence of a substring
            Console.WriteLine("IndexOf('C#'): " + text.IndexOf("C#")); // Output: 7

            // 10. Split(delimiters) - Splits the string into an array of substrings
            string[] words = text.Split(',');
            Console.WriteLine("Split: " + string.Join(" | ", words)); // Output: "   Hello | C# World!   "

            // 11. StartsWith(value) - Checks if the string starts with a specified value
            Console.WriteLine("StartsWith('   Hello'): " + text.StartsWith("   Hello")); // Output: True

            // 12. EndsWith(value) - Checks if the string ends with a specified value
            Console.WriteLine("EndsWith('World!   '): " + text.EndsWith("World!   ")); // Output: True

            // 13. Insert(index, value) - Inserts a substring at the specified index
            Console.WriteLine("Insert(5, ', World'): " + text.Insert(5, ", World")); // Output: "   Hello, World, C# World!   "

            // 14. Remove(startIndex) - Removes all characters from the specified index
            Console.WriteLine("Remove(5): " + text.Remove(5)); // Output: "   Hello"

            // 15. Remove(startIndex, length) - Removes a specified length of characters
            Console.WriteLine("Remove(5, 3): " + text.Remove(5, 3)); // Output: "   Heo, C# World!   "

            // 16. Equals(otherString) - Checks if two strings are equal
            string text2 = "Hello, C# World!";
            Console.WriteLine("Equals: " + text.Equals(text2)); // Output: False

            // 17. ToCharArray() - Converts the string to a char array
            char[] charArray = text.Trim().ToCharArray();
            Console.WriteLine("ToCharArray: " + string.Join(", ", charArray)); // Output: H, e, l, l, o, ,, C, #,  , W, o, r, l, d, !

        }
    }
}

------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
// Lesson 11: Using if Statement in C#
using System;

namespace IfStatementExample
{
    class Program
    {
        static void Main(string[] args)
        {
            int age =Convert.ToInt32(Console.ReadLine()); ;
            

            if (age >= 18)
            {
                Console.WriteLine("You are an adult.");
            }
            else
            {
                Console.WriteLine("You are a minor.");
            }

            // Using else if
            if (age < 18)
            {
                Console.WriteLine("You are a minor.");
            }
            else if (age == 18)
            {
                Console.WriteLine("You just turned an adult!");
            }
            else
            {
                Console.WriteLine("You are an adult.");
            }
        }
    }
}
------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
// Lesson 13: Using Logical Operators (&&, ||)
using System;

namespace LogicalOperatorsExample
{
    class Program
    {
        static void Main(string[] args)
        {
            int age = 20;
            bool hasLicense = true;

            // AND Operator (&&)
            if (age >= 18 && hasLicense)
            {
                Console.WriteLine("You are eligible to drive.");
            }
            else
            {
                Console.WriteLine("You are either not old enough or do not have a license.");
            }

            // OR Operator (||)
            if (age < 18 || !hasLicense)
            {
                Console.WriteLine("You are either too young or do not have a license.");
            }
        }
    }
}
------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

// Lesson 14: Using for Loop


namespace ForLoopExample
{
    class Program
    {
        static void Main(string[] args)
        {
            // Print numbers from 1 to 5
            for (int i = 1; i <= 5; i++)
            {
                Console.WriteLine(i);
            }
        }
    }
}

------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------


// Lesson 15: Using while Loop
using System;

namespace WhileLoopExample
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = 1;
            
            // Print numbers from 1 to 5
            while (i <= 5)
            {
                Console.WriteLine(i);
                i++;  // Increment the counter
            }
        }
    }
}

------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

// Lesson 16: Using do...while Loop
using System;

namespace DoWhileLoopExample
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = 1;

            // Print numbers from 1 to 5
            do
            {
                Console.WriteLine(i);
                i++;
            } while (i <= 5);
        }
    }
}
------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

// Lesson 17: Using foreach Loop
using System;

namespace ForeachLoopExample
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] fruits = { "Apple", "Banana", "Cherry" };

            foreach (string fruit in fruits)
            {
                Console.WriteLine(fruit);
            }
        }
    }
}
------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
// Lesson 19: Arrays in C#
using System;

namespace ArrayExample
{
    class Program
    {
        static void Main(string[] args)
        {
            // Declaring and initializing an array using new
            int[] numbers = new int[5];  // Array to hold 5 integers
            
            // Initializing array elements
            numbers[0] = 10;
            numbers[1] = 20;
            numbers[2] = 30;
            numbers[3] = 40;
            numbers[4] = 50;
            
            // Declaring and initializing an array using array initializer
            string[] fruits = { "Apple", "Banana", "Cherry", "Date" };

            // Accessing array elements
            Console.WriteLine(numbers[0]);  // Output: 10
            Console.WriteLine(numbers[4]);  // Output: 50
            Console.WriteLine(fruits[2]);   // Output: Cherry

            // Length of an array
            Console.WriteLine("Number of elements in 'numbers' array: " + numbers.Length);  // Output: 5

            // Iterating through an array using a for loop
            for (int i = 0; i < numbers.Length; i++)
            {
                Console.WriteLine("Element at index " + i + ": " + numbers[i]);
            }

            // Prompting the user to enter new values for the array
            for (int i = 0; i < numbers.Length; i++)
            {
                Console.WriteLine("Enter a number for index " + i + ":");
                numbers[i] = Convert.ToInt32(Console.ReadLine());
            }

            // Display the updated array
            Console.WriteLine("Updated numbers array:");
            for (int i = 0; i < numbers.Length; i++)
            {
                Console.WriteLine("Element at index " + i + ": " + numbers[i]);
            }
        }
    }
}
------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
using System;
// Lesson 20: Method  in C#
namespace ArrayExample
{
    class Program
    { 
        // Method = performs a section of code whenever it's called/invoked.
        // We use it to reuse code without writing it multiple times.
        
        static void Main(string[] args)
        {
            int age = 10;
            string name = "Kader";
            
            // Calling the method and passing the arguments
            HappyBirthday(name, age);
        }

        // Method declaration with parameters: 'name' and 'age'
        static void HappyBirthday(string name, int age)
        {
            Console.WriteLine("Happy Birthday");
            Console.WriteLine("Happy Birthday");
            Console.WriteLine("Happy Birthday");
            Console.WriteLine("Happy Birthday " + name);
            Console.WriteLine("You are " + age + " years old");
            Console.WriteLine();
        }
    }
}
------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
using System;
// Lesson 21 Overloaded Method 
// How It Works:
// When you call an overloaded method, the compiler chooses the method
// to execute based on the number or type of arguments you provide.
// It matches the arguments with the available method signatures
namespace MethodOverloadingExample
{
    class Program
    {
        static void Main(string[] args)
        {
            // Calling overloaded methods with different parameter types
            PrintMessage("Hello!");
            PrintMessage("Hello", 3);

            // Calling overloaded methods with different number of parameters
            int sum1 = AddNumbers(5, 10);
            int sum2 = AddNumbers(5, 10, 15);

            Console.WriteLine("Sum1: " + sum1);  // Output: Sum1: 15
            Console.WriteLine("Sum2: " + sum2);  // Output: Sum2: 30
        }

        // Method with one string parameter
        static void PrintMessage(string message)
        {
            Console.WriteLine(message);
        }

        // Overloaded method with one string parameter and an integer for repetition count
        static void PrintMessage(string message, int count)
        {
            for (int i = 0; i < count; i++)
            {
                Console.WriteLine(message);
            }
        }

        // Method to add two integers
        static int AddNumbers(int a, int b)
        {
            return a + b;
        }

        // Overloaded method to add three integers
        static int AddNumbers(int a, int b, int c)
        {
            return a + b + c;
        }
    }
}
------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
// Lesson 22: Classes in  C#
    using System;

namespace MyNamespace
{
    // Define the 'Car' class
    class Car
    {
        // Fields (or properties) of the Car class
        public string Brand;  // The brand of the car (e.g., Audi, BMW)
        public string Model;  // The model of the car (e.g., A4, X5)
        public string Year;   // The year of the car's manufacture (e.g., 2000, 2020)

        // Method to display the car's information
        public void DisplayCars()
        {
            // Prints the car's details in the format: Year Brand Model
            Console.WriteLine($"{Year} {Brand} {Model}");
        }
    }

    // Main program class where execution begins
    class Program
    {
        // Main method, entry point of the program
        static void Main(string[] args)
        {
            // Creating a new instance of the 'Car' class
            Car car = new Car();

            // Setting the car's properties (attributes)
            car.Brand = "Audi";   // Assigning the brand of the car
            car.Model = "A4";     // Assigning the model of the car
            car.Year = "2000";    // Assigning the year of manufacture

            // Calling the DisplayCars method to show car information
            car.DisplayCars();    // Output: 2000 Audi A4
        }
    }
==============================================================================================================================================================================================================================================================================
using System;

namespace MyNamespace
{
    // Class representing a person
    class Person
    {
        // Private field to store the name of the person
        private string name ;

        // Method to set the name
        public void SetName(string name)
        {
            this.name = name;  // 'this.name' refers to the class field, while 'name' is the parameter
        }

        // Method to get the name
        public string GetName()
        {
            return name;  // Return the value of the class field 'name'
        }
    }

    // Main program class where execution starts
    class Program
    {
        static void Main(string[] args)
        {
            // Create an instance of the 'Person' class
            Person per = new Person();

            // Set a new name using the 'SetName' method
            per.SetName("Ahmed");

            // Get the name and print it
            Console.WriteLine(per.GetName());  // Output: Ahmed
        }
    }
}
==============================================================================================================================================================================================================================================================================
    using System;
//3. Inheritance:
namespace MyNamespace
{
    // Base class representing a general animal
    class Animal
    {
        // Public field for the name of the animal
        public string Name;

        // Method to represent the animal eating
        public void Eat()
        {
            Console.WriteLine("This animal is eating...");
        }
    }

    // Derived (Child) class representing a Dog, which is an Animal
    class Dog : Animal
    {
        // Method to represent the dog barking
        public void Bark()
        {
            Console.WriteLine("This dog is barking...");
        }
    }

    // Program class where the application starts
    class Program
    {
        static void Main(string[] args)
        {
            // Creating an instance of the Dog class
            Dog dog = new Dog();

            // Setting the name of the dog
            dog.Name = "Philip";

            // Calling the methods of the Dog class (inherited from Animal and its own)
            Console.WriteLine($"This dog's name is {dog.Name}.");  // Output: This dog's name is Philip.
            dog.Eat();  // Output: This animal is eating...
            dog.Bark(); // Output: This dog is barking...
        }
    }
}

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
---------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
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
---------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
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
---------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
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
---------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
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
---------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
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
---------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

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

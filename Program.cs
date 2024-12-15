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
---------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
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
---------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
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

---------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
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
---------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------



namespace InputDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to my Demo!");

            // First we need to prompt our user for some information. We should use Write for this as it will be more intuitive for the user. Don't forget to add a space at the end of your message otherwise the input will appear right next to your prompt and that won't look very nice.

            Console.Write("Enter your first name: ");

            // Console.ReadLine() will take the input from the console as a string. We need to assign the input to a variable in order to store it. Otherwise we won't be saving it anywhere.
            string firstName = Console.ReadLine();

            Console.Write("Enter your first name: ");
            string lastName = Console.ReadLine();

            //// Concatenating strings ////
            // Strings are the primary way we deliver information to users.
            // There are several ways to display output and to use variables that we have retrieved from the user.

            // We can use the '+' operator to combine strings, a process called concatenation.
            Console.WriteLine("Hello " + firstName + " " + lastName + "! Nice to meet you!");

            // We can use "substitution parameters" to specify the locations where we want to put our variables
            // The process is this.
            // 1. We have our string literal, followed by a comma, then a comma seperated list of all of the variables we want to include in our string.
            // 2. Then in our string literal, we put {0} where we want the first variable to go, {1} the second, etc.
            // In the below example, {0} is related to the "firstName" variable, and {1} is related to the "lastName" variable
            //
            //                                                                       {0}        {1}
            Console.WriteLine("Hello {0} {1}! It is even nicer to meet you now!", firstName, lastName);

            // We can also use a process called "string interpolation", which is the easiest way to combine strings.
            // To do this, we write a string literal but right before the open double quotations we add the '$' character.
            // after that, we can add a variable to a string by wrapping them in curly braces.
            // String interpolation is by far the most common method to merge strings.
            // For example:
            //                |
            //                |
            //                v
            Console.WriteLine($"Hello {firstName} {lastName}, it is still nice to meet you!");

            // If we want to have any data type other than a string, we need to perform an operation called "Parsing". We need to take the string input, and parse it into the data type that we want.
            // If we are unable to parse the input into the correct data type, and error will throw and the application will quit.
            // Here we are parsing a string into a char data type, however if we enter more than a single character, the parsing will fail.
            Console.Write("Enter a single character: ");
            char character = char.Parse(Console.ReadLine());
            Console.WriteLine("The char you entered was " + character);

            // To get a integer we use int.Parse(). We could also use byte, short, or long here.
            // The same rules for parsing apply
            Console.Write("Enter a whole number: ");
            int wholeNumber = int.Parse(Console.ReadLine());

            Console.WriteLine($"The number you wrote was: {wholeNumber}");

            // To get a decimal number we can use a float, double, or decimal data type.
            Console.Write("Enter a decimal number: ");
            double decimalNumber = double.Parse(Console.ReadLine());

            Console.WriteLine("The decimal number you entered was: " + decimalNumber);

            // When writing numbers with decimal points, it is common to want to specify precision 
            // To specify precision we can use string interpolation to specify the number of digits we want to display by appending :N#,
            // where # is the number of decimal places you want to go to.
            // Here we will write the decimal number from before to a maximum of two digits.
            Console.WriteLine($"The decimal number to two decimal places is {decimalNumber:N2}");

            // If we want to write an output in a format specificall for money, we can use string interpolation again with the suffix ":c"
            // the :c suffix will add a $ character, separate the thousands with commas, and round the number to two decimal places.
            Console.WriteLine($"If only I had {decimalNumber:c} more, I could buy a tangerine.");

            // To learn more about formatting console output, please see the following links:
            // https://lms.nait.ca/d2l/le/content/36982/viewContent/2120998/View
            // https://learn.microsoft.com/en-us/dotnet/csharp/language-reference/tokens/interpolated
            // https://learn.microsoft.com/en-us/dotnet/standard/base-types/standard-numeric-format-strings?redirectedfrom=MSDN

            Console.WriteLine("Goodbye!");
        }
    }
}

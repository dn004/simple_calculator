
using System;

class Calculator
{
    static void Main()
    {
        Console.WriteLine("Welcome to the Simple Calculator!");

        while (true)
        {
            // Display the menu options to the user
            Console.WriteLine("\nMenu:");
            Console.WriteLine("1. Add");
            Console.WriteLine("2. Subtract");
            Console.WriteLine("3. Multiply");
            Console.WriteLine("4. Divide");
            Console.WriteLine("5. Square");
            Console.WriteLine("6. Square Root");
            Console.WriteLine("7. π (pi)");
            Console.WriteLine("8. Exit");

            // Get the user's choice
            Console.Write("Enter your choice (1-8): ");
            string choiceStr = Console.ReadLine();

            if (!int.TryParse(choiceStr, out int choice))
            {
                Console.WriteLine("Invalid input. Please enter a valid number.");
                continue;
            }

            // Perform the corresponding operation based on the user's choice
            switch (choice)
            {
                case 1: // Addition
                    PerformAddition();
                    break;

                case 2: // Subtraction
                    PerformSubtraction();
                    break;

                case 3: // Multiplication
                    PerformMultiplication();
                    break;

                case 4: // Division
                    PerformDivision();
                    break;

                case 5: // Square
                    PerformSquare();
                    break;

                case 6: // Square Root
                    PerformSquareRoot();
                    break;

                case 7: // π (pi)
                    PerformPi();
                    break;

                case 8: // Exit the program
                    Console.WriteLine("Thank you for using the Simple Calculator!");
                    return;

                default:
                    Console.WriteLine("Invalid choice. Please select a valid option (1-8).");
                    break;
            }
        }
    }

    // Helper method to read a double input from the user
    static double GetInput(string message)
    {
        Console.Write(message);
        string inputStr = Console.ReadLine();
        if (double.TryParse(inputStr, out double value))
        {
            return value;
        }
        else
        {
            Console.WriteLine("Invalid input. Please enter a valid number.");
            return GetInput(message);
        }
    }

    // Helper method to perform addition
    static void PerformAddition()
    {
        double num1 = GetInput("Enter the first number: ");
        double num2 = GetInput("Enter the second number: ");
        double result = num1 + num2;
        Console.WriteLine($"Result: {result}");
    }

    // Helper method to perform subtraction
    static void PerformSubtraction()
    {
        double num1 = GetInput("Enter the first number: ");
        double num2 = GetInput("Enter the second number: ");
        double result = num1 - num2;
        Console.WriteLine($"Result: {result}");
    }

    // Helper method to perform multiplication
    static void PerformMultiplication()
    {
        double num1 = GetInput("Enter the first number: ");
        double num2 = GetInput("Enter the second number: ");
        double result = num1 * num2;
        Console.WriteLine($"Result: {result}");
    }

    // Helper method to perform division
    static void PerformDivision()
    {
        double num1 = GetInput("Enter the first number: ");
        double num2 = GetInput("Enter the second number: ");
        if (num2 == 0)
        {
            Console.WriteLine("Error: Cannot divide by zero.");
        }
        else
        {
            double result = num1 / num2;
            Console.WriteLine($"Result: {result}");
        }
    }

    // Helper method to calculate the square of a number
    static void PerformSquare()
    {
        double num = GetInput("Enter a number: ");
        double result = num * num;
        Console.WriteLine($"Square of {num}: {result}");
    }

    // Helper method to calculate the square root of a number
    static void PerformSquareRoot()
    {
        double num = GetInput("Enter a number: ");
        if (num < 0)
        {
            Console.WriteLine("Error: Cannot calculate square root of a negative number.");
        }
        else
        {
            double result = Math.Sqrt(num);
            Console.WriteLine($"Square root of {num}: {result}");
        }
    }

    // Helper method to calculate π (pi)
    static void PerformPi()
    {
        double pi = Math.PI;
        Console.WriteLine($"π (pi): {pi}");
    }
}

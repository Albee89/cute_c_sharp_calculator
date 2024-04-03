using System;
using System.Collections.Generic;


class Calculator
{
    static Dictionary<string, double> calculations = new Dictionary<string, double>();

    static void Main(string[] args)
    {
        while (true)
        {
            Console.WriteLine("Welcome to the Cute Calc!");
            Console.WriteLine("1. Calculator");
            Console.WriteLine("2. List Saved Calculations, or ");
            Console.WriteLine("3. Exit");

#pragma warning disable CS8600 // Converting null literal or possible null value to non-nullable type.
            string choice = Console.ReadLine();
#pragma warning restore CS8600 // Converting null literal or possible null value to non-nullable type.

            switch (choice)
            {
                case "1":
                    PerformCalculation();
                    break;
                case "2":
                    ListSavedCalculations();
                    break;
                case "3":
                    return;
                default:
                    Console.WriteLine("Invalid choice. Please try again.");
                    break;
            }
        }
    }

    static void PerformCalculation()
    {
        Console.WriteLine("Enter the name for this calculator: ");
#pragma warning disable CS8600 // Converting null literal or possible null value to non-nullable type.
        string name = Console.ReadLine();
#pragma warning restore CS8600 // Converting null literal or possible null value to non-nullable type.

        Console.WriteLine("Enter sum: ")
    ;
#pragma warning disable CS8600 // Converting null literal or possible null value to non-nullable type.
        string expression = Console.ReadLine();
#pragma warning restore CS8600 // Converting null literal or possible null value to non-nullable type.

        try
        {
            double result = EvaluateExpression(expression);
            calculations[name] = result;
            Console.WriteLine($"Calculation '{name}' result: {result}");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Error: {ex.Message}");
        }
    }

    static double EvaluateExpression(string expression)
    {
        // You'll need to implement a proper expression evaluator here,
        // depending on the complexity of expressions you want to support.
        // For simplicity, let's assume simple arithmetic operations for now.
        return Convert.ToDouble(new System.Data.DataTable().Compute(expression, null));
    }

    static void ListSavedCalculations()
    {
        Console.WriteLine("Saved Calculations:");
        foreach (var kvp in calculations)
        {
            Console.WriteLine($"{kvp.Key}: {kvp.Value}");
        }
    }
}

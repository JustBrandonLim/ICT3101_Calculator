using Newtonsoft.Json.Linq;
using System;

public class Calculator
{
    public Calculator() { }
    public double DoOperation(double num1, double num2, string op)
    {
        double result = double.NaN; // Default value
                                    // Use a switch statement to do the math.
        switch (op)
        {
            case "a":
                result = Add(num1, num2);
                break;
            case "s":
                result = Subtract(num1, num2);
                break;
            case "m":
                result = Multiply(num1, num2);
                break;
            case "d":
                // Ask the user to enter a non-zero divisor.
                result = Divide(num1, num2);
                break;
            case "f":
                result = Factorial(num1);
                break;
            case "t":
                result = Triangle(num1, num2);
                break;
            case "c":
                result = Circle(num1);
                break;
            case "u":
                result = UnknownFunctionA(num1, num2);
                break;
            // Return text for an incorrect option entry.
            default:
                break;
        }
        return result;
    }
    public double Add(double num1, double num2)
    {
        string concatenated = num1.ToString() + num2.ToString();
        if (IsBinaryString(concatenated))
        {
            int decimalValue = Convert.ToInt32(concatenated, 2);
            return decimalValue;
        }
        else
        {
            return (num1 + num2);
        }
    }
    public double Subtract(double num1, double num2)
    {
        return (num1 - num2);
    }
    public double Multiply(double num1, double num2)
    {
        return (num1 * num2);
    }
    public double Divide(double num1, double num2)
    {
        if (num1 == 0)
        {
            if (num2 == 0)
            {
                // When both a and b are 0, return 1
                return 1.0;
            }
            else
            {
                // When a is 0 and b is not 0, return 0
                return 0.0;
            }
        }
        else if (num2 == 0)
        {
            // When b is 0 and a is not 0, return positive infinity
            return double.PositiveInfinity;
        }
        else
        {
            // Normal division when neither a nor b is 0
            return num1 / num2;
        }
    }
    public double Divide_Zero(double num1, double num2)
    {
        if (num1 == 0 || num2 == 0)
        {
            throw new ArgumentException();
        }
        else
        {
            return (num1 / num2);
        }
    }

    public double Factorial(double num1) 
    { 
        if ( num1 < 0 || num1 % 1 != 0)
        {
            throw new ArgumentException("Factorial is not defined for negative values or non-whole numbers.");
        }

        if ( num1 == 0 || num1 == 1)
        {
            return 1;
        }

        return num1 * Factorial(num1 - 1);
    }
    public double Triangle(double num1, double num2)
    {
        return (num1 * num2 * 0.5);
    }
    public double Circle(double num1)
    {
        return (num1 * 3.142 * num1);
    }
    public double UnknownFunctionA(double num1, double num2)
    {
        if (num1 < 0 || num2 < 0 || num1 < num2)
        {
            throw new ArgumentException();
        }
        return Divide(Factorial(num1), Factorial(Subtract(num1, num2)));
    }
    public double UnknownFunctionB(double num1, double num2)
    {
        if (num1 < 0 || num2 < 0 || num1 < num2)
        {
            throw new ArgumentException();
        }

        return Divide(Factorial(num1), Multiply(Factorial(num2), Factorial(Subtract(num1, num2))));
    }

    public double Availability(double num1, double num2)
    {
        if (num1 < 0 || num2 < 0)
        {
            throw new ArgumentException();
        }

        return Multiply(Divide(num1,Add(num1,num2)),100);
    }
    public double FailureIntensity(double num1, double num2, double num3)
    {
        if (num1 < 0 || num2 < 0)
        {
            throw new ArgumentException();
        }

        return Math.Round(Multiply(num1, Subtract(1,Divide(num2,num3))), MidpointRounding.AwayFromZero);
    }
    public double ExpectedFailure(double num1, double num2, double num3)
    {
        if (num1 < 0 || num2 < 0)
        {
            throw new ArgumentException();
        }
        
        return Math.Round(Multiply(num1, Subtract(1, Math.Exp(Multiply(-1, Multiply(Divide(num2, num1), num3))))), MidpointRounding.AwayFromZero);
    }

    public double SSI(double num1, double num2, double num3, double num4)
    {
        if (num1 < 0 || num2 < 0)
        {
            throw new ArgumentException();
        }

        return Subtract(Subtract(Add(num1, num2),num3),num4);
    }
    public double LogarithmicFailureIntensity(double num1, double num2, double num3)
    {
        if (num1 < 0 || num2 < 0)
        {
            throw new ArgumentException();
        }

        return Math.Round(Multiply(num2, Math.Exp(Multiply(-1,Multiply(num1, num3)))),2);
    }
    public double LogarithmicExpectedFailure(double num1, double num2, double num3)
    {
        if (num1 < 0 || num2 < 0)
        {
            throw new ArgumentException();
        }

        return Math.Round(Multiply(Divide(1,num1),Math.Log(Add(Multiply(Multiply(num2, num1),num3),1))), MidpointRounding.AwayFromZero);
    }

    public bool IsBinaryString(string input)
    {
        foreach (char c in input)
        {
            if (c != '0' && c != '1')
            {
                return false;
            }
        }
        return true;
    }

    public double GenMagicNum(double input, IFileReader fileReader)
    {
        double result = 0;
        int choice = Convert.ToInt16(input);
        string[] magicStrings = fileReader.Read("../../../../ICT3101_Calculator/MagicNumbers.txt");
        if ((choice >= 0) && (choice < magicStrings.Length))
        {
            result = Convert.ToDouble(magicStrings[choice]);
        }
        result = (result > 0) ? (2 * result) : (-2 * result);
        return result;
    }

}

public interface IFileReader
{
    string[] Read(string path);
}

public class FileReader : IFileReader
{
    public string[] Read(string path)
    {
        return File.ReadAllLines(path);
    }
}


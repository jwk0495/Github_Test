namespace Example_4;

public class UMLEx
{
    static void Main()
    {
        Calculator calculator = new Calculator();
        calculator.Total = calculator.Power(2, 5);
        calculator.DisplayResult();
    }
}

/*
public class Person
{
    public string Name { get; set; }
    public string PhoneNumber { get; set; }
    public Address Address { get; set; }

    public void Walk()
    {
    }

    public void Run()
    {
    }

    public void Speak()
    {
    }
}

public class Address
{
    public string Street { get; set; }
    public string City { get; set; }
    public string State { get; set; }
    public string PostalCode { get; set; }
    public string Country { get; set; }
}

public class Student : Person
{
    string StudentNumber { get; set; }

    public void GetStudentNumber(string number)
    {
    }

    public void Introduce()
    {
    }
}

public class Professor : Person
{
    public string Salary { get; set; }

    public string Department { get; set; }

    public void Teach()
    {
    }
}

*/
public interface ICalculator
{
    double Devide(double inputA, double inputB);
    double Add(double inputA, double inputB);
    double Subtract(double inputA, double inputB);
    double Multiply(double inputA, double inputB);
}

public interface IEngineeringClaculator : ICalculator
{
    double Power(double inputA, double inputB);
    double SquareRoot(double input);
    double Sin(double angle);
    double Cos(double angle);
}

public class Calculator : IEngineeringClaculator
{
    public double Total { get; set; }

    public void DisplayResult()
    {
        Console.WriteLine($"result: {Total}");
    }

    public double Add(double inputA, double inputB)
    {
        return inputA + inputB;
    }

    public double Subtract(double inputA, double inputB)
    {
        return inputA - inputB;
    }

    public double Multiply(double inputA, double inputB)
    {
        return inputA * inputB;
    }

    public double Devide(double inputA, double inputB)
    {
        return inputA * inputB;
    }

    public double Power(double inputA, double inputB)
    {
        return Math.Pow(inputA, inputB);
    }

    public double SquareRoot(double input)
    {
        return Math.Sqrt(input);
    }

    public double Sin(double input)
    {
        return Math.Sin(input);
    }

    public double Cos(double input)
    {
        return Math.Cos(input);
    }
}
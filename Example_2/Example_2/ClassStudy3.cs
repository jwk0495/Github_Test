namespace Example_3;

public class ClassStudy3
{
    static void Main1()
    {
        float result;
        Calculator BasicCal = new Calculator();

        string input = Console.ReadLine();
        char[] opers = { '+', '-', '*', '/' };

        string[] numberstr = input.Split(opers);
        float number1;
        float number2;

        if (float.TryParse(numberstr[0], out number1) && float.TryParse(numberstr[1], out number2))
        {
            foreach (char oper in input)
            {
                if (oper == '+')
                {
                    result = BasicCal.Add(number1, number2);
                    BasicCal.Total = result;
                }

                else if (oper == '-')
                {
                    result = BasicCal.Subtract(number1, number2);
                    BasicCal.Total = result;
                }
                else if (oper == '*')
                {
                    result = BasicCal.Multiply(number1, number2);
                    BasicCal.Total = result;
                }
                else if (oper == '/')
                {
                    result = BasicCal.Divide(number1, number2);
                    BasicCal.Total = result;
                }
            }

            BasicCal.PrintResult();
        }

        else
            Console.WriteLine("유효하지 않은 연산자 입니다.");
    }
}

public class Calculator
{
    public float Total { get; set; } // 숫자가 최정적으로 저장되는 Property

    public void PrintResult()
    {
        Console.WriteLine($"결과는 {Total} 입니다.");
        Total = 0; // 계산값 초기화
    }

    public float Add(float number1, float number2)
    {
        return number1 + number2;
    }

    public float Subtract(float number1, float number2)
    {
        return number1 - number2;
    }

    public float Multiply(float number1, float number2)
    {
        return number1 * number2;
    }

    public float Divide(float number1, float number2)
    {
        return number1 / number2;
    }
}
namespace Example_2;

public class ClassStudy3_2
{
    public static void Main1()
    {
        Calculator1 BasicCal = new Calculator1();
        ConsoleKeyInfo info;
        
        // do-while문 사용
        do
        {
            Console.Write("계산식을 입력해 주세요 : ");

            string input = Console.ReadLine();
            char oper = '\0';
            string number1 = ""; // 연산자 기준 앞 숫자 저장
            string number2 = ""; // 연산자 기준 뒤 숫자 저장
            bool isOperFound = false;

            for (int i = 0; i < input.Length; i++) // 입력값 탐색
            {
                if (!isOperFound && (input[i] == '+' || input[i] == '-' || input[i] == '*' || input[i] == '/'))
                {
                    oper = input[i];
                    isOperFound = true;
                }

                else if (!isOperFound)
                    number1 += input[i];

                else if (isOperFound)
                    number2 += input[i];
            }

            if (float.TryParse(number1, out float result1) && float.TryParse(number2, out float result2))
                switch (oper)
                {
                    case '+': BasicCal.Total = BasicCal.Add(result1, result2); break;
                    case '-': BasicCal.Total = BasicCal.Subtract(result1, result2); break;
                    case '*': BasicCal.Total = BasicCal.Multiply(result1, result2); break;
                    case '/': BasicCal.Total = BasicCal.Divide(result1, result2); break;
                    default:
                        Console.WriteLine("유효하지 않은 연산자 입니다.");
                        return;
                }

            BasicCal.PrintResult();

            Console.Write("추가로 계산하시겠습니까? (Y/N)");
            info = Console.ReadKey();
            Console.WriteLine();
        }
        
        while (info.Key == ConsoleKey.Y);
        
        Console.WriteLine("프로그램을 종료합니다.");
    }
    
}

public class Calculator1
{
    public float Total { get; set; } // 숫자가 최정적으로 저장되는 Property

    public void PrintResult()
    {
        Console.WriteLine($"결과는 {Total} 입니다.");
        Total = 0;  // 계산값 초기화
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
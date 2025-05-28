using System;

public class Program
{
    public static void Main(string[] args)
    {
        byte data;  // 8bit data
        int number = 5;
        float speed = 5.66f;
        double value = 123456789123.4f;
        char input = 'a';
        string name = "chunsik Lee";
        bool isActive = false; // or true

        int[] numbers = new int[4]; // 공간만 할당, 공간에는 0이 default로 들어있음
        int[] numbers2 = { 1, 2, 5, 10 };
        int[] numbers3 = new int[5] { 5, 3, 5, 7, 6 };


        Console.WriteLine("Hello, World!");
        Console.WriteLine(numbers2[1]);
        numbers2[2] = 8;
        Console.WriteLine(numbers2[2]);
        Console.WriteLine(numbers2.Length);
        Console.WriteLine(numbers2.Rank); // 1차원 배열

        Console.WriteLine("---------------------");
        numbers2.CopyTo(numbers, 0); // numbers2의 정보를 numbers의 0번쨰 인덱스부터 붙여넣기
        for (int i = 0; i < numbers.Length; i++)
        {
            Console.WriteLine(numbers[i]);
        }

        Console.WriteLine("---------------------");
        Array.Reverse(numbers);// 메소드의 오버로드: 같은 이름으로 여러 기능
        for (int i = 0; i < numbers.Length; i++)
        {
            Console.WriteLine(numbers[i]);
        }

        int[,] matrix = new int[3, 3] 
        { 
            { 3, 2, 1 }, 
            { 2, 3, 4 }, 
            { 4, 5, 6 } 
        };
        matrix[1, 2] = 10;

        // if 조건문
        if (matrix[1, 2] == 10)
        {
            matrix[1, 2] = 5;
        }
        
        if(isActive)
        {
            Console.WriteLine("활성화 되었습니다.");
        }
        else
        {
            Console.WriteLine("비활성화 되었습니다.");
        }

        if (number >= 0)
        {
            Console.WriteLine("0 이상입니다.");
        }
        else if(number > 5 && number < 10)
        {
            Console.WriteLine("5초과, 10미만입니다,");
        }
        else if(number > 20 && number <30)
        {
            Console.WriteLine("20초과, 30미만입니다.");
        }
        else
        {
            Console.WriteLine("나머지 조건입니다.");
        }
    }
}
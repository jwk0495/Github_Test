// See https://aka.ms/new-console-template for more information
using System;

public class Program
{
    public enum Weekday
    { 
        Sunday,
        Monday,
        Tuesday,
        Wednesday,
        Thursday,
        Friday,
        Saturday

    }

    public enum Color
    { 
        Red = 0xff000,
        Green = 0x00ff00,
        Blue = 0x0000ff
    }
    public enum State
    { 
        작동중,
        정지,
        긴급,
        오류

    }
    public static void Main(string[] args)
    {
        byte data; //8bit
        int number = 5;
        float speed = 5.66f;
        double value = 456456456.5f;
        char input = 'a';
        string name = "chiho lee";
        bool isActive = true;
        int[] numbers = new int[5]; //공간만 할당 나머지구간 0
        int[] numbers2 = { 1, 2, 5, 10 };
        int[] numbers3 = new int[5] { 5, 3, 5, 7, 6 };


        Console.WriteLine("Hello, World!");
        Console.WriteLine(numbers2[1]);
        numbers2[2] = 8;
        Console.WriteLine(numbers2[2]);
        Console.WriteLine(numbers2.Length);
        Console.WriteLine(numbers2.Rank);

        Console.WriteLine("----------------");
        numbers2.CopyTo(numbers, 0);
        for (int i = 0; i < numbers.Length; i++)
        {
            Console.WriteLine(numbers[i]);


        }

        Console.WriteLine("-----------");
        Array.Reverse(numbers);
        for (int i = 0; i < numbers.Length; i++)
        { 
            Console.WriteLine(numbers[i]);
        }
        int[,] matrix = new int[3, 3]
        {
            {3,2,1 },
            {2,3,4 },
            {4,5,6 }
        };
        matrix[1, 2] = 10;

        // if 조건문
        if (matrix[1, 2] == 10) ;
        {
            matrix[1, 2] = 5;
        }

        if (isActive == true)
        {
            Console.WriteLine("활성화 되었습니다");
        }

        else
        {
            Console.WriteLine("비활성화 되었습니다");
        }
        if (number >= 0)
        {
            Console.WriteLine("0 이상 입니다");

        }
        else if (number > 5 && number < 10)
        {
            Console.WriteLine("5초과 10 미만입니다");

        }

        else if (number > 20 && number < 30)
        {
            Console.WriteLine("20초과 30미만입니다");

        }
        else 
        {
            Console.WriteLine("나머지 조건입니다");
        }

        switch (number)
        {
            case 0:
                Console.WriteLine("0입니다");
                break;
            case 1:
                Console.WriteLine("1입니다");
                break;
            case 2:
                Console.WriteLine("2입니다");
                break;
            case 3:
                Console.WriteLine("3입니다");
                break;
            default:
                Console.WriteLine("defualt 입니다");
                break;

        }
        // for 반복문
        for (int i = 0; i < 10; i++)
        {
            Console.WriteLine(i + "번 입니다");

        }
        for (int i = 0; i < numbers3.Length; i++)
        {
            Console.WriteLine(numbers3[i]+"번"); 
           
        }

        string[] names = { "Alice", "Bob", "Chalie" };
        foreach (string n in names)
        {
            Console.WriteLine(n + "입니다");
        }

        isActive = true;

        while (isActive)
        {
            Console.WriteLine("isActive");

            if (isActive)
                break;
        }

        int k = 0;
        while (k < 10)
        { 
            Console.WriteLine(k+"번 입니다");
            k++;
        }

        int j= 0;

        do 
        {
            Console.WriteLine(j + "번 입니다");
            j++;

        }while (j < 10);


        string[] nameList = { "이치호", "김정완", "박건율", "전주호" };
        for (int i = 0; i < nameList.Length; i++)
        {
            string myname = nameList[i];
            
            if (myname == "이치호")
            { 
               Console.WriteLine("내 이름은"+myname+"입니다" ); 
            }
        }

        int[,] matrix2 = new int[4, 4]
        {
            {1,2,3,4 },
            {5,6,7,8 },
            {9,10,11,12 },
            {13,14,15,16 }
        };

        int sum = 0;

        for (int i = 0; i < matrix2.GetLength(0); i++) // 행 수
        {
            for (int t = 0; t < matrix2.GetLength(1); t++) // 열 수
            {
                sum += matrix2[i, t];
            }
        }

        Console.WriteLine("행렬 요소의 합: " + sum);  // 출력: 21
        //Test

        //250528
        //열거형

        Weekday weekday = Weekday.Monday;

        switch (weekday)
        { 
            case Weekday.Monday:
                break;
            case Weekday.Tuesday:
                break;
            case Weekday.Wednesday:
                break;
            case Weekday.Thursday:
                break;
            case Weekday.Friday:
                break;
            case Weekday.Saturday:
                break;
            case Weekday.Sunday:
                break;
        }

        State state = State.작동중;
        
        
    }
}
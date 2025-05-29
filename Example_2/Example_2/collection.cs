using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example_2
{
    // 컬렉션: 배열처럼 여러개의 데이터를 하나의 객체로 관리하는 기능
    // 장점
    // 1. 데이터 관리를 위해 간결한 코드작성이 가능
    // 2. 데이터 검색, 정렬을 효율적으로 수행 가능
    // 3. 다양한 데이터 유형을 저장 가능

    class collection
    {
        static int[] numberArray = new int[5] { 1, 2, 3, 4, 5 };
        static List<int> numberList = new List<int>() { 1, 2, 3, 4, 5 };

        static void Main123()
        {
            int[] numberArray = new int[5] { 1, 2, 3, 4, 5 }; // 고정형
            List<int> numberList = new List<int>() { 1, 2, 3, 4, 5 }; // 가변형

            // numberArray[6] = 10; // 배열은 정해진 인덱스만 접근 가능
            numberList.Add(6);
            numberList.Add(7);
            numberList.Add(8);

            numberList.Remove(6); // 특정 정보를 지운다
            numberList.RemoveAt(2); // 특정 인덱스의 정보를 지운다
            numberList.Reverse(); // 정보를 역순으로 바꾼다.

            Console.WriteLine("배열의 크기 : " +numberList.Count);
            numberList.Clear();
            Console.WriteLine("초기화 후 배열의 크기 : " +numberList.Count);

            foreach (int number in numberList)
                Console.WriteLine(number);

            // array는 int, float, double 기존의 자료형만 넣을 수 있음
            // 컬렉션은 클래스, 인터페이스, 구조체
            List<collection> collections = new List<collection>();
            // 여러 클래스를 여러개의 객체로 만들 수 있음.
            
            // 1. Stack
            Stack<string> books = new Stack<string>();
            books.Push("마인드 셋");
            books.Push("인간 관계론");
            books.Push("노인과 바다");
            
            // books.pop();

            foreach (var book in books)
                Console.WriteLine(book);
            
            books.Clear();
            
            // 2. Queue
            Queue<char> characters = new Queue<char>();
            characters.Enqueue('A');
            characters.Enqueue('B');
            characters.Enqueue('C');
            characters.Enqueue('D');

            // characters.Dequeue(); //가장 먼저 들어온 순서대로 제거
            foreach (char c in characters)
                Console.WriteLine(c);
            
            // 3. HashSet : 중복된 값은 무시함
            HashSet<string> names = new HashSet<string>();
            names.Add("손흥민");
            names.Add("봉준호");
            names.Add("김정완");
            names.Add("김정완");

            Console.WriteLine("김정완 있나요? " + names.Contains("김정완"));
            foreach (var name in names)
                Console.WriteLine(name);

            if (!names.Contains("김종환"))
                Console.WriteLine("김종환이 포함되어있지 않습니다.");
            
            // 4. Dictionary : Key - Value 를 사용하여 데이터를 저장
            Dictionary<string, string> englishDictionary = new Dictionary<string, string>();
            // englishDictionary.Add("책", "book");
            englishDictionary.Add("사전", "dictionary");
            englishDictionary.Add("우유", "milk");
            englishDictionary.Add("초콜릿", "chocolate");

            if(!englishDictionary.ContainsKey("책"))
            {
                Console.WriteLine("책이 포함되어있지 않습니다.");
                englishDictionary.TryAdd("책", "book");
            }
            Console.WriteLine("사전의 의미는 : " + englishDictionary["사전"]);
        }
    }
}
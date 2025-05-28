namespace Example_2;

// Collection : 배열처럼 여러개의 데이터를 하나의 객체로 관리하는 기능
/*
장점
    1. 데이터 관리를 위해 간결한 코드작성이 가능
    2. 데이터 검색, 정렬을 효율적으로 수행 가능
    3. 다양한 데이터 유형을 저장 가능
*/

public class collection
{
    static void Main3()
    {
        int[] numberArray = new int[5] { 1, 2, 3, 4, 5 }; // 고정형
        List<int> numberList = new List<int>() { 1, 2, 3, 4, 5 }; // 가변형

        numberList.Add(6);
        numberList.Add(7);
        numberList.Add(8);
        
        // array는 int, float, duoble 기존의 자료형만 넣을 수 있음
        // Collection은 클래스, 인터페이스, 구조체 등을 넣을 수 있다.
        
        List<collection> collectionList = new List<collection>();
        // 여러 클래스를 여러개의 객체로 만들 수 있음.
    }
}
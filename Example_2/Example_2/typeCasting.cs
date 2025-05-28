namespace Example_2;

class typeCasting
{
    // 전역 변수 (Global Vairable)
    private int value = 0;  // Class 안의 변수는 Private이 Default
    const float pi = 3.141592f; // 상수이기 때문에 바뀌지 않음.
    
    /*
    암시적 형변환
        char -> int -> long ->  float  -> double
    */
    
    public static void Main2()
    {
        // 지역 변수 (Local Vairable)
        int a = 5;
        double b = 413.6;
        float number = 3.14f;
        
        // 1. 암시적 형변환
        double c = a;   // 변수의 크기에 따라 큰 변수 <- 작은 변수

        // 2. 명시적 형변환
        int d =(int)b;  // duoble -> int로 변환 413
        int e = (int)number;
        int f = Convert.ToInt32(b);
        int g = Int32.Parse("530"); // 문자의 경우 Parse, TryParse 사용
        
        //Convert.ToBoolean, ToDuoble, ToString
    }
}
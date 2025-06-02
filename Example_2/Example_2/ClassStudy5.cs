// 인터페이스 (Interface) : C++의 다중 상속을 보완한 기능. C#에서는 Interface를 다중 상속 가능

namespace Example_3;

public class ClassStudy5
{
    static void Main123()
    {
        
    }
}

public class Animal : IMovable, ISpeakable
{
    public string Type { get; set; }
    public int legCNt { get; set; }

    public Animal(string type, int legCNt)
    {
        Type = type;
        legCNt = legCNt;
    }

    public void Move()
    {
        throw new NotImplementedException();
    }

    public void Speak()
    {
        throw new NotImplementedException();
    }
}

public interface IMovable
{
    // abstrcat 메소드와 같이 구현 필수
    void Move()
    {
        Console.WriteLine("움직이는중...");
    }
}

public interface ISpeakable
{
    void Speak()
    {
        Console.WriteLine("말하는중...");
    }
}
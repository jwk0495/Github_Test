using System.Numerics;
using Example_2_2;

namespace Example_2;

public class ValueReferencType
{
    // 구조체
    public struct Point
    {
        public int x { get; set; }
        public int y { get; set; }

        public Point(int _x, int _y)
        {
            x = _x;
            y = _y;
        }

        public void Translate(int dx, int dy)
        {
            x += dx;
            y += dy;
        }
    }

    static void Main123()
    {
        // value Type으로 Stack에 저장됨.
        int a = 10;
        int b = 20;

        Console.WriteLine(a + b); // Call By Value

        // Reference Type : 동적할당, 주소(Pointer)는 Stack에 저장되고, 그 안의 내용들은 Heap에 저장됨.
        StartcraftUnit unit = new StartcraftUnit("Marine", 5, 6);
        StartcraftUnit unit2 = unit;

        Console.WriteLine(unit2.HP); // Call By Reference -> 5
        unit2.HP = 10;
        // 참조형의 값을 바꿀 때, 다른 참조가 있는지 주의해야 함. -> 10
        Console.WriteLine(unit.HP);

        // 가비지 컬렉션 : 동적할당된 참조형 변수는 자동으로 메모리가 해제됨

        Point p1 = new Point(3, 4);
        p1.Translate(1, 2);
        List<Point> points = new List<Point>();

        Vector3 location = new Vector3(10, 30, 59);
    }
}
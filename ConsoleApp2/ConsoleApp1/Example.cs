#define Test
/*
Это простая программа на С#.
Назовем её example.cs
*/
using System;
using System.Reflection;
using System.Linq;
using System.Linq.Expressions;
using System.Threading;

class Switch {
    static void VhogfenieChisel() {
         int ch;
        for (ch = -100; ch <= 100; ch +=5) 
        switch (ch)
        {
            case 20:
                Console.WriteLine("ch include A");
            break;
            case 40:
                Console.WriteLine("ch include B");
            break;
            default:
                Console.WriteLine(ch);
            break;
        }
       
    }
}

class MyBuilding
{
    public int floors;
    public int area;
    public int occupants;
    public MyBuilding(int f, int a, int o)
    {
        floors = f;
        area = a;
        occupants = o;
    }
    public int AreaPP()
    {
        return area / occupants;
    }
    public int MaxO(int minaria)
    {
        return area / minaria;
    }
}
class MyBuildingDemo
{
    static void BuildingsMain()
    {
        MyBuilding home = new MyBuilding(2, 2500, 4);
        MyBuilding office = new MyBuilding(3, 4200, 25);
        Console.WriteLine("Максимальное количество человек в доме, \n"
            + "если на каждого должно приходится " + 300 + " " + home.MaxO(300));
        Console.WriteLine("Максимальное количество человек в офисе, \n"
            + "если на каждого должно приходится " + 100 + " " + office.MaxO(100));
        Console.WriteLine("Площадь на одного в доме, \n"
            + home.AreaPP());
        Console.WriteLine("Площадь на одного в офисе, \n"
            + office.AreaPP());


    }
}

class AssignARef
{
    static void MainMassive()
    {
        int i;
        int[] nums1 = new int[10];
        int[] nums2 = new int[10];
        for (i = 0; i < 10; i++) nums1[i] = i;
        for (i = 0; i < 10; i++) nums2[i] = -i;
        Console.WriteLine("содержимое массива nums1 до: ");
        for (i = 0; i <= nums1.Length - 1; i++)
        {
            Console.Write(nums1[i] + " ");
        }
        Console.WriteLine("\nсодержимое массива nums2 до: ");
        for (i = 0; i <= nums2.Length - 1; i++)
        {
            Console.Write(nums2[i] + " ");
        }
        nums1 = nums2;

        for (i = 0; i <= nums2.Length - 1; i++)
        {
            nums2[i] += 5; 
        }
        Console.WriteLine("\nсодержимое массива nums1 после: ");
        for (i = 0; i <= nums1.Length - 1; i++)
        {
            Console.Write(nums1[i] + " ");
        }
        Console.WriteLine("\nсодержимое массива nums2 после: ");
        for (i = 0; i <= nums2.Length - 1; i++)
        {
            Console.Write(nums2[i] + " ");
        }

    }
}
class Lineyka
{
    static void MainMassiveLineyka()
    {
        int i;
        int lcm = 30;
        int linch = (int) (lcm / 2.54);
        int[] cm = new int[lcm+1];
        int[] inch = new int[linch+1];
        for (i = 0; i <= lcm; i++)
        {
            cm[i] = i;
        }
        for (i = 0; i <= linch; i++)
        {
            inch[i] = i;
        }
        Console.WriteLine("линейка в см: ");
        for (i = 0; i < cm.Length; i++)
        {
            Console.Write(cm[i] + " ");
        }
        Console.WriteLine(cm.Length);
        Console.WriteLine("линейка в дюймах: ");
        for (i = 0; i < inch.Length; i++)
        {
            Console.Write(inch[i] + " ");
        }
        Console.WriteLine("\n" + inch.Length);
    }
}

class Stack
{
    char[] stck;
    int tos;
    //конструктор класса Stack
    public Stack(int size)
    {
        stck = new char[size];
        tos = 0;
    }
    //Помещение символов в стек
    public void Push(char ch)
    {
        if (tos == stck.Length)
        {
            Console.WriteLine("стек полный");
            return;
        }
        stck[tos] = ch;
        tos++;
    }
    //извлечь символ из стека
    public char Pop()
    {
        if(tos == 0)
        {
            Console.WriteLine("стек пуст");
            return (char)0;
        }
        tos--;
        return stck[tos];
    }
    //возвратить значение true если стек полон
    public bool IsFull()
    {
          return tos == stck.Length;
    }
    //возвратить значение true если стек пуст
    public bool IsEmpty()
    {
        return tos == 0;
    }
    //возвратить емкость стека
    public int Capasity()
    {
        return stck.Length;
    }
    //возвратить количество элементов в стеке
    public int GetNum()
    {
        return tos;
    }

}

class SteckDemo
{
    static void MainStack()
    {
        Stack stck1 = new Stack(10);
        Stack stck2 = new Stack(10);
        Stack stck3 = new Stack(10);
        Stack stck4 = new Stack(10);
        char ch = 'A';

        do {
            stck1.Push(ch);
            ch++;
        } 
        while (!stck1.IsFull());

        do
        {

            ch = stck1.Pop();
            stck3.Push(ch);
            stck2.Push(ch);
        }
        while (!stck1.IsEmpty());

        do
        {

            ch = stck3.Pop();
            stck1.Push(ch);
        }
        while (!stck3.IsEmpty());


        do
        {
            ch = stck1.Pop();
            Console.Write(ch);
        }
        while (!stck1.IsEmpty());
        Console.WriteLine();
        do
        {
            ch = stck2.Pop();
            Console.Write(ch);
        }
        while (!stck2.IsEmpty());
        Console.WriteLine();

    }
}

class MyClass
{
    int alpha, beta;
    public MyClass(int i, int j)
    {
        alpha = i;
        beta = j;
    }
    //возвратить значение true если парметр ob имеет те же значения, что и вызывающий обьект.
    public bool SameAs(MyClass ob)
    {
        if ((ob.alpha == alpha) & (ob.beta == beta))
            return true;
        else
            return false;
    }
    //сделать копию обьекта ob.
    public void Copy(MyClass ob)
    {
        alpha = ob.alpha;
        beta = ob.beta;
    }
    public void Show()
    {
        Console.WriteLine("alpha: {0}, beta: {1}", alpha, beta);
    }
}

class PassOb
{
    static void MainPeredachaObektov()
    {
        MyClass ob1 = new MyClass(4, 5);
        MyClass ob2 = new MyClass(6, 7);
        Console.WriteLine("ob1:");
        ob1.Show();
        Console.WriteLine("ob2:");
        ob2.Show();
        if (ob1.SameAs(ob2))
            Console.WriteLine("ob1 и ob2 имеют одинаковые значения.");
        else
            Console.WriteLine("ob1 и ob2 имеют разные значения.");
        Console.WriteLine();
        //а теперь сделать обьект ob1 копией обьекта ob2.
        ob1.Copy(ob2);
        Console.Write("ob1 и ob2 после копирования: ");
        ob1.Show();
        ob2.Show();
        if (ob1.SameAs(ob2))
            Console.WriteLine("ob1 и ob2 имеют одинаковые значения");
        else
            Console.WriteLine("ob1 и ob2 имеют разные значения");
    }
}
class Change
{
    public int[] ar = new int[3];
    //public int z = 0;
    public Change(int a, int b)
    {
        Console.WriteLine("a b до:" + a + " " + b);
    }
    public int[] ChangeRet(int a, int b)
    {
        Console.WriteLine("a b до:" + a + " " + b);
        a = a - b;
        b = b + a;
        a = b - a;
        ar[0] = a;
        ar[1] = b;
        Console.WriteLine("a b в модуле:" + ar[0] + " " + ar[1]);
        return ar;

    }

}

class MyProbe1
{
    static void MainChangeWithoutGet() //
    {
        int x = 10;
        int y = 50;
        Change ob = new Change(x, y);
        int[] ar1 = ob.ChangeRet(x, y);
        Console.WriteLine("a b в теле:" + ar1[0] + " " + ar1[1]);
    }
}

class RefTest
{
    //Этот метод изменяет свой аргумент с модификатором ref
    public void Sqr(ref int i)
    {
        i = i * i;
    }
}

class RefDemo
{
    static void MainMetodRef()
    {
        RefTest ob = new RefTest();
        int a = 10;
        Console.WriteLine("a до вызова: " + a );
        ob.Sqr(ref a);
        Console.WriteLine("a после вызова: " + a );
    }
}

class Decompose
{
    public int GetParts(double n, out double frac)
    {
        int whole;
        whole = (int)n;
        frac = n - whole;
        return whole;
    }
}
class UseOut
{
    static void MainSOUT()
    {
        Decompose ob = new Decompose();
        int i;
        double f;
        i = ob.GetParts(10.125, out f);
        Console.WriteLine("Целая часть числа: " + i);
        Console.WriteLine("Дробная часть числа: " + f);
    }
}

//Наименьший и наибольший общий множитель
class Num
{
    public Num(int a, int b, out int l, out int u)
    {
        l = (a > b ? (int)(b / 2) : (int)(a / 2));
        if (a != 0 && b != 0)
        {
            for (; a % l != 0 | b % l != 0; l--) ;
            for (u = 2; a % u != 0 | b % u != 0; u++) ;
        }
        else
        {
            l = 0;
            u = 0;
        }
    }
}

class DemoOut
{
    static void MainObshDel()
    {
        int x = 65;
        int y = 78;
        Num ob = new Num(x, y, out int max, out int min);
        Console.WriteLine("наибольший делитель " + x + " " + y + " = " + max );
        Console.WriteLine("наименьший делитель " + x + " " + y + " = " + min);
    }
}

class TenTaskMod
{
    int a, b;
    public TenTaskMod(string str, out char str1, out string stro)
    {
        str1 = str[0];
        stro = str.Substring(1, 2);
        Console.WriteLine("субстринг " + str1 + " " + stro);
    }
    public TenTaskMod(string str, int a, out char str1)
    {
        str1 = str[a];
        Console.WriteLine("перегрузка " + str1);
    }
    public int Ten(int a, int b)
    {
        return (a + b);
    }
    public int Ten(){
        return 4 + 4;
    }

}

class TenTaskMain
{
    static int MainSt(string[] args)
    {
        //проверить наличие аргументов
        if(args.Length < 1)
        {
            Console.WriteLine("нет аргументов");
            args = new string[] {
                "one", "two", "three", "four", "five", "six", "seven", "eight", "nine", "ten"
            };
            Console.WriteLine("первое вхождение " + args[0]);
        }
        TenTaskMod ch1 = new TenTaskMod(args[0], out char str1, out string stro);
        Console.WriteLine("субстринг " + str1 + " " + stro);
        TenTaskMod ch2 = new TenTaskMod(args[0], 2, out char str2);
        Console.WriteLine("итог str2 " + str2);

        int ch3 = ch2.Ten(2, 2);
        Console.WriteLine("вызов метода от 2 2 " + ch3);
        int ch4 = ch2.Ten();
        Console.WriteLine("перегрузка метода от 4 4 " + ch4);
        //TenTaskMod ch4 = new TenTaskMod();
        //Console.WriteLine("два по два "); 
        //string ch2 = new TenTaskMod();
        return 1;
    }
}
class Res1
{
    public string x, y, z;
    public string Res2(params string[] str)
    {
        string strr;
        if (str.Length == 0)
        {
            Console.WriteLine("массив пустой");
            return "x";
        }
        strr = str[0];
        for (int i = 0; i < str.Length; i++)
            strr = strr + str[i];
        strr = strr.Substring(10, 5);

        return strr;
    }
    public string Res2(int a = 5, params string[] str)
    {
        string strr;
        if (str.Length == 0)
        {
            Console.WriteLine("массив пустой");
            return "x";
        }
        strr = str[0];
        for (int i = 0; i < str.Length; i++)
            strr = strr + str[i];
        strr = strr.Substring(a, 5);

        return strr;
    }
    public string Res2(string z,string x, string y = "fuck")
    {
        return x + z + y;
    }
    public string Res2()
    {
        return x + z + y;
    }

}

class Res3
{
    static void MainVisovi()
    {
        Res1 ch4 = new Res1();
        string min, min2, min3, min4;
        string[] args = new string[] {
            "one", "two", "three", "four", "five", "six", "seven", "eight", "nine", "ten"
          };

        min = ch4.Res2(args);
        min2 = ch4.Res2(15, args);
        min3 = ch4.Res2("two", x :"five");
        Res1 ch5 = new Res1 { x = "dfg", y = "dfg", z = "trr" };
        min4 = ch5.Res2();
        Console.WriteLine("наименьшее значение " + " \n" + min + " \n" + min2 + " \n" + min3 + " \n" + min4);


    }
}

class Factorial1
{
    public int FactR1(int n)
    {
        int result;
        if (n == 1) return 1;
        result = FactR1(n - 1) * n;
        return result;
    }
}

class Recursion
{
    static void Main1()
    {
        Factorial1 f = new Factorial1();
        Console.WriteLine("факториал 3 равен " + f.FactR1(3));
    }
}

class Factorial
{
    public static int count = 0;
    public string OneCh(string One)
    {
        return One.Substring(0, 1);
    }
    public void Recurs(string One)
    {
        if (One.Length > 0)
            Recurs(One.Substring(1, One.Length - 1));

        else
            return;
       // Console.Write("chlen"+One[0]);
        Console.WriteLine("massive"+ One + "dlina" + One.Length);

    }
}
    class RecursionTX
    {
        static void MainOld()
        {
        string[] str = new string[]
        {
           "one", "two", "three", "four", "five", "six", "seven", "eight", "nine", "ten"
        };
        Factorial ob = new Factorial();
        string Sum = "start";
        foreach (string x in str)

        {
            Sum = Sum + ob.OneCh(x);
            Factorial.count++;
            Console.WriteLine("count 0" + Factorial.count);
        }

        Console.WriteLine("по пытка " + Sum);
        Console.WriteLine("count 1" + Factorial.count);
        //Console.WriteLine("по пытка " + ob.Recurs(Sum);
        ob.Recurs(Sum);
        Console.WriteLine("count 2" + Factorial.count + " ");
    }
    }

class Chih
{
    public string one, two;
    public string three;
    public Chih(string x, string y)
    {
        one = x;
        two = y;
    }

    public Chih()
    {
        one = "Ма";
        two = "кс";
    }
    public static Chih operator + (Chih op1, Chih op2)
    {
        Chih result = new Chih();
        result.one = op2.one + op2.two;
        result.two = " = ";
        result.three =  op1.one+op1.two;
        return result;
    }
    public void Show()
    {
        Console.WriteLine("sum with overload       " + one + two + three);
    }

}
class Overload
{
    static void MainOverload()
    {
        string a = "Мама + ", b = "Папа";
        Chih ob = new Chih();
        Chih ob1 = new Chih(a, b);
        Chih ob2 = ob + ob1;
        ob2.Show();
      }


}

class FailArr2
{
    int[,] a;
    int rows, cols;
    public int length;
    public bool errfl;
    public FailArr2(int r, int c)
    {
        rows = r;
        cols = c;
        a = new int[rows, cols];
        length = rows * cols;
    }
    public int this[int index1, int index2]
    {
        get
        {
            if (ok(index1, index2))
            {
                errfl = false;
                return a[index1, index2];
            }
            else
            {
                errfl = true;
                return 0;
            }
        }
        set
        {
            if (ok(index1, index2))
            {
                a[index1, index2] = value;
                errfl = false;
            }
            else
            {
                errfl = true;
            }
        }
    }
        private bool ok(int index1, int index2)
    {
        if (index1 >= 0 & index1 < rows & index2 >= 0 & index2 < cols)
            return true;
        return false;
    }
    
}

class IndexDemo
{
    static void MainAksessor()
    {
        FailArr2 fs = new FailArr2(3, 5);
        int x;
        Console.WriteLine("error");
        for (int i = 0; i < 6; i++)
            fs[i, i] = i * 10;
        for (int i=0; i < 6; i++)
        {
            x = fs[i, i];
            if (x != -1) Console.Write(x + " ");
        }
        Console.WriteLine();
    }
}

class TwoShape
{
    public double pri_width, pri_height;
    public TwoShape(double w, double h)
    {
        Width = w;
        Height = h;
    }
    public double Width

    {
        get { return pri_width; }
        set { pri_width = value < 0 ? -value : value; }
    }
    public double Height
    {
        get { return pri_height; }
        set { pri_height = value < 0 ? -value : value; }
    }
    public void ShowDim()
    {
        Console.WriteLine("Ширина и высота равны " + Width + " and " + Height);
    }

}

class Triangle:TwoShape
{
    public string Style;
    public Triangle(string s, double w, double h) : base(w, h)
    {
        Style = s;
    }
    public double Aria()
    {
        return Width * Height / 2;
    }
    public void ShowStyle()
    {
        Console.WriteLine("Треугольник " + Style);
    }
}

class Shapes
{
    static void MainNasledovanie()
    {
        Triangle t1 = new Triangle("равнобедренный", 4.0, 4.0);
        Triangle t2 = new Triangle("прямоугольный", 8.0, 12.0);
        t1.Width = 4.0;
        t1.Height = 4.0;
        t1.Style = "равнобедренный";
        t2.Width = 8.0;
        t2.Height = 12.0;
        t2.Style = "прямоугольный";
        Console.WriteLine("сведения о обьекте t1: ");
        t1.ShowStyle();
        t1.ShowDim();
        Console.WriteLine("площадь равна "+ t1.Aria());

    }
}

class Ponjat
{
    static int count = 0, id;
    public Ponjat()
    {
        id = count;
        count++;
    }
    public override string ToString()
    {
        return "Обьект № " + id + " типа MyClass";
    }
    public void Try22()
    {
        Console.WriteLine("8");
    }

}

class PolPon
{
    static void MainPeregruzkaBazovogoObjectToStrig()
    {
        Ponjat ob1 = new Ponjat();
        Console.WriteLine(ob1);
        Ponjat ob2 = new Ponjat();
        Console.WriteLine(ob2);
        Ponjat ob3 = new Ponjat();
        Console.WriteLine(ob3);
        ob1.Try22();
    }
}

public interface ISeries
{
    int Next
    {
        get; set;
    }
    int this[int index]
    {
        get;
    }
}

class MyIndex : ISeries
{
    int val;
    public MyIndex()
    {
        val = 0;
    }
    public int Next
    {
        get
        {
            val += 2;
            return val;
        }
        set
        {
            val = value;
        }
    }
    public int this[int index] { 
        get {
            val = 0;
            for(int i = 0; i < index; i++)
                val += 2;
                return val;
            
        }
    }
}

class SerDemo
{
    static void MainInterfIndex()
    {
        MyIndex ob = new MyIndex();
        for (int i = 0; i < 5; i++)
            Console.WriteLine("следующее число равно" + ob.Next);
        Console.WriteLine("начать с числа 21");
        ob.Next = 21;
        for (int i = 0; i < 5; i++)
            Console.WriteLine("следующее число равно " + ob.Next);
        Console.WriteLine("\nсбросить в о " + ob.Next);
        ob.Next = 0;
        for (int i = 0; i < 5; i++)
            Console.WriteLine("следующее число равно" + ob[i]);
       
    }
}
class ConveyorControl
{
    // Enumerate the conveyor commands. 
    public enum Action { Start, Stop, Forward, Reverse };

    public void Conveyor(Action com)
    {
        switch (com)
        {
            case Action.Start:
                Console.WriteLine("Starting conveyor.");
                break;
            case Action.Stop:
                Console.WriteLine("Stopping conveyor.");
                break;
            case Action.Forward:
                Console.WriteLine("Moving forward.");
                break;
            case Action.Reverse:
                Console.WriteLine("Moving backward.");
                break;
        }
    }
}

class ConveyorDemo
{
    static void MainPerechislenia()
    {
        ConveyorControl c = new ConveyorControl();

        c.Conveyor(((ConveyorControl.Action)0));
        c.Conveyor(ConveyorControl.Action.Forward);
        c.Conveyor(ConveyorControl.Action.Reverse);
        c.Conveyor(ConveyorControl.Action.Stop);

    }
}
class RangeArrayException : Exception
{
    /* Implement all of the Exception constructors. Notice that 
       the constructors simply execute the base class constructor. 
       Because NonIntResultException adds nothing to Exception, 
       there is no need for any further actions. */
    public RangeArrayException() : base() { }
    public RangeArrayException(string message) : base(message) { }
    public RangeArrayException(string message, Exception innerException) :
      base(message, innerException)
    { }
    protected RangeArrayException(
      System.Runtime.Serialization.SerializationInfo info,
      System.Runtime.Serialization.StreamingContext context) :
        base(info, context)
    { }

    // Override ToString for RangeArrayException. 
    public override string ToString()
    {
        return Message;
    }
}
class RangeArray
{
    // Private data. 
    int[] a; // reference to underlying array   
    int lowerBound; // smallest index 
    int upperBound; // largest index 

    // An auto-implemented, read-only Length property. 
    public int Length { get; private set; }

    // Construct array given its size.  
    public RangeArray(int low, int high)
    {
        high++;
        if (high <= low)
        {
            throw new RangeArrayException("Low index not less than high.");
        }
        a = new int[high - low];
        Length = high - low;

        lowerBound = low;
        upperBound = --high;
    }

    // This is the indexer for RangeArray.  
    public int this[int index]
    {
        // This is the get accessor.  
        get
        {
            if (ok(index))
            {
                return a[index - lowerBound];
            }
            else
            {
                throw new RangeArrayException("Range Error.");
            }
        }

        // This is the set accessor. 
        set
        {
            if (ok(index))
            {
                a[index - lowerBound] = value;
            }
            else throw new RangeArrayException("Range Error.");
        }
    }

    // Return true if index is within bounds.  
    private bool ok(int index)
    {
        if (index >= lowerBound & index <= upperBound) return true;
        return false;
    }
}

// Demonstrate the index-range array.  
class RangeArrayDemo
{
    static void MainException()
    {
        try
        {
            throw new RangeArrayException();
            RangeArray ra = new RangeArray(-5, 5);
            RangeArray ra2 = new RangeArray(1, 10);

            // Demonstrate ra. 
            Console.WriteLine("Length of ra: " + ra.Length);

            for (int i = -5; i <= 5; i++)
                ra[i] = i;

            Console.Write("Contents of ra: ");
            for (int i = -5; i <= 5; i++)
                Console.Write(ra[i] + " ");

            Console.WriteLine("\n");

            // Demonstrate ra2. 
            Console.WriteLine("Length of ra2: " + ra2.Length);

            for (int i = 1; i <= 10; i++)
                ra2[i] = i;

            Console.Write("Contents of ra2: ");
            for (int i = 1; i <= 10; i++)
                Console.Write(ra2[i] + " ");

            Console.WriteLine("\n");


        }
        catch (RangeArrayException exc)
        {
            Console.WriteLine(exc);
        }

        // Now, demonstrate some errors. 
        Console.WriteLine("Now generate some range errors.");

        // Use an invalid constructor. 
        try
        {
            RangeArray ra3 = new RangeArray(100, -10); // Error 
        }
        catch (RangeArrayException exc)
        {
            Console.WriteLine(exc);
        }

        // Use an invalid index. 
        try
        {
            RangeArray ra3 = new RangeArray(-2, 2);

            for (int i = -2; i <= 2; i++)
                ra3[i] = i;

            Console.Write("Contents of ra3: ");
            for (int i = -2; i <= 10; i++) // generate range error 
                Console.Write(ra3[i] + " ");

        }
        catch (RangeArrayException exc)
        {
            Console.WriteLine(exc);
        }
    }
}

class MyInter
{
    String str;
    public MyInter(string a)
    {
        str = a;
    }
    public string MyText()
    {
        Console.WriteLine("Input some simbols");
        //str = Console.In.ReadLine();
        Console.WriteLine(Console.ReadKey());

        Console.ReadKey();
        if (str == "some simbols")
        {
            str = "right";
        }
        else
        {
            str = "wrong";
        }
        return str;
        

    }
}
delegate void MyDel(string str);
class WorkText
{
    static void MainTextInput()
    {
        MyInter ob = new MyInter("some simbols");
        //string final = ob.MyText();
        Console.WriteLine(ob.MyText());
    }
}
//CASINO
class MinRandom
{
    public char MyDel(int p)
    {
        int x = p;
        Console.WriteLine("in mydel");
        return (char)x;
    }
    public char MyDel1(int p)
    {
        int x = p;
        Console.WriteLine("in mydel1");
        return (char)x;
        
    }



    public int[] MainRand(int g)
    {
        try
        {
            int[] ar = new int[g];
            Random rand = new Random();
            for (int i = 0; i < g; i++)
                ar[i] = rand.Next(0, 100);
            for (int i = 0; i < g; i++)
                Console.WriteLine(ar[i]);
            return ar;

        }
        catch(Exception exc)
        {
            Console.WriteLine(exc + "test");
            return null;
        }
    }
}
delegate char PrOb(int p);


class DelDem
{

    static void MainDel()
    {
        MinRandom ar = new MinRandom();
        PrOb Ob = ar.MyDel;
        Ob += ar.MyDel1;
        int[] arr = ar.MainRand(100);
        try
        {
            for (int i = 0; i < arr.Length; i++)
                Console.Write(Ob(arr[i]));
        }
        catch (Exception exc)
        {
            Console.WriteLine(exc + "test1");
        }
    }

}
//listing 5
// Demonstrate covariance and contravariance. 
   

class X
{
    public int Val;
}

// Y is derived from X. 
class Y : X { }

// This delegate returns X and takes a Y argument. 
delegate X ChangeIt(Y obj);

class CoContraVariance
{

    // This method returns X and has an X parameter. 
    static X IncrA(X obj)
    {
        X temp = new X();
        temp.Val = obj.Val + 1;
        return temp;
    }

    // This method returns Y and has an Y parameter. 
    static Y IncrB(Y obj)
    {
        Y temp = new Y();
        temp.Val = obj.Val + 1;
        return temp;
    }

    static void MainKovariantnost()
    {
        Y Yob = new Y();

        // In this case, the parameter to IncrA 
        // is X and the parameter to ChangeIt is Y. 
        // Because of contravariance, the following 
        // line is OK. 
        ChangeIt change = IncrA;

        X Xob = change(Yob);

        Console.WriteLine("Xob: " + Xob.Val);

        // In the next case, the return type of 
        // IncrB is Y and the return type of  
        // ChangeIt is X. Because of covariance, 
        // the following line is OK. 
        change = IncrB;

        Yob = (Y)change(Yob);

        Console.WriteLine("Yob: " + Yob.Val);
    }
}

delegate int CountIt(int i);

class Anon
{
    static void MainDel2()
    {
        CountIt count = delegate(int x)
        {
            for (int i = 0; i < 5; i++) { 
                x = x + i;
            }
            return x;
        };
        Console.WriteLine(count(5));
    }
}
class lambda
{
    static void MainLambda()
    {
        CountIt Sum = (int res) =>
        {
            int p = res;
            for (int i = 0; i < p; i++)
            {
                res = res + i;
            }
            return res;
        };
        Console.WriteLine(Sum(5));
    }
}

delegate int DelegEvent(int j);

class Sobitie
{
    public event EventHandler NazvSobitie;
    public void ObrabotkaSobitiya()
    {
        if (NazvSobitie != null)
            NazvSobitie(this, EventArgs.Empty);
    }
}
class XX
{
    int id;
    public XX(int x) {
        id = x;
            }
    DelegEvent jd = id =>
    {
        int b = id + 1;
        return b;
    };
    public void Xev(object sender, EventArgs e)
    {
        int pd = jd(id);

        Console.WriteLine("Событи-е получено обьектом " + id + " " + pd + " "+ sender + " " + e);
    }
}

class EvDemo
{
    static void MainSobitie()
    {
        Sobitie evt = new Sobitie();
        XX o1 = new XX(1);
        XX o2 = new XX(2);
        XX o3 = new XX(3);
        evt.NazvSobitie += o1.Xev;
        evt.NazvSobitie += o2.Xev;
        evt.NazvSobitie += o3.Xev;
        evt.ObrabotkaSobitiya();
    }
}

class MyR
{
    int x, y;
    public MyR(int i)
    {
        Console.WriteLine("Constructor class MyR(int)");
        x = y = i;
    }
    public MyR(int i, int j)
    {
        Console.WriteLine("Constructor class MyR (int)(int)");
        x = i;
        y = j;
        Show();
    }
    public int Sum()
    {
        return x + y;
    }
    public bool IsB(int i)
    {
        if ((x < i) && (i < y)) return true;
        else return false;
    }
    public void Set(int a, int b)
    {
        Console.WriteLine("In method Set(int)(int)");
        x = a;
        y = b;
    }
    public void Set(double a, double b)
    {
        Console.WriteLine("In method set(double)(double)");
        x = (int)a;
        y = (int)b;
        Show();
    }
    public void Show()
    {
        Console.WriteLine("Znach x {0} znach y {1} ",x, y);
    }
}
class InDem
{
    static void MainReflect()
    {
        Type t = typeof(MyR);
        int val;
        ConstructorInfo[] ci = t.GetConstructors();
        Console.WriteLine("Dostupn construct: ");
        foreach (ConstructorInfo c in ci)
        {
            Console.Write(" " + t.Name + "(");
            ParameterInfo[] pi = c.GetParameters();
            for (int i = 0; i < pi.Length; i++)
            {
                Console.Write(pi[i].ParameterType.Name + " " + pi[i].Name);
                if (i + 1 < pi.Length) Console.Write(", ");
            }

        }
        Console.WriteLine();
        int x;
        for (x = 0; x < ci.Length; x++)
        {
            ParameterInfo[] pi = ci[x].GetParameters();
            if (pi.Length == 2) break;
        }
        if (x == ci.Length)
        {
            Console.WriteLine("Constructor ne nayden");
            return;
        }
        else
        {
            Console.WriteLine("Nayden constructor s 2 param\n");
        }
        object[] consargs = new object[2];
        consargs[0] = 10;
        consargs[1] = 20;
        object reflectOb = ci[x].Invoke(consargs);
        Console.WriteLine("\nVizov metoda dlya ReflectOb");
        Console.WriteLine();
        MethodInfo[] mi = t.GetMethods();
        foreach (MethodInfo m in mi)
        {
            ParameterInfo[] pi = m.GetParameters();
            if (m.Name.CompareTo("Set") == 0 && pi[0].ParameterType == typeof(double))
            {
                object[] args = new object[2];
                args[0] = 1.12;
                args[1] = 23.4;
                m.Invoke(reflectOb, args);
            }
            else if ((m.Name.CompareTo("Set") == 0 && pi[0].ParameterType == typeof(int)))
            {
                object[] args = new object[2];
                args[0] = 9;
                args[1] = 18;
                m.Invoke(reflectOb, args);
            }
            else if ((m.Name.CompareTo("Sum") == 0)) {
                val = (int)m.Invoke(reflectOb, null);
                Console.WriteLine("Summa = "+ val);
            }
            else if (m.Name.CompareTo("IsB") == 0)
            {
                object[] args = new object[1];
                args[0] = 14;
                m.Invoke(reflectOb, args);
                if ((bool)m.Invoke(reflectOb, args))
                    Console.WriteLine("Znacheniye {0} nahoditsya mezhdu {1} {2}", args[0], args[0], args[0]);
            }
            else if (m.Name.CompareTo("Show") == 0)
            {
                m.Invoke(reflectOb, null);
            }
        }
    }
}

[AttributeUsage(AttributeTargets.All)]
public class RemarkAttribute : Attribute
{
    string pri_remark; // underlies Remark property 

    public string Supplement; // this is a named parameter 

    public RemarkAttribute(string comment)
    {
        pri_remark = comment;
        Supplement = "None";
        Priority = 1;
    }

    public string Remark
    {
        get
        {
            return pri_remark;
        }
    }

    // Use a property as a named parameter.  
    public int Priority { get; set; }
}

[RemarkAttribute("This class uses an attribute.",
                 Supplement = "This is additional info.",
                 Priority = 10)]
class UseAttrib
{
    // ... 
}

internal class NamedParamDemo
{
    static void MainRemark()
    {
        Type t = typeof(UseAttrib);

        Console.Write("Attributes in " + t.Name + ": ");

        object[] attribs = t.GetCustomAttributes(false);
        foreach (object o in attribs)
        {
            Console.WriteLine(o);
        }

        // Retrieve the RemarkAttribute. 
        Type tRemAtt = typeof(RemarkAttribute);
        RemarkAttribute ra = (RemarkAttribute)
              Attribute.GetCustomAttribute(t, tRemAtt);
#if Test
        Console.Write("Remark: ");
        Console.WriteLine(ra.Remark);
#endif
        Console.Write("Supplement: ");
        Console.WriteLine(ra.Supplement);

        Console.WriteLine("Priority: " + ra.Priority);
    }
}
class A
{
    public  int D;
    public A(int g)
    {
        D = g - 1;
    }

}
class B<T>
{
//    public T P = default;
    public T[] Mas(int g, T k)
    {
        T[] m = new T[g];
        for (int i = 0; i < g; i++)
        {
            m[i] = k;
            Console.WriteLine(m[i]);
        }
            
        return m;

    }
}

class C
{

    static void MainObobshenie()
    {
        A a = new A(5);
        B<object> b = new B<object>();
        //        object z;
        //        z = (a is B);
        //        x = (b is A);
        Type t = typeof(A);
        Console.WriteLine(t.IsClass);
        //       if((bool)z)
        //           Console.WriteLine("z = " , z.ToString());
        //        if((bool)x)
        //            Console.WriteLine("x = " , x);
        //        Console.WriteLine(a.D + b.P);
        
        object[] h = b.Mas(5,"pop");
        Console.WriteLine(h[0]);
        for (int i=0; i < h.Length; i++)
            Console.WriteLine(h[i]);
        Console.WriteLine(a);

    }
}

class Item
{
    public string Name {get; set;}
    public int ItemNumber {get; set;}
    public Item(string n, int inum)
    {   Name = n;
        ItemNumber = inum;}
}
class InStockStatus
{
    public int ItemNumber {get; set;}
    public bool InStock { get; set; }
    public InStockStatus(int n, bool b)
    {
        ItemNumber = n;
        InStock = b;
    }
}
class Temp
{
    public string Name { get; set; }
    public bool InStock { get; set; }
    public Temp(string n, bool b)
        {
        Name = n;
        InStock = b;
        }
}

class JoinDemo
{
    static void MainLinq()
    {
        Item[] items =
        {
            new Item("Cusachki", 1924),
            new Item("Tiski", 7892),
            new Item("Molotok", 8534),
            new Item("Pila", 6411)
        };
        InStockStatus[] statuslist =
        {
            new InStockStatus(1424, true),
            new InStockStatus(7892, false),
            new InStockStatus(8534, true),
            new InStockStatus(6411, true)
        };
        var InStockList = from item in items
                          join entry in statuslist
                          on item.ItemNumber equals entry.ItemNumber
                          select new Temp(item.Name, entry.InStock);
        Console.WriteLine("Tovar\tNalichie\n");
        foreach (Temp t in InStockList)
            Console.WriteLine("{0}\t{1}", t.Name, t.InStock);

    }
}
class f1
{
    public string Name { get; set; }
    public int Age { get; set; }
    public int Weight { get; set; }
    public int Height { get; set; }
    public f1(string n, int a, int w, int H)
    {
        Name = n;
        Age = a;
        Weight = w;
        Height = H;
    }
}
class r1
{
    public string Role { get; set; }
    public string Name { get; set; }
    public r1(string r, string n)
    {
        Role = r;
        Name = n;
    }
}
class t1
{
    public string Name { get; set; }
    public string Role { get; set; }
    public int Weight { get; set; }
    public t1(int w,string r, string n)
    {
        Role = r;
        Weight = w;
        Name = n;
    }
}

class m1
{
    static void MainLin()
    {
        f1[] Ar =
        {
            new f1("Liudmyla", 41, 65, 165),
            new f1("Vladyslav", 40, 93, 185),
            new f1("Maksym", 5, 23, 120)

        };
        r1[] Ar2 =
        {
            new r1("Papa", "Vladyslav"),
            new r1("Mama", "Liudmyla"),
            new r1("Son", "Maksym")
        };
        r1[] Zar =
        {
            new r1("Bonus", "Minus"),
            new r1("Left", "Right"),
            new r1("Up", "Down")
        };
        var RW = from f1 in Ar
                 join entry in Ar2
                 on f1.Name equals entry.Name
    //             where f1.Name == "Liudmyla"
                 orderby f1.Name
                    from z1 in Zar
                        where z1.Role == "Bonus"
                 select new { f1.Height, entry.Role, RoleS = z1.Role };
        Console.WriteLine("Role\tHeight\tName");
        foreach (var t in RW)
            Console.WriteLine("{0}\t{1}\t{2}", t.Role, t.Height, t.RoleS);

    }
}
class m2
{
    static void MainLin2()
    {
        f1[] Ar =
        {
            new f1("Liudmyla", 41, 65, 165),
            new f1("Vladyslav", 40, 93, 185),
            new f1("Maksym", 5, 23, 120)

        };
        r1[] Ar2 =
        {
            new r1("Papa", "Vladyslav"),
            new r1("Mama", "Liudmyla"),
            new r1("Son", "Maksym")
        };
        r1[] Zar =
        {
            new r1("Bonus", "Minus"),
            new r1("Left", "Right"),
            new r1("Up", "Down")
        };
        var RW = from f1 in Ar
                 join entry in Ar2
                 on f1.Name equals entry.Name
                 //             where f1.Name == "Liudmyla"
                 orderby f1.Name
                 from z1 in Zar
                     //                 where z1.Role == "Bonus"
                 group f1 by f1.Name
                 into ws
                 where ws.Count() == 3
                 select ws;
        Console.WriteLine("Role\tName");
        foreach (var t in RW)
            foreach(var s1 in t )
            Console.WriteLine("{0}\t{1}", s1.Height, s1.Name);

    }
}
class m3
{
    static void MainDerevya()
    {
        f1[] Ar =
        {
            new f1("Liudmyla", 41, 65, 165),
            new f1("Vladyslav", 40, 93, 185),
            new f1("Maksym", 5, 23, 120)

        };
        r1[] Ar2 =
        {
            new r1("Papa", "Vladyslav"),
            new r1("Mama", "Liudmyla"),
            new r1("Son", "Maksym")
        };
        r1[] Zar =
        {
            new r1("Bonus", "Minus"),
            new r1("Left", "Right"),
            new r1("Up", "Down")
        };
        var RW = Ar.Join(Ar2, k1 => k1.Name, k2 => k2.Name, (k1, k2) => new { k1.Weight, k2.Role, k1.Name });
        Console.WriteLine("Role\tName");
        foreach (var t in RW)
                Console.WriteLine("{0}\t{1}", t.Name, t.Weight);
        Expression<Func<int, int, bool>>
            isfactorexp = (n, d) => (d != 0) ? (n % d) == 0 : false;
        Func<int, int, bool> isfactor = isfactorexp.Compile();
        Console.WriteLine(RW.Count()+" " + isfactor(5, 10));


    }
}
class UnsafeCode
{
    unsafe static void MainUnsafe()
    {
        ConsoleKeyInfo keypress;

        Console.WriteLine("Enter keystrokes. Enter Q to stop.");
        int count = 99;
        int* p;
        p = &count;
        Console.WriteLine("Ishodnoe znach count: " + *p);
        *p = 10;
        Console.WriteLine("Novoe znach count: " + *p);


        int* ip = &count;
        do
        {
            keypress = Console.ReadKey(); // read keystrokes 

            Console.WriteLine(" Your key is: " + keypress.KeyChar);

            // Check for modifier keys. 
            if ((ConsoleModifiers.Alt & keypress.Modifiers) != 0)
                Console.WriteLine("Alt key pressed.");
            if ((ConsoleModifiers.Control & keypress.Modifiers) != 0)
                Console.WriteLine("Control key pressed.");
            if ((ConsoleModifiers.Shift & keypress.Modifiers) != 0)
                Console.WriteLine("Shift key pressed.");

            Console.WriteLine((uint)(ip));

        } while (keypress.KeyChar != 'Q');
        Console.WriteLine((uint)(ip));
        Console.WriteLine((uint)(++ip));
        Console.WriteLine((uint)(ip));
    }
}

class MyThread
{
    public int count;
    public Thread thrd;
    public var time;
    public MyThread(string name)
    {
        time = DateTime.Now;
        count = 0;
        thrd = new Thread(this.Run);
        thrd.Name = name;
        thrd.Start();
    }
    void Run()
    {
        Console.WriteLine(thrd + " starting");
        do
        {
            Thread.Sleep(500);
            Console.WriteLine("In " + thrd.Name + " Count is " + count);
            count++;

        } while (count < 10);
        Console.WriteLine("Thread " + thrd.Name + " terminating");
    }

}
class MoreThreads
{
    static void Main()
    {
        DateTime dt = DateTime.Now;
        Console.WriteLine("Main thread starting");
        MyThread mt1 = new MyThread("potok 1");
        MyThread mt2 = new MyThread("potok 2");
        MyThread mt3 = new MyThread("potok 3");
        do
        {
            Console.WriteLine("Time with seconds: " +
                  "{0:HH:mm:ss tt}", dt);
            Console.Write(".");
            Thread.Sleep(500);
        } while (mt1.thrd.IsAlive &&
        mt2.thrd.IsAlive &&
        mt3.thrd.IsAlive);
        Console.WriteLine("Main thread ending");
    }
}
class EnumFmtDemo
{
    enum Direction { North, South, East, West }
    [Flags]
    enum Status
    {
        Ready = 0x1, OffLine = 0x2,
        Waiting = 0x4, TransmitOK = 0x8,
        RecieveOK = 0x10, OnLine = 0x20
    }

    static void MainEnum()
    {
        Direction d = Direction.West;

        Console.WriteLine("{0:G}", d);
        Console.WriteLine("{0:F}", d);
        Console.WriteLine("{0:D}", d);
        Console.WriteLine("{0:X}", d);

        Status s = Status.Ready | Status.TransmitOK;

        Console.WriteLine("{0:G}", s);
        Console.WriteLine("{0:F}", s);
        Console.WriteLine("{0:D}", s);
        Console.WriteLine("{0:X}", s);
    }
}
class CustomTimeAndDateFormatsDemo
{
    static void MainTime()
    {
        DateTime dt = DateTime.Now;

        Console.WriteLine("Time is {0:hh:mm tt}", dt);
        Console.WriteLine("24 hour time is {0:HH:mm}", dt);
        Console.WriteLine("Date is {0:ddd MMM dd, yyyy}", dt);

        Console.WriteLine("Era: {0:gg}", dt);

        Console.WriteLine("Time with seconds: " +
                          "{0:HH:mm:ss tt}", dt);

        Console.WriteLine("Use m for day of month: {0:m}", dt);
        Console.WriteLine("Use m for minutes: {0:%m}", dt);
    }
}
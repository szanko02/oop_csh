using System;
public class MyClass
{
    protected float a;
    protected float b;

    public MyClass()
    {
        a = 4.11F;
        b = 21;
    }
    public float A1
    {
        get { return a / b; }
    }
    public float getSetB1
    {
        get { return a; }
        set { a = value; }
    }
    public float getSetC1
    {
        get { return b; }
        set { b = value; }
    }
}

public class MyClass2: MyClass
{
    private const bool f = true;
    protected float d;
    
    public MyClass2(float a, float b, float d) : base(a, b)
    {
        this.d = d;
    }

    public MyClass2(): this(4.11F, 21, 20)
    {    
        this.d = 20;
    }
    public float getSetC2
    {
        get 
        {
            if (f == false) 
            {
                return b += d;
            }
            else
            {
                return b -= d;
            }
        }
    }

}
public class Program
{
    private static void Main()
    {
        MyClass MyObj = new MyClass();
        MyClass2 MyObj2 = new MyClass2();
        Console.WriteLine(MyObj2.getSetC2);
        Console.WriteLine(MyObj.A1);
    }
}


using System;
public class MyClass
{
    protected float a;
    protected float b;

    public MyClass()
    {
        a = 10;
        b = 2;
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

public class MyClass2 : MyClass
{
    protected float d;
    private float[] arr;

    public MyClass2(float d) : base()
    {
        this.d = d;
    }
    public MyClass2(float d, int something) : this(d)
    {
    
        arr = new float[(int)a * something];
        for (int i = 0; i < arr.Length; i++)
        {
            arr[i] = getC2 * i;
        }
    }

    public void printArray()
    {
        int k = 0;
        foreach (int i in arr)
        {
            Console.Write($"\nЧлен номер [{k++}]: {i} ");
        }
    }
    public float getC2
    {
        get
        {
        return b =- d;
        }
    }

}
public class Program
{
    private static void Main()
    {
        MyClass MyObj = new MyClass();
        MyClass2 MyObj2 = new MyClass2(21,1);
        Console.WriteLine(MyObj2.getC2);
        Console.WriteLine(MyObj.A1);
        MyObj2.printArray();
    }
}

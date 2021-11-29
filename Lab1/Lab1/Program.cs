using System;
public class MyClass
{
    int a = 4;
    int b = 2;
    public int A1
    {
        get { return a / b; }
    }
    public int B1
    {
        get { return a; }
        set { a = value; }
    }
    public int C1
    {
        get { return b; }
        set { b = value; }
    }
}
public class Program
{
    private static void Main()
    {
        MyClass MyObj = new MyClass();
        Console.WriteLine(MyObj.B1);
    }
}
//1

using System;
using ValueAndReferenceType;

internal class Program
{
    static void Main(string[] args)
    {
        try
        {
            DoTask();
        }
        catch (Exception ex)
        {

            Console.WriteLine(ex.Message);
        }
        finally
        {
            Console.ReadLine();
        }
    }

    private static void DoTask()
    {
        TestValueType();
        Console.WriteLine();
        TestReferenceType();
        TestRefOperator();
        TestOutOperator();
        BoxingTest();
        UnBoxingTest();
        TestIsCasting();
        TestASCasting();

    }

    private static void TestASCasting()
    {
        Object[] myArray = new Object[5];
        myArray[0] = 100;
        myArray[1] = 3.14m;
        myArray[2] = new Student() { Name = "Tanvir" };
        myArray[3] = "Hello";
        myArray[4] = true;
        for (int i = 0; i < myArray.Length; i++)
        {
            string strValue = myArray[i] as string;
            if (strValue != null)
            {
                Console.WriteLine(strValue);
            }
            else
            {
                Console.WriteLine("It is not a string");
            }
        }
    }
    private static void TestIsCasting()
    {
        Object obj = new Object();
        if (obj is Student)
        {
            Student student = new Student();
            student.Name = "Tanvir";
            Console.WriteLine(student.Name);
        }
        Console.WriteLine("It is not an object");

    }
    private static void UnBoxingTest()
    {
        Object obj = 10;
        int num1 = (int)obj;
        Console.WriteLine(num1);
    }
    private static void BoxingTest()
    {
        int num1 = 10;
        Object obj = num1;
        Console.WriteLine(obj);

        decimal num2 = 10.5m;
        Object obj2 = num1;
        Console.WriteLine(obj2);
    }

    private static void TestOutOperator()
    {
        int bag;
        PassOutValue(out bag);
        Console.WriteLine(bag);
    }

    private static void PassOutValue(out int bag)
    {
        bag = 10;
        Console.WriteLine(bag);
        bag++;
        Console.WriteLine(bag);
    }

    private static void TestRefOperator()
    {
        int param = 10;
        Console.WriteLine(param);
        PassValue(ref param);
        Console.WriteLine(param);
    }

    private static void PassValue(ref int param)
    {
        param++;
        Console.WriteLine(param);
    }

    private static void TestReferenceType()
    {
        Student obj = new Student();
        obj.Name = "Tanvir";
        Console.WriteLine(obj.Name);
        ChangeName(obj);
        Console.WriteLine(obj.Name);
    }

    private static void ChangeName(Student obj)
    {
        obj.Name = "Tanvir Hasan";
        Console.WriteLine(obj.Name);
    }

    private static void TestValueType()
    {
        int num1 = 10;
        Console.WriteLine(num1);
        IncreaseValue(num1);
        Console.WriteLine(num1);
    }

    private static void IncreaseValue(int num1)
    {
        num1++;
        Console.WriteLine(num1);
    }
}
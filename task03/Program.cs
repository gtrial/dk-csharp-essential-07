using System;

namespace task03
{
    struct MyStruct
    {
        public string change;
    }

    class Program
    {
        static void ClassTaker(MyClass myClass)
        {
            myClass.change = "changed";
        }
        static void StruktTaker(MyStruct myStruct)
        {
            myStruct.change = "changed";
        }
        static void Main()
        {
            MyStruct myStruct = new MyStruct();
            MyClass myClass = new MyClass();
            myStruct.change = "not changed";
            myClass.change = "not changed";
            StruktTaker(myStruct);
            ClassTaker(myClass);
            Console.WriteLine($"myStruct.change: {myStruct.change}");
            Console.WriteLine($"myClass.change: {myClass.change}");
        }
    }
}

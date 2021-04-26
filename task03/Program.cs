using System;

namespace task03
{
    internal struct MyStruct
    {
        public string Change;
    }

    internal static class Program
    {
        private static void ClassTaker(MyClass myClass)
        {
            myClass.Change = "changed";
        }

        private static void StructTaker(MyStruct myStruct)
        {
            myStruct.Change = "changed";
        }

        private static void Main()
        {
            var myStruct = new MyStruct();
            var myClass = new MyClass();
            myStruct.Change = "not changed";
            myClass.Change = "not changed";
            StructTaker(myStruct);
            ClassTaker(myClass);
            Console.WriteLine($"myStruct.change: {myStruct.Change}");
            Console.WriteLine($"myClass.change: {myClass.Change}");
        }
    }
}

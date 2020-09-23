using System;

namespace TestRuntimeT4ForDotNetCore
{
    class Program
    {
        static void Main(string[] args)
        {
            MyModel page = new MyModel("MyClass");
            String pageContent = page.TransformText();

            Console.Write(pageContent);
            Console.ReadLine();
        }
    }
}

using System;

namespace Stack
{
    class Program
    {
        static void Main(string[] args)
        {
            NodeStack<string> stack = new NodeStack<string>();
            stack.Push("aaa");
            stack.Push("bbb");
            stack.Push("ccc");
            stack.Push("ddd");

            foreach (var item in stack)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine();
            string header = stack.Peek();
            Console.WriteLine($"H: {header}");
            Console.WriteLine();

            header = stack.Pop();
            foreach (var item in stack)
            {
                Console.WriteLine(item);
            }
        }
    }
}

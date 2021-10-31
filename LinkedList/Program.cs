using System;

namespace LinkedList
{
    class Program
    {
        static void Main(string[] args)
        {
            LinkedList<int> linkedList = new LinkedList<int>();
            Console.WriteLine("Add 1,2,3,4");
            linkedList.Add(1);
            linkedList.Add(2);
            linkedList.Add(3);
            linkedList.Add(4);

            foreach (var item in linkedList)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("Remove 2");
            linkedList.Remove(2);
            foreach (var item in linkedList)
            {
                Console.WriteLine(item);
            }
            
            bool isPresent = linkedList.Contains(3);
            Console.WriteLine(isPresent == true);

            linkedList.AppendFirst(6);

            Console.ReadKey();
        }
    }
}

// See https://aka.ms/new-console-template for more information

namespace LinkedList
{
    public class Program
    {
        static void Main(string[] args)
        {
            LinkedList<int> linkedList2 = new LinkedList<int>();
            var count = linkedList2.First.Previous;
            global::LinkedList.LinkedList.MyLinkedList<int> linkedList = new();
            var count2 = linkedList.First.Next;
            linkedList.AddLast(10);
            linkedList.AddLast(20);
            linkedList.AddLast(30);

            var indexOfTen = linkedList.IndexOf(10);
            var indexOfTwenty = linkedList.IndexOf(20);

            Console.WriteLine($"Contains 10? {linkedList.Contains(10)}");

            linkedList.RemoveFirst();
            Console.WriteLine($"Contains 10? {linkedList.Contains(10)}");

            var myLinkedListAsArray = linkedList.ToArray();
            foreach (var item in myLinkedListAsArray)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine();

        }
    }
}




using DataStructures.LinkedList.SinglyLinkedList;

namespace App
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var linkedList = new SinglyLinkedList<int>();
            linkedList.AddFirst(1);
            linkedList.AddFirst(2);
            linkedList.AddFirst(3);

            var current = linkedList.Head;
            while (current !=null)
            {
                Console.WriteLine(current.Value);
                current = current.Next;
            }
            //Çıktı: 3,2,1

            Console.ReadKey();
        }
    }
}


namespace DataStructures.LinkedList.SinglyLinkedList
{
    // Tek yönlü bağlı liste için düğüm tasarımı
    // Her düğüm (Node), bir veri ve bir sonraki düğüme işaret eden referans içerir.
    public class SinglyLinkedListNode<T>
    {
        // Bir sonraki düğümü işaret eden referans
        public SinglyLinkedListNode<T> Next { get; set; }

        // Düğümün içerdiği değer 
        public T Value { get; set; }

        // Constructor, düğüm oluşturulurken değer atanır
        public SinglyLinkedListNode(T value)
        {
            Value = value;
        }

        public override string ToString() => $"{Value}";
    }
}

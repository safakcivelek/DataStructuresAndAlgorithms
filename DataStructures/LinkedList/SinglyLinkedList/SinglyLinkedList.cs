
namespace DataStructures.LinkedList.SinglyLinkedList
{
    // Tek yönlü bağlı liste yapısı
    // Listeye eleman ekleme (AddFirst) işlemi O(1) zaman karmaşıklığına sahiptir
    public class SinglyLinkedList<T>
    {
        // Listenin başını (ilk düğüm) işaret eden referans
        // Başlangıçta null olabilir, yani liste boş olabilir
        public SinglyLinkedListNode<T> Head { get; set; }

        // Her yeni eleman, mevcut listenin başına eklenir ve Head güncellenir
        public void AddFirst(T value)
        {
            // Yeni bir düğüm oluşturulur
            var newNode = new SinglyLinkedListNode<T>(value);

            // Yeni düğümün Next referansı mevcut Head'i işaret eder
            // Bu sayede yeni düğüm, eski listenin başı olur
            newNode.Next = Head;

            // Head referansı yeni düğüm olacak şekilde güncellenir
            // Bu sayede yeni eleman listenin başı olur
            Head = newNode;
        }
    }
}

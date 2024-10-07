namespace DSA.DataStructures.Queue
{
    internal class QueueUsingLinkedList
    {
        public QueueNode head;

        public QueueNode tail;

        public void Enqueue(int key)
        {
            QueueNode queueNode = new QueueNode(key);
            if (head == null)
            {
                head = queueNode;
            }
            else
            {
                QueueNode current = head;
                while (current.Next != null)
                {
                    current = current.Next;
                }

                current.Next = queueNode;

            }
        }

        public int DeQueue()
        {
            int dequeuedValue = 0;
            if (head == null)
            {
                System.Console.WriteLine("Queue is empty");
            }
            else
            {
                dequeuedValue = head.Key;
                head = head.Next;
            }
            return dequeuedValue;
        }

    }

    public class QueueNode
    {
        public int Key { get; set; }

        public QueueNode Next { get; set; }

        public QueueNode(int key)
        {
            Key = key;
        }
    }

    public class QueueUsingLinkedListProgram
    {
        static void Main(string[] args)
        {
            QueueUsingLinkedList queue = new QueueUsingLinkedList();

            queue.Enqueue(10);

            queue.Enqueue(20);

            queue.Enqueue(30);

            queue.DeQueue();
        }
    }
}

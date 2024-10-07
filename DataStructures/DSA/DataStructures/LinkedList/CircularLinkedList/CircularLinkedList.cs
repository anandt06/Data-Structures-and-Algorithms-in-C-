namespace DSA.DataStructures.LinkedList.CircularLinkedList
{
    public class Node
    {
        public int Key;

        public Node Next;
    }

    internal class CircularLinkedList
    {
        public Node head;

        public Node tail;

        public void AddFirst(int key)
        {
            Node node = new Node();
            node.Key = key;

            if (head == null)
            {
                head = node;
                node.Next = head;
            }
            Node current = head;
            while (current.Next != head)
            {
                current = current.Next;
            }
            node.Next = head;
            head = node;
            current.Next = head;

        }

        public void AddLast(int key)
        {
            Node node = new Node();
            node.Key = key;
            if (head == null)
            {
                head = node;
                node.Next = head;
                return;
            }
            Node current = head;
            while (current.Next != head)
            {
                current = current.Next;
            }
            var temp = current.Next;
            current.Next = node;
            node.Next = temp;
        }

        public void PopLast()
        {
            Node current = head;
            while (current.Next.Next != head)
            {
                current = current.Next;
            }
            current.Next = head;

        }

        public void PopFirst()
        {
            if (head == null)
            {
                System.Console.WriteLine("UnderFlow");
            }
            head = head.Next;

            Node current = head;

            while (current.Next != head)
            {
                current = current.Next;
            }
            current.Next = head;
        }

        public bool Find(int key)
        {
            Node current = head;

            while (current.Next != head)
            {
                if (current.Key == key)
                {
                    return true;
                }
                else
                {
                    current = current.Next;
                }
            }
            return false;
        }

        public void InsertAfter(Node node, int key)
        {
            Node newNode = new Node() { Key = key };
            Node current = head;
            while (current.Key != node.Key)
            {
                current = current.Next;
            }
            var temp = current.Next;
            current.Next = newNode;
            newNode.Next = temp;
        }
    }
    public static class CircularLinkedListProgram
    {
        static void Main(string[] args)
        {
            CircularLinkedList circularLinkedList = new CircularLinkedList();

            circularLinkedList.AddFirst(30);

            circularLinkedList.AddFirst(20);

            circularLinkedList.AddFirst(10);

            circularLinkedList.AddLast(50);

            //circularLinkedList.PopLast();

            circularLinkedList.PopFirst();

            circularLinkedList.InsertAfter(new Node() { Key = 30 }, 60);


        }
    }
}

namespace DSA.DataStructures.LinkedList.DoublyLinkedList
{
    public class Node
    {
        public Node Previous;

        public Node Next;

        public int Key;
    }

    public class DoublyLinkedList
    {
        public Node head;

        public Node tail;

        void PrintAllNodes()
        {
            Node curent = head;

            while (curent != null)
            {
                System.Console.WriteLine(curent.Key);
                curent = curent.Next;
            }
        }

        public void AddFirst(int data)
        {
            Node newNode = new Node();
            newNode.Key = data;
            newNode.Next = head;
            newNode.Previous = null;

            if (head != null)
            {
                head.Previous = newNode;
            }

            head = newNode;

            if (tail == null)
            {
                tail = newNode;
            }
        }

        public void InsertAfter(Node currentNode, int data)
        {
            if (head == null || tail == null)
            {
                System.Console.WriteLine("Empty List");
                return;
            }

            Node newNode = new Node { Key = data };
            Node current = head;

            // Find the node after which the new node will be inserted
            while (current != null && current.Key != currentNode.Key)
            {
                current = current.Next;
            }

            // If the current node is found
            if (current != null)
            {
                newNode.Next = current.Next;
                newNode.Previous = current;

                // If the current node is not the last node
                if (current.Next != null)
                {
                    current.Next.Previous = newNode;
                }
                else
                {
                    // If the current node is the last node, update the tail
                    tail = newNode;
                }

                current.Next = newNode;
            }
        }
        public void AddLast(int data)
        {
            Node node = new Node();
            node.Key = data;
            node.Next = null;

            // If the list is empty, initialize head and tail
            if (head == null)
            {
                node.Previous = null;
                head = node;
                tail = node; // set tail since this is the only node
            }
            else
            {
                // If the list is not empty, add the new node at the end
                tail.Next = node;
                node.Previous = tail;
                tail = node;
            }
        }


        public void PopFirst()
        {
            if (head == null || tail == null)
            {
                System.Console.WriteLine("Cannot pop an empty List");
                return;
            }
            head = head.Next;

            if (head == null)
            {
                tail = null;
                System.Console.WriteLine("List is empty after pop operation");
            }
        }

        public void PopLast()
        {
            if (head == null)
            {
                System.Console.WriteLine("Cannot pop an empty List");
                return;
            }

            if (head == tail)
            {
                // List has only one node
                head = tail = null;
            }
            else
            {
                Node current = head;

                // Traverse to the second last node
                while (current.Next != tail)
                {
                    current = current.Next;
                }

                // Set the second last node as the tail and remove the last node
                current.Next = null;
                tail = current;
            }
        }

    }
    public class DoublyLinkedListProgram
    {
        static void Main(string[] args)
        {
            DoublyLinkedList doublyLinkedList = new DoublyLinkedList();

            doublyLinkedList.AddFirst(30);

            doublyLinkedList.AddFirst(20);

            doublyLinkedList.AddLast(40);

            doublyLinkedList.AddLast(50);

            //doublyLinkedList.PopFirst();

            doublyLinkedList.PopLast();

            //doublyLinkedList.InsertAfter(new Node() { Key = 60 }, 35);


        }
    }
}

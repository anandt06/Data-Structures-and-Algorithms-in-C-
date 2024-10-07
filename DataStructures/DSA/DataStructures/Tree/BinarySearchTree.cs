using System;

namespace DSA.DataStructures.Tree
{
    class Node
    {
        public int? Value;
        public Node Left;
        public Node Right;

        public Node(int item)
        {
            Value = item;
            Left = Right = null;
        }
    }

    /// <summary>
    /// Binary Search Tree or BST is a form of Tree where every Left Element is less than root and right element is greather than root
    /// </summary>

    class BinarySearchTree
    {
        public Node Root;

        public BinarySearchTree()
        {
            Root = null;
        }

        public void Insert(int data)
        {
            Root = InsertRecord(Root, data);
        }

        public Node InsertRecord(Node root, int data)
        {
            if (root == null)
            {
                root = new Node(data);
                return root;
            }

            /// call comes back to if or else depending on condition after inserting to set the root back to the intial root. This is how recursion works
            if (data < root.Value)
            {
                root.Left = InsertRecord(root.Left, data);
            }
            else if (data > root.Value)
            {
                root.Right = InsertRecord(root.Right, data);
            }

            return root;
        }

        //Traverse Left then Root then Right and should start from leaves
        public void InorderTraversal(Node root)
        {
            if (root == null)
            {
                return;
            }
            InorderTraversal(root.Left);
            Console.Write(root.Value + " ");
            InorderTraversal(root.Right);

        }

        //Traverse Left then Root then Right and should start from leaves
        public void PostorderTraversal(Node root)
        {
            if (root != null)
            {
                InorderTraversal(root.Left);
                Console.Write(root.Value + " ");
                InorderTraversal(root.Right);
            }
        }

        //Traverse Left then Root then Right and should start from leaves
        public void PreorderTraversal(Node node)
        {
            if (node == null)
            {
                return;
            }
            Console.Write(node.Value + " ");
            PreorderTraversal(node);
            PreorderTraversal(node.Right);
        }


        public void DisplayTree()
        {
            Console.WriteLine("Inorder Traversal of the Binary Tree:");
            InorderTraversal(Root);
            Console.WriteLine();
        }

        public int? MinValue(Node root)
        {
            if (root == null)
            {
                return null;
            }
            else if (root.Left == null)
            {
                return root.Value;
            }
            else
            {
                return MinValue(root.Left);
            }
        }

        public int? MaxValue(Node root)
        {
            if (root == null)
            {
                return null;
            }
            else if (root.Right == null)
            {
                return root.Value;
            }
            else
            {
                return MaxValue(root.Right);
            }
        }
        public Node Delete(Node root, int? key)
        {
            if (root == null)
            {
                return root;
            }

            if (key < root.Value)
            {
                root.Left = Delete(root.Left, key);
            }
            else if (key > root.Value)
            {
                root.Right = Delete(root.Right, key);
            }
            else
            {
                if (root.Left == null)
                {
                    return root.Right;
                }
                else if (root.Right == null)
                {
                    return root.Left;
                }

                root.Value = MinValue(root.Right);

                root.Right = Delete(root.Right, root.Value);
            }

            return root;
        }

        // Function to find the Lowest Common Ancestor (LCA) of two nodes in a BST
        public Node FindLCA(Node node, int n1, int n2)
        {
            if (node == null)
                return null;

            // If both n1 and n2 are smaller than the root, then LCA lies in the left subtree
            if (n1 < node.Value && n2 < node.Value)
                return FindLCA(node.Left, n1, n2);

            // If both n1 and n2 are greater than the root, then LCA lies in the right subtree
            if (n1 > node.Value && n2 > node.Value)
                return FindLCA(node.Right, n1, n2);

            // If one node is on one side and the other is on the other side, or one matches the current node,
            // the current node is the LCA
            return node;
        }
    }


    public static class BinaryTreeProgram
    {
        static void Main()
        {
            BinarySearchTree bst = new BinarySearchTree();

            bst.Insert(50);
            bst.Insert(30);
            bst.Insert(20);
            bst.Insert(40);
            bst.Insert(70);
            bst.Insert(60);
            bst.Insert(80);

            var minimum = bst.MinValue(bst.Root);
            var maximum = bst.MaxValue(bst.Root);
            Console.WriteLine(maximum.ToString());
            Console.WriteLine(minimum.ToString());

            int node1 = 20, node2 = 40;
            Node lca = bst.FindLCA(bst.Root, node1, node2);
            Console.WriteLine($"Lowest Common Ancestor of nodes {node1} and {node2}: {lca.Value}");

            bst.Delete(bst.Root, 20);

            // Displaying the tree
            bst.DisplayTree();
        }
    }
}


//        50
//       /   \
//     30     70
//    /  \   /  \
//  20   40 60   80

// Inorder Traversal (Left-Root-Right): 20 30 40 50 60 70 80 

// Postorder Traversal (Left-Right-Root): 20 40 30 60 80 70 50

// Preorder Traversal (Root-Left-Right): 50 30 20 40 70 60 80

// TIPS TO REMEMBER: For Inorder Root is in betwen Left and Right, For Postorder Root is at end after Left and Right, For Preorder Root is before Left and Right

// Inorder  : Time Complexity: O(N)  Space Complexity: O(N)


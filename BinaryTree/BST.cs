using QueueLinkedList;

namespace BinarySearchTree
{
    public class BST
    {   //  50
        //30 - 80
        //10-40 60-90
        public Node Root { get; set; }

        public BST() => Root = null;

        public void Insert(Node tempRoot, int element)
        {
            Node temp = null;

            while (tempRoot != null)
            {
                temp = tempRoot;

                if (element == tempRoot.Element)
                {
                    return;
                }
                else if (element < tempRoot.Element)
                {
                    tempRoot = tempRoot.Left;
                }
                else if (element > tempRoot.Element)
                {
                    tempRoot = tempRoot.Right;
                }
            }

            Node newNode = new(element, null, null);

            if (Root != null)
            {
                if (element < temp.Element)
                {
                    temp.Left = newNode;
                }
                else
                {
                    temp.Right = newNode;
                }
            }
            else
            {
                Root = newNode;
            }
        }

        public Node InsertRecursive(Node tempRoot, int element)
        {
            if (tempRoot != null)
            {
                if (element < tempRoot.Element)
                {
                    tempRoot.Left = InsertRecursive(tempRoot.Left, element);
                }
                else if (element > tempRoot.Element)
                {
                    tempRoot.Right = InsertRecursive(tempRoot.Right, element);
                }
            }
            else
            {
                Node newNode = new(element, null, null);
                tempRoot = newNode;
            }

            return tempRoot;
        }

        public void Inorder(Node tempRoot)
        {
            if (tempRoot != null)
            {
                Inorder(tempRoot.Left);
                PrintNodeElement(tempRoot.Element);
                Inorder(tempRoot.Right);
            }
        }

        public void PreorderRecursiveTraversal(Node tempRoot)
        {
            if (tempRoot != null)
            {
                PrintNodeElement(tempRoot.Element);
                PreorderRecursiveTraversal(tempRoot.Left);
                PreorderRecursiveTraversal(tempRoot.Right);
            }
        }

        public void PostOrderRecursive(Node tempRoot)
        {
            if (tempRoot != null)
            {
                PostOrderRecursive(tempRoot.Left);
                PostOrderRecursive(tempRoot.Right);
                PrintNodeElement(tempRoot.Element);
            }
        }

        public void LevelOrder()
        {
            QueueLinked queueLinked = new();
            Node t = Root;
            Console.Write($"{t.Element}");
            queueLinked.Enqueue(t);

            while (!queueLinked.IsEmpty())
            {
                t = queueLinked.Dequeue() as Node;

                if (t.Left != null)
                {
                    Console.Write($"{t.Left} ");
                    queueLinked.Enqueue(t.Left);
                }
                if (t.Right != null)
                {
                    Console.Write($"{t.Left} ");
                    queueLinked.Enqueue(t.Right);
                }
            }

        }

        public bool Search(int key)
        {
            Node tempRoot = Root;
            bool isKeyAvailable = true;

            while (tempRoot != null)
            {
                if (key == tempRoot.Element)
                {
                    return isKeyAvailable;
                }
                else if (key < tempRoot.Element)
                {
                    tempRoot = tempRoot.Left;
                }
                else if (key > tempRoot.Element)
                {
                    tempRoot = tempRoot.Right;
                }
            }

            return !isKeyAvailable;
        }

        public bool Delete(int element)
        {
            Node p = Root;
            Node? pp = null;

            while (p != null && p.Element != element)
            {
                pp = p;
                p = element < p.Element ? p.Left : p.Right;
            }

            if (p == null)
            {
                return false;
            }

            if ((p.Left != null) && (p.Right != null))
            {
                Node s = p.Left;
                Node ps = p;

                while (s.Right != null)
                {
                    ps = s;
                    s = s.Right;
                }

                p.Element = s.Element;
                p = s;
                pp = ps;
            }

            Node c = null;

            if (p.Left != null)
            {
                c = p.Left;
            }
            else
            {
                c = p.Right;
            }

            if (p == Root)
            {
                Root = null;
            }
            else
            {
                if (p == pp.Left)
                {
                    pp.Left = c;
                }
                else
                {
                    pp.Right = c;
                }
            }

            return false;
        }

        public int Count(Node tempRoot)
        {
            if (tempRoot != null)
            {
                int x = Count(tempRoot.Left);
                int y = Count(tempRoot.Right);

                return x + y + 1;
            }

            return 0;
        }


        private static void PrintNodeElement(int element)
                => Console.Write($"{element} ");
    }
}

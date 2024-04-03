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
            if(tempRoot != null)
            {
                PrintNodeElement(tempRoot.Element);
                PreorderRecursiveTraversal(tempRoot.Left);
                PreorderRecursiveTraversal(tempRoot.Right);
            }
        }

        public void PrintNodeElement(int element)
                => Console.Write($"{element} ");
    }
}

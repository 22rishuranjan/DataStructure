namespace BinarySearchTree
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");

            var bst = InsertRecords();
            bst.InOrder();
            bst.PostOrder();
            bst.PreOrder();

            var node = bst.Search(51);
            Console.ReadKey();
        }

        public static BST InsertRecords()
        {
            BST bst = new BST();
            bst.Insert(10);
            bst.Insert(5);
            bst.Insert(15);
            bst.Insert(3);
            bst.Insert(7);

            return bst;
        }
    }
}

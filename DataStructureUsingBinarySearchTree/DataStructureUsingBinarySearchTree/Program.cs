using System;

namespace DataStructureUsingBinarySearchTree
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\n UC1");
            UC1BinarySearchTree<int> binarySearchTree = new UC1BinarySearchTree<int>(56);
            binarySearchTree.Insert(30);
            binarySearchTree.Insert(70);
            binarySearchTree.Display();

            Console.WriteLine("\n UC2");
            UC2BinaryAsPerFig<int> binarySearchTree1 = new UC2BinaryAsPerFig<int>(56);
            binarySearchTree1.Insert(30);
            binarySearchTree1.Insert(70);
            binarySearchTree1.Insert(22);
            binarySearchTree1.Insert(40);
            binarySearchTree1.Insert(60);
            binarySearchTree1.Insert(95);
            binarySearchTree1.Insert(11);
            binarySearchTree1.Insert(65);
            binarySearchTree1.Insert(3);
            binarySearchTree1.Insert(16);
            binarySearchTree1.Insert(63);
            binarySearchTree1.Insert(67);
            binarySearchTree1.Display();
            binarySearchTree1.getSize();

            Console.WriteLine("\n UC3");
            UC3Search<int> binarySearch = new UC3Search<int>(56);
            binarySearch.Insert(30);
            binarySearch.Insert(70);
            binarySearch.Insert(22);
            binarySearch.Insert(40);
            binarySearch.Insert(60);
            binarySearch.Insert(95);
            binarySearch.Insert(11);
            binarySearch.Insert(65);
            binarySearch.Insert(3);
            binarySearch.Insert(16);
            binarySearch.Insert(63);
            binarySearch.Insert(67);
            binarySearch.Display();
            binarySearch.getSize();
            bool result = binarySearch.ifExists(63, binarySearch);
            //Console.WriteLine(result);
        }
    }
}

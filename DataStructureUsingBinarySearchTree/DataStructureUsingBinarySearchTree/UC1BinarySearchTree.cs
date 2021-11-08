using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructureUsingBinarySearchTree
{
   public  class UC1BinarySearchTree<T> where T : IComparable
    {

           
            public T NodeData
            {
                get;
                set;
            }

           
            public UC1BinarySearchTree<T> leftTree { get; set; }
            public UC1BinarySearchTree<T> rightTree { get; set; }

           
            public UC1BinarySearchTree(T nodeData)
            {
                this.NodeData = nodeData;
                this.leftTree = null;
                this.rightTree = null;
            }

            int leftCount = 0;
            int rightCount = 0;
            bool result = false;

           
            public void Insert(T item)
            {
                T currentNodeValue = this.NodeData;
                if ((currentNodeValue.CompareTo(item)) > 0)
                {
                    if (this.leftTree == null)
                        this.leftTree = new UC1BinarySearchTree<T>(item);
                    else
                        this.leftTree.Insert(item);
                }
                else
                {
                    if (this.rightTree == null)
                        this.rightTree = new UC1BinarySearchTree<T>(item);
                    else
                        this.rightTree.Insert(item);
                }
            }

           
            public void Display()
            {
                if (this.leftTree != null)
                {
                    this.leftTree.Display();
                }
                Console.WriteLine(this.NodeData.ToString());
                if (this.rightTree != null)
                {
                    this.rightTree.Display();
                }
            }

        }
    
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinarySearchTree
{
    class TreeNode
    {
        private int data;
        private TreeNode leftChild;
        private TreeNode rightChild;
        //soft delete
        bool isDeleted = false;

        public TreeNode(int data)
        {
            this.data = data;
        }

        public TreeNode find(int data)
        {
            if (this.data == data && !isDeleted)
                return this;
            if (data < this.data && leftChild != null)
                return leftChild.find(data);
            if (data > rightChild.data && rightChild != null)
                return rightChild.find(data);
            return null;
        }

        public void insert(int data)
        {
            if (data >= this.data)
            {
                if (this.rightChild == null)
                    this.rightChild = new TreeNode(data);
                else
                    this.rightChild.insert(data);
            }
            else
            {
                if (this.leftChild == null)
                    this.leftChild = new TreeNode(data);
                else
                    this.leftChild.insert(data);
            }
        }
        
        public int Data { get => data; }
        internal TreeNode LeftChild { get => leftChild; set => leftChild = value; }
        internal TreeNode RightChild { get => rightChild; set => rightChild = value; }
        public void delete()
        {
            this.isDeleted = true;
        }
        public int smallest()
        {
            if (this.leftChild == null)
            
                return this.data;
            return this.leftChild.smallest();
        }
        public int largest()
        {
            if (this.rightChild == null)
                return this.data;
            return this.rightChild.largest();
        }
    }
}

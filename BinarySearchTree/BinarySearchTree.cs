using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinarySearchTree
{
    class BinarySearchTree
    {
        private TreeNode root;
        public void insert(int data)
        {
            if (root == null)
                this.root = new TreeNode(data);
            else
                root.insert(data);
        }

        public TreeNode find (int data)
        {
            if (root != null)
                return root.find(data);
            return null;
        }

        public void delete1(int data)
        {
            TreeNode current = this.root;
            TreeNode parent = this.root;
            //isleftchild or isrightchild determines if the parent has the left or right child
            bool isLeftChild = false;

            if (current == null)
                return;

            while (current != null && current.Data != data)
            {
               parent = current;

               if (data < current.Data)
                {
                    current = current.LeftChild;
                    isLeftChild = true;
                }
                else
                {
                    current = current.RightChild;
                    isLeftChild = false;
                }
            }
            if (current == null)
                return;

            if (current.LeftChild == null && current.RightChild == null)
            {
                if (current == root)
                    root = null;
                else
                {
                    if (isLeftChild)
                        parent.LeftChild = null;
                    else
                        parent.RightChild = null;
                }
            }

            else if (current.RightChild == null)
            {
                if (current == root)
                    root = current.LeftChild;
                //isleftchild or isrightchild determines if the parent has the left or right child
                else if (isLeftChild)
                    parent.LeftChild = current.LeftChild; 
                else
                    parent.RightChild = current.LeftChild;
            }
            else if (current.LeftChild == null)
            {
                if (current == root)
                    root = current.RightChild;
                else if (isLeftChild)
                    parent.LeftChild = current.RightChild; //possible correction required: i.e. may be rightchild
                else
                    parent.RightChild = current.RightChild;
            }
            //TODO delete a node with two child

            

        }

        //softdelete
        public void delete(int data){
            TreeNode toDel = find(data);
            toDel.delete();
        }
        public int smallest()
        {
            if (this.root != null)
                return root.smallest();
            return -99;
        }
        public int largest()
        {
            if (this.root != null)
                return root.largest();
            return -99;
        }

    }
}

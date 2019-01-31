using System;
using Xunit;
using find_maximum_value;
using BreadthFirstTraversal.Classes;

namespace findMaxInBinaryTree_unittesting
{
    public class UnitTest1
    {
        [Fact]
        public void TestHappyCase()
        {
            TreeNode treeNode1 = new TreeNode(100);
            Node node1 = new Node(treeNode1);
            treeNode1.LeftChild = new TreeNode(200);
            treeNode1.RightChild = new TreeNode(1);
            int answer1 = Program.FindMaxValue(node1);
            Assert.Equal(200, answer1);
        }

        //can't do null case because I didn't set up instantiates with no input
        //[Fact]
        //public void TestNullCase()
        //{
        //    TreeNode treeNode2 = new TreeNode();
        //    TreeNode treeNode2 = new TreeNode(1);
        //    Node node2 = new Node(treeNode2);
        //    Node node2 = new Node();
        //    node2.Value.Value = null;

        //}

        [Fact]
        public void TestNegCase()
        {
            TreeNode treeNode2 = new TreeNode(-10);
            Node node2 = new Node(treeNode2);
            treeNode2.LeftChild = new TreeNode(-1);
            treeNode2.RightChild = new TreeNode(-50);
            int answer2 = Program.FindMaxValue(node2);
            Assert.Equal(-1, answer2);
        }

        [Fact]
        public void TestDupCase()
        {
            TreeNode treeNode3 = new TreeNode(100);
            Node node3 = new Node(treeNode3);
            treeNode3.LeftChild = new TreeNode(100);
            treeNode3.RightChild = new TreeNode(100);
            int answer3 = Program.FindMaxValue(node3);
            Assert.Equal(100, answer3);
        }
    }
}

/* 
 Test null tree
 test neg values
 test duplicate values
 test "happy" case
     
     
*/
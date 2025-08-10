/**
 * Definition for a binary tree node.
 * public class TreeNode {
 *     public int val;
 *     public TreeNode left;
 *     public TreeNode right;
 *     public TreeNode(int val=0, TreeNode left=null, TreeNode right=null) {
 *         this.val = val;
 *         this.left = left;
 *         this.right = right;
 *     }
 * }
 */
public class Solution {
    public TreeNode InvertTree(TreeNode root) {

        //Base case
        if(root == null)
        {
            return null;
        }
        
        //Swap the left and right child of tree and its subtree
        TreeNode temp = root.right;
        root.right = root.left;
        root.left = temp;

        //Iterate through each left and right node
        InvertTree(root.left);
        InvertTree(root.right);
        
        //return the root of the tree
        return root;

    }
}
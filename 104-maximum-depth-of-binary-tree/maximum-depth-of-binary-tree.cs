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
    public int MaxDepth(TreeNode root) {
        
        //Base Case to go to the next of leaf nodes and return backwards
        if(root == null)
        {
            return 0;
        }
        
        //For the left subtree if every root and sub-root node
        int leftSum = MaxDepth(root.left);
        //For the right subtree if every root and sub-root node
        int rightSum = MaxDepth(root.right);

        //1 means count the root node and if will gige the max of the two subtrees
        return 1 + (Math.Max(leftSum , rightSum));

    }
}
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
    public bool IsValidBST(TreeNode root) {
        bool Validate(TreeNode node, long minValue, long maxValue)
        {
            if (node == null) 
                return true; // Empty trees are valid

            if (node.val <= minValue || node.val >= maxValue) 
                return false; // Breaks BST rule

            return Validate(node.left, minValue, node.val) && 
                   Validate(node.right, node.val, maxValue);
        }

        return Validate(root, long.MinValue, long.MaxValue);
        
    }
}
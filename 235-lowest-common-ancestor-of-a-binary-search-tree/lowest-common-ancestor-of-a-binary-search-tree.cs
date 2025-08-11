/**
 * Definition for a binary tree node.
 * public class TreeNode {
 *     public int val;
 *     public TreeNode left;
 *     public TreeNode right;
 *     public TreeNode(int x) { val = x; }
 * }
 */

public class Solution {
    public TreeNode LowestCommonAncestor(TreeNode root, TreeNode p, TreeNode q) {
        
        //Base case
        if (root == null || root == p || root == q)
            return root;

        //search in left and right subtrees
        TreeNode left = LowestCommonAncestor(root.left, p, q);
        TreeNode right = LowestCommonAncestor(root.right, p, q);

        //If p and q are found in different subtrees, the rott would be LCA
        if (left != null && right != null)
            return root;

        //it, return the non-null result
        return left ?? right;
    }
}
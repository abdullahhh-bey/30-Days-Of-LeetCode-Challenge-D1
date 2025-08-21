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
    public bool HasPathSum(TreeNode root, int targetSum) {
        //Base case
        if(root == null)
        {
            return false;
        }

        //For child or leaf node validation
        if(root.left == null && root.right == null){
            if(root.val == targetSum){
                return true;
            }
        }

        //Check for the left and right siubtrees and just compare th
        //leaf node if its equal to the target sum, then return true
        bool leftSide = HasPathSum(root.left, (targetSum - root.val));
        bool rightSide = HasPathSum(root.right , (targetSum - root.val));
        return (leftSide || rightSide);
    }
}
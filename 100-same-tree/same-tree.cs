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
    public bool IsSameTree(TreeNode p, TreeNode q) {
        //it firstr check the validation 
        //if both are null, return true
        //Base case
        if( p == null && q == null )
        {
            return true;
        }

        //If any one of them is not null, return false
        if( p == null || q == null )
        {
            return false;
        }

        //Main logic
        //If the root of both trees is same , CHECK FOR THE LEFT AND RIGHT NODES
        if(p.val == q.val)
        {
            return IsSameTree(p.left , q.left) && IsSameTree(p.right , q.right);        
        }

        return false;

    }
}
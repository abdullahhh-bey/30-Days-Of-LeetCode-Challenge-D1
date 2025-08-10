/**
 * Definition for a binary tree node.
 * struct TreeNode {
 *     int val;
 *     TreeNode *left;
 *     TreeNode *right;
 *     TreeNode() : val(0), left(nullptr), right(nullptr) {}
 *     TreeNode(int x) : val(x), left(nullptr), right(nullptr) {}
 *     TreeNode(int x, TreeNode *left, TreeNode *right) : val(x), left(left), right(right) {}
 * };
 */
class Solution {
public:
    TreeNode* invertTree(TreeNode* root) {
        //Base case
        if(root == NULL)
        {
            return NULL;
        }
        
        //Swap the left and right child of tree and its subtree
        TreeNode* temp = root->right;
        root->right = root->left;
        root->left = temp;

        //Iterate through each left and right node
        invertTree(root->left);
        invertTree(root->right);
        
        //return the root of the tree
        return root;
    }
};
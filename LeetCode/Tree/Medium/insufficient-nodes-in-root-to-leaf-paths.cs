// Problem :- https://leetcode.com/problems/insufficient-nodes-in-root-to-leaf-paths/

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
    public TreeNode SufficientSubset(TreeNode root, int limit) {
        IsValidSubset(root, 0, limit);
        
        if(root.left == null && root.right == null && root.val < limit) {
            root = null;
        }
        
        return root;
    }
    
    private bool IsValidSubset(TreeNode node, int pathSum, int limit){
        if(node != null){
            bool isLPathValid = false;
            bool isRPathValid = false;
            if(node.left != null && node.right != null){
                isLPathValid = IsValidSubset(node.left, pathSum + node.val, limit);
                isRPathValid = IsValidSubset(node.right, pathSum + node.val, limit);
            }else if (node.left != null)  {
                isLPathValid = IsValidSubset(node.left, pathSum + node.val, limit);
            } else if (node.right != null) {
                isRPathValid = IsValidSubset(node.right, pathSum + node.val, limit);
            }else{
                return pathSum + node.val >= limit;
            }  
            
            if(!isLPathValid){
                node.left = null;
            }
            if(!isRPathValid){
                node.right = null;
            }
            return isLPathValid || isRPathValid;
        }
        return pathSum >= limit;
    }
}

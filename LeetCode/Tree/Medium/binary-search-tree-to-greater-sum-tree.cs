// Problem :- https://leetcode.com/problems/binary-search-tree-to-greater-sum-tree/

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
    int maxVal = 0;
    
    public TreeNode BstToGst(TreeNode root) {
        Calc(root);
        return root;
    }
    
    public void Calc(TreeNode node){
        if(node != null){
            if(node.right != null){
                Calc(node.right);
            }
            
            maxVal = node.val + maxVal;       
            node.val = maxVal;
            
            if(node.left != null){
                Calc(node.left);
            }
        }
    }
}

// Problem :- https://leetcode.com/problems/maximum-difference-between-node-and-ancestor/

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
    int MaxDiff = 0;
    public int MaxAncestorDiff(TreeNode root) {
        TriverseTree(root);
        return MaxDiff;
    }
    
    private void TriverseTree(TreeNode node){
        if(node != null){
            CalMaxDiff(node,node);
            TriverseTree(node.left);
            TriverseTree(node.right);
        }
    }
    
    private void CalMaxDiff(TreeNode node, TreeNode parent){
        if(node != null){
            MaxDiff = Math.Max(MaxDiff,Math.Abs(node.val - parent.val));
            CalMaxDiff(node.left,parent);
            CalMaxDiff(node.right,parent);
        }
    }
}

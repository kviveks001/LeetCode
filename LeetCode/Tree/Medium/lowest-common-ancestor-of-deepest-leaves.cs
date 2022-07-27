// Problem :- https://leetcode.com/problems/lowest-common-ancestor-of-deepest-leaves/

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
    public TreeNode LcaDeepestLeaves(TreeNode root) {
        return TriverseNode(root, MaxDepth(root), 1);
    }
    
    private TreeNode TriverseNode(TreeNode node, int height, int level){
        if(height == level) return node;
        if(node != null){
            var left = TriverseNode(node.left, height, level + 1);
            var right = TriverseNode(node.right, height, level + 1);
            
            if( left != null && right != null ){
                return node;
            }else if(left != null){
                return left;
            }else{
                return right;
            }
        }
        return null;
    }
    
    private int MaxDepth(TreeNode node){
        return node == null ? 0 : Math.Max(MaxDepth(node.left),MaxDepth(node.right)) + 1 ;
    }
}

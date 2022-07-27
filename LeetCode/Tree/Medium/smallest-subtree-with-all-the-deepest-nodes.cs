// Problem :- https://leetcode.com/problems/smallest-subtree-with-all-the-deepest-nodes/

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
    public TreeNode SubtreeWithAllDeepest(TreeNode root) {
        int maxPath = MaxPath(root);
        return Triverse(root,maxPath,1);
    }
    
    private TreeNode Triverse(TreeNode node,int maxDepth, int level){
        if(maxDepth == level){
            return node;
        }
        if(node != null){
            var left = Triverse(node.left,maxDepth,level+1);
            var right = Triverse(node.right,maxDepth,level+1);
            
            if(left != null && right != null){
                return node;
            }else if(left != null){
                return left;
            }else{
                return right;
            }
        }
        return null;
    }
    
    private int MaxPath(TreeNode node){
        if(node != null){
            return Math.Max(MaxPath(node.left),MaxPath(node.right)) + 1;
        }
        return 0;
    }
}

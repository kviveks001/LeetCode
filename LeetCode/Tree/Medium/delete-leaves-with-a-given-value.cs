// Problem :- https://leetcode.com/problems/delete-leaves-with-a-given-value/

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
    public TreeNode RemoveLeafNodes(TreeNode root, int target) {
        RemoveLeafNode(root, root, false, target);
        if(root.left == null && root.right == null && root.val == target){
            root = null;
        }
        return root;
    }
    
    private void RemoveLeafNode(TreeNode node,TreeNode parent,bool isLeft, int target){
        if(node != null){
            RemoveLeafNode(node.left, node, true, target);
            RemoveLeafNode(node.right, node, false, target);
            
            if(node.left == null && node.right == null && node.val == target){
                if(isLeft){
                    parent.left = null;
                }else{
                    parent.right = null;
                }
            }
        }
    }
}

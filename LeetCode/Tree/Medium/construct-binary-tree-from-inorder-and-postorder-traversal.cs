// Problem :- https://leetcode.com/problems/construct-binary-tree-from-inorder-and-postorder-traversal/

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
    public TreeNode BuildTree(int[] inorder, int[] postorder) {
        return ConstructTree(inorder,postorder,0,inorder.Length-1,0,inorder.Length-1);
    }
    
    private TreeNode ConstructTree(int[] inorder, int[] postorder,int inStat, int inEnd, int postStat, int postEnd){
        TreeNode tempNode = null;
        if(inStat <= inEnd && postStat <= postEnd){
            tempNode = new TreeNode(postorder[postEnd]);
            int keyIndex = Array.FindIndex(inorder, w => w == postorder[postEnd]);
            int leftShif  = keyIndex - inStat;
            
            tempNode.left = ConstructTree(inorder,postorder,inStat,keyIndex - 1,postStat,postStat+leftShif-1);
            tempNode.right = ConstructTree(inorder,postorder,keyIndex + 1,inEnd,postStat + leftShif,postEnd-1);
        }
        return tempNode;
    }
}

// Problem :- https://leetcode.com/problems/construct-binary-tree-from-preorder-and-inorder-traversal/

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
    public TreeNode BuildTree(int[] preorder, int[] inorder) {
        return ConstructTree(preorder,inorder,0,preorder.Length-1,0,preorder.Length-1);
    }
    
    private TreeNode ConstructTree(int[] preorder,int[] inorder,int instat,int inend,int prestat,int preend){
        TreeNode resp = null;
        if(instat <= inend && prestat <= preend){
            var index = Array.FindIndex(inorder, row => row == preorder[prestat]);
            resp = new TreeNode(preorder[prestat]);
            int leftInd = index - instat;
                
            resp.left = ConstructTree(preorder,inorder,instat,index-1,prestat+1,prestat+leftInd);
            resp.right = ConstructTree(preorder,inorder,index+1,inend,prestat+leftInd+1,preend);
        }
        return resp;
    }
}

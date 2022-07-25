// Problem :- https://leetcode.com/problems/count-good-nodes-in-binary-tree/

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
    int count = 0;
    public int GoodNodes(TreeNode root) {
        CheckNodeAll(root,int.MinValue);
        return count;
    }
    
    private void CheckNodeAll(TreeNode node, int max){
        if(node != null){      
            if(node.val >= max){
                count++;
            }
            max = Math.Max(max,node.val);
            CheckNodeAll(node.left,max);
            CheckNodeAll(node.right,max); 
        }
    }
}

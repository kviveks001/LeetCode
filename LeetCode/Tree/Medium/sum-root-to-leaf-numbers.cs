// Problem :- https://leetcode.com/problems/sum-root-to-leaf-numbers/

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
    private int sum = 0;
    public int SumNumbers(TreeNode root) {
        TriverseTree(root,"");
        return sum;
    }
    
    private void TriverseTree(TreeNode node,string num){
        if(node != null){
            if(node.left != null && node.right != null){
                TriverseTree(node.left,num + node.val);
                TriverseTree(node.right,num + node.val);
            }else if(node.left != null){
                TriverseTree(node.left,num + node.val);
            }else if(node.right != null){
                TriverseTree(node.right,num + node.val);
            }else{
                num += node.val;
                sum += int.Parse(num);
            }
        }
    }
}

// Problem :- https://leetcode.com/problems/distribute-coins-in-binary-tree/

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
    int steps = 0;
    public int DistributeCoins(TreeNode root) {
        CountSteps(root);
        return steps;
    }
    
    private int CountSteps(TreeNode node){
        if(node != null){
            int left = CountSteps(node.left), right = CountSteps(node.right);
            steps += Math.Abs(left) + Math.Abs(right);
            return node.val + left + right - 1;
        }
        return 0;
    }
}

// Problem :- https://leetcode.com/problems/binary-tree-coloring-game/

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
    private int left, right;
    public bool BtreeGameWinningMove(TreeNode root, int n, int x) {
        SearchNode(root, x);
        if(left > n / 2 || right > n / 2) return true;
        
        if(left + right + 1 <= n / 2) return true;
        
        return false;
    }
    
    private int SearchNode(TreeNode node, int x){
        if(node == null) return 0;
        
        int l = SearchNode(node.left, x);
        int r = SearchNode(node.right, x);
        if(node.val == x){
            this.left = l;
            this.right = r;
        }
        return 1 + l + r;
    }
}

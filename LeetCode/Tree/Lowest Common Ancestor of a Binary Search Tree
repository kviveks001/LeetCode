URL :- https://leetcode.com/problems/lowest-common-ancestor-of-a-binary-search-tree/


/**
 * Definition for a binary tree node.
 * public class TreeNode {
 *     public int val;
 *     public TreeNode left;
 *     public TreeNode right;
 *     public TreeNode(int x) { val = x; }
 * }
 */

public class Solution {
    public TreeNode LowestCommonAncestor(TreeNode root, TreeNode p, TreeNode q) {
        if(root == null)
            return null;        
        
        if(root.val == p.val || root.val == q.val)
            return root;
        
        if (root.val > p.val && root.val < q.val)
            return root;
        
        if (root.val > q.val && root.val < p.val)
            return root;
        
        if(root.val > p.val && root.val > q.val){
            return LowestCommonAncestor(root.left, p, q);
        }else if(root.val < p.val && root.val < q.val){
            return LowestCommonAncestor(root.right, p, q);
        }
        return root;
    }
}

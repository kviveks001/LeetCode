// Problem :- https://leetcode.com/problems/kth-smallest-element-in-a-bst/

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
    SortedSet<int> res = null; 
    public int KthSmallest(TreeNode root, int k) {
        res = new SortedSet<int>();
        FindSortedSet(root, k);        
        return res.Last();
    }
    
    private void FindSortedSet(TreeNode node, int k){
        if(node != null){
            res.Add(node.val);
            FindSortedSet(node.left, k);
            FindSortedSet(node.right, k);
            
            while(res.Count > k){
                res.Remove(res.Max);
            }
        }
    }
}

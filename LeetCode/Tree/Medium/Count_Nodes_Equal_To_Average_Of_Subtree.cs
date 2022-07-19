// Problem :- https://leetcode.com/problems/count-nodes-equal-to-average-of-subtree/

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
    public int AverageOfSubtree(TreeNode root) {
        return FindNode(root);
    }
    
    private int FindNode(TreeNode node){
        int res = 0;
        if(node != null){
            var resp = FindAverageOfSubtree(node);
            int avg = resp.Key / resp.Value;
            if(avg == node.val) res++;

            if(node.left != null){
                res += FindNode(node.left);
            }
            if(node.right != null){
                res += FindNode(node.right);
            }
        }
        return res;            
    }
    
    private KeyValuePair<int,int> FindAverageOfSubtree(TreeNode node){
        KeyValuePair<int,int> res = new KeyValuePair<int,int>();
        if(node != null){
            res = new KeyValuePair<int,int>(node.val,1);
            if(node.left != null){
                var resL = FindAverageOfSubtree(node.left);
                res = new KeyValuePair<int,int>(res.Key + resL.Key,res.Value + resL.Value);
            }

            if(node.right != null){
                var resR = FindAverageOfSubtree(node.right);
                res = new KeyValuePair<int,int>(res.Key + resR.Key,res.Value + resR.Value);
            }
        }
        
        return res;
    }
}

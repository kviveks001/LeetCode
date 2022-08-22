// Problem :- https://leetcode.com/problems/path-sum-ii/

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
    IList<IList<int>> res = new List<IList<int>>();
    public IList<IList<int>> PathSum(TreeNode root, int targetSum) {
        GetList(root, targetSum,new List<int>());
        return res;
    }
    
    private void GetList(TreeNode node, int targetSum,List<int> path){
        if(node != null){
            path.Add(node.val);
            
            if(node.left == null && node.right == null){
                if(path.Sum() == targetSum)
                    res.Add(path);
            }else {
                if(node.left != null){
                    GetList(node.left, targetSum,path.ToList());
                }
                if(node.right != null){
                    GetList(node.right, targetSum,path.ToList());
                }
            }
        }
    }
}

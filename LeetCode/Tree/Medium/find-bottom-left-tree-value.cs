// Problem :- https://leetcode.com/problems/find-bottom-left-tree-value/

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
    public int FindBottomLeftValue(TreeNode root) {
        Queue<TreeNode> resQueue = new Queue<TreeNode>();
        int res = 0;
        
        if(root != null)
            resQueue.Enqueue(root);
        
        while(resQueue.Any()){
            int levelNodeCount = resQueue.Count;
            
            for(int index = 0; index < levelNodeCount; index++){
                var tempNode = resQueue.Dequeue();
                
                if(index == 0){
                    res = tempNode.val;
                }
                
                if(tempNode.left != null){
                    resQueue.Enqueue(tempNode.left);
                }
                
                if(tempNode.right != null){
                    resQueue.Enqueue(tempNode.right);
                }
            }
        }        
        
        return res;
    }
}

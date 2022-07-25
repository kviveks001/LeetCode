// Problem :- https://leetcode.com/problems/maximum-level-sum-of-a-binary-tree/

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
    public int MaxLevelSum(TreeNode root) {
        return BFS(root);
    }
    
    private int BFS(TreeNode root){
        int maxSum = int.MinValue;
        int maxLevel = 0;
        int res = 0;
        Queue<TreeNode> nodeQueue =new Queue<TreeNode>();
        nodeQueue.Enqueue(root);
        
        while(nodeQueue.Any()){
            int levelNodeCount = nodeQueue.Count;
            int sum = 0;
            for(int index = 0; index < levelNodeCount ; index++){
                var tempNode = nodeQueue.Dequeue();
                sum += tempNode.val;
                
                if(tempNode.left != null)
                    nodeQueue.Enqueue(tempNode.left);
                if(tempNode.right != null)
                    nodeQueue.Enqueue(tempNode.right);
            }
            maxLevel++;
            if(maxSum < sum ){
                res = maxLevel;
                maxSum = sum;
            }
        }
        
        return res;
    }
}

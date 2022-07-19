Problem :- https://leetcode.com/problems/deepest-leaves-sum/

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
    public int DeepestLeavesSum(TreeNode root) {
        int count = 0;
        Queue<TreeNode> nodeQueue = new Queue<TreeNode>();
        
        nodeQueue.Enqueue(root);
        
        while(nodeQueue.Any()){
            int len = nodeQueue.Count;
            count = 0;
            for(int i = 0; i< len ; i++){
                var tempNode = nodeQueue.Dequeue();
                count += tempNode.val;
                if(tempNode.left != null)
                    nodeQueue.Enqueue(tempNode.left);
                if(tempNode.right != null)
                    nodeQueue.Enqueue(tempNode.right);
            }
        }
        return count;        
    }
}

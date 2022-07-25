// Problem :- https://leetcode.com/problems/find-largest-value-in-each-tree-row/

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
    public IList<int> LargestValues(TreeNode root) {
        Queue<TreeNode> resQueue = new Queue<TreeNode>();
        IList<int> res = new List<int>();

        if(root != null)
            resQueue.Enqueue(root);

        while(resQueue.Any()){
            int levelNodeCount = resQueue.Count;
            int max = int.MinValue;
            for(int index = 0; index < levelNodeCount; index++){
                var tempNode = resQueue.Dequeue();
                max = Math.Max(tempNode.val,max);

                if(tempNode.left != null){
                    resQueue.Enqueue(tempNode.left);
                }

                if(tempNode.right != null){
                    resQueue.Enqueue(tempNode.right);
                }
            }
            res.Add(max);
        }      

        return res;
    }
}

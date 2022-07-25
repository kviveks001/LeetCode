// Problem :- https://leetcode.com/problems/binary-tree-level-order-traversal/

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
    public IList<IList<int>> LevelOrder(TreeNode root) {
        Queue<TreeNode> resQueue = new Queue<TreeNode>();
        List<IList<int>> res = new List<IList<int>>();
        
        if(root != null)
            resQueue.Enqueue(root);
        
        while(resQueue.Any()){
            int levelNodeCount = resQueue.Count;
            List<int> tempList = new List<int>();
            
            for(int index = 0; index < levelNodeCount; index++){
                var tempNode = resQueue.Dequeue();
                tempList.Add(tempNode.val);
                if(tempNode.left != null)
                    resQueue.Enqueue(tempNode.left);
                if(tempNode.right != null)
                    resQueue.Enqueue(tempNode.right);
            }
            
            res.Add(tempList);
        }
        
        
        return res;
    }
}

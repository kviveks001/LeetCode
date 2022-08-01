// Problem :- https://leetcode.com/problems/binary-tree-level-order-traversal-ii/

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
    public IList<IList<int>> LevelOrderBottom(TreeNode root) {
        return BFS(root);
    }
    
    private IList<IList<int>> BFS(TreeNode node){
        IList<IList<int>> resp = new List<IList<int>>();
        Queue<TreeNode> treeQueue = new Queue<TreeNode>();
        if(node != null){
            treeQueue.Enqueue(node);
        }
        
        while(treeQueue.Any()){
            IList<int> tempList = new List<int>();
            int preLevelNodeCount = treeQueue.Count;
            
            for(int i = 0; i< preLevelNodeCount ; i++){
                
                var tempNode = treeQueue.Dequeue();
                tempList.Add(tempNode.val);
                
                if(tempNode.left != null){
                    treeQueue.Enqueue(tempNode.left);
                }
                
                if(tempNode.right != null){
                    treeQueue.Enqueue(tempNode.right);
                }
            }
            resp.Insert(0, tempList);
        }
        
        return resp;
    }
}

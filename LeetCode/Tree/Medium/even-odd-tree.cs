// Problem  :- https://leetcode.com/problems/even-odd-tree/

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
    public bool IsEvenOddTree(TreeNode root) {
        return CheckForEvenOddTree(root);
    }
    
    private bool CheckForEvenOddTree(TreeNode node){
        Queue<TreeNode> _tempQueue = new Queue<TreeNode>();
        if(node != null)
            _tempQueue.Enqueue(node);
        int level = 0;
        while(_tempQueue.Any()){
            var len = _tempQueue.Count();
            int preVal = level % 2 == 0 ? int.MinValue : int.MaxValue ;
            
            for(int i = 0 ; i < len ; i++){
                var tempNode = _tempQueue.Dequeue();
                
                if(level % 2 == 0){
                    if(preVal >= tempNode.val || tempNode.val % 2 == 0){
                        return false;
                    }
                }else{
                   if(preVal <= tempNode.val || tempNode.val % 2 != 0){
                        return false;
                    } 
                }
                
                preVal = tempNode.val;
                
                if(tempNode.left != null){
                    _tempQueue.Enqueue(tempNode.left);
                }
                
                if(tempNode.right != null){
                    _tempQueue.Enqueue(tempNode.right);
                }
            }
            
            level++;
        }
        return true;
    }
}

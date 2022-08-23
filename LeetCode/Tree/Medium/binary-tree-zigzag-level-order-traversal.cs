// Problem :- https://leetcode.com/problems/binary-tree-zigzag-level-order-traversal/

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
    public IList<IList<int>> ZigzagLevelOrder(TreeNode root) {
        IList<IList<int>> res = new List<IList<int>>();
        Queue<TreeNode> _tempQueue = new Queue<TreeNode>();
        if(root != null){
            _tempQueue.Enqueue(root);
        }
        bool isLToR = true;
        while(_tempQueue.Any()){
            int len = _tempQueue.Count();
            var tempList = new List<int>();
            for(int index = 0 ; index < len ; index++){
                var tempNode = _tempQueue.Dequeue();
                
                if(isLToR){
                    tempList.Add(tempNode.val);
                }else{
                    tempList.Insert(0,tempNode.val);
                }
                
                if(tempNode.left != null){
                    _tempQueue.Enqueue(tempNode.left);
                }

                if(tempNode.right != null){
                    _tempQueue.Enqueue(tempNode.right);
                }
            }
            res.Add(tempList);
            isLToR = !isLToR;
        }
        
        return res;
    }
}

// https://leetcode.com/problems/sum-of-nodes-with-even-valued-grandparent/


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
    public int SumEvenGrandparent(TreeNode root) {
        return GetSumEvenGrandparent(root);
    }
    
    private int GetSumEvenGrandparent(TreeNode node){
        if(node == null) return 0;
        int sum = 0;
        
        if(node.val % 2 == 0){
            sum += SecondLevelNodeSum(node);
        }
        
        if(node.left != null){
            sum += GetSumEvenGrandparent(node.left);
        }
        
        if(node.right != null){
            sum += GetSumEvenGrandparent(node.right);
        }
        
        return sum;
    }
    
    private int SecondLevelNodeSum(TreeNode node){
        Queue<TreeNode> _queu = new Queue<TreeNode>();
        int level = 0;
        _queu.Enqueue(node);
        
        while(_queu.Any()){
            int sum = 0;
            int cnt = _queu.Count;
            level++;
            for(int i = 0 ; i < cnt ; i++){
                var tempNode = _queu.Dequeue();
                sum += tempNode.val;
                if(tempNode.left != null)
                    _queu.Enqueue(tempNode.left);
                if(tempNode.right != null)
                    _queu.Enqueue(tempNode.right);
            }
            if(level == 3) return sum;
        }
        return 0;
    }
}

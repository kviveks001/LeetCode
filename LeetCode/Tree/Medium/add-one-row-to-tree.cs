// Problem :- https://leetcode.com/problems/add-one-row-to-tree/

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
    public TreeNode AddOneRow(TreeNode root, int val, int depth) {
        return AddNode(root, val, depth);
    }
    
    private TreeNode AddNode(TreeNode node, int val, int depth){
        Queue<TreeNode> _tempNode = new Queue<TreeNode>();
        
        if(node != null){
            _tempNode.Enqueue(node);
        }
        int level = 1;
        
        if(level == depth){ 
            var tempNode = new TreeNode(val);
            tempNode.left = node;
            return tempNode;
        }else{
            while(_tempNode.Any()){
                int prevLevelNodeCount = _tempNode.Count();
                level++;

                for(int index = 0; index < prevLevelNodeCount; index++){

                    var tempNode = _tempNode.Dequeue();

                    if(level == depth){                       
                        var leftNode = tempNode.left;
                        var rightNode = tempNode.right;
                        tempNode.left = new TreeNode(val);
                        tempNode.left.left = leftNode;
                        tempNode.right = new TreeNode(val);
                        tempNode.right.right = rightNode;
                    }else{
                        if(tempNode.left != null){
                            _tempNode.Enqueue(tempNode.left);
                        }

                        if(tempNode.right != null){
                            _tempNode.Enqueue(tempNode.right);
                        }
                    }
                }
            }
            return node;
        }
    }
}

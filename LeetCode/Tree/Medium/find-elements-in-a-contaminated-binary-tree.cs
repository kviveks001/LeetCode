// Problem :- https://leetcode.com/problems/find-elements-in-a-contaminated-binary-tree/

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
public class FindElements {
    TreeNode parsedTreeRootNode;
    public FindElements(TreeNode root) {
        if(root != null) root.val = 0;
        parsedTreeRootNode = root;
        RecoveredBinaryTree(parsedTreeRootNode);
    }
    
    private void RecoveredBinaryTree(TreeNode node){
        if(node != null){
            if(node.left != null){
                node.left.val = 2 * node.val + 1;
                RecoveredBinaryTree(node.left);
            }
            
            if(node.right != null){
                node.right.val = 2 * node.val + 2;
                RecoveredBinaryTree(node.right);
            }
        }
    }
    
    public bool Find(int target) {
        return FindNode(parsedTreeRootNode,target);
    }
    
    private bool FindNode(TreeNode node, int target){
        if(node != null){
            if(node.val == target) return true;            
            return FindNode(node.left,target) || FindNode(node.right,target);
        }
        return false;
    }
}

/**
 * Your FindElements object will be instantiated and called as such:
 * FindElements obj = new FindElements(root);
 * bool param_1 = obj.Find(target);
 */

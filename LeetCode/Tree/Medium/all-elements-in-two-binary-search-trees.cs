// Problem :- https://leetcode.com/problems/all-elements-in-two-binary-search-trees/

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
    public IList<int> GetAllElements(TreeNode root1, TreeNode root2) {
        List<int> allNodeValue = new List<int>();
        TriverseAllNode(root1, allNodeValue);
        TriverseAllNode(root2, allNodeValue);
        return allNodeValue.OrderBy(x=>x).ToList();
    }
    
    private void TriverseAllNode(TreeNode node,List<int> allNodeValue){
        if(node != null){
            allNodeValue.Add(node.val);
            if(node.left != null){
                TriverseAllNode(node.left, allNodeValue);
            }
            
            if(node.right != null){
                TriverseAllNode(node.right, allNodeValue);
            }
        }
    }
}

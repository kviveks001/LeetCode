// Problem :- https://leetcode.com/problems/serialize-and-deserialize-bst/

/**
 * Definition for a binary tree node.
 * public class TreeNode {
 *     public int val;
 *     public TreeNode left;
 *     public TreeNode right;
 *     public TreeNode(int x) { val = x; }
 * }
 */
public class Codec {

    // Encodes a tree to a single string.
    public string serialize(TreeNode root) {
        var res = getSerializeString(root);
        return res;
    }
    
    private string getSerializeString(TreeNode root) {
        Queue<TreeNode> nodeQueue = new Queue<TreeNode>();
        StringBuilder resp = new StringBuilder();
        nodeQueue.Enqueue(root);
        while(nodeQueue.Any()){
            var tempNode = nodeQueue.Dequeue();
            
            if(tempNode == null){
                resp.Append("# ");
            }else{
                resp.Append(tempNode.val + " ");
                nodeQueue.Enqueue(tempNode.left);
                nodeQueue.Enqueue(tempNode.right);
            }
        }
        return resp.ToString();
    }

    // Decodes your encoded data to tree.
    public TreeNode deserialize(string data) {
        if(string.IsNullOrEmpty(data) || data.Trim() == "#"){
            return null;
        }else{
            var splittedList = data.Trim().Split(" ").ToList();
            Queue<TreeNode> tempQueue = new Queue<TreeNode>();
            TreeNode root = new TreeNode(int.Parse(splittedList[0]));
            tempQueue.Enqueue(root);
            for( int index = 1 ; index < splittedList.Count ; index++){
                var parent = tempQueue.Dequeue();
                if(splittedList[index] != "#"){
                    parent.left = new TreeNode(int.Parse(splittedList[index]));
                    tempQueue.Enqueue(parent.left);
                }
                if( ++index < splittedList.Count && splittedList[index] != "#"){
                    parent.right = new TreeNode(int.Parse(splittedList[index]));
                    tempQueue.Enqueue(parent.right);
                }
            }
            return root;
        }
    }
}

// Your Codec object will be instantiated and called as such:
// Codec ser = new Codec();
// Codec deser = new Codec();
// String tree = ser.serialize(root);
// TreeNode ans = deser.deserialize(tree);
// return ans;

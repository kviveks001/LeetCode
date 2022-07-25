// Problem :- https://leetcode.com/problems/n-ary-tree-level-order-traversal/

/*
// Definition for a Node.
public class Node {
    public int val;
    public IList<Node> children;

    public Node() {}

    public Node(int _val) {
        val = _val;
    }

    public Node(int _val, IList<Node> _children) {
        val = _val;
        children = _children;
    }
}
*/

public class Solution {
    public IList<IList<int>> LevelOrder(Node root) {
        Queue<Node> resQueue = new Queue<Node>();
        List<IList<int>> res = new List<IList<int>>();
        
        if(root != null)
            resQueue.Enqueue(root);
        
        while(resQueue.Any()){
            int levelNodeCount = resQueue.Count;
            List<int> tempList = new List<int>();
            
            for(int index = 0; index < levelNodeCount; index++){
                var tempNode = resQueue.Dequeue();
                tempList.Add(tempNode.val);
                for(int j = 0 ; j < tempNode.children.Count ; j++){
                    resQueue.Enqueue(tempNode.children[j]);
                }
            }
            
            res.Add(tempList);
        }
        
        
        return res;
    }
}

// Problem - https://leetcode.com/problems/populating-next-right-pointers-in-each-node/

/*
// Definition for a Node.
public class Node {
    public int val;
    public Node left;
    public Node right;
    public Node next;

    public Node() {}

    public Node(int _val) {
        val = _val;
    }

    public Node(int _val, Node _left, Node _right, Node _next) {
        val = _val;
        left = _left;
        right = _right;
        next = _next;
    }
}
*/

public class Solution {
    public Node Connect(Node root) {
        ConnectNode(root);
        return root;
    }
    
    private void ConnectNode(Node node){
        Queue<Node> tempQueue = new Queue<Node>();
        if(node != null)
            tempQueue.Enqueue(node);
        while(tempQueue.Any()){
            int len = tempQueue.Count;
            Node tempPrev = null;
            for(int index = 0; index < len ; index++){
                var tempNode = tempQueue.Dequeue();
                
                if(tempNode.left != null && tempNode.right != null){
                    tempNode.left.next = tempNode.right;
                    tempQueue.Enqueue(tempNode.left);
                    tempQueue.Enqueue(tempNode.right);
                    
                    if(tempPrev != null){
                        tempPrev.next = tempNode.left;
                    }                    
                    tempPrev = tempNode.right;
                }
            }
        }
    }
}

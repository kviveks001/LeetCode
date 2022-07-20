// Problem :- https://leetcode.com/problems/path-in-zigzag-labelled-binary-tree/

public class TreeNode1 {
    public TreeNode1 left {get; set;}
    public TreeNode1 right {get; set;}
    public int val {get; set;}
    public TreeNode1(TreeNode1 left, TreeNode1 right, int val){
        this.left = left;
        this.right = right;
        this.val = val;
    }
}

public class Solution {
    public IList<int> PathInZigZagTree(int label) {
        TreeNode1 node = BuildTree(label);
        List<int> res = new List<int>();
        FindPath(node,label,res);
        return res;
    }
    
    private TreeNode1 BuildTree(int target){
        Queue<TreeNode1> queu = new Queue<TreeNode1>();
        bool isLeftToRight = true;
        int counter = 1;
        TreeNode1 node = new TreeNode1(null,null,counter);
        
        queu.Enqueue(node);
        
        isLeftToRight = !isLeftToRight;
        
        while(queu.Any()){
            
            int nodecount = queu.Count;
            int numc = counter;
            if(!isLeftToRight){
                numc += (2 * nodecount);
            }else{
                numc += 1;
            }
            
            for(int i = 0 ; i < nodecount ; i++){
                var tempNode = queu.Dequeue();
                if(counter <= target){
                    if(isLeftToRight){
                        tempNode.left =new TreeNode1(null,null,numc++);
                        tempNode.right =new TreeNode1(null,null,numc++);
                    }else{
                        tempNode.left =new TreeNode1(null,null,numc--);
                        tempNode.right =new TreeNode1(null,null,numc--);
                    }
                    queu.Enqueue(tempNode.left);
                    queu.Enqueue(tempNode.right);
                }else{
                    return node;
                }
            }
            counter += (2 * nodecount);
            isLeftToRight = !isLeftToRight;
        }
        
        return node;
    }
    
    private bool FindPath(TreeNode1 node, int target,List<int> res){
        bool resp = false;
        if(node != null){
            res.Add(node.val);
            if(node.val == target){
                resp = true;
            }else{
               resp = FindPath(node.left , target, res) ||
                FindPath(node.right , target, res);
            }
            if(!resp){
                res.Remove(node.val);
            }
        }
        return resp;
    }
}

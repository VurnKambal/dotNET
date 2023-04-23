
public class Branch
{
    int maxDepth = 0;


    List<Branch> branches;
    public Branch(List<Branch> branches)
    {
        this.branches = branches;
    }


    public Branch()
    {
        this.branches = new List<Branch> { };
    }

    // currentDepth defaults to 0 from the caller to its lowest node, the maxDepth 
    public int findDepth(int currentDepth = 0)
    {
        if (this.branches != null)
        {
            foreach (Branch branch in this.branches)
            {
                maxDepth = Math.Max(branch.findDepth(currentDepth + 1), maxDepth);
            }
        }

        return Math.Max(currentDepth, maxDepth); ;
    }
}

class Kent
{
    // Initialize branches to imitate the given tree
    // Find the depth of the tree starting from the rootNode
    static void Main(string[] args)
    {
        int depth = 0;
        Branch node1 = new Branch();
        Branch node2 = new Branch();
        Branch node3 = new Branch(new List<Branch> { node1 });
        Branch node4 = new Branch();
        Branch node5 = new Branch();
        Branch node6 = new Branch(new List<Branch> { node2 });
        Branch node7 = new Branch(new List<Branch> { node3, node4 });
        Branch node8 = new Branch();
        Branch node9 = new Branch(new List<Branch> { node5 });
        Branch node10 = new Branch(new List<Branch> { node6, node7, node7 });
        Branch rootNode = new Branch(new List<Branch> { node9, node10 });



        depth = rootNode.findDepth();
        Console.WriteLine($"\nThe Tree's depth is {depth}\n");

    }

}






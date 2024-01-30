using System.Collections.Generic;
public class MyNode
{
    public int Index;
    private List<MyNode> _children;

    public MyNode(int index)
    {
        Index = index;
        _children = new List<MyNode>();
    }
    
    public void AddChild(MyNode n)
    {
        int changeIndex = _children.FindIndex(x => x.Index > n.Index);
        _children.Insert(changeIndex,n);
    }
}

public class MyTree
{
    public Dictionary<int,MyNode> Nodes;

    public MyTree()
    {
        Nodes = new Dictionary<int, MyNode>() { {-1,new MyNode(-1)} };
    }

    public void AddElement(int index, int parentIndex)
    {
        if (Nodes.TryGetValue(parentIndex, out MyNode parentNode))
        {
            if (Nodes.TryGetValue(index, out MyNode tryNode))
            {
                parentNode.AddChild(tryNode);
            }
            else
            {
                MyNode newNode = new MyNode(index);
                parentNode.AddChild(newNode);
                Nodes[index] = newNode;
            }

        }
        else
        {
            if (Nodes.TryGetValue(index, out MyNode tryNode))
            {
                MyNode newParentNode = new MyNode(parentIndex);
                parentNode.AddChild(tryNode);
                Nodes[index] = newParentNode;
            }
            else
            {
                MyNode newParentNode = new MyNode(parentIndex);
                MyNode newNode = new MyNode(index);
                newParentNode.AddChild(newNode);
                Nodes[index] = newParentNode;
                Nodes[index] = newNode;
            }
        }
    }
}
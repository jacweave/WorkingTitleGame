using UnityEngine;
using System.Collections;

public class Node {

    public Node parent { get; set; }
    public Dimension dim { get; set; }

    public Node()
    {
        parent = null;
        dim = null;
    }

    public Node(Node n)
    {
        parent = n;
        dim = null;
    }

    public Node(Node n, Dimension d)
    {
        parent = n;
        dim = d;
    }

    public Node(Dimension d)
    {
        parent = null;
        dim = d;
    }
}

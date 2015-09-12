using UnityEngine;
using System.Collections;

public class Dimension {

    //Fields
    private int _dimX;
    private int _dimY;

    //Properties
    public int X { get { return _dimX; } set { _dimX = value; } }
    public int Y { get { return _dimY; } set { _dimY = value; } }

    public Dimension(int x, int y)
    {
        X = x;
        Y = y;
    }

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}

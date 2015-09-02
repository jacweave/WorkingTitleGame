using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class BaseTile : MonoBehaviour {

    //Fields
    private List<object> _contents;
    private Dimension _pos;

    //Properties
    public List<object> Contents { get { return _contents; } set { _contents = value; } }
    public Dimension Position { get { return _pos; } set { _pos = value; } }
    public int PositionX { get { return _pos.X; } set { _pos.X = value; } }
    public int PositionY { get { return _pos.Y; } set { _pos.Y = value; } }

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    public bool IsEmpty()
    {
        return Contents.Count == 0;
    }
}

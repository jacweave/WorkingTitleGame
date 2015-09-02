using UnityEngine;
using System.Collections;

public class BaseControllable : MonoBehaviour {

    //Fields
    private int _visRange;
    private BasePlayer _owner; //TODO: Change type
    private int _size;
    private bool _actionStatus;
    private Dimension _pos;

    //Properties
    public int VisibilityRange { get { return _visRange; } set { _visRange = value; } }
    public BasePlayer Owner { get { return _owner; } set { _owner = value; } }
    public int Size { get { return _size; } set { _size = value; } }
    public bool ActionStatus { get { return _actionStatus; } set { _actionStatus = value; } }
    public Dimension Position { get { return _pos; } set { _pos = value; } }

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}

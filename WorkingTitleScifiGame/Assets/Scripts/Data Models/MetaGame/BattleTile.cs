using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class BattleTile : BaseTile {

    //Fields
    private Dictionary<BasePlayer, bool> _visPlayer;

    //Properties
    public Dictionary<BasePlayer, bool> PlayerVisibility { get { return _visPlayer; } set { _visPlayer = value; } }

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}

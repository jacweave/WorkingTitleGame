using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class BaseInstance : MonoBehaviour {

    //Fields
    private List<int> _players;
    private BaseMap _map;

    //Properties
    public List<int> Players { get { return _players; } set { _players = value; } }
    public BaseMap Map { get { return _map; } set { _map = value; } }

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}

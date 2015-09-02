using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class UtilityAction : BaseAction {

    //Fields
    private BaseControllable _target;
    private List<int> _effects;
    private int _duration;

    //Properties
    public BaseControllable Target { get { return _target; } set { _target = value; } }
    public List<int> Effects { get { return _effects; } set { _effects = value; } }
    public int Duration { get { return _duration; } set { _duration = value; } }

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}

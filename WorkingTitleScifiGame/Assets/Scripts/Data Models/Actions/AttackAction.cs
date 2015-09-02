using UnityEngine;
using System.Collections;

public class AttackAction : BaseAction {

    //Fields
    private BaseControllable _target;

    //Properties
    public BaseControllable Target { get { return _target; } set { _target = value; } }

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}

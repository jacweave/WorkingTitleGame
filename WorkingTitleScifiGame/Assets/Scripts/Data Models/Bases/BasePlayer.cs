using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class BasePlayer : MonoBehaviour {

    //Fields
    private List<UnitControllable> _units;
    private List<BuildingControllable> _buildings;
    private int _resource;
    private string _id;

    //Properties
    public List<UnitControllable> Units { get { return _units; } set { _units = value; } }
    public List<BuildingControllable> Buildings { get { return _buildings; } set { _buildings = value; } }
    public int Resource { get { return _resource; } set { _resource = value; } }
    public string Identifier { get { return _id; } set { _id = value; } }

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}

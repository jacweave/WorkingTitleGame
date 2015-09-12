using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class Startup : MonoBehaviour {

	// Use this for initialization
	void Start () {
        SessionHandler.SetSessionVariable("Player", new HumanPlayer { Name = "Human", Units = new List<UnitControllable>(), Buildings = new List<BuildingControllable>(), Identifier = "1", Resource = 0 });
        Debug.Log(SessionHandler.GetSessionVariable("Player"));
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}

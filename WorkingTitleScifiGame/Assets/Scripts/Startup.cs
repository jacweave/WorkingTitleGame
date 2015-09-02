using UnityEngine;
using System.Collections;

public class Startup : MonoBehaviour {

	// Use this for initialization
	void Start () {
        SessionHandler.SetSessionVariable("Player", new HumanPlayer { Name = "Human", Units = null, Buildings = null, Identifier = "1", Resource = 0 });
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}

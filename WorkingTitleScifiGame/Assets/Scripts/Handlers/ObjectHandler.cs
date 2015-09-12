using UnityEngine;
using System.Collections;

public class ObjectHandler : MonoBehaviour {

    public delegate void UpdateDel();

    private UpdateDel _update;

    public UpdateDel Updater { get { return _update; } set { _update = value; } }

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
        Updater();
	}
}

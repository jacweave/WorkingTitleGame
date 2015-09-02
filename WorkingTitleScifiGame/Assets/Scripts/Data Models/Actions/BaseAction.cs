using UnityEngine;
using System.Collections;

public class BaseAction : MonoBehaviour {

    //Fields
    private BaseControllable _actor;

    //Properties
    public BaseControllable Actor { get { return _actor; } set { _actor = value; } }

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    protected void SetActionStatus()
    {
        try
        {
            Actor.ActionStatus = true;
        }
        catch
        {

        }
        
    }
}

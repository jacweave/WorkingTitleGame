using UnityEngine;
using System.Collections;

public class BuildingControllable : BaseControllable {

    //Fields
    #region BuildingControllable/Fields
    private int _actionStatus;
    private int _capPoints;
    #endregion

    //Properties
    #region BuildingControllable/Properties
    public int ActionStatus { get { return _actionStatus; } set { _actionStatus = value; } }
    public int CapturePoints { get { return _capPoints; } set { _capPoints = value; } }
    #endregion

    // Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}

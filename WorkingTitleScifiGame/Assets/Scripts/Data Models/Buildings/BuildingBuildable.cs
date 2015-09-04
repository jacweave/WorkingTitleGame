using UnityEngine;
using System.Collections;

public class BuildingBuildable : BaseBuildable {

    //Fields
    #region BuildingBuildable/Fields
    private int _visRange;
    private int _capPoints;
    #endregion

    //Properties
    #region BuildingBuildable/Properties
    public int VisibilityRange { get { return _visRange; } set { _visRange = value; } }
    public int CapturePoints { get { return _capPoints; } set { _capPoints = value; } }
    #endregion

    // Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}

using UnityEngine;
using System.Collections;

public class UnitBuildable : BaseBuildable {

    //Fields
    private int _movRange;
    private int _visRange;
    private int _buildAt;
    private int _healthCap;

    //Properties
    public int MoveRange { get { return _movRange; } set { _movRange = value; } }
    public int VisibilityRange { get { return _visRange; } set { _visRange = value; } }
    public int BuiltAt { get { return _buildAt; } set { _buildAt = value; } }
    public int HealthCapacity { get { return _healthCap; } set { _healthCap = value; } }

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}

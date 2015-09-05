using UnityEngine;
using System.Collections;

public class BaseBuildable : MonoBehaviour {

    //Fields
    #region BaseBuildable/Fields
    private int _cost;
    private int _buildTime;
    private int _size;
    private SpriteRenderer _sprite;
    #endregion

    //Properties
    #region BaseBuildable/Properties
    public int Cost { get { return _cost; } set { _cost = value; } }
    public int BuildTime { get { return _buildTime; } set { _buildTime = value; } }
    public int Size { get { return _size; } set { _size = value; } }
    public SpriteRenderer Sprite { get { return _sprite; } set { _sprite = value; } }
    #endregion

    // Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}

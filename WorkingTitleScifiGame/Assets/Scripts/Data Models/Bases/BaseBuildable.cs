using UnityEngine;
using System.Collections;

public class BaseBuildable {

    //Fields
    #region BaseBuildable/Fields
    private int _cost;
    private int _buildTime;
    private int _size;
    private Sprite _sprite;
    #endregion

    //Properties
    #region BaseBuildable/Properties
    public int Cost { get { return _cost; } set { _cost = value; } }
    public int BuildTime { get { return _buildTime; } set { _buildTime = value; } }
    public int Size { get { return _size; } set { _size = value; } }
    public Sprite Sprite { get { return _sprite; } set { _sprite = value; } }
    #endregion
}

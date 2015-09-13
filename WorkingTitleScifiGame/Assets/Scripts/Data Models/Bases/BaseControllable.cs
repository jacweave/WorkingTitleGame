using UnityEngine;
using System.Collections;

public class BaseControllable : BaseObject {

    //Fields
    #region BaseControllable/Fields
    private int _visRange;
    private BasePlayer _owner; 
    private int _size;
    private bool _actionStatus;
    private Dimension _pos;
    private Sprite _sprite;
    private GameObject _object;
    #endregion

    //Properties
    #region BaseControllable/Properties
    public int VisibilityRange { get { return _visRange; } set { _visRange = value; } }
    public BasePlayer Owner { get { return _owner; } set { _owner = value; } }
    public int Size { get { return _size; } set { _size = value; } }
    public bool ActionStatus { get { return _actionStatus; } set { _actionStatus = value; } }
    public Dimension Position { get { return _pos; } set { _pos = value; } }
    public Sprite Sprite { get { return _sprite; } set { _sprite = value; } }
    public GameObject Object { get { return _object; } set { _object = value; } }
    #endregion

    //Constructors
    #region BaseControllable/Constructors
    public BaseControllable()
    {

    }

    public BaseControllable(int vRange, BasePlayer ownr, int s, Dimension p, Sprite sprite, bool actStatus = true) 
    {
        Init();
        VisibilityRange = vRange;
        Owner = ownr;
        Size = s;
        Position = p;
        Sprite = sprite;
        ActionStatus = actStatus;
        Renderer.sprite = sprite;
    }
    #endregion
}

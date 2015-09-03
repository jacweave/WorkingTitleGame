using UnityEngine;
using System.Collections;

public class BaseControllable : MonoBehaviour {

    //Fields
    #region BaseControllable/Fields
    private int _visRange;
    private BasePlayer _owner; //TODO: Change type
    private int _size;
    private bool _actionStatus;
    private Dimension _pos;
    private SpriteRenderer _sprite;
    #endregion

    //Properties
    #region BaseControllable/Properties
    public int VisibilityRange { get { return _visRange; } set { _visRange = value; } }
    public BasePlayer Owner { get { return _owner; } set { _owner = value; } }
    public int Size { get { return _size; } set { _size = value; } }
    public bool ActionStatus { get { return _actionStatus; } set { _actionStatus = value; } }
    public Dimension Position { get { return _pos; } set { _pos = value; } }
    public SpriteRenderer Sprite { get { return _sprite; } set { _sprite = value; } }
    #endregion

    //Constructors
    #region BaseControllable/Constructors
    public BaseControllable()
    {

    }

    public BaseControllable(int vRange, BasePlayer ownr, int s, Dimension p, string spriteLoc, bool actStatus = true)
    {
        VisibilityRange = vRange;
        Owner = ownr;
        Size = s;
        Position = p;
        Sprite = new SpriteRenderer();
        Sprite.sprite = Resources.Load<Sprite>(spriteLoc);
        ActionStatus = actStatus;
    }
    #endregion

    // Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}

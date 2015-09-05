using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class BaseTile : MonoBehaviour {

    //Fields
    #region BaseTile/Fields
    private List<object> _contents;
    private Dimension _pos;
    private SpriteRenderer _emptySprite;
    #endregion

    //Properties
    #region BaseTile/Fields
    public List<object> Contents { get { return _contents; } set { _contents = value; } }
    public Dimension Position { get { return _pos; } set { _pos = value; } }
    public int PositionX { get { return _pos.X; } set { _pos.X = value; } }
    public int PositionY { get { return _pos.Y; } set { _pos.Y = value; } }
    public SpriteRenderer EmptySprite { get { return _emptySprite; } set { _emptySprite = value; } }
    #endregion

    //Constructoors
    #region BaseTile/Constructors
    public BaseTile()
    {

    }

    public BaseTile(Dimension d)
    {
        Position = d;
        EmptySprite = new SpriteRenderer();
        EmptySprite.sprite = Resources.Load<Sprite>("Art/Sprites/EmptyTile");
    }
    #endregion

    // Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    public bool IsEmpty()
    {
        return Contents.Count == 0;
    }

    public void AddContent(object o)
    {
        Contents.Add(o);
    }

    public bool RemoveContent(object o)
    {
        return Contents.Remove(o);
    }
}

using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class BaseTile : BaseObject {

    //Fields
    #region BaseTile/Fields
    private List<object> _contents;
    private Dimension _pos;
    private Sprite _emptySprite;
    #endregion

    //Properties
    #region BaseTile/Fields
    public List<object> Contents { get { return _contents; } set { _contents = value; } }
    public Dimension Position { get { return _pos; } set { _pos = value; } }
    public int PositionX { get { return _pos.X; } set { _pos.X = value; } }
    public int PositionY { get { return _pos.Y; } set { _pos.Y = value; } }
    public Sprite EmptySprite { get { return _emptySprite; } set { _emptySprite = value; } }
    #endregion

    protected override void Init()
    {
        base.Init();
    }

    //Constructoors
    #region BaseTile/Constructors
    public BaseTile() : base()
    {

    }

    public BaseTile(Dimension d) : base()
    {
        Init();
        Position = d;
        EmptySprite = new Sprite();
        EmptySprite = Resources.Load<Sprite>("Art/Sprites/EmptyTile");
        Renderer.sprite = EmptySprite;
        Transform.position = new Vector3((float)d.X, (float)d.Y, 0f);
    }
    #endregion

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

    public override void OnUpdate()
    {
 	    base.OnUpdate();
    }
}

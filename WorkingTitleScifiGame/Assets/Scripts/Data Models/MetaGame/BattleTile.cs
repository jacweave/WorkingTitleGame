using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class BattleTile : BaseTile {

    //Fields
    #region BattleTile/Fields
    private Dictionary<BasePlayer, bool> _visPlayer;
    private static Dictionary<string, int> _priorities = new Dictionary<string,int> { { "Building", 1 },
                                                                                      { "Unit", 2 }, 
                                                                                      { "Indicator", 3 },
                                                                                      { "Fog", 4 } };
    private static SpriteRenderer _indicator;
    private static SpriteRenderer _fog;
    private bool _indicate;
    #endregion

    //Properties
    #region BattleTile/Properties
    public Dictionary<BasePlayer, bool> PlayerVisibility { get { return _visPlayer; } set { _visPlayer = value; } }
    public static Dictionary<string, int> Priorities { get { return _priorities; } }
    public static SpriteRenderer Indicator { get { return _indicator; } set { _indicator = value; } }
    public static SpriteRenderer Fog { get { return _fog; } set { _fog = value; } }
    public bool Indicate { get { return _indicate; } set { _indicate = value; } }
    #endregion

    //Constructoors
    #region BattleTile/Constructors
    public BattleTile() : base()
    {

    }

    public BattleTile(Dimension d) : base(d)
    {
        
    }
    #endregion

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    public void SetVisible(BasePlayer p)
    {
        PlayerVisibility[p] = true;
    }

    public void SetInvisible(BasePlayer p)
    {
        PlayerVisibility[p] = false;
    }

    public bool CheckVisibility(BasePlayer p)
    {
        return PlayerVisibility[p];
    }

    public void SetIndicate(Color c)
    {
        Indicate = true;
        Indicator.color = c;
    }

    public void DesetIndicate()
    {
        Indicate = false;
    }
}

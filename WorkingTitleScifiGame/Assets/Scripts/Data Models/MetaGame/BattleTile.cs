using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class BattleTile : BaseTile {

    //Fields
    #region BattleTile/Fields
    private Dictionary<BasePlayer, bool> _visPlayer;
    private static Dictionary<string, int> _priorities = new Dictionary<string,int> { { "Building", 1 },
                                                                                      { "Unit", 2 }, 
                                                                                      { "Fog", 3 },
                                                                                      { "Indicator", 4 } };
    private static Sprite _indicator;
    private static Sprite _fog;
    private bool _indicate;
    #endregion

    //Properties
    #region BattleTile/Properties
    public Dictionary<BasePlayer, bool> PlayerVisibility { get { return _visPlayer; } set { _visPlayer = value; } }
    public static Dictionary<string, int> Priorities { get { return _priorities; } }
    public static Sprite Indicator { get { return _indicator; } set { _indicator = value; } }
    public static Sprite Fog { get { return _fog; } set { _fog = value; } }
    public bool Indicate { get { return _indicate; } set { _indicate = value; } }
    #endregion

    //Constructoors
    #region BattleTile/Constructors
    protected override void Init()
    {
        base.Init();
        PlayerVisibility = new Dictionary<BasePlayer, bool>();
        foreach(BasePlayer p in ((BattleInstance)(SessionHandler.GetSessionVariable(Enums.SessVars.ActiveInst))).Players)
        {
            PlayerVisibility.Add(p, false);
        }
    }

    public BattleTile() : base()
    {
        Init();
    }

    public BattleTile(Dimension d) : base(d)
    {
        Init();
    }

    public BattleTile(int x, int y) : base(new Dimension(x, y))
    {
        Init();
    }
    #endregion

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
        Renderer.color = c;
    }

    public void DesetIndicate()
    {
        Indicate = false;
    }

    public override void OnUpdate()
    {
 	     base.OnUpdate();
        if (CheckVisibility((BasePlayer)SessionHandler.GetSessionVariable(Enums.SessVars.LocalPlayer)))
        {
            Renderer.enabled = true;
        }
        else
        {
            Renderer.enabled = false;
        }
    }
}

using UnityEngine;
using System.Collections;

public class BattleMap : BaseMap {

    //Fields
    private bool _fogOfWar;

    //Properties
    public bool FogOfWar { get { return _fogOfWar; } set { _fogOfWar = value; } }

    //Constructors
     #region BattleMap/Constructors
    public BattleMap() : base()
    {

    }

    public BattleMap(Dimension dim) : base(dim)
    {
        FogOfWar = true;
    }

    public BattleMap(BattleTile[,] tile) : base(tile)
    {
        FogOfWar = true;
    }

    public BattleMap(Dimension dim, BaseTile[,] tile) : base(dim, tile)
    {
        FogOfWar = true;
    }
    #endregion

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}

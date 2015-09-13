using UnityEngine;
using System.Collections;

public class BattleMap : BaseMap {

    //Fields
    private bool _fogOfWar = true;

    //Properties
    public bool FogOfWar { get { return _fogOfWar; } set { _fogOfWar = value; } }

    //Constructors
     #region BattleMap/Constructors
    protected override void Init()
    {
        base.Init();
    }
    public BattleMap() : base()
    {
        Init();
    }

    public BattleMap(Dimension dim) : base(dim)
    {
        Tiles = new BattleTile[dim.X, dim.Y];
        for (int i = 0; i < dim.X; i++)
        {
            for (int j = 0; j < dim.Y; j++)
            {
                Tiles[i, j] = new BattleTile(i, j);
            }
        }
    }

    public BattleMap(BattleTile[,] tile) : base(tile)
    {
        
    }

    public BattleMap(Dimension dim, BaseTile[,] tile) : base(dim, tile)
    {
        
    }
    #endregion

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    public static BattleMap RandomMap()
    {
        var rX = UnityEngine.Random.Range(15, 51);
        var rY = UnityEngine.Random.Range(15, 51);

        return new BattleMap(new Dimension(rX, rY));
    }
}

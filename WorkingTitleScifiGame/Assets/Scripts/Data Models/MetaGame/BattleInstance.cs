using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class BattleInstance : BaseInstance {

    //Fields
    #region BattleInstance/Fields
    private BasePlayer _turn;
    private List<UnitBuildable> _units;
    private List<BuildingBuildable> _buildings;
    private Queue<BasePlayer> _turnTrack;
    #endregion

    //Properties
    #region BattleInstance/Properties
    public BasePlayer PlayerTurn { get { return _turn; } set { _turn = value; } }
    public List<UnitBuildable> Units { get { return _units; } set { _units = value; } }
    public List<BuildingBuildable> Buildings { get { return _buildings; } set { _buildings = value; } }
    public Queue<BasePlayer> TurnTracker { get { return _turnTrack; } set { _turnTrack = value; } }
    #endregion

    //Constructors
    #region BattleInstance/Constructors
    public BattleInstance() : base()
    {
        Units = XMLHandler.LoadUnitBuildables();
        Buildings = XMLHandler.LoadBuildingBuildables();
        PlayerTurn = Players[0];
        TurnTracker = new Queue<BasePlayer>(Players.GetRange(1, Players.Count - 1));
        PlayerTurn.StartTurn();
    }

    public BattleInstance(List<BasePlayer> p) : base(p)
    {
        Units = XMLHandler.LoadUnitBuildables();
        Buildings = XMLHandler.LoadBuildingBuildables();
        PlayerTurn = Players[0];
        Map = (BattleMap)Map;
        PlayerTurn = Players[0];
        TurnTracker = new Queue<BasePlayer>(Players.GetRange(1, Players.Count - 1));
        PlayerTurn.StartTurn();
    }

    public BattleInstance(BattleMap map, List<BasePlayer> p) : base(map, p)
    {
        Units = XMLHandler.LoadUnitBuildables();
        Buildings = XMLHandler.LoadBuildingBuildables();
        PlayerTurn = Players[0];
        TurnTracker = new Queue<BasePlayer>(Players.GetRange(1, Players.Count - 1));
        PlayerTurn.StartTurn();
    }
    #endregion

    // Use this for initialization
	void Start () {
        
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    public bool CheckEndTurn()
    {
        return PlayerTurn.EndTurn;
    }

    public void NextTurn()
    {
        TurnTracker.Enqueue(PlayerTurn);
        PlayerTurn = TurnTracker.Dequeue();
        PlayerTurn.StartTurn();
    }

    public bool IsLocalTurn()
    {
        return PlayerTurn.Equals(SessionHandler.Session["Player"]);
    }
}

using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class BattleInstance : BaseInstance {

    //Fields
    #region BattleInstance/Fields
    private BasePlayer _turn = new BasePlayer();
    private List<UnitBuildable> _units;
    private List<BuildingBuildable> _buildings;
    private Queue<BasePlayer> _turnTrack;
    private Camera _cam;
    #endregion

    //Properties
    #region BattleInstance/Properties
    public BasePlayer PlayerTurn { get { return _turn; } set { _turn = value; } }
    public List<UnitBuildable> Units { get { return _units; } set { _units = value; } }
    public List<BuildingBuildable> Buildings { get { return _buildings; } set { _buildings = value; } }
    public Queue<BasePlayer> TurnTracker { get { return _turnTrack; } set { _turnTrack = value; } }
    public Camera InstanceCamera { get { return _cam; } set { _cam = value; } }
    #endregion

    //Constructors
    #region BattleInstance/Constructors
    void Init()
    {
        InstanceCamera = (Camera)SessionHandler.GetSessionVariable(Enums.SessVars.Camera);
        SessionHandler.SetSessionVariable(Enums.SessVars.ActiveInst, this);
        Units = XMLHandler.LoadUnitBuildables();
        Buildings = XMLHandler.LoadBuildingBuildables();
        PlayerTurn = Players[0];
        TurnTracker = new Queue<BasePlayer>(Players.GetRange(1, Players.Count - 1));
        PlayerTurn.StartTurn();
        PlayerTurn.Units.Add(Units[0].ToControllable(PlayerTurn, new Dimension(0, 0)));
    }

    public BattleInstance() : base()
    {
        Init();
    }

    public BattleInstance(List<BasePlayer> p) : base(p)
    {
        Init();
        Map = BattleMap.RandomMap();
        InstanceCamera.transform.position = new Vector3(Map.DimensionX / 2, Map.DimensionY / 2, InstanceCamera.transform.position.z); 
    }

    public BattleInstance(BattleMap map, List<BasePlayer> p) : base(map, p)
    {
        Init();
    }
    #endregion

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
        return PlayerTurn.Equals(SessionHandler.GetSessionVariable(Enums.SessVars.LocalPlayer));
    }
}

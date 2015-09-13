using UnityEngine;
using System.Collections;

public class UnitBuildable : BaseBuildable {

    //Fields
    #region UnitBuildable/Fields
    private int _movRange;
    private int _visRange;
    private int _buildAt;
    private int _healthCap;
    private int _offStat;
    private int _defStat;
    private int _mainRange;
    #endregion

    //Properties
    #region UnitBuildable/Properties
    public int MoveRange { get { return _movRange; } set { _movRange = value; } }
    public int VisibilityRange { get { return _visRange; } set { _visRange = value; } }
    public int BuiltAt { get { return _buildAt; } set { _buildAt = value; } }
    public int HealthCapacity { get { return _healthCap; } set { _healthCap = value; } }
    public int OffenseStat { get { return _offStat; } set { _offStat = value; } }
    public int DefenseStat { get { return _defStat; } set { _defStat = value; } }
    public int MainActionRange { get { return _mainRange; } set { _mainRange = value; } }
    #endregion

    //Constructors
    #region UnitBuildable/Constructors
    public UnitBuildable() : base()
    {

    }
    #endregion

    public UnitControllable ToControllable(BasePlayer ownr, Dimension pos)
    {
        var unit = new UnitControllable(MoveRange, HealthCapacity, DefenseStat, OffenseStat, MainActionRange, VisibilityRange, ownr, Size, pos, Sprite, true);
        
        return unit;
    }
}

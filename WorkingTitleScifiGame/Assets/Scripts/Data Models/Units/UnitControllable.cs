using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class UnitControllable : BaseControllable {

    //Fields
    #region UnitControllable/Fields
    private int _movRange;
    private int _movStatus;
    private int _healthCap;
    private int _healthCurrent;
    private List<int> _modifiers;
    private int _defStat;
    private int _offStat;
    private int _mainRange;
    #endregion

    //Properties
    #region UnitControllable/Properties
    public int MoveRange { get { return _movRange; } set { _movRange = value; } }
    public int MoveStatus { get { return _movStatus; } set { _movStatus = value; } }
    public int HealthCapacity { get { return _healthCap; } set { _healthCap = value; } }
    public int HealthCurrent { get { return _healthCurrent; } set { _healthCurrent = value; } }
    public List<int> Modifiers { get { return _modifiers; } set { _modifiers = value; } }
    public int DefenseStat { get { return _defStat; } set { _defStat = value; } }
    public int OffenseStat { get { return _offStat; } set { _offStat = value; } }
    public int MainActionRange { get { return _mainRange; } set { _mainRange = value; } }
    #endregion

    //Constructors
    #region UnitControllable/Constructors
    public UnitControllable() : base()
    {
        
    }
    #endregion

    // Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    public void DealDamage(int damage)
    {
        try
        {
            HealthCurrent -= damage;
        }
        catch
        {

        }
    }

    private bool IsDestroyed()
    {
        return HealthCurrent <= 0;
    }

    private void OnDestroyed()
    {
        //DO THINGS THEN DESTROY OBJECT
        Destroy(this);
    }

    public bool CheckDestroyed()
    {
        if (IsDestroyed())
        {
            OnDestroyed();
            return true;
        }

        return false;
    }

    public void Move(Dimension destination, int distance)
    {
        try
        {
            Position = destination;
            MoveStatus -= distance;
        }
        catch
        {

        }
    }
}

using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class BasePlayer {

    //Fields
    #region BasePlayer/Fields
    private List<UnitControllable> _units;
    private List<BuildingControllable> _buildings;
    private int _resource;
    private string _id;
    private bool _end = true;
    #endregion 

    //Properties
    #region BasePlayer/Properties
    public List<UnitControllable> Units { get { return _units; } set { _units = value; } }
    public List<BuildingControllable> Buildings { get { return _buildings; } set { _buildings = value; } }
    public int Resource { get { return _resource; } set { _resource = value; } }
    public string Identifier { get { return _id; } set { _id = value; } }
    public bool EndTurn { get { return _end; } set { _end = value; } }
    #endregion

    public void FinishTurn()
    {
        EndTurn = true;
    }

    public void StartTurn()
    {
        EndTurn = false;
    }
}

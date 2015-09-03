using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class BattleInstance : BaseInstance {

    //Fields
    private BasePlayer _turn;

    //Properties
    public BasePlayer PlayerTurn { get { return _turn; } set { _turn = value; } }

    //Constructors
    public BattleInstance()
    {

    }

    public BattleInstance(List<BasePlayer> p) : base(p)
    {
        PlayerTurn = Players[0];
    }

	// Use this for initialization
	void Start () {
	    
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}

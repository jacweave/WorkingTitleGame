﻿using UnityEngine;
using System.Collections;

public class BattleInstance : BaseInstance {

    //Fields
    private BasePlayer _turn;

    //Properties
    public BasePlayer PlayerTurn { get { return _turn; } set { _turn = value; } }

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}

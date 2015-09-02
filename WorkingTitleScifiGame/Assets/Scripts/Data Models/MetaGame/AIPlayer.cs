using UnityEngine;
using System.Collections;

public class AIPlayer : BasePlayer {

    //Fields
    private int _difficulty;
    private int _strat;
    private int _surrCond;

    //Properties
    public int Difficulty { get { return _difficulty; } set { _difficulty = value; } }
    public int Strategy { get { return _strat; } set { _strat = value; } }
    public int SurrenderConditions { get { return _surrCond; } set { _surrCond = value; } }

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}

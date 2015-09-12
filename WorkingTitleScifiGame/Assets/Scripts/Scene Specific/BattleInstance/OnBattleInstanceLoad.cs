using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class OnBattleInstanceLoad : MonoBehaviour {

    private BattleInstance _instance;

    public BattleInstance Instance { get { return _instance; } set { _instance = value; } }

	// Use this for initialization
	void Start () {
        Instance = new BattleInstance(new List<BasePlayer> { (HumanPlayer)SessionHandler.GetSessionVariable("Player"), new AIPlayer() });
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}

using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class BaseInstance : MonoBehaviour
{
    //Fields
    #region BaseInstance/Fields
    private List<BasePlayer> _players;
    private BaseMap _map;
    #endregion

    //Properties
    #region BaseInstance/Properties
    public List<BasePlayer> Players { get { return _players; } set { _players = value; } }
    public BaseMap Map { get { return _map; } set { _map = value; } }
    #endregion

    //Constructors
    #region BaseInstance/Constructors
    public BaseInstance()
    {

    }

    public BaseInstance(List<BasePlayer> p)
    {
        Players = p;
        Map = BaseMap.RandomMap();
    }

    public BaseInstance(BaseMap m, List<BasePlayer> p)
    {
        Map = m;
        Players = p;
    }
    #endregion

    // Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}

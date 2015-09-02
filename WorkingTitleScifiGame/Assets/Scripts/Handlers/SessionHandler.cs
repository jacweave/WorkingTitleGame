using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class SessionHandler : MonoBehaviour {

    //Fields
    #region SessionHandler/Fields
    private static Dictionary<string, object> _session;
    #endregion

    //Properties
    #region SessionHandler/Properties
    public static Dictionary<string, object> Session { get { return _session; } set { _session = value; } }
    #endregion

    // Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    public static object GetSessionVariable(string key)
    {
        if (Session.ContainsKey(key))
        {
            return Session[key];
        }
        return null;
    }

    public static void SetSessionVariable(string key, object value)
    {
        Session.Add(key, value);
    }
}

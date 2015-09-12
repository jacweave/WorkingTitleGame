using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class SessionHandler {

    //Fields
    #region SessionHandler/Fields
    private static Dictionary<string, object> _session = new Dictionary<string, object> { { "Player", new HumanPlayer { Name = "Human", Units = new List<UnitControllable>(), Buildings = new List<BuildingControllable>(), Identifier = "1", Resource = 0 } } };
    #endregion

    //Properties
    #region SessionHandler/Properties
    public static Dictionary<string, object> Session { get { return _session; } set { _session = value; } }
    #endregion

    //Constructors
    #region SessionHandler/Constructors
    static SessionHandler()
    {
        Session = new Dictionary<string, object>();
    }
    #endregion

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

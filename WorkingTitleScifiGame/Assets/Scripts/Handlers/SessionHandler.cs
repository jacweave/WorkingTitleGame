using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class SessionHandler {

    //Fields
    #region SessionHandler/Fields
    private static Dictionary<Enums.SessVars, object> _session; 
    #endregion

    //Properties
    #region SessionHandler/Properties
    public static Dictionary<Enums.SessVars, object> Session { get { return _session; } set { _session = value; } }
    #endregion

    //Constructors
    #region SessionHandler/Constructors
    static SessionHandler()
    {
        Session = new Dictionary<Enums.SessVars, object> { { Enums.SessVars.LocalPlayer, new HumanPlayer { Name = "Human", Units = new List<UnitControllable>(), Buildings = new List<BuildingControllable>(), Identifier = "1", Resource = 0 } } };
    }
    #endregion

    public static object GetSessionVariable(Enums.SessVars key)
    {
        if (Session.ContainsKey(key))
        {
            return Session[key];
        }
        return null;
    }

    public static void SetSessionVariable(Enums.SessVars key, object value)
    {
        if (Session.ContainsKey(key))
        {
            Session[key] = value;
        }
        Session.Add(key, value);
    }
}

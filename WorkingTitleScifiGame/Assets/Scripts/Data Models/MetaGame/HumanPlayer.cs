using UnityEngine;
using System.Collections;

public class HumanPlayer : BasePlayer {

    //Fields
    private string _name;

    //Properties
    public string Name { get { return _name; } set { _name = value; } }
}

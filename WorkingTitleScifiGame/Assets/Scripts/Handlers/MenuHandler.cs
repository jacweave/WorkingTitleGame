using UnityEngine;
using UnityEngine.UI;

public class MenuHandler : MonoBehaviour {
    //protected GameObject MainMenuText, MultiPlayerMenuText, OptionsMenuText, SinglePlayerMenuText;
    //public Text myText;
    // Use this for initialization
    public void OnMouseDown()
    {
        if (name == "SinglePlayerBtn")
        {
            Application.LoadLevel("BattleInstance");
        }
    }
}

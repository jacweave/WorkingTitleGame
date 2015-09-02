using UnityEngine;
using UnityEngine.UI;

public class MouseOverEvent : MonoBehaviour
{

    public Text myText;

    void OnMouseOver()
    {
        myText.color = Color.red;
    }
    void OnMouseExit()
    {
        myText.color = Color.blue;
    }
    
}

using UnityEngine;
using System.Collections;

public class LoadNextScene : MonoBehaviour {



    void OnMouseDown()
    {
        if (this.name == "SinglePlayer")
        {
            Application.LoadLevel("SinglePlayer");
        }

        else if (this.name == "MainMenu")
        {
            Application.LoadLevel("MainMenu");
        }
    }
}

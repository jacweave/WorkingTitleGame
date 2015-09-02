using UnityEngine;
using System.Collections;

public class LoadNextMenu : MonoBehaviour {



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
        else if(this.name == "MultiPlayer")
        {
            Application.LoadLevel("MultiPlayerMenu");
        }
        else if(this.name == "Exit")
        {

            Application.Quit();
        }
    }
}
